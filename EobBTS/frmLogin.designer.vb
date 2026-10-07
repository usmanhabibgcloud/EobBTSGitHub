<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLogin
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents fraLogin As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fraLogin = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fraLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraLogin
        '
        Me.fraLogin.BackColor = System.Drawing.Color.White
        Me.fraLogin.Controls.Add(Me.PictureBox1)
        Me.fraLogin.Controls.Add(Me.btnCancel)
        Me.fraLogin.Controls.Add(Me.btnLogin)
        Me.fraLogin.Controls.Add(Me.txtName)
        Me.fraLogin.Controls.Add(Me.txtPassword)
        Me.fraLogin.Controls.Add(Me.Label1)
        Me.fraLogin.Controls.Add(Me.Label2)
        Me.fraLogin.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraLogin.Location = New System.Drawing.Point(4, 0)
        Me.fraLogin.Name = "fraLogin"
        Me.fraLogin.Padding = New System.Windows.Forms.Padding(0)
        Me.fraLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraLogin.Size = New System.Drawing.Size(560, 204)
        Me.fraLogin.TabIndex = 5
        Me.fraLogin.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EobBTS.My.Resources.Resources.Private_folder_3D
        Me.PictureBox1.Location = New System.Drawing.Point(13, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(387, 148)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 36)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(288, 148)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(93, 36)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Blue
        Me.txtName.Location = New System.Drawing.Point(353, 44)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.Size = New System.Drawing.Size(166, 27)
        Me.txtName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsReturn = True
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Blue
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPassword.Location = New System.Drawing.Point(353, 104)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.Size = New System.Drawing.Size(166, 26)
        Me.txtPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(231, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(116, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(239, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(108, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password:"
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
        Me.ImageList1.Images.SetKeyName(6, "PNG Add-2.png")
        Me.ImageList1.Images.SetKeyName(7, "PNG Edit.png")
        Me.ImageList1.Images.SetKeyName(8, "PNG Cancel.png")
        Me.ImageList1.Images.SetKeyName(9, "unlockiconblue.png")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(4, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(560, 94)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Employees' Old Age Benefits Institution" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Claims Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Developed By" &
    ""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(560, 40)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Usman Habib (Dy. Director EOBI)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(576, 368)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fraLogin)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.fraLogin.ResumeLayout(False)
        Me.fraLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
#End Region
End Class