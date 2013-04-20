<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbxStudentList = New System.Windows.Forms.ListBox()
        Me.lblStudentList = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblCurriculum = New System.Windows.Forms.Label()
        Me.lblExpectedGraduation = New System.Windows.Forms.Label()
        Me.lblAcademicStats = New System.Windows.Forms.Label()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.lblGPAValue = New System.Windows.Forms.Label()
        Me.lblClassesTakenValue = New System.Windows.Forms.Label()
        Me.lblClassesTaken = New System.Windows.Forms.Label()
        Me.lblMinQuartersToGrad = New System.Windows.Forms.Label()
        Me.lblMinQuartersToGradValue = New System.Windows.Forms.Label()
        Me.lblAvgUnitsPerQuarter = New System.Windows.Forms.Label()
        Me.lblAvgUnitsPerQuarterValue = New System.Windows.Forms.Label()
        Me.lblClassStandingValue = New System.Windows.Forms.Label()
        Me.lblClassStanding = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblCourseCurriculum = New System.Windows.Forms.Label()
        Me.gbxCompleted = New System.Windows.Forms.GroupBox()
        Me.lbxCompleted = New System.Windows.Forms.ListBox()
        Me.lbxNotTaken = New System.Windows.Forms.ListBox()
        Me.gbxNotTaken = New System.Windows.Forms.GroupBox()
        Me.gbxFailDrop = New System.Windows.Forms.GroupBox()
        Me.lbxFailDrop = New System.Windows.Forms.ListBox()
        Me.lblCurriculumValue = New System.Windows.Forms.Label()
        Me.gbxCompleted.SuspendLayout()
        Me.gbxNotTaken.SuspendLayout()
        Me.gbxFailDrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbxStudentList
        '
        Me.lbxStudentList.FormattingEnabled = True
        Me.lbxStudentList.Location = New System.Drawing.Point(39, 88)
        Me.lbxStudentList.Name = "lbxStudentList"
        Me.lbxStudentList.Size = New System.Drawing.Size(120, 394)
        Me.lbxStudentList.TabIndex = 0
        '
        'lblStudentList
        '
        Me.lblStudentList.AutoSize = True
        Me.lblStudentList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentList.Location = New System.Drawing.Point(39, 69)
        Me.lblStudentList.Name = "lblStudentList"
        Me.lblStudentList.Size = New System.Drawing.Size(104, 13)
        Me.lblStudentList.TabIndex = 1
        Me.lblStudentList.Text = "Select a student:"
        '
        'lblStudentName
        '
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(340, 20)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(300, 25)
        Me.lblStudentName.TabIndex = 14
        Me.lblStudentName.Text = "Student Name"
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurriculum
        '
        Me.lblCurriculum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurriculum.Location = New System.Drawing.Point(402, 68)
        Me.lblCurriculum.Name = "lblCurriculum"
        Me.lblCurriculum.Size = New System.Drawing.Size(280, 25)
        Me.lblCurriculum.TabIndex = 15
        Me.lblCurriculum.Text = "Curriculum Year: "
        '
        'lblExpectedGraduation
        '
        Me.lblExpectedGraduation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpectedGraduation.Location = New System.Drawing.Point(367, 90)
        Me.lblExpectedGraduation.Name = "lblExpectedGraduation"
        Me.lblExpectedGraduation.Size = New System.Drawing.Size(330, 25)
        Me.lblExpectedGraduation.TabIndex = 16
        Me.lblExpectedGraduation.Text = "Expected Graduation Date: 2015"
        '
        'lblAcademicStats
        '
        Me.lblAcademicStats.AutoSize = True
        Me.lblAcademicStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcademicStats.Location = New System.Drawing.Point(411, 132)
        Me.lblAcademicStats.Name = "lblAcademicStats"
        Me.lblAcademicStats.Size = New System.Drawing.Size(129, 17)
        Me.lblAcademicStats.TabIndex = 17
        Me.lblAcademicStats.Text = "Academic Statistics"
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPA.Location = New System.Drawing.Point(389, 159)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(36, 13)
        Me.lblGPA.TabIndex = 18
        Me.lblGPA.Text = "GPA:"
        Me.lblGPA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGPAValue
        '
        Me.lblGPAValue.AutoSize = True
        Me.lblGPAValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPAValue.Location = New System.Drawing.Point(436, 159)
        Me.lblGPAValue.Name = "lblGPAValue"
        Me.lblGPAValue.Size = New System.Drawing.Size(22, 13)
        Me.lblGPAValue.TabIndex = 19
        Me.lblGPAValue.Text = "4.0"
        Me.lblGPAValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClassesTakenValue
        '
        Me.lblClassesTakenValue.AutoSize = True
        Me.lblClassesTakenValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassesTakenValue.Location = New System.Drawing.Point(436, 186)
        Me.lblClassesTakenValue.Name = "lblClassesTakenValue"
        Me.lblClassesTakenValue.Size = New System.Drawing.Size(19, 13)
        Me.lblClassesTakenValue.TabIndex = 21
        Me.lblClassesTakenValue.Text = "20"
        Me.lblClassesTakenValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClassesTaken
        '
        Me.lblClassesTaken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassesTaken.Location = New System.Drawing.Point(313, 186)
        Me.lblClassesTaken.Name = "lblClassesTaken"
        Me.lblClassesTaken.Size = New System.Drawing.Size(112, 13)
        Me.lblClassesTaken.TabIndex = 22
        Me.lblClassesTaken.Text = "# Classes Taken:"
        Me.lblClassesTaken.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMinQuartersToGrad
        '
        Me.lblMinQuartersToGrad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinQuartersToGrad.Location = New System.Drawing.Point(479, 186)
        Me.lblMinQuartersToGrad.Name = "lblMinQuartersToGrad"
        Me.lblMinQuartersToGrad.Size = New System.Drawing.Size(109, 27)
        Me.lblMinQuartersToGrad.TabIndex = 23
        Me.lblMinQuartersToGrad.Text = "Minimum Quarters Left to Graduate:"
        Me.lblMinQuartersToGrad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMinQuartersToGradValue
        '
        Me.lblMinQuartersToGradValue.AutoSize = True
        Me.lblMinQuartersToGradValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinQuartersToGradValue.Location = New System.Drawing.Point(594, 200)
        Me.lblMinQuartersToGradValue.Name = "lblMinQuartersToGradValue"
        Me.lblMinQuartersToGradValue.Size = New System.Drawing.Size(13, 13)
        Me.lblMinQuartersToGradValue.TabIndex = 24
        Me.lblMinQuartersToGradValue.Text = "8"
        Me.lblMinQuartersToGradValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAvgUnitsPerQuarter
        '
        Me.lblAvgUnitsPerQuarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgUnitsPerQuarter.Location = New System.Drawing.Point(316, 208)
        Me.lblAvgUnitsPerQuarter.Name = "lblAvgUnitsPerQuarter"
        Me.lblAvgUnitsPerQuarter.Size = New System.Drawing.Size(109, 26)
        Me.lblAvgUnitsPerQuarter.TabIndex = 26
        Me.lblAvgUnitsPerQuarter.Text = "Avg. Units Per Quarter:"
        Me.lblAvgUnitsPerQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAvgUnitsPerQuarterValue
        '
        Me.lblAvgUnitsPerQuarterValue.AutoSize = True
        Me.lblAvgUnitsPerQuarterValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgUnitsPerQuarterValue.Location = New System.Drawing.Point(436, 221)
        Me.lblAvgUnitsPerQuarterValue.Name = "lblAvgUnitsPerQuarterValue"
        Me.lblAvgUnitsPerQuarterValue.Size = New System.Drawing.Size(19, 13)
        Me.lblAvgUnitsPerQuarterValue.TabIndex = 27
        Me.lblAvgUnitsPerQuarterValue.Text = "16"
        Me.lblAvgUnitsPerQuarterValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClassStandingValue
        '
        Me.lblClassStandingValue.AutoSize = True
        Me.lblClassStandingValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassStandingValue.Location = New System.Drawing.Point(594, 159)
        Me.lblClassStandingValue.Name = "lblClassStandingValue"
        Me.lblClassStandingValue.Size = New System.Drawing.Size(61, 13)
        Me.lblClassStandingValue.TabIndex = 29
        Me.lblClassStandingValue.Text = "Sophomore"
        Me.lblClassStandingValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClassStanding
        '
        Me.lblClassStanding.AutoSize = True
        Me.lblClassStanding.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassStanding.Location = New System.Drawing.Point(493, 159)
        Me.lblClassStanding.Name = "lblClassStanding"
        Me.lblClassStanding.Size = New System.Drawing.Size(95, 13)
        Me.lblClassStanding.TabIndex = 28
        Me.lblClassStanding.Text = "Class Standing:"
        Me.lblClassStanding.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMajor
        '
        Me.lblMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(343, 45)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(300, 25)
        Me.lblMajor.TabIndex = 30
        Me.lblMajor.Text = "B.S. Computer Science"
        Me.lblMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseCurriculum
        '
        Me.lblCourseCurriculum.AutoSize = True
        Me.lblCourseCurriculum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseCurriculum.Location = New System.Drawing.Point(411, 302)
        Me.lblCourseCurriculum.Name = "lblCourseCurriculum"
        Me.lblCourseCurriculum.Size = New System.Drawing.Size(136, 17)
        Me.lblCourseCurriculum.TabIndex = 31
        Me.lblCourseCurriculum.Text = "Curriculum Progress"
        '
        'gbxCompleted
        '
        Me.gbxCompleted.Controls.Add(Me.lbxCompleted)
        Me.gbxCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCompleted.ForeColor = System.Drawing.Color.Green
        Me.gbxCompleted.Location = New System.Drawing.Point(305, 341)
        Me.gbxCompleted.Name = "gbxCompleted"
        Me.gbxCompleted.Size = New System.Drawing.Size(112, 147)
        Me.gbxCompleted.TabIndex = 34
        Me.gbxCompleted.TabStop = False
        Me.gbxCompleted.Text = "Completed"
        '
        'lbxCompleted
        '
        Me.lbxCompleted.FormattingEnabled = True
        Me.lbxCompleted.Location = New System.Drawing.Point(7, 20)
        Me.lbxCompleted.Name = "lbxCompleted"
        Me.lbxCompleted.Size = New System.Drawing.Size(99, 121)
        Me.lbxCompleted.TabIndex = 0
        '
        'lbxNotTaken
        '
        Me.lbxNotTaken.FormattingEnabled = True
        Me.lbxNotTaken.Location = New System.Drawing.Point(7, 19)
        Me.lbxNotTaken.Name = "lbxNotTaken"
        Me.lbxNotTaken.Size = New System.Drawing.Size(100, 121)
        Me.lbxNotTaken.TabIndex = 0
        '
        'gbxNotTaken
        '
        Me.gbxNotTaken.Controls.Add(Me.lbxNotTaken)
        Me.gbxNotTaken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxNotTaken.ForeColor = System.Drawing.Color.Olive
        Me.gbxNotTaken.Location = New System.Drawing.Point(423, 341)
        Me.gbxNotTaken.Name = "gbxNotTaken"
        Me.gbxNotTaken.Size = New System.Drawing.Size(113, 147)
        Me.gbxNotTaken.TabIndex = 35
        Me.gbxNotTaken.TabStop = False
        Me.gbxNotTaken.Text = "Not Taken"
        '
        'gbxFailDrop
        '
        Me.gbxFailDrop.Controls.Add(Me.lbxFailDrop)
        Me.gbxFailDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFailDrop.ForeColor = System.Drawing.Color.Red
        Me.gbxFailDrop.Location = New System.Drawing.Point(542, 341)
        Me.gbxFailDrop.Name = "gbxFailDrop"
        Me.gbxFailDrop.Size = New System.Drawing.Size(116, 147)
        Me.gbxFailDrop.TabIndex = 36
        Me.gbxFailDrop.TabStop = False
        Me.gbxFailDrop.Text = "Failed/Dropped"
        '
        'lbxFailDrop
        '
        Me.lbxFailDrop.FormattingEnabled = True
        Me.lbxFailDrop.Location = New System.Drawing.Point(7, 19)
        Me.lbxFailDrop.Name = "lbxFailDrop"
        Me.lbxFailDrop.Size = New System.Drawing.Size(103, 121)
        Me.lbxFailDrop.TabIndex = 0
        '
        'lblCurriculumValue
        '
        Me.lblCurriculumValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurriculumValue.Location = New System.Drawing.Point(537, 68)
        Me.lblCurriculumValue.Name = "lblCurriculumValue"
        Me.lblCurriculumValue.Size = New System.Drawing.Size(50, 25)
        Me.lblCurriculumValue.TabIndex = 37
        Me.lblCurriculumValue.Text = "2000"
        '
        'StudentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 596)
        Me.Controls.Add(Me.lblCurriculumValue)
        Me.Controls.Add(Me.gbxFailDrop)
        Me.Controls.Add(Me.gbxNotTaken)
        Me.Controls.Add(Me.gbxCompleted)
        Me.Controls.Add(Me.lblCourseCurriculum)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.lblClassStandingValue)
        Me.Controls.Add(Me.lblClassStanding)
        Me.Controls.Add(Me.lblAvgUnitsPerQuarterValue)
        Me.Controls.Add(Me.lblAvgUnitsPerQuarter)
        Me.Controls.Add(Me.lblMinQuartersToGradValue)
        Me.Controls.Add(Me.lblMinQuartersToGrad)
        Me.Controls.Add(Me.lblClassesTaken)
        Me.Controls.Add(Me.lblClassesTakenValue)
        Me.Controls.Add(Me.lblGPAValue)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.lblAcademicStats)
        Me.Controls.Add(Me.lblExpectedGraduation)
        Me.Controls.Add(Me.lblCurriculum)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudentList)
        Me.Controls.Add(Me.lbxStudentList)
        Me.Name = "StudentView"
        Me.Text = "StudentView"
        Me.gbxCompleted.ResumeLayout(False)
        Me.gbxNotTaken.ResumeLayout(False)
        Me.gbxFailDrop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbxStudentList As System.Windows.Forms.ListBox
    Friend WithEvents lblStudentList As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblCurriculum As System.Windows.Forms.Label
    Friend WithEvents lblExpectedGraduation As System.Windows.Forms.Label
    Friend WithEvents lblAcademicStats As System.Windows.Forms.Label
    Friend WithEvents lblGPA As System.Windows.Forms.Label
    Friend WithEvents lblGPAValue As System.Windows.Forms.Label
    Friend WithEvents lblClassesTakenValue As System.Windows.Forms.Label
    Friend WithEvents lblClassesTaken As System.Windows.Forms.Label
    Friend WithEvents lblMinQuartersToGrad As System.Windows.Forms.Label
    Friend WithEvents lblMinQuartersToGradValue As System.Windows.Forms.Label
    Friend WithEvents lblAvgUnitsPerQuarter As System.Windows.Forms.Label
    Friend WithEvents lblAvgUnitsPerQuarterValue As System.Windows.Forms.Label
    Friend WithEvents lblClassStandingValue As System.Windows.Forms.Label
    Friend WithEvents lblClassStanding As System.Windows.Forms.Label
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents lblCourseCurriculum As System.Windows.Forms.Label
    Friend WithEvents gbxCompleted As System.Windows.Forms.GroupBox
    Friend WithEvents lbxCompleted As System.Windows.Forms.ListBox
    Friend WithEvents lbxNotTaken As System.Windows.Forms.ListBox
    Friend WithEvents gbxNotTaken As System.Windows.Forms.GroupBox
    Friend WithEvents gbxFailDrop As System.Windows.Forms.GroupBox
    Friend WithEvents lbxFailDrop As System.Windows.Forms.ListBox
    Friend WithEvents lblCurriculumValue As System.Windows.Forms.Label
End Class
