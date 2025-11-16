Public Class frmCaseSettle
    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn




    Private EditMode As Boolean = False

    Public intSettleID As Long


    Private Sub grdBudget_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSettle.CellContentClick
        If e.ColumnIndex = grdSettle.Columns("Del").Index Then
            If grdSettle.CurrentRow.Index = grdSettle.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            grdSettle.Rows.RemoveAt(e.RowIndex)

            FillSerial(grdSettle)
        End If

    End Sub
    Private Sub grdBudget_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSettle.CellEndEdit
        If e.ColumnIndex = grdSettle.Columns("FIRNo").Index Then
            Dim CellValue As String
            CellValue = grdSettle.Item(e.ColumnIndex, e.RowIndex).Value
            Dim cls As New clsReader
            cls.GetRecord("Select FIRID,FIRNo,ClaimantCNIC,ClaimantName + '- ' + ClaimantRelative As ClaimantName From tblFIRMain Where FIRNo = '" & CellValue & "'", cn)
            If cls.EOF = False Then
                Me.grdSettle.Item("FIRID", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("FIRID")
                Me.grdSettle.Item("FIRNO", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("FIRNo")
                Me.grdSettle.Item("ClaimantCNIC", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("ClaimantCNIC")
                Me.grdSettle.Item("ClaimantName", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("ClaimantName")
                If e.RowIndex = CType(sender, DataGridView).RowCount - 1 Then
                    Me.grdSettle.RowCount = CType(sender, DataGridView).RowCount + 1

                End If
            Else
                Me.grdSettle.Item("FIRID", e.RowIndex).Value = Nothing
                Me.grdSettle.Item("FIRNo", e.RowIndex).Value = Nothing
                Me.grdSettle.Item("ClaimantName", e.RowIndex).Value = Nothing
                Me.grdSettle.Item("ClaimantCNIC", e.RowIndex).Value = Nothing

            End If
        End If

        If e.ColumnIndex = grdSettle.Columns("ClaimantCNIC").Index Then
            Dim CellValue As String
            CellValue = grdSettle.Item(e.ColumnIndex, e.RowIndex).Value
            Dim cls As New clsReader
            cls.GetRecord("Select FIRID,FIRNo,ClaimantCNIC,ClaimantName + '- ' + ClaimantRelative As ClaimantName From tblFIRMain Where ClaimantCNIC = '" & CellValue & "'", cn)
            If cls.EOF = False Then
                Me.grdSettle.Item("FIRID", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("FIRID")
                Me.grdSettle.Item("FIRNO", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("FIRNo")
                Me.grdSettle.Item("ClaimantCNIC", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("ClaimantCNIC")
                Me.grdSettle.Item("ClaimantName", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("ClaimantName")
                If e.RowIndex = CType(sender, DataGridView).RowCount - 1 Then
                    Me.grdSettle.RowCount = CType(sender, DataGridView).RowCount + 1

                End If
            Else
                Me.grdSettle.Item("FIRID", e.RowIndex).Value = Nothing
                Me.grdSettle.Item("FIRNo", e.RowIndex).Value = Nothing
                Me.grdSettle.Item("ClaimantName", e.RowIndex).Value = Nothing
                Me.grdSettle.Item("ClaimantCNIC", e.RowIndex).Value = Nothing

            End If

        End If


        FillSerial(Me.grdSettle)

    End Sub

    Private Sub grdVoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdSettle.KeyDown
        If e.KeyCode = Keys.Delete Then

            If Me.grdSettle.CurrentRow.Index = Me.grdSettle.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Me.grdSettle.Rows.RemoveAt(grdSettle.CurrentRow.Index)

            FillSerial(grdSettle)

        End If
    End Sub



    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()
    End Sub
    Private Sub ZeroPoint()
        EditMode = False
        Me.txtSettleID.Text = Nothing
        Me.grdSettle.RowCount = 0
        Me.grpSettlementInfo.Enabled = False
        Me.grdSettle.Enabled = False

        ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub

    Private Sub frmCaseSettle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            txtSettleDate.Text = Format(Today(), "dd/MM/yyyy")
            dtDate.Value = Today()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ZeroPoint()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ActionEdit()
    End Sub

    Public Sub FillSettle()
        Try
            Dim cls As New clsReader

            cls.GetRecord("select SettleID,SettleDate from tblCaseSettleMain Where SettleID = " & intSettleID & "  Select S.FIRID, (Select M.FIRNo from tblFIRMain M where M.FIRID = S.FIRID) as FIRNO,(Select M.ClaimantCNIC from tblFIRMain M where M.FIRID = S.FIRID) as ClaimantCNIC,(Select M.ClaimantName + '- ' + M.ClaimantRelative from tblFIRMain M where M.FIRID = S.FIRID) as ClaimantName,S.ClaimNo, S.Remarks from tblCaseSettleDetail S Where SettleID =  " & intSettleID, cn)

            Me.txtSettleID.Text = cls.ds.Tables(0).Rows(0)("SettleID")
            txtSettleDate.Text = Format(cls.ds.Tables(0).Rows(0)("SettleDate"), "dd/MM/yyyy")
            Me.dtDate.Value = cls.ds.Tables(0).Rows(0)("SettleDate")
            Me.grpSettlementInfo.Enabled = True

            Me.grdSettle.Enabled = True
            Me.grdSettle.RowCount = cls.ds.Tables(1).Rows.Count + 1
            For i As Integer = 0 To cls.ds.Tables(1).Rows.Count - 1
                Me.grdSettle.Item("Sr", i).Value = i + 1
                Me.grdSettle.Item("FIRID", i).Value = cls.ds.Tables(1).Rows(i)("FIRID")
                Me.grdSettle.Item("FIRNo", i).Value = cls.ds.Tables(1).Rows(i)("FIRNO")
                Me.grdSettle.Item("ClaimantCNIC", i).Value = cls.ds.Tables(1).Rows(i)("ClaimantCNIC")
                Me.grdSettle.Item("ClaimantName", i).Value = cls.ds.Tables(1).Rows(i)("ClaimantName")
                Me.grdSettle.Item("ClaimNo", i).Value = cls.ds.Tables(1).Rows(i)("ClaimNo")
                Me.grdSettle.Item("Remarks", i).Value = cls.ds.Tables(1).Rows(i)("Remarks")
            Next

            EditMode = True

            txtSettleDate.Focus()
            ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
            cls = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ActionDelete()


    End Sub

    Private Sub grdBudget_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grdSettle.RowsAdded
        FillSerial(Me.grdSettle)
    End Sub



    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub
        EditMode = False
        Me.grdSettle.RowCount = 1
        Me.grpSettlementInfo.Enabled = True
        Me.grdSettle.Enabled = True
        Me.txtSettleDate.Focus()

        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)

    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub
        frmVoucherSearch.myTag = "Case_Settle"
        frmVoucherSearch.ShowDialog()
    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave
        If btnSave.Visible = False Then Exit Sub
        If MsgBox("Do You Want to Save the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        For i As Integer = 0 To Me.grdSettle.RowCount - 2
            If Me.grdSettle.Item("ClaimNo", i).Value = Nothing Then
                MsgBox("Any of the Row the Claim Number is Missing ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        Next
        '--------------------------Converting Grid to Table--------------

        Dim tblDetail As New DataTable
        Dim strFldNames As String() = New String() {"FIRID", "ClaimNo", "Remarks"}

        For i As Integer = 0 To UBound(strFldNames)
            tblDetail.Columns.Add(strFldNames(i).ToString)
        Next

        For r As Integer = 0 To Me.grdSettle.RowCount - 2
            If Not (grdSettle.Item("ClaimantName", r).Value = Nothing) Then
                tblDetail.Rows.Add()
                tblDetail.Rows(tblDetail.Rows.Count - 1)("FIRID") = Me.grdSettle.Item("FIRID", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("ClaimNo") = Me.grdSettle.Item("ClaimNo", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("Remarks") = Me.grdSettle.Item("Remarks", r).Value

            End If
        Next r

        '---------------------------SAVING MAIN AND DETAIL TABLE-------------------------

        Dim cls As New ClsWriter
        If EditMode = False Then GoTo AddMode
        If EditMode = True Then GoTo EditMode

AddMode:
        Try
            Dim fldNames As String() = New String() {"FYID", "SettleDate", "Editable", "UserID"}
            Dim fldValues As Object = New Object() {intFYID, fnTextToDate(txtSettleDate.Text), 1, strUser}
            cls.AddRecord(tblDetail, cn, "tblCaseSettleDetail", "tblCaseSettleMain", "SettleID", fldNames, fldValues)
            cls = Nothing
            ZeroPoint()
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
EditMode:
        Try
            Dim fldNames As String() = New String() {"FYID", "SettleDate", "Editable", "UserID"}
            Dim fldValues As Object = New Object() {intFYID, fnTextToDate(txtSettleDate.Text), 1, strUser}

            cls.UpdateRecord(tblDetail, cn, "tblCaseSettleDetail", "tblCaseSettleMain", "SettleID", fldNames, fldValues, intSettleID)
            cls = Nothing
            ZeroPoint()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub ActionCancel() Implements ICancelBtn.ActionCancel
        If btnCancel.Visible = False Then Exit Sub
        If MsgBox("Do You Want to Cancel the Changes", vbYesNo, "") = MsgBoxResult.No Then Exit Sub
        ZeroPoint()
    End Sub

    Public Sub ActionDelete() Implements IDeleteBtn.ActionDelete
        If btnDelete.Visible = False Then Exit Sub

        If EditMode = True Then
            If MessageBox.Show("Are you sure you want to Delete the Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                Dim cls As New ClsWriter
                cls.DeleteRecord("tblCaseSettleMain", "SettleID", intSettleID, cn)
                cls = Nothing
                ZeroPoint()

                ButtonPosition(ButtonPos.Delete, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
            End If
        End If


    End Sub

    Private Sub txtBDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSettleDate.Validating
        Try
            Dim dt As New DateTime(Strings.Right(txtSettleDate.Text, 4), Strings.Mid(txtSettleDate.Text, 4, 2), Strings.Left(txtSettleDate.Text, 2))
            If Not (dt >= dtStartDate And dt <= dtEndDate) Then

                MsgBox("Please Enter Date Between " & dtStartDate & " And " & dtEndDate)
                txtSettleDate.Focus()
                Exit Sub
            End If
            dtDate.Value = dt
            'MsgBox(Format(dtDate.Value, "MMMM"))

        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtSettleDate.Focus()
        End Try
    End Sub

    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSettleDate.GotFocus

        SelectText(sender)
    End Sub

End Class