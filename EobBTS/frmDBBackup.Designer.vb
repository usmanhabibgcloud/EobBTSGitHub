<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDBBackup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBBackup))
        Me.grpEmployee = New System.Windows.Forms.GroupBox()
        Me.lblDBBackupPath = New System.Windows.Forms.Label()
        Me.btnSelectFolder = New System.Windows.Forms.Button()
        Me.btnTakeBackup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpEmployee.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEmployee
        '
        Me.grpEmployee.Controls.Add(Me.lblDBBackupPath)
        Me.grpEmployee.Controls.Add(Me.btnSelectFolder)
        Me.grpEmployee.Location = New System.Drawing.Point(0, 58)
        Me.grpEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.grpEmployee.Name = "grpEmployee"
        Me.grpEmployee.Padding = New System.Windows.Forms.Padding(4)
        Me.grpEmployee.Size = New System.Drawing.Size(635, 107)
        Me.grpEmployee.TabIndex = 0
        Me.grpEmployee.TabStop = False
        '
        'lblDBBackupPath
        '
        Me.lblDBBackupPath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblDBBackupPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBBackupPath.ForeColor = System.Drawing.Color.Blue
        Me.lblDBBackupPath.Location = New System.Drawing.Point(12, 52)
        Me.lblDBBackupPath.Name = "lblDBBackupPath"
        Me.lblDBBackupPath.Size = New System.Drawing.Size(604, 37)
        Me.lblDBBackupPath.TabIndex = 1
        Me.lblDBBackupPath.Text = "Database Backup Path"
        Me.lblDBBackupPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSelectFolder
        '
        Me.btnSelectFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectFolder.Location = New System.Drawing.Point(12, 12)
        Me.btnSelectFolder.Name = "btnSelectFolder"
        Me.btnSelectFolder.Size = New System.Drawing.Size(604, 37)
        Me.btnSelectFolder.TabIndex = 0
        Me.btnSelectFolder.Text = "Select Folder/Path for Backup"
        Me.btnSelectFolder.UseVisualStyleBackColor = True
        '
        'btnTakeBackup
        '
        Me.btnTakeBackup.Location = New System.Drawing.Point(260, 172)
        Me.btnTakeBackup.Name = "btnTakeBackup"
        Me.btnTakeBackup.Size = New System.Drawing.Size(125, 33)
        Me.btnTakeBackup.TabIndex = 1
        Me.btnTakeBackup.Text = "Take Backup"
        Me.btnTakeBackup.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database Bakup"
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.EobBTS.My.Resources.Resources.backupDB_to_NAS
        Me.PictureBox1.Location = New System.Drawing.Point(210, 218)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'frmDBBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 519)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpEmployee)
        Me.Controls.Add(Me.btnTakeBackup)
        Me.Name = "frmDBBackup"
        Me.Text = "SQL Database Backup Form"
        Me.grpEmployee.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpEmployee As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTakeBackup As Button
    Friend WithEvents btnSelectFolder As Button
    Friend WithEvents lblDBBackupPath As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
End Class
