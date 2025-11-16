Public Class FrmUserRole

    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn


    Private editMode As Boolean = False

    Private Sub FrmUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ZeroPoint()
    End Sub


    Private Sub CreateTab(Optional ByVal edit As Boolean = False)
        Dim intSize As Integer() = New Integer() {40, 300, 50, 50, 50, 50}
        If tabRole.TabPages.Count > 0 Then
            tabRole.TabPages.Clear()
        End If

        Dim cls As New clsReader
        With cls

            '.GetRecord("Select FYID,FYIdentifier,FYStart,FYEnd from tblFinancialYear", cn)

            For i As Integer = 0 To 0
                Dim TP As New TabPage
                Dim grd As New DataGridView With {
                    .Parent = TP,
                    .Name = "Grid" & i.ToString,
                    .Dock = DockStyle.Fill
                }
                Dim clsM As New clsReader
                Dim tbl As New DataTable

                If edit = True Then
                    clsM.GetRecord("Select d.mnuCode , case mnuLevel When 1 then mnuCaption when 2 then space(8)+mnuCaption when 3 then space(16)+mnuCaption end as Menu ," &
                    " cast(case when charindex('X',d.Access,1)>0 then 1 else 0 end as bit) as [Access]," &
                    " cast(case when charindex('A',d.Access,1)>0 then 1 else 0 end as bit) as [Add]," &
                    " cast(case when charindex('E',d.Access,1)>0 then 1 else 0 end as bit) as [Edit]," &
                    " cast(case when charindex('D',d.Access,1)>0 then 1 else 0 end as bit) as [Delete] " &
                    " from tblRoleDetail d inner join tblMenu m on d.mnuCode = m.mnucode where d.RoleID = '" & treeRoles.SelectedNode.Text & "' ORDER BY MNUINDEX", cn)
                Else
                    clsM.GetRecord("Select mnuCode,case mnuLevel When 1 then mnuCaption when 2 then space(8)+mnuCaption when 3 then space(16)+mnuCaption end as Menu ,cast(0 as bit) As Access, cast(0 as bit) As [Add], cast(0 as bit) As Edit, cast(0 as bit) As [Delete] from tblMenu order by mnuIndex", cn)
                End If

                'clsM.GetRecord("Select mnuCode,mnuCaption as Menu from tblMenu where mnuLevel = 3 order by mnuIndex", cn)
                tbl = clsM.ds.Tables(0)

                grd.DataSource = tbl

                grd.RowHeadersVisible = False
                grd.AllowUserToAddRows = False
                grd.AllowUserToDeleteRows = False
                grd.AllowUserToOrderColumns = False
                grd.AllowUserToResizeColumns = False
                grd.AllowUserToResizeRows = False

                TP.Text = "Access Detail"
                TP.Name = "page1"
                TP.Controls.Add(grd)
                'TP.Tag = .ds.Tables(0).Rows(i)("FYID").ToString
                tabRole.Controls.Add(TP)
                grd.Columns("mnuCode").Visible = False
                grd.Columns("Menu").ReadOnly = True
                GridColumnSize(grd, intSize)

            Next

        End With
        cls = Nothing


    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()
    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()
    End Sub
    Private Function BooleanToChar(ByVal blnX As Boolean, ByVal blnA As Boolean, ByVal blnE As Boolean, ByVal blnD As Boolean) As String
        Dim str As String = Nothing
        If blnX = True Then str += "X"
        If blnA = True Then str += "A"
        If blnE = True Then str += "E"
        If blnD = True Then str += "D"

        Return str
    End Function

    Private Sub FillRollTree()
        treeRoles.Nodes.Clear()
        Dim cls As New clsReader
        cls.GetRecord("Select RoleID from tblRoleMain", cn)
        If cls.EOF(0) = False Then
            For i As Integer = 0 To cls.ds.Tables(0).Rows.Count - 1
                treeRoles.Nodes.Add(cls.ds.Tables(0).Rows(i)(0).ToString)
            Next
        End If

        cls = Nothing
    End Sub

    Private Sub TreeRole_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeRoles.AfterSelect
        Dim cls As New clsReader
        With cls
            .GetRecord("Select RoleID , RoleName from tblRoleMain where RoleID = '" & e.Node.Text & "'", cn)
            txtRoleID.Text = .ds.Tables(0).Rows(0)("RoleID")
            txtRoleName.Text = .ds.Tables(0).Rows(0)("RoleName")
        End With
        cls = Nothing

    End Sub


    Private Sub TreeUsers_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles treeRoles.NodeMouseDoubleClick
        CreateTab(True)
        editMode = True
        tabRole.Enabled = True
        txtRoleName.Enabled = True
        ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub

        editMode = False

        CreateTab()

        txtRoleID.Enabled = True
        txtRoleName.Enabled = True
        txtRoleID.Text = Nothing
        txtRoleName.Text = Nothing

        treeRoles.Enabled = False
        tabRole.Enabled = True

        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub
        Dim x As Integer = treeRoles.SelectedNode.Bounds.X
        Dim y As Integer = treeRoles.SelectedNode.Bounds.Y
        treeUsers_NodeMouseDoubleClick(treeRoles, New TreeNodeMouseClickEventArgs(treeRoles.SelectedNode, Windows.Forms.MouseButtons.Left, 2, x, y))



    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave
        If btnSave.Visible = False Then Exit Sub

        If MsgBox("Do you Want to Save the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        '------------------Converting Grid into DataTable---------------
        Dim tblDetail As New DataTable
        tblDetail.Rows.Clear()
        tblDetail.Columns.Clear()


        Dim strFldNames As String() = New String() {"RoleID", "mnuCode", "Access"}

        For i As Integer = 0 To UBound(strFldNames)
            tblDetail.Columns.Add(strFldNames(i).ToString)
        Next
        tabRole.SelectedIndex = 0
        Dim TP As TabPage
        For Each TP In tabRole.TabPages
            Dim grd As DataGridView

            For Each grd In TP.Controls
                grd.EndEdit()
                For r As Integer = 0 To grd.Rows.Count - 1
                    tblDetail.Rows.Add()
                    tblDetail.Rows(tblDetail.Rows.Count - 1)("RoleID") = txtRoleID.Text
                    'tblDetail.Rows(tblDetail.Rows.Count - 1)("FYID") = Val(TP.Tag)
                    tblDetail.Rows(tblDetail.Rows.Count - 1)("mnuCode") = grd.Item("mnuCode", r).Value
                    tblDetail.Rows(tblDetail.Rows.Count - 1)("Access") = BooleanToChar(grd.Item("Access", r).Value, grd.Item("Add", r).Value, grd.Item("Edit", r).Value, grd.Item("Delete", r).Value)
                Next
            Next
        Next

        '-------------------Saving Main and Detail Table ---------------------
        Dim cls As New ClsWriter

        Dim fldNames As String() = New String() {"RoleID", "RoleName"}
        Dim fldValues As Object = New Object() {txtRoleID.Text, txtRoleName.Text}

        If editMode = True Then GoTo EditMode
        If editMode = False Then GoTo AddMode

AddMode:
        cls.AddRecord(tblDetail, cn, "tblRoleDetail", "tblRoleMain", Nothing, fldNames, fldValues)
        cls = Nothing
        ZeroPoint()
        Exit Sub

EditMode:
        cls.UpdateRecord(tblDetail, cn, "tblRoleDetail", "tblRoleMain", "RoleID", fldNames, fldValues, txtRoleID.Text, True)
        cls = Nothing
        ZeroPoint()



    End Sub

    Public Sub ActionCancel() Implements ICancelBtn.ActionCancel
        If btnCancel.Visible = False Then Exit Sub

        If MsgBox("Do you Want to Cancel the Changes", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub
        ZeroPoint()

    End Sub

    Public Sub ActionDelete() Implements IDeleteBtn.ActionDelete
        If btnDelete.Visible = False Then Exit Sub

    End Sub


    Private Sub ZeroPoint()
        txtRoleID.Enabled = False
        txtRoleName.Enabled = False
        treeRoles.Enabled = True
        tabRole.Enabled = True

        fillRollTree()
        tabRole.Enabled = False
        ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ActionEdit()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Do you Want to Close the Form", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Close()

    End Sub
End Class