Imports System.Data.SqlClient
Public Class frmJobAssignment
    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn

    Dim EditMode As Boolean = False

    Private Sub frmGradeDef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ZeroPoint()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()
    End Sub

    Private Sub ZeroPoint()

        EditMode = False
        FillJobAssigned()
        grpJobInfo.Enabled = False
        On Error Resume Next
        ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
        btnAdd.Visible = False

    End Sub
    Private Sub FillJobAssigned()
        Dim cls As New clsReader
        cls.GetRecord("select PreparedBy,CheckedBy,CheckedBy_2,AuditBy,ApprovedBy from tblAssignment", cn)

        txtPreparedName.Text = cls.ds.Tables(0).Rows(0)("PreparedBy")
        txtCheckedName.Text = cls.ds.Tables(0).Rows(0)("CheckedBy")
        txtCheckedName2.Text = cls.ds.Tables(0).Rows(0)("CheckedBy_2")
        txtAuditBy.Text = cls.ds.Tables(0).Rows(0)("AuditBy")
        txtApprovedName.Text = cls.ds.Tables(0).Rows(0)("ApprovedBy")
        cls = Nothing

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ActionDelete()
    End Sub

    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub

        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub
        On Error Resume Next
        ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
        Me.grpJobInfo.Enabled = True
        btnDelete.Visible = False

    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave
        If btnSave.Visible = False Then Exit Sub
        If MsgBox("Do You Want to Save the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub


        Dim cmd As New SqlCommand
        Dim myTran As SqlTransaction = cn.BeginTransaction
        Try
            cmd.Connection = cn
            cmd.Transaction = myTran
            cmd.CommandText = "Delete  tblAssignment  insert into tblAssignment values ('" & txtPreparedName.Text & "','" & txtCheckedName.Text & "','" & txtAuditBy.Text & "','" & txtApprovedName.Text & "','" & txtCheckedName2.Text & "')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = Nothing
            myTran.Commit()
            ZeroPoint()
            MsgBox(" The Record Has been Saved")
        Catch ex As Exception
            MsgBox(ex.ToString)
            myTran.Rollback()
        End Try



    End Sub

    Public Sub ActionCancel() Implements ICancelBtn.ActionCancel
        If MsgBox("Do You Want to Cancel the Changes", vbYesNo, "") = MsgBoxResult.No Then Exit Sub
        If btnCancel.Visible = False Then Exit Sub
        ZeroPoint()
    End Sub

    Public Sub ActionDelete() Implements IDeleteBtn.ActionDelete

        If btnDelete.Visible = False Then Exit Sub
        'If MessageBox.Show("Do you Want to Delete the Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
        'Dim cls As New ClsWriter
        'cls.DeleteRecord("tblAssignment", "AssignmentID", IntID, cn)
        'cls = Nothing
        'ZeroPoint()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ActionEdit()
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you want to close the this Form", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
        Me.Close()

    End Sub


End Class