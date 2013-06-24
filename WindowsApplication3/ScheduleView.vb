Imports BusinessLogic

Public Class ScheduleView
    Dim tempStudentDB As Collection = Controller.getStudentDB
    Dim quarterArray As New ArrayList
    Dim courseCollection As New Collection
    Dim nullString As String
    Dim nullStudent As New Student
    Dim nullCollection As New Collection
    Dim nullcourse As New Course

    Dim lblTimeArray, lblCourseIDArray, lblDayArray, lblyearArray, lblQuarterArray As New ArrayList



    Private Sub lboxQuarters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxQuarters.SelectedIndexChanged
        If Not lboxQuarters.SelectedIndex = -1 Then
            'Display Objects
            pnlQuarter.Visible = True
            Label20.Visible = True
            lboxClasses.Visible = True

            'get user selection for quarter
            Dim choice As String = lboxQuarters.SelectedItem

            'get all class from selected quarter
            Dim tempArray As ArrayList = courseCollection.Item(choice)
            tempArray.Sort()
            lboxClasses.Items.Clear()

            'add all courses from selected quater to List box
            For Each Me.nullString In tempArray
                lboxClasses.Items.Add(nullString)
            Next

            Dim firstYear As Integer = 0
            Dim secondYear As Integer = 0
            Dim thirdYear As Integer = 0
            Dim fourthYear As Integer = 0
            Dim fifthYear As Integer = 0


            'fill out metrics
            For Each Me.nullStudent In tempStudentDB
                'get year and quarter to determine what year they are
                Dim year As Integer = nullStudent.EnrolledYear
                Dim currentYear As Integer = Now.Year
                Dim statusYear As Integer = currentYear - year

                'determine what year this student is
                If statusYear = 1 Then
                    firstYear += 1
                ElseIf statusYear = 2 Then
                    secondYear += 1
                ElseIf statusYear = 3 Then
                    thirdYear += 1
                ElseIf statusYear = 4 Then
                    fourthYear += 1
                Else
                    fifthYear += 1
                End If
            Next

            'display Data
            lblNumClasses.Text = tempArray.Count
            lblNumFirstYear.Text = firstYear
            lblNumSecondYear.Text = secondYear
            lblNumThirdYear.Text = thirdYear
            lblNumFourthYear.Text = fourthYear
            lblNumFifthYear.Text = fifthYear


        End If
    End Sub

    Private Sub lboxClasses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxClasses.SelectedIndexChanged
        If Not lboxClasses.SelectedIndex = -1 Then
            pnlClassMetrics.Visible = True

        End If
    End Sub

    Private Sub ScheduleView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim nullSection As New Section
        Dim nullschedule As New Schedule
        Dim tempSchedule As New ScheduleDatabase
        tempSchedule.MasterDatabase = Controller.getScheduleDB
        For Each nullschedule In tempSchedule.MasterDatabase
            cboSchedules.Items.Add(nullschedule.Quarter & "-" & nullschedule.Year)
        Next
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If Not cboQuarter.SelectedIndex = -1 Then
            Dim scheduleDB As New ScheduleDatabase
            scheduleDB.MasterDatabase = Controller.getScheduleDB
            Dim studentDB As New StudentDatabase
            studentDB.MasterDatabase = Controller.getStudentDB
            Dim tempSection As New Section
            Dim courseNeed As New Collection
            Dim tempSchedule As New Schedule
            Dim courseArray As New ArrayList


            'find out what course is highest in demand
            For Each Me.nullStudent In studentDB.MasterDatabase
                Dim courseTakenID As New ArrayList
                Dim courseRequired As New ArrayList
                For index = 0 To nullStudent.SectionsTaken.Count - 1 Step 1
                    'adds classes taken to courseTakenID Arraylist
                    If Not courseTakenID.Contains(nullStudent.SectionsTaken(index).SectionTaken.CourseID()) Then
                        courseTakenID.Add(nullStudent.SectionsTaken(index).SectionTaken.CourseID())
                    End If
                Next


                'gets all course ID for the current curriculum
                courseRequired = nullStudent.CurrentCurriculum.returnAllCourseID()

                For counter = 0 To courseRequired.Count - 1 Step 1
                    If Not courseTakenID.Contains(courseRequired.Item(counter)) Then
                        Dim tempCourse As New Course
                        Dim courseNeedCount As Integer

                        If courseNeed.Contains(courseRequired.Item(counter)) Then
                            courseNeedCount = courseNeed.Item(courseRequired.Item(counter)).AmountNeeded
                            courseNeed.Remove(courseRequired.Item(counter))
                            courseNeedCount += 1
                            tempCourse.AmountNeeded = courseNeedCount
                            tempCourse.ID = courseRequired.Item(counter)
                            courseNeed.Add(tempCourse, tempCourse.ID)
                        Else
                            tempCourse.AmountNeeded = 1
                            tempCourse.ID = courseRequired.Item(counter)
                            courseNeed.Add(tempCourse, tempCourse.ID)
                        End If

                    End If
                Next

            Next


            For Each Me.nullcourse In courseNeed
                courseArray.Add(nullcourse.ID)
            Next
            courseArray.Sort()


            Dim startTime As TimeSpan = TimeSpan.Parse("8:00")

            Dim quarter As String = cboQuarter.SelectedItem
            Dim year As String = nudYear.Value
            Dim scheduleID As String = quarter & "-" & year
            tempSchedule.ScheduleID = scheduleID


            'create M,W,F class
            For index = 1 To courseArray.Count - 1 Step 1
                Dim sectionCounter As Integer = 0
                tempSection = New Section
                tempSection.CourseID = courseArray(index)
                tempSection.Days = "M, W, F"
                tempSection.ScheduleID = scheduleID
                tempSection.SectionID = sectionCounter
                tempSection.StartTime = TimeSpan.Parse("8:00")
                Dim test As Boolean = False
                While test = False
                    If tempSchedule.SectionCollection.Contains(tempSection.SectionID) Then
                        tempSection.SectionID += 1
                    Else
                        tempSection.SectionID = tempSection.CourseID & "-" & tempSection.SectionID
                        tempSchedule.addSection(tempSection)
                        test = True
                    End If
                End While
            Next

            'Creat T, Th

            For index = 1 To courseArray.Count - 1 Step 1
                Dim sectionCounter As Integer = 1
                tempSection = New Section
                tempSection.CourseID = courseArray(index)
                tempSection.Days = "T, Th"
                tempSection.ScheduleID = scheduleID
                tempSection.SectionID = sectionCounter
                tempSection.StartTime = TimeSpan.Parse("8:00")
                Dim test As Boolean = False
                While test = False
                    If tempSchedule.SectionCollection.Contains(tempSection.SectionID) Then
                        tempSection.SectionID += 1
                    Else
                        tempSection.SectionID = tempSection.CourseID & "-" & tempSection.SectionID
                        tempSchedule.addSection(tempSection)
                        test = True
                    End If
                End While
            Next

            tempSchedule.Year = nudYear.Value
            tempSchedule.Quarter = cboQuarter.SelectedItem
            scheduleDB.addSchedule(tempSchedule)


            Controller.updateScheduleDB(scheduleDB.MasterDatabase)
            erasePanel()
            updateComboBox()
            updateDisplay(tempSchedule)
            cboSchedules.SelectedItem = tempSchedule.ScheduleID
        Else
            MessageBox.Show("Please select a quarter")
        End If
    End Sub

    Private Sub updateComboBox()
        cboSchedules.Items.Clear()
        Dim nullSection As New Section
        Dim nullschedule As New Schedule
        Dim tempSchedule As New ScheduleDatabase
        tempSchedule.MasterDatabase = Controller.getScheduleDB
        For Each nullschedule In tempSchedule.MasterDatabase
            cboSchedules.Items.Add(nullschedule.Quarter & "-" & nullschedule.Year)
        Next
    End Sub

    Private Sub updateDisplay(ByVal schedule As Schedule)
        lblTimeArray.Clear()
        lblCourseIDArray.Clear()
        lblDayArray.Clear()
        lblyearArray.Clear()
        lblQuarterArray.Clear()

        lblTimeArray.Add(lblTime)
        lblCourseIDArray.Add(lblCourseID)
        lblDayArray.Add(lblDays)
        lblyearArray.Add(lblYear)
        lblQuarterArray.Add(lblQuarter)



        For Each nullSection In schedule.SectionCollection
            Dim lblTimes As New Label
            lblTimes.Location = lblTime.Location
            Dim index As Integer = lblTimeArray.Count - 1
            lblTimes.Top = lblTimeArray(index).Top + 30
            lblTimes.Text = nullSection.StartTime.ToString
            lblTimes.Width = lblTime.Width + 20
            lblTimeArray.Add(lblTimes)
            Me.Panel1.Controls.Add(lblTimes)

            Dim lblCourse = New Label
            lblCourse.Location = lblCourseID.Location
            lblCourse.Top = lblCourseIDArray(index).Top + 30
            lblCourse.Text = nullSection.CourseID
            lblCourse.Width = lblCourseID.Width + 30
            lblCourseIDArray.Add(lblCourse)
            Me.Panel1.Controls.Add(lblCourse)

            Dim lblDay = New Label
            lblDay.Location = lblDays.Location
            lblDay.Top = lblDayArray(index).Top + 30
            lblDay.Text = nullSection.Days
            lblDay.Width = lblDays.Width + 30
            lblDayArray.Add(lblDay)
            Me.Panel1.Controls.Add(lblDay)

            Dim lblYears = New Label
            lblYears.Location = lblYear.Location
            lblYears.Top = lblyearArray(index).Top + 30
            lblYears.Text = schedule.Year
            lblYears.Width = lblYear.Width + 30
            lblyearArray.Add(lblYears)
            Me.Panel1.Controls.Add(lblYears)

            Dim lblQuarters = New Label
            lblQuarters.Location = lblQuarter.Location
            lblQuarters.Top = lblQuarterArray(index).Top + 30
            lblQuarters.Text = schedule.Quarter
            lblQuarters.Width = lblQuarter.Width
            lblQuarterArray.Add(lblQuarters)
            Me.Panel1.Controls.Add(lblQuarters)
        Next


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            lboxQuarters.Items.Clear()
            lboxClasses.SelectedIndex = -1
            Dim courseArray As New ArrayList
            For Each Me.nullStudent In tempStudentDB
                For index = 0 To nullStudent.SectionsTaken.Count - 1 Step 1
                    Dim quarter As String = nullStudent.SectionsTaken(index).Quarter
                    Dim year As String = nullStudent.SectionsTaken(index).Year
                    Dim tempQuarter As String = quarter & "-" & year
                    Dim temp As String = nullStudent.SectionsTaken(index).SectionTaken.CourseID()
                    If courseCollection.Contains(tempQuarter) Then
                        courseArray = courseCollection.Item(tempQuarter)
                        If courseArray.Contains(temp) Then
                            courseArray.Remove(temp)
                            courseArray.Add(temp)
                        Else
                            courseArray.Add(temp)
                        End If

                        courseCollection.Remove(tempQuarter)
                        courseCollection.Add(courseArray, tempQuarter)
                    Else
                        courseCollection.Add(courseArray, tempQuarter)
                    End If
                    If quarterArray.Contains(tempQuarter) = False Then
                        quarterArray.Add(tempQuarter)
                    End If
                Next
            Next
            quarterArray.Sort()
            For Each Me.nullString In quarterArray
                lboxQuarters.Items.Add(nullString)
            Next

        End If
    End Sub

    Private Sub cboSchedules_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSchedules.SelectedIndexChanged
        erasePanel()
        Dim nullSection As New Section
        Dim nullschedule As New Schedule
        Dim tempSchedule As New ScheduleDatabase
        tempSchedule.MasterDatabase = Controller.getScheduleDB
        Dim selectedItem As String = cboSchedules.SelectedItem
        nullschedule = tempSchedule.MasterDatabase.Item(selectedItem)
        updateDisplay(nullschedule)
    End Sub

    Private Sub erasePanel()
        Dim nullLabel As New Label
        Dim lastLabel As Integer = lblCourseIDArray.Count - 1

        For index = lastLabel To 1 Step -1
            nullLabel = lblTimeArray(index)
            lblTimeArray.RemoveAt(index)
            nullLabel.Dispose()

            nullLabel = lblCourseIDArray(index)
            lblCourseIDArray.RemoveAt(index)
            nullLabel.Dispose()

            nullLabel = lblDayArray(index)
            lblDayArray.RemoveAt(index)
            nullLabel.Dispose()

            nullLabel = lblQuarterArray(index)
            lblQuarterArray.RemoveAt(index)
            nullLabel.Dispose()

            nullLabel = lblyearArray(index)
            lblyearArray.RemoveAt(index)
            nullLabel.Dispose()
        Next
    End Sub


End Class