Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient


Public Class frmPetitionCommentsPrint
    Public myTag As String

    Private Sub frmPetitionCommentsPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdVoucher.DataSource = Nothing
        Select Case myTag
            Case "Petition Comments"
                Me.Label1.Text = "Please Search the Petition and Double Click on the Petition to Print Comments"
                lblFIR.Text = "Petition"
                btnShowAllCases.Text = "Show All Petitions"

        End Select

    End Sub
    Private Sub txtDesc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClaimantInfo.KeyUp
        If Len(txtClaimantInfo.Text) >= 1 Then
            GetPetitioner_ByDesc()
        End If
    End Sub
    Private Sub GetPetitioner_ByDesc()
        Dim cls As New clsReader
        cls.GetRecord("Select AuthorityID,Editable,PetitionNo,ClaimantName,ClaimantCNIC,IPName,IPCNIC,EOBINo from tblAuthorityMain where  (VSource = 'Self') and (PetitionNo like '%" & txtClaimantInfo.Text & "%' or ClaimantName like '%" & txtClaimantInfo.Text & "%' or IPName like '%" & txtClaimantInfo.Text & "%' or ClaimantCNIC like '%" & txtClaimantInfo.Text & "%' or EOBINo like '%" & txtClaimantInfo.Text & "%' or IPCNIC like '%" & txtClaimantInfo.Text & "%') order by PetitionNo", cn)
        grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
        Dim intCSize As Integer() = New Integer() {40, 10, 10, 120, 130, 115, 130, 115, 100}
        grdVoucher = GridColumnSize(grdVoucher, intCSize)

        Me.grdVoucher.Columns("Editable").Visible = False
        Me.grdVoucher.Columns("AuthorityID").Visible = False

    End Sub


    Private Sub grdVoucher_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdVoucher.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Select Case myTag
            Case "Petition Comments"
                Try
                    ShowPetitionCommentsReport(grdVoucher.Item("AuthorityID", e.RowIndex).Value)
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
            Select Case myTag
                Case "Petition Comments"
                    txtClaimantInfo.Text = Nothing
                    If txtFIRNo.Text = Nothing Then
                        MessageBox.Show("Please Enter Petition No.")
                        Exit Sub
                    End If
                    Dim cls As New clsReader
                    cls.GetRecord("Select AuthorityID,Editable,PetitionNo,ClaimantName,ClaimantCNIC,IPName,IPCNIC,EOBINo from tblAuthorityMain where  (VSource = 'Self') and (PetitionNo like '%" & txtFIRNo.Text & "%') order by PetitionNo", cn)
                    If cls.EOF = True Then
                        MessageBox.Show("The Petition No. Does Not Exists")

                    End If
                    grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
                    Dim intCSize As Integer() = New Integer() {40, 10, 10, 120, 130, 115, 130, 115, 100}
                    grdVoucher = GridColumnSize(grdVoucher, intCSize)

                    Me.grdVoucher.Columns("Editable").Visible = False
                    Me.grdVoucher.Columns("AuthorityID").Visible = False
            End Select

        End If
    End Sub

    Private Sub txtClaimantInfo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClaimantInfo.KeyDown
        txtFIRNo.Text = Nothing
    End Sub

    Private Sub btnShowAllCases_Click(sender As Object, e As EventArgs) Handles btnShowAllCases.Click

        Select Case myTag
            Case "Petition Comments"
                Dim cls As New clsReader
                cls.GetRecord("Select AuthorityID,Editable,PetitionNo,ClaimantName,ClaimantCNIC,IPName,IPCNIC,EOBINo from tblAuthorityMain where  (VSource = 'Self')  order by PetitionNo", cn)
                If cls.EOF = True Then
                    MessageBox.Show("The Petition No. Does Not Exists")

                End If
                grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
                Dim intCSize As Integer() = New Integer() {40, 10, 10, 120, 130, 115, 130, 115, 100}
                grdVoucher = GridColumnSize(grdVoucher, intCSize)

                Me.grdVoucher.Columns("Editable").Visible = False
                Me.grdVoucher.Columns("AuthorityID").Visible = False
        End Select
    End Sub

    Private Sub ShowPetitionCommentsReport(PetitionID As Double)
        Try
            Cursor = Cursors.WaitCursor

            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spAuthorityCommentsRpt", cn) With {
                .CommandType = CommandType.StoredProcedure
            }


            myCommand.Parameters.Add("@AuthorityID", SqlDbType.Int).Value = PetitionID

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crAuthorityComments.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)

            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Petition Comments Print"
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