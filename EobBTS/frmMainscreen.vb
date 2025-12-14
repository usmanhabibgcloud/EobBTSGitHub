Public Class frmMainscreen

    Private Sub mnuDefEmpDef_Click(sender As Object, e As EventArgs) Handles mnuDefEmpDef.Click
        mdlGeneral.ShowChild(frmEmployeesDef)

    End Sub
    Private Sub mnuActCaseReceived_Click(sender As Object, e As EventArgs) Handles mnuActCaseReceived.Click
        mdlGeneral.ShowChild(frmCaseReceived)
    End Sub
    Private Sub mnuActVerificationReceived_Click(sender As Object, e As EventArgs) Handles mnuActVerificationReceived.Click
        ShowChild(frmVerificationReceived)
    End Sub

    Private Sub mnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click, mnuEdit.Click, mnuSave.Click, mnuCancel.Click, mnuDelete.Click
        If Me.ActiveMdiChild Is Nothing Then Exit Sub
        Try
            Select Case CType(sender, DevComponents.DotNetBar.ButtonItem).Name
                Case "mnuAdd"
                    DirectCast(Me.ActiveMdiChild, IAddBtn).ActionAdd()
                Case "mnuEdit"
                    DirectCast(Me.ActiveMdiChild, IEditBtn).ActionEdit()
                Case "mnuSave"
                    DirectCast(Me.ActiveMdiChild, ISaveBtn).ActionSave()
                Case "mnuDelete"
                    DirectCast(Me.ActiveMdiChild, IDeleteBtn).ActionDelete()
                Case "mnuCancel"
                    DirectCast(Me.ActiveMdiChild, ICancelBtn).ActionCancel()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function MenuVisible(ByVal strName As String) As Boolean
        Dim cls As New clsReader
        cls.GetRecord("Select cast(case when charindex('X',R.Access,1)>0 then 1 else 0 end as bit) as [Access] " &
                    " From tblUserMain M Inner Join tblUserDetail d on m.UserID=D.UserID Inner Join tblRoleDetail R on m.RoleID=R.RoleID " &
                    " where R.mnuCode='" & strName & "' And D.FYID=" & intFYID & " And M.UserID='" & strUser & "'", cn)
        Try
            Return cls.ds.Tables(0).Rows(0)(0)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        If MsgBox("Do you Want to Close the Application", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub



    Private Sub frmMainscreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width

        mnuDefinitions.Visible = MenuVisible("mnuDefinitions")
        mnuDefEmp.Visible = MenuVisible("mnuDefEmp")
        mnuDefEmpJobAssignment.Visible = MenuVisible("mnuDefEmpJobAssignment")
        mnuDefEmpDef.Visible = MenuVisible("mnuDefEmpDef")
        mnuActivities.Visible = MenuVisible("mnuActivities")
        mnuActCases.Visible = MenuVisible("mnuActCases")
        mnuActCaseReceived.Visible = MenuVisible("mnuActCaseReceived")
        mnuActVerificationReceived.Visible = MenuVisible("mnuActVerificationReceived")
        mnuDefGeneral.Visible = MenuVisible("mnuDefGeneral")
        mnuDefGeneralRegInfo.Visible = MenuVisible("mnuDefGeneralRegInfo")
        mnuDefGeneralUsers.Visible = MenuVisible("mnuDefGeneralUsers")
        mnuDefGeneralUserRole.Visible = MenuVisible("mnuDefGeneralUserRole")
        mnuDefGeneralFinancialYear.Visible = MenuVisible("mnuDefGeneralFinancialYear")
        mnuDefGeneralFinancialYear.Visible = MenuVisible("mnuActCaseSettle")
        mnuActORVerification.Visible = MenuVisible("mnuActORVerification")
        mnuActORVerificationReminder.Visible = MenuVisible("mnuActORVerificationReminder")
        mnuActCaseRecommended.Visible = MenuVisible("mnuActCaseRecommended")
        mnuDefGeneralDBBackup.Visible = MenuVisible("mnuDefGeneralDBBackup")
    End Sub

    Private Sub mnuDefGeneralRegInfo_Click(sender As Object, e As EventArgs) Handles mnuDefGeneralRegInfo.Click
        ShowChild(frmRegionInfo)
    End Sub

    Private Sub mnuDefGeneralUsers_Click(sender As Object, e As EventArgs) Handles mnuDefGeneralUsers.Click
        ShowChild(frmUsers)
    End Sub

    Private Sub mnuDefGeneralUserRole_Click(sender As Object, e As EventArgs) Handles mnuDefGeneralUserRole.Click
        ShowChild(frmUserRole)
    End Sub

    Private Sub mnuDefGeneralFinancialYear_Click(sender As Object, e As EventArgs) Handles mnuDefGeneralFinancialYear.Click
        ShowChild(frmYearDef)
    End Sub

    Private Sub mnuRptBTSProcessSheet_Click(sender As Object, e As EventArgs) Handles mnuRptBTSProcessSheet.Click
        frmProcessSheetForm.myTag = "Process Sheet"
        ShowChild(frmProcessSheetForm)
    End Sub

    Private Sub mnuActCaseSettle_Click(sender As Object, e As EventArgs) Handles mnuActCaseSettle.Click
        ShowChild(frmCaseSettle)
    End Sub

    Private Sub mnuActORVerification_Click(sender As Object, e As EventArgs) Handles mnuActORVerification.Click
        ShowChild(frmORVerificationSent)
    End Sub

    Private Sub mnuRptORVerification_Click(sender As Object, e As EventArgs) Handles mnuRptORVerification.Click
        ShowChild(frmORVerificationPrint)
    End Sub

    Private Sub mnuRptClaimCasesReport_Click(sender As Object, e As EventArgs) Handles mnuRptClaimCasesReport.Click
        ShowChild(frmPendingCasesReport)
    End Sub

    Private Sub mnuActCaseRecommended_Click(sender As Object, e As EventArgs) Handles mnuActCaseRecommended.Click
        ShowChild(frmRecommendedByBTS)
    End Sub

    Private Sub mnuRptFIRHistory_Click(sender As Object, e As EventArgs) Handles mnuRptFIRHistory.Click
        frmFIRHistoryPrint.myTag = "FIR History"
        ShowChild(frmFIRHistoryPrint)
    End Sub

    Private Sub mnuDefEmpJobAssignment_Click(sender As Object, e As EventArgs) Handles mnuDefEmpJobAssignment.Click
        ShowChild(frmJobAssignment)
    End Sub

    Private Sub mnuActORVerificationReminder_Click(sender As Object, e As EventArgs) Handles mnuActORVerificationReminder.Click
        ShowChild(frmORverificationReminder)
    End Sub

    Private Sub mnuRptORVeriReminder_Click(sender As Object, e As EventArgs) Handles mnuRptORVeriReminder.Click
        ShowChild(frmORVeriReminderPrint)
    End Sub

    Private Sub mnuActCaseUpdates_Click(sender As Object, e As EventArgs) Handles mnuActCaseUpdates.Click
        ShowChild(frmCaseUpdates)
    End Sub

    Private Sub mnuDefGeneralDBBackup_Click(sender As Object, e As EventArgs) Handles mnuDefGeneralDBBackup.Click
        ShowChild(frmDBBackup)
    End Sub
End Class