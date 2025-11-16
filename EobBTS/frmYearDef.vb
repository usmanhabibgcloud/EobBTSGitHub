Public Class frmYearDef

    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn
    Private editMode As Boolean = False
    Private intID As Long = Nothing

    Private Sub ZeroPoint()
        editMode = False
        txtYearIdentifier.ReadOnly = False
        grpYearInfo.Enabled = False
        txtYearIdentifier.Text = Nothing
        grdYear.Enabled = True
        dtStart.Value = mdlGeneral.dtStartDate
        dtEnd.Value = mdlGeneral.dtEndDate
        Try
            Dim cls As New clsReader
            cls.GetRecord("Select FYID, FyIdentifier as [Year Identifier],FYStart [Start Date],FyEnd as [End Date] from tblFinancialYear", cn)
            If cls.EOF = False Then
                grdYear.DataSource = AddSerial(cls.ds.Tables(0))
                grdYear.Columns("FYID").Visible = False
                grdYear.Columns("Sr").Width = 40
                grdYear.Columns("Year Identifier").Width = 230
                grdYear.Columns("Start Date").Width = 90
                grdYear.Columns("End Date").Width = 90
                cls = Nothing
            End If
            ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmYearDef_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ZeroPoint()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Do you Want to Close the Form", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Me.Close()
    End Sub





    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub

        grpYearInfo.Enabled = True
        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
        txtYearIdentifier.Focus()

    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub
        grdYear_CellDoubleClick(grdYear, New DataGridViewCellEventArgs(grdYear.CurrentCell.ColumnIndex, grdYear.CurrentRow.Index))

    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave
        If btnSave.Visible = False Then Exit Sub
        If MsgBox("Do you Want to Save the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        If editMode = False Then GoTo AddMode
        If editMode = True Then GoTo EditMode

AddMode:

        Try
            Dim cls As New clsWriter
            Dim strFldNames As String() = New String() {"FYIdentifier", "FYStart", "FYEnd"}
            Dim objFldValues As Object() = New Object() {txtYearIdentifier.Text, fnTextToDate(txtStartDate.Text), fnTextToDate(txtEndDate.Text)}
            cls.AddRecord("tblFinancialYear", strFldNames, objFldValues, cn)
            cls = Nothing
            ZeroPoint()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Exit Sub

EditMode:

        Try
            Dim cls As New clsWriter
            Dim strFldNames As String() = New String() {"FYIdentifier", "FYStart", "FYEnd"}
            Dim objFldValues As Object() = New Object() {txtYearIdentifier.Text, fnTextToDate(txtStartDate.Text), fnTextToDate(txtEndDate.Text)}
            cls.UpdateRecord("tblFinancialYear", strFldNames, objFldValues, " where FYID = " & intID, cn)

            cls = Nothing
            ZeroPoint()
        Catch ex As Exception

        End Try


    End Sub

    Public Sub ActionCancel() Implements ICancelBtn.ActionCancel
        If btnCancel.Visible = False Then Exit Sub

        If MsgBox("Do you Want to Cancel the Changes", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub

        ZeroPoint()


    End Sub

    Public Sub ActionDelete() Implements IDeleteBtn.ActionDelete
        If btnDelete.Visible = False Then Exit Sub
        If MsgBox("Do you Want to Delete the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim cls As New clsWriter
        cls.DeleteRecord("tblFinancialYear", "FYID", intID, cn)
        cls = Nothing
        ZeroPoint()
    End Sub

    Private Sub txtEndDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndDate.Validated
        Try
            txtEndDate.Text = Convert.ToDateTime(txtEndDate.Text)
            dtEnd.Value = Convert.ToDateTime(txtEndDate.Text)
        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtEndDate.Focus()
        End Try
    End Sub

    Private Sub txtStartDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartDate.Validated
        Try
            txtStartDate.Text = Convert.ToDateTime(txtStartDate.Text)
            dtStart.Value = Convert.ToDateTime(txtStartDate.Text)
        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtStartDate.Focus()
        End Try

    End Sub

    Private Sub grdYear_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYear.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        If btnEdit.Visible = False Then Exit Sub
        Try
            intID = grdYear.Item("FYID", e.RowIndex).Value
            txtYearIdentifier.Text = grdYear.Item("Year Identifier", e.RowIndex).Value
            txtStartDate.Text = grdYear.Item("Start Date", e.RowIndex).Value
            txtEndDate.Text = grdYear.Item("End Date", e.RowIndex).Value
            dtStart.Value = Convert.ToDateTime(grdYear.Item("Start Date", e.RowIndex).Value)
            dtEnd.Value = Convert.ToDateTime(grdYear.Item("End Date", e.RowIndex).Value)

            grpYearInfo.Enabled = True
            grdYear.Enabled = False

            editMode = True
            ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ActionDelete()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ActionEdit()
    End Sub
End Class