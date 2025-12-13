<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaseUpdates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaseUpdates))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtIPRelativeName = New System.Windows.Forms.TextBox()
        Me.txtIPName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEOBINo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIPDOB = New System.Windows.Forms.MaskedTextBox()
        Me.grpIP = New System.Windows.Forms.GroupBox()
        Me.txtIPDeathDate = New System.Windows.Forms.MaskedTextBox()
        Me.optFemale2 = New System.Windows.Forms.RadioButton()
        Me.txtIPCNIC = New System.Windows.Forms.MaskedTextBox()
        Me.optMale2 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grpClaimant = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.optFemale1 = New System.Windows.Forms.RadioButton()
        Me.txtPreviousClaimNo = New System.Windows.Forms.TextBox()
        Me.optMale1 = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtClaimnatDOB = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtClaimantCNIC = New System.Windows.Forms.MaskedTextBox()
        Me.cboNatureOfBenefit = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClaimantRelativeName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClaimantName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFIRDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFIRNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolActivity = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.grdVoucher = New System.Windows.Forms.DataGridView()
        Me.Sr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseRemarksDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.grpIP.SuspendLayout()
        Me.grpClaimant.SuspendLayout()
        Me.ToolActivity.SuspendLayout()
        CType(Me.grdVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'txtIPRelativeName
        '
        Me.txtIPRelativeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPRelativeName.Location = New System.Drawing.Point(461, 16)
        Me.txtIPRelativeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIPRelativeName.Name = "txtIPRelativeName"
        Me.txtIPRelativeName.Size = New System.Drawing.Size(223, 26)
        Me.txtIPRelativeName.TabIndex = 1
        '
        'txtIPName
        '
        Me.txtIPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPName.Location = New System.Drawing.Point(116, 16)
        Me.txtIPName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIPName.Name = "txtIPName"
        Me.txtIPName.Size = New System.Drawing.Size(228, 26)
        Me.txtIPName.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(711, 52)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 38)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Date of Death" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(if Died)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEOBINo
        '
        Me.txtEOBINo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEOBINo.Location = New System.Drawing.Point(461, 54)
        Me.txtEOBINo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEOBINo.Name = "txtEOBINo"
        Me.txtEOBINo.Size = New System.Drawing.Size(220, 26)
        Me.txtEOBINo.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(361, 53)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "EOBI No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(173, 57)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 25)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "D.O.B"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(687, 17)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 25)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "IP CNIC"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(359, 22)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Relative Name"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1013, 31)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Claimant Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIPDOB
        '
        Me.txtIPDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPDOB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtIPDOB.Location = New System.Drawing.Point(236, 53)
        Me.txtIPDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIPDOB.Mask = "00/00/0000"
        Me.txtIPDOB.Name = "txtIPDOB"
        Me.txtIPDOB.Size = New System.Drawing.Size(107, 26)
        Me.txtIPDOB.TabIndex = 5
        Me.txtIPDOB.ValidatingType = GetType(Date)
        '
        'grpIP
        '
        Me.grpIP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpIP.Controls.Add(Me.txtIPDeathDate)
        Me.grpIP.Controls.Add(Me.txtIPDOB)
        Me.grpIP.Controls.Add(Me.optFemale2)
        Me.grpIP.Controls.Add(Me.txtIPCNIC)
        Me.grpIP.Controls.Add(Me.optMale2)
        Me.grpIP.Controls.Add(Me.txtIPRelativeName)
        Me.grpIP.Controls.Add(Me.txtIPName)
        Me.grpIP.Controls.Add(Me.Label16)
        Me.grpIP.Controls.Add(Me.txtEOBINo)
        Me.grpIP.Controls.Add(Me.Label10)
        Me.grpIP.Controls.Add(Me.Label11)
        Me.grpIP.Controls.Add(Me.Label12)
        Me.grpIP.Controls.Add(Me.Label13)
        Me.grpIP.Controls.Add(Me.Label14)
        Me.grpIP.Enabled = False
        Me.grpIP.Location = New System.Drawing.Point(16, 197)
        Me.grpIP.Margin = New System.Windows.Forms.Padding(4)
        Me.grpIP.Name = "grpIP"
        Me.grpIP.Padding = New System.Windows.Forms.Padding(4)
        Me.grpIP.Size = New System.Drawing.Size(981, 96)
        Me.grpIP.TabIndex = 64
        Me.grpIP.TabStop = False
        Me.grpIP.Text = "Insured Person Info"
        '
        'txtIPDeathDate
        '
        Me.txtIPDeathDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPDeathDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtIPDeathDate.Location = New System.Drawing.Point(820, 55)
        Me.txtIPDeathDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIPDeathDate.Mask = "00/00/0000"
        Me.txtIPDeathDate.Name = "txtIPDeathDate"
        Me.txtIPDeathDate.Size = New System.Drawing.Size(129, 26)
        Me.txtIPDeathDate.TabIndex = 7
        Me.txtIPDeathDate.ValidatingType = GetType(Date)
        '
        'optFemale2
        '
        Me.optFemale2.AutoSize = True
        Me.optFemale2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFemale2.Location = New System.Drawing.Point(83, 54)
        Me.optFemale2.Margin = New System.Windows.Forms.Padding(4)
        Me.optFemale2.Name = "optFemale2"
        Me.optFemale2.Size = New System.Drawing.Size(85, 24)
        Me.optFemale2.TabIndex = 4
        Me.optFemale2.Text = "Female"
        Me.optFemale2.UseVisualStyleBackColor = True
        '
        'txtIPCNIC
        '
        Me.txtIPCNIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPCNIC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtIPCNIC.Location = New System.Drawing.Point(803, 15)
        Me.txtIPCNIC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIPCNIC.Mask = "#####-#######-#"
        Me.txtIPCNIC.Name = "txtIPCNIC"
        Me.txtIPCNIC.Size = New System.Drawing.Size(147, 26)
        Me.txtIPCNIC.TabIndex = 2
        '
        'optMale2
        '
        Me.optMale2.AutoSize = True
        Me.optMale2.Checked = True
        Me.optMale2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMale2.Location = New System.Drawing.Point(9, 54)
        Me.optMale2.Margin = New System.Windows.Forms.Padding(4)
        Me.optMale2.Name = "optMale2"
        Me.optMale2.Size = New System.Drawing.Size(66, 24)
        Me.optMale2.TabIndex = 3
        Me.optMale2.TabStop = True
        Me.optMale2.Text = "Male"
        Me.optMale2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(45, 22)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "IP Name"
        '
        'grpClaimant
        '
        Me.grpClaimant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpClaimant.Controls.Add(Me.Label2)
        Me.grpClaimant.Controls.Add(Me.optFemale1)
        Me.grpClaimant.Controls.Add(Me.txtPreviousClaimNo)
        Me.grpClaimant.Controls.Add(Me.optMale1)
        Me.grpClaimant.Controls.Add(Me.Label9)
        Me.grpClaimant.Controls.Add(Me.txtClaimnatDOB)
        Me.grpClaimant.Controls.Add(Me.Label8)
        Me.grpClaimant.Controls.Add(Me.txtClaimantCNIC)
        Me.grpClaimant.Controls.Add(Me.cboNatureOfBenefit)
        Me.grpClaimant.Controls.Add(Me.Label4)
        Me.grpClaimant.Controls.Add(Me.txtClaimantRelativeName)
        Me.grpClaimant.Controls.Add(Me.Label7)
        Me.grpClaimant.Controls.Add(Me.txtClaimantName)
        Me.grpClaimant.Controls.Add(Me.Label6)
        Me.grpClaimant.Controls.Add(Me.txtFIRDate)
        Me.grpClaimant.Controls.Add(Me.dtDate)
        Me.grpClaimant.Controls.Add(Me.Label5)
        Me.grpClaimant.Controls.Add(Me.txtFIRNo)
        Me.grpClaimant.Controls.Add(Me.Label3)
        Me.grpClaimant.Enabled = False
        Me.grpClaimant.Location = New System.Drawing.Point(16, 30)
        Me.grpClaimant.Margin = New System.Windows.Forms.Padding(4)
        Me.grpClaimant.Name = "grpClaimant"
        Me.grpClaimant.Padding = New System.Windows.Forms.Padding(4)
        Me.grpClaimant.Size = New System.Drawing.Size(981, 133)
        Me.grpClaimant.TabIndex = 63
        Me.grpClaimant.TabStop = False
        Me.grpClaimant.Text = "Claimant Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Case Type"
        '
        'optFemale1
        '
        Me.optFemale1.AutoSize = True
        Me.optFemale1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFemale1.Location = New System.Drawing.Point(84, 94)
        Me.optFemale1.Margin = New System.Windows.Forms.Padding(4)
        Me.optFemale1.Name = "optFemale1"
        Me.optFemale1.Size = New System.Drawing.Size(85, 24)
        Me.optFemale1.TabIndex = 6
        Me.optFemale1.Text = "Female"
        Me.optFemale1.UseVisualStyleBackColor = True
        '
        'txtPreviousClaimNo
        '
        Me.txtPreviousClaimNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreviousClaimNo.Location = New System.Drawing.Point(839, 95)
        Me.txtPreviousClaimNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPreviousClaimNo.Name = "txtPreviousClaimNo"
        Me.txtPreviousClaimNo.Size = New System.Drawing.Size(111, 26)
        Me.txtPreviousClaimNo.TabIndex = 9
        '
        'optMale1
        '
        Me.optMale1.AutoSize = True
        Me.optMale1.Checked = True
        Me.optMale1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMale1.Location = New System.Drawing.Point(9, 94)
        Me.optMale1.Margin = New System.Windows.Forms.Padding(4)
        Me.optMale1.Name = "optMale1"
        Me.optMale1.Size = New System.Drawing.Size(66, 24)
        Me.optMale1.TabIndex = 5
        Me.optMale1.TabStop = True
        Me.optMale1.Text = "Male"
        Me.optMale1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(695, 91)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 38)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Previous Claim No " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(if Converted Case)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtClaimnatDOB
        '
        Me.txtClaimnatDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaimnatDOB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtClaimnatDOB.Location = New System.Drawing.Point(237, 90)
        Me.txtClaimnatDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClaimnatDOB.Mask = "00/00/0000"
        Me.txtClaimnatDOB.Name = "txtClaimnatDOB"
        Me.txtClaimnatDOB.Size = New System.Drawing.Size(107, 26)
        Me.txtClaimnatDOB.TabIndex = 7
        Me.txtClaimnatDOB.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(175, 91)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "D.O.B"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtClaimantCNIC
        '
        Me.txtClaimantCNIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaimantCNIC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtClaimantCNIC.Location = New System.Drawing.Point(803, 53)
        Me.txtClaimantCNIC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClaimantCNIC.Mask = "#####-#######-#"
        Me.txtClaimantCNIC.Name = "txtClaimantCNIC"
        Me.txtClaimantCNIC.Size = New System.Drawing.Size(147, 26)
        Me.txtClaimantCNIC.TabIndex = 4
        '
        'cboNatureOfBenefit
        '
        Me.cboNatureOfBenefit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboNatureOfBenefit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNatureOfBenefit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNatureOfBenefit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNatureOfBenefit.FormattingEnabled = True
        Me.cboNatureOfBenefit.Items.AddRange(New Object() {"Old Age", "Survivor", "Minor Child", "Estate Pension"})
        Me.cboNatureOfBenefit.Location = New System.Drawing.Point(461, 91)
        Me.cboNatureOfBenefit.Margin = New System.Windows.Forms.Padding(4)
        Me.cboNatureOfBenefit.Name = "cboNatureOfBenefit"
        Me.cboNatureOfBenefit.Size = New System.Drawing.Size(220, 28)
        Me.cboNatureOfBenefit.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(691, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Claimant CNIC"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtClaimantRelativeName
        '
        Me.txtClaimantRelativeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaimantRelativeName.Location = New System.Drawing.Point(461, 54)
        Me.txtClaimantRelativeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClaimantRelativeName.Name = "txtClaimantRelativeName"
        Me.txtClaimantRelativeName.Size = New System.Drawing.Size(223, 26)
        Me.txtClaimantRelativeName.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(355, 59)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Relative Name"
        '
        'txtClaimantName
        '
        Me.txtClaimantName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaimantName.Location = New System.Drawing.Point(116, 54)
        Me.txtClaimantName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClaimantName.Name = "txtClaimantName"
        Me.txtClaimantName.Size = New System.Drawing.Size(228, 26)
        Me.txtClaimantName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Claimant Name"
        '
        'txtFIRDate
        '
        Me.txtFIRDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFIRDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtFIRDate.Location = New System.Drawing.Point(401, 17)
        Me.txtFIRDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFIRDate.Mask = "00/00/0000"
        Me.txtFIRDate.Name = "txtFIRDate"
        Me.txtFIRDate.Size = New System.Drawing.Size(129, 29)
        Me.txtFIRDate.TabIndex = 1
        Me.txtFIRDate.ValidatingType = GetType(Date)
        '
        'dtDate
        '
        Me.dtDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.dtDate.Enabled = False
        Me.dtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Location = New System.Drawing.Point(560, 17)
        Me.dtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(389, 29)
        Me.dtDate.TabIndex = 10
        Me.dtDate.TabStop = False
        Me.dtDate.Value = New Date(2012, 5, 23, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "FIR/Case No."
        '
        'txtFIRNo
        '
        Me.txtFIRNo.AcceptsTab = True
        Me.txtFIRNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFIRNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFIRNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFIRNo.Location = New System.Drawing.Point(116, 17)
        Me.txtFIRNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFIRNo.Name = "txtFIRNo"
        Me.txtFIRNo.Size = New System.Drawing.Size(159, 29)
        Me.txtFIRNo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FIR Date"
        '
        'Label15
        '
        Me.Label15.AutoEllipsis = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 167)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(967, 33)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Insured Person Information"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Column1"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 10
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 20
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
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
        'ToolActivity
        '
        Me.ToolActivity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolActivity.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolActivity.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolActivity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnCancel, Me.btnDelete, Me.ToolStripSeparator1, Me.btnExit})
        Me.ToolActivity.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolActivity.Location = New System.Drawing.Point(0, 564)
        Me.ToolActivity.Name = "ToolActivity"
        Me.ToolActivity.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolActivity.Size = New System.Drawing.Size(1013, 39)
        Me.ToolActivity.TabIndex = 62
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
        'grdVoucher
        '
        Me.grdVoucher.AllowUserToAddRows = False
        Me.grdVoucher.AllowUserToDeleteRows = False
        Me.grdVoucher.AllowUserToResizeColumns = False
        Me.grdVoucher.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdVoucher.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdVoucher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdVoucher.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdVoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr, Me.FIRID, Me.CaseRemarksDate, Me.CaseRemarks, Me.del})
        Me.grdVoucher.Location = New System.Drawing.Point(16, 334)
        Me.grdVoucher.Margin = New System.Windows.Forms.Padding(4)
        Me.grdVoucher.Name = "grdVoucher"
        Me.grdVoucher.RowHeadersVisible = False
        Me.grdVoucher.Size = New System.Drawing.Size(981, 218)
        Me.grdVoucher.TabIndex = 60
        '
        'Sr
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        Me.Sr.DefaultCellStyle = DataGridViewCellStyle3
        Me.Sr.Frozen = True
        Me.Sr.HeaderText = "Sr#"
        Me.Sr.Name = "Sr"
        Me.Sr.ReadOnly = True
        Me.Sr.Width = 40
        '
        'FIRID
        '
        Me.FIRID.HeaderText = "FIRID"
        Me.FIRID.Name = "FIRID"
        Me.FIRID.Visible = False
        '
        'CaseRemarksDate
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CaseRemarksDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.CaseRemarksDate.HeaderText = "Remarks Date"
        Me.CaseRemarksDate.Name = "CaseRemarksDate"
        Me.CaseRemarksDate.Width = 150
        '
        'CaseRemarks
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.NullValue = Nothing
        Me.CaseRemarks.DefaultCellStyle = DataGridViewCellStyle5
        Me.CaseRemarks.HeaderText = "Case Remarks / Important Notes"
        Me.CaseRemarks.Name = "CaseRemarks"
        Me.CaseRemarks.Width = 500
        '
        'del
        '
        Me.del.HeaderText = ""
        Me.del.Image = Global.EobBTS.My.Resources.Resources.PNG_CloseView
        Me.del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.del.Name = "del"
        Me.del.Width = 20
        '
        'Label17
        '
        Me.Label17.AutoEllipsis = True
        Me.Label17.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Teal
        Me.Label17.Location = New System.Drawing.Point(16, 299)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(981, 27)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "Please Mention Important Notes / Current Position /Updates / Remarks etc"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCaseUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 603)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpIP)
        Me.Controls.Add(Me.grpClaimant)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ToolActivity)
        Me.Controls.Add(Me.grdVoucher)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCaseUpdates"
        Me.Text = "frmCaseUpdates"
        Me.grpIP.ResumeLayout(False)
        Me.grpIP.PerformLayout()
        Me.grpClaimant.ResumeLayout(False)
        Me.grpClaimant.PerformLayout()
        Me.ToolActivity.ResumeLayout(False)
        Me.ToolActivity.PerformLayout()
        CType(Me.grdVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents txtIPRelativeName As TextBox
    Friend WithEvents txtIPName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEOBINo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPDOB As MaskedTextBox
    Friend WithEvents grpIP As GroupBox
    Friend WithEvents txtIPDeathDate As MaskedTextBox
    Friend WithEvents optFemale2 As RadioButton
    Friend WithEvents txtIPCNIC As MaskedTextBox
    Friend WithEvents optMale2 As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents grpClaimant As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents optFemale1 As RadioButton
    Friend WithEvents txtPreviousClaimNo As TextBox
    Friend WithEvents optMale1 As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txtClaimnatDOB As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtClaimantCNIC As MaskedTextBox
    Friend WithEvents cboNatureOfBenefit As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClaimantRelativeName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtClaimantName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFIRDate As MaskedTextBox
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFIRNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents ToolActivity As ToolStrip
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents grdVoucher As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents Sr As DataGridViewTextBoxColumn
    Friend WithEvents FIRID As DataGridViewTextBoxColumn
    Friend WithEvents CaseRemarksDate As DataGridViewTextBoxColumn
    Friend WithEvents CaseRemarks As DataGridViewTextBoxColumn
    Friend WithEvents del As DataGridViewImageColumn
End Class
