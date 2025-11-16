Public Class frmORVerificationSent
    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn




    Private EditMode As Boolean = False

    Public intORVerificationID As Long


    Private Sub grdORVerification_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdORVerification.CellContentClick
        If e.ColumnIndex = grdORVerification.Columns("Del").Index Then
            If grdORVerification.CurrentRow.Index = grdORVerification.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            grdORVerification.Rows.RemoveAt(e.RowIndex)

            FillSerial(grdORVerification)
        End If

    End Sub

    Private Sub grdORVerification_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdORVerification.KeyDown
        If e.KeyCode = Keys.Delete Then

            If Me.grdORVerification.CurrentRow.Index = Me.grdORVerification.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Me.grdORVerification.Rows.RemoveAt(grdORVerification.CurrentRow.Index)

            FillSerial(grdORVerification)

        End If
    End Sub



    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()
    End Sub
    Private Sub ZeroPoint()
        EditMode = False
        Me.txtORVerificationID.Text = Nothing
        Me.txtFIRNoFrom.Text = Nothing
        Me.txtFIRNoTo.Text = Nothing
        Me.grdORVerification.RowCount = 0
        Me.grpORVerification.Enabled = False
        Me.grdORVerification.Enabled = False

        ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub

    Private Sub frmCaseSettle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            txtORVerificationDate.Text = Format(Today(), "dd/MM/yyyy")
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

    Public Sub FillORVerification()
        Try
            Dim cls As New clsReader

            cls.GetRecord("select ORVerificationID, FYID,ORVerificationDate from tblORVerificationMain where Editable = 1 and ORVerificationID = " & intORVerificationID & "  Select FIRID,(Select FIRNo from tblFIRMain where FIRID =tblORVerificationDetail.FIRID) as FIRNo,(Select ClaimantName from tblFIRMain where FIRID =tblORVerificationDetail.FIRID) as ClaimantName,(Select IPName from tblFIRMain where FIRID =tblORVerificationDetail.FIRID) as IPName,FIRDetailID,EmployerName,RegionName,Beat from tblORVerificationDetail where ORVerificationID =  " & intORVerificationID, cn)

            Me.txtORVerificationID.Text = cls.ds.Tables(0).Rows(0)("ORVerificationID")
            txtORVerificationDate.Text = Format(cls.ds.Tables(0).Rows(0)("ORVerificationDate"), "dd/MM/yyyy")
            Me.dtDate.Value = cls.ds.Tables(0).Rows(0)("ORVerificationDate")
            Me.grpORVerification.Enabled = True


            Me.grdORVerification.RowCount = 0
            Me.grdORVerification.Enabled = True
            Me.grdORVerification.RowCount = cls.ds.Tables(1).Rows.Count + 1
            For i As Integer = 0 To cls.ds.Tables(1).Rows.Count - 1
                Me.grdORVerification.Item("Sr", i).Value = i + 1
                Me.grdORVerification.Item("FIRDetailID", i).Value = cls.ds.Tables(1).Rows(i)("FIRDetailID")
                Me.grdORVerification.Item("FIRID", i).Value = cls.ds.Tables(1).Rows(i)("FIRID")
                Me.grdORVerification.Item("FIRNo", i).Value = cls.ds.Tables(1).Rows(i)("FIRNo")
                Me.grdORVerification.Item("ClaimantName", i).Value = cls.ds.Tables(1).Rows(i)("ClaimantName")
                Me.grdORVerification.Item("IPName", i).Value = cls.ds.Tables(1).Rows(i)("IPName")
                Me.grdORVerification.Item("EmployerName", i).Value = cls.ds.Tables(1).Rows(i)("EmployerName")
                Me.grdORVerification.Item("RegionName", i).Value = cls.ds.Tables(1).Rows(i)("RegionName")
                Me.grdORVerification.Item("Beat", i).Value = cls.ds.Tables(1).Rows(i)("Beat")

            Next

            EditMode = True

            txtORVerificationDate.Focus()
            ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
            cls = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ActionDelete()


    End Sub


    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub
        EditMode = False
        Me.grdORVerification.RowCount = 0
        Me.grpORVerification.Enabled = True
        Me.grdORVerification.Enabled = True
        Me.txtORVerificationDate.Focus()

        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)

    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub
        frmVoucherSearch.myTag = "OR_Verification"
        frmVoucherSearch.ShowDialog()
    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave
        If btnSave.Visible = False Then Exit Sub
        If MsgBox("Do You Want to Save the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        If Me.grdORVerification.RowCount = 0 Then
            MsgBox("There is No Record to Save ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        '--------------------------Converting Grid to Table--------------

        Dim tblDetail As New DataTable
        Dim strFldNames As String() = New String() {"FIRDetailID", "FIRID", "EmployerName", "RegionName", "Beat"}

        For i As Integer = 0 To UBound(strFldNames)
            tblDetail.Columns.Add(strFldNames(i).ToString)
        Next

        For r As Integer = 0 To Me.grdORVerification.RowCount - 2
            If Not (grdORVerification.Item("FIRNo", r).Value = Nothing) Then
                tblDetail.Rows.Add()
                tblDetail.Rows(tblDetail.Rows.Count - 1)("FIRDetailID") = Me.grdORVerification.Item("FIRDetailID", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("FIRID") = Me.grdORVerification.Item("FIRID", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("EmployerName") = Me.grdORVerification.Item("EmployerName", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("RegionName") = Me.grdORVerification.Item("RegionName", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("Beat") = Me.grdORVerification.Item("Beat", r).Value

            End If
        Next r

        '---------------------------SAVING MAIN AND DETAIL TABLE-------------------------

        Dim cls As New ClsWriter
        If EditMode = False Then GoTo AddMode
        If EditMode = True Then GoTo EditMode

AddMode:
        Try
            Dim fldNames As String() = New String() {"FYID", "ORVerificationDate", "Editable", "UserID"}
            Dim fldValues As Object = New Object() {intFYID, fnTextToDate(txtORVerificationDate.Text), 1, strUser}
            cls.AddRecord(tblDetail, cn, "tblORVerificationDetail", "tblORVerificationMain", "ORVerificationID", fldNames, fldValues)
            cls = Nothing
            ZeroPoint()
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
EditMode:
        Try
            Dim fldNames As String() = New String() {"FYID", "ORVerificationDate", "Editable", "UserID"}
            Dim fldValues As Object = New Object() {intFYID, fnTextToDate(txtORVerificationDate.Text), 1, strUser}

            cls.UpdateRecord(tblDetail, cn, "tblORVerificationDetail", "tblORVerificationMain", "ORVerificationID", fldNames, fldValues, intORVerificationID)
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
                cls.DeleteRecord("tblORVerificationMain", "ORVerificationID", intORVerificationID, cn)
                cls = Nothing
                ZeroPoint()

                ButtonPosition(ButtonPos.Delete, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
            End If
        End If


    End Sub

    Private Sub txtBDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtORVerificationDate.Validating
        Try
            Dim dt As New DateTime(Strings.Right(txtORVerificationDate.Text, 4), Strings.Mid(txtORVerificationDate.Text, 4, 2), Strings.Left(txtORVerificationDate.Text, 2))
            If Not (dt >= dtStartDate And dt <= dtEndDate) Then

                MsgBox("Please Enter Date Between " & dtStartDate & " And " & dtEndDate)
                txtORVerificationDate.Focus()
                Exit Sub
            End If
            dtDate.Value = dt
            'MsgBox(Format(dtDate.Value, "MMMM"))

        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtORVerificationDate.Focus()
        End Try
    End Sub

    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtORVerificationDate.GotFocus

        SelectText(sender)
    End Sub





    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If txtFIRNoFrom.Text = Nothing Or txtFIRNoTo.Text = Nothing Then
            MessageBox.Show("Please Enter Valid Values in Text Boxes, Second Text Box may not be Lesser than First Text Box ")
            txtFIRNoFrom.Focus()
            Exit Sub
        End If



        If CInt(txtFIRNoTo.Text) < CInt(txtFIRNoFrom.Text) Then
            MessageBox.Show("Please Enter Valid Values in Text Boxes, Second Text Box may not be Lesser than First Text Box ")
            txtFIRNoFrom.Focus()
            Exit Sub
        End If

        Try
            Dim cls As New clsReader

            cls.GetRecord("Select M.FIRID,M.FIRNo,M.ClaimantName,M.IPName,D.FIRDetailID,D.EmployerName,D.RegionName,D.Beat from tblFIRMain M inner join tblFIRDetail D on M.FIRID=D.FIRID left join tblCaseSettleDetail S on M.FIRID = S.FIRID left join tblORVerificationDetail OD on D.FIRDetailID=OD.FIRDetailID  left join tblVerificationDetail VD on D.FIRDetailID = VD.FIRDetailID where S.ClaimNo is null and OD.FIRDetailID is null and D.RegionName <> '" & strMyRegion & "' and VD.FIRDetailID is null  and try_convert(numeric(38,12),M.FIRNo) >= " & CInt(txtFIRNoFrom.Text) & " and try_convert(numeric(38,12),M.FIRNo) <= " & CInt(txtFIRNoTo.Text) & " order by M.FIRNo", cn)
            Me.grdORVerification.RowCount = 0
            Me.grdORVerification.Enabled = True
            Me.grdORVerification.RowCount = cls.ds.Tables(0).Rows.Count + 1
            For i As Integer = 0 To cls.ds.Tables(0).Rows.Count - 1
                Me.grdORVerification.Item("Sr", i).Value = i + 1
                Me.grdORVerification.Item("FIRDetailID", i).Value = cls.ds.Tables(0).Rows(i)("FIRDetailID")
                Me.grdORVerification.Item("FIRID", i).Value = cls.ds.Tables(0).Rows(i)("FIRID")
                Me.grdORVerification.Item("FIRNo", i).Value = cls.ds.Tables(0).Rows(i)("FIRNo")
                Me.grdORVerification.Item("ClaimantName", i).Value = cls.ds.Tables(0).Rows(i)("ClaimantName")
                Me.grdORVerification.Item("IPName", i).Value = cls.ds.Tables(0).Rows(i)("IPName")
                Me.grdORVerification.Item("EmployerName", i).Value = cls.ds.Tables(0).Rows(i)("EmployerName")
                Me.grdORVerification.Item("RegionName", i).Value = cls.ds.Tables(0).Rows(i)("RegionName")
                Me.grdORVerification.Item("Beat", i).Value = cls.ds.Tables(0).Rows(i)("Beat")

            Next


            cls = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class