Imports System.Data.SqlClient
Public Class frmRecommendedByBTS
    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn

    Private EditMode As Boolean = False

    Public intRecommendedID As Long


    Private Sub grdRecommended_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRecommended.CellContentClick
        If e.ColumnIndex = grdRecommended.Columns("Del").Index Then
            If grdRecommended.CurrentRow.Index = grdRecommended.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            grdRecommended.Rows.RemoveAt(e.RowIndex)

            FillSerial(grdRecommended)
        End If

    End Sub



    Private Sub grdRecommended_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRecommended.CellEndEdit
        If e.ColumnIndex = grdRecommended.Columns("FIRNo").Index Then
            Dim CellValue As String
            CellValue = grdRecommended.Item(e.ColumnIndex, e.RowIndex).Value
            '--------------Check Weather the case is already Recommended or Not Recommended------------
            Dim cls_0 As New clsReader
            cls_0.GetRecord("select M.FIRNo,RM.RecommendedDate ,RD.FIRID from tblcaseRecommendedDetail RD inner join tblFIRMain M on RD.FIRID= M.FIRID inner join tblCaseRecommendedMain RM on RM.RecommendedID = RD.RecommendedID where M.FIRNo = '" & CellValue & "'", cn)
            If cls_0.EOF = False Then
                MessageBox.Show(cls_0.ds.Tables(0).Rows(0)("RecommendedDate"), "This Record Already Recommended Dated ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.grdRecommended.Item("FIRID", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("FIRNo", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("ClaimantName", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("ClaimantCNIC", e.RowIndex).Value = Nothing

                Exit Sub
            End If
            '-----------------------------------------------------

            Dim cls As New clsReader
            cls.GetRecord("Select FIRID,FIRNo,ClaimantCNIC,ClaimantName + '- ' + ClaimantRelative As ClaimantName From tblFIRMain Where FIRNo = '" & CellValue & "'", cn)
            If cls.EOF = False Then
                '----------Check the Verifed Period is not prior to the Applicability Date of Act --------
                Dim cls_2 As New clsReader
                cls_2.GetRecord("Execute [dbo].[spCheck_Verified_Period] @FIRNo = '" & CellValue & "'", cn)
                If cls_2.EOF = False Then
                    MessageBox.Show("The Period Veried is Prior to the Applicability", "Check Verified Period", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                cls_2 = Nothing

                Me.grdRecommended.Item("FIRID", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("FIRID")
                Me.grdRecommended.Item("FIRNO", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("FIRNo")
                Me.grdRecommended.Item("ClaimantCNIC", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("ClaimantCNIC")
                Me.grdRecommended.Item("ClaimantName", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("ClaimantName")
                If e.RowIndex = CType(sender, DataGridView).RowCount - 1 Then
                    Me.grdRecommended.RowCount = CType(sender, DataGridView).RowCount + 1

                End If
            Else
                Me.grdRecommended.Item("FIRID", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("FIRNo", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("ClaimantName", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("ClaimantCNIC", e.RowIndex).Value = Nothing

            End If
        End If

        If e.ColumnIndex = grdRecommended.Columns("ClaimantCNIC").Index Then
            Dim CellValue As String
            CellValue = grdRecommended.Item(e.ColumnIndex, e.RowIndex).Value

            Dim cls_0 As New clsReader
            cls_0.GetRecord("select M.FIRNo,RM.RecommendedDate ,RD.FIRID from tblcaseRecommendedDetail RD inner join tblFIRMain M on RD.FIRID= M.FIRID inner join tblCaseRecommendedMain RM on RM.RecommendedID = RD.RecommendedID where M.ClaimantCNIC = '" & CellValue & "'", cn)
            If cls_0.EOF = False Then
                MessageBox.Show(cls_0.ds.Tables(0).Rows(0)("RecommendedDate"), "This Record Already Recommended Dated ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.grdRecommended.Item("FIRID", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("FIRNo", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("ClaimantName", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("ClaimantCNIC", e.RowIndex).Value = Nothing

                Exit Sub
            End If

            Dim cls As New clsReader
            cls.GetRecord("Select FIRID,FIRNo,ClaimantCNIC,ClaimantName + '- ' + ClaimantRelative As ClaimantName From tblFIRMain Where ClaimantCNIC = '" & CellValue & "'", cn)
            If cls.EOF = False Then
                '----------Check the Verifed Period is not prior to the Applicability Date of Act --------
                Dim cls_2 As New clsReader
                cls_2.GetRecord("Execute [dbo].[spCheck_Verified_Period] @ClaimantCNIC = '" & CellValue & "'", cn)
                If cls_2.EOF = False Then
                    MessageBox.Show("The Period Veried is Prior to the Applicability", "Check Verified Period", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                cls_2 = Nothing

                Me.grdRecommended.Item("FIRID", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("FIRID")
                Me.grdRecommended.Item("FIRNO", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("FIRNo")
                Me.grdRecommended.Item("ClaimantCNIC", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("ClaimantCNIC")
                Me.grdRecommended.Item("ClaimantName", e.RowIndex).Value = cls.ds.Tables(0).Rows(0)("ClaimantName")
                If e.RowIndex = CType(sender, DataGridView).RowCount - 1 Then
                    Me.grdRecommended.RowCount = CType(sender, DataGridView).RowCount + 1

                End If
            Else
                Me.grdRecommended.Item("FIRID", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("FIRNo", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("ClaimantName", e.RowIndex).Value = Nothing
                Me.grdRecommended.Item("ClaimantCNIC", e.RowIndex).Value = Nothing

            End If

        End If

        FillSerial(Me.grdRecommended)

    End Sub

    Private Sub grdRecommended_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdRecommended.KeyDown
        If e.KeyCode = Keys.Delete Then

            If Me.grdRecommended.CurrentRow.Index = Me.grdRecommended.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Me.grdRecommended.Rows.RemoveAt(grdRecommended.CurrentRow.Index)

            FillSerial(grdRecommended)

        End If
    End Sub



    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()
    End Sub
    Private Sub ZeroPoint()
        EditMode = False
        Me.txtRecommendedID.Text = Nothing
        Me.grdRecommended.RowCount = 0
        Me.grpRecommendedInfo.Enabled = False
        Me.grdRecommended.Enabled = False

        ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub

    Private Sub frmRecommendedByBTS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            txtRecommendedDate.Text = Format(Today(), "dd/MM/yyyy")
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

    Public Sub FillRecommended()
        Try
            Dim cls As New clsReader

            cls.GetRecord("select RecommendedID,RecommendedDate from tblCaseRecommendedMain Where RecommendedID = " & intRecommendedID & "  Select R.FIRID, (Select M.FIRNo from tblFIRMain M where M.FIRID = R.FIRID) as FIRNO,(Select M.ClaimantCNIC from tblFIRMain M where M.FIRID = R.FIRID) as ClaimantCNIC,(Select M.ClaimantName + '- ' + M.ClaimantRelative from tblFIRMain M where M.FIRID = R.FIRID) as ClaimantName,R.PensionStartDate, R.Remarks from tblCaseRecommendedDetail R Where RecommendedID =  " & intRecommendedID, cn)

            Me.txtRecommendedID.Text = cls.ds.Tables(0).Rows(0)("RecommendedID")
            txtRecommendedDate.Text = Format(cls.ds.Tables(0).Rows(0)("RecommendedDate"), "dd/MM/yyyy")
            Me.dtDate.Value = cls.ds.Tables(0).Rows(0)("RecommendedDate")
            Me.grpRecommendedInfo.Enabled = True

            Me.grdRecommended.Enabled = True
            Me.grdRecommended.RowCount = cls.ds.Tables(1).Rows.Count + 1
            For i As Integer = 0 To cls.ds.Tables(1).Rows.Count - 1
                Me.grdRecommended.Item("Sr", i).Value = i + 1
                Me.grdRecommended.Item("FIRID", i).Value = cls.ds.Tables(1).Rows(i)("FIRID")
                Me.grdRecommended.Item("FIRNo", i).Value = cls.ds.Tables(1).Rows(i)("FIRNO")
                Me.grdRecommended.Item("ClaimantCNIC", i).Value = cls.ds.Tables(1).Rows(i)("ClaimantCNIC")
                Me.grdRecommended.Item("ClaimantName", i).Value = cls.ds.Tables(1).Rows(i)("ClaimantName")
                Me.grdRecommended.Item("PensionStartDate", i).Value = IIf(cls.ds.Tables(1).Rows(i)("PensionStartDate") = "01-01-0001", Nothing, cls.ds.Tables(1).Rows(i)("PensionStartDate"))
                Me.grdRecommended.Item("Remarks", i).Value = cls.ds.Tables(1).Rows(i)("Remarks")
            Next

            EditMode = True

            txtRecommendedDate.Focus()
            ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
            cls = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ActionDelete()


    End Sub

    Private Sub grdBudget_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grdRecommended.RowsAdded
        FillSerial(Me.grdRecommended)
    End Sub



    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub
        EditMode = False
        Me.grdRecommended.RowCount = 1
        Me.grpRecommendedInfo.Enabled = True
        Me.grdRecommended.Enabled = True
        Me.txtRecommendedDate.Focus()

        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)

    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub
        frmVoucherSearch.myTag = "Case_Recommended"
        frmVoucherSearch.ShowDialog()
    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave
        If btnSave.Visible = False Then Exit Sub
        If MsgBox("Do You Want to Save the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        'For i As Integer = 0 To Me.grdRecommended.RowCount - 2
        '    If Me.grdRecommended.Item("FIRNo", i).Value = Nothing Then
        '        MsgBox("Any of the Row the Claim Number is Missing ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        '        Exit Sub
        '    End If
        'Next
        ''--------------------------Converting Grid to Table--------------

        Dim tblDetail As New DataTable
        Dim strFldNames As String() = New String() {"FIRID", "PensionStartDate", "Remarks"}

        For i As Integer = 0 To UBound(strFldNames)
            tblDetail.Columns.Add(strFldNames(i).ToString)
        Next

        For r As Integer = 0 To Me.grdRecommended.RowCount - 2
            If Not (grdRecommended.Item("ClaimantName", r).Value = Nothing) Then
                tblDetail.Rows.Add()
                tblDetail.Rows(tblDetail.Rows.Count - 1)("FIRID") = Me.grdRecommended.Item("FIRID", r).Value
                tblDetail.Rows(tblDetail.Rows.Count - 1)("PensionStartDate") = IIf(grdRecommended.Item("PensionStartDate", r).Value = Nothing, "0001-01-01", fnTextToDate(grdRecommended.Item("PensionStartDate", r).Value))
                tblDetail.Rows(tblDetail.Rows.Count - 1)("Remarks") = Me.grdRecommended.Item("Remarks", r).Value

            End If
        Next r

        '---------------------------SAVING MAIN AND DETAIL TABLE-------------------------

        Dim cls As New ClsWriter
        If EditMode = False Then GoTo AddMode
        If EditMode = True Then GoTo EditMode

AddMode:
        Try
            Dim fldNames As String() = New String() {"FYID", "RecommendedDate", "Editable", "UserID"}
            Dim fldValues As Object = New Object() {intFYID, fnTextToDate(txtRecommendedDate.Text), 1, strUser}
            cls.AddRecord(tblDetail, cn, "tblCaseRecommendedDetail", "tblCaseRecommendedMain", "RecommendedID", fldNames, fldValues)
            cls = Nothing
            ZeroPoint()
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
EditMode:
        Try
            Dim fldNames As String() = New String() {"FYID", "RecommendedDate", "Editable", "UserID"}
            Dim fldValues As Object = New Object() {intFYID, fnTextToDate(txtRecommendedDate.Text), 1, strUser}

            cls.UpdateRecord(tblDetail, cn, "tblCaseRecommendedDetail", "tblCaseRecommendedMain", "RecommendedID", fldNames, fldValues, intRecommendedID)
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
                cls.DeleteRecord("tblCaseRecommendedMain", "RecommendedID", intRecommendedID, cn)
                cls = Nothing
                ZeroPoint()

                ButtonPosition(ButtonPos.Delete, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
            End If
        End If


    End Sub

    Private Sub txtRecommendedDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRecommendedDate.Validating
        Try
            Dim dt As New DateTime(Strings.Right(txtRecommendedDate.Text, 4), Strings.Mid(txtRecommendedDate.Text, 4, 2), Strings.Left(txtRecommendedDate.Text, 2))
            If Not (dt >= dtStartDate And dt <= dtEndDate) Then

                MsgBox("Please Enter Date Between " & dtStartDate & " And " & dtEndDate)
                txtRecommendedDate.Focus()
                Exit Sub
            End If
            dtDate.Value = dt
            'MsgBox(Format(dtDate.Value, "MMMM"))

        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtRecommendedDate.Focus()
        End Try
    End Sub

    Private Sub txtRecommendedDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRecommendedDate.GotFocus
        SelectText(sender)
    End Sub

    Private Sub grdRecommended_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdRecommended.CellValidating
        Dim dt2 As Date
        If e.ColumnIndex = grdRecommended.Columns("PensionStartDate").Index Then

            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt2) Then
                MessageBox.Show("Enter correct Date")

                e.Cancel = True
                Exit Sub

            End If
            grdRecommended.Item("PensionStartDate", e.RowIndex).Value = Format(dt2, "dd-MM-yyyy")

        End If
    End Sub

    Private Sub btnDeleteCaseRec_Click(sender As Object, e As EventArgs) Handles btnDeleteCaseRec.Click
        Dim commandDeletetext As String


        commandDeletetext = "Declare @FIRNo as nvarchar(15) " &
                    "Declare @RecordsCount as int " &
                    "Set @FIRNo = '" & txtDeleteCaseNo.Text.ToString & "'" &
                    " Select @RecordsCount =  count(RecommendedID)  from tblCaseRecommendedDetail where RecommendedID = (Select RecommendedID from tblCaseRecommendedDetail where FIRID = (Select FIRID from tblFIRMain where FIRNo = @FIRNo)) " &
                    " If @RecordsCount > 1 begin Delete tblCaseRecommendedDetail where FIRID = (Select FIRID from tblFIRMain where FIRNo = @FIRNo) End " &
                    " If @RecordsCount = 1 begin delete tblCaseRecommendedMain where RecommendedID  = (Select RecommendedID from tblCaseRecommendedDetail where FIRID = (Select FIRID from tblFIRMain where FIRNo = @FIRNo)) End"


        If txtDeleteCaseNo.Text = Nothing Then
            MsgBox("Please Enter Proper Case Number", MsgBoxStyle.OkOnly)
            txtDeleteCaseNo.SelectAll()
            Exit Sub
        End If

        If MsgBox("Do you Want to Delete the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim tr As SqlTransaction = cn.BeginTransaction
        Dim cmd As New SqlCommand With {
            .Transaction = tr,
            .Connection = cn,
            .CommandText = commandDeletetext
        }
        Try
            Dim rowsaffected As Integer
            rowsaffected = cmd.ExecuteNonQuery()
            tr.Commit()
            txtDeleteCaseNo.Text = Nothing
            If rowsaffected > 0 Then
                MsgBox("Record have been Deleted")
            Else
                MsgBox("No Record Exists")
            End If


        Catch ex As Exception
            tr.Rollback()
            txtDeleteCaseNo.Text = Nothing

        End Try





    End Sub
End Class