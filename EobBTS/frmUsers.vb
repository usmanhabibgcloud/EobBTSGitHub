Public Class frmUsers

    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn

    Private editMode As Boolean = False

    Private Sub frmUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillCombo(cboRole, "Select RoleID from tblRoleMain")
        ZeroPoint()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()
    End Sub

    Private Sub fillUserTree()
        treeUsers.Nodes.Clear()
        Dim cls As New clsReader
        cls.GetRecord("Select UserID from tblUserMain", cn)
        If cls.EOF(0) = False Then
            For i As Integer = 0 To cls.ds.Tables(0).Rows.Count - 1
                treeUsers.Nodes.Add(cls.ds.Tables(0).Rows(i)(0).ToString)
            Next
        End If

        cls = Nothing
    End Sub

    Private Sub treeUsers_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeUsers.AfterSelect
        Dim cls As New clsReader

        With cls
            .GetRecord("Select UserID , UserName,UserPassword,RoleID from tblUserMain where UserID = '" & e.Node.Text & "'", cn)
            txtUserID.Text = .ds.Tables(0).Rows(0)("UserID")
            txtUserName.Text = .ds.Tables(0).Rows(0)("UserName")
            cboRole.Text = .ds.Tables(0).Rows(0)("RoleID")
            txtPassword.Text = .ds.Tables(0).Rows(0)("UserPassword")
            txtConfirm.Text = .ds.Tables(0).Rows(0)("UserPassword")

        End With
        cls = Nothing
        FillYear(True, txtUserID.Text)
    End Sub

    Private Sub treeUsers_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treeUsers.NodeMouseDoubleClick
        editMode = True
        SplitContainer1.Panel2.Enabled = True
        grdDetail.Enabled = True
        ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)

    End Sub

    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub
        editMode = False
        txtUserID.Text = Nothing
        txtUserName.Text = Nothing
        txtPassword.Text = Nothing
        txtConfirm.Text = Nothing
        cboRole.SelectedIndex = 0
        grdDetail.Enabled = True
        SplitContainer1.Panel2.Enabled = True
        SplitContainer1.Panel1.Enabled = False

        FillYear()
        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        Try
            If btnEdit.Visible = False Then Exit Sub
            treeUsers_NodeMouseDoubleClick(treeUsers, New TreeNodeMouseClickEventArgs(n, MouseButtons.Left, 2, x, y))
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave
        If btnSave.Visible = False Then Exit Sub
        Try
            If Strings.Equals(txtPassword.Text, txtConfirm.Text) = False Then
                MsgBox("Passwords does not Match")
                Exit Sub
            End If
            '------------------Converting Grid into DataTable---------------
            Dim tblDetail As New DataTable
            tblDetail.Rows.Clear()
            tblDetail.Columns.Clear()

            Dim strFldNames As String() = New String() {"UserID", "FYID", "Access"}

            For i As Integer = 0 To UBound(strFldNames)
                tblDetail.Columns.Add(strFldNames(i).ToString)
            Next
            For r As Integer = 0 To grdDetail.Rows.Count - 1
                tblDetail.Rows.Add()
                tblDetail.Rows(r)("UserID") = txtUserID.Text
                tblDetail.Rows(r)("FYID") = grdDetail.Item("FYID", r).Value
                'If grdDetail.Item("Access", r).Value = True Then
                '    tblDetail.Rows(r)("Access") = 1
                'Else
                '    tblDetail.Rows(r)("Access") = 0
                'End If
                tblDetail.Rows(r)("Access") = IIf(grdDetail.Item("Access", r).Value = True, 1, 0)
            Next

            '-------------------Saving Main and Detail Table ---------------------
            Dim cls As New clsWriter

            Dim fldNames As String() = New String() {"UserID", "UserName", "UserPassword", "RoleID", "Enable"}
            Dim fldValues As Object = New Object() {txtUserID.Text, txtUserName.Text, txtPassword.Text, cboRole.Text, IIf(chkEnable.CheckState = CheckState.Checked, 1, 0)}

            If editMode = True Then GoTo EditMode
            If editMode = False Then GoTo AddMode

AddMode:
            cls.AddRecord(tblDetail, cn, "tblUserDetail", "tblUserMain", Nothing, fldNames, fldValues)
            cls = Nothing
            ZeroPoint()
            Exit Sub

EditMode:
            cls.UpdateRecord(tblDetail, cn, "tblUserDetail", "tblUserMain", "UserID", fldNames, fldValues, txtUserID.Text, True)
            cls = Nothing
            ZeroPoint()
        Catch ex As Exception
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

    End Sub

    Private Sub FillYear(Optional ByVal EditMode As Boolean = False, Optional ByVal strID As String = Nothing)
        grdDetail.Rows.Clear()
        Dim cls As New clsReader

        If EditMode = True Then
            cls.GetRecord("Select FYID, FyIdentifier ,FYStart ,FyEnd, IsAccess=coalesce((Select Access from tblUserDetail Where UserID='" & strID & "' And FYID=Y.FYID),0) from tblFinancialYear Y", cn)
        Else
            cls.GetRecord("Select FYID, FyIdentifier ,FYStart ,FyEnd, IsAccess=0 from tblFinancialYear", cn)
        End If

        For i As Integer = 0 To cls.ds.Tables(0).Rows.Count - 1
            grdDetail.Rows.Add()
            grdDetail.Item("Sr", i).Value = i + 1
            grdDetail.Item("FYear", i).Value = cls.ds.Tables(0).Rows(i)("FyIdentifier") & " - " & cls.ds.Tables(0).Rows(i)("FyStart") & " To " & cls.ds.Tables(0).Rows(i)("FyEnd")
            grdDetail.Item("Access", i).Value = cls.ds.Tables(0).Rows(i)("IsAccess")
            grdDetail.Item("FYID", i).Value = cls.ds.Tables(0).Rows(i)("FYID")

        Next
        cls = Nothing
    End Sub
    Public Sub ZeroPoint()
        fillUserTree()
        SplitContainer1.Panel2.Enabled = False
        SplitContainer1.Panel1.Enabled = True
        ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ActionEdit()
    End Sub
    Dim n As TreeNode
    Dim x, y As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub treeUsers_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles treeUsers.NodeMouseClick
        n = e.Node
        x = e.X
        y = e.Y
    End Sub
End Class