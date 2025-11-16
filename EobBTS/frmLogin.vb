Option Strict Off
Option Explicit On
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmLogin
    Inherits System.Windows.Forms.Form


    Public cmd As New SqlCommand
    Private Sub ButtonActions(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click, btnCancel.Click
        Select Case CType(sender, Button).Name
            Case "btnLogin"
                Try
                    Cursor = Cursors.WaitCursor
                    Dim fileNum As Integer = FreeFile()
                    Dim strDBServer As String = Nothing
                    FileOpen(fileNum, "DBServer.txt", OpenMode.Input)
                    strDBServer = LineInput(fileNum)
                    FileClose(fileNum)
                    'MsgBox(strDBServer)

                    cn.ConnectionString = "server=" & strDBServer & ";database=EobBTS;user=sa;pwd=disaster;Connect Timeout=200; pooling='true'; Max Pool Size=200"


                    cn.Open()

                Catch ex As Exception
                    Cursor = Cursors.Default
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
                Try
                    Dim cls As New clsReader
                    Dim clsCInfo As New clsReader

                    cls.GetRecord("Select * from tblUserMain where enable = 1 And UserID = '" & Me.txtName.Text & "' and userPassword = '" & Me.txtPassword.Text & "'", cn)

                    If cls.EOF = False Then
                        '-------------Getting Regional Information and storing in the Publice Variables----
                        With clsCInfo
                            .GetRecord("select RegionName,MyRegion,RegionAddress,HeadOfficeAddress,PhoneNo,EmailAddress from tblRegionInfo", cn)
                            If .EOF = False Then
                                strRegionName = .ds.Tables(0).Rows(0)("RegionName")
                                strMyRegion = .ds.Tables(0).Rows(0)("MyRegion")
                                strRegionAddress = .ds.Tables(0).Rows(0)("RegionAddress")
                                strHeadOfficeAddress = .ds.Tables(0).Rows(0)("HeadOfficeAddress")
                                strPhoneNO = .ds.Tables(0).Rows(0)("PhoneNo")
                                strEmailAddress = .ds.Tables(0).Rows(0)("EmailAddress")
                            End If
                        End With
                        clsCInfo = Nothing
                        '-------------------------------------------------------------------
                        strUser = txtName.Text
                        frmYearSelect.Show()
                        Cursor = Cursors.Default
                        Me.Close()

                    Else
                        MsgBox("User does not Exist", MsgBoxStyle.OkOnly)
                        cn.Close()
                        Cursor = Cursors.Default
                    End If
                    cls = Nothing
                Catch ex As Exception
                    cn.Close()
                    cn = Nothing
                    Cursor = Cursors.Default
                    MsgBox(ex.Message)
                End Try
            Case "btnCancel"
                Me.Close()
        End Select

    End Sub

    Private Sub txtName_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.Validated
        txtName.Text = txtName.Text.ToUpper
    End Sub

End Class