<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmORVeriReminderPrint
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdVoucher = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpReminderType = New System.Windows.Forms.GroupBox()
        Me.OptMultiRpt = New System.Windows.Forms.RadioButton()
        Me.OptSingleRpt = New System.Windows.Forms.RadioButton()
        Me.grpReminderCopy = New System.Windows.Forms.GroupBox()
        Me.chkDDG3 = New System.Windows.Forms.CheckBox()
        Me.chkDDG2 = New System.Windows.Forms.CheckBox()
        Me.chkDDG1 = New System.Windows.Forms.CheckBox()
        CType(Me.grdVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReminderType.SuspendLayout()
        Me.grpReminderCopy.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdVoucher
        '
        Me.grdVoucher.AllowUserToAddRows = False
        Me.grdVoucher.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdVoucher.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdVoucher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdVoucher.Location = New System.Drawing.Point(5, 38)
        Me.grdVoucher.Name = "grdVoucher"
        Me.grdVoucher.ReadOnly = True
        Me.grdVoucher.RowHeadersVisible = False
        Me.grdVoucher.Size = New System.Drawing.Size(503, 326)
        Me.grdVoucher.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(721, 29)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Select  to Show Other Region Verifications  Reminder"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(373, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 28)
        Me.btnExit.TabIndex = 51
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(5, 388)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(193, 29)
        Me.btnOk.TabIndex = 50
        Me.btnOk.Text = "Ok/Show"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'grpReminderType
        '
        Me.grpReminderType.Controls.Add(Me.OptMultiRpt)
        Me.grpReminderType.Controls.Add(Me.OptSingleRpt)
        Me.grpReminderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReminderType.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.grpReminderType.Location = New System.Drawing.Point(514, 38)
        Me.grpReminderType.Name = "grpReminderType"
        Me.grpReminderType.Size = New System.Drawing.Size(195, 151)
        Me.grpReminderType.TabIndex = 53
        Me.grpReminderType.TabStop = False
        Me.grpReminderType.Text = "Select Reminder Type"
        '
        'OptMultiRpt
        '
        Me.OptMultiRpt.AutoSize = True
        Me.OptMultiRpt.Location = New System.Drawing.Point(6, 80)
        Me.OptMultiRpt.Name = "OptMultiRpt"
        Me.OptMultiRpt.Size = New System.Drawing.Size(167, 21)
        Me.OptMultiRpt.TabIndex = 1
        Me.OptMultiRpt.TabStop = True
        Me.OptMultiRpt.Text = "Multi Report Reminder"
        Me.OptMultiRpt.UseVisualStyleBackColor = True
        '
        'OptSingleRpt
        '
        Me.OptSingleRpt.AutoSize = True
        Me.OptSingleRpt.Checked = True
        Me.OptSingleRpt.Location = New System.Drawing.Point(6, 42)
        Me.OptSingleRpt.Name = "OptSingleRpt"
        Me.OptSingleRpt.Size = New System.Drawing.Size(177, 21)
        Me.OptSingleRpt.TabIndex = 0
        Me.OptSingleRpt.TabStop = True
        Me.OptSingleRpt.Text = "Single Report Reminder"
        Me.OptSingleRpt.UseVisualStyleBackColor = True
        '
        'grpReminderCopy
        '
        Me.grpReminderCopy.Controls.Add(Me.chkDDG3)
        Me.grpReminderCopy.Controls.Add(Me.chkDDG2)
        Me.grpReminderCopy.Controls.Add(Me.chkDDG1)
        Me.grpReminderCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReminderCopy.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.grpReminderCopy.Location = New System.Drawing.Point(514, 195)
        Me.grpReminderCopy.Name = "grpReminderCopy"
        Me.grpReminderCopy.Size = New System.Drawing.Size(195, 169)
        Me.grpReminderCopy.TabIndex = 54
        Me.grpReminderCopy.TabStop = False
        Me.grpReminderCopy.Text = "Reminder Copy"
        '
        'chkDDG3
        '
        Me.chkDDG3.AutoSize = True
        Me.chkDDG3.Location = New System.Drawing.Point(9, 113)
        Me.chkDDG3.Name = "chkDDG3"
        Me.chkDDG3.Size = New System.Drawing.Size(106, 21)
        Me.chkDDG3.TabIndex = 2
        Me.chkDDG3.Text = "DDG B C - III"
        Me.chkDDG3.UseVisualStyleBackColor = True
        '
        'chkDDG2
        '
        Me.chkDDG2.AutoSize = True
        Me.chkDDG2.Checked = True
        Me.chkDDG2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDDG2.Location = New System.Drawing.Point(9, 74)
        Me.chkDDG2.Name = "chkDDG2"
        Me.chkDDG2.Size = New System.Drawing.Size(103, 21)
        Me.chkDDG2.TabIndex = 1
        Me.chkDDG2.Text = "DDG B C - II"
        Me.chkDDG2.UseVisualStyleBackColor = True
        '
        'chkDDG1
        '
        Me.chkDDG1.AutoSize = True
        Me.chkDDG1.Location = New System.Drawing.Point(9, 33)
        Me.chkDDG1.Name = "chkDDG1"
        Me.chkDDG1.Size = New System.Drawing.Size(100, 21)
        Me.chkDDG1.TabIndex = 0
        Me.chkDDG1.Text = "DDG B C - I"
        Me.chkDDG1.UseVisualStyleBackColor = True
        '
        'frmORVeriReminderPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 419)
        Me.Controls.Add(Me.grpReminderCopy)
        Me.Controls.Add(Me.grpReminderType)
        Me.Controls.Add(Me.grdVoucher)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmORVeriReminderPrint"
        Me.Text = "frmORVeriReminderPrint"
        CType(Me.grdVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReminderType.ResumeLayout(False)
        Me.grpReminderType.PerformLayout()
        Me.grpReminderCopy.ResumeLayout(False)
        Me.grpReminderCopy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdVoucher As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents grpReminderType As GroupBox
    Friend WithEvents grpReminderCopy As GroupBox
    Friend WithEvents OptMultiRpt As RadioButton
    Friend WithEvents OptSingleRpt As RadioButton
    Friend WithEvents chkDDG3 As CheckBox
    Friend WithEvents chkDDG2 As CheckBox
    Friend WithEvents chkDDG1 As CheckBox
End Class
