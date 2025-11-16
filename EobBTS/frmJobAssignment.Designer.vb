<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobAssignment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobAssignment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpJobInfo = New System.Windows.Forms.GroupBox()
        Me.txtAuditBy = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApprovedName = New System.Windows.Forms.TextBox()
        Me.txtCheckedName = New System.Windows.Forms.TextBox()
        Me.txtPreparedName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolActivity = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtCheckedName2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpJobInfo.SuspendLayout()
        Me.ToolActivity.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Job Assignment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpJobInfo
        '
        Me.grpJobInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpJobInfo.Controls.Add(Me.txtCheckedName2)
        Me.grpJobInfo.Controls.Add(Me.Label6)
        Me.grpJobInfo.Controls.Add(Me.txtAuditBy)
        Me.grpJobInfo.Controls.Add(Me.Label5)
        Me.grpJobInfo.Controls.Add(Me.txtApprovedName)
        Me.grpJobInfo.Controls.Add(Me.txtCheckedName)
        Me.grpJobInfo.Controls.Add(Me.txtPreparedName)
        Me.grpJobInfo.Controls.Add(Me.Label4)
        Me.grpJobInfo.Controls.Add(Me.Label2)
        Me.grpJobInfo.Controls.Add(Me.Label3)
        Me.grpJobInfo.Location = New System.Drawing.Point(6, 28)
        Me.grpJobInfo.Name = "grpJobInfo"
        Me.grpJobInfo.Size = New System.Drawing.Size(494, 190)
        Me.grpJobInfo.TabIndex = 54
        Me.grpJobInfo.TabStop = False
        Me.grpJobInfo.Text = "Job Information"
        '
        'txtAuditBy
        '
        Me.txtAuditBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuditBy.Location = New System.Drawing.Point(164, 112)
        Me.txtAuditBy.Name = "txtAuditBy"
        Me.txtAuditBy.Size = New System.Drawing.Size(324, 20)
        Me.txtAuditBy.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Audited By"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApprovedName
        '
        Me.txtApprovedName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApprovedName.Location = New System.Drawing.Point(164, 143)
        Me.txtApprovedName.Name = "txtApprovedName"
        Me.txtApprovedName.Size = New System.Drawing.Size(324, 20)
        Me.txtApprovedName.TabIndex = 24
        '
        'txtCheckedName
        '
        Me.txtCheckedName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheckedName.Location = New System.Drawing.Point(164, 49)
        Me.txtCheckedName.Name = "txtCheckedName"
        Me.txtCheckedName.Size = New System.Drawing.Size(324, 20)
        Me.txtCheckedName.TabIndex = 21
        '
        'txtPreparedName
        '
        Me.txtPreparedName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPreparedName.Location = New System.Drawing.Point(164, 20)
        Me.txtPreparedName.Name = "txtPreparedName"
        Me.txtPreparedName.Size = New System.Drawing.Size(324, 20)
        Me.txtPreparedName.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Approved By"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Prepared By"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Recommended By"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolActivity
        '
        Me.ToolActivity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolActivity.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolActivity.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolActivity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnCancel, Me.btnDelete, Me.ToolStripSeparator1, Me.btnExit})
        Me.ToolActivity.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolActivity.Location = New System.Drawing.Point(0, 233)
        Me.ToolActivity.Name = "ToolActivity"
        Me.ToolActivity.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolActivity.Size = New System.Drawing.Size(506, 39)
        Me.ToolActivity.TabIndex = 56
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
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(36, 36)
        Me.btnExit.Text = "Exit"
        '
        'txtCheckedName2
        '
        Me.txtCheckedName2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCheckedName2.Location = New System.Drawing.Point(164, 80)
        Me.txtCheckedName2.Name = "txtCheckedName2"
        Me.txtCheckedName2.Size = New System.Drawing.Size(324, 20)
        Me.txtCheckedName2.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 23)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Checked By2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmJobAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 272)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpJobInfo)
        Me.Controls.Add(Me.ToolActivity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmJobAssignment"
        Me.Text = "frmJobAssignment"
        Me.grpJobInfo.ResumeLayout(False)
        Me.grpJobInfo.PerformLayout()
        Me.ToolActivity.ResumeLayout(False)
        Me.ToolActivity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpJobInfo As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents ToolActivity As ToolStrip
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPreparedName As TextBox
    Friend WithEvents txtApprovedName As TextBox
    Friend WithEvents txtCheckedName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAuditBy As TextBox
    Friend WithEvents txtCheckedName2 As TextBox
    Friend WithEvents Label6 As Label
End Class
