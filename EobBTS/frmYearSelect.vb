Public Class frmYearSelect

    Private Sub ZeroPoint()

        Dim cls As New clsReader
        cls.GetRecord("SELECT F.FYID, F.FYIdentifier as [Year Identifier],F.FYStart as [Start Date],F.FyEnd as [End Date] from tblFinancialYear F inner join tblUserDetail D on F.FYID=D.FYID where D.UserID ='" & strUser & "' And D.Access=1", cn)
        grdYear.DataSource = AddSerial(cls.ds.Tables(0))
        grdYear.Columns("FYID").Visible = False
        grdYear.Columns("Sr").Width = 40
        grdYear.Columns("Year Identifier").Width = 230
        grdYear.Columns("Start Date").Width = 90
        grdYear.Columns("End Date").Width = 90
        cls = Nothing

    End Sub

   
    Private Sub grdYear_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYear.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Cursor = Cursors.WaitCursor
        intFYID = grdYear.Item("FYID", e.RowIndex).Value
        dtStartDate = grdYear.Item("Start Date", e.RowIndex).Value
        dtEndDate = grdYear.Item("End Date", e.RowIndex).Value
        frmMainscreen.striplblUser.Text = strUser
        frmMainscreen.Text = grdYear.Item("Year Identifier", e.RowIndex).Value

        frmMainscreen.Show()
        'Form1.Show()
        Cursor = Cursors.Default
        Me.Close()

    End Sub

    Private Sub frmYearSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ZeroPoint()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        cn = Nothing
        Me.Close()
    End Sub

       

    Private Sub grdYear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdYear.KeyDown
        If e.KeyCode = Keys.Enter Then
            grdYear_CellDoubleClick(sender, New DataGridViewCellEventArgs(grdYear.CurrentCell.ColumnIndex, grdYear.CurrentRow.Index))
        End If
    End Sub


End Class