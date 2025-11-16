Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine


Public Class frmORVeriReminderPrint
    Private Sub FrmORVerificationPrint_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cls As New clsReader
        cls.GetRecord("select ORVerificationID As [OR Verification ID],ORVerificationDate As [OR Verification Date], Editable from tblORVerificationReminderMain", cn)

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
    Private Sub ShowReport_MultiPage(ORVerificationID As Double)
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crPanelMedical_To_HeadOffice
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spORVerificationReminder_Print", cn) With {
                .CommandType = CommandType.StoredProcedure
            }


            myCommand.Parameters.Add("@ORVerificationID", SqlDbType.Int).Value = ORVerificationID

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crORVerificationReminderPrint.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Other Region Verification Reminder Print"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowReport_SinglePage(ORVerificationID As Double)
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crPanelMedical_To_HeadOffice
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spORVerificationReminder_Print", cn) With {
                .CommandType = CommandType.StoredProcedure
            }


            myCommand.Parameters.Add("@ORVerificationID", SqlDbType.Int).Value = ORVerificationID

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crORVerficationReminderPrint_2.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)
            myReport.SetParameterValue("DDG1", Me.chkDDG1.Checked)
            myReport.SetParameterValue("DDG2", Me.chkDDG2.Checked)
            myReport.SetParameterValue("DDG3", Me.chkDDG3.Checked)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Other Region Verification Reminder Print"
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
        If Me.OptMultiRpt.Checked = True Then

            Try
                ShowReport_MultiPage(grdVoucher.Item("OR Verification ID", e.RowIndex).Value)
            Catch ex As Exception

            End Try

        End If
        If Me.OptSingleRpt.Checked = True Then

            Try
                ShowReport_SinglePage(grdVoucher.Item("OR Verification ID", e.RowIndex).Value)
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub btnSingleRpt_CheckedChanged(sender As Object, e As EventArgs) Handles OptSingleRpt.CheckedChanged
        If OptSingleRpt.Checked = True Then
            grpReminderCopy.Visible = True
        Else
            grpReminderCopy.Visible = False
        End If
    End Sub
End Class