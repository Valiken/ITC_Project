<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleView
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
        Me.lboxQuarters = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlQuarter = New System.Windows.Forms.GroupBox()
        Me.lblNumFifthYear = New System.Windows.Forms.Label()
        Me.lblNumFourthYear = New System.Windows.Forms.Label()
        Me.lblNumThirdYear = New System.Windows.Forms.Label()
        Me.lblNumSecondYear = New System.Windows.Forms.Label()
        Me.lblNumFirstYear = New System.Windows.Forms.Label()
        Me.lblNumClasses = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.pnlClassMetrics = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lboxClasses = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.schedule = New System.Windows.Forms.TabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.cboQuarter = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboSchedules = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.generator = New System.Windows.Forms.TabPage()
        Me.pnlQuarter.SuspendLayout()
        Me.pnlClassMetrics.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.schedule.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.generator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lboxQuarters
        '
        Me.lboxQuarters.FormattingEnabled = True
        Me.lboxQuarters.Location = New System.Drawing.Point(30, 48)
        Me.lboxQuarters.Name = "lboxQuarters"
        Me.lboxQuarters.Size = New System.Drawing.Size(120, 95)
        Me.lboxQuarters.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quarters"
        '
        'pnlQuarter
        '
        Me.pnlQuarter.Controls.Add(Me.lblNumFifthYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumFourthYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumThirdYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumSecondYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumFirstYear)
        Me.pnlQuarter.Controls.Add(Me.lblNumClasses)
        Me.pnlQuarter.Controls.Add(Me.Label5)
        Me.pnlQuarter.Controls.Add(Me.Label2)
        Me.pnlQuarter.Controls.Add(Me.Label3)
        Me.pnlQuarter.Controls.Add(Me.Label1)
        Me.pnlQuarter.Controls.Add(Me.label7)
        Me.pnlQuarter.Controls.Add(Me.label6)
        Me.pnlQuarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlQuarter.Location = New System.Drawing.Point(203, 11)
        Me.pnlQuarter.Name = "pnlQuarter"
        Me.pnlQuarter.Size = New System.Drawing.Size(532, 190)
        Me.pnlQuarter.TabIndex = 19
        Me.pnlQuarter.TabStop = False
        Me.pnlQuarter.Text = "Quarter Metrics"
        Me.pnlQuarter.Visible = False
        '
        'lblNumFifthYear
        '
        Me.lblNumFifthYear.AutoSize = True
        Me.lblNumFifthYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFifthYear.Location = New System.Drawing.Point(258, 149)
        Me.lblNumFifthYear.Name = "lblNumFifthYear"
        Me.lblNumFifthYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumFifthYear.TabIndex = 27
        Me.lblNumFifthYear.Text = "Course Name"
        '
        'lblNumFourthYear
        '
        Me.lblNumFourthYear.AutoSize = True
        Me.lblNumFourthYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFourthYear.Location = New System.Drawing.Point(258, 126)
        Me.lblNumFourthYear.Name = "lblNumFourthYear"
        Me.lblNumFourthYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumFourthYear.TabIndex = 26
        Me.lblNumFourthYear.Text = "Course Name"
        '
        'lblNumThirdYear
        '
        Me.lblNumThirdYear.AutoSize = True
        Me.lblNumThirdYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumThirdYear.Location = New System.Drawing.Point(258, 103)
        Me.lblNumThirdYear.Name = "lblNumThirdYear"
        Me.lblNumThirdYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumThirdYear.TabIndex = 25
        Me.lblNumThirdYear.Text = "Course Name"
        '
        'lblNumSecondYear
        '
        Me.lblNumSecondYear.AutoSize = True
        Me.lblNumSecondYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumSecondYear.Location = New System.Drawing.Point(258, 83)
        Me.lblNumSecondYear.Name = "lblNumSecondYear"
        Me.lblNumSecondYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumSecondYear.TabIndex = 24
        Me.lblNumSecondYear.Text = "Course Name"
        '
        'lblNumFirstYear
        '
        Me.lblNumFirstYear.AutoSize = True
        Me.lblNumFirstYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFirstYear.Location = New System.Drawing.Point(258, 60)
        Me.lblNumFirstYear.Name = "lblNumFirstYear"
        Me.lblNumFirstYear.Size = New System.Drawing.Size(94, 15)
        Me.lblNumFirstYear.TabIndex = 23
        Me.lblNumFirstYear.Text = "Course Name"
        '
        'lblNumClasses
        '
        Me.lblNumClasses.AutoSize = True
        Me.lblNumClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumClasses.Location = New System.Drawing.Point(258, 37)
        Me.lblNumClasses.Name = "lblNumClasses"
        Me.lblNumClasses.Size = New System.Drawing.Size(94, 15)
        Me.lblNumClasses.TabIndex = 22
        Me.lblNumClasses.Text = "Course Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(29, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Number of Fifth Year Students"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(14, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Number of Fourth Year Students"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(24, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Number of Third Year Students"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Number of Second Year Students"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.label7.Location = New System.Drawing.Point(44, 34)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(189, 18)
        Me.label7.TabIndex = 15
        Me.label7.Text = "Number of Classes Offered"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.label6.Location = New System.Drawing.Point(27, 57)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(207, 18)
        Me.label6.TabIndex = 16
        Me.label6.Text = "Number of First Year Students"
        '
        'pnlClassMetrics
        '
        Me.pnlClassMetrics.Controls.Add(Me.Label12)
        Me.pnlClassMetrics.Controls.Add(Me.Label13)
        Me.pnlClassMetrics.Controls.Add(Me.Label18)
        Me.pnlClassMetrics.Controls.Add(Me.Label19)
        Me.pnlClassMetrics.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlClassMetrics.Location = New System.Drawing.Point(203, 287)
        Me.pnlClassMetrics.Name = "pnlClassMetrics"
        Me.pnlClassMetrics.Size = New System.Drawing.Size(532, 132)
        Me.pnlClassMetrics.TabIndex = 30
        Me.pnlClassMetrics.TabStop = False
        Me.pnlClassMetrics.Text = "Class Metrics"
        Me.pnlClassMetrics.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(314, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 15)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "N/A"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(314, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "N/A"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label18.Location = New System.Drawing.Point(72, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(219, 18)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Number of student that Attended"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label19.Location = New System.Drawing.Point(27, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(264, 18)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Number of students that need to Attend"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(47, 287)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 15)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Classes"
        Me.Label20.Visible = False
        '
        'lboxClasses
        '
        Me.lboxClasses.FormattingEnabled = True
        Me.lboxClasses.Items.AddRange(New Object() {"CIS-304", "CIS-234", "CIS-244", "CIS-124"})
        Me.lboxClasses.Location = New System.Drawing.Point(30, 313)
        Me.lboxClasses.Name = "lboxClasses"
        Me.lboxClasses.Size = New System.Drawing.Size(120, 95)
        Me.lboxClasses.TabIndex = 28
        Me.lboxClasses.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.schedule)
        Me.TabControl1.Controls.Add(Me.generator)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(772, 504)
        Me.TabControl1.TabIndex = 31
        '
        'schedule
        '
        Me.schedule.Controls.Add(Me.Label26)
        Me.schedule.Controls.Add(Me.Label25)
        Me.schedule.Controls.Add(Me.Label24)
        Me.schedule.Controls.Add(Me.Panel2)
        Me.schedule.Controls.Add(Me.Label21)
        Me.schedule.Controls.Add(Me.cboSchedules)
        Me.schedule.Controls.Add(Me.Panel1)
        Me.schedule.Location = New System.Drawing.Point(4, 22)
        Me.schedule.Name = "schedule"
        Me.schedule.Padding = New System.Windows.Forms.Padding(3)
        Me.schedule.Size = New System.Drawing.Size(764, 478)
        Me.schedule.TabIndex = 1
        Me.schedule.Text = "Schedules"
        Me.schedule.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(68, 54)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 20)
        Me.Label26.TabIndex = 32
        Me.Label26.Text = "View"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(353, 47)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(234, 29)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "Selected Schedule"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(28, 172)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(165, 20)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Generate Schedule"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.btnGenerate)
        Me.Panel2.Controls.Add(Me.cboQuarter)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.nudYear)
        Me.Panel2.Location = New System.Drawing.Point(6, 195)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 214)
        Me.Panel2.TabIndex = 29
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(41, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 15)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "What Quarter"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(57, 153)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'cboQuarter
        '
        Me.cboQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuarter.FormattingEnabled = True
        Me.cboQuarter.Items.AddRange(New Object() {"FALL", "WINTER", "SPRING"})
        Me.cboQuarter.Location = New System.Drawing.Point(41, 37)
        Me.cboQuarter.Name = "cboQuarter"
        Me.cboQuarter.Size = New System.Drawing.Size(121, 21)
        Me.cboQuarter.TabIndex = 22
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(46, 83)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 15)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "What Year"
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(44, 101)
        Me.nudYear.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(74, 20)
        Me.nudYear.TabIndex = 23
        Me.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudYear.Value = New Decimal(New Integer() {2014, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(28, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 20)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Past Schedules"
        '
        'cboSchedules
        '
        Me.cboSchedules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSchedules.FormattingEnabled = True
        Me.cboSchedules.Location = New System.Drawing.Point(32, 96)
        Me.cboSchedules.Name = "cboSchedules"
        Me.cboSchedules.Size = New System.Drawing.Size(121, 21)
        Me.cboSchedules.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblQuarter)
        Me.Panel1.Controls.Add(Me.lblYear)
        Me.Panel1.Controls.Add(Me.lblDays)
        Me.Panel1.Controls.Add(Me.lblCourseID)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Location = New System.Drawing.Point(253, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 331)
        Me.Panel1.TabIndex = 26
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarter.Location = New System.Drawing.Point(365, 9)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(59, 16)
        Me.lblQuarter.TabIndex = 26
        Me.lblQuarter.Text = "Quarter"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(291, 9)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(41, 16)
        Me.lblYear.TabIndex = 25
        Me.lblYear.Text = "Year"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Location = New System.Drawing.Point(213, 9)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(44, 16)
        Me.lblDays.TabIndex = 24
        Me.lblDays.Text = "Days"
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseID.Location = New System.Drawing.Point(104, 9)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(76, 16)
        Me.lblCourseID.TabIndex = 23
        Me.lblCourseID.Text = "Course ID"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(28, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 16)
        Me.lblTime.TabIndex = 22
        Me.lblTime.Text = "Time"
        '
        'generator
        '
        Me.generator.Controls.Add(Me.pnlQuarter)
        Me.generator.Controls.Add(Me.pnlClassMetrics)
        Me.generator.Controls.Add(Me.lboxQuarters)
        Me.generator.Controls.Add(Me.lboxClasses)
        Me.generator.Controls.Add(Me.Label4)
        Me.generator.Controls.Add(Me.Label20)
        Me.generator.Location = New System.Drawing.Point(4, 22)
        Me.generator.Name = "generator"
        Me.generator.Padding = New System.Windows.Forms.Padding(3)
        Me.generator.Size = New System.Drawing.Size(764, 478)
        Me.generator.TabIndex = 0
        Me.generator.Text = "Metrics"
        Me.generator.UseVisualStyleBackColor = True
        '
        'ScheduleView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 528)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ScheduleView"
        Me.Text = "ScheduleView"
        Me.pnlQuarter.ResumeLayout(False)
        Me.pnlQuarter.PerformLayout()
        Me.pnlClassMetrics.ResumeLayout(False)
        Me.pnlClassMetrics.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.schedule.ResumeLayout(False)
        Me.schedule.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.generator.ResumeLayout(False)
        Me.generator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lboxQuarters As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlQuarter As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents lblNumClasses As System.Windows.Forms.Label
    Friend WithEvents lblNumFifthYear As System.Windows.Forms.Label
    Friend WithEvents lblNumFourthYear As System.Windows.Forms.Label
    Friend WithEvents lblNumThirdYear As System.Windows.Forms.Label
    Friend WithEvents lblNumSecondYear As System.Windows.Forms.Label
    Friend WithEvents lblNumFirstYear As System.Windows.Forms.Label
    Friend WithEvents pnlClassMetrics As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lboxClasses As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents generator As System.Windows.Forms.TabPage
    Friend WithEvents schedule As System.Windows.Forms.TabPage
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents nudYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboQuarter As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblQuarter As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents lblCourseID As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents cboSchedules As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
