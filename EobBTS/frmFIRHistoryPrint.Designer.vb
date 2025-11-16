<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFIRHistoryPrint
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnShowAllCases = New System.Windows.Forms.Button()
        Me.txtClaimantInfo = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFIR = New System.Windows.Forms.Label()
        Me.txtFIRNo = New System.Windows.Forms.TextBox()
        Me.grdVoucher = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancell = New System.Windows.Forms.Button()
        CType(Me.grdVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowAllCases
        '
        Me.btnShowAllCases.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShowAllCases.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnShowAllCases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnShowAllCases.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllCases.ForeColor = System.Drawing.Color.Linen
        Me.btnShowAllCases.Location = New System.Drawing.Point(853, 48)
        Me.btnShowAllCases.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShowAllCases.Name = "btnShowAllCases"
        Me.btnShowAllCases.Size = New System.Drawing.Size(213, 42)
        Me.btnShowAllCases.TabIndex = 32
        Me.btnShowAllCases.Text = "Show All Cases"
        Me.btnShowAllCases.UseVisualStyleBackColor = False
        '
        'txtClaimantInfo
        '
        Me.txtClaimantInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaimantInfo.Location = New System.Drawing.Point(540, 57)
        Me.txtClaimantInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClaimantInfo.Name = "txtClaimantInfo"
        Me.txtClaimantInfo.Size = New System.Drawing.Size(299, 26)
        Me.txtClaimantInfo.TabIndex = 29
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(296, 63)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(220, 17)
        Me.lblName.TabIndex = 31
        Me.lblName.Text = "Claimant/IP Name / CNIC/EOBI No"
        '
        'lblFIR
        '
        Me.lblFIR.AutoSize = True
        Me.lblFIR.Location = New System.Drawing.Point(12, 63)
        Me.lblFIR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFIR.Name = "lblFIR"
        Me.lblFIR.Size = New System.Drawing.Size(91, 17)
        Me.lblFIR.TabIndex = 30
        Me.lblFIR.Text = "FIR/Case No."
        '
        'txtFIRNo
        '
        Me.txtFIRNo.AcceptsTab = True
        Me.txtFIRNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFIRNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFIRNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFIRNo.Location = New System.Drawing.Point(117, 58)
        Me.txtFIRNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFIRNo.Name = "txtFIRNo"
        Me.txtFIRNo.Size = New System.Drawing.Size(168, 29)
        Me.txtFIRNo.TabIndex = 28
        '
        'grdVoucher
        '
        Me.grdVoucher.AllowUserToAddRows = False
        Me.grdVoucher.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdVoucher.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdVoucher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdVoucher.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdVoucher.Location = New System.Drawing.Point(7, 95)
        Me.grdVoucher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdVoucher.Name = "grdVoucher"
        Me.grdVoucher.ReadOnly = True
        Me.grdVoucher.RowHeadersVisible = False
        Me.grdVoucher.Size = New System.Drawing.Size(1067, 437)
        Me.grdVoucher.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1089, 31)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Search Claim Cases"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancell
        '
        Me.btnCancell.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancell.Location = New System.Drawing.Point(16, 2)
        Me.btnCancell.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancell.Name = "btnCancell"
        Me.btnCancell.Size = New System.Drawing.Size(100, 28)
        Me.btnCancell.TabIndex = 27
        Me.btnCancell.Text = "btnCancell"
        Me.btnCancell.UseVisualStyleBackColor = True
        '
        'frmFIRHistoryPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 535)
        Me.Controls.Add(Me.btnShowAllCases)
        Me.Controls.Add(Me.txtClaimantInfo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblFIR)
        Me.Controls.Add(Me.txtFIRNo)
        Me.Controls.Add(Me.grdVoucher)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancell)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmFIRHistoryPrint"
        Me.Text = "frmFIRHistoryPrint"
        CType(Me.grdVoucher, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
