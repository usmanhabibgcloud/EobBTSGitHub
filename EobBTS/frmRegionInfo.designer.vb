<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegionInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegionInfo))
        Me.grpRegionInfo = New System.Windows.Forms.GroupBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.txtHeadOfficeAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRegionAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPhoneNos = New System.Windows.Forms.TextBox()
        Me.txtRegionName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolActivity = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMyRegion = New System.Windows.Forms.TextBox()
        Me.grpRegionInfo.SuspendLayout()
        Me.ToolActivity.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRegionInfo
        '
        Me.grpRegionInfo.Controls.Add(Me.txtMyRegion)
        Me.grpRegionInfo.Controls.Add(Me.Label5)
        Me.grpRegionInfo.Controls.Add(Me.txtWebsite)
        Me.grpRegionInfo.Controls.Add(Me.txtHeadOfficeAddress)
        Me.grpRegionInfo.Controls.Add(Me.Label6)
        Me.grpRegionInfo.Controls.Add(Me.Label4)
        Me.grpRegionInfo.Controls.Add(Me.txtRegionAddress)
        Me.grpRegionInfo.Controls.Add(Me.Label2)
        Me.grpRegionInfo.Controls.Add(Me.Label13)
        Me.grpRegionInfo.Controls.Add(Me.txtEmailAddress)
        Me.grpRegionInfo.Controls.Add(Me.Label18)
        Me.grpRegionInfo.Controls.Add(Me.txtPhoneNos)
        Me.grpRegionInfo.Controls.Add(Me.txtRegionName)
        Me.grpRegionInfo.Controls.Add(Me.Label3)
        Me.grpRegionInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpRegionInfo.Location = New System.Drawing.Point(2, 28)
        Me.grpRegionInfo.Name = "grpRegionInfo"
        Me.grpRegionInfo.Size = New System.Drawing.Size(640, 211)
        Me.grpRegionInfo.TabIndex = 10
        Me.grpRegionInfo.TabStop = False
        Me.grpRegionInfo.Text = "Region Information"
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(127, 174)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(505, 20)
        Me.txtWebsite.TabIndex = 8
        '
        'txtHeadOfficeAddress
        '
        Me.txtHeadOfficeAddress.Location = New System.Drawing.Point(127, 148)
        Me.txtHeadOfficeAddress.Name = "txtHeadOfficeAddress"
        Me.txtHeadOfficeAddress.Size = New System.Drawing.Size(505, 20)
        Me.txtHeadOfficeAddress.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Web Site"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Head Office Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRegionAddress
        '
        Me.txtRegionAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRegionAddress.Location = New System.Drawing.Point(127, 44)
        Me.txtRegionAddress.Name = "txtRegionAddress"
        Me.txtRegionAddress.Size = New System.Drawing.Size(505, 20)
        Me.txtRegionAddress.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Region Address"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(6, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 20)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Phone Number(s)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmailAddress.Location = New System.Drawing.Point(127, 96)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(505, 20)
        Me.txtEmailAddress.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 20)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Email Address"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhoneNos
        '
        Me.txtPhoneNos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhoneNos.Location = New System.Drawing.Point(127, 70)
        Me.txtPhoneNos.Name = "txtPhoneNos"
        Me.txtPhoneNos.Size = New System.Drawing.Size(505, 20)
        Me.txtPhoneNos.TabIndex = 2
        '
        'txtRegionName
        '
        Me.txtRegionName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRegionName.Location = New System.Drawing.Point(127, 18)
        Me.txtRegionName.Name = "txtRegionName"
        Me.txtRegionName.Size = New System.Drawing.Size(260, 20)
        Me.txtRegionName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Region Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(658, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Region Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolActivity
        '
        Me.ToolActivity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolActivity.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolActivity.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolActivity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnCancel, Me.btnDelete, Me.ToolStripSeparator1, Me.btnExit})
        Me.ToolActivity.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolActivity.Location = New System.Drawing.Point(0, 256)
        Me.ToolActivity.Name = "ToolActivity"
        Me.ToolActivity.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolActivity.Size = New System.Drawing.Size(658, 39)
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
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(393, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "My Region"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMyRegion
        '
        Me.txtMyRegion.Location = New System.Drawing.Point(475, 18)
        Me.txtMyRegion.Name = "txtMyRegion"
        Me.txtMyRegion.Size = New System.Drawing.Size(157, 20)
        Me.txtMyRegion.TabIndex = 47
        '
        'frmRegionInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 295)
        Me.Controls.Add(Me.ToolActivity)
        Me.Controls.Add(Me.grpRegionInfo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRegionInfo"
        Me.Text = "frmRegionInfo"
        Me.grpRegionInfo.ResumeLayout(False)
        Me.grpRegionInfo.PerformLayout()
        Me.ToolActivity.ResumeLayout(False)
        Me.ToolActivity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpRegionInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNos As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRegionName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRegionAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents txtHeadOfficeAddress As System.Windows.Forms.TextBox
    Friend WithEvents ToolActivity As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMyRegion As TextBox
    '    Friend WithEvents System2013DataSet As GL_APPLICATION.System2013DataSet
    '   Friend WithEvents Tbl_CompanyInfoTableAdapter As GL_APPLICATION.System2013DataSetTableAdapters.tbl_CompanyInfoTableAdapter
End Class
