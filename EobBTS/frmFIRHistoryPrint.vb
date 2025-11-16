Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient


Public Class frmFIRHistoryPrint
    Public myTag As String

    Private Sub frmVoucherSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdVoucher.DataSource = Nothing
        Select Case myTag
            Case "FIR History"
                Me.Label1.Text = "Please Search the Case and Double Click on the case to Print FIR/Case Employment History"

        End Select

    End Sub
    Private Sub txtDesc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClaimantInfo.KeyUp

        If Len(txtClaimantInfo.Text) >= 4 Then
            GetClaimant_ByDesc()
        End If

    End Sub
    Private Sub GetClaimant_ByDesc()
        Dim cls As New clsReader
        cls.GetRecord("select FIRID,Editable,FIRNo,FIRDate,ClaimantName,ClaimantCNIC,IPName,IPCNIC,EOBINo from tblFIRMain where  (VSource = 'Self') and (FIRNo like '%" & txtClaimantInfo.Text & "%' or ClaimantName like '%" & txtClaimantInfo.Text & "%' or IPName like '%" & txtClaimantInfo.Text & "%' or ClaimantCNIC like '%" & txtClaimantInfo.Text & "%' or EOBINo like '%" & txtClaimantInfo.Text & "%' or IPCNIC like '%" & txtClaimantInfo.Text & "%') order by FIRNo", cn)
        grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
        Dim intCSize As Integer() = New Integer() {40, 10, 10, 60, 80, 130, 115, 130, 115, 100}
        grdVoucher = GridColumnSize(grdVoucher, intCSize)

        Me.grdVoucher.Columns("Editable").Visible = False
        Me.grdVoucher.Columns("FIRID").Visible = False
        Me.grdVoucher.Columns("FIRDate").DefaultCellStyle.Format = "dd/MM/yyyy"

    End Sub


    Private Sub grdVoucher_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdVoucher.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        If Me.grdVoucher.Item("Editable", e.RowIndex).Value = False Then
            MsgBox("This Voucher can't be Edited", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Select Case myTag


            Case "FIR History"
                Try

                    If e.RowIndex < 0 Then Exit Sub

                    Try
                        ShowFIRHistoryReport(grdVoucher.Item("FIRID", e.RowIndex).Value)
                    Catch ex As Exception

                    End Try

                Catch ex As Exception

                End Try

        End Select

    End Sub

    Private Sub grdVoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdVoucher.KeyDown
        If e.KeyCode = Keys.Enter Then
            grdVoucher_CellDoubleClick(sender, New DataGridViewCellEventArgs(grdVoucher.CurrentCell.ColumnIndex, grdVoucher.CurrentRow.Index))
        End If
    End Sub

    Private Sub grdVoucher_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdVoucher.Sorted
        FillSerial(Me.grdVoucher)
    End Sub


    Private Sub btnCancell_Click(sender As Object, e As EventArgs) Handles btnCancell.Click
        Me.Close()
    End Sub

    Private Sub txtFIRNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFIRNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtClaimantInfo.Text = Nothing
            If txtFIRNo.Text = Nothing Then
                MessageBox.Show("Please Enter Case/FIR No")
                Exit Sub
            End If
            Dim cls As New clsReader
            cls.GetRecord("select FIRID,Editable,FIRNo,FIRDate,ClaimantName,ClaimantCNIC,IPName,IPCNIC,EOBINo from tblFIRMain where  (VSource = 'Self') and (FIRNo = '" & txtFIRNo.Text & "') order by FIRNo", cn)
            If cls.EOF = True Then
                MessageBox.Show("The Claim/FIR/Case No Does Not Exists")

            End If
            grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
            Dim intCSize As Integer() = New Integer() {40, 10, 10, 60, 80, 130, 115, 130, 115, 100}
            grdVoucher = GridColumnSize(grdVoucher, intCSize)

            Me.grdVoucher.Columns("Editable").Visible = False
            Me.grdVoucher.Columns("FIRID").Visible = False
            Me.grdVoucher.Columns("FIRDate").DefaultCellStyle.Format = "dd/MM/yyyy"

        End If
    End Sub

    Private Sub txtClaimantInfo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClaimantInfo.KeyDown
        txtFIRNo.Text = Nothing
    End Sub

    Private Sub btnShowAllCases_Click(sender As Object, e As EventArgs) Handles btnShowAllCases.Click
        Dim cls As New clsReader
        cls.GetRecord("select FIRID,Editable,FIRNo,FIRDate,ClaimantName,ClaimantCNIC,IPName,IPCNIC,EOBINo from tblFIRMain where VSource = 'Self' order by FIRNo", cn)
        If cls.EOF = True Then
            MessageBox.Show("The Claim/FIR/Case No Does Not Exists")

        End If
        grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
        Dim intCSize As Integer() = New Integer() {40, 10, 10, 60, 80, 130, 115, 130, 115, 100}
        grdVoucher = GridColumnSize(grdVoucher, intCSize)

        Me.grdVoucher.Columns("Editable").Visible = False
        Me.grdVoucher.Columns("FIRID").Visible = False
        Me.grdVoucher.Columns("FIRDate").DefaultCellStyle.Format = "dd/MM/yyyy"

    End Sub

    Private Sub ShowFIRHistoryReport(FIRID As Double)
        Try
            Cursor = Cursors.WaitCursor

            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spFIRHistory", cn) With {
                .CommandType = CommandType.StoredProcedure
            }


            myCommand.Parameters.Add("@FIRID", SqlDbType.Int).Value = FIRID

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crFIRHistory.rpt"))
            myReport.SetDataSource(tbl)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "FIR/Case History/Employment History"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ZeroPoint()
        Me.Label1.Text = "Search Claim Cases"
        lblFIR.Visible = True
        txtFIRNo.Visible = True
        lblName.Visible = True
        txtClaimantInfo.Visible = True
        btnShowAllCases.Visible = True
        Me.grdVoucher.DataSource = Nothing

    End Sub

    Private Sub frmVoucherSearch_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ZeroPoint()


    End Sub


End Class