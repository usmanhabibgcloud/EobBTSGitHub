<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessSheetForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnShowAllCases = New System.Windows.Forms.Button()
        Me.txtClaimantInfo = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFIR = New System.Windows.Forms.Label()
        Me.txtFIRNo = New System.Windows.Forms.TextBox()
        Me.grdVoucher = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancell = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optPension = New System.Windows.Forms.RadioButton()
        Me.optGrant = New System.Windows.Forms.RadioButton()
        CType(Me.grdVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShowAllCases
        '
        Me.btnShowAllCases.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShowAllCases.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnShowAllCases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnShowAllCases.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllCases.ForeColor = System.Drawing.Color.Linen
        Me.btnShowAllCases.Location = New System.Drawing.Point(640, 36)
        Me.btnShowAllCases.Name = "btnShowAllCases"
        Me.btnShowAllCases.Size = New System.Drawing.Size(160, 34)
        Me.btnShowAllCases.TabIndex = 24
        Me.btnShowAllCases.Text = "Show All Cases"
        Me.btnShowAllCases.UseVisualStyleBackColor = False
        '
        'txtClaimantInfo
        '
        Me.txtClaimantInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaimantInfo.Location = New System.Drawing.Point(405, 43)
        Me.txtClaimantInfo.Name = "txtClaimantInfo"
        Me.txtClaimantInfo.Size = New System.Drawing.Size(225, 22)
        Me.txtClaimantInfo.TabIndex = 21
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(222, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(176, 13)
        Me.lblName.TabIndex = 23
        Me.lblName.Text = "Claimant/IP Name / CNIC/EOBI No"
        '
        'lblFIR
        '
        Me.lblFIR.AutoSize = True
        Me.lblFIR.Location = New System.Drawing.Point(9, 48)
        Me.lblFIR.Name = "lblFIR"
        Me.lblFIR.Size = New System.Drawing.Size(73, 13)
        Me.lblFIR.TabIndex = 22
        Me.lblFIR.Text = "FIR/Case No."
        '
        'txtFIRNo
        '
        Me.txtFIRNo.AcceptsTab = True
        Me.txtFIRNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFIRNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFIRNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFIRNo.Location = New System.Drawing.Point(88, 44)
        Me.txtFIRNo.Name = "txtFIRNo"
        Me.txtFIRNo.Size = New System.Drawing.Size(127, 24)
        Me.txtFIRNo.TabIndex = 20
        '
        'grdVoucher
        '
        Me.grdVoucher.AllowUserToAddRows = False
        Me.grdVoucher.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdVoucher.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.grdVoucher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdVoucher.DefaultCellStyle = DataGridViewCellStyle8
        Me.grdVoucher.Location = New System.Drawing.Point(5, 74)
        Me.grdVoucher.Name = "grdVoucher"
        Me.grdVoucher.ReadOnly = True
        Me.grdVoucher.RowHeadersVisible = False
        Me.grdVoucher.Size = New System.Drawing.Size(800, 288)
        Me.grdVoucher.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(817, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Search Claim Cases"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancell
        '
        Me.btnCancell.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancell.Location = New System.Drawing.Point(12, 3)
        Me.btnCancell.Name = "btnCancell"
        Me.btnCancell.Size = New System.Drawing.Size(75, 23)
        Me.btnCancell.TabIndex = 19
        Me.btnCancell.Text = "btnCancell"
        Me.btnCancell.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optGrant)
        Me.GroupBox1.Controls.Add(Me.optPension)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 368)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 55)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'optPension
        '
        Me.optPension.AutoSize = True
        Me.optPension.Checked = True
        Me.optPension.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPension.Location = New System.Drawing.Point(7, 23)
        Me.optPension.Name = "optPension"
        Me.optPension.Size = New System.Drawing.Size(79, 23)
        Me.optPension.TabIndex = 0
        Me.optPension.TabStop = True
        Me.optPension.Text = "Pension"
        Me.optPension.UseVisualStyleBackColor = True
        '
        'optGrant
        '
        Me.optGrant.AutoSize = True
        Me.optGrant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optGrant.Location = New System.Drawing.Point(134, 23)
        Me.optGrant.Name = "optGrant"
        Me.optGrant.Size = New System.Drawing.Size(124, 23)
        Me.optGrant.TabIndex = 1
        Me.optGrant.Text = "Old Age Grant"
        Me.optGrant.UseVisualStyleBackColor = True
        '
        'frmProcessSheetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 435)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnShowAllCases)
        Me.Controls.Add(Me.txtClaimantInfo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblFIR)
        Me.Controls.Add(Me.txtFIRNo)
        Me.Controls.Add(Me.grdVoucher)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancell)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProcessSheetForm"
        Me.Text = "frmProcessSheetForm"
        CType(Me.grdVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowAllCases As Button
    Friend WithEvents txtClaimantInfo As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblFIR As Label
    Friend WithEvents txtFIRNo As TextBox
    Friend WithEvents grdVoucher As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancell As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optGrant As RadioButton
    Friend WithEvents optPension As RadioButton
End Class
