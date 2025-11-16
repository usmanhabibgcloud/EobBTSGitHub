<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecommendedByBTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecommendedByBTS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolActivity = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpRecommendedInfo = New System.Windows.Forms.GroupBox()
        Me.txtRecommendedDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRecommendedID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdRecommended = New System.Windows.Forms.DataGridView()
        Me.Sr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimantCNIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimantName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PensionStartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDeleteCaseRec = New System.Windows.Forms.Button()
        Me.txtDeleteCaseNo = New System.Windows.Forms.TextBox()
        Me.ToolActivity.SuspendLayout()
        Me.grpRecommendedInfo.SuspendLayout()
        CType(Me.grdRecommended, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolActivity
        '
        Me.ToolActivity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolActivity.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolActivity.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolActivity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnCancel, Me.btnDelete, Me.ToolStripSeparator1, Me.btnExit})
        Me.ToolActivity.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolActivity.Location = New System.Drawing.Point(0, 505)
        Me.ToolActivity.Name = "ToolActivity"
        Me.ToolActivity.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolActivity.Size = New System.Drawing.Size(1060, 39)
        Me.ToolActivity.TabIndex = 53
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
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1060, 31)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Recommendation of Claim Cases By Incharge BTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpRecommendedInfo
        '
        Me.grpRecommendedInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRecommendedInfo.Controls.Add(Me.txtRecommendedDate)
        Me.grpRecommendedInfo.Controls.Add(Me.dtDate)
        Me.grpRecommendedInfo.Controls.Add(Me.Label5)
        Me.grpRecommendedInfo.Controls.Add(Me.txtRecommendedID)
        Me.grpRecommendedInfo.Controls.Add(Me.Label3)
        Me.grpRecommendedInfo.Enabled = False
        Me.grpRecommendedInfo.Location = New System.Drawing.Point(8, 34)
        Me.grpRecommendedInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRecommendedInfo.Name = "grpRecommendedInfo"
        Me.grpRecommendedInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRecommendedInfo.Size = New System.Drawing.Size(883, 79)
        Me.grpRecommendedInfo.TabIndex = 52
        Me.grpRecommendedInfo.TabStop = False
        Me.grpRecommendedInfo.Text = "Case Recommended Info"
        '
        'txtRecommendedDate
        '
        Me.txtRecommendedDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtRecommendedDate.Location = New System.Drawing.Point(471, 27)
        Me.txtRecommendedDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRecommendedDate.Mask = "00/00/0000"
        Me.txtRecommendedDate.Name = "txtRecommendedDate"
        Me.txtRecommendedDate.Size = New System.Drawing.Size(124, 22)
        Me.txtRecommendedDate.TabIndex = 0
        Me.txtRecommendedDate.ValidatingType = GetType(Date)
        '
        'dtDate
        '
        Me.dtDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.dtDate.Enabled = False
        Me.dtDate.Location = New System.Drawing.Point(608, 27)
        Me.dtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(267, 22)
        Me.dtDate.TabIndex = 14
        Me.dtDate.TabStop = False
        Me.dtDate.Value = New Date(2012, 5, 23, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Case Recommended ID"
        '
        'txtRecommendedID
        '
        Me.txtRecommendedID.Location = New System.Drawing.Point(223, 27)
        Me.txtRecommendedID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRecommendedID.Name = "txtRecommendedID"
        Me.txtRecommendedID.ReadOnly = True
        Me.txtRecommendedID.Size = New System.Drawing.Size(168, 22)
        Me.txtRecommendedID.TabIndex = 5
        Me.txtRecommendedID.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(416, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date"
        '
        'grdRecommended
        '
        Me.grdRecommended.AllowUserToAddRows = False
        Me.grdRecommended.AllowUserToDeleteRows = False
        Me.grdRecommended.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdRecommended.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdRecommended.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRecommended.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdRecommended.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRecommended.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr, Me.FIRID, Me.FIRNo, Me.ClaimantCNIC, Me.ClaimantName, Me.PensionStartDate, Me.Remarks, Me.Del})
        Me.grdRecommended.Enabled = False
        Me.grdRecommended.Location = New System.Drawing.Point(8, 126)
        Me.grdRecommended.Margin = New System.Windows.Forms.Padding(4)
        Me.grdRecommended.Name = "grdRecommended"
        Me.grdRecommended.RowHeadersVisible = False
        Me.grdRecommended.Size = New System.Drawing.Size(1036, 353)
        Me.grdRecommended.TabIndex = 50
        '
        'Sr
        '
        Me.Sr.Frozen = True
        Me.Sr.HeaderText = "Sr#"
        Me.Sr.Name = "Sr"
        Me.Sr.ReadOnly = True
        Me.Sr.Width = 30
        '
        'FIRID
        '
        Me.FIRID.HeaderText = "FIRID"
        Me.FIRID.Name = "FIRID"
        Me.FIRID.ReadOnly = True
        Me.FIRID.Visible = False
        '
        'FIRNo
        '
        Me.FIRNo.HeaderText = "FIR No."
        Me.FIRNo.Name = "FIRNo"
        Me.FIRNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FIRNo.Width = 70
        '
        'ClaimantCNIC
        '
        DataGridViewCellStyle3.Format = "#####-#######-#"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ClaimantCNIC.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClaimantCNIC.HeaderText = "Claimant CNIC"
        Me.ClaimantCNIC.Name = "ClaimantCNIC"
        Me.ClaimantCNIC.Width = 120
        '
        'ClaimantName
        '
        Me.ClaimantName.HeaderText = "Claimant Name"
        Me.ClaimantName.Name = "ClaimantName"
        Me.ClaimantName.ReadOnly = True
        Me.ClaimantName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClaimantName.Width = 200
        '
        'PensionStartDate
        '
        DataGridViewCellStyle4.Format = "dd-MM-yyyy"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PensionStartDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.PensionStartDate.HeaderText = "Pension Start Date"
        Me.PensionStartDate.Name = "PensionStartDate"
        Me.PensionStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PensionStartDate.Width = 120
        '
        'Remarks
        '
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Remarks.DefaultCellStyle = DataGridViewCellStyle5
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Remarks.Width = 190
        '
        'Del
        '
        Me.Del.HeaderText = ""
        Me.Del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Del.Name = "Del"
        Me.Del.ReadOnly = True
        Me.Del.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Del.Width = 15
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
        'btnDeleteCaseRec
        '
        Me.btnDeleteCaseRec.Location = New System.Drawing.Point(898, 85)
        Me.btnDeleteCaseRec.Name = "btnDeleteCaseRec"
        Me.btnDeleteCaseRec.Size = New System.Drawing.Size(136, 28)
        Me.btnDeleteCaseRec.TabIndex = 54
        Me.btnDeleteCaseRec.TabStop = False
        Me.btnDeleteCaseRec.Text = "Delete Case"
        Me.btnDeleteCaseRec.UseVisualStyleBackColor = True
        '
        'txtDeleteCaseNo
        '
        Me.txtDeleteCaseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeleteCaseNo.Location = New System.Drawing.Point(898, 44)
        Me.txtDeleteCaseNo.MaxLength = 15
        Me.txtDeleteCaseNo.Name = "txtDeleteCaseNo"
        Me.txtDeleteCaseNo.Size = New System.Drawing.Size(136, 30)
        Me.txtDeleteCaseNo.TabIndex = 55
        Me.txtDeleteCaseNo.TabStop = False
        '
        'frmRecommendedByBTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 544)
        Me.Controls.Add(Me.txtDeleteCaseNo)
        Me.Controls.Add(Me.btnDeleteCaseRec)
        Me.Controls.Add(Me.ToolActivity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpRecommendedInfo)
        Me.Controls.Add(Me.grdRecommended)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRecommendedByBTS"
        Me.Text = "frmRecommendedByBTS"
        Me.ToolActivity.ResumeLayout(False)
        Me.ToolActivity.PerformLayout()
        Me.grpRecommendedInfo.ResumeLayout(False)
        Me.grpRecommendedInfo.PerformLayout()
        CType(Me.grdRecommended, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolActivity As ToolStrip
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents grpRecommendedInfo As GroupBox
    Friend WithEvents txtRecommendedDate As MaskedTextBox
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRecommendedID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grdRecommended As DataGridView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Sr As DataGridViewTextBoxColumn
    Friend WithEvents FIRID As DataGridViewTextBoxColumn
    Friend WithEvents FIRNo As DataGridViewTextBoxColumn
    Friend WithEvents ClaimantCNIC As DataGridViewTextBoxColumn
    Friend WithEvents ClaimantName As DataGridViewTextBoxColumn
    Friend WithEvents PensionStartDate As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents btnDeleteCaseRec As Button
    Friend WithEvents txtDeleteCaseNo As TextBox
End Class
