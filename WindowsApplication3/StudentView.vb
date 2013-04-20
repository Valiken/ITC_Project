Public Class StudentView

    Dim students As Collection = Controller.getStudentDB()
    Dim studentList As New List(Of Student)

    'On load, loop through students in studentDB and add them to Listbox
    Private Sub StudentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tempStudent As New Student

        For Each tempStudent In students
            lbxStudentList.Items.Add(tempStudent.Name)
            studentList.Add(tempStudent)
        Next

        lbxStudentList.SelectedIndex = 0
        lblStudentName.Text = studentList(lbxStudentList.SelectedIndex).Name
        lblCurriculumValue.Text = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ID
        lblExpectedGraduation.Text = "Expected Graduation Year: " + studentList(lbxStudentList.SelectedIndex).getExpectedGraduationDate().ToString
        lblClassStandingValue.Text = studentList(lbxStudentList.SelectedIndex).getClassStanding()
        calculateAvgUnitsPerQuarter()
        clearCourseLists()
        updateCourseLists()

    End Sub

    'Update the Student information labels
    Private Sub lbxStudentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxStudentList.SelectedIndexChanged
        lblStudentName.Text = studentList(lbxStudentList.SelectedIndex).Name
        lblCurriculumValue.Text = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ID
        lblExpectedGraduation.Text = "Expected Graduation Year: " + studentList(lbxStudentList.SelectedIndex).getExpectedGraduationDate().ToString
        lblClassStandingValue.Text = studentList(lbxStudentList.SelectedIndex).getClassStanding()
        lblGPAValue.Text = studentList(lbxStudentList.SelectedIndex).calculateGPA()
        lblClassesTakenValue.Text = studentList(lbxStudentList.SelectedIndex).SectionsTaken.Count()
        lblMinQuartersToGradValue.Text = studentList(lbxStudentList.SelectedIndex).getMinimumQuartersLeft()
        calculateAvgUnitsPerQuarter()
        clearCourseLists()
        updateCourseLists()

    End Sub


    Sub updateCourseLists()

        Dim coursesLeftList As ArrayList = New ArrayList()
        Dim courseDB As Collection = Controller.getCourseDB()
        Dim requiredCoreCoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredCoreCourses.Courses
        Dim requiredGECoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredGECourses.Courses
        Dim electiveCoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ElectiveCourses.Courses

        Dim completedCoursesList As New ArrayList
        Dim finalCompletedCourses As New ArrayList
        Dim failDropCoursesList As New ArrayList
        Dim finalFailDropCourses As New ArrayList
        Dim notTakenCoursesList As New ArrayList
        Dim finalNotTakenCourses As New ArrayList

        Dim enrollment As New Enrollment
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken
        Dim gradePoints As Double

        For Each enrollment In coursesTakenList
            gradePoints = studentList(lbxStudentList.SelectedIndex).calculateGradePoints(enrollment.Grade)

            Select Case gradePoints
                Case Is > 1.7
                    completedCoursesList.Add(enrollment.SectionTaken.CourseID)
                    If finalCompletedCourses.Contains(enrollment.SectionTaken.CourseID) Then
                        'do nothing
                    Else
                        finalCompletedCourses.Add(enrollment.SectionTaken.CourseID)
                    End If
                    'lbxCompleted.Items.Add(enrollment.SectionTaken.CourseID)         

                Case 0
                    failDropCoursesList.Add(enrollment.SectionTaken.CourseID)
                    If finalFailDropCourses.Contains(enrollment.SectionTaken.CourseID) Then
                        'do nothing
                    Else
                        finalFailDropCourses.Add(enrollment.SectionTaken.CourseID)
                    End If
                    'lbxFailDrop.Items.Add(enrollment.SectionTaken.CourseID)

                Case Else
                    notTakenCoursesList.Add(enrollment.SectionTaken.CourseID)
                    If finalNotTakenCourses.Contains(enrollment.SectionTaken.CourseID) Then
                        'do nothing
                    Else
                        finalNotTakenCourses.Add(enrollment.SectionTaken.CourseID)
                    End If

            End Select

        Next

        For Each tempCourseID As String In finalCompletedCourses
            lbxCompleted.Items.Add(tempCourseID)
        Next

        For Each tempCourseID As String In finalFailDropCourses
            lbxFailDrop.Items.Add(tempCourseID)
        Next

        For Each tempCourseID As String In finalNotTakenCourses
            lbxNotTaken.Items.Add(tempCourseID)
        Next

    End Sub

    Sub calculateAvgUnitsPerQuarter()

        Dim unitCounter As Integer = 0
        Dim currentQuarter As String = ""
        Dim currentYear As Integer = 0
        Dim enrollment As New Enrollment
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken
        Dim unitCount As New ArrayList
        Dim courseDB As Collection = Controller.getCourseDB()
        Dim totalUnitCount As Double = 0.0

        For Each enrollment In coursesTakenList
            'If the quarter has changed...
            If ((Not enrollment.Quarter = currentQuarter Or Not _
                enrollment.Year = currentYear) Or enrollment.Quarter = Nothing) Then

                'Commit the tally for quarter unit counter to unit count array
                unitCount.Add(unitCounter)
                unitCounter = 0

                'Change current quarter
                currentQuarter = enrollment.Quarter
                currentYear = enrollment.Year

            End If

            'Update unit counter for the quarter
            unitCounter += courseDB.Item(enrollment.SectionTaken.CourseID).units

        Next

        'Get a total count of units taken over the quarters
        For Each unitCounter In unitCount
            totalUnitCount += CDbl(unitCounter)
        Next

        'Divide total units by total quarters taken to get the average units taken per quarter
        totalUnitCount /= CDbl(unitCount.Count())
        totalUnitCount = Math.Round(totalUnitCount, 2, MidpointRounding.AwayFromZero)

        lblAvgUnitsPerQuarterValue.Text = totalUnitCount.ToString

    End Sub

    Sub clearCourseLists()
        lbxCompleted.Items.Clear()
        lbxFailDrop.Items.Clear()
        lbxNotTaken.Items.Clear()
    End Sub

End Class