<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPendingCasesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCasesRecommended = New System.Windows.Forms.RadioButton()
        Me.rbPendingCasesWithReason = New System.Windows.Forms.RadioButton()
        Me.rbRecommendedNotSet = New System.Windows.Forms.RadioButton()
        Me.rbPendingCasesExRecom = New System.Windows.Forms.RadioButton()
        Me.rbPendingConverted = New System.Windows.Forms.RadioButton()
        Me.rbPendigRCC = New System.Windows.Forms.RadioButton()
        Me.rbPendingLocalVerification = New System.Windows.Forms.RadioButton()
        Me.rbPendingORVerification = New System.Windows.Forms.RadioButton()
        Me.rbPendingCases = New System.Windows.Forms.RadioButton()
        Me.rbFIRRegister = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtDate_From = New System.Windows.Forms.DateTimePicker()
        Me.dtDate_To = New System.Windows.Forms.DateTimePicker()
        Me.rbDateRange = New System.Windows.Forms.RadioButton()
        Me.rbCompleteRange = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(562, 29)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Please Select Range Option"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCasesRecommended)
        Me.GroupBox1.Controls.Add(Me.rbPendingCasesWithReason)
        Me.GroupBox1.Controls.Add(Me.rbRecommendedNotSet)
        Me.GroupBox1.Controls.Add(Me.rbPendingCasesExRecom)
        Me.GroupBox1.Controls.Add(Me.rbPendingConverted)
        Me.GroupBox1.Controls.Add(Me.rbPendigRCC)
        Me.GroupBox1.Controls.Add(Me.rbPendingLocalVerification)
        Me.GroupBox1.Controls.Add(Me.rbPendingORVerification)
        Me.GroupBox1.Controls.Add(Me.rbPendingCases)
        Me.GroupBox1.Controls.Add(Me.rbFIRRegister)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 327)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'rbCasesRecommended
        '
        Me.rbCasesRecommended.AutoSize = True
        Me.rbCasesRecommended.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCasesRecommended.ForeColor = System.Drawing.Color.Purple
        Me.rbCasesRecommended.Location = New System.Drawing.Point(23, 251)
        Me.rbCasesRecommended.Name = "rbCasesRecommended"
        Me.rbCasesRecommended.Size = New System.Drawing.Size(230, 24)
        Me.rbCasesRecommended.TabIndex = 31
        Me.rbCasesRecommended.Text = "Cases Recommended Detail"
        Me.rbCasesRecommended.UseVisualStyleBackColor = True
        '
        'rbPendingCasesWithReason
        '
        Me.rbPendingCasesWithReason.AutoSize = True
        Me.rbPendingCasesWithReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendingCasesWithReason.ForeColor = System.Drawing.Color.Maroon
        Me.rbPendingCasesWithReason.Location = New System.Drawing.Point(23, 62)
        Me.rbPendingCasesWithReason.Name = "rbPendingCasesWithReason"
        Me.rbPendingCasesWithReason.Size = New System.Drawing.Size(482, 24)
        Me.rbPendingCasesWithReason.TabIndex = 30
        Me.rbPendingCasesWithReason.Text = "Pending Cases (Excl. Recommended) With Reason of Pendency"
        Me.rbPendingCasesWithReason.UseVisualStyleBackColor = True
        '
        'rbRecommendedNotSet
        '
        Me.rbRecommendedNotSet.AutoSize = True
        Me.rbRecommendedNotSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecommendedNotSet.ForeColor = System.Drawing.Color.Maroon
        Me.rbRecommendedNotSet.Location = New System.Drawing.Point(23, 110)
        Me.rbRecommendedNotSet.Name = "rbRecommendedNotSet"
        Me.rbRecommendedNotSet.Size = New System.Drawing.Size(296, 24)
        Me.rbRecommendedNotSet.TabIndex = 29
        Me.rbRecommendedNotSet.Text = "Cases Recommended but Not Settled"
        Me.rbRecommendedNotSet.UseVisualStyleBackColor = True
        '
        'rbPendingCasesExRecom
        '
        Me.rbPendingCasesExRecom.AutoSize = True
        Me.rbPendingCasesExRecom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendingCasesExRecom.ForeColor = System.Drawing.Color.Maroon
        Me.rbPendingCasesExRecom.Location = New System.Drawing.Point(23, 38)
        Me.rbPendingCasesExRecom.Name = "rbPendingCasesExRecom"
        Me.rbPendingCasesExRecom.Size = New System.Drawing.Size(316, 24)
        Me.rbPendingCasesExRecom.TabIndex = 28
        Me.rbPendingCasesExRecom.Text = "Pending Cases Excluded Recommended"
        Me.rbPendingCasesExRecom.UseVisualStyleBackColor = True
        '
        'rbPendingConverted
        '
        Me.rbPendingConverted.AutoSize = True
        Me.rbPendingConverted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendingConverted.ForeColor = System.Drawing.Color.Maroon
        Me.rbPendingConverted.Location = New System.Drawing.Point(23, 86)
        Me.rbPendingConverted.Name = "rbPendingConverted"
        Me.rbPendingConverted.Size = New System.Drawing.Size(246, 24)
        Me.rbPendingConverted.TabIndex = 27
        Me.rbPendingConverted.Text = "Pending Converted Cases Only"
        Me.rbPendingConverted.UseVisualStyleBackColor = True
        '
        'rbPendigRCC
        '
        Me.rbPendigRCC.AutoSize = True
        Me.rbPendigRCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendigRCC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPendigRCC.Location = New System.Drawing.Point(23, 195)
        Me.rbPendigRCC.Name = "rbPendigRCC"
        Me.rbPendigRCC.Size = New System.Drawing.Size(123, 24)
        Me.rbPendigRCC.TabIndex = 10
        Me.rbPendigRCC.Text = "Pending RCC"
        Me.rbPendigRCC.UseVisualStyleBackColor = True
        '
        'rbPendingLocalVerification
        '
        Me.rbPendingLocalVerification.AutoSize = True
        Me.rbPendingLocalVerification.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendingLocalVerification.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.rbPendingLocalVerification.Location = New System.Drawing.Point(23, 147)
        Me.rbPendingLocalVerification.Name = "rbPendingLocalVerification"
        Me.rbPendingLocalVerification.Size = New System.Drawing.Size(210, 24)
        Me.rbPendingLocalVerification.TabIndex = 2
        Me.rbPendingLocalVerification.Text = "Pending Local Verification"
        Me.rbPendingLocalVerification.UseVisualStyleBackColor = True
        '
        'rbPendingORVerification
        '
        Me.rbPendingORVerification.AutoSize = True
        Me.rbPendingORVerification.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendingORVerification.ForeColor = System.Drawing.Color.SeaGreen
        Me.rbPendingORVerification.Location = New System.Drawing.Point(23, 171)
        Me.rbPendingORVerification.Name = "rbPendingORVerification"
        Me.rbPendingORVerification.Size = New System.Drawing.Size(196, 24)
        Me.rbPendingORVerification.TabIndex = 1
        Me.rbPendingORVerification.Text = "Pending OR Verification"
        Me.rbPendingORVerification.UseVisualStyleBackColor = True
        '
        'rbPendingCases
        '
        Me.rbPendingCases.AutoSize = True
        Me.rbPendingCases.Checked = True
        Me.rbPendingCases.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendingCases.ForeColor = System.Drawing.Color.Maroon
        Me.rbPendingCases.Location = New System.Drawing.Point(23, 14)
        Me.rbPendingCases.Name = "rbPendingCases"
        Me.rbPendingCases.Size = New System.Drawing.Size(134, 24)
        Me.rbPendingCases.TabIndex = 0
        Me.rbPendingCases.TabStop = True
        Me.rbPendingCases.Text = "Pending Cases"
        Me.rbPendingCases.UseVisualStyleBackColor = True
        '
        'rbFIRRegister
        '
        Me.rbFIRRegister.AutoSize = True
        Me.rbFIRRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFIRRegister.ForeColor = System.Drawing.Color.Purple
        Me.rbFIRRegister.Location = New System.Drawing.Point(23, 275)
        Me.rbFIRRegister.Name = "rbFIRRegister"
        Me.rbFIRRegister.Size = New System.Drawing.Size(118, 24)
        Me.rbFIRRegister.TabIndex = 3
        Me.rbFIRRegister.Text = "FIR Register"
        Me.rbFIRRegister.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(341, 438)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 28)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(48, 438)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(97, 29)
        Me.btnOk.TabIndex = 42
        Me.btnOk.Text = "Ok/Show"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtDate_From)
        Me.GroupBox2.Controls.Add(Me.dtDate_To)
        Me.GroupBox2.Controls.Add(Me.rbDateRange)
        Me.GroupBox2.Controls.Add(Me.rbCompleteRange)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(530, 43)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(388, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "To"
        '
        'dtDate_From
        '
        Me.dtDate_From.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate_From.Location = New System.Drawing.Point(284, 12)
        Me.dtDate_From.Name = "dtDate_From"
        Me.dtDate_From.Size = New System.Drawing.Size(97, 20)
        Me.dtDate_From.TabIndex = 32
        Me.dtDate_From.Value = New Date(2012, 5, 25, 0, 0, 0, 0)
        '
        'dtDate_To
        '
        Me.dtDate_To.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate_To.Location = New System.Drawing.Point(417, 12)
        Me.dtDate_To.Name = "dtDate_To"
        Me.dtDate_To.Size = New System.Drawing.Size(97, 20)
        Me.dtDate_To.TabIndex = 33
        Me.dtDate_To.Value = New Date(2012, 5, 25, 0, 0, 0, 0)
        '
        'rbDateRange
        '
        Me.rbDateRange.AutoSize = True
        Me.rbDateRange.Location = New System.Drawing.Point(193, 13)
        Me.rbDateRange.Name = "rbDateRange"
        Me.rbDateRange.Size = New System.Drawing.Size(83, 17)
        Me.rbDateRange.TabIndex = 1
        Me.rbDateRange.TabStop = True
        Me.rbDateRange.Text = "Date Range"
        Me.rbDateRange.UseVisualStyleBackColor = True
        '
        'rbCompleteRange
        '
        Me.rbCompleteRange.AutoSize = True
        Me.rbCompleteRange.Checked = True
        Me.rbCompleteRange.Location = New System.Drawing.Point(17, 13)
        Me.rbCompleteRange.Name = "rbCompleteRange"
        Me.rbCompleteRange.Size = New System.Drawing.Size(104, 17)
        Me.rbCompleteRange.TabIndex = 0
        Me.rbCompleteRange.TabStop = True
        Me.rbCompleteRange.Text = "Complete Range"
        Me.rbCompleteRange.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoEllipsis = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label9.Location = New System.Drawing.Point(0, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(542, 28)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Please Select Type of Report"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPendingCasesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 478)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPendingCasesReport"
        Me.Text = "Claim Cases Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbPendingORVerification As RadioButton
    Friend WithEvents rbPendingCases As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents rbPendingLocalVerification As RadioButton
    Friend WithEvents rbFIRRegister As RadioButton
    Friend WithEvents rbPendigRCC As RadioButton
    Friend WithEvents rbPendingConverted As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtDate_From As DateTimePicker
    Friend WithEvents dtDate_To As DateTimePicker
    Friend WithEvents rbDateRange As RadioButton
    Friend WithEvents rbCompleteRange As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents rbPendingCasesExRecom As RadioButton
    Friend WithEvents rbRecommendedNotSet As RadioButton
    Friend WithEvents rbPendingCasesWithReason As RadioButton
    Friend WithEvents rbCasesRecommended As RadioButton
End Class
