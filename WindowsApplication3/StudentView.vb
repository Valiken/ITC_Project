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
        lblExpectedGraduation.Text = "Expected Graduation Date: " + studentList(lbxStudentList.SelectedIndex).ExpectedGraduationDate.ToString("y")
        lblClassStandingValue.Text = getClassStanding()
        clearCourseLists()
        updateCourseLists()

    End Sub

    'Update the Student information labels
    Private Sub lbxStudentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxStudentList.SelectedIndexChanged
        lblStudentName.Text = studentList(lbxStudentList.SelectedIndex).Name
        lblCurriculumValue.Text = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ID
        lblExpectedGraduation.Text = "Expected Graduation Date: " + studentList(lbxStudentList.SelectedIndex).ExpectedGraduationDate.ToString("y")
        lblGPAValue.Text = calculateGPA()
        lblClassesTakenValue.Text = studentList(lbxStudentList.SelectedIndex).SectionsTaken.Count()
        lblMinQuartersToGradValue.Text = getMinimumQuartersLeft()
        clearCourseLists()
        updateCourseLists()
        
    End Sub

    'Determines GPA; returns String
    Private Function calculateGPA()

        Dim finalGradePoints As Double = 0.0
        Dim gradePoints As Double = 0.0
        Dim classGradePoints As Double = 0.0
        Dim unitsTaken As Double = 0.0
        Dim totalUnitsTaken As Double = 0.0
        Dim GPA As Double
        Dim enrollment As New Enrollment
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken

        For Each enrollment In coursesTakenList

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

        Select Case unitsTaken
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
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken

        For Each enrollment In coursesTakenList
            course = courseDB.Item(enrollment.SectionTaken.CourseID)
            unitsTaken += course.Units
        Next
        
        Return unitsTaken
    End Function

    'Determine the minimum quarters left to graduate; returns String
    Function getMinimumQuartersLeft()
        Dim minimumQuartersLeft As Double = 0.0
        Dim electiveCoursesRemaining As Double = 0.0
        Dim coursesLeftList As ArrayList = New ArrayList()
        Dim electiveUnitsRemaining As Integer = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ElectiveUnitsRequired

        Dim course As New Course
        Dim enrollment As New Enrollment
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken
        Dim courseDB As Collection = Controller.getCourseDB()
        Dim courseID As String
        Dim requiredCoreCoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredCoreCourses.Courses
        Dim requiredGECoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredGECourses.Courses
        Dim electiveCoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ElectiveCourses.Courses

        For Each courseID In requiredCoreCoursesList
            coursesLeftList.Add(courseDB.Item(courseID))
        Next

        For Each courseID In requiredGECoursesList
            coursesLeftList.Add(courseDB.Item(courseID))
        Next

        For Each courseID In electiveCoursesList
            For Each enrollment In coursesTakenList
                If enrollment.Grade Is Nothing Or calculateGradePoints(enrollment.Grade) <= 1.7 Then
                    'Do nothing
                Else
                    electiveUnitsRemaining -= courseDB.Item(courseID).units
                End If
            Next
        Next

        If electiveUnitsRemaining < 0 Then
            electiveUnitsRemaining = 0
            minimumQuartersLeft = coursesLeftList.Count()
        ElseIf electiveUnitsRemaining = 0 Then
            minimumQuartersLeft = coursesLeftList.Count()
        Else
            electiveCoursesRemaining = electiveUnitsRemaining / 4
            minimumQuartersLeft = coursesLeftList.Count() + electiveCoursesRemaining
        End If

        minimumQuartersLeft /= 4
        minimumQuartersLeft = Math.Ceiling(minimumQuartersLeft)

        Return minimumQuartersLeft.ToString

    End Function

    Sub updateCourseLists()
        Dim coursesLeftList As ArrayList = New ArrayList()
        Dim courseDB As Collection = Controller.getCourseDB()
        Dim requiredCoreCoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredCoreCourses.Courses
        Dim requiredGECoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredGECourses.Courses
        Dim electiveCoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ElectiveCourses.Courses

        Dim enrollment As New Enrollment
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken
        Dim gradePoints As Double

        For Each enrollment In coursesTakenList
            gradePoints = calculateGradePoints(enrollment.Grade)

            Select Case gradePoints
                Case Is > 1.7
                    lbxCompleted.Items.Add(enrollment.SectionTaken.CourseID)
                Case 0
                    lbxFailDrop.Items.Add(enrollment.SectionTaken.CourseID)
                Case Else
                    lbxNotTaken.Items.Add(enrollment.SectionTaken.CourseID)
            End Select
        Next

    End Sub

    Sub clearCourseLists()
        lbxCompleted.Items.Clear()
        lbxFailDrop.Items.Clear()
        lbxNotTaken.Items.Clear()
    End Sub

End Class