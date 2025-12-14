Imports System.IO
Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class frmDBBackup


    Private Sub btnTakeBakup_Click(sender As Object, e As EventArgs) Handles btnTakeBackup.Click
        Try
            Cursor = Cursors.WaitCursor

            ' SQL Server backup query
            Dim backupFile As String = Path.Combine(
                        lblDBBackupPath.Text,
                        "EobBTS_Backup_" & DateTime.Now.ToString("yyyyMMdd") & ".bak"
                    )
            Dim backupQuery As String =
                "BACKUP DATABASE EobBTS TO DISK = @path WITH INIT"

            Using cmd As New SqlCommand(backupQuery, cn)
                cmd.Parameters.AddWithValue("@path", backupFile)

                cmd.ExecuteNonQuery()
            End Using
            Cursor = Cursors.Default

            MessageBox.Show("Backup completed successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSelectFolder_Click(sender As Object, e As EventArgs) Handles btnSelectFolder.Click
        Using fbd As New FolderBrowserDialog()
            fbd.Description = "Select folder to save database backup"

            If fbd.ShowDialog() = DialogResult.OK Then
                lblDBBackupPath.Text = fbd.SelectedPath
                My.Settings.lastbackuppath = fbd.SelectedPath
                My.Settings.Save()


            End If
        End Using
    End Sub

    Private Sub frmDBBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDBBackupPath.Text = My.Settings.lastbackuppath

    End Sub
End Class