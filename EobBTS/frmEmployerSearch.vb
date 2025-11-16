Imports System.Data.SqlClient

Public Class frmEmployerSearch
    Public blnSingle As Boolean = False
    Public Destin As Destination
    Public intRIndex As Integer


    Public Enum Destination
        CaseReceived = 0

    End Enum
    Private Sub OK()
        Try

            'grdEmployers.RowCount = 0
            Select Case Destin
                Case Destination.CaseReceived
                    If Me.grdEmployersChild.RowCount >= frmCaseReceived.grdVoucher.RowCount - intRIndex Then
                        frmCaseReceived.grdVoucher.RowCount = frmCaseReceived.grdVoucher.RowCount + (Me.grdEmployersChild.RowCount - (frmCaseReceived.grdVoucher.RowCount - intRIndex)) + 1
                    End If
                    For i As Integer = 0 To Me.grdEmployersChild.RowCount - 1
                        frmCaseReceived.grdVoucher.Item("EmployerName", intRIndex).Value = Me.grdEmployersChild.Item("EmployerName", i).Value
                        frmCaseReceived.grdVoucher.Item("RegionName", intRIndex).Value = Me.grdEmployersChild.Item("RegionName", i).Value
                        frmCaseReceived.grdVoucher.Item("Beat", intRIndex).Value = Me.grdEmployersChild.Item("Beat", i).Value
                        frmCaseReceived.grdVoucher.Item("EmployerCode", intRIndex).Value = Me.grdEmployersChild.Item("EmployerCode", i).Value
                        intRIndex = intRIndex + 1
                    Next
                    Me.Close()


            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmEmployerSearch_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.grdEmployersChild.RowCount = 0
    End Sub
    Private Sub zeropoint()
        Try
            txtCode.Text = Nothing
            txtDesc.Text = Nothing
        Catch ex As Exception

        End Try

    End Sub
    Private Sub frmEmployerSearched_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        zeropoint()

    End Sub


    Dim i As Integer = 0
    Private Sub grdEmployers_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEmployers.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        If blnSingle = False Then
            Me.grdEmployersChild.RowCount = grdEmployersChild.RowCount + 1
            i = grdEmployersChild.RowCount
            Me.grdEmployersChild.Item(0, i - 1).Value = i

            Me.grdEmployersChild.Item("EmployerCode", i - 1).Value = Me.grdEmployers.Item("EmployerCode", e.RowIndex).Value
            Me.grdEmployersChild.Item("EmployerName", i - 1).Value = Me.grdEmployers.Item("EmployerName", e.RowIndex).Value
            Me.grdEmployersChild.Item("RegionName", i - 1).Value = Me.grdEmployers.Item("Region", e.RowIndex).Value
            Me.grdEmployersChild.Item("Beat", i - 1).Value = Me.grdEmployers.Item("Beat", e.RowIndex).Value
            Me.grdEmployersChild.Item("ActApplicability", i - 1).Value = Format(Me.grdEmployers.Item("Appl Date", e.RowIndex).Value, "dd-MM-yyyy")
            Me.grdEmployersChild.Item("RegDate", i - 1).Value = Format(Me.grdEmployers.Item("Reg Date", e.RowIndex).Value, "dd-MM-yyyy")
            Me.grdEmployersChild.Item("ActiveStatus", i - 1).Value = Me.grdEmployers.Item("Status", e.RowIndex).Value

        ElseIf blnSingle = True Then
            Me.grdEmployersChild.RowCount = 1
            Me.grdEmployersChild.Item(0, 0).Value = 1

            Me.grdEmployersChild.Item("EmployerCode", i - 1).Value = Me.grdEmployers.Item("EmployerCode", e.RowIndex).Value
            Me.grdEmployersChild.Item("EmployerName", i - 1).Value = Me.grdEmployers.Item("EmployerName", e.RowIndex).Value
            Me.grdEmployersChild.Item("RegionName", i - 1).Value = Me.grdEmployers.Item("Region", e.RowIndex).Value
            Me.grdEmployersChild.Item("Beat", i - 1).Value = Me.grdEmployers.Item("Beat", e.RowIndex).Value
            Me.grdEmployersChild.Item("ActApplicability", i - 1).Value = Format(Me.grdEmployers.Item("Appl Date", e.RowIndex).Value, "dd-MM-yyyy")
            Me.grdEmployersChild.Item("RegDate", i - 1).Value = Format(Me.grdEmployers.Item("Reg Date", e.RowIndex).Value, "dd-MM-yyyy")
            Me.grdEmployersChild.Item("ActiveStatus", i - 1).Value = Me.grdEmployers.Item("Status", e.RowIndex).Value

        End If

    End Sub
    Private strWord As String = Nothing
    Private intLen As Integer

    Private Sub grdBudget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdEmployers.KeyDown
        If e.Control And e.KeyCode = Keys.D Then
            grdEmployers_CellDoubleClick(sender, New DataGridViewCellEventArgs(CType(sender, DataGridView).CurrentCell.ColumnIndex, CType(sender, DataGridView).CurrentRow.Index))
        End If
        If e.KeyCode = Keys.Enter Then
            OK()
        End If
    End Sub

    Private Sub grdBudget_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdEmployers.Sorted
        For i As Integer = 1 To grdEmployers.RowCount
            grdEmployers.Item(0, i - 1).Value = i
        Next
    End Sub

    Private Sub grdBudgetChild_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdEmployersChild.KeyDown
        If grdEmployersChild.RowCount = 0 Then Exit Sub
        If e.KeyCode = Keys.Delete Then
            Dim i As Integer = CType(sender, DataGridView).CurrentRow.Index
            Me.grdEmployersChild.Rows.RemoveAt(i)
        End If
        If e.KeyCode = Keys.Enter Then
            OK()
        End If

    End Sub

    Private Sub grdBudgetChild_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grdEmployersChild.RowsRemoved
        If grdEmployersChild.RowCount = 0 Then Exit Sub
        For i As Integer = 0 To grdEmployersChild.RowCount - 1
            grdEmployersChild.Item(0, i).Value = i + 1
        Next
    End Sub

    Private Sub grdBudgetChild_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdEmployersChild.Sorted
        For i As Integer = 1 To grdEmployersChild.RowCount
            grdEmployersChild.Item(0, i - 1).Value = i
        Next
    End Sub


    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        OK()
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()

    End Sub
    Private Sub GetBudget_Bydesc()
        Try

            Dim cls As New clsReader
            cls.GetRecord("select EmployerCode,EmployerName,Region,Beat,[Address],ApplicabilityDate as [Appl Date],RegistrationDate as [Reg Date],ActiveStatus as [Status] from tblEmployers  Where EmployerName like '%" & txtDesc.Text & "%' order by EmployerName", cn)
            grdEmployers.DataSource = AddSerial(cls.ds.Tables(0))
            grdEmployers.Columns("Sr").Width = 30
            grdEmployers.Columns("EmployerCode").Width = 100
            grdEmployers.Columns("EmployerName").Width = 200
            grdEmployers.Columns("Region").Width = 80
            grdEmployers.Columns("Beat").Width = 30
            grdEmployers.Columns("Address").Width = 190
            grdEmployers.Columns("Appl Date").Width = 80
            grdEmployers.Columns("Reg Date").Width = 80
            grdEmployers.Columns("Status").Width = 40

            mdlGeneral.ResizeGridRows(grdEmployers, "EmployerName")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDesc_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc.KeyDown
        Me.txtCode.Text = Nothing
        If e.KeyCode = Keys.Enter Then
            If Len(txtDesc.Text) >= 4 Then
                GetBudget_Bydesc()
            End If

        End If

    End Sub
    Private Sub GetBudget_ByCode()
        Try
            Dim cls As New clsReader
            cls.GetRecord("select EmployerCode,EmployerName,Region,Beat,[Address],ApplicabilityDate as [Appl Date],RegistrationDate as [Reg Date],ActiveStatus as [Status] from tblEmployers  Where EmployerCode like '%" & txtCode.Text & "%' order by EmployerName", cn)
            grdEmployers.DataSource = AddSerial(cls.ds.Tables(0))
            grdEmployers.Columns("Sr").Width = 30
            grdEmployers.Columns("EmployerCode").Width = 100
            grdEmployers.Columns("EmployerName").Width = 200
            grdEmployers.Columns("Region").Width = 80
            grdEmployers.Columns("Beat").Width = 30
            grdEmployers.Columns("Address").Width = 190
            grdEmployers.Columns("Appl Date").Width = 80
            grdEmployers.Columns("Reg Date").Width = 80
            grdEmployers.Columns("Status").Width = 40

            mdlGeneral.ResizeGridRows(grdEmployers, "EmployerName")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        Me.txtDesc.Text = Nothing
        If e.KeyCode = Keys.Enter Then
            If Len(txtCode.Text) >= 4 Then
                GetBudget_ByCode()
            End If

        End If

    End Sub


End Class