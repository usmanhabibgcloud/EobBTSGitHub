Imports System.Data.SqlClient

Public Class frmRegionInfo
    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn



    Private Sub FrmCompanyInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ZeroPoint()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MsgBox("Do you Want to Close the Form", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Me.Close()
    End Sub
    Private Sub ZeroPoint()
        grpRegionInfo.Enabled = False


        Dim cls As New clsReader
        Try
            With cls
                .GetRecord("select RegionName,MyRegion,RegionAddress,HeadOfficeAddress,PhoneNo,EmailAddress,website from tblRegionInfo", cn)
                If .EOF = False Then
                    txtRegionName.Text = .ds.Tables(0).Rows(0)("RegionName")
                    txtMyRegion.Text = .ds.Tables(0).Rows(0)("MyRegion")
                    txtRegionAddress.Text = .ds.Tables(0).Rows(0)("RegionAddress")
                    txtPhoneNos.Text = .ds.Tables(0).Rows(0)("PhoneNo")
                    txtEmailAddress.Text = .ds.Tables(0).Rows(0)("EmailAddress")
                    txtHeadOfficeAddress.Text = .ds.Tables(0).Rows(0)("HeadOfficeAddress")
                    txtWebsite.Text = .ds.Tables(0).Rows(0)("Website")

                    ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
                    btnAdd.Visible = False
                Else
                    btnAdd.PerformClick()
                End If

            End With

        Catch ex As Exception

        End Try

        cls = Nothing

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ActionEdit()
    End Sub

    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub
        grpRegionInfo.Enabled = True
        txtRegionName.Focus()
        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub
        txtRegionName.Focus()
        grpRegionInfo.Enabled = True

        ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
        btnDelete.Visible = False
    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave
        If btnSave.Visible = False Then Exit Sub

        If MsgBox("Do you Want to Save the Record", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        If txtRegionName.Text = Nothing Then
            MsgBox("Please Enter Valid Region Name", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim tr As SqlTransaction = cn.BeginTransaction
        Dim cmd As New SqlCommand With {
            .Transaction = tr,
            .Connection = cn,
            .CommandText = "Delete tblRegionInfo insert into tblRegionInfo (RegionName,MyRegion,RegionAddress,HeadOfficeAddress,PhoneNo,EmailAddress,website) Values ('" & txtRegionName.Text & "' , '" & txtMyRegion.Text & "' , '" & txtRegionAddress.Text & "' , '" & txtHeadOfficeAddress.Text & "' , '" & txtPhoneNos.Text & "' , '" & txtEmailAddress.Text & "' , '" & txtWebsite.Text & "')"
        }
        Try
            cmd.ExecuteScalar()
            tr.Commit()
            ZeroPoint()
            MsgBox("Record have been saved")
        Catch ex As Exception
            tr.Rollback()
        End Try
    End Sub

    Public Sub ActionCancel() Implements ICancelBtn.ActionCancel
        If btnCancel.Visible = False Then Exit Sub

        If MsgBox("Do you Want to Cancel the Changes", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub
        ZeroPoint()
    End Sub

    Public Sub ActionDelete() Implements IDeleteBtn.ActionDelete

    End Sub
End Class