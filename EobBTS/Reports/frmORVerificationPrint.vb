Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmORVerificationPrint

    Private Sub FrmORVerificationPrint_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cls As New clsReader
        cls.GetRecord("select ORVerificationID As [OR Verification ID],ORVerificationDate As [OR Verification Date], Editable from tblORVerificationMain", cn)

        grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
        Dim intCSize As Integer() = New Integer() {40, 130, 290, 10}
        grdVoucher = GridColumnSize(grdVoucher, intCSize)

        Me.grdVoucher.Columns("Editable").Visible = False
        Me.grdVoucher.Columns("OR Verification Date").DefaultCellStyle.Format = "dd/MM/yyyy"

        Try
            Me.grdVoucher.Item("OR Verification ID", 0).Selected = True
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        GrdVoucher_CellDoubleClick(grdVoucher, New DataGridViewCellEventArgs(grdVoucher.CurrentCell.ColumnIndex, grdVoucher.CurrentRow.Index))
    End Sub
    Private Sub ShowReport(ORVerificationID As Double)
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crPanelMedical_To_HeadOffice
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spORVerification", cn) With {
                .CommandType = CommandType.StoredProcedure
            }


            myCommand.Parameters.Add("@ORVerificationID", SqlDbType.Int).Value = ORVerificationID

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crORVerificationPrint.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Other Region Verification Print"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub GrdVoucher_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdVoucher.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            ShowReport(grdVoucher.Item("OR Verification ID", e.RowIndex).Value)
        Catch ex As Exception

        End Try

    End Sub
End Class