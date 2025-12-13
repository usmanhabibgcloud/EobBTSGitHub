Imports Microsoft.VisualBasic.DateAndTime
Imports System.Data.SqlClient
Imports System.Math


Public Class frmCaseUpdates

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

    Private Sub frmCaseUpdates_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            txtFIRDate.Text = Format(Today(), "dd/MM/yyyy")
            dtDate.Value = Today()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ZeroPoint()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ActionEdit()

    End Sub

    Public Sub FillVoucher()

        Try
            Dim cls As New clsReader
            cls.GetRecord("select FIRID, FIRNo, FIRDate, ClaimantName, ClaimantRelative, ClaimantCNIC, ClaimantGender, ClaimantDoB, CaseType, PreviousClaimNo, IPName, IPRelative, IPCNIC, IPGender, IPDoB, EOBINo, IPDeathDate, Editable, VSource, PreparedBy, Checked, CheckedBy, Approved, ApprovedBy, RefID, FYID from tblFIRMain where FIRID = '" & intFIRID & "'  select c.FIRID,c.CaseRemarksDate,c.Caseremarks,PreparedBy from tblCaseUpdates c where FIRID = '" & intFIRID & "' ", cn)

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
            grdVoucher.Enabled = True


            grdVoucher.RowCount = cls.ds.Tables(1).Rows.Count + 1
            For i As Integer = 0 To cls.ds.Tables(1).Rows.Count - 1
                grdVoucher.Item("Sr", i).Value = i + 1
                grdVoucher.Item("FIRID", i).Value = cls.ds.Tables(1).Rows(i)("FIRID")
                grdVoucher.Item("CaseRemarksDate", i).Value = cls.ds.Tables(1).Rows(i)("CaseRemarksDate")
                grdVoucher.Item("CaseRemarks", i).Value = cls.ds.Tables(1).Rows(i)("CaseRemarks")

            Next
            EditMode = True

            grdVoucher.Focus()
            ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
            cls = Nothing

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

        frmVoucherSearch.myTag = "Case_Updates"
        frmVoucherSearch.ShowDialog()

    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave

        If btnSave.Visible = False Then Exit Sub
        Cursor = Cursors.WaitCursor

        '-------------------------------Converting DataGrid into Data table---------------------
        Dim tblDetail As New DataTable

        Dim strFldNames As String() = New String() {"FIRID", "CaseRemarksDate", "CaseRemarks", "PreparedBy"}

        For i As Integer = 0 To UBound(strFldNames)
            tblDetail.Columns.Add(strFldNames(i).ToString)
        Next

        For r As Integer = 0 To grdVoucher.RowCount - 2
            If Not (grdVoucher.Item("CaseRemarks", r).Value = Nothing) Then

                tblDetail.Rows.Add()
                tblDetail.Rows(tblDetail.Rows.Count - 1)("FIRID") = intFIRID
                tblDetail.Rows(tblDetail.Rows.Count - 1)("CaseRemarksDate") = IIf(grdVoucher.Item("CaseRemarksDate", r).Value = Nothing Or grdVoucher.Item("CaseRemarksDate", r).Value = "01-01-0001", fnTextToDate(DateAndTime.Today), fnTextToDate(grdVoucher.Item("CaseRemarksDate", r).Value))
                tblDetail.Rows(tblDetail.Rows.Count - 1)("CaseRemarks") = grdVoucher.Item("CaseRemarks", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("PreparedBy") = mdlGeneral.strUser
            End If
        Next r
        If tblDetail.Rows.Count = 0 Then
            MessageBox.Show("There is no Record to Save", "Please Enter Valid Remarks / Updates Etc")
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
            cmd.CommandText = "delete tblCaseUpdates where FIRID = " & intFIRID
            cmd.ExecuteNonQuery()
            cmd.CommandText = Nothing


            For i As Integer = 0 To tblDetail.Rows.Count - 1
                cmd.CommandText =
                        "insert into tblCaseUpdates (FIRID,CaseRemarksDate,CaseRemarks,PreparedBy) Values (" _
                                                            & "'" & tblDetail.Rows(i)("FIRID") & "'," _
                                                            & "'" & tblDetail.Rows(i)("CaseRemarksDate") & "'," _
                                                            & "'" & tblDetail.Rows(i)("CaseRemarks") & "'," _
                                                            & "'" & tblDetail.Rows(i)("PreparedBy") & "' )"
                cmd.ExecuteNonQuery()
                cmd.CommandText = Nothing
            Next

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
        cls.DeleteRecord("tblCaseUpdates", "FIRID", intFIRID, cn)

        cls = Nothing
        ZeroPoint()

    End Sub
    Dim dt2 As Date
    Dim dt3 As Date
    Private Sub grdVoucher_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdVoucher.CellValidating
        Dim dt2 As Date


        If e.ColumnIndex = grdVoucher.Columns("CaseRemarksDate").Index Then

            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt2) Then
                MessageBox.Show("Enter correct Date")
                e.Cancel = True
                Exit Sub

            End If
            grdVoucher.Item("CaseRemarksDate", e.RowIndex).Value = Format(dt2, "dd-MM-yyyy")

        End If

    End Sub


    '-----------------------------Below is under Process---------------------


    Private Sub grdVoucher_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdVoucher.CellEndEdit
        If e.ColumnIndex = grdVoucher.Columns("CaseRemarksDate").Index Then

            If CType(sender, DataGridView).Item("CaseRemarksDate", e.RowIndex).Value = Nothing Or CType(sender, DataGridView).Item("CaseRemarksDate", e.RowIndex).Value = "01-01-0001" Then
                grdVoucher.Item("CaseRemarksDate", e.RowIndex).Value = Format(Date.Now, "dd-MM-yyyy")

            End If
        End If
        If e.ColumnIndex = grdVoucher.Columns("CaseRemarks").Index Then
            If e.RowIndex = CType(sender, DataGridView).RowCount - 1 Then
                grdVoucher.RowCount = CType(sender, DataGridView).RowCount + 1
            End If


        End If

        FillSerial(grdVoucher)

    End Sub

    Private Sub grdVoucher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdVoucher.CellContentClick
        If e.ColumnIndex = grdVoucher.Columns("Del").Index Then

            If grdVoucher.CurrentRow.Index = grdVoucher.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            grdVoucher.Rows.RemoveAt(e.RowIndex)

            FillSerial(grdVoucher)
        End If
    End Sub

    Private Sub grdVoucher_KeyDown(sender As Object, e As KeyEventArgs) Handles grdVoucher.KeyDown
        If e.KeyCode = Keys.Delete Then
            If grdVoucher.CurrentRow.Index = grdVoucher.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            grdVoucher.Rows.RemoveAt(grdVoucher.CurrentRow.Index)

            FillSerial(grdVoucher)
        End If

    End Sub
End Class