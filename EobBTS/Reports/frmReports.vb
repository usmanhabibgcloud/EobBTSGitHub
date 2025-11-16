Public Class frmReports
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmReports_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        crView.Dispose()

    End Sub

End Class