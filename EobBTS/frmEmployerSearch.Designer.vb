<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployerSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdEmployersChild = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdEmployers = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Sr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployerCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Beat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActApplicability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdEmployersChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmployers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdEmployersChild
        '
        Me.grdEmployersChild.AllowUserToAddRows = False
        Me.grdEmployersChild.AllowUserToDeleteRows = False
        Me.grdEmployersChild.AllowUserToResizeColumns = False
        Me.grdEmployersChild.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        Me.grdEmployersChild.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdEmployersChild.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEmployersChild.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdEmployersChild.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdEmployersChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEmployersChild.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr, Me.EmployerCode, Me.EmployerName, Me.RegionName, Me.Beat, Me.ActApplicability, Me.RegDate, Me.ActiveStatus})
        Me.grdEmployersChild.Location = New System.Drawing.Point(1, 340)
        Me.grdEmployersChild.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEmployersChild.Name = "grdEmployersChild"
        Me.grdEmployersChild.RowHeadersVisible = False
        Me.grdEmployersChild.Size = New System.Drawing.Size(1164, 198)
        Me.grdEmployersChild.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(-5, 295)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1171, 38)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Selected Employers"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdEmployers
        '
        Me.grdEmployers.AllowUserToAddRows = False
        Me.grdEmployers.AllowUserToDeleteRows = False
        Me.grdEmployers.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Turquoise
        Me.grdEmployers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grdEmployers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdEmployers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdEmployers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEmployers.Location = New System.Drawing.Point(1, 86)
        Me.grdEmployers.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEmployers.Name = "grdEmployers"
        Me.grdEmployers.ReadOnly = True
        Me.grdEmployers.RowHeadersVisible = False
        Me.grdEmployers.Size = New System.Drawing.Size(1164, 206)
        Me.grdEmployers.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(1, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1164, 34)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Please Select Employers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(396, 15)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(752, 26)
        Me.txtDesc.TabIndex = 0
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(101, 15)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(188, 26)
        Me.txtCode.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(953, 545)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 28)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(831, 545)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(97, 28)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Reg No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Name"
        '
        'Sr
        '
        Me.Sr.Frozen = True
        Me.Sr.HeaderText = "Sr#"
        Me.Sr.Name = "Sr"
        Me.Sr.ReadOnly = True
        Me.Sr.Width = 40
        '
        'EmployerCode
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = Nothing
        Me.EmployerCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployerCode.HeaderText = "Employer Reg"
        Me.EmployerCode.Name = "EmployerCode"
        Me.EmployerCode.ReadOnly = True
        Me.EmployerCode.Width = 120
        '
        'EmployerName
        '
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployerName.DefaultCellStyle = DataGridViewCellStyle4
        Me.EmployerName.HeaderText = "Employer Name"
        Me.EmployerName.Name = "EmployerName"
        Me.EmployerName.ReadOnly = True
        Me.EmployerName.Width = 290
        '
        'RegionName
        '
        Me.RegionName.HeaderText = "Region"
        Me.RegionName.Name = "RegionName"
        Me.RegionName.ReadOnly = True
        '
        'Beat
        '
        Me.Beat.HeaderText = "Beat"
        Me.Beat.Name = "Beat"
        Me.Beat.ReadOnly = True
        Me.Beat.Width = 40
        '
        'ActApplicability
        '
        Me.ActApplicability.HeaderText = "Applicability of Act"
        Me.ActApplicability.Name = "ActApplicability"
        Me.ActApplicability.ReadOnly = True
        Me.ActApplicability.Width = 90
        '
        'RegDate
        '
        Me.RegDate.HeaderText = "Registration Date"
        Me.RegDate.Name = "RegDate"
        Me.RegDate.ReadOnly = True
        Me.RegDate.Width = 90
        '
        'ActiveStatus
        '
        Me.ActiveStatus.HeaderText = "Active Status"
        Me.ActiveStatus.Name = "ActiveStatus"
        Me.ActiveStatus.ReadOnly = True
        Me.ActiveStatus.Width = 80
        '
        'frmEmployerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1182, 576)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grdEmployersChild)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdEmployers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEmployerSearch"
        Me.Text = "frmEmployerSearch"
        CType(Me.grdEmployersChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmployers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdEmployersChild As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents grdEmployers As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Sr As DataGridViewTextBoxColumn
    Friend WithEvents EmployerCode As DataGridViewTextBoxColumn
    Friend WithEvents EmployerName As DataGridViewTextBoxColumn
    Friend WithEvents RegionName As DataGridViewTextBoxColumn
    Friend WithEvents Beat As DataGridViewTextBoxColumn
    Friend WithEvents ActApplicability As DataGridViewTextBoxColumn
    Friend WithEvents RegDate As DataGridViewTextBoxColumn
    Friend WithEvents ActiveStatus As DataGridViewTextBoxColumn
End Class
