Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmEmployeesDef
    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn



    Dim EditMode As Boolean = False
    Private intID As Long = Nothing
    Private Sub FillEmployees()
        Dim cls As New clsReader
        cls.GetRecord("Select EmployeeID, EmployeePNumber As [P. Number],EmployeeName As [Name],EmployeeFatherName As [Father Name],EmployeeDesignation As [Designation], Status from tblEmployees", cn)
        ',EmployeeGrade,EmployeeCNIC,EmployeeDOB,EmployeeRegionJoining,EmployeeTransferFrom,EmployeeTransferTo,EmployeeRegionLeaving
        Me.grd.DataSource = AddSerial(cls.ds.Tables(0))

        Dim intCSize As Integer() = New Integer() {40, 10, 70, 160, 130, 110, 70}
        grd = GridColumnSize(grd, intCSize)

        grd.Columns("EmployeeID").Visible = False

    End Sub

    Private Sub frmSupplierDef_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ZeroPoint()

    End Sub


    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()
    End Sub


    Private Sub ZeroPoint()
        FillEmployees()
        Dim ctl As Control
        For Each ctl In Me.grpEmployee.Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = Nothing
            End If
        Next
        Me.txtDOB.Text = Nothing
        Me.txtDOJ.Text = Nothing

        txtCNIC.Text = Nothing

        Me.grpEmployee.Enabled = False
        Me.grd.Enabled = True
        EditMode = False
        ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)

    End Sub


    Private Sub grd_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellDoubleClick
        If btnEdit.Visible = False Then Exit Sub

        If e.RowIndex < 0 Then Exit Sub
        intID = grd.Item("EmployeeID", e.RowIndex).Value
        Dim cls As New clsReader
        cls.GetRecord("SELECT EmployeeID,EmployeePNumber,EmployeeName,EmployeeFatherName,EmployeeDesignation, " &
                      "EmployeeGrade, EmployeeCNIC,EmployeeDOB,EmployeeRegionJoining, EmployeeTransferFrom," &
                        "EmployeeTransferTo,ActiveInactive, Status FROM tblEmployees " &
                        "WHERE EMPLOYEEID = " & intID, cn)

        Me.txtPNo.Text = cls.ds.Tables(0).Rows(0)("EmployeePNumber")
        Me.txtName.Text = cls.ds.Tables(0).Rows(0)("EmployeeName")
        Me.txtFatherName.Text = IIf(IsDBNull(cls.ds.Tables(0).Rows(0)("EmployeeFatherName")) = True, "", cls.ds.Tables(0).Rows(0)("EmployeeFatherName"))
        Me.txtDesignation.Text = IIf(IsDBNull(cls.ds.Tables(0).Rows(0)("EmployeeDesignation")) = True, "", cls.ds.Tables(0).Rows(0)("EmployeeDesignation"))
        Me.txtGrade.Text = IIf(IsDBNull(cls.ds.Tables(0).Rows(0)("EmployeeGrade")) = True, "", cls.ds.Tables(0).Rows(0)("EmployeeGrade"))
        Me.txtCNIC.Text = IIf(IsDBNull(cls.ds.Tables(0).Rows(0)("EmployeeCNIC")) = True, "", cls.ds.Tables(0).Rows(0)("EmployeeCNIC"))
        Me.txtDOB.Text = IIf(IsDBNull(cls.ds.Tables(0).Rows(0)("EmployeeDOB")) = True, "", cls.ds.Tables(0).Rows(0)("EmployeeDOB"))
        Me.txtDOJ.Text = IIf(IsDBNull(cls.ds.Tables(0).Rows(0)("EmployeeRegionJoining")) = True, "", cls.ds.Tables(0).Rows(0)("EmployeeRegionJoining"))
        Me.txtTransferFrom.Text = IIf(IsDBNull(cls.ds.Tables(0).Rows(0)("EmployeeTransferFrom")) = True, "", cls.ds.Tables(0).Rows(0)("EmployeeTransferFrom"))
        Me.txtTransferTo.Text = IIf(IsDBNull(cls.ds.Tables(0).Rows(0)("EmployeeTransferTo")) = True, "", cls.ds.Tables(0).Rows(0)("EmployeeTransferTo"))
        Me.cbActive.Checked = cls.ds.Tables(0).Rows(0)("ActiveInactive")
        Me.cboStatus.Text = IIf(IsDBNull(cls.ds.Tables(0).Rows(0)("Status")) = True, "In Service", cls.ds.Tables(0).Rows(0)("Status"))
        ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
        EditMode = True
        Me.grpEmployee.Enabled = True
        txtName.Focus()
        grd.Enabled = False



    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ActionDelete()
    End Sub

    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub
        Me.grd.Enabled = False
        Me.grpEmployee.Enabled = True
        Me.cboStatus.SelectedIndex = 0
        txtName.Focus()
        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub
        grd_CellDoubleClick(grd, New DataGridViewCellEventArgs(grd.CurrentCell.ColumnIndex, grd.CurrentRow.Index))

    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave
        If btnSave.Visible = False Then Exit Sub
        If txtName.Text = "" Or txtPNo.Text = "" Then
            MessageBox.Show("P.No or Name is Missing. Please Enter Valid Values", "Wrong Values", MessageBoxButtons.OK)
            Exit Sub

        End If


        'If MsgBox("Do you Want to Save the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        If MsgBox("Do You Want to Save the Record", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then Exit Sub

        Try
            Dim cls As New clsWriter
            Dim strFld As String() = New String() {"EmployeePNumber", "EmployeeName", "EmployeeFatherName", "EmployeeDesignation", "EmployeeGrade", "EmployeeCNIC", "EmployeeDOB", "EmployeeRegionJoining", "EmployeeTransferFrom", "EmployeeTransferTo", "ActiveInactive", "Status"}
            Dim objValues As Object() = New Object() {txtPNo.Text, txtName.Text, txtFatherName.Text, txtDesignation.Text, txtGrade.Text, txtCNIC.Text, fnTextToDate(txtDOB.Text), fnTextToDate(txtDOJ.Text), txtTransferFrom.Text, txtTransferTo.Text, cbActive.CheckState, cboStatus.Text}
            If EditMode = False Then
                cls.AddRecord("tblEmployees", strFld, objValues, cn)
                cls = Nothing
            ElseIf EditMode = True Then
                cls.UpdateRecord("tblEmployees", strFld, objValues, " Where EmployeeID = " & intID, cn)
                cls = Nothing
            End If
            ZeroPoint()
        Catch ex As Exception
            Exit Sub
        End Try




    End Sub

    Public Sub ActionCancel() Implements ICancelBtn.ActionCancel
        If btnCancel.Visible = False Then Exit Sub

        If MsgBox("Do you Want to Cancel the Changes", MessageBoxButtons.YesNo, "") = Windows.Forms.DialogResult.No Then Exit Sub

        ZeroPoint()

    End Sub

    Public Sub ActionDelete() Implements IDeleteBtn.ActionDelete
        If btnDelete.Visible = False Then Exit Sub
        If MessageBox.Show("Do you Want to Delete the Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
        Dim cls As New clsWriter
        cls.DeleteRecord("tblEmployees", "EmployeeId", intID, cn)
        cls = Nothing
        ZeroPoint()

    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MsgBox("Do you Want to Close the Form", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Close()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If grdRowindex < 0 Then Exit Sub
        grd_CellDoubleClick(grd, New DataGridViewCellEventArgs(grdColumnindex, grdRowindex))
    End Sub

    Dim grdRowindex As Integer = Nothing
    Dim grdColumnindex As Integer = Nothing


    Private Sub grd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd.CellClick
        grdRowindex = grd.CurrentCell.RowIndex
        grdColumnindex = grd.CurrentCell.ColumnIndex

    End Sub

End Class