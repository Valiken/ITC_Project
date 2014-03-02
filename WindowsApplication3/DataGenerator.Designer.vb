<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataGenerator))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Classes = New System.Windows.Forms.TabPage()
        Me.btnRoomsGenerate = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudRoomsStudents = New System.Windows.Forms.NumericUpDown()
        Me.nudRoomsAvailable = New System.Windows.Forms.NumericUpDown()
        Me.btnClassesImport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lboxClassesCourses = New System.Windows.Forms.ListBox()
        Me.btnClassesAddClass = New System.Windows.Forms.Button()
        Me.txtClassesPrerequisites = New System.Windows.Forms.TextBox()
        Me.cboxClassesPrerequisites = New System.Windows.Forms.CheckBox()
        Me.txtClassesCompanion = New System.Windows.Forms.TextBox()
        Me.cboxClassesCompanion = New System.Windows.Forms.CheckBox()
        Me.nudClassesUnits = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassesFileSRC = New System.Windows.Forms.TextBox()
        Me.btnClassesBrowse = New System.Windows.Forms.Button()
        Me.Curriculum = New System.Windows.Forms.TabPage()
        Me.btnCurriculumNew = New System.Windows.Forms.Button()
        Me.cboCurriculumYear = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCurriculumImport = New System.Windows.Forms.Button()
        Me.btnCurriculumAddElectives = New System.Windows.Forms.Button()
        Me.btnCurriculumAddCore = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lboxCurriculumElective = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lboxCurriculumReqCore = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCurriculumAddGE = New System.Windows.Forms.Button()
        Me.btnCurriculumDrop = New System.Windows.Forms.Button()
        Me.lboxCurriculumReqGE = New System.Windows.Forms.ListBox()
        Me.lboxCurriculumCourses = New System.Windows.Forms.ListBox()
        Me.btnCurriculumBrowse = New System.Windows.Forms.Button()
        Me.txtCurriculumFileSrc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Students = New System.Windows.Forms.TabPage()
        Me.lblCurriculumDist = New System.Windows.Forms.Label()
        Me.txtCurriculumDist = New System.Windows.Forms.TextBox()
        Me.cbxCurriculumYear = New System.Windows.Forms.ComboBox()
        Me.lblCurriculumYear = New System.Windows.Forms.Label()
        Me.nudClassesPerQuarter = New System.Windows.Forms.NumericUpDown()
        Me.lblClassesPerQuarter = New System.Windows.Forms.Label()
        Me.lblCurrentYear = New System.Windows.Forms.Label()
        Me.nudCurrentYear = New System.Windows.Forms.NumericUpDown()
        Me.lblCurrentQuarter = New System.Windows.Forms.Label()
        Me.nudDropRate = New System.Windows.Forms.NumericUpDown()
        Me.lblDropRate = New System.Windows.Forms.Label()
        Me.nudNumberofStudentsgenerated = New System.Windows.Forms.NumericUpDown()
        Me.lblNumberofStudents = New System.Windows.Forms.Label()
        Me.cbxCurrentQuarter = New System.Windows.Forms.ComboBox()
        Me.chkRandClassGen = New System.Windows.Forms.CheckBox()
        Me.btnRandomGenerate = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Classes.SuspendLayout()
        CType(Me.nudRoomsStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRoomsAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudClassesUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Curriculum.SuspendLayout()
        Me.Students.SuspendLayout()
        CType(Me.nudClassesPerQuarter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCurrentYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDropRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberofStudentsgenerated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Classes)
        Me.TabControl1.Controls.Add(Me.Curriculum)
        Me.TabControl1.Controls.Add(Me.Students)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(582, 445)
        Me.TabControl1.TabIndex = 0
        '
        'Classes
        '
        Me.Classes.Controls.Add(Me.btnRoomsGenerate)
        Me.Classes.Controls.Add(Me.Label13)
        Me.Classes.Controls.Add(Me.Label2)
        Me.Classes.Controls.Add(Me.nudRoomsStudents)
        Me.Classes.Controls.Add(Me.nudRoomsAvailable)
        Me.Classes.Controls.Add(Me.btnClassesImport)
        Me.Classes.Controls.Add(Me.Label5)
        Me.Classes.Controls.Add(Me.Button3)
        Me.Classes.Controls.Add(Me.lboxClassesCourses)
        Me.Classes.Controls.Add(Me.btnClassesAddClass)
        Me.Classes.Controls.Add(Me.txtClassesPrerequisites)
        Me.Classes.Controls.Add(Me.cboxClassesPrerequisites)
        Me.Classes.Controls.Add(Me.txtClassesCompanion)
        Me.Classes.Controls.Add(Me.cboxClassesCompanion)
        Me.Classes.Controls.Add(Me.nudClassesUnits)
        Me.Classes.Controls.Add(Me.Label8)
        Me.Classes.Controls.Add(Me.txtCourseName)
        Me.Classes.Controls.Add(Me.Label4)
        Me.Classes.Controls.Add(Me.Label1)
        Me.Classes.Controls.Add(Me.txtClassesFileSRC)
        Me.Classes.Controls.Add(Me.btnClassesBrowse)
        Me.Classes.Location = New System.Drawing.Point(4, 22)
        Me.Classes.Name = "Classes"
        Me.Classes.Padding = New System.Windows.Forms.Padding(3)
        Me.Classes.Size = New System.Drawing.Size(574, 419)
        Me.Classes.TabIndex = 0
        Me.Classes.Text = "Classes"
        Me.Classes.UseVisualStyleBackColor = True
        '
        'btnRoomsGenerate
        '
        Me.btnRoomsGenerate.Location = New System.Drawing.Point(149, 360)
        Me.btnRoomsGenerate.Name = "btnRoomsGenerate"
        Me.btnRoomsGenerate.Size = New System.Drawing.Size(97, 23)
        Me.btnRoomsGenerate.TabIndex = 26
        Me.btnRoomsGenerate.Text = "Generate Rooms"
        Me.btnRoomsGenerate.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(55, 311)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(194, 15)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Number of students per room"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Number of rooms available"
        '
        'nudRoomsStudents
        '
        Me.nudRoomsStudents.Location = New System.Drawing.Point(149, 329)
        Me.nudRoomsStudents.Name = "nudRoomsStudents"
        Me.nudRoomsStudents.Size = New System.Drawing.Size(100, 20)
        Me.nudRoomsStudents.TabIndex = 23
        Me.nudRoomsStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudRoomsStudents.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nudRoomsAvailable
        '
        Me.nudRoomsAvailable.Location = New System.Drawing.Point(149, 282)
        Me.nudRoomsAvailable.Name = "nudRoomsAvailable"
        Me.nudRoomsAvailable.Size = New System.Drawing.Size(100, 20)
        Me.nudRoomsAvailable.TabIndex = 22
        Me.nudRoomsAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudRoomsAvailable.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnClassesImport
        '
        Me.btnClassesImport.Location = New System.Drawing.Point(447, 9)
        Me.btnClassesImport.Name = "btnClassesImport"
        Me.btnClassesImport.Size = New System.Drawing.Size(97, 23)
        Me.btnClassesImport.TabIndex = 21
        Me.btnClassesImport.Text = "Import Classes"
        Me.btnClassesImport.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(361, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Courses Added"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(428, 360)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Remove Class"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lboxClassesCourses
        '
        Me.lboxClassesCourses.FormattingEnabled = True
        Me.lboxClassesCourses.Location = New System.Drawing.Point(327, 69)
        Me.lboxClassesCourses.Name = "lboxClassesCourses"
        Me.lboxClassesCourses.Size = New System.Drawing.Size(198, 277)
        Me.lboxClassesCourses.TabIndex = 18
        '
        'btnClassesAddClass
        '
        Me.btnClassesAddClass.Location = New System.Drawing.Point(327, 360)
        Me.btnClassesAddClass.Name = "btnClassesAddClass"
        Me.btnClassesAddClass.Size = New System.Drawing.Size(97, 23)
        Me.btnClassesAddClass.TabIndex = 17
        Me.btnClassesAddClass.Text = "Add Class"
        Me.btnClassesAddClass.UseVisualStyleBackColor = True
        '
        'txtClassesPrerequisites
        '
        Me.txtClassesPrerequisites.Enabled = False
        Me.txtClassesPrerequisites.Location = New System.Drawing.Point(149, 231)
        Me.txtClassesPrerequisites.Name = "txtClassesPrerequisites"
        Me.txtClassesPrerequisites.Size = New System.Drawing.Size(100, 20)
        Me.txtClassesPrerequisites.TabIndex = 16
        '
        'cboxClassesPrerequisites
        '
        Me.cboxClassesPrerequisites.AutoSize = True
        Me.cboxClassesPrerequisites.Enabled = False
        Me.cboxClassesPrerequisites.Location = New System.Drawing.Point(126, 205)
        Me.cboxClassesPrerequisites.Name = "cboxClassesPrerequisites"
        Me.cboxClassesPrerequisites.Size = New System.Drawing.Size(86, 17)
        Me.cboxClassesPrerequisites.TabIndex = 15
        Me.cboxClassesPrerequisites.Text = "Prerequisites"
        Me.cboxClassesPrerequisites.UseVisualStyleBackColor = True
        '
        'txtClassesCompanion
        '
        Me.txtClassesCompanion.Enabled = False
        Me.txtClassesCompanion.Location = New System.Drawing.Point(149, 167)
        Me.txtClassesCompanion.Name = "txtClassesCompanion"
        Me.txtClassesCompanion.Size = New System.Drawing.Size(100, 20)
        Me.txtClassesCompanion.TabIndex = 14
        '
        'cboxClassesCompanion
        '
        Me.cboxClassesCompanion.AutoSize = True
        Me.cboxClassesCompanion.Enabled = False
        Me.cboxClassesCompanion.Location = New System.Drawing.Point(126, 141)
        Me.cboxClassesCompanion.Name = "cboxClassesCompanion"
        Me.cboxClassesCompanion.Size = New System.Drawing.Size(107, 17)
        Me.cboxClassesCompanion.TabIndex = 13
        Me.cboxClassesCompanion.Text = "Companion Class"
        Me.cboxClassesCompanion.UseVisualStyleBackColor = True
        '
        'nudClassesUnits
        '
        Me.nudClassesUnits.Enabled = False
        Me.nudClassesUnits.Location = New System.Drawing.Point(151, 106)
        Me.nudClassesUnits.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudClassesUnits.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudClassesUnits.Name = "nudClassesUnits"
        Me.nudClassesUnits.Size = New System.Drawing.Size(98, 20)
        Me.nudClassesUnits.TabIndex = 12
        Me.nudClassesUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudClassesUnits.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(105, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Units"
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(149, 69)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Course Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Import a File"
        '
        'txtClassesFileSRC
        '
        Me.txtClassesFileSRC.Enabled = False
        Me.txtClassesFileSRC.Location = New System.Drawing.Point(106, 12)
        Me.txtClassesFileSRC.Name = "txtClassesFileSRC"
        Me.txtClassesFileSRC.Size = New System.Drawing.Size(254, 20)
        Me.txtClassesFileSRC.TabIndex = 1
        '
        'btnClassesBrowse
        '
        Me.btnClassesBrowse.Location = New System.Drawing.Point(366, 10)
        Me.btnClassesBrowse.Name = "btnClassesBrowse"
        Me.btnClassesBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnClassesBrowse.TabIndex = 0
        Me.btnClassesBrowse.Text = "Browse"
        Me.btnClassesBrowse.UseVisualStyleBackColor = True
        '
        'Curriculum
        '
        Me.Curriculum.Controls.Add(Me.btnCurriculumNew)
        Me.Curriculum.Controls.Add(Me.cboCurriculumYear)
        Me.Curriculum.Controls.Add(Me.Label12)
        Me.Curriculum.Controls.Add(Me.Label11)
        Me.Curriculum.Controls.Add(Me.btnCurriculumImport)
        Me.Curriculum.Controls.Add(Me.btnCurriculumAddElectives)
        Me.Curriculum.Controls.Add(Me.btnCurriculumAddCore)
        Me.Curriculum.Controls.Add(Me.Label10)
        Me.Curriculum.Controls.Add(Me.lboxCurriculumElective)
        Me.Curriculum.Controls.Add(Me.Label9)
        Me.Curriculum.Controls.Add(Me.lboxCurriculumReqCore)
        Me.Curriculum.Controls.Add(Me.Label7)
        Me.Curriculum.Controls.Add(Me.Label6)
        Me.Curriculum.Controls.Add(Me.btnCurriculumAddGE)
        Me.Curriculum.Controls.Add(Me.btnCurriculumDrop)
        Me.Curriculum.Controls.Add(Me.lboxCurriculumReqGE)
        Me.Curriculum.Controls.Add(Me.lboxCurriculumCourses)
        Me.Curriculum.Controls.Add(Me.btnCurriculumBrowse)
        Me.Curriculum.Controls.Add(Me.txtCurriculumFileSrc)
        Me.Curriculum.Controls.Add(Me.Label3)
        Me.Curriculum.Location = New System.Drawing.Point(4, 22)
        Me.Curriculum.Name = "Curriculum"
        Me.Curriculum.Padding = New System.Windows.Forms.Padding(3)
        Me.Curriculum.Size = New System.Drawing.Size(574, 419)
        Me.Curriculum.TabIndex = 1
        Me.Curriculum.Text = "Curriculum"
        Me.Curriculum.UseVisualStyleBackColor = True
        '
        'btnCurriculumNew
        '
        Me.btnCurriculumNew.Location = New System.Drawing.Point(21, 47)
        Me.btnCurriculumNew.Name = "btnCurriculumNew"
        Me.btnCurriculumNew.Size = New System.Drawing.Size(117, 23)
        Me.btnCurriculumNew.TabIndex = 34
        Me.btnCurriculumNew.Text = "Create New"
        Me.btnCurriculumNew.UseVisualStyleBackColor = True
        '
        'cboCurriculumYear
        '
        Me.cboCurriculumYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurriculumYear.FormattingEnabled = True
        Me.cboCurriculumYear.Location = New System.Drawing.Point(447, 56)
        Me.cboCurriculumYear.Name = "cboCurriculumYear"
        Me.cboCurriculumYear.Size = New System.Drawing.Size(71, 21)
        Me.cboCurriculumYear.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(369, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 15)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Year"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(360, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 15)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Curriculum"
        '
        'btnCurriculumImport
        '
        Me.btnCurriculumImport.Location = New System.Drawing.Point(447, 10)
        Me.btnCurriculumImport.Name = "btnCurriculumImport"
        Me.btnCurriculumImport.Size = New System.Drawing.Size(97, 23)
        Me.btnCurriculumImport.TabIndex = 29
        Me.btnCurriculumImport.Text = "Import Classes"
        Me.btnCurriculumImport.UseVisualStyleBackColor = True
        '
        'btnCurriculumAddElectives
        '
        Me.btnCurriculumAddElectives.Image = CType(resources.GetObject("btnCurriculumAddElectives.Image"), System.Drawing.Image)
        Me.btnCurriculumAddElectives.Location = New System.Drawing.Point(290, 304)
        Me.btnCurriculumAddElectives.Name = "btnCurriculumAddElectives"
        Me.btnCurriculumAddElectives.Size = New System.Drawing.Size(55, 43)
        Me.btnCurriculumAddElectives.TabIndex = 28
        Me.btnCurriculumAddElectives.UseVisualStyleBackColor = True
        '
        'btnCurriculumAddCore
        '
        Me.btnCurriculumAddCore.Image = CType(resources.GetObject("btnCurriculumAddCore.Image"), System.Drawing.Image)
        Me.btnCurriculumAddCore.Location = New System.Drawing.Point(290, 213)
        Me.btnCurriculumAddCore.Name = "btnCurriculumAddCore"
        Me.btnCurriculumAddCore.Size = New System.Drawing.Size(55, 43)
        Me.btnCurriculumAddCore.TabIndex = 27
        Me.btnCurriculumAddCore.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(369, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Electives "
        '
        'lboxCurriculumElective
        '
        Me.lboxCurriculumElective.FormattingEnabled = True
        Me.lboxCurriculumElective.Location = New System.Drawing.Point(360, 293)
        Me.lboxCurriculumElective.Name = "lboxCurriculumElective"
        Me.lboxCurriculumElective.Size = New System.Drawing.Size(158, 69)
        Me.lboxCurriculumElective.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(369, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Required Core"
        '
        'lboxCurriculumReqCore
        '
        Me.lboxCurriculumReqCore.FormattingEnabled = True
        Me.lboxCurriculumReqCore.Location = New System.Drawing.Point(360, 203)
        Me.lboxCurriculumReqCore.Name = "lboxCurriculumReqCore"
        Me.lboxCurriculumReqCore.Size = New System.Drawing.Size(158, 69)
        Me.lboxCurriculumReqCore.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(369, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Required GE "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Courses"
        '
        'btnCurriculumAddGE
        '
        Me.btnCurriculumAddGE.Image = CType(resources.GetObject("btnCurriculumAddGE.Image"), System.Drawing.Image)
        Me.btnCurriculumAddGE.Location = New System.Drawing.Point(290, 130)
        Me.btnCurriculumAddGE.Name = "btnCurriculumAddGE"
        Me.btnCurriculumAddGE.Size = New System.Drawing.Size(55, 43)
        Me.btnCurriculumAddGE.TabIndex = 9
        Me.btnCurriculumAddGE.UseVisualStyleBackColor = True
        '
        'btnCurriculumDrop
        '
        Me.btnCurriculumDrop.Image = CType(resources.GetObject("btnCurriculumDrop.Image"), System.Drawing.Image)
        Me.btnCurriculumDrop.Location = New System.Drawing.Point(209, 213)
        Me.btnCurriculumDrop.Name = "btnCurriculumDrop"
        Me.btnCurriculumDrop.Size = New System.Drawing.Size(55, 43)
        Me.btnCurriculumDrop.TabIndex = 8
        Me.btnCurriculumDrop.UseVisualStyleBackColor = True
        '
        'lboxCurriculumReqGE
        '
        Me.lboxCurriculumReqGE.FormattingEnabled = True
        Me.lboxCurriculumReqGE.Location = New System.Drawing.Point(360, 114)
        Me.lboxCurriculumReqGE.Name = "lboxCurriculumReqGE"
        Me.lboxCurriculumReqGE.Size = New System.Drawing.Size(158, 69)
        Me.lboxCurriculumReqGE.TabIndex = 7
        '
        'lboxCurriculumCourses
        '
        Me.lboxCurriculumCourses.FormattingEnabled = True
        Me.lboxCurriculumCourses.Location = New System.Drawing.Point(21, 111)
        Me.lboxCurriculumCourses.Name = "lboxCurriculumCourses"
        Me.lboxCurriculumCourses.Size = New System.Drawing.Size(166, 251)
        Me.lboxCurriculumCourses.TabIndex = 6
        '
        'btnCurriculumBrowse
        '
        Me.btnCurriculumBrowse.Location = New System.Drawing.Point(366, 10)
        Me.btnCurriculumBrowse.Name = "btnCurriculumBrowse"
        Me.btnCurriculumBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnCurriculumBrowse.TabIndex = 5
        Me.btnCurriculumBrowse.Text = "Browse"
        Me.btnCurriculumBrowse.UseVisualStyleBackColor = True
        '
        'txtCurriculumFileSrc
        '
        Me.txtCurriculumFileSrc.Enabled = False
        Me.txtCurriculumFileSrc.Location = New System.Drawing.Point(106, 12)
        Me.txtCurriculumFileSrc.Name = "txtCurriculumFileSrc"
        Me.txtCurriculumFileSrc.Size = New System.Drawing.Size(254, 20)
        Me.txtCurriculumFileSrc.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Import a File"
        '
        'Students
        '
        Me.Students.Controls.Add(Me.lblCurriculumDist)
        Me.Students.Controls.Add(Me.txtCurriculumDist)
        Me.Students.Controls.Add(Me.cbxCurriculumYear)
        Me.Students.Controls.Add(Me.lblCurriculumYear)
        Me.Students.Controls.Add(Me.nudClassesPerQuarter)
        Me.Students.Controls.Add(Me.lblClassesPerQuarter)
        Me.Students.Controls.Add(Me.lblCurrentYear)
        Me.Students.Controls.Add(Me.nudCurrentYear)
        Me.Students.Controls.Add(Me.lblCurrentQuarter)
        Me.Students.Controls.Add(Me.nudDropRate)
        Me.Students.Controls.Add(Me.lblDropRate)
        Me.Students.Controls.Add(Me.nudNumberofStudentsgenerated)
        Me.Students.Controls.Add(Me.lblNumberofStudents)
        Me.Students.Controls.Add(Me.cbxCurrentQuarter)
        Me.Students.Controls.Add(Me.chkRandClassGen)
        Me.Students.Controls.Add(Me.btnRandomGenerate)
        Me.Students.Location = New System.Drawing.Point(4, 22)
        Me.Students.Name = "Students"
        Me.Students.Size = New System.Drawing.Size(574, 419)
        Me.Students.TabIndex = 2
        Me.Students.Text = "Students"
        Me.Students.UseVisualStyleBackColor = True
        '
        'lblCurriculumDist
        '
        Me.lblCurriculumDist.AutoSize = True
        Me.lblCurriculumDist.Location = New System.Drawing.Point(173, 52)
        Me.lblCurriculumDist.Name = "lblCurriculumDist"
        Me.lblCurriculumDist.Size = New System.Drawing.Size(128, 13)
        Me.lblCurriculumDist.TabIndex = 21
        Me.lblCurriculumDist.Text = "Curriculum Distribution (%)"
        '
        'txtCurriculumDist
        '
        Me.txtCurriculumDist.Location = New System.Drawing.Point(176, 68)
        Me.txtCurriculumDist.Name = "txtCurriculumDist"
        Me.txtCurriculumDist.Size = New System.Drawing.Size(100, 20)
        Me.txtCurriculumDist.TabIndex = 20
        '
        'cbxCurriculumYear
        '
        Me.cbxCurriculumYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurriculumYear.FormattingEnabled = True
        Me.cbxCurriculumYear.Location = New System.Drawing.Point(176, 114)
        Me.cbxCurriculumYear.Name = "cbxCurriculumYear"
        Me.cbxCurriculumYear.Size = New System.Drawing.Size(121, 21)
        Me.cbxCurriculumYear.TabIndex = 19
        '
        'lblCurriculumYear
        '
        Me.lblCurriculumYear.AutoSize = True
        Me.lblCurriculumYear.Location = New System.Drawing.Point(173, 97)
        Me.lblCurriculumYear.Name = "lblCurriculumYear"
        Me.lblCurriculumYear.Size = New System.Drawing.Size(81, 13)
        Me.lblCurriculumYear.TabIndex = 18
        Me.lblCurriculumYear.Text = "Curriculum Year"
        '
        'nudClassesPerQuarter
        '
        Me.nudClassesPerQuarter.Location = New System.Drawing.Point(29, 292)
        Me.nudClassesPerQuarter.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudClassesPerQuarter.Name = "nudClassesPerQuarter"
        Me.nudClassesPerQuarter.Size = New System.Drawing.Size(120, 20)
        Me.nudClassesPerQuarter.TabIndex = 17
        Me.nudClassesPerQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudClassesPerQuarter.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'lblClassesPerQuarter
        '
        Me.lblClassesPerQuarter.AutoSize = True
        Me.lblClassesPerQuarter.Location = New System.Drawing.Point(29, 276)
        Me.lblClassesPerQuarter.Name = "lblClassesPerQuarter"
        Me.lblClassesPerQuarter.Size = New System.Drawing.Size(100, 13)
        Me.lblClassesPerQuarter.TabIndex = 16
        Me.lblClassesPerQuarter.Text = "Classes Per Quarter"
        '
        'lblCurrentYear
        '
        Me.lblCurrentYear.AutoSize = True
        Me.lblCurrentYear.Location = New System.Drawing.Point(29, 179)
        Me.lblCurrentYear.Name = "lblCurrentYear"
        Me.lblCurrentYear.Size = New System.Drawing.Size(66, 13)
        Me.lblCurrentYear.TabIndex = 15
        Me.lblCurrentYear.Text = "Current Year"
        '
        'nudCurrentYear
        '
        Me.nudCurrentYear.Location = New System.Drawing.Point(29, 195)
        Me.nudCurrentYear.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.nudCurrentYear.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCurrentYear.Name = "nudCurrentYear"
        Me.nudCurrentYear.Size = New System.Drawing.Size(120, 20)
        Me.nudCurrentYear.TabIndex = 14
        Me.nudCurrentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudCurrentYear.Value = New Decimal(New Integer() {2013, 0, 0, 0})
        '
        'lblCurrentQuarter
        '
        Me.lblCurrentQuarter.AutoSize = True
        Me.lblCurrentQuarter.Location = New System.Drawing.Point(26, 135)
        Me.lblCurrentQuarter.Name = "lblCurrentQuarter"
        Me.lblCurrentQuarter.Size = New System.Drawing.Size(79, 13)
        Me.lblCurrentQuarter.TabIndex = 13
        Me.lblCurrentQuarter.Text = "Current Quarter"
        '
        'nudDropRate
        '
        Me.nudDropRate.Location = New System.Drawing.Point(29, 112)
        Me.nudDropRate.Name = "nudDropRate"
        Me.nudDropRate.Size = New System.Drawing.Size(120, 20)
        Me.nudDropRate.TabIndex = 12
        Me.nudDropRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDropRate
        '
        Me.lblDropRate.AutoSize = True
        Me.lblDropRate.Location = New System.Drawing.Point(26, 96)
        Me.lblDropRate.Name = "lblDropRate"
        Me.lblDropRate.Size = New System.Drawing.Size(73, 13)
        Me.lblDropRate.TabIndex = 11
        Me.lblDropRate.Text = "Drop Rate (%)"
        '
        'nudNumberofStudentsgenerated
        '
        Me.nudNumberofStudentsgenerated.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNumberofStudentsgenerated.Location = New System.Drawing.Point(29, 68)
        Me.nudNumberofStudentsgenerated.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudNumberofStudentsgenerated.Name = "nudNumberofStudentsgenerated"
        Me.nudNumberofStudentsgenerated.Size = New System.Drawing.Size(120, 20)
        Me.nudNumberofStudentsgenerated.TabIndex = 10
        Me.nudNumberofStudentsgenerated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudNumberofStudentsgenerated.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblNumberofStudents
        '
        Me.lblNumberofStudents.AutoSize = True
        Me.lblNumberofStudents.Location = New System.Drawing.Point(26, 51)
        Me.lblNumberofStudents.Name = "lblNumberofStudents"
        Me.lblNumberofStudents.Size = New System.Drawing.Size(101, 13)
        Me.lblNumberofStudents.TabIndex = 9
        Me.lblNumberofStudents.Text = "Number of Students"
        '
        'cbxCurrentQuarter
        '
        Me.cbxCurrentQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurrentQuarter.FormattingEnabled = True
        Me.cbxCurrentQuarter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbxCurrentQuarter.Items.AddRange(New Object() {"FALL", "WINTER", "SPRING"})
        Me.cbxCurrentQuarter.Location = New System.Drawing.Point(29, 151)
        Me.cbxCurrentQuarter.Name = "cbxCurrentQuarter"
        Me.cbxCurrentQuarter.Size = New System.Drawing.Size(121, 21)
        Me.cbxCurrentQuarter.TabIndex = 8
        '
        'chkRandClassGen
        '
        Me.chkRandClassGen.AutoSize = True
        Me.chkRandClassGen.Location = New System.Drawing.Point(29, 251)
        Me.chkRandClassGen.Name = "chkRandClassGen"
        Me.chkRandClassGen.Size = New System.Drawing.Size(162, 17)
        Me.chkRandClassGen.TabIndex = 7
        Me.chkRandClassGen.Text = "Random Classes Per Quarter"
        Me.chkRandClassGen.UseVisualStyleBackColor = True
        '
        'btnRandomGenerate
        '
        Me.btnRandomGenerate.Location = New System.Drawing.Point(186, 374)
        Me.btnRandomGenerate.Name = "btnRandomGenerate"
        Me.btnRandomGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnRandomGenerate.TabIndex = 5
        Me.btnRandomGenerate.Text = "Generate!"
        Me.btnRandomGenerate.UseVisualStyleBackColor = True
        '
        'DataGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 485)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "DataGenerator"
        Me.Text = "DataGenerator"
        Me.TabControl1.ResumeLayout(False)
        Me.Classes.ResumeLayout(False)
        Me.Classes.PerformLayout()
        CType(Me.nudRoomsStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRoomsAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudClassesUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Curriculum.ResumeLayout(False)
        Me.Curriculum.PerformLayout()
        Me.Students.ResumeLayout(False)
        Me.Students.PerformLayout()
        CType(Me.nudClassesPerQuarter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCurrentYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDropRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberofStudentsgenerated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Classes As System.Windows.Forms.TabPage
    Friend WithEvents txtCourseName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClassesFileSRC As System.Windows.Forms.TextBox
    Friend WithEvents btnClassesBrowse As System.Windows.Forms.Button
    Friend WithEvents Curriculum As System.Windows.Forms.TabPage
    Friend WithEvents btnCurriculumBrowse As System.Windows.Forms.Button
    Friend WithEvents txtCurriculumFileSrc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Students As System.Windows.Forms.TabPage
    Friend WithEvents txtClassesPrerequisites As System.Windows.Forms.TextBox
    Friend WithEvents cboxClassesPrerequisites As System.Windows.Forms.CheckBox
    Friend WithEvents txtClassesCompanion As System.Windows.Forms.TextBox
    Friend WithEvents cboxClassesCompanion As System.Windows.Forms.CheckBox
    Friend WithEvents nudClassesUnits As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClassesAddClass As System.Windows.Forms.Button
    Friend WithEvents lboxClassesCourses As System.Windows.Forms.ListBox
    Friend WithEvents lboxCurriculumCourses As System.Windows.Forms.ListBox
    Friend WithEvents btnCurriculumAddGE As System.Windows.Forms.Button
    Friend WithEvents btnCurriculumDrop As System.Windows.Forms.Button
    Friend WithEvents lboxCurriculumReqGE As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lboxCurriculumElective As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lboxCurriculumReqCore As System.Windows.Forms.ListBox
    Friend WithEvents btnCurriculumAddElectives As System.Windows.Forms.Button
    Friend WithEvents btnCurriculumAddCore As System.Windows.Forms.Button
    Friend WithEvents btnRandomGenerate As System.Windows.Forms.Button
    Friend WithEvents btnClassesImport As System.Windows.Forms.Button
    Friend WithEvents btnCurriculumImport As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCurriculumYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCurriculumNew As System.Windows.Forms.Button
    Friend WithEvents cbxCurriculumYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblCurriculumYear As System.Windows.Forms.Label
    Friend WithEvents nudClassesPerQuarter As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblClassesPerQuarter As System.Windows.Forms.Label
    Friend WithEvents lblCurrentYear As System.Windows.Forms.Label
    Friend WithEvents nudCurrentYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCurrentQuarter As System.Windows.Forms.Label
    Friend WithEvents nudDropRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDropRate As System.Windows.Forms.Label
    Friend WithEvents nudNumberofStudentsgenerated As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNumberofStudents As System.Windows.Forms.Label
    Friend WithEvents cbxCurrentQuarter As System.Windows.Forms.ComboBox
    Friend WithEvents chkRandClassGen As System.Windows.Forms.CheckBox
    Friend WithEvents lblCurriculumDist As System.Windows.Forms.Label
    Friend WithEvents txtCurriculumDist As System.Windows.Forms.TextBox
    Friend WithEvents nudRoomsStudents As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudRoomsAvailable As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRoomsGenerate As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
