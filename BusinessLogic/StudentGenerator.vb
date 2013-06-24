Public Class StudentGenerator

    Private m_numberStudents, m_idLength As Integer
    Private m_curriculumDistribution As New ArrayList
    Private m_dropoutRate As Double
    Private m_curriculumList As New ArrayList
    Private m_currentQuarter As String
    Private m_currentYear As Integer
    Private m_quartersToDropout As Integer
    Private m_randomClassSelection As Boolean
    Private m_classesPerQuarter As Integer
    Private rng As New Random

    'db necessary to generate enrollments for students
    Private m_curriculumdb As Collection
    Private m_coursedb As Collection

    Private m_schedulelist As New Collection
    Property SchedulesGenerated As Collection

        Get
            Return m_schedulelist
        End Get
        Set(ByVal value As Collection)

        End Set
    End Property


    ''' <summary>
    ''' Student generator objects needs curriculum and course databases to generate students. Default initial values are loaded during object construction,
    ''' values can be changed by changing properties.
    ''' </summary>
    ''' <param name="curricdb"></param>
    ''' <param name="coursedb"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal curricdb As Collection, ByVal coursedb As Collection)
        m_idLength = 6
        m_numberStudents = 100
        m_curriculumdb = curricdb
        m_coursedb = coursedb
        m_dropoutRate = 0
        m_currentQuarter = "Spring"
        m_currentYear = 2013
        m_quartersToDropout = 3
        m_randomClassSelection = True
        m_classesPerQuarter = 4
        'create values for distribution
        ''generate list of curriculums
        For Each c As Curriculum In curricdb
            m_curriculumList.Add(c)
            m_curriculumDistribution.Add(1.0 / curricdb.Count)
        Next

        Dim tempyear As Integer = m_curriculumList.Item(0).ID
        Dim tempquarter As String = "WINTER"
        While (Not isEqualToOrGreaterThanCurrentQuarterAndYear(tempquarter, tempyear))
            m_schedulelist.Add(New Schedule(tempquarter + "-" + tempyear.ToString, tempyear, tempquarter), tempquarter + "-" + tempyear.ToString)
            incrementQuarterCount(tempquarter, tempyear)
        End While

    End Sub

    Public Function generateStudents() As ArrayList
        'validate parameters first
        Dim studentList As New ArrayList(m_numberStudents)
        Dim studentCounter As Integer = 0
        'generate id
        While (studentCounter < m_numberStudents)
            Dim tempid As String = generateCode()
            While (isDuplicateID(studentList, tempid))
                tempid = generateCode()
            End While
            Dim tempstudent As New Student
            tempstudent.ID = tempid
            tempstudent.Name = generateRandomName()
            studentList.Add(tempstudent)
            studentCounter += 1
        End While

        'add curriculums to student (default random enroll quarter with weight on fall)
        studentCounter = 0
        Dim distmilestones(m_curriculumDistribution.Count - 1) As Integer
        Dim counter As Integer = 0
        For Each value As Double In m_curriculumDistribution
            If (counter = 0) Then
                distmilestones.SetValue(CInt(value * m_numberStudents), counter)
            Else
                distmilestones.SetValue(CInt(value * m_numberStudents) + distmilestones(counter - 1), counter)
            End If
            counter += 1
        Next
        For Each tempstudent As Student In studentList
            For counter = distmilestones.Length - 1 To 0 Step -1
                If (studentCounter < distmilestones(counter)) Then
                    'assign curriculum to use for this distribution on student
                    tempstudent.CurrentCurriculum = m_curriculumList.Item(counter)
                    tempstudent.EnrolledQuarter = generateRandomStartQuarter()
                    tempstudent.EnrolledYear = Integer.Parse(tempstudent.CurrentCurriculum.ID)
                End If
            Next
            'assign last curriculum as failsafe
            If (tempstudent.EnrolledQuarter Is Nothing) Then
                tempstudent.CurrentCurriculum = m_curriculumList.Item(m_curriculumList.Count - 1)
                tempstudent.EnrolledQuarter = "FALL"
                tempstudent.EnrolledYear = Integer.Parse(tempstudent.CurrentCurriculum.ID)
            End If
            studentCounter += 1
        Next

        'mark dropout students
        Dim dropoutstudents As New ArrayList
        Dim studentsToDrop As Integer = m_dropoutRate * m_numberStudents
        Dim rng As New Random
        'failsafe against infinite loop
        If (studentsToDrop > studentList.Count) Then
            studentsToDrop = studentList.Count
        End If
        For dropcounter As Integer = 1 To studentsToDrop Step 1
            Dim tempindex As Integer = rng.Next() Mod studentList.Count
            While (isDuplicateID(dropoutstudents, studentList.Item(tempindex).ID) Or Not validDropout(studentList.Item(tempindex)))
                tempindex = rng.Next() Mod studentList.Count
            End While
            dropoutstudents.Add(studentList.Item(tempindex))
        Next

        'add courses to each student(default behavior is random 1 to 4 classes per quarter)
        For Each stud As Student In studentList
            'Dim totalquarters As Integer = calcQuatertersTaken(stud)
            If (dropoutstudents.Contains(stud)) Then
                For dropcounter As Integer = 1 To m_quartersToDropout
                    decrementQuarterCount(m_currentQuarter, m_currentYear)
                Next
            End If
            'For quartercounter As Integer = 0 To calcQuatertersTaken(stud) Step 1
            Dim quartercount As String = stud.EnrolledQuarter
            Dim yearcount As Integer = stud.EnrolledYear
            While (Not isEqualToOrGreaterThanCurrentQuarterAndYear(quartercount, yearcount))
                Dim coursestaking As Integer = m_classesPerQuarter - 1
                If (m_randomClassSelection) Then
                    coursestaking = (rng.Next Mod 3)
                End If

                For classcounter As Integer = 0 To coursestaking Step 1
                    If (Not hasGraduated(stud)) Then


                        Dim tempsection As Section = generateRandomSection(stud.CurrentCurriculum)
                        While (Not isValidSection(stud, tempsection))
                            tempsection = generateRandomSection(stud.CurrentCurriculum)
                        End While
                        'add more detail to section before adding to enrollment and sched list
                        tempsection.ScheduleID = quartercount + "-" + yearcount.ToString
                        tempsection.SectionID = tempsection.CourseID + "-0"
                        tempsection.Days = "M, W, F"
                        tempsection.StartTime = TimeSpan.Parse("8:00")
                        If (m_schedulelist.Item(tempsection.ScheduleID).SectionCollection.contains(tempsection.CourseID + "-0")) Then
                            tempsection.Days = m_schedulelist.Item(tempsection.ScheduleID).SectionCollection.Item(tempsection.CourseID + "-0").Days
                            tempsection.StartTime = m_schedulelist.Item(tempsection.ScheduleID).SectionCollection.Item(tempsection.CourseID + "-0").StartTime
                            m_schedulelist.Item(tempsection.ScheduleID).SectionCollection.Item(tempsection.CourseID + "-0").addStudentID(stud.ID)
                        Else
                            tempsection.Days = generateRandomDay
                            tempsection.StartTime = generateRandomTime(tempsection.Days)
                            m_schedulelist.Item(tempsection.ScheduleID).addSection(tempsection)
                        End If

                        stud.addCourseTakenWithGradeAndDate(tempsection, generateRandomGrade, yearcount, quartercount)
                    End If
                Next
                incrementQuarterCount(quartercount, yearcount)
            End While
            If (dropoutstudents.Contains(stud)) Then
                For dropcounter As Integer = 1 To m_quartersToDropout
                    incrementQuarterCount(m_currentQuarter, m_currentYear)
                Next
            End If
        Next


        Return studentList
    End Function

    Property NumberOfStudents As Integer
        Get
            Return m_numberStudents
        End Get
        Set(ByVal value As Integer)
            m_numberStudents = value
        End Set
    End Property

    Property DropoutRate As Double
        Get
            Return m_dropoutRate
        End Get
        Set(ByVal value As Double)
            m_dropoutRate = value
        End Set
    End Property

    Property ClassesPerQuarter As Integer
        Get
            Return m_classesPerQuarter
        End Get
        Set(ByVal value As Integer)
            m_classesPerQuarter = value
        End Set
    End Property

    Property CurrentQuarter As String
        Get
            Return m_currentQuarter
        End Get
        Set(ByVal value As String)
            m_currentQuarter = value
        End Set
    End Property

    Property CurrentYear As String
        Get
            Return m_currentYear
        End Get
        Set(ByVal value As String)
            m_currentYear = value
        End Set
    End Property

    Property RandomClassesPerQuarter As Boolean
        Get
            Return m_randomClassSelection
        End Get
        Set(ByVal value As Boolean)
            m_randomClassSelection = value
        End Set
    End Property

    Property CurriculumDistribution As ArrayList
        Get
            Return m_curriculumDistribution
        End Get
        Set(ByVal value As ArrayList)
            m_curriculumDistribution = value
        End Set
    End Property

    Private Function generateCode() As String
        Dim code As String = ""
        Dim counter As Integer = 0
        While (counter < m_idLength)
            code += generateRandomAlphaNumeric()
            counter += 1
        End While

        Return code
    End Function

    Private Function isDuplicateID(ByVal studentlist As ArrayList, ByVal id As String) As Boolean
        For Each Student As Student In studentlist
            If (Student.ID = id) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function generateRandomAlphaNumeric() As Char
        Dim temp As Integer = rng.Next() Mod 2
        If (False) Then
            Return Chr((rng.Next() Mod 26) + 97)
        Else
            Return Chr((rng.Next() Mod 10) + 48)
        End If
    End Function

    Private Function generateRandomSection(ByVal curric As Curriculum) As Section
        Dim tempcourselist As New ArrayList
        Dim mysection As New Section
        For Each cid As String In curric.ElectiveCourses.Courses
            tempcourselist.Add(cid)
        Next

        For Each cid As String In curric.RequiredCoreCourses.Courses
            tempcourselist.Add(cid)
        Next

        For Each cid As String In curric.RequiredGECourses.Courses
            tempcourselist.Add(cid)
        Next

        mysection.CourseID = tempcourselist.Item(rng.Next() Mod tempcourselist.Count)
        Return mysection
    End Function

    Private Function isValidSection(ByVal student As Student, ByVal section As Section) As Boolean
        'check empty
        If (section.CourseID Is Nothing) Then
            Return False
        End If


        'check taken
        For Each enroll As Enrollment In student.SectionsTaken
            If (enroll.SectionTaken.CourseID = section.CourseID) Then
                If (enroll.Grade = "A" Or enroll.Grade = "B" Or enroll.Grade = "C") Then
                    Return False
                End If
            End If
        Next
        'check prereqs
        'Dim prereqs As ArrayList = m_coursedb.Item(section.CourseID).PreRequisitCourse
        Dim prereqs As ArrayList = generatePrereqs(section.CourseID)
        Dim tempcourselist As New ArrayList
        For Each enroll As Enrollment In student.SectionsTaken
            tempcourselist.Add(enroll.SectionTaken.CourseID)
        Next
        For Each cid As String In prereqs
            If ((Not tempcourselist.Contains(cid)) And Not cid = Nothing) Then
                Return False
            End If
        Next

        Return True
    End Function

    'Private Function calcQuatertersTaken(ByVal stud As Student) As Integer
    '    Dim value As Integer = 0
    '    Dim currqval As Integer = 0
    '    Dim qval As Integer = 0
    '    If(stud.EnrolledQuarter.ToUpper = "FALL") Then
    '        qval = 0
    '        ElseIf(stud.EnrolledQuarter.ToUpper = "WINTER") Then
    '        qval = 1
    '        ElseIf(stud.EnrolledQuarter.ToUpper = "SPRING") Then
    '        qval = 2
    '    End If

    '    If(m_currentQuarter.ToUpper = "FALL") Then
    '        currqval = 0
    '        ElseIf(m_currentQuarter.ToUpper = "WINTER") Then
    '        currqval = 1
    '        ElseIf(m_currentQuarter.ToUpper = "SPRING") Then
    '        currqval = 2
    '    End If

    '    value = (m_currentYear - stud.EnrolledYear) + (currqval - qval)

    '    Return value
    'End Function

    Private Function generateRandomGrade() As String
        Dim temp As Integer = rng.Next Mod 100
        Select Case temp
            Case 0 to 19
                Return "A"
            Case 20 to 49
                Return "B"
            Case 50 to 89
                Return "C"
            Case 90 to 96
                Return "D"
            Case Else
                Return "F"
        End Select
    End Function

    ''only works if students only start in fall
    'Private Function calcQuarter(ByVal currentCounter As Integer) As String
    '    Select Case currentCounter mod 3
    '        Case 0
    '            Return "FALL"
    '        Case 1
    '            Return "WINTER"
    '        Case Else
    '            Return "SPRING"
    '    End Select
    'End Function

    'Private Function calcYear(ByVal currentCounter As Integer, ByVal stud As Student) As Integer
    '    Dim value As Integer = stud.EnrolledYear
    '    value += currentCounter / 3

    '    Return value
    'End Function

    Private Function isEqualToOrGreaterThanCurrentQuarterAndYear(ByVal quarter As String, ByVal year As Integer) As Boolean
        If (year >= m_currentYear And isEqualToOrGreaterThanCurrentQuarter(quarter)) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub incrementQuarterCount(ByRef quarter As String, ByRef year As Integer)
        Dim tempquarter As String = ""

        Select Case quarter
            Case "FALL"
                tempquarter = "WINTER"
                year += 1
            Case "WINTER"
                tempquarter = "SPRING"
            Case "SPRING"
                tempquarter = "FALL"

        End Select
        quarter = tempquarter
    End Sub

    Private Sub decrementQuarterCount(ByRef quarter As String, ByRef year As Integer)
        Dim tempquarter As String = ""

        Select Case quarter
            Case "FALL"
                tempquarter = "SPRING"
            Case "WINTER"
                tempquarter = "FALL"
                year -= 1
            Case "SPRING"
                tempquarter = "WINTER"

        End Select
        quarter = tempquarter
    End Sub

    Private Function isEqualToOrGreaterThanCurrentQuarter(ByVal quarter As String) As Boolean
        Select Case quarter
            Case "FALL"
                Return True
            Case "WINTER"
                If (m_currentQuarter = "WINTER") Then
                    Return True
                Else
                    Return False
                End If
            Case "SPRING"
                If (m_currentQuarter = "WINTER" Or m_currentQuarter = "SPRING") Then
                    Return True
                Else
                    Return False
                End If
            Case Else
                Return False
        End Select
    End Function

    Private Function generatePrereqs(ByVal cid As String) As ArrayList
        Dim prereqs As ArrayList
        If (cid = Nothing) Then
            prereqs = New ArrayList
            Return prereqs
        End If

        If (m_coursedb.Contains(cid) And Not m_coursedb.Item(cid).PreRequisitCourse.Contains(Nothing)) Then
            prereqs = m_coursedb.Item(cid).PreRequisitCourse
            'For Each preq As String In prereqs
            '    If( Not preq = Nothing)
            '        Dim tempreqs As ArrayList = generatePrereqs(preq)
            '        For Each p As String In tempreqs
            '            If(Not p = Nothing)
            '                prereqs.Add(p)
            '            End If                      
            '        Next
            '    End If
            'Next


        Else
            prereqs = New ArrayList
        End If



        Return prereqs
    End Function

    Private Function generateRandomName() As String
        Dim firstnames = New String() {"Florence", "Dan", "Toni", "Philip", "Renee", "Caroline", "Sally", "Stacy", "Sharon", "Dorothy", "Annie", "Dwight", "Vivian", "Tom", "Gwendolyn", "Phillip", "Jane", "Kristin", "Steven", _
"Neil", "Marcia", "Becky", "Priscilla", "Keith", "Billy", "Dolores", "Leo", "Annie", "Joyce", "Carmen", "Pauline", "Fred", "Vicki", "Carlos", "Fred", "Valerie", "Christine", _
"Dwight", "Danielle", "Vincent", "Claude", "Patricia", "Guy", "Kathleen", "Tonya", "Sean", "Kevin", "Alan", "Marie", "Andrew", "Jacqueline", "Ethel", "Emily", "Edwin", _
"Holly", "Ashley", "Larry", "Ted", "Paula", "Wade", "Kimberly", "Maureen", "Phyllis", "Francis", "Gary", "Ellen", "Geoffrey", "Jason", "Christian", "Nina", "Michele", _
"Jason", "Ruby", "Renee", "Peter", "Clarence", "Janet", "Hugh", "Marcia", "Paige", "Rodney", "Sara", "Martin", "Dorothy", "Clarence", "Cecil", "Elisabeth", "Lauren", _
"Glenda", "Jay", "Sarah", "Joan", "Dolores", "Mary", "Nathan", "Linda", "Judy", "Kay", "Wallace", "Steve", "Arnold", "Anne", "Meredith", "Lori", "Maureen", "Sean", _
"Lindsay", "Steven", "Jim", "Vickie", "Elizabeth", "Zachary", "Sheryl", "Jenny", "Beverly", "Joel", "Craig", "Martha", "Rosemary", "Stacey", "Yvonne", "Don"}
        Dim lastnames = New String() {"Knight", "Nelson", "Clements", "Duke", "Levine", "Bennett", "Martin", "Ramsey", "Curtis", "Wilkerson", "Miller", "Cash", "Daniels", "Levin", "Ford", "Simmons", _
"Golden", "Hernandez", "Simpson", "Ross", "Alston", "Cole", "Walsh", "Koch", "Harding", "Young", "Davies", "Carr", "Carver", "Joyner", "Feldman", "McPherson", _
"Burnett", "Meyer", "Kramer", "Conway", "Harding", "Hartman", "Taylor", "Harrison", "McDaniel", "Gay", "Braswell", "Craig", "Reynolds", "Boyer", _
"O'Connor", "Burnette", "Wright", "Harris", "Doyle", "Holden", "French", "Woodward", "Sawyer", "Rose", "Bland", "Moran", "Hensley", "Harvey", "Sparks", _
"Cain", "Hurley", "Alston", "Vaughan", "Fox", "Meyer", "Marsh", "Holder", "Case", "Desai", "Law", "Todd", "Vogel", "Carpenter", "Pearce", "Stuart", "Miller", _
"Barnett", "Pollard", "Wilkerson", "Raynor", "Bernstein", "McConnell", "Walker", "Coates", "Barnes", "Sigmon", "Weeks", "Keith", "Herring", "Branch", _
"Cooper", "Payne", "Langley", "Mercer", "Dawson", "Paul", "Matthews", "Schwartz", "McCarthy", "Stern", "Norton", "Collier", "Adkins", "Boyer", "Gibbons", _
"Cobb", "Lu", "Miles", "Joyce", "Sweeney", "McKenzie", "Potter", "Bowles", "Terry", "Shaffer", "Stephens", "Hayes", "Pollard", "Allred", "Brandt", "Lawson", _
"Ballard", "McCormick", "Stark"}
        Dim name As String = ""

        name += firstnames(rng.Next Mod firstnames.Length) + " " + lastnames(rng.Next Mod lastnames.Length)

        Return name
    End Function

    Private Function generateRandomStartQuarter() As String
        Dim choice As Integer = rng.Next Mod 100
        Select Case choice
            Case 0 To 19
                Return "WINTER"
            Case 20 To 39
                Return "SPRING"
            Case Else
                Return "FALL"
        End Select
    End Function

    Private Function validDropout(ByVal stud As Student) As Boolean
        Dim check As Boolean
        For dropcounter As Integer = 1 To m_quartersToDropout
            incrementQuarterCount(stud.EnrolledQuarter, stud.EnrolledYear)
        Next
        check = Not isEqualToOrGreaterThanCurrentQuarterAndYear(stud.EnrolledQuarter, stud.EnrolledYear)
        For dropcounter As Integer = 1 To m_quartersToDropout
            decrementQuarterCount(stud.EnrolledQuarter, stud.EnrolledYear)
        Next
        Return check
    End Function

    Private Function hasGraduated(ByVal st As Student) As boolean
        Dim isGraduated As Boolean = True
        Dim passedClasses As New ArrayList

        For Each enroll As Enrollment In st.SectionsTaken
            If (enroll.Grade = "A" Or enroll.Grade = "B" Or enroll.Grade = "C") Then
                passedClasses.Add(enroll.SectionTaken.CourseID)
            End If
        Next

        Dim tempcourselist As New ArrayList
        Dim tempelectivelist As New ArrayList

        For Each cid As String In st.CurrentCurriculum.RequiredGECourses.Courses
            tempcourselist.Add(cid)
        Next

        For Each cid As String In st.CurrentCurriculum.RequiredCoreCourses.Courses
            tempcourselist.Add(cid)
        Next

        For Each cid As String In st.CurrentCurriculum.ElectiveCourses.Courses
            tempelectivelist.Add(cid)
        Next

        Dim passedAllClasses As Boolean = True
        For Each coid As String In tempcourselist
            If (passedAllClasses) Then
                passedAllClasses = passedClasses.Contains(coid)
            End If
        Next

        Dim unitcount As Integer = 0
        For Each coid As String In tempelectivelist
            If (tempelectivelist.Contains(coid)) Then
                unitcount += 4 'assume all electives worth 4 units
            End If

        Next
        Dim passedelectives As Boolean = False
        If unitcount >= st.CurrentCurriculum.ElectiveUnitsRequired Then
            passedelectives = True
        End If

        isGraduated = (passedAllClasses And passedelectives)

        Return isGraduated
    End Function

    Private Function generateRandomDay() As String
        Dim randint As Integer = rng.Next mod 2
        Select Case randint
            Case 0
                Return "M, W, F"
            Case Else
                Return "T, TH"
        End Select


    End Function

    Private Function generateRandomTime(ByVal day As String)
        Dim randint As Integer = rng.Next mod 8
        Dim addtime As TimeSpan
        Dim starttime As TimeSpan = TimeSpan.Parse("8:00")

        If(day = "M, W, F")
            addtime = TimeSpan.Parse("1:00")
            Else
            addtime = TimeSpan.Parse("1:30")
        End If

        For count As Integer = 0 to randint
            starttime = starttime.Add(addtime)
        Next

        Return starttime

    End Function

End Class
