﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Students = New System.Windows.Forms.TabPage()
        Me.testbox = New System.Windows.Forms.TextBox()
        Me.btnRandomGenerate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.Classes.SuspendLayout()
        CType(Me.nudClassesUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Curriculum.SuspendLayout()
        Me.Students.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(541, 407)
        Me.TabControl1.TabIndex = 0
        '
        'Classes
        '
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
        Me.Classes.Size = New System.Drawing.Size(533, 381)
        Me.Classes.TabIndex = 0
        Me.Classes.Text = "Classes"
        Me.Classes.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(257, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Courses Added"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(324, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Remove Class"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'lboxClassesCourses
        '
        Me.lboxClassesCourses.FormattingEnabled = True
        Me.lboxClassesCourses.Location = New System.Drawing.Point(223, 63)
        Me.lboxClassesCourses.Name = "lboxClassesCourses"
        Me.lboxClassesCourses.Size = New System.Drawing.Size(198, 173)
        Me.lboxClassesCourses.TabIndex = 18
        '
        'btnClassesAddClass
        '
        Me.btnClassesAddClass.Location = New System.Drawing.Point(223, 260)
        Me.btnClassesAddClass.Name = "btnClassesAddClass"
        Me.btnClassesAddClass.Size = New System.Drawing.Size(97, 23)
        Me.btnClassesAddClass.TabIndex = 17
        Me.btnClassesAddClass.Text = "Add Class"
        Me.btnClassesAddClass.UseVisualStyleBackColor = True
        Me.btnClassesAddClass.Visible = False
        '
        'txtClassesPrerequisites
        '
        Me.txtClassesPrerequisites.Enabled = False
        Me.txtClassesPrerequisites.Location = New System.Drawing.Point(106, 217)
        Me.txtClassesPrerequisites.Name = "txtClassesPrerequisites"
        Me.txtClassesPrerequisites.Size = New System.Drawing.Size(100, 20)
        Me.txtClassesPrerequisites.TabIndex = 16
        '
        'cboxClassesPrerequisites
        '
        Me.cboxClassesPrerequisites.AutoSize = True
        Me.cboxClassesPrerequisites.Enabled = False
        Me.cboxClassesPrerequisites.Location = New System.Drawing.Point(83, 194)
        Me.cboxClassesPrerequisites.Name = "cboxClassesPrerequisites"
        Me.cboxClassesPrerequisites.Size = New System.Drawing.Size(86, 17)
        Me.cboxClassesPrerequisites.TabIndex = 15
        Me.cboxClassesPrerequisites.Text = "Prerequisites"
        Me.cboxClassesPrerequisites.UseVisualStyleBackColor = True
        '
        'txtClassesCompanion
        '
        Me.txtClassesCompanion.Enabled = False
        Me.txtClassesCompanion.Location = New System.Drawing.Point(106, 157)
        Me.txtClassesCompanion.Name = "txtClassesCompanion"
        Me.txtClassesCompanion.Size = New System.Drawing.Size(100, 20)
        Me.txtClassesCompanion.TabIndex = 14
        '
        'cboxClassesCompanion
        '
        Me.cboxClassesCompanion.AutoSize = True
        Me.cboxClassesCompanion.Enabled = False
        Me.cboxClassesCompanion.Location = New System.Drawing.Point(83, 134)
        Me.cboxClassesCompanion.Name = "cboxClassesCompanion"
        Me.cboxClassesCompanion.Size = New System.Drawing.Size(107, 17)
        Me.cboxClassesCompanion.TabIndex = 13
        Me.cboxClassesCompanion.Text = "Companion Class"
        Me.cboxClassesCompanion.UseVisualStyleBackColor = True
        '
        'nudClassesUnits
        '
        Me.nudClassesUnits.Enabled = False
        Me.nudClassesUnits.Location = New System.Drawing.Point(108, 97)
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
        Me.Label8.Location = New System.Drawing.Point(62, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Units"
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(106, 62)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 63)
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
        Me.Curriculum.Controls.Add(Me.Button1)
        Me.Curriculum.Controls.Add(Me.TextBox1)
        Me.Curriculum.Controls.Add(Me.Label3)
        Me.Curriculum.Location = New System.Drawing.Point(4, 22)
        Me.Curriculum.Name = "Curriculum"
        Me.Curriculum.Padding = New System.Windows.Forms.Padding(3)
        Me.Curriculum.Size = New System.Drawing.Size(533, 381)
        Me.Curriculum.TabIndex = 1
        Me.Curriculum.Text = "Curriculum"
        Me.Curriculum.UseVisualStyleBackColor = True
        '
        'btnCurriculumAddElectives
        '
        Me.btnCurriculumAddElectives.Image = CType(resources.GetObject("btnCurriculumAddElectives.Image"), System.Drawing.Image)
        Me.btnCurriculumAddElectives.Location = New System.Drawing.Point(267, 252)
        Me.btnCurriculumAddElectives.Name = "btnCurriculumAddElectives"
        Me.btnCurriculumAddElectives.Size = New System.Drawing.Size(75, 50)
        Me.btnCurriculumAddElectives.TabIndex = 28
        Me.btnCurriculumAddElectives.UseVisualStyleBackColor = True
        '
        'btnCurriculumAddCore
        '
        Me.btnCurriculumAddCore.Image = CType(resources.GetObject("btnCurriculumAddCore.Image"), System.Drawing.Image)
        Me.btnCurriculumAddCore.Location = New System.Drawing.Point(267, 157)
        Me.btnCurriculumAddCore.Name = "btnCurriculumAddCore"
        Me.btnCurriculumAddCore.Size = New System.Drawing.Size(75, 50)
        Me.btnCurriculumAddCore.TabIndex = 27
        Me.btnCurriculumAddCore.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(366, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Electives "
        '
        'lboxCurriculumElective
        '
        Me.lboxCurriculumElective.FormattingEnabled = True
        Me.lboxCurriculumElective.Location = New System.Drawing.Point(357, 237)
        Me.lboxCurriculumElective.Name = "lboxCurriculumElective"
        Me.lboxCurriculumElective.Size = New System.Drawing.Size(158, 69)
        Me.lboxCurriculumElective.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(366, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Required Core"
        '
        'lboxCurriculumReqCore
        '
        Me.lboxCurriculumReqCore.FormattingEnabled = True
        Me.lboxCurriculumReqCore.Location = New System.Drawing.Point(357, 147)
        Me.lboxCurriculumReqCore.Name = "lboxCurriculumReqCore"
        Me.lboxCurriculumReqCore.Size = New System.Drawing.Size(158, 69)
        Me.lboxCurriculumReqCore.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(366, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Required GE "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Courses"
        '
        'btnCurriculumAddGE
        '
        Me.btnCurriculumAddGE.Image = CType(resources.GetObject("btnCurriculumAddGE.Image"), System.Drawing.Image)
        Me.btnCurriculumAddGE.Location = New System.Drawing.Point(267, 67)
        Me.btnCurriculumAddGE.Name = "btnCurriculumAddGE"
        Me.btnCurriculumAddGE.Size = New System.Drawing.Size(75, 50)
        Me.btnCurriculumAddGE.TabIndex = 9
        Me.btnCurriculumAddGE.UseVisualStyleBackColor = True
        '
        'btnCurriculumDrop
        '
        Me.btnCurriculumDrop.Image = CType(resources.GetObject("btnCurriculumDrop.Image"), System.Drawing.Image)
        Me.btnCurriculumDrop.Location = New System.Drawing.Point(186, 157)
        Me.btnCurriculumDrop.Name = "btnCurriculumDrop"
        Me.btnCurriculumDrop.Size = New System.Drawing.Size(75, 50)
        Me.btnCurriculumDrop.TabIndex = 8
        Me.btnCurriculumDrop.UseVisualStyleBackColor = True
        '
        'lboxCurriculumReqGE
        '
        Me.lboxCurriculumReqGE.FormattingEnabled = True
        Me.lboxCurriculumReqGE.Location = New System.Drawing.Point(357, 58)
        Me.lboxCurriculumReqGE.Name = "lboxCurriculumReqGE"
        Me.lboxCurriculumReqGE.Size = New System.Drawing.Size(158, 69)
        Me.lboxCurriculumReqGE.TabIndex = 7
        '
        'lboxCurriculumCourses
        '
        Me.lboxCurriculumCourses.FormattingEnabled = True
        Me.lboxCurriculumCourses.Location = New System.Drawing.Point(19, 58)
        Me.lboxCurriculumCourses.Name = "lboxCurriculumCourses"
        Me.lboxCurriculumCourses.Size = New System.Drawing.Size(158, 251)
        Me.lboxCurriculumCourses.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 20)
        Me.TextBox1.TabIndex = 4
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
        Me.Students.Controls.Add(Me.testbox)
        Me.Students.Controls.Add(Me.btnRandomGenerate)
        Me.Students.Controls.Add(Me.Label2)
        Me.Students.Controls.Add(Me.Button2)
        Me.Students.Controls.Add(Me.TextBox2)
        Me.Students.Location = New System.Drawing.Point(4, 22)
        Me.Students.Name = "Students"
        Me.Students.Size = New System.Drawing.Size(533, 381)
        Me.Students.TabIndex = 2
        Me.Students.Text = "Students"
        Me.Students.UseVisualStyleBackColor = True
        '
        'testbox
        '
        Me.testbox.Location = New System.Drawing.Point(221, 64)
        Me.testbox.Multiline = True
        Me.testbox.Name = "testbox"
        Me.testbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.testbox.Size = New System.Drawing.Size(232, 265)
        Me.testbox.TabIndex = 6
        '
        'btnRandomGenerate
        '
        Me.btnRandomGenerate.Location = New System.Drawing.Point(48, 323)
        Me.btnRandomGenerate.Name = "btnRandomGenerate"
        Me.btnRandomGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnRandomGenerate.TabIndex = 5
        Me.btnRandomGenerate.Text = "Generate!"
        Me.btnRandomGenerate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Import a File"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(366, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(106, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(254, 20)
        Me.TextBox2.TabIndex = 2
        '
        'DataGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 497)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "DataGenerator"
        Me.Text = "DataGenerator"
        Me.TabControl1.ResumeLayout(False)
        Me.Classes.ResumeLayout(False)
        Me.Classes.PerformLayout()
        CType(Me.nudClassesUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Curriculum.ResumeLayout(False)
        Me.Curriculum.PerformLayout()
        Me.Students.ResumeLayout(False)
        Me.Students.PerformLayout()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Students As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
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
    Friend WithEvents testbox As System.Windows.Forms.TextBox
End Class
