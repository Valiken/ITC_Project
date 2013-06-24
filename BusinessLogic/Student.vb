''' <summary>
''' This class represents a student enrolled in the university
''' </summary>
Public Class Student

    Private m_ID, m_Name, m_enrolledQuarter As String
    Private m_enrolledYear As Integer
    Private m_ExpectedGraduation As Date = Now
    Private m_CurrentStudent As Boolean = False
    Private m_coursesTaken As New Collection
    Private m_curriculum As Curriculum
    Private m_courses As New ArrayList

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String,
            ByVal enrolledYear As String, ByVal enrolledQuarter As String, ByVal currentStudent As Boolean) ' Optional ByVal expectedGraudationDate As Date = Now
        Me.ID = id
        Me.Name = name
        Me.EnrolledYear = enrolledYear
        Me.EnrolledQuarter = enrolledQuarter
        Me.CurrentStudent = currentStudent
    End Sub

    Public Sub New(ByVal id As String, ByVal name As String,
            ByVal enrolledYear As String, ByVal enrolledQuarter As String, ByVal currentStudent As Boolean, ByVal currentCurriculum As Curriculum) ' Optional ByVal expectedGraudationDate As Date = Now
        Me.ID = id
        Me.Name = name
        Me.EnrolledYear = enrolledYear
        Me.EnrolledQuarter = enrolledQuarter
        Me.CurrentStudent = currentStudent
        Me.CurrentCurriculum = currentCurriculum
    End Sub


    Public Property ID As String
        Get
            Return m_ID
        End Get
        Set(ByVal value As String)
            m_ID = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property

    Public Property EnrolledQuarter As String
        Get
            Return m_enrolledQuarter
        End Get
        Set(ByVal value As String)
            m_enrolledQuarter = value
        End Set
    End Property

    Public Property EnrolledYear As Integer
        Get
            Return m_enrolledYear
        End Get
        Set(ByVal value As Integer)
            m_enrolledYear = value
        End Set
    End Property

    Public Property ExpectedGraduationDate As Date
        Get
            Return m_ExpectedGraduation
        End Get
        Set(ByVal value As Date)
            m_ExpectedGraduation = value
        End Set
    End Property
    Public Property CurrentStudent As Boolean
        Get
            Return m_CurrentStudent
        End Get
        Set(ByVal value As Boolean)
            m_CurrentStudent = value
        End Set
    End Property

    Public Property Courses As Collection
        Get
            Return m_coursesTaken
        End Get
        Set(ByVal value As Collection)
            m_coursesTaken = value
        End Set
    End Property


    Public Property CurrentCurriculum As Curriculum
        Get
            Return m_curriculum
        End Get
        Set(ByVal value As Curriculum)
            m_curriculum = value
        End Set
    End Property

    Public Property SectionsTaken As ArrayList

        Get
            Return m_courses
        End Get
        Set

        End Set
    end property

    Public Sub addCourse(ByVal section As Section)
        m_courses.Add(New Enrollment(section))
    End Sub

     Public Sub addCourseTakenWithGrade(ByVal section As Section, ByVal grade As String)
        m_courses.Add(New Enrollment(section, grade))
    End Sub

    Public Sub addCourseTakenWithGradeAndDate(ByVal section As Section, ByVal grade As String, byval year As String, byVal quarter as String)
        If Not m_courses.Count = 0 Then
            m_courses.Add(New Enrollment(section, grade, year, quarter))
        Else
            EnrolledQuarter = quarter
            EnrolledYear = year
            m_courses.Add(New Enrollment(section, grade, year, quarter))
        End If

    end sub


    Function calculateGPA()

        Dim finalGradePoints As Double = 0.0
        Dim gradePoints As Double = 0.0
        Dim classGradePoints As Double = 0.0
        Dim unitsTaken As Double = 0.0
        Dim totalUnitsTaken As Double = 0.0
        Dim GPA As Double
        Dim enrollment As New Enrollment

        For Each enrollment In SectionsTaken

            'Assign value to letter grade
            gradePoints = calculateGradePoints(enrollment.Grade)

            'Get course and then get the units for the course
            unitsTaken = getUnitsTaken()

            'Calculate the grade points earned for the class
            classGradePoints = gradePoints * CDbl(unitsTaken)

            'Update the counters for total units taken and final grade points
            totalUnitsTaken += unitsTaken
            finalGradePoints += classGradePoints
        Next

        'Calculate GPA and display to 3 decimal places
        GPA = Math.Round((finalGradePoints / totalUnitsTaken), 3)

        Return GPA.ToString()

    End Function

    'Determine class standing based on total units taken; returns String
    Function getClassStanding()

        Dim classStanding As String
        Dim unitsTaken As Double = getUnitsTaken()

        Select Case CInt(unitsTaken)
            Case Is > 134
                classStanding = "Senior"
            Case 90 To 134
                classStanding = "Junior"
            Case 45 To 89
                classStanding = "Sophomore"
            Case 0 To 44
                classStanding = "Freshman"
            Case Else
                classStanding = "Invalid unit count"
        End Select

        Return classStanding
    End Function

    'Determine grade points based on letter grade; returns Double
    Function calculateGradePoints(ByVal grade As String)

        Dim gradePoints As Double = 0.0

        'Assign value to letter grade
        Select Case grade
            Case "A"
                gradePoints = 4.0
            Case "A-"
                gradePoints = 3.7
            Case "B+"
                gradePoints = 3.33
            Case "B"
                gradePoints = 3.0
            Case "B-"
                gradePoints = 2.7
            Case "C+"
                gradePoints = 2.3
            Case "C"
                gradePoints = 2.0
            Case "C-"
                gradePoints = 1.7
            Case "D+"
                gradePoints = 1.3
            Case "D"
                gradePoints = 1.0
            Case "D-"
                gradePoints = 0.7
            Case "F"
                gradePoints = 0
            Case "W"
                gradePoints = 0
        End Select

        Return gradePoints

    End Function

    Function getUnitsTaken()
        Dim unitsTaken As Double = 0.0
        Dim course As New Course
        Dim enrollment As New Enrollment
        Dim courseDB As Collection = Controller.getCourseDB()

        For Each enrollment In SectionsTaken
            If enrollment.SectionTaken.CourseID IsNot Nothing Then
                course = courseDB.Item(enrollment.SectionTaken.CourseID)
                unitsTaken += course.Units
            End If
        Next

        Return unitsTaken
    End Function

    'Determine the minimum quarters left to graduate; returns String
    Function getMinimumQuartersLeft()
        Dim minimumQuartersLeft As Double = 0.0
        Dim electiveCoursesRemaining As Double = 0.0
        Dim coursesLeftList As ArrayList = New ArrayList()
        Dim electiveUnitsRemaining As Integer = CurrentCurriculum.ElectiveUnitsRequired
        Dim course As New Course
        Dim enrollment As New Enrollment
        Dim courseDB As Collection = Controller.getCourseDB()
        Dim requiredCoreCoursesList As ArrayList = CurrentCurriculum.RequiredCoreCourses.Courses
        Dim requiredGECoursesList As ArrayList = CurrentCurriculum.RequiredGECourses.Courses
        Dim electiveCoursesList As ArrayList = CurrentCurriculum.ElectiveCourses.Courses
        Dim courseID As String
        Dim totalCoursesLeft As Integer = 0
        Dim totalElectiveCoursesLeft As Integer = 0

        For Each courseID In requiredCoreCoursesList
            coursesLeftList.Add(courseID)
        Next

        For Each courseID In requiredGECoursesList
            coursesLeftList.Add(courseID)
        Next

        For Each enrollment In SectionsTaken
            'check if any courses in the coursesLeftList have grades
            If coursesLeftList.Contains(enrollment.SectionTaken.CourseID) Then
                'if grade is not passing, then it still must be taken
                If enrollment.Grade Is Nothing Or calculateGradePoints(enrollment.Grade) <= 1.7 Then
                    totalCoursesLeft += 1
                    'Else.. it must be a completed class
                Else
                    'check if that class is an elective class, if so.. subtract 4 units from the elective units remaining (all electives are 4 units)
                    If electiveCoursesList.Contains(enrollment.SectionTaken.CourseID) Then
                        electiveUnitsRemaining -= 4
                    End If
                End If
            End If
        Next

        If electiveUnitsRemaining <= 0 Then
            electiveUnitsRemaining = 0
        ElseIf electiveUnitsRemaining > 0 Then
            totalElectiveCoursesLeft = electiveUnitsRemaining / 4
        End If

        totalCoursesLeft += totalElectiveCoursesLeft

        'minimumQuartersLeft = totalCoursesLeft / CDbl(Integer.Parse(DataGenerator.nudClassesPerQuarter.Value))
        minimumQuartersLeft = totalCoursesLeft / 4 'temp fix to breaking MVC
        minimumQuartersLeft = Math.Ceiling(minimumQuartersLeft)

        Return minimumQuartersLeft.ToString

    End Function

    Function getExpectedGraduationDate()

        Dim expectedGraduationYear As Integer = Integer.Parse(CurrentCurriculum.ID) + 4

        Return expectedGraduationYear
    End Function

End Class
