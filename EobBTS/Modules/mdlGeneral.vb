
Imports System.Data.Sql
Imports System.Data.SqlClient

Module mdlGeneral
    Public cn As New SqlConnection
    Public strUser As String
    Public strRegionName As String
    Public strMyRegion As String
    Public strHeadOfficeAddress As String
    Public strRegionAddress As String
    Public strPhoneNO As String
    Public strEmailAddress As String


    Public intFYID As Integer

    Public dtStartDate, dtEndDate As Date


    Public Enum ButtonPos
        Add = 0
        Edit = 1
        Save = 2
        Cancel = 3
        Delete = 4
    End Enum

    Public Function AddSerial(ByVal tbl As DataTable)
        tbl.Columns.Add("Sr")
        tbl.Columns("Sr").SetOrdinal(0)
        For i As Integer = 0 To tbl.Rows.Count - 1
            tbl.Rows(i)("Sr") = i + 1
        Next
        Return tbl
    End Function
    Public Function GridColumnSize(ByVal grd As DataGridView, ByVal ArrColSize As Integer())
        'grd.ReadOnly = True
        grd.AllowUserToOrderColumns = False
        grd.AllowUserToResizeColumns = False
        grd.AllowUserToResizeRows = False
        For i As Integer = 0 To UBound(ArrColSize)
            grd.Columns(i).Width = ArrColSize(i)
        Next
        Return grd

    End Function
    Public Sub ButtonPosition(ByVal strBtn As ButtonPos, ByVal bAdd As ToolStripButton, ByVal bEdit As ToolStripButton, ByVal bSave As ToolStripButton, ByVal bCancel As ToolStripButton, ByVal bDelete As ToolStripButton)

        bAdd.Enabled = True
        bEdit.Enabled = True
        bSave.Enabled = True
        bCancel.Enabled = True
        bDelete.Enabled = True



        bCancel.Visible = False
        bDelete.Visible = False
        bEdit.Visible = False
        bAdd.Visible = False
        bSave.Visible = False

        Select Case strBtn

            Case ButtonPos.Cancel

                bAdd.Visible = ButtonVisible(CType(bAdd.Owner.Parent, Form), "A")
                bEdit.Visible = ButtonVisible(CType(bEdit.Owner.Parent, Form), "E")
            Case ButtonPos.Add
                bCancel.Visible = True
                bSave.Visible = True
            Case ButtonPos.Edit
                bDelete.Visible = ButtonVisible(CType(bDelete.Owner.Parent, Form), "D")
                bCancel.Visible = True
                bSave.Visible = True
            Case ButtonPos.Delete
                bAdd.Visible = ButtonVisible(CType(bAdd.Owner.Parent, Form), "A")
                bEdit.Visible = ButtonVisible(CType(bEdit.Owner.Parent, Form), "E")
            Case ButtonPos.Save
                bAdd.Visible = ButtonVisible(CType(bAdd.Owner.Parent, Form), "A")
                bEdit.Visible = ButtonVisible(CType(bEdit.Owner.Parent, Form), "E")
        End Select
    End Sub

    Public Function ButtonVisible(ByVal frm As Form, ByVal strAccess As String) As Boolean
        Dim cls As New clsReader


        'cls.GetRecord("Select cast(case when charindex('" & strAccess & "',Access,1)>0 then 1 else 0 end as bit) as [Access] From tbl_UserDetail d inner join tbl_Menu m on d.mnuCode = m.mnuCode where FYID=" & intFYID & " And UserID='" & strUser & "' and m.AlliedForm = '" & frm.Name & "'", cn)

        cls.GetRecord("Select  cast(case when charindex('" & strAccess & "',rd.Access,1)>0 then 1 else 0 end as bit) as [Access] from tblRoleDetail rd inner join tblUserMain um on rd.RoleID = um.RoleID inner join tblmenu M on M.mnuCode = rd.mnuCode where  um.UserID = '" & strUser & "' and M.AlliedForm = '" & frm.Name & "'", cn)

        Try
            Return cls.ds.Tables(0).Rows(0)(0)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function fnTextToDate(ByVal strDate As String) As String
        If Replace(strDate, " ", "") = "//" Then
            Return String.Empty
            Exit Function
        End If
        Try
            Dim d As String = Strings.Left(strDate, 2)
            Dim m As String = Strings.Mid(strDate, 4, 2)
            Dim y As String = Strings.Right(strDate, 4)
            'Dim myDay As New System.DateTime(y, m, d)


            Dim DD As String = y & "-" & m & "-" & d
            Return DD
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try
    End Function


    Public Function NextVoucher(ByVal strVType As String) As String
        Dim cls As New clsReader
        cls.GetRecord("select dbo.fnNextVoucher('" & mdlGeneral.intFYID & "','" & strVType & "')", cn)
        Return cls.ds.Tables(0).Rows(0)(0).ToString
    End Function
    Public Function NextVoucher(ByVal txtVDate As String, ByVal strVType As String) As String
        Dim cls As New clsReader
        cls.GetRecord("select dbo.fnNextFinancialVoucher('" & txtVDate & "','" & strVType & "')", cn)
        Return cls.ds.Tables(0).Rows(0)(0).ToString
    End Function

    Public Sub fillCombo(ByVal cbo As ComboBox, ByVal strQuery As String)
        'cbo.Items.Clear()
        cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbo.AutoCompleteSource = AutoCompleteSource.ListItems
        cbo.DropDownStyle = ComboBoxStyle.DropDownList
        Dim cls As New clsReader
        cls.GetRecord(strQuery, cn)
        cbo.DataSource = cls.ds.Tables(0).DefaultView
        cbo.DisplayMember = cls.ds.Tables(0).Columns(0).ColumnName
    End Sub

    Public Sub fillCombo(ByVal cbo As ComboBox, ByVal strQuery As String, ByVal IncludeValue As Boolean)
        'cbo.Items.Clear()
        cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbo.AutoCompleteSource = AutoCompleteSource.ListItems
        cbo.DropDownStyle = ComboBoxStyle.DropDownList
        Dim cls As New clsReader
        cls.GetRecord(strQuery, cn)
        cbo.DataSource = cls.ds.Tables(0).DefaultView
        cbo.DisplayMember = cls.ds.Tables(0).Columns(0).ColumnName
        cbo.ValueMember = cls.ds.Tables(0).Columns(1).ColumnName


    End Sub



    Public Sub fillCombo(ByVal cbo As DataGridViewComboBoxColumn, ByVal strQuery As String)

        Dim cls As New clsReader
        cls.GetRecord(strQuery, cn)
        cbo.DataSource = cls.ds.Tables(0).DefaultView
        cbo.DisplayMember = cls.ds.Tables(0).Columns(0).ColumnName

    End Sub

    Public Sub ResizeGridRows(ByVal grd As DataGridView, ByVal strColName As String)
        grd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        grd.Columns(strColName).DefaultCellStyle.WrapMode = DataGridViewTriState.True

    End Sub
    Public Sub ResizeGridRows(ByVal grd As DataGridView, ByVal intColIndex As Integer)
        grd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        grd.Columns(intColIndex).DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
    Public Sub FocusNextControl(ByVal myKey As System.Windows.Forms.Keys)
        If myKey = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub


    Public Sub ShowChild(ByVal frm As Form, Optional ByVal mytab As DevComponents.DotNetBar.TabControl = Nothing)

        frm.MdiParent = frmMainscreen
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Public Function InsertDash(ByVal strCode As String) As String
        Select Case Strings.Len(strCode)
            Case 2
                Return strCode
            Case 4
                Return Left(strCode, 2) & "-" & Right(strCode, 2)
            Case 8
                Return Left(strCode, 2) & "-" & Mid(strCode, 3, 2) & "-" & Right(strCode, 4)
                
            Case Else
                Return Nothing
        End Select
    End Function
    Public Function RemoveDash(ByVal strCode As String) As String
        Return Replace(strCode, "-", "")
    End Function
    Public Function GetAcDesc(ByVal code As String) As String
        Dim cls As New clsReader
        With cls
            .GetRecord("Select AccountDesc from tblCoA where AccountLevel=3 and AccountCode = '" & code & "'", cn)
            If .EOF = False Then
                Return .ds.Tables(0).Rows(0)(0)
            Else
                Return Nothing
            End If
        End With
    End Function

    Public Function GetBudgeHeadDesc(ByVal code As String) As String
        Dim cls As New clsReader
        With cls
            .GetRecord("select BudgetHeadDesc from tblBudgetHeads where BudgetHeadCode = '" & code & "'", cn)
            If .EOF = False Then
                Return .ds.Tables(0).Rows(0)(0)
            Else
                Return Nothing
            End If
        End With
    End Function
    Public Function GetBudgeHeadID(ByVal code As String) As String
        Dim cls As New clsReader
        With cls
            .GetRecord("select BudgetHeadID from tblBudgetHeads where BudgetHeadCode = '" & code & "'", cn)
            If .EOF = False Then
                Return .ds.Tables(0).Rows(0)(0)
            Else
                Return Nothing
            End If
        End With
    End Function
    Public Sub FillSerial(ByVal Dgrid As DataGridView)
        For i As Integer = 0 To Dgrid.RowCount - 1
            Dgrid.Item(0, i).Value = i + 1
        Next
    End Sub
    Public Sub SelectText(ByVal ctl As Control)
        If TypeOf ctl Is TextBox Then

            CType(ctl, TextBox).SelectionStart = 0
            CType(ctl, TextBox).SelectionLength = Len(ctl.Text)
        ElseIf TypeOf ctl Is MaskedTextBox Then

            CType(ctl, MaskedTextBox).SelectionStart = 0
            CType(ctl, MaskedTextBox).SelectionLength = Len(ctl.Text)

        End If
    End Sub

    Public Function fnReportPath(ByVal strReportName As String) As String

        'Dim RepPath As String = "D:\Visual Basic Programs\EobBTS\EobBTS\Reports\" & strReportName

        Dim RepPath As String = System.Windows.Forms.Application.StartupPath + "\Reports\" & strReportName
        If Right(strReportName, 4) = ".rpt" Then
            RepPath = RepPath
        Else
            RepPath = RepPath + ".rpt"
        End If
        Return RepPath

    End Function

End Module

