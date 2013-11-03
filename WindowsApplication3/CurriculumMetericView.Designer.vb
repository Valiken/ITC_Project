<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurriculumMetericView
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbxCurriclum = New System.Windows.Forms.ComboBox()
        Me.ClassBox = New System.Windows.Forms.GroupBox()
        Me.lblCompanion = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblPrereq = New System.Windows.Forms.Label()
        Me.lbxCurriculum = New System.Windows.Forms.ListBox()
        Me.lblCurriculumTitle = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAvgRemaining = New System.Windows.Forms.Label()
        Me.lblAvgUnits = New System.Windows.Forms.Label()
        Me.lblMinUnit = New System.Windows.Forms.Label()
        Me.lblMaxUnit = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStdTotal = New System.Windows.Forms.Label()
        Me.lblAvgTime = New System.Windows.Forms.Label()
        Me.lblMaxTime = New System.Windows.Forms.Label()
        Me.lblMinTime = New System.Windows.Forms.Label()
        Me.lblMetricsTitle = New System.Windows.Forms.Label()
        Me.lblGrad = New System.Windows.Forms.Label()
        Me.lblDropOut = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.ClassBox.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.cmbxCurriclum)
        Me.TabPage2.Controls.Add(Me.ClassBox)
        Me.TabPage2.Controls.Add(Me.lbxCurriculum)
        Me.TabPage2.Controls.Add(Me.lblCurriculumTitle)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(801, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Curriculum View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label8.Location = New System.Drawing.Point(157, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Select Curriculum:"
        '
        'cmbxCurriclum
        '
        Me.cmbxCurriclum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCurriclum.FormattingEnabled = True
        Me.cmbxCurriclum.Location = New System.Drawing.Point(277, 32)
        Me.cmbxCurriclum.Name = "cmbxCurriclum"
        Me.cmbxCurriclum.Size = New System.Drawing.Size(159, 21)
        Me.cmbxCurriclum.TabIndex = 19
        '
        'ClassBox
        '
        Me.ClassBox.Controls.Add(Me.lblCompanion)
        Me.ClassBox.Controls.Add(Me.lblUnit)
        Me.ClassBox.Controls.Add(Me.lblPrereq)
        Me.ClassBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassBox.Location = New System.Drawing.Point(157, 57)
        Me.ClassBox.Name = "ClassBox"
        Me.ClassBox.Size = New System.Drawing.Size(593, 117)
        Me.ClassBox.TabIndex = 18
        Me.ClassBox.TabStop = False
        Me.ClassBox.Text = "ClassBox"
        '
        'lblCompanion
        '
        Me.lblCompanion.AutoSize = True
        Me.lblCompanion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanion.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblCompanion.Location = New System.Drawing.Point(6, 81)
        Me.lblCompanion.Name = "lblCompanion"
        Me.lblCompanion.Size = New System.Drawing.Size(131, 18)
        Me.lblCompanion.TabIndex = 17
        Me.lblCompanion.Text = "Companion Class:"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblUnit.Location = New System.Drawing.Point(6, 34)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(46, 18)
        Me.lblUnit.TabIndex = 15
        Me.lblUnit.Text = "Units:"
        '
        'lblPrereq
        '
        Me.lblPrereq.AutoSize = True
        Me.lblPrereq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrereq.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblPrereq.Location = New System.Drawing.Point(6, 57)
        Me.lblPrereq.Name = "lblPrereq"
        Me.lblPrereq.Size = New System.Drawing.Size(86, 18)
        Me.lblPrereq.TabIndex = 16
        Me.lblPrereq.Text = "Prerequisite"
        '
        'lbxCurriculum
        '
        Me.lbxCurriculum.FormattingEnabled = True
        Me.lbxCurriculum.Location = New System.Drawing.Point(9, 30)
        Me.lbxCurriculum.Name = "lbxCurriculum"
        Me.lbxCurriculum.Size = New System.Drawing.Size(142, 524)
        Me.lbxCurriculum.TabIndex = 13
        '
        'lblCurriculumTitle
        '
        Me.lblCurriculumTitle.AutoSize = True
        Me.lblCurriculumTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurriculumTitle.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblCurriculumTitle.Location = New System.Drawing.Point(301, 3)
        Me.lblCurriculumTitle.Name = "lblCurriculumTitle"
        Me.lblCurriculumTitle.Size = New System.Drawing.Size(142, 24)
        Me.lblCurriculumTitle.TabIndex = 12
        Me.lblCurriculumTitle.Text = "Curriculum Title"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.lblMetricsTitle)
        Me.TabPage1.Controls.Add(Me.lblGrad)
        Me.TabPage1.Controls.Add(Me.lblDropOut)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(801, 567)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Metrics View "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAvgRemaining)
        Me.GroupBox2.Controls.Add(Me.lblAvgUnits)
        Me.GroupBox2.Controls.Add(Me.lblMinUnit)
        Me.GroupBox2.Controls.Add(Me.lblMaxUnit)
        Me.GroupBox2.Location = New System.Drawing.Point(237, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 106)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Unit Metrics"
        '
        'lblAvgRemaining
        '
        Me.lblAvgRemaining.AutoSize = True
        Me.lblAvgRemaining.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblAvgRemaining.Location = New System.Drawing.Point(6, 16)
        Me.lblAvgRemaining.Name = "lblAvgRemaining"
        Me.lblAvgRemaining.Size = New System.Drawing.Size(133, 13)
        Me.lblAvgRemaining.TabIndex = 6
        Me.lblAvgRemaining.Text = "Average Remaining Units: "
        '
        'lblAvgUnits
        '
        Me.lblAvgUnits.AutoSize = True
        Me.lblAvgUnits.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblAvgUnits.Location = New System.Drawing.Point(6, 38)
        Me.lblAvgUnits.Name = "lblAvgUnits"
        Me.lblAvgUnits.Size = New System.Drawing.Size(114, 13)
        Me.lblAvgUnits.TabIndex = 7
        Me.lblAvgUnits.Text = "Average Units Taken: "
        '
        'lblMinUnit
        '
        Me.lblMinUnit.AutoSize = True
        Me.lblMinUnit.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblMinUnit.Location = New System.Drawing.Point(6, 61)
        Me.lblMinUnit.Name = "lblMinUnit"
        Me.lblMinUnit.Size = New System.Drawing.Size(106, 13)
        Me.lblMinUnit.TabIndex = 8
        Me.lblMinUnit.Text = "Minimum units taken:"
        '
        'lblMaxUnit
        '
        Me.lblMaxUnit.AutoSize = True
        Me.lblMaxUnit.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblMaxUnit.Location = New System.Drawing.Point(6, 83)
        Me.lblMaxUnit.Name = "lblMaxUnit"
        Me.lblMaxUnit.Size = New System.Drawing.Size(112, 13)
        Me.lblMaxUnit.TabIndex = 9
        Me.lblMaxUnit.Text = "Maximum units taken: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStdTotal)
        Me.GroupBox1.Controls.Add(Me.lblAvgTime)
        Me.GroupBox1.Controls.Add(Me.lblMaxTime)
        Me.GroupBox1.Controls.Add(Me.lblMinTime)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 106)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time Metrics"
        '
        'lblStdTotal
        '
        Me.lblStdTotal.AutoSize = True
        Me.lblStdTotal.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblStdTotal.Location = New System.Drawing.Point(6, 83)
        Me.lblStdTotal.Name = "lblStdTotal"
        Me.lblStdTotal.Size = New System.Drawing.Size(74, 13)
        Me.lblStdTotal.TabIndex = 22
        Me.lblStdTotal.Text = "Student Total:"
        '
        'lblAvgTime
        '
        Me.lblAvgTime.AutoSize = True
        Me.lblAvgTime.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblAvgTime.Location = New System.Drawing.Point(6, 16)
        Me.lblAvgTime.Name = "lblAvgTime"
        Me.lblAvgTime.Size = New System.Drawing.Size(127, 13)
        Me.lblAvgTime.TabIndex = 3
        Me.lblAvgTime.Text = "Average Time in Quarters"
        '
        'lblMaxTime
        '
        Me.lblMaxTime.AutoSize = True
        Me.lblMaxTime.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblMaxTime.Location = New System.Drawing.Point(6, 61)
        Me.lblMaxTime.Name = "lblMaxTime"
        Me.lblMaxTime.Size = New System.Drawing.Size(111, 13)
        Me.lblMaxTime.TabIndex = 5
        Me.lblMaxTime.Text = "Maximum Time Taken"
        '
        'lblMinTime
        '
        Me.lblMinTime.AutoSize = True
        Me.lblMinTime.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblMinTime.Location = New System.Drawing.Point(6, 38)
        Me.lblMinTime.Name = "lblMinTime"
        Me.lblMinTime.Size = New System.Drawing.Size(108, 13)
        Me.lblMinTime.TabIndex = 4
        Me.lblMinTime.Text = "Minimum Time Taken"
        '
        'lblMetricsTitle
        '
        Me.lblMetricsTitle.AutoSize = True
        Me.lblMetricsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetricsTitle.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblMetricsTitle.Location = New System.Drawing.Point(9, 3)
        Me.lblMetricsTitle.Name = "lblMetricsTitle"
        Me.lblMetricsTitle.Size = New System.Drawing.Size(110, 24)
        Me.lblMetricsTitle.TabIndex = 0
        Me.lblMetricsTitle.Text = "Metrics Title"
        '
        'lblGrad
        '
        Me.lblGrad.AutoSize = True
        Me.lblGrad.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblGrad.Location = New System.Drawing.Point(9, 40)
        Me.lblGrad.Name = "lblGrad"
        Me.lblGrad.Size = New System.Drawing.Size(160, 13)
        Me.lblGrad.TabIndex = 1
        Me.lblGrad.Text = "Number of Graduated Students: "
        '
        'lblDropOut
        '
        Me.lblDropOut.AutoSize = True
        Me.lblDropOut.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblDropOut.Location = New System.Drawing.Point(10, 62)
        Me.lblDropOut.Name = "lblDropOut"
        Me.lblDropOut.Size = New System.Drawing.Size(113, 13)
        Me.lblDropOut.TabIndex = 2
        Me.lblDropOut.Text = "Number of Drop Outs: "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(-1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(809, 593)
        Me.TabControl1.TabIndex = 10
        '
        'CurriculumMetericView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.Name = "CurriculumMetericView"
        Me.Text = "Curriculum View"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ClassBox.ResumeLayout(False)
        Me.ClassBox.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAvgRemaining As System.Windows.Forms.Label
    Friend WithEvents lblAvgUnits As System.Windows.Forms.Label
    Friend WithEvents lblMinUnit As System.Windows.Forms.Label
    Friend WithEvents lblMaxUnit As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAvgTime As System.Windows.Forms.Label
    Friend WithEvents lblMaxTime As System.Windows.Forms.Label
    Friend WithEvents lblMinTime As System.Windows.Forms.Label
    Friend WithEvents lblMetricsTitle As System.Windows.Forms.Label
    Friend WithEvents lblGrad As System.Windows.Forms.Label
    Friend WithEvents lblDropOut As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents lblCurriculumTitle As System.Windows.Forms.Label
    Friend WithEvents lbxCurriculum As System.Windows.Forms.ListBox
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblPrereq As System.Windows.Forms.Label
    Friend WithEvents lblCompanion As System.Windows.Forms.Label
    Friend WithEvents ClassBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxCurriclum As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblStdTotal As System.Windows.Forms.Label
End Class
