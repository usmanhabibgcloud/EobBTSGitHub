<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYearDef
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYearDef))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolActivity = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.grpYearInfo = New System.Windows.Forms.GroupBox()
        Me.txtEndDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtStartDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtStart = New System.Windows.Forms.DateTimePicker()
        Me.txtYearIdentifier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdYear = New System.Windows.Forms.DataGridView()
        Me.ToolActivity.SuspendLayout()
        Me.grpYearInfo.SuspendLayout()
        CType(Me.grdYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolActivity
        '
        Me.ToolActivity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolActivity.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolActivity.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolActivity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnCancel, Me.btnDelete, Me.ToolStripSeparator1, Me.btnExit})
        Me.ToolActivity.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolActivity.Location = New System.Drawing.Point(0, 380)
        Me.ToolActivity.Name = "ToolActivity"
        Me.ToolActivity.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolActivity.Size = New System.Drawing.Size(498, 39)
        Me.ToolActivity.TabIndex = 36
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
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(498, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Definition of Financial Year"
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
        'grpYearInfo
        '
        Me.grpYearInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpYearInfo.Controls.Add(Me.txtEndDate)
        Me.grpYearInfo.Controls.Add(Me.txtStartDate)
        Me.grpYearInfo.Controls.Add(Me.dtEnd)
        Me.grpYearInfo.Controls.Add(Me.dtStart)
        Me.grpYearInfo.Controls.Add(Me.txtYearIdentifier)
        Me.grpYearInfo.Controls.Add(Me.Label4)
        Me.grpYearInfo.Controls.Add(Me.Label3)
        Me.grpYearInfo.Controls.Add(Me.Label2)
        Me.grpYearInfo.Enabled = False
        Me.grpYearInfo.Location = New System.Drawing.Point(12, 28)
        Me.grpYearInfo.Name = "grpYearInfo"
        Me.grpYearInfo.Size = New System.Drawing.Size(482, 112)
        Me.grpYearInfo.TabIndex = 34
        Me.grpYearInfo.TabStop = False
        Me.grpYearInfo.Text = "Year Information"
        '
        'txtEndDate
        '
        Me.txtEndDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtEndDate.Location = New System.Drawing.Point(108, 81)
        Me.txtEndDate.Mask = "00/00/0000"
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(94, 20)
        Me.txtEndDate.TabIndex = 2
        Me.txtEndDate.ValidatingType = GetType(Date)
        '
        'txtStartDate
        '
        Me.txtStartDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtStartDate.Location = New System.Drawing.Point(108, 53)
        Me.txtStartDate.Mask = "00/00/0000"
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(94, 20)
        Me.txtStartDate.TabIndex = 1
        Me.txtStartDate.ValidatingType = GetType(Date)
        '
        'dtEnd
        '
        Me.dtEnd.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtEnd.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.dtEnd.Enabled = False
        Me.dtEnd.Location = New System.Drawing.Point(215, 81)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(257, 20)
        Me.dtEnd.TabIndex = 15
        Me.dtEnd.TabStop = False
        Me.dtEnd.Value = New Date(2012, 5, 23, 0, 0, 0, 0)
        '
        'dtStart
        '
        Me.dtStart.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtStart.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.dtStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtStart.Enabled = False
        Me.dtStart.Location = New System.Drawing.Point(215, 53)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(257, 20)
        Me.dtStart.TabIndex = 13
        Me.dtStart.TabStop = False
        Me.dtStart.Value = New Date(2012, 5, 23, 0, 0, 0, 0)
        '
        'txtYearIdentifier
        '
        Me.txtYearIdentifier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtYearIdentifier.Location = New System.Drawing.Point(108, 19)
        Me.txtYearIdentifier.Name = "txtYearIdentifier"
        Me.txtYearIdentifier.Size = New System.Drawing.Size(366, 20)
        Me.txtYearIdentifier.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Year End Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Year Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Year Identifier:"
        '
        'grdYear
        '
        Me.grdYear.AllowUserToAddRows = False
        Me.grdYear.AllowUserToDeleteRows = False
        Me.grdYear.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdYear.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdYear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdYear.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdYear.Location = New System.Drawing.Point(12, 152)
        Me.grdYear.Name = "grdYear"
        Me.grdYear.ReadOnly = True
        Me.grdYear.RowHeadersVisible = False
        Me.grdYear.Size = New System.Drawing.Size(482, 216)
        Me.grdYear.TabIndex = 3
        '
        'frmYearDef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 419)
        Me.Controls.Add(Me.ToolActivity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpYearInfo)
        Me.Controls.Add(Me.grdYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmYearDef"
        Me.Text = "frmYearDef"
        Me.ToolActivity.ResumeLayout(False)
        Me.ToolActivity.PerformLayout()
        Me.grpYearInfo.ResumeLayout(False)
        Me.grpYearInfo.PerformLayout()
        CType(Me.grdYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolActivity As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents grpYearInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdYear As System.Windows.Forms.DataGridView
    Friend WithEvents txtYearIdentifier As System.Windows.Forms.TextBox
    Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEndDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtStartDate As System.Windows.Forms.MaskedTextBox
End Class
