<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeesDef
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeesDef))
        Me.grd = New System.Windows.Forms.DataGridView()
        Me.grpEmployee = New System.Windows.Forms.GroupBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTransferTo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDOJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.MaskedTextBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCNIC = New System.Windows.Forms.MaskedTextBox()
        Me.txtTransferFrom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPNo = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolActivity = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.cboEmployeeID = New System.Windows.Forms.ComboBox()
        Me.cbActive = New System.Windows.Forms.CheckBox()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmployee.SuspendLayout()
        Me.ToolActivity.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd
        '
        Me.grd.AllowUserToAddRows = False
        Me.grd.AllowUserToDeleteRows = False
        Me.grd.AllowUserToResizeColumns = False
        Me.grd.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Location = New System.Drawing.Point(5, 175)
        Me.grd.Name = "grd"
        Me.grd.ReadOnly = True
        Me.grd.RowHeadersVisible = False
        Me.grd.Size = New System.Drawing.Size(605, 200)
        Me.grd.TabIndex = 11
        '
        'grpEmployee
        '
        Me.grpEmployee.Controls.Add(Me.cbActive)
        Me.grpEmployee.Controls.Add(Me.cboStatus)
        Me.grpEmployee.Controls.Add(Me.Label13)
        Me.grpEmployee.Controls.Add(Me.txtTransferTo)
        Me.grpEmployee.Controls.Add(Me.Label6)
        Me.grpEmployee.Controls.Add(Me.txtDOJ)
        Me.grpEmployee.Controls.Add(Me.Label10)
        Me.grpEmployee.Controls.Add(Me.txtDOB)
        Me.grpEmployee.Controls.Add(Me.txtDesignation)
        Me.grpEmployee.Controls.Add(Me.Label12)
        Me.grpEmployee.Controls.Add(Me.txtGrade)
        Me.grpEmployee.Controls.Add(Me.Label11)
        Me.grpEmployee.Controls.Add(Me.txtFatherName)
        Me.grpEmployee.Controls.Add(Me.Label2)
        Me.grpEmployee.Controls.Add(Me.txtCNIC)
        Me.grpEmployee.Controls.Add(Me.txtTransferFrom)
        Me.grpEmployee.Controls.Add(Me.Label8)
        Me.grpEmployee.Controls.Add(Me.Label7)
        Me.grpEmployee.Controls.Add(Me.txtPNo)
        Me.grpEmployee.Controls.Add(Me.txtName)
        Me.grpEmployee.Controls.Add(Me.Label5)
        Me.grpEmployee.Controls.Add(Me.Label4)
        Me.grpEmployee.Controls.Add(Me.Label3)
        Me.grpEmployee.Location = New System.Drawing.Point(5, 32)
        Me.grpEmployee.Name = "grpEmployee"
        Me.grpEmployee.Size = New System.Drawing.Size(605, 137)
        Me.grpEmployee.TabIndex = 42
        Me.grpEmployee.TabStop = False
        Me.grpEmployee.Text = "Employee Information"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"In Service", "Retired"})
        Me.cboStatus.Location = New System.Drawing.Point(517, 16)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(78, 21)
        Me.cboStatus.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(468, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 23)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Status"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransferTo
        '
        Me.txtTransferTo.Location = New System.Drawing.Point(273, 100)
        Me.txtTransferTo.Name = "txtTransferTo"
        Me.txtTransferTo.Size = New System.Drawing.Size(132, 20)
        Me.txtTransferTo.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(198, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Transfer To"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDOJ
        '
        Me.txtDOJ.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtDOJ.Location = New System.Drawing.Point(90, 100)
        Me.txtDOJ.Mask = "00/00/0000"
        Me.txtDOJ.Name = "txtDOJ"
        Me.txtDOJ.RejectInputOnFirstFailure = True
        Me.txtDOJ.Size = New System.Drawing.Size(102, 20)
        Me.txtDOJ.TabIndex = 9
        Me.txtDOJ.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(13, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 20)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "D.O.Joining"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDOB
        '
        Me.txtDOB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtDOB.Location = New System.Drawing.Point(273, 71)
        Me.txtDOB.Mask = "00/00/0000"
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.RejectInputOnFirstFailure = True
        Me.txtDOB.Size = New System.Drawing.Size(88, 20)
        Me.txtDOB.TabIndex = 7
        Me.txtDOB.ValidatingType = GetType(Date)
        '
        'txtDesignation
        '
        Me.txtDesignation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesignation.Location = New System.Drawing.Point(424, 45)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(171, 20)
        Me.txtDesignation.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(350, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 23)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Designation"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrade
        '
        Me.txtGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrade.Location = New System.Drawing.Point(273, 45)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(71, 20)
        Me.txtGrade.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(213, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 23)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Grade"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFatherName
        '
        Me.txtFatherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFatherName.Location = New System.Drawing.Point(315, 18)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(151, 20)
        Me.txtFatherName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(236, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Father Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCNIC
        '
        Me.txtCNIC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtCNIC.Location = New System.Drawing.Point(90, 71)
        Me.txtCNIC.Mask = "#####-#######-#"
        Me.txtCNIC.Name = "txtCNIC"
        Me.txtCNIC.Size = New System.Drawing.Size(102, 20)
        Me.txtCNIC.TabIndex = 6
        '
        'txtTransferFrom
        '
        Me.txtTransferFrom.Location = New System.Drawing.Point(450, 71)
        Me.txtTransferFrom.Name = "txtTransferFrom"
        Me.txtTransferFrom.Size = New System.Drawing.Size(145, 20)
        Me.txtTransferFrom.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(368, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Transfer From"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(210, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "D.O.B"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPNo
        '
        Me.txtPNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPNo.Location = New System.Drawing.Point(90, 45)
        Me.txtPNo.Name = "txtPNo"
        Me.txtPNo.Size = New System.Drawing.Size(102, 20)
        Me.txtPNo.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(90, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(142, 20)
        Me.txtName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "CNIC"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "P.No."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(621, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Employee Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Save-1.jpg")
        Me.ImageList1.Images.SetKeyName(1, "Add-3.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Undo-2.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Delete-2.bmp")
        Me.ImageList1.Images.SetKeyName(4, "Exit-1.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Edit-1.jpg")
        '
        'ToolActivity
        '
        Me.ToolActivity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolActivity.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolActivity.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolActivity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnCancel, Me.btnDelete, Me.ToolStripSeparator1, Me.btnExit})
        Me.ToolActivity.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolActivity.Location = New System.Drawing.Point(0, 397)
        Me.ToolActivity.Name = "ToolActivity"
        Me.ToolActivity.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolActivity.Size = New System.Drawing.Size(621, 39)
        Me.ToolActivity.TabIndex = 44
        Me.ToolActivity.Text = "ToolStrip1"
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
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(36, 36)
        Me.btnEdit.Text = "Edit"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
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
        'cboEmployeeID
        '
        Me.cboEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployeeID.FormattingEnabled = True
        Me.cboEmployeeID.Location = New System.Drawing.Point(553, 0)
        Me.cboEmployeeID.Name = "cboEmployeeID"
        Me.cboEmployeeID.Size = New System.Drawing.Size(57, 21)
        Me.cboEmployeeID.TabIndex = 48
        Me.cboEmployeeID.Visible = False
        '
        'cbActive
        '
        Me.cbActive.AutoSize = True
        Me.cbActive.Checked = True
        Me.cbActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbActive.Location = New System.Drawing.Point(450, 103)
        Me.cbActive.Name = "cbActive"
        Me.cbActive.Size = New System.Drawing.Size(56, 17)
        Me.cbActive.TabIndex = 49
        Me.cbActive.Text = "Active"
        Me.cbActive.UseVisualStyleBackColor = True
        '
        'frmEmployeesDef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 436)
        Me.Controls.Add(Me.cboEmployeeID)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.grpEmployee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolActivity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEmployeesDef"
        Me.Text = "Employee Definition Form"
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmployee.ResumeLayout(False)
        Me.grpEmployee.PerformLayout()
        Me.ToolActivity.ResumeLayout(False)
        Me.ToolActivity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents grpEmployee As System.Windows.Forms.GroupBox
    Friend WithEvents txtCNIC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTransferFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPNo As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolActivity As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtFatherName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDOB As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDOJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTransferTo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cbActive As CheckBox
End Class
