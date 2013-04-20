Imports System.ComponentModel

Public Class CurriculumMetericView

    'in class variables for handling data generation 
    Private m_graduatedStudents, m_droppedStudents As String
    Private m_curriculum As String
    Private m_maxUnits, m_minUnits, m_avgUnits, m_unitsLeft As String ' for unit metrics 
    Private m_maxTime, m_minTime, m_avgTime As String ' for time metrics 

    'For displaying class information in the class metrics view
    Dim courses As Collection = Controller.getCourseDB
    Dim courseList As New List(Of Course)
    Dim tempCourse As New Course
    Dim enrollment As New Enrollment

    Dim enrollmentList As New List(Of Enrollment)

    'For displaying information about students from their curriculums
    Dim students As Collection = Controller.getStudentDB
    Dim studentList As New List(Of Student)
    Dim tempStudent As New Student
    Dim unitsTaken As New ArrayList
    Dim quartersAttended As New ArrayList

    'For dispalying curriculum centric data
    Dim curriculums As Collection = Controller.getCurriculumDB
    Dim curriculumList As New List(Of Curriculum)
    Dim tempCurriculum As New Curriculum

    'handles events that occur during the view load 
    Public Sub CurriculumMetericView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'hides the classBox and then also changes the titles depending on the selected curriculum
        ClassBox.Hide()
        lblMetricsTitle.Text = m_curriculum + " Metrics"
        lblCurriculumTitle.Text = m_curriculum + " Curriculum"

        'generate a list of curriculums
        For Each Me.tempCurriculum In curriculums
            cmbxCurriclum.Items.Add(tempCurriculum.ID)
            curriculumList.Add(tempCurriculum)
        Next

        For Each tempStudent In students
            studentList.Add(tempStudent)
        Next
    End Sub

    'handles user changes to the selected curriculum year 
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCurriclum.SelectedIndexChanged

        'functions and stuff
        titleChanges()
        populateCurriculums()
        graduatedStudents()
        Units()
        time()
        avgUnitsRemaining()
        calcedDropped()
        totalStudents()

    End Sub 

    'handles user selection of different classes in the curriculum
    Private Sub lbxCurriculum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCurriculum.SelectedIndexChanged
        
        'displays the class box after class is selected
        ClassBox.Show()

        'changes the classbox label
        ClassBox.Text = courseList(lbxCurriculum.SelectedIndex).ID

        'updates the unit label to display class units
        lblUnit.Text = "Units: " + courseList(lbxCurriculum.SelectedIndex).Units.ToString

        'For each loop for displaying the prerequisite classes 
        lblPrereq.Text = "Prerequite(s): "
        For Each PreRequisitCourse As String In courseList(lbxCurriculum.SelectedIndex).PreRequisitCourse()
            lblPrereq.Text += PreRequisitCourse + " "
        Next

        'displays the companion courses for a class 
        lblCompanion.Text = "Companion Course(s): " + courseList(lbxCurriculum.SelectedIndex).CompanionCourse

    End Sub 

    'Used to change the curriculum view titles 
    Public Sub titleChanges()
        'updating the titles 
        m_curriculum = curriculumList(cmbxCurriclum.SelectedIndex).ID
        lblMetricsTitle.Text = m_curriculum + " Metrics"
        lblCurriculumTitle.Text = m_curriculum + " Curriculum"

    End Sub 'working so far  

    'populates the curriculum
    Public Sub populateCurriculums()
        
        'resets the listbox for classes in a curriculum
        lbxCurriculum.Items.Clear()
        
        'These for loops go through and add the different classes into the curriculum view 
        For Each cid As String In tempCurriculum.ElectiveCourses.Courses
            tempCourse.ID = cid
            lbxCurriculum.Items.Add(tempCourse.ID)
            courseList.Add(courses.Item(tempCourse.ID))
        Next

        For Each cid As String In tempCurriculum.RequiredCoreCourses.Courses
            tempCourse.ID = cid
            lbxCurriculum.Items.Add(tempCourse.ID)
            courseList.Add(courses.Item(tempCourse.ID))
        Next

        For Each cid As String In tempCurriculum.RequiredGECourses.Courses
            tempCourse.ID = cid
            lbxCurriculum.Items.Add(tempCourse.ID)
            courseList.Add(courses.Item(tempCourse.ID))
        Next

    End Sub 'working so far 

    Public Sub graduatedStudents()
        Dim gradCounter As Integer = 0
        For Each std As Student In studentList
            If std.CurrentCurriculum.ID = curriculumList(cmbxCurriclum.SelectedIndex).ID Then
                If hasGraduated(std) = True Then
                    gradCounter += 1
                End If
            End If
        Next
        m_graduatedStudents = gradCounter.ToString
        lblGrad.Text = "Graduated Students: " + m_graduatedStudents
    End Sub

    'For calculating graduated students per curriculum 
    Public Function hasGraduated(ByVal st As Student) As Boolean
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

    'For calculating dropped students per curriculum 
    Public Sub calcedDropped()
        Dim saveNow As DateTime = DateTime.Now
        Dim quarterArray As New ArrayList
        Dim totalQuarterArray As New ArrayList
        Dim droppedCount As Integer = 0
        Dim yr As New Enrollment
        For Each std As Student In studentList
            If std.CurrentCurriculum.ID = curriculumList(cmbxCurriclum.SelectedIndex).ID Then
                quarterArray.Add(std.SectionsTaken)
            End If
        Next

        For Each enrollarray As ArrayList In quarterArray
            If enrollarray.Count - 1 >= 0 Then
                yr = enrollarray.Item(enrollarray.Count - 1)
                If Integer.Parse(saveNow.Year.ToString) - Integer.Parse(yr.Year.ToString) > 0 Then
                    droppedCount += 1
                End If
            Else

            End If
        Next
        Dim dc As String = droppedCount.ToString

        m_droppedStudents = dc

        lblDropOut.Text = "Dropped Out: " + m_droppedStudents
    End Sub 'Correct

    ' used to calculate the metrics used for time in terms of quarters 
    Public Sub time()
        Dim quarterArray As New ArrayList
        Dim totalQuarterArray As New ArrayList

        For Each std As Student In studentList
            If std.CurrentCurriculum.ID = curriculumList(cmbxCurriclum.SelectedIndex).ID Then
                quarterArray.Add(std.SectionsTaken)
            End If
        Next

        For Each enrollarray As ArrayList In quarterArray
            Dim quarterCount As Integer = 0
            Dim currentQuarter As String = ""
            Dim currentYear As Integer = 0
            For Each enroll As Enrollment In enrollarray
                If ((Not enroll.Quarter = currentQuarter Or Not _
                    enroll.Year = currentYear) Or enroll.Quarter = Nothing) Then
                    quarterCount += 1
                    currentQuarter = enroll.Quarter
                    currentYear = enroll.Year
                End If
            Next
            totalQuarterArray.Add(quarterCount)
        Next

        m_maxTime = (maxTime(totalQuarterArray)).ToString
        m_minTime = (minTime(totalQuarterArray)).ToString
        m_avgTime = (avgTime(totalQuarterArray)).ToString

        lblMaxTime.Text = "Maximum quarters attended: " + m_maxTime
        lblMinTime.Text = "Minimum quarters attended: " + m_minTime
        lblAvgTime.Text = "Average quarters attended: " + m_avgTime

    End Sub 'working so far 

    Public Function avgTime(ByVal quarterArray As ArrayList) 'in quarters 
        Dim quarters As Integer = Nothing
        Dim num As Integer = Nothing
        Dim calc As Double = Nothing
        For i As Integer = 0 To (quarterArray.Count - 1)
            quarters += quarterArray(i)

            quarterArray.Count.ToString()
            num = quarterArray.Count
            calc = quarters / num
        Next
        Return FormatNumber(calc)

    End Function 'working so far

    Public Function minTime(ByVal quarterArray As ArrayList) 'in quarters 
        Dim min As Integer = Nothing

        For i As Integer = 0 To (quarterArray.Count - 1)
            If i = 0 Then
                min = quarterArray(i)
            Else
                If quarterArray(i) < min Then min = quarterArray(i)
            End If
        Next
        minTime = min
        Return minTime

    End Function 'working so far

    Public Function maxTime(ByVal quarterArray As ArrayList) 'in quarters 
        Dim max As Integer = Nothing

        For i As Integer = 0 To (quarterArray.Count - 1)
            If i = 0 Then
                max = quarterArray(i)
            Else
                If quarterArray(i) > max Then max = quarterArray(i)
            End If
        Next
        maxTime = max
        Return maxTime

    End Function 'working so far

    ' these four blocks of code are used to determine unit metrics 
    Public Sub Units()

        Dim unitArray As New ArrayList
        Dim course As New Course
        Dim courseDB As Collection = Controller.getCourseDB()

        'Dim coursesTakenList As ArrayList = tempStudent.SectionsTaken

        Dim sectionArray As New ArrayList

        For Each std As Student In studentList
            If std.CurrentCurriculum.ID = curriculumList(cmbxCurriclum.SelectedIndex).ID Then
                sectionArray.Add(std.SectionsTaken)
            End If
        Next

        For Each enrollarray As ArrayList In sectionArray
            Dim unitsTaken As Integer = 0
            For Each enroll As Enrollment In enrollarray
                tempCourse = courses.Item(enroll.SectionTaken.CourseID)
                unitsTaken += tempCourse.Units

            Next
            unitArray.Add(unitsTaken)
        Next

        m_maxUnits = (maxUnits(unitArray)).ToString
        m_minUnits = (minUnits(unitArray)).ToString
        m_avgUnits = (avgUnits(unitArray)).ToString
        ' m_unitsLeft = (avgUnitsRemaining()).ToString

        lblMaxUnit.Text = "Maximum units taken: " + m_maxUnits
        lblMinUnit.Text = "Minimum units taken: " + m_minUnits
        lblAvgUnits.Text = "Average units taken: " + m_avgUnits

    End Sub 'works for avg, max, and min 

    Public Function avgUnits(ByVal unitArray As ArrayList)
        Dim units As Integer = Nothing
        Dim num As Integer = Nothing
        Dim calc As Double = Nothing
        For i As Integer = 0 To (unitArray.Count - 1)
            units += unitArray(i)

            'unitArray.Count.ToString 
            num = unitArray.Count
            calc = units / num
        Next
        Return FormatNumber(calc)
    End Function 'working so far 

    Public Function maxUnits(ByVal unitArray As ArrayList)
        Dim max As Integer = Nothing

        For i As Integer = 0 To (unitArray.Count - 1)
            If i = 0 Then
                max = unitArray(i)
            Else
                If unitArray(i) > max Then max = unitArray(i)
            End If
        Next
        Return max
    End Function 'working so far 

    Public Function minUnits(ByVal unitArray As ArrayList)
        Dim min As Integer = Nothing

        For i As Integer = 0 To (unitArray.Count - 1)
            If i = 0 Then
                min = unitArray(i)
            Else
                If unitArray(i) < min Then min = unitArray(i)
            End If
        Next
        Return min
    End Function 'working so far 

    'these two blocks calculate average remaining units for the curriculum
    Public Sub avgUnitsRemaining()

        Dim unitArray As New ArrayList
        Dim course As New Course
        Dim courseDB As Collection = Controller.getCourseDB()

        'Dim coursesTakenList As ArrayList = tempStudent.SectionsTaken
        Dim sectionArray2 As New ArrayList
        Dim remainingArray As New ArrayList

        'Dim requiredCoreCoursesList As New ArrayList
        'Dim requiredGECoursesList As New ArrayList
        Dim electiveCoursesList As New ArrayList

        'requiredGECoursesList.Add(curriculumList(cmbxCurriclum.SelectedIndex).RequiredGECourses)
        'requiredCoreCoursesList.Add(curriculumList(cmbxCurriclum.SelectedIndex).RequiredCoreCourses)
        electiveCoursesList.Add(curriculumList(cmbxCurriclum.SelectedIndex).ElectiveCourses)

        'Dim tempCourseList As New ArrayList
        'Dim tempUnits As New ArrayList
        'Dim UnitCount As Integer
        'Dim reqUnitsRemaining As Integer

        For Each std2 As Student In studentList
            If std2.CurrentCurriculum.ID = curriculumList(cmbxCurriclum.SelectedIndex).ID Then
                sectionArray2.Add(std2.SectionsTaken)
            End If
        Next

        'For Each clssGe As String In curriculumList(cmbxCurriclum.SelectedIndex).RequiredGECourses.Courses
        '    If clssGe = tempCourse.ID Then
        '        tempCourseList.Add(tempCourse)
        '        'courseList.Contains(tempCourse)

        '    End If
        'Next
        'For Each clssCr As String In curriculumList(cmbxCurriclum.SelectedIndex).RequiredCoreCourses.Courses
        '    If clssCr = tempCourse.ID Then
        '        tempCourseList.Add(tempCourse)
        '    End If
        'Next

        ''For Each cid As String In curriculumList(cmbxCurriclum.SelectedIndex).RequiredGECourses.Courses
        ''    tempCourseList.Add(cid)
        ''Next

        ''For Each cid As String In curriculumList(cmbxCurriclum.SelectedIndex).RequiredCoreCourses.Courses
        ''    tempCourseList.Add(cid)
        ''Next

        'For Each Curr As Curriculum In curriculumList
        '    For Each tmpcrs As Course In tempCourseList
        '        UnitCount += tmpcrs.Units
        '    Next
        'Next


        For Each Std2 As Student In studentList
            If Std2.CurrentCurriculum.ID = curriculumList(cmbxCurriclum.SelectedIndex).ID Then
                For Each courseID In electiveCoursesList
                    For Each enrollarray In sectionArray2
                        Dim electiveUnitsRemaining As Integer = curriculumList(cmbxCurriclum.SelectedIndex).ElectiveUnitsRequired
                        For Each enroll As Enrollment In enrollarray
                            If enroll.Grade Is Nothing Or Std2.calculateGradePoints(enroll.Grade) <= 1.7 Then
                                'Do nothing
                            Else
                                tempCourse = courses.Item(enroll.SectionTaken.CourseID)
                                electiveUnitsRemaining -= tempCourse.Units

                            End If

                            If electiveUnitsRemaining > 0 Then
                                remainingArray.Add(electiveUnitsRemaining)
                            Else
                                Dim overElectives As Integer = 0
                                remainingArray.Add(overElectives)
                            End If

                        Next
                    Next
                Next
            End If
        Next

        m_unitsLeft = (avgRemainingCalc(remainingArray)).ToString

        lblAvgRemaining.Text = "Average Remaining Units: " + m_unitsLeft

    End Sub 'INCORRECT

    Public Function avgRemainingCalc(ByVal remainingArray As ArrayList)
        Dim units As Integer = Nothing
        Dim num As Integer = Nothing
        Dim calc As Double = Nothing
        For i As Integer = 0 To (remainingArray.Count - 1)
            units += remainingArray(i)
            num = remainingArray.Count
            calc = units / num
        Next
        Return FormatNumber(calc)
    End Function 'working I think

    Public Function totalStudents()
        Dim stdCount As Integer = 0
        For Each std As Student In studentList
            If std.CurrentCurriculum.ID = curriculumList(cmbxCurriclum.SelectedIndex).ID Then
                stdCount += 1
            End If
        Next

        lblStdTotal.Text = "Total Students: " + stdCount.ToString
        Return stdCount
    End Function

End Class