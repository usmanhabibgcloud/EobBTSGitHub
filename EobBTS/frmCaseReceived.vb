
Imports Microsoft.VisualBasic.DateAndTime
Imports System.ComponentModel
Imports System.Data.SqlClient


Public Class frmCaseReceived
    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn



    Private EditMode As Boolean = False
    Public intFIRID As Long
    Private strFIRNo As String
    Private strClaimantCNIC As String



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()

    End Sub

    Private Sub grdVoucher_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdVoucher.CellContentClick
        If e.ColumnIndex = grdVoucher.Columns("Del").Index Then

            If grdVoucher.CurrentRow.Index = grdVoucher.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            grdVoucher.Rows.RemoveAt(e.RowIndex)

            FillSerial(grdVoucher)
        End If
        If e.ColumnIndex = grdVoucher.Columns("F1").Index Then
            frmEmployerSearch.blnSingle = False
            frmEmployerSearch.intRIndex = grdVoucher.CurrentRow.Index
            frmEmployerSearch.Destin = frmEmployerSearch.Destination.CaseReceived
            frmEmployerSearch.ShowDialog()
        End If
    End Sub

    Private Sub grdVoucher_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdVoucher.CellEndEdit
        If e.ColumnIndex = grdVoucher.Columns("EmployerName").Index Then
            If e.RowIndex = CType(sender, DataGridView).RowCount - 1 Then
                grdVoucher.RowCount = CType(sender, DataGridView).RowCount + 1
            End If


        End If

        FillSerial(grdVoucher)

    End Sub

    Dim strDate As String

    Private Sub grdVoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdVoucher.KeyDown
        If e.KeyCode = Keys.Delete Then
            If grdVoucher.CurrentRow.Index = grdVoucher.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            grdVoucher.Rows.RemoveAt(grdVoucher.CurrentRow.Index)

            FillSerial(grdVoucher)
        ElseIf e.KeyCode = Keys.F1 And (grdVoucher.CurrentCell.ColumnIndex = grdVoucher.Columns("F1").Index Or grdVoucher.CurrentCell.ColumnIndex = grdVoucher.Columns("EmployerName").Index) Then

            frmEmployerSearch.blnSingle = False
            frmEmployerSearch.intRIndex = grdVoucher.CurrentRow.Index
            frmEmployerSearch.Destin = frmEmployerSearch.Destination.CaseReceived
            frmEmployerSearch.ShowDialog()

        End If

    End Sub

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
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Do You Want to Close the Form ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Close()
    End Sub



    Private Sub frmJVAct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            txtFIRDate.Text = Format(Today(), "dd/MM/yyyy")
            dtDate.Value = Today()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'FillVTypes()
        ZeroPoint()
    End Sub

    'Private Function GetRegionNames() As List(Of String)
    '    Dim query As String = "select RegionName from tblRegionNames"
    '    Dim cls As New clsReader
    '    cls.GetRecord(query, cn)
    '    Dim supplierNames = New List(Of String)()

    '    For i As Integer = 0 To cls.ds.Tables(0).Rows.Count - 1
    '        supplierNames.Add(cls.ds.Tables(0).Rows(i)("RegionName"))
    '    Next

    '    Return supplierNames
    'End Function
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ActionEdit()

    End Sub

    Public Sub FillVoucher()
        Try
            Dim cls As New clsReader
            cls.GetRecord("select FIRID,FIRNo,FIRDate,ClaimantName,ClaimantRelative,ClaimantCNIC,ClaimantGender,ClaimantDoB,CaseType,PreviousClaimNo,IPName,IPRelative,IPCNIC,IPGender,IPDoB,EOBINo,IPDeathDate,Editable,VSource,PreparedBy,Checked,CheckedBy,Approved,ApprovedBy,RefID,FYID from tblFIRMain where FIRID = '" & intFIRID & "'  select FIRDetailID, FIRID, EmployerName, PeriodFrom, PeriodTo, RegionName, Beat, EmployerCode from tblFIRDetail where FIRID = '" & intFIRID & "'", cn)
            strFIRNo = cls.ds.Tables(0).Rows(0)("FIRNo")
            txtFIRNo.Text = cls.ds.Tables(0).Rows(0)("FIRNo")
            txtFIRDate.Text = cls.ds.Tables(0).Rows(0)("FIRDate").ToString
            dtDate.Value = Convert.ToDateTime(txtFIRDate.Text)
            'MessageBox.Show(cls.ds.Tables(0).Rows(0)("FIRDate").ToString)
            txtClaimantName.Text = cls.ds.Tables(0).Rows(0)("ClaimantName")
            txtClaimantRelativeName.Text = cls.ds.Tables(0).Rows(0)("ClaimantRelative")
            strClaimantCNIC = cls.ds.Tables(0).Rows(0)("ClaimantCNIC")
            txtClaimantCNIC.Text = cls.ds.Tables(0).Rows(0)("ClaimantCNIC")
            optMale1.Checked = IIf(cls.ds.Tables(0).Rows(0)("ClaimantGender") = "Male", True, False)
            optFemale1.Checked = IIf(cls.ds.Tables(0).Rows(0)("ClaimantGender") = "Female", True, False)
            txtClaimnatDOB.Text = cls.ds.Tables(0).Rows(0)("ClaimantDoB").ToString

            'MessageBox.Show(cls.ds.Tables(0).Rows(0)("ClaimantDoB").ToString)
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

            grpClaimant.Enabled = True
            grpIP.Enabled = True
            If txtPreviousClaimNo.Text = Nothing Then
                grdVoucher.Enabled = True
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
                grdVoucher.Item("RegionName", i).Value = cls.ds.Tables(1).Rows(i)("RegionName")
                grdVoucher.Item("Beat", i).Value = cls.ds.Tables(1).Rows(i)("Beat")
                grdVoucher.Item("EmployerCode", i).Value = cls.ds.Tables(1).Rows(i)("EmployerCode")
            Next
            EditMode = True

            txtFIRNo.Focus()
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
        If btnAdd.Visible = False Then Exit Sub
        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)

        grdVoucher.Enabled = True
        grpClaimant.Enabled = True
        grpIP.Enabled = True

        btnSameAbove.Enabled = True

        cboNatureOfBenefit.Enabled = True
        txtFIRNo.Focus()
        grdVoucher.RowCount = 1
        FillSerial(grdVoucher)
        'GetVoucherNo()

    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub

        frmVoucherSearch.myTag = "Case_Received"
        frmVoucherSearch.ShowDialog()

    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave


        If btnSave.Visible = False Then Exit Sub
        Cursor = Cursors.WaitCursor

        '-------------Chacking Savings Constraints--------------------------------
        If txtFIRNo.Text = Nothing Then
            MessageBox.Show("Please Enter FIR/Application Number", "Error")
            Cursor = Cursors.Default
            Exit Sub
        End If
        If txtFIRDate.Text = Nothing Then
            MessageBox.Show("Please Enter Valid FIR Date", "Error")
            Cursor = Cursors.Default
            Exit Sub
        End If

        If txtClaimantName.Text = Nothing Then
            MessageBox.Show("Please Enter Claimant Name", "Error")
            Cursor = Cursors.Default
            Exit Sub
        End If
        If Len(txtClaimantCNIC.Text) < 15 Then
            MessageBox.Show("Please Enter Valid Claimant CNIC Number", "Error")
            Cursor = Cursors.Default
            Exit Sub
        End If

        If Not (cboNatureOfBenefit.Text = "Old Age") And txtIPDeathDate.Text = "  -  -" Then
            'If Not (cboNatureOfBenefit.Text = "Old Age" Or cboNatureOfBenefit.Text = "Invalidity") And txtIPDeathDate.Text = "  -  -" Then
            MessageBox.Show("Please Enter Valid IP Death/Invalidity Date", "Error")
            Cursor = Cursors.Default
            Exit Sub

        End If

        If (cboNatureOfBenefit.Text = "Old Age") And Not (txtIPDeathDate.Text = "  -  -") Then
            'If (cboNatureOfBenefit.Text = "Old Age" Or cboNatureOfBenefit.Text = "Invalidity") And Not (txtIPDeathDate.Text = "  -  -") Then
            MessageBox.Show("Please Remove Death/Invalidity Date", "Error")
            Cursor = Cursors.Default
            Exit Sub

        End If


        If grdVoucher.RowCount = 1 And Len(txtPreviousClaimNo.Text) < 3 Then
            MessageBox.Show("Please Enter Employment History OR Valid Convered CLAIM No", "Error")
            Cursor = Cursors.Default
            Exit Sub
        End If


        '-------------------------------Converting DataGrid into Data table---------------------

        Dim tblDetail As New DataTable

        Dim strFldNames As String() = New String() {"EmployerName", "PeriodFrom", "PeriodTo", "RegionName", "Beat", "EmployerCode"}

        For i As Integer = 0 To UBound(strFldNames)
            tblDetail.Columns.Add(strFldNames(i).ToString)
        Next

        For r As Integer = 0 To grdVoucher.RowCount - 2
            If Not (grdVoucher.Item("EmployerName", r).Value = Nothing) Then

                tblDetail.Rows.Add()
                tblDetail.Rows(tblDetail.Rows.Count - 1)("EmployerName") = Replace(grdVoucher.Item("EmployerName", r).Value, "'", " ")
                'tblDetail.Rows(tblDetail.Rows.Count - 1)("EmployerName") = grdVoucher.Item("EmployerName", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("PeriodFrom") = IIf(grdVoucher.Item("PeriodFrom", r).Value = Nothing, "0001-01-01", fnTextToDate(grdVoucher.Item("PeriodFrom", r).Value))
                tblDetail.Rows(tblDetail.Rows.Count - 1)("PeriodTo") = IIf(grdVoucher.Item("PeriodTo", r).Value = Nothing, "0001-01-01", fnTextToDate(grdVoucher.Item("PeriodTo", r).Value))
                tblDetail.Rows(tblDetail.Rows.Count - 1)("RegionName") = grdVoucher.Item("RegionName", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("Beat") = grdVoucher.Item("Beat", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("EmployerCode") = grdVoucher.Item("EmployerCode", r).Value
            End If
        Next r

        '---------------------------SAVING MAIN AND DETAIL TABLE-------------------------


        Dim cls As New ClsWriter
        If EditMode = False Then GoTo AddMode
        If EditMode = True Then GoTo EditMode
AddMode:
        Try

            Dim fldNames As String() = New String() {"FIRNo", "FIRDate", "ClaimantName", "ClaimantRelative", "ClaimantCNIC", "ClaimantGender", "ClaimantDoB", "CaseType", "PreviousClaimNo", "IPName", "IPRelative", "IPCNIC", "IPGender", "IPDoB", "EOBINo", "IPDeathDate", "Editable", "VSource", "PreparedBy", "FYID"}
            Dim fldValues As Object = New Object() {txtFIRNo.Text, fnTextToDate(txtFIRDate.Text), txtClaimantName.Text, txtClaimantRelativeName.Text, txtClaimantCNIC.Text, IIf(Me.optMale1.Checked = True, "Male", "Female"), fnTextToDate(txtClaimnatDOB.Text), cboNatureOfBenefit.Text, txtPreviousClaimNo.Text, txtIPName.Text, txtIPRelativeName.Text, txtIPCNIC.Text, IIf(Me.optMale2.Checked = True, "Male", "Female"), fnTextToDate(txtIPDOB.Text), txtEOBINo.Text, fnTextToDate(IIf(txtIPDeathDate.Text = "  -  -", "01/01/1900", txtIPDeathDate.Text)), 1, "SELF", strUser, intFYID}

            cls.AddRecord(tblDetail, cn, "tblFIRDetail", "tblFIRMain", "FIRID", fldNames, fldValues)
            cls = Nothing
            ZeroPoint()
            Cursor = Cursors.Default
            Exit Sub
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
EditMode:
        Try

            Dim fldNames As String() = New String() {"FIRNo", "FIRDate", "ClaimantName", "ClaimantRelative", "ClaimantCNIC", "ClaimantGender", "ClaimantDoB", "CaseType", "PreviousClaimNo", "IPName", "IPRelative", "IPCNIC", "IPGender", "IPDoB", "EOBINo", "IPDeathDate", "Editable", "VSource", "PreparedBy", "FYID"}
            Dim fldValues As Object = New Object() {txtFIRNo.Text, fnTextToDate(txtFIRDate.Text), txtClaimantName.Text, txtClaimantRelativeName.Text, txtClaimantCNIC.Text, IIf(Me.optMale1.Checked = True, "Male", "Female"), fnTextToDate(txtClaimnatDOB.Text), cboNatureOfBenefit.Text, txtPreviousClaimNo.Text, txtIPName.Text, txtIPRelativeName.Text, txtIPCNIC.Text, IIf(Me.optMale2.Checked = True, "Male", "Female"), fnTextToDate(txtIPDOB.Text), txtEOBINo.Text, fnTextToDate(IIf(txtIPDeathDate.Text = "  -  -", "01/01/1900", txtIPDeathDate.Text)), 1, "SELF", strUser, intFYID}

            cls.UpdateRecord(tblDetail, cn, "tblFIRDetail", "tblFIRMain", "FIRID", fldNames, fldValues, intFIRID)
            cls = Nothing
            ZeroPoint()
            Cursor = Cursors.Default
            Exit Sub
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message)
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
        cls.DeleteRecord("tblFIRMain", "FIRID", intFIRID, cn)
        cls = Nothing
        ZeroPoint()
        '--------------Updating the name of user who deleted the record-----------
        'Dim cmd As New SqlCommand
        'cmd.CommandText = "Update tbl_JVMainLog Set ActBy = '" & strUser & "' where JVID = " & intJVID & " and Act = 'DELETED'"
        'cmd.Connection = cn
        'cmd.ExecuteNonQuery()

    End Sub

    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFIRDate.GotFocus
        SelectText(sender)
    End Sub



    Private Sub txtFIRVDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFIRDate.Validating
        Try
            dtDate.Value = Convert.ToDateTime(txtFIRDate.Text)
            If Not (dtDate.Value >= dtStartDate And dtDate.Value <= dtEndDate) Then

                MsgBox("Please Enter Date Between " & dtStartDate & " And " & dtEndDate)
                txtFIRDate.Focus()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtFIRDate.Focus()
        End Try


    End Sub

    Private Sub txtClaimantDOB_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtClaimnatDOB.Validating
        Dim dt1 As New DateTimePicker
        Try
            dt1.Value = Convert.ToDateTime(txtClaimnatDOB.Text)
        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtClaimnatDOB.Focus()
        End Try
    End Sub
    Dim dt2 As DateTime
    Dim dt3 As DateTime

    Private Sub txtIPDOB_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIPDOB.Validating
        Dim dt1 As New DateTimePicker
        Try
            dt1.Value = Convert.ToDateTime(txtIPDOB.Text)
        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtIPDOB.Focus()
        End Try
    End Sub

    Private Sub txtIPDeathDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIPDeathDate.Validating
        If txtIPDeathDate.Text = "  -  -" Then Exit Sub
        Dim dt1 As New DateTimePicker
        Try
            dt1.Value = Convert.ToDateTime(txtIPDeathDate.Text)
        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtIPDeathDate.Focus()
        End Try
    End Sub

    Private Sub grdVoucher_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdVoucher.CellValidating
        Dim dt7 As Date
        Dim dt8 As Date
        If e.ColumnIndex = grdVoucher.Columns("PeriodFrom").Index Then
            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt7) Then
                MessageBox.Show("Enter correct Date")

                e.Cancel = True
                Exit Sub

            End If
            grdVoucher.Item("PeriodFrom", e.RowIndex).Value = Format(dt7, "dd-MM-yyyy")

        End If
        If e.ColumnIndex = grdVoucher.Columns("PeriodTo").Index Then
            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt8) Then
                MessageBox.Show("Enter correct Date")
                e.Cancel = True
                Exit Sub

            End If
            grdVoucher.Item("PeriodTo", e.RowIndex).Value = Format(dt8, "dd-MM-yyyy")

        End If
    End Sub

    Private Sub btnSameAbove_Click(sender As Object, e As EventArgs) Handles btnSameAbove.Click
        txtIPName.Text = txtClaimantName.Text
        txtIPRelativeName.Text = txtClaimantRelativeName.Text
        txtIPCNIC.Text = txtClaimantCNIC.Text
        optMale2.Checked = optMale1.Checked
        optFemale2.Checked = optFemale1.Checked
        txtIPDOB.Text = txtClaimnatDOB.Text

    End Sub

    Private Sub Saving_Constraints()

    End Sub


    Private Sub txtPreviousClaimNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPreviousClaimNo.KeyUp
        If Me.txtPreviousClaimNo.Text = Nothing Then
            grdVoucher.Enabled = True
        Else
            grdVoucher.Enabled = False
            grdVoucher.RowCount = 0
            grdVoucher.RowCount = 1
        End If
    End Sub

    Private Sub txtFIRNo_Validating(sender As Object, e As CancelEventArgs) Handles txtFIRNo.Validating
        Dim cls As New clsReader
        If EditMode = True And strFIRNo = txtFIRNo.Text Then Exit Sub
        cls.GetRecord("select FIRNo from tblFIRMain where FIRNo = '" & txtFIRNo.Text & "'", cn)
        If cls.EOF = False Then
            MessageBox.Show("This FIR/Case Number Already Exists, Please Enter Other FIR No", "ERROR", MessageBoxButtons.OK)
            txtFIRNo.Focus()
        End If
    End Sub

    Private Sub txtClaimantCNIC_Validating(sender As Object, e As CancelEventArgs) Handles txtClaimantCNIC.Validating
        Dim cls As New clsReader
        If EditMode = True And strClaimantCNIC = txtClaimantCNIC.Text Then Exit Sub
        cls.GetRecord("select ClaimantCNIC from tblFIRMain where ClaimantCNIC = '" & txtClaimantCNIC.Text & "'", cn)
        If cls.EOF = False Then
            MessageBox.Show("This CNIC Number Already Exists, Please Enter Other CNIC Number", "ERROR", MessageBoxButtons.OK)
            txtClaimantCNIC.Focus()
        End If
    End Sub
    Private Sub cboNatureOfBenefit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNatureOfBenefit.SelectedIndexChanged
        If (cboNatureOfBenefit.Text = "Old Age" Or cboNatureOfBenefit.Text = "Invalidity") Then
            txtPreviousClaimNo.Enabled = False
            txtPreviousClaimNo.Text = Nothing
            grdVoucher.Enabled = True
        Else
            txtPreviousClaimNo.Enabled = True
        End If
    End Sub

    Private Sub DataGridViewImageColumn1_Disposed(sender As Object, e As EventArgs) Handles DataGridViewImageColumn1.Disposed

    End Sub
End Class