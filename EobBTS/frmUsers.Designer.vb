<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.ToolActivity = New System.Windows.Forms.ToolStrip()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.treeUsers = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.chkEnable = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grdDetail = New System.Windows.Forms.DataGridView()
        Me.Sr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Access = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FYID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolActivity.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(36, 36)
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancel.Enabled = False
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(36, 36)
        Me.btnCancel.Text = "Cancel"
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(36, 36)
        Me.btnEdit.Text = "Edit"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(36, 36)
        Me.btnExit.Text = "Exit"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Enabled = False
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(36, 36)
        Me.btnDelete.Text = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(36, 36)
        Me.btnAdd.Text = "Add"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'txtUserName
        '
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Location = New System.Drawing.Point(116, 34)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(250, 20)
        Me.txtUserName.TabIndex = 14
        '
        'ToolActivity
        '
        Me.ToolActivity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolActivity.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolActivity.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolActivity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnCancel, Me.btnDelete, Me.ToolStripSeparator1, Me.btnExit})
        Me.ToolActivity.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolActivity.Location = New System.Drawing.Point(0, 363)
        Me.ToolActivity.Name = "ToolActivity"
        Me.ToolActivity.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolActivity.Size = New System.Drawing.Size(573, 39)
        Me.ToolActivity.TabIndex = 48
        Me.ToolActivity.Text = "ToolStrip1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "User Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'treeUsers
        '
        Me.treeUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeUsers.Location = New System.Drawing.Point(0, 0)
        Me.treeUsers.Name = "treeUsers"
        Me.treeUsers.Size = New System.Drawing.Size(189, 146)
        Me.treeUsers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(573, 25)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "User Description and His Role"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserID
        '
        Me.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserID.Location = New System.Drawing.Point(116, 10)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(175, 20)
        Me.txtUserID.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "User ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SplitContainer1
        '
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.treeUsers)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkEnable)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cboRole)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPassword)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtConfirm)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtUserName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtUserID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(568, 146)
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.TabIndex = 46
        '
        'chkEnable
        '
        Me.chkEnable.AutoSize = True
        Me.chkEnable.Checked = True
        Me.chkEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnable.Location = New System.Drawing.Point(307, 12)
        Me.chkEnable.Name = "chkEnable"
        Me.chkEnable.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkEnable.Size = New System.Drawing.Size(59, 17)
        Me.chkEnable.TabIndex = 32
        Me.chkEnable.Text = "Enable"
        Me.chkEnable.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 23)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "User Role"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboRole
        '
        Me.cboRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(116, 58)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(250, 21)
        Me.cboRole.TabIndex = 29
        '
        'txtPassword
        '
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.Location = New System.Drawing.Point(116, 83)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(250, 20)
        Me.txtPassword.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConfirm
        '
        Me.txtConfirm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfirm.Location = New System.Drawing.Point(116, 107)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New System.Drawing.Size(250, 20)
        Me.txtConfirm.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Confirm Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdDetail
        '
        Me.grdDetail.AllowUserToAddRows = False
        Me.grdDetail.AllowUserToDeleteRows = False
        Me.grdDetail.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki
        Me.grdDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr, Me.FYear, Me.Access, Me.FYID})
        Me.grdDetail.Enabled = False
        Me.grdDetail.Location = New System.Drawing.Point(0, 180)
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.RowHeadersVisible = False
        Me.grdDetail.Size = New System.Drawing.Size(570, 180)
        Me.grdDetail.TabIndex = 50
        '
        'Sr
        '
        Me.Sr.Frozen = True
        Me.Sr.HeaderText = "Sr#"
        Me.Sr.Name = "Sr"
        Me.Sr.ReadOnly = True
        Me.Sr.Width = 50
        '
        'FYear
        '
        Me.FYear.HeaderText = "Financial Year"
        Me.FYear.Name = "FYear"
        Me.FYear.Width = 400
        '
        'Access
        '
        Me.Access.HeaderText = "Access"
        Me.Access.Name = "Access"
        Me.Access.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Access.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Access.Width = 90
        '
        'FYID
        '
        Me.FYID.HeaderText = "FYID"
        Me.FYID.Name = "FYID"
        Me.FYID.Visible = False
        Me.FYID.Width = 85
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 402)
        Me.Controls.Add(Me.grdDetail)
        Me.Controls.Add(Me.ToolActivity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmUsers"
        Me.Text = "frmUsers"
        Me.ToolActivity.ResumeLayout(False)
        Me.ToolActivity.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents ToolActivity As System.Windows.Forms.ToolStrip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents treeUsers As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkEnable As System.Windows.Forms.CheckBox
    Friend WithEvents grdDetail As System.Windows.Forms.DataGridView
    Friend WithEvents Sr As DataGridViewTextBoxColumn
    Friend WithEvents FYear As DataGridViewTextBoxColumn
    Friend WithEvents Access As DataGridViewCheckBoxColumn
    Friend WithEvents FYID As DataGridViewTextBoxColumn
End Class
