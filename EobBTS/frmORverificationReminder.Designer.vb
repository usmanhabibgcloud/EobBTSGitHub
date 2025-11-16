<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmORverificationReminder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmORverificationReminder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolActivity = New System.Windows.Forms.ToolStrip()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.grdORVerification = New System.Windows.Forms.DataGridView()
        Me.Sr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRDetailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaimantName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Beat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstIntDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtORVerificationDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtORVerificationID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpORVerification = New System.Windows.Forms.GroupBox()
        Me.txtBeforeDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolActivity.SuspendLayout()
        CType(Me.grdORVerification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpORVerification.SuspendLayout()
        Me.SuspendLayout()
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
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(36, 36)
        Me.btnEdit.Text = "Edit"
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
        Me.ToolActivity.Location = New System.Drawing.Point(0, 406)
        Me.ToolActivity.Name = "ToolActivity"
        Me.ToolActivity.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolActivity.Size = New System.Drawing.Size(890, 39)
        Me.ToolActivity.TabIndex = 2
        Me.ToolActivity.Text = "ToolStrip1"
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
        'grdORVerification
        '
        Me.grdORVerification.AllowUserToAddRows = False
        Me.grdORVerification.AllowUserToDeleteRows = False
        Me.grdORVerification.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdORVerification.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdORVerification.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdORVerification.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdORVerification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdORVerification.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr, Me.FIRDetailID, Me.FIRID, Me.FIRNo, Me.ClaimantName, Me.IPName, Me.EmployerName, Me.RegionName, Me.Beat, Me.FirstIntDate, Me.Del})
        Me.grdORVerification.Enabled = False
        Me.grdORVerification.Location = New System.Drawing.Point(5, 127)
        Me.grdORVerification.Name = "grdORVerification"
        Me.grdORVerification.RowHeadersVisible = False
        Me.grdORVerification.Size = New System.Drawing.Size(872, 257)
        Me.grdORVerification.TabIndex = 1
        '
        'Sr
        '
        Me.Sr.Frozen = True
        Me.Sr.HeaderText = "Sr#"
        Me.Sr.Name = "Sr"
        Me.Sr.ReadOnly = True
        Me.Sr.Width = 30
        '
        'FIRDetailID
        '
        Me.FIRDetailID.HeaderText = "FIRDetailID"
        Me.FIRDetailID.Name = "FIRDetailID"
        Me.FIRDetailID.ReadOnly = True
        Me.FIRDetailID.Visible = False
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
        Me.FIRNo.ReadOnly = True
        Me.FIRNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FIRNo.Width = 70
        '
        'ClaimantName
        '
        Me.ClaimantName.HeaderText = "Claimant Name"
        Me.ClaimantName.Name = "ClaimantName"
        Me.ClaimantName.ReadOnly = True
        Me.ClaimantName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClaimantName.Width = 120
        '
        'IPName
        '
        Me.IPName.HeaderText = "IP Name"
        Me.IPName.Name = "IPName"
        Me.IPName.ReadOnly = True
        Me.IPName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IPName.Width = 120
        '
        'EmployerName
        '
        Me.EmployerName.HeaderText = "Employer Name"
        Me.EmployerName.Name = "EmployerName"
        Me.EmployerName.ReadOnly = True
        Me.EmployerName.Width = 220
        '
        'RegionName
        '
        Me.RegionName.HeaderText = "Region Name"
        Me.RegionName.Name = "RegionName"
        Me.RegionName.ReadOnly = True
        Me.RegionName.Width = 120
        '
        'Beat
        '
        Me.Beat.HeaderText = "Beat"
        Me.Beat.Name = "Beat"
        Me.Beat.ReadOnly = True
        Me.Beat.Width = 50
        '
        'FirstIntDate
        '
        DataGridViewCellStyle3.Format = "dd-MM-yyyy"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FirstIntDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.FirstIntDate.HeaderText = "First Intimation Date"
        Me.FirstIntDate.Name = "FirstIntDate"
        Me.FirstIntDate.ReadOnly = True
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
        'btnLoad
        '
        Me.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLoad.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLoad.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.Linen
        Me.btnLoad.Location = New System.Drawing.Point(518, 42)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(339, 34)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Reminders of OR Verification"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Please Enter the Date Before Which  The Reminder(s) Will Be Initiatede"
        '
        'txtORVerificationDate
        '
        Me.txtORVerificationDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtORVerificationDate.Location = New System.Drawing.Point(387, 14)
        Me.txtORVerificationDate.Mask = "00/00/0000"
        Me.txtORVerificationDate.Name = "txtORVerificationDate"
        Me.txtORVerificationDate.Size = New System.Drawing.Size(112, 20)
        Me.txtORVerificationDate.TabIndex = 0
        Me.txtORVerificationDate.ValidatingType = GetType(Date)
        '
        'dtDate
        '
        Me.dtDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.dtDate.Enabled = False
        Me.dtDate.Location = New System.Drawing.Point(518, 15)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(339, 20)
        Me.dtDate.TabIndex = 14
        Me.dtDate.TabStop = False
        Me.dtDate.Value = New Date(2012, 5, 23, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "OR Verification ID"
        '
        'txtORVerificationID
        '
        Me.txtORVerificationID.Location = New System.Drawing.Point(134, 15)
        Me.txtORVerificationID.Name = "txtORVerificationID"
        Me.txtORVerificationID.ReadOnly = True
        Me.txtORVerificationID.Size = New System.Drawing.Size(197, 20)
        Me.txtORVerificationID.TabIndex = 5
        Me.txtORVerificationID.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date"
        '
        'grpORVerification
        '
        Me.grpORVerification.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpORVerification.Controls.Add(Me.txtBeforeDate)
        Me.grpORVerification.Controls.Add(Me.btnLoad)
        Me.grpORVerification.Controls.Add(Me.Label2)
        Me.grpORVerification.Controls.Add(Me.txtORVerificationDate)
        Me.grpORVerification.Controls.Add(Me.dtDate)
        Me.grpORVerification.Controls.Add(Me.Label5)
        Me.grpORVerification.Controls.Add(Me.txtORVerificationID)
        Me.grpORVerification.Controls.Add(Me.Label3)
        Me.grpORVerification.Enabled = False
        Me.grpORVerification.Location = New System.Drawing.Point(6, 35)
        Me.grpORVerification.Name = "grpORVerification"
        Me.grpORVerification.Size = New System.Drawing.Size(872, 86)
        Me.grpORVerification.TabIndex = 0
        Me.grpORVerification.TabStop = False
        Me.grpORVerification.Text = "Other Region Verification Reminders"
        '
        'txtBeforeDate
        '
        Me.txtBeforeDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtBeforeDate.Location = New System.Drawing.Point(387, 51)
        Me.txtBeforeDate.Mask = "00/00/0000"
        Me.txtBeforeDate.Name = "txtBeforeDate"
        Me.txtBeforeDate.Size = New System.Drawing.Size(112, 20)
        Me.txtBeforeDate.TabIndex = 1
        Me.txtBeforeDate.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(890, 25)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Other Region Verifcation Reminder Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmORverificationReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 445)
        Me.Controls.Add(Me.ToolActivity)
        Me.Controls.Add(Me.grdORVerification)
        Me.Controls.Add(Me.grpORVerification)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmORverificationReminder"
        Me.Text = "OtherRegionVerificationReminder"
        Me.ToolActivity.ResumeLayout(False)
        Me.ToolActivity.PerformLayout()
        CType(Me.grdORVerification, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpORVerification.ResumeLayout(False)
        Me.grpORVerification.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolActivity As ToolStrip
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents grdORVerification As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtORVerificationDate As MaskedTextBox
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtORVerificationID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grpORVerification As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Sr As DataGridViewTextBoxColumn
    Friend WithEvents FIRDetailID As DataGridViewTextBoxColumn
    Friend WithEvents FIRID As DataGridViewTextBoxColumn
    Friend WithEvents FIRNo As DataGridViewTextBoxColumn
    Friend WithEvents ClaimantName As DataGridViewTextBoxColumn
    Friend WithEvents IPName As DataGridViewTextBoxColumn
    Friend WithEvents EmployerName As DataGridViewTextBoxColumn
    Friend WithEvents RegionName As DataGridViewTextBoxColumn
    Friend WithEvents Beat As DataGridViewTextBoxColumn
    Friend WithEvents FirstIntDate As DataGridViewTextBoxColumn
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents txtBeforeDate As MaskedTextBox
End Class
