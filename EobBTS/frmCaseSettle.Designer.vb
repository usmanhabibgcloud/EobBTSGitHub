<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaseSettle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaseSettle))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolActivity = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtSettleDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSettleID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.grpSettlementInfo = New System.Windows.Forms.GroupBox()
        Me.grdSettle = New System.Windows.Forms.DataGridView()
        Me.Sr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimantCNIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimantName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolActivity.SuspendLayout()
        Me.grpSettlementInfo.SuspendLayout()
        CType(Me.grdSettle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.Width = 15
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
        Me.ToolActivity.Location = New System.Drawing.Point(0, 393)
        Me.ToolActivity.Name = "ToolActivity"
        Me.ToolActivity.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolActivity.Size = New System.Drawing.Size(795, 39)
        Me.ToolActivity.TabIndex = 49
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
        'txtSettleDate
        '
        Me.txtSettleDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtSettleDate.Location = New System.Drawing.Point(282, 22)
        Me.txtSettleDate.Mask = "00/00/0000"
        Me.txtSettleDate.Name = "txtSettleDate"
        Me.txtSettleDate.Size = New System.Drawing.Size(94, 20)
        Me.txtSettleDate.TabIndex = 0
        Me.txtSettleDate.ValidatingType = GetType(Date)
        '
        'dtDate
        '
        Me.dtDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.dtDate.Enabled = False
        Me.dtDate.Location = New System.Drawing.Point(382, 22)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(380, 20)
        Me.dtDate.TabIndex = 14
        Me.dtDate.TabStop = False
        Me.dtDate.Value = New Date(2012, 5, 23, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Case Settle ID"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(795, 25)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Settlement of Claim Cases .... "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSettleID
        '
        Me.txtSettleID.Location = New System.Drawing.Point(96, 22)
        Me.txtSettleID.Name = "txtSettleID"
        Me.txtSettleID.ReadOnly = True
        Me.txtSettleID.Size = New System.Drawing.Size(127, 20)
        Me.txtSettleID.TabIndex = 5
        Me.txtSettleID.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 15
        '
        'grpSettlementInfo
        '
        Me.grpSettlementInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSettlementInfo.Controls.Add(Me.txtSettleDate)
        Me.grpSettlementInfo.Controls.Add(Me.dtDate)
        Me.grpSettlementInfo.Controls.Add(Me.Label5)
        Me.grpSettlementInfo.Controls.Add(Me.txtSettleID)
        Me.grpSettlementInfo.Controls.Add(Me.Label3)
        Me.grpSettlementInfo.Enabled = False
        Me.grpSettlementInfo.Location = New System.Drawing.Point(6, 28)
        Me.grpSettlementInfo.Name = "grpSettlementInfo"
        Me.grpSettlementInfo.Size = New System.Drawing.Size(777, 64)
        Me.grpSettlementInfo.TabIndex = 47
        Me.grpSettlementInfo.TabStop = False
        Me.grpSettlementInfo.Text = "Case Settlement Info"
        '
        'grdSettle
        '
        Me.grdSettle.AllowUserToAddRows = False
        Me.grdSettle.AllowUserToDeleteRows = False
        Me.grdSettle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdSettle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdSettle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSettle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdSettle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSettle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr, Me.FIRID, Me.FIRNo, Me.ClaimantCNIC, Me.ClaimantName, Me.ClaimNo, Me.Remarks, Me.Del})
        Me.grdSettle.Enabled = False
        Me.grdSettle.Location = New System.Drawing.Point(6, 102)
        Me.grdSettle.Name = "grdSettle"
        Me.grdSettle.RowHeadersVisible = False
        Me.grdSettle.Size = New System.Drawing.Size(777, 276)
        Me.grdSettle.TabIndex = 45
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
        'ClaimNo
        '
        Me.ClaimNo.HeaderText = "Claim Number"
        Me.ClaimNo.Name = "ClaimNo"
        Me.ClaimNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Remarks
        '
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Remarks.DefaultCellStyle = DataGridViewCellStyle4
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Remarks.Width = 210
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
        'frmCaseSettle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 432)
        Me.Controls.Add(Me.ToolActivity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpSettlementInfo)
        Me.Controls.Add(Me.grdSettle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCaseSettle"
        Me.Text = "frmCaseSettle"
        Me.ToolActivity.ResumeLayout(False)
        Me.ToolActivity.PerformLayout()
        Me.grpSettlementInfo.ResumeLayout(False)
        Me.grpSettlementInfo.PerformLayout()
        CType(Me.grdSettle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents ToolActivity As ToolStrip
    Friend WithEvents txtSettleDate As MaskedTextBox
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSettleID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents grpSettlementInfo As GroupBox
    Friend WithEvents grdSettle As DataGridView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Sr As DataGridViewTextBoxColumn
    Friend WithEvents FIRID As DataGridViewTextBoxColumn
    Friend WithEvents FIRNo As DataGridViewTextBoxColumn
    Friend WithEvents ClaimantCNIC As DataGridViewTextBoxColumn
    Friend WithEvents ClaimantName As DataGridViewTextBoxColumn
    Friend WithEvents ClaimNo As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Del As DataGridViewImageColumn
End Class
