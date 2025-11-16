Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Public Class frmVoucherSearch
    Public myTag As String

    Private Sub frmVoucherSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdVoucher.DataSource = Nothing
        Select Case myTag

            Case "Case_Settle"
                Me.Label1.Text = "Please Select to Edit the Record"
                lblFIR.Visible = False
                txtFIRNo.Visible = False
                lblName.Visible = False
                txtClaimantInfo.Visible = False
                btnShowAllCases.Visible = False

                Dim cls As New clsReader
                cls.GetRecord("select SettleID,FYID,SettleDate,Editable from tblCaseSettleMain Where FYID = " & intFYID & " order by SettleID", cn)
                grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
                Dim intCSize As Integer() = New Integer() {40, 50, 10, 680, 10}
                grdVoucher = GridColumnSize(grdVoucher, intCSize)

                Me.grdVoucher.Columns("Editable").Visible = False
                Me.grdVoucher.Columns("FYID").Visible = False
                Me.grdVoucher.Columns("SettleDate").DefaultCellStyle.Format = "dd/MM/yyyy"

            Case "Case_Recommended"
                Me.Label1.Text = "Please Select to Edit the Record"
                lblFIR.Visible = False
                txtFIRNo.Visible = False
                lblName.Visible = False
                txtClaimantInfo.Visible = False
                btnShowAllCases.Visible = False

                Dim cls As New clsReader
                cls.GetRecord("select RecommendedID,FYID,RecommendedDate,Editable from tblCaseRecommendedMain Where FYID = " & intFYID & " order by RecommendedID", cn)
                grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
                Dim intCSize As Integer() = New Integer() {40, 50, 10, 680, 10}
                grdVoucher = GridColumnSize(grdVoucher, intCSize)

                Me.grdVoucher.Columns("Editable").Visible = False
                Me.grdVoucher.Columns("FYID").Visible = False
                Me.grdVoucher.Columns("RecommendedDate").DefaultCellStyle.Format = "dd/MM/yyyy"


            Case "OR_Verification"
                Me.Label1.Text = "Please Select to Edit the Record"
                lblFIR.Visible = False
                txtFIRNo.Visible = False
                lblName.Visible = False
                txtClaimantInfo.Visible = False
                btnShowAllCases.Visible = False

                Dim cls As New clsReader

                cls.GetRecord("select ORVerificationID, FYID,ORVerificationDate,Editable from tblORVerificationMain where  FYID = " & intFYID & " Order By ORVerificationID", cn)
                grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
                Dim intCSize As Integer() = New Integer() {40, 230, 10, 500, 10}
                grdVoucher = GridColumnSize(grdVoucher, intCSize)

                Me.grdVoucher.Columns("Editable").Visible = False
                Me.grdVoucher.Columns("FYID").Visible = False
                Me.grdVoucher.Columns("ORVerificationDate").DefaultCellStyle.Format = "dd/MM/yyyy"

            Case "OR_Verification_Reminder"
                Me.Label1.Text = "Please Select to Edit the Record"
                lblFIR.Visible = False
                txtFIRNo.Visible = False
                lblName.Visible = False
                txtClaimantInfo.Visible = False
                btnShowAllCases.Visible = False

                Dim cls As New clsReader

                cls.GetRecord("select ORVerificationID, FYID,ORVerificationDate,Editable from tblORVerificationReminderMain where  FYID = " & intFYID & " Order By ORVerificationID", cn)
                grdVoucher.DataSource = AddSerial(cls.ds.Tables(0))
                Dim intCSize As Integer() = New Integer() {40, 230, 10, 500, 10}
                grdVoucher = GridColumnSize(grdVoucher, intCSize)

                Me.grdVoucher.Columns("Editable").Visible = False
                Me.grdVoucher.Columns("FYID").Visible = False
                Me.grdVoucher.Columns("ORVerificationDate").DefaultCellStyle.Format = "dd/MM/yyyy"


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

            Case "Case_Received"
                Try

                    frmCaseReceived.intFIRID = grdVoucher.Item("FIRID", e.RowIndex).Value
                    frmCaseReceived.FillVoucher()
                    Me.Close()
                Catch ex As Exception

                End Try

            Case "Verification_Received"
                Try

                    frmVerificationReceived.intFIRID = grdVoucher.Item("FIRID", e.RowIndex).Value
                    frmVerificationReceived.FillVoucher()
                    Me.Close()
                Catch ex As Exception

                End Try

            Case "Case_Updates"
                Try

                    frmCaseUpdates.intFIRID = grdVoucher.Item("FIRID", e.RowIndex).Value
                    frmCaseUpdates.FillVoucher()
                    Me.Close()
                Catch ex As Exception

                End Try

            Case "Case_Settle"
                Try

                    frmCaseSettle.intSettleID = grdVoucher.Item("SettleID", e.RowIndex).Value
                    frmCaseSettle.FillSettle()
                    Me.Close()
                Catch ex As Exception

                End Try

            Case "Case_Recommended"
                Try

                    frmRecommendedByBTS.intRecommendedID = grdVoucher.Item("RecommendedID", e.RowIndex).Value
                    frmRecommendedByBTS.FillRecommended()
                    Me.Close()
                Catch ex As Exception

                End Try


            Case "OR_Verification"
                Try

                    frmORVerificationSent.intORVerificationID = grdVoucher.Item("ORVerificationID", e.RowIndex).Value
                    frmORVerificationSent.FillORVerification()
                    Me.Close()
                Catch ex As Exception

                End Try
            Case "OR_Verification_Reminder"
                Try

                    frmORverificationReminder.intORVerificationID = grdVoucher.Item("ORVerificationID", e.RowIndex).Value
                    frmORverificationReminder.FillORVerification()
                    Me.Close()
                Catch ex As Exception

                End Try


        End Select

    End Sub

    Private Sub grdVoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdVoucher.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                grdVoucher_CellDoubleClick(sender, New DataGridViewCellEventArgs(grdVoucher.CurrentCell.ColumnIndex, grdVoucher.CurrentRow.Index))
            End If

        Catch ex As Exception

        End Try
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
        cls.GetRecord("select FIRID,Editable,FIRNo,FIRDate,ClaimantName,ClaimantCNIC,IPName,IPCNIC,EOBINo from tblFIRMain where VSource = 'Self' order by FIRdate, FIRNo", cn)
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