
Imports Microsoft.VisualBasic.DateAndTime
Imports System.Data.SqlClient
Imports System.Math

Public Class frmVerificationReceived
    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn



    Private EditMode As Boolean = False
    Public intFIRID As Long


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()
    End Sub
    Dim TotalVerified As Decimal

    Private Sub CalculateTotal()
        Try

            Dim bd As Date = New Date(1983, 6, 30)
            TotalVerified = 0
            Dim tblVerifiedPeriod As New DataTable
            Dim strColumns As String() = New String() {"DateFrom", "DateTo", "BeforeDays", "AfterDays", "BeforeYears", "AfterYears", "TotalYears"}

            For i As Integer = 0 To UBound(strColumns)
                tblVerifiedPeriod.Columns.Add(strColumns(i).ToString)
            Next
            For i As Integer = 0 To grdVoucher.RowCount - 2
                tblVerifiedPeriod.Rows.Add()
                tblVerifiedPeriod.Rows(i)("DateFrom") = IIf((grdVoucher.Item("VerifiedFrom", i).Value = Nothing Or grdVoucher.Item("VerifiedFrom", i).Value = "01-01-0001"), "01-01-1900", grdVoucher.Item("VerifiedFrom", i).Value)
                tblVerifiedPeriod.Rows(i)("DateTo") = IIf((grdVoucher.Item("VerifiedTo", i).Value = Nothing Or grdVoucher.Item("VerifiedTo", i).Value = "01-01-0001"), "01-01-1900", grdVoucher.Item("VerifiedTo", i).Value)
                Dim dt5 As Date = CType(tblVerifiedPeriod.Rows(i)("DateFrom"), Date)
                Dim dt6 As Date = CType(tblVerifiedPeriod.Rows(i)("DateTo"), Date)

                Dim md As Date
                If dt6 < bd Then
                    md = dt6
                Else
                    md = bd
                End If

                tblVerifiedPeriod.Rows(i)("BeforeDays") = IIf(dt5 <= bd And Not (dt5 = New Date(1900, 1, 1)), DateDiff(DateInterval.Day, dt5, md) + 1, 0)
                'MsgBox(tblVerifiedPeriod.Rows(i)("DateFrom"))
                'MsgBox(tblVerifiedPeriod.Rows(i)("BeforeDays"))
                tblVerifiedPeriod.Rows(i)("AfterDays") = DateDiff(DateInterval.Day, dt5, dt6) - (tblVerifiedPeriod.Rows(i)("BeforeDays")) + IIf((dt5 = New Date(1900, 1, 1)), 0, 1)
                tblVerifiedPeriod.Rows(i)("BeforeYears") = CType((tblVerifiedPeriod.Rows(i)("BeforeDays")) / 312, Decimal)
                tblVerifiedPeriod.Rows(i)("AfterYears") = CType((tblVerifiedPeriod.Rows(i)("AfterDays")) / 365, Decimal)
                tblVerifiedPeriod.Rows(i)("TotalYears") = CType(tblVerifiedPeriod.Rows(i)("BeforeYears"), Decimal) + CType(tblVerifiedPeriod.Rows(i)("AfterYears"), Decimal)
                TotalVerified = TotalVerified + CType(tblVerifiedPeriod.Rows(i)("TotalYears"), Decimal)
            Next
            lblTotalVerified.Text = Format(TotalVerified, "#,###.##")
        Catch ex As Exception

        End Try


    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()

    End Sub

    Dim strDate As String

    Private Sub ZeroPoint()
        EditMode = False
        grpClaimant.Enabled = False
        txtFIRNo.Text = Nothing
        txtClaimantName.Text = Nothing
        txtClaimantRelativeName.Text = Nothing
        txtClaimantCNIC.Text = Nothing
        optMale1.Checked = True
        optFemale1.Checked = False
        txtClaimnatDOB.Text = Nothing
        cboNatureOfBenefit.SelectedIndex = cboNatureOfBenefit.Items.IndexOf("Old Age")
        txtPreviousClaimNo.Text = Nothing

        grpIP.Enabled = False
        txtIPName.Text = Nothing
        txtIPRelativeName.Text = Nothing
        txtIPCNIC.Text = Nothing
        optMale2.Checked = True
        optFemale2.Checked = False
        txtIPDOB.Text = Nothing
        txtEOBINo.Text = Nothing
        txtIPDeathDate.Text = Nothing
        lblTotalVerified.Text = Nothing
        txtAvgWages.Text = Nothing
        txtAvgWages.Enabled = False

        grdVoucher.RowCount = 0
        grdVoucher.Enabled = False

        ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
        btnAdd.Visible = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Do You Want to Close the Form ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Close()
    End Sub

    Private Sub frmVerificationReceived_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            txtFIRDate.Text = Format(Today(), "dd/MM/yyyy")
            dtDate.Value = Today()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'FillVTypes()
        ZeroPoint()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ActionEdit()

    End Sub

    Public Sub FillVoucher()

        Try
            Dim cls As New clsReader
            cls.GetRecord("select FIRID, FIRNo, FIRDate, ClaimantName, ClaimantRelative, ClaimantCNIC, ClaimantGender, ClaimantDoB, CaseType, PreviousClaimNo, IPName, IPRelative, IPCNIC, IPGender, IPDoB, EOBINo, IPDeathDate, Editable, VSource, PreparedBy, Checked, CheckedBy, Approved, ApprovedBy, RefID, FYID from tblFIRMain where FIRID = '" & intFIRID & "'  select FD.FIRDetailID, FD.FIRID, FD.EmployerName, FD.PeriodFrom, FD.PeriodTo,Coalesce(VD.VerifiedFrom,'0001-01-01') as VerifiedFrom,Coalesce(VD.VerifiedTo,'0001-01-01') as VerifiedTo,Coalesce(VD.UnVerified,0) as UnVerified, Coalesce(VD.ReferRCC,0) as ReferRCC from tblFIRDetail FD left join tblVerificationDetail VD on FD.FIRDetailID=VD.FIRDetailID where FD.FIRID = '" & intFIRID & "'  select AvgWages from tblVerificationAvgWages where FIRID = '" & intFIRID & "' ", cn)

            txtFIRNo.Text = cls.ds.Tables(0).Rows(0)("FIRNo")
            txtFIRDate.Text = cls.ds.Tables(0).Rows(0)("FIRDate").ToString
            dtDate.Value = Convert.ToDateTime(txtFIRDate.Text)
            txtClaimantName.Text = cls.ds.Tables(0).Rows(0)("ClaimantName")
            txtClaimantRelativeName.Text = cls.ds.Tables(0).Rows(0)("ClaimantRelative")
            txtClaimantCNIC.Text = cls.ds.Tables(0).Rows(0)("ClaimantCNIC")
            optMale1.Checked = IIf(cls.ds.Tables(0).Rows(0)("ClaimantGender") = "Male", True, False)
            optFemale1.Checked = IIf(cls.ds.Tables(0).Rows(0)("ClaimantGender") = "Female", True, False)
            txtClaimnatDOB.Text = cls.ds.Tables(0).Rows(0)("ClaimantDoB").ToString

            cboNatureOfBenefit.Text = cls.ds.Tables(0).Rows(0)("CaseType")
            txtPreviousClaimNo.Text = cls.ds.Tables(0).Rows(0)("PreviousClaimNo")

            txtIPName.Text = cls.ds.Tables(0).Rows(0)("IPName")
            txtIPRelativeName.Text = cls.ds.Tables(0).Rows(0)("IPRelative")
            txtIPCNIC.Text = cls.ds.Tables(0).Rows(0)("IPCNIC")
            optMale2.Checked = IIf(cls.ds.Tables(0).Rows(0)("IPGender") = "Male", True, False)
            optFemale2.Checked = IIf(cls.ds.Tables(0).Rows(0)("IPGender") = "Female", True, False)
            txtIPDOB.Text = cls.ds.Tables(0).Rows(0)("IPDoB").ToString
            txtEOBINo.Text = cls.ds.Tables(0).Rows(0)("EOBINo")

            txtIPDeathDate.Text = IIf(cls.ds.Tables(0).Rows(0)("IPDeathDate").ToString = "01-01-1900 12:00:00 AM", Nothing, cls.ds.Tables(0).Rows(0)("IPDeathDate").ToString)

            If cls.ds.Tables(2).Rows.Count = 0 Then
                txtAvgWages.Text = 0
            Else
                txtAvgWages.Text = cls.ds.Tables(2).Rows(0)("Avgwages").ToString
            End If

            If txtPreviousClaimNo.Text = Nothing Then
                grdVoucher.Enabled = True
                txtAvgWages.Enabled = True
            Else
                grdVoucher.Enabled = False

            End If


            grdVoucher.RowCount = cls.ds.Tables(1).Rows.Count + 1
            For i As Integer = 0 To cls.ds.Tables(1).Rows.Count - 1
                grdVoucher.Item("Sr", i).Value = i + 1
                grdVoucher.Item("FIRDetailID", i).Value = cls.ds.Tables(1).Rows(i)("FIRDetailID")
                grdVoucher.Item("FIRID", i).Value = cls.ds.Tables(1).Rows(i)("FIRID")
                grdVoucher.Item("EmployerName", i).Value = cls.ds.Tables(1).Rows(i)("EmployerName")
                grdVoucher.Item("PeriodFrom", i).Value = cls.ds.Tables(1).Rows(i)("PeriodFrom")
                grdVoucher.Item("PeriodTo", i).Value = cls.ds.Tables(1).Rows(i)("PeriodTo")
                grdVoucher.Item("VerifiedFrom", i).Value = IIf(cls.ds.Tables(1).Rows(i)("VerifiedFrom") = "01-01-0001", Nothing, cls.ds.Tables(1).Rows(i)("VerifiedFrom"))
                grdVoucher.Item("VerifiedTo", i).Value = IIf(cls.ds.Tables(1).Rows(i)("VerifiedTo") = "01-01-0001", Nothing, cls.ds.Tables(1).Rows(i)("VerifiedTo"))
                grdVoucher.Item("UnVerified", i).Value = cls.ds.Tables(1).Rows(i)("UnVerified")
                grdVoucher.Item("ReferRCC", i).Value = cls.ds.Tables(1).Rows(i)("ReferRCC")
            Next
            EditMode = True

            grdVoucher.Focus()
            ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
            cls = Nothing
            CalculateTotal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ActionDelete()
    End Sub

    Private Sub grdVoucher_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grdVoucher.RowsAdded
        FillSerial(grdVoucher)

    End Sub

    Public Sub ActionAdd() Implements IAddBtn.ActionAdd

    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub

        frmVoucherSearch.myTag = "Verification_Received"
        frmVoucherSearch.ShowDialog()

    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave

        If btnSave.Visible = False Then Exit Sub
        Cursor = Cursors.WaitCursor


        '-------------------------------Converting DataGrid into Data table---------------------

        Dim tblDetail As New DataTable

        Dim strFldNames As String() = New String() {"FIRDetailID", "FIRID", "EmployerName", "VerifiedFrom", "VerifiedTo", "UnVerified", "ReferRCC", "PreparedBy"}

        For i As Integer = 0 To UBound(strFldNames)
            tblDetail.Columns.Add(strFldNames(i).ToString)
        Next

        For r As Integer = 0 To grdVoucher.RowCount - 2
            If Not ((grdVoucher.Item("VerifiedFrom", r).Value = Nothing Or grdVoucher.Item("VerifiedFrom", r).Value = "01-01-0001") Or (grdVoucher.Item("VerifiedTo", r).Value = Nothing Or grdVoucher.Item("VerifiedTo", r).Value = "01-01-0001")) Or (grdVoucher.Item("UnVerified", r).Value = 1) Or (grdVoucher.Item("ReferRCC", r).Value = 1) Then

                tblDetail.Rows.Add()
                tblDetail.Rows(tblDetail.Rows.Count - 1)("FIRDetailID") = grdVoucher.Item("FIRDetailID", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("FIRID") = grdVoucher.Item("FIRID", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("EmployerName") = grdVoucher.Item("EmployerName", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("VerifiedFrom") = IIf(grdVoucher.Item("VerifiedFrom", r).Value = Nothing, "0001-01-01", fnTextToDate(grdVoucher.Item("VerifiedFrom", r).Value))
                tblDetail.Rows(tblDetail.Rows.Count - 1)("VerifiedTo") = IIf(grdVoucher.Item("VerifiedTo", r).Value = Nothing, "0001-01-01", fnTextToDate(grdVoucher.Item("VerifiedTo", r).Value))
                tblDetail.Rows(tblDetail.Rows.Count - 1)("UnVerified") = grdVoucher.Item("Unverified", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("ReferRCC") = grdVoucher.Item("ReferRCC", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("PreparedBy") = mdlGeneral.strUser

            End If
        Next r
        If tblDetail.Rows.Count = 0 Then
            MessageBox.Show("There is no Record to Save", "Please Enter Verified Period or Valid Priod")
            Cursor = Cursors.Arrow
            Exit Sub

        End If

        '---------------------------SAVING MAIN AND DETAIL TABLE-------------------------


        If EditMode = True Then GoTo EditMode


EditMode:

        Dim cmd As New SqlCommand
        Dim myTran As SqlTransaction = cn.BeginTransaction
        Try
            cmd.Connection = cn
            cmd.Transaction = myTran
            cmd.CommandText = "delete tblVerificationDetail where FIRID = " & intFIRID
            cmd.ExecuteNonQuery()
            cmd.CommandText = Nothing

            cmd.CommandText = "delete tblVerificationAvgWages where FIRID = " & intFIRID
            cmd.ExecuteNonQuery()
            cmd.CommandText = Nothing



            For i As Integer = 0 To tblDetail.Rows.Count - 1
                cmd.CommandText =
                        "insert into tblVerificationDetail (FIRDetailID,FIRID,EmployerName,VerifiedFrom,VerifiedTo,UnVerified,ReferRCC,PreparedBy) Values (" _
                                                            & "'" & tblDetail.Rows(i)("FIRDetailID") & "'," _
                                                            & "'" & tblDetail.Rows(i)("FIRID") & "'," _
                                                            & "'" & tblDetail.Rows(i)("EmployerName") & "'," _
                                                            & "'" & tblDetail.Rows(i)("VerifiedFrom") & "'," _
                                                            & "'" & tblDetail.Rows(i)("VerifiedTo") & "'," _
                                                            & "'" & tblDetail.Rows(i)("UnVerified") & "'," _
                                                            & "'" & tblDetail.Rows(i)("ReferRCC") & "'," _
                                                            & "'" & tblDetail.Rows(i)("PreparedBy") & "' )"
                cmd.ExecuteNonQuery()
                cmd.CommandText = Nothing
            Next

            cmd.CommandText = "insert into tblVerificationAvgWages Values ('" & intFIRID & "','" & Val(txtAvgWages.Text) & "')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = Nothing



            myTran.Commit()
            ZeroPoint()
            Cursor = Cursors.Arrow
            MsgBox(" The Record Has been Saved", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            Cursor = Cursors.Arrow
            myTran.Rollback()
            MsgBox(ex.ToString)

        End Try


    End Sub

    Public Sub ActionCancel() Implements ICancelBtn.ActionCancel

        If btnCancel.Visible = False Then Exit Sub
        If MsgBox("Do You Want to Cancel the Changes", vbYesNo, "") = MsgBoxResult.No Then Exit Sub
        ZeroPoint()

    End Sub

    Public Sub ActionDelete() Implements IDeleteBtn.ActionDelete
        If btnDelete.Visible = False Then Exit Sub
        If MessageBox.Show("Are you Want to Delete The Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then Exit Sub
        Dim cls As New ClsWriter
        cls.DeleteRecord("tblVerificationDetail", "FIRID", intFIRID, cn)

        cls = Nothing
        ZeroPoint()
        '--------------Updating the name of user who deleted the record-----------
        'Dim cmd As New SqlCommand
        'cmd.CommandText = "Update tbl_JVMainLog Set ActBy = '" & strUser & "' where JVID = " & intJVID & " and Act = 'DELETED'"
        'cmd.Connection = cn
        'cmd.ExecuteNonQuery()

    End Sub
    Dim dt2 As Date
    Dim dt3 As Date
    Private Sub grdVoucher_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdVoucher.CellValidating
        Dim dt2 As Date
        Dim dt3 As Date

        If e.ColumnIndex = grdVoucher.Columns("VerifiedFrom").Index Then

            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt2) Then
                MessageBox.Show("Enter correct Date")

                e.Cancel = True
                Exit Sub

            End If
            grdVoucher.Item("VerifiedFrom", e.RowIndex).Value = Format(dt2, "dd-MM-yyyy")

        End If
        If e.ColumnIndex = grdVoucher.Columns("VerifiedTo").Index Then
            'If grdVoucher.Item("PeriodTo", e.RowIndex).Value = Nothing Then Exit Sub
            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt3) Then
                MessageBox.Show("Enter correct Date")
                'Me.DataGridViewsalarydetail.Rows(e.RowIndex).ErrorText = "Enter a valid Date time"
                e.Cancel = True
                Exit Sub

            End If
            grdVoucher.Item("VerifiedTo", e.RowIndex).Value = Format(dt3, "dd-MM-yyyy")

        End If
    End Sub

    Private Sub grdVoucher_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdVoucher.CellEndEdit
        If e.ColumnIndex = grdVoucher.Columns("VerifiedFrom").Index Then
            CalculateTotal()
            If Not (CType(sender, DataGridView).Item("VerifiedFrom", e.RowIndex).Value = Nothing Or CType(sender, DataGridView).Item("VerifiedFrom", e.RowIndex).Value = "01-01-0001") Then
                grdVoucher.Item("UnVerified", e.RowIndex).Value = False

            End If
        End If
        If e.ColumnIndex = grdVoucher.Columns("VerifiedTo").Index Then
            CalculateTotal()
            If Not (CType(sender, DataGridView).Item("VerifiedTo", e.RowIndex).Value = Nothing Or CType(sender, DataGridView).Item("VerifiedTo", e.RowIndex).Value = "01-01-0001") Then
                grdVoucher.Item("UnVerified", e.RowIndex).Value = False

            End If
        End If

    End Sub

    Private Sub grdVoucher_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grdVoucher.CellEnter

        If e.ColumnIndex = grdVoucher.Columns("UnVerified").Index Then
            If Not (CType(sender, DataGridView).Item("VerifiedFrom", e.RowIndex).Value = Nothing Or CType(sender, DataGridView).Item("VerifiedFrom", e.RowIndex).Value = "01-01-0001") Or Not (CType(sender, DataGridView).Item("VerifiedTo", e.RowIndex).Value = Nothing Or CType(sender, DataGridView).Item("VerifiedTo", e.RowIndex).Value = "01-01-0001") Then
                grdVoucher.Columns(grdVoucher.Columns("UnVerified").Index).ReadOnly = True
            Else
                grdVoucher.Columns(grdVoucher.Columns("UnVerified").Index).ReadOnly = False
            End If
        End If

    End Sub



    Private Sub txtAvgWages_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAvgWages.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class