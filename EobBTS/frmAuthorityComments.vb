Imports Microsoft.VisualBasic.DateAndTime
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Globalization



Public Class frmAuthorityComments
    Implements IAddBtn
    Implements IEditBtn
    Implements ISaveBtn
    Implements ICancelBtn
    Implements IDeleteBtn



    Private EditMode As Boolean = False
    Public intAuthorityID As Long
    Public intFIRID As Long
    Dim TotalVerified As Decimal
    'Private strFIRNo As String
    'Private strClaimantCNIC As String



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ActionSave()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ActionAdd()

    End Sub

    Private Sub grdVoucher_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdVoucher.CellContentClick
        If e.ColumnIndex = grdVoucher.Columns("Del").Index Then

            If grdVoucher.CurrentRow.Index = grdVoucher.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            grdVoucher.Rows.RemoveAt(e.RowIndex)

            FillSerial(grdVoucher)
        End If
        If e.ColumnIndex = grdVoucher.Columns("F1").Index Then
            frmEmployerSearch.blnSingle = False
            frmEmployerSearch.intRIndex = grdVoucher.CurrentRow.Index
            frmEmployerSearch.Destin = frmEmployerSearch.Destination.AuthorityComments
            frmEmployerSearch.ShowDialog()
        End If
    End Sub

    Private Sub grdVoucher_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdVoucher.CellEndEdit
        If e.ColumnIndex = grdVoucher.Columns("EmployerName").Index Then
            If e.RowIndex = CType(sender, DataGridView).RowCount - 1 Then
                grdVoucher.RowCount = CType(sender, DataGridView).RowCount + 1
            End If

            FillSerial(grdVoucher)
        End If
        If e.ColumnIndex = grdVoucher.Columns("VerifiedFrom").Index Then
            CalculateTotal()
        End If
        If e.ColumnIndex = grdVoucher.Columns("VerifiedTo").Index Then
            CalculateTotal()
        End If


    End Sub

    Dim strDate As String

    Private Sub grdVoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdVoucher.KeyDown
        If e.KeyCode = Keys.Delete Then
            If grdVoucher.CurrentRow.Index = grdVoucher.RowCount - 1 Then Exit Sub
            If MsgBox("Do You Want to Delete Row ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            grdVoucher.Rows.RemoveAt(grdVoucher.CurrentRow.Index)

            FillSerial(grdVoucher)
        ElseIf e.KeyCode = Keys.F1 And (grdVoucher.CurrentCell.ColumnIndex = grdVoucher.Columns("F1").Index Or grdVoucher.CurrentCell.ColumnIndex = grdVoucher.Columns("EmployerName").Index) Then

            frmEmployerSearch.blnSingle = False
            frmEmployerSearch.intRIndex = grdVoucher.CurrentRow.Index
            frmEmployerSearch.Destin = frmEmployerSearch.Destination.AuthorityComments
            frmEmployerSearch.ShowDialog()

        End If

    End Sub

    Private Sub ZeroPoint()

        EditMode = False
        grpClaimant.Enabled = False
        btnImportData.Enabled = False
        txtPetitionNo.Text = Nothing
        txtFIRNo.Text = Nothing
        txtClaimantName.Text = Nothing
        txtClaimantRelativeName.Text = Nothing
        txtClaimantCNIC.Text = Nothing
        optMale1.Checked = True
        optFemale1.Checked = False
        txtClaimnatDOB.Text = Nothing
        cboNatureOfBenefit.SelectedIndex = cboNatureOfBenefit.Items.IndexOf("Old Age")
        txtPreviousClaimNo.Text = Nothing
        txtMobileNo.Text = Nothing
        txtAddress.Text = Nothing
        'txtFIRDate.Text = Nothing
        lblTotalVerified.Text = "Zero"


        grpIP.Enabled = False
        txtIPName.Text = Nothing
        txtIPRelativeName.Text = Nothing
        txtIPCNIC.Text = Nothing
        optMale2.Checked = True
        optFemale2.Checked = False
        txtIPDOB.Text = Nothing
        txtEOBINo.Text = Nothing
        txtIPDeathDate.Text = Nothing

        grdVoucher.RowCount = 0
        grdVoucher.Enabled = False

        grpCaseFacts.Enabled = False
        txtBriefFactsofCase.Text = Nothing
        txtPetitionerContention.Text = Nothing
        txtRespondentRebuttal.Text = Nothing
        txtAnyBenefitAwarded.Text = Nothing
        txtMootPoint.Text = Nothing
        txtDecision33.Text = Nothing
        txtDecision34.Text = Nothing
        txtOtherCourtProceed.Text = Nothing

        ButtonPosition(ButtonPos.Cancel, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ActionCancel()
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Do You Want to Close the Form ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Close()
    End Sub

    Private Sub frmAuthorityComments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            txtFIRDate.Text = Format(Today(), "dd/MM/yyyy")
            dtDate.Value = Today()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ZeroPoint()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ActionEdit()

    End Sub

    Public Sub FillVoucher()
        Try
            Dim cls As New clsReader
            cls.GetRecord("SELECT AuthorityID, PetitionNo, CommentsDate, FIRID, FIRNo,FIRDate, ClaimantCNIC, ClaimantName, ClaimantRelative, ClaimantGender, ClaimantDoB, CaseType, PreviousClaimNo, ClaimantMobile, ClaimantAddress, IPName,  IPRelative,  IPCNIC,  IPGender,  EOBINo,  IPDeathDate,  IPDoB,  BreifFacts, PetitionerContention,  RespondantRebuttal,  AnyBenefitAwarded,  MootPoint,  Decision33,  Decision34, OtherCourtProceeeds,  Editable,  VSource,  FYID from tblAuthorityMain where AuthorityID = '" & intAuthorityID & "'  Select AuthorityDetailID,AuthorityID, EmployerCode, EmployerName,  ActApplicability,  ActiveStatus,  PeriodFrom,  PeriodTo,  Remarks1,  VerifiedFrom,VerifiedTo, Remarks2,  RejectionReason,  RegionName,   Beat FROM tblAuthorityDetail where AuthorityID = '" & intAuthorityID & "'", cn)
            txtPetitionNo.Text = cls.ds.Tables(0).Rows(0)("PetitionNo")
            txtFIRNo.Text = cls.ds.Tables(0).Rows(0)("FIRNo")
            txtFIRDate.Text = CType(cls.ds.Tables(0).Rows(0)("FIRDate"), Date).ToString("dd-MM-yyyy")
            dtDate.Value = Convert.ToDateTime(txtFIRDate.Text)
            'MessageBox.Show(cls.ds.Tables(0).Rows(0)("FIRDate").ToString)
            txtClaimantName.Text = cls.ds.Tables(0).Rows(0)("ClaimantName")
            txtClaimantRelativeName.Text = cls.ds.Tables(0).Rows(0)("ClaimantRelative")
            txtClaimantCNIC.Text = cls.ds.Tables(0).Rows(0)("ClaimantCNIC")
            optMale1.Checked = IIf(cls.ds.Tables(0).Rows(0)("ClaimantGender") = "Male", True, False)
            optFemale1.Checked = IIf(cls.ds.Tables(0).Rows(0)("ClaimantGender") = "Female", True, False)
            txtClaimnatDOB.Text = CType(cls.ds.Tables(0).Rows(0)("ClaimantDoB"), Date).ToString("dd-MM-yyyy")
            cboNatureOfBenefit.Text = cls.ds.Tables(0).Rows(0)("CaseType")
            txtPreviousClaimNo.Text = cls.ds.Tables(0).Rows(0)("PreviousClaimNo")
            txtMobileNo.Text = cls.ds.Tables(0).Rows(0)("ClaimantMobile")
            txtAddress.Text = cls.ds.Tables(0).Rows(0)("ClaimantAddress")

            txtIPName.Text = cls.ds.Tables(0).Rows(0)("IPName")
            txtIPRelativeName.Text = cls.ds.Tables(0).Rows(0)("IPRelative")
            txtIPCNIC.Text = cls.ds.Tables(0).Rows(0)("IPCNIC")
            optMale2.Checked = IIf(cls.ds.Tables(0).Rows(0)("IPGender") = "Male", True, False)
            optFemale2.Checked = IIf(cls.ds.Tables(0).Rows(0)("IPGender") = "Female", True, False)
            txtIPDOB.Text = cls.ds.Tables(0).Rows(0)("IPDoB").ToString
            txtEOBINo.Text = cls.ds.Tables(0).Rows(0)("EOBINo")
            txtIPDeathDate.Text = IIf(cls.ds.Tables(0).Rows(0)("IPDeathDate").ToString = "01-01-1900 12:00:00 AM", Nothing, CType(cls.ds.Tables(0).Rows(0)("IPDeathDate"), Date).ToString("dd-MM-yyyy"))
            grpClaimant.Enabled = True
            grpIP.Enabled = True
            grpCaseFacts.Enabled = True

            If txtPreviousClaimNo.Text = Nothing Then
                grdVoucher.Enabled = True
            Else
                grdVoucher.Enabled = False
            End If

            txtBriefFactsofCase.Text = cls.ds.Tables(0).Rows(0)("BreifFacts")
            txtPetitionerContention.Text = cls.ds.Tables(0).Rows(0)("PetitionerContention")
            txtRespondentRebuttal.Text = cls.ds.Tables(0).Rows(0)("RespondantRebuttal")
            txtAnyBenefitAwarded.Text = cls.ds.Tables(0).Rows(0)("AnyBenefitAwarded")
            txtMootPoint.Text = cls.ds.Tables(0).Rows(0)("MootPoint")
            txtDecision33.Text = cls.ds.Tables(0).Rows(0)("Decision33")
            txtDecision34.Text = cls.ds.Tables(0).Rows(0)("Decision34")
            txtOtherCourtProceed.Text = cls.ds.Tables(0).Rows(0)("OtherCourtProceeeds")


            grdVoucher.RowCount = cls.ds.Tables(1).Rows.Count + 1
            For i As Integer = 0 To cls.ds.Tables(1).Rows.Count - 1
                grdVoucher.Item("Sr", i).Value = i + 1
                grdVoucher.Item("AuthorityDetailID", i).Value = cls.ds.Tables(1).Rows(i)("AuthorityDetailID")
                grdVoucher.Item("AuthorityID", i).Value = cls.ds.Tables(1).Rows(i)("AuthorityID")
                grdVoucher.Item("EmployerCode", i).Value = cls.ds.Tables(1).Rows(i)("EmployerCode")
                grdVoucher.Item("EmployerName", i).Value = cls.ds.Tables(1).Rows(i)("EmployerName")
                grdVoucher.Item("ActApplicable", i).Value = CType(cls.ds.Tables(1).Rows(i)("ActApplicability"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("ActiveStatus", i).Value = cls.ds.Tables(1).Rows(i)("ActiveStatus")
                grdVoucher.Item("PeriodFrom", i).Value = CType(cls.ds.Tables(1).Rows(i)("PeriodFrom"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("PeriodTo", i).Value = CType(cls.ds.Tables(1).Rows(i)("PeriodTo"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("Remarks1", i).Value = cls.ds.Tables(1).Rows(i)("Remarks1")
                grdVoucher.Item("VerifiedFrom", i).Value = CType(cls.ds.Tables(1).Rows(i)("VerifiedFrom"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("VerifiedTo", i).Value = CType(cls.ds.Tables(1).Rows(i)("VerifiedTo"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("Remarks2", i).Value = cls.ds.Tables(1).Rows(i)("Remarks2")
                grdVoucher.Item("RejectionReason", i).Value = cls.ds.Tables(1).Rows(i)("RejectionReason")
                grdVoucher.Item("RegionName", i).Value = cls.ds.Tables(1).Rows(i)("RegionName")
                grdVoucher.Item("Beat", i).Value = cls.ds.Tables(1).Rows(i)("Beat")

            Next
            EditMode = True

            txtPetitionNo.Focus()
            ButtonPosition(ButtonPos.Edit, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)
            cls = Nothing
            CalculateTotal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FillVoucher_DataImport()
        Try
            Dim cls As New clsReader
            cls.GetRecord("Select FIRID, FIRNo, FIRDate, ClaimantCNIC, ClaimantName, ClaimantRelative, ClaimantGender, ClaimantDoB, CaseType, PreviousClaimNo, IPName, IPRelative, IPCNIC, IPGender, EOBINo, IPDeathDate, IPDoB from tblFIRMain where FIRID = '" & intFIRID & "'  SELECT ISNULL(RTRIM(FD.EmployerCode), '') AS EmployerCode,ISNULL(E.EmployerName, '') AS EmployerName,ISNULL(E.ApplicabilityDate, CONVERT(date, '0001-01-01')) AS ActApplicability,ISNULL(E.ActiveStatus, '') AS ActiveStatus,FD.PeriodFrom,FD.PeriodTo,ISNULL(VD.VerifiedFrom, CONVERT(date, '0001-01-01')) AS VerifiedFrom,ISNULL(VD.VerifiedTo, CONVERT(date, '0001-01-01')) AS VerifiedTo,ISNULL(E.Region, '') AS RegionName,ISNULL(E.Beat, '') AS Beat FROM tblFIRDetail AS FD LEFT JOIN tblEmployers AS E ON E.EmployerCode = RTRIM(FD.EmployerCode) LEFT JOIN tblVerificationDetail AS VD ON VD.FIRDetailID = FD.FIRDetailID WHERE FD.FIRID = '" & intFIRID & "'", cn)
            txtFIRNo.Text = cls.ds.Tables(0).Rows(0)("FIRNo")
            txtFIRDate.Text = CType(cls.ds.Tables(0).Rows(0)("FIRDate"), Date).ToString("dd-MM-yyyy")
            dtDate.Value = Convert.ToDateTime(txtFIRDate.Text)
            'MessageBox.Show(cls.ds.Tables(0).Rows(0)("FIRDate").ToString)
            txtClaimantName.Text = cls.ds.Tables(0).Rows(0)("ClaimantName")
            txtClaimantRelativeName.Text = cls.ds.Tables(0).Rows(0)("ClaimantRelative")
            txtClaimantCNIC.Text = cls.ds.Tables(0).Rows(0)("ClaimantCNIC")
            optMale1.Checked = IIf(cls.ds.Tables(0).Rows(0)("ClaimantGender") = "Male", True, False)
            optFemale1.Checked = IIf(cls.ds.Tables(0).Rows(0)("ClaimantGender") = "Female", True, False)
            txtClaimnatDOB.Text = CType(cls.ds.Tables(0).Rows(0)("ClaimantDoB"), Date).ToString("dd-MM-yyyy")
            cboNatureOfBenefit.Text = cls.ds.Tables(0).Rows(0)("CaseType")
            txtPreviousClaimNo.Text = cls.ds.Tables(0).Rows(0)("PreviousClaimNo")

            txtIPName.Text = cls.ds.Tables(0).Rows(0)("IPName")
            txtIPRelativeName.Text = cls.ds.Tables(0).Rows(0)("IPRelative")
            txtIPCNIC.Text = cls.ds.Tables(0).Rows(0)("IPCNIC")
            optMale2.Checked = IIf(cls.ds.Tables(0).Rows(0)("IPGender") = "Male", True, False)
            optFemale2.Checked = IIf(cls.ds.Tables(0).Rows(0)("IPGender") = "Female", True, False)
            txtIPDOB.Text = cls.ds.Tables(0).Rows(0)("IPDoB").ToString
            txtEOBINo.Text = cls.ds.Tables(0).Rows(0)("EOBINo")
            txtIPDeathDate.Text = IIf(cls.ds.Tables(0).Rows(0)("IPDeathDate").ToString = "01-01-1900 12:00:00 AM", Nothing, CType(cls.ds.Tables(0).Rows(0)("IPDeathDate"), Date).ToString("dd-MM-yyyy"))
            'grpClaimant.Enabled = True
            'grpIP.Enabled = True
            'grpCaseFacts.Enabled = True

            If txtPreviousClaimNo.Text = Nothing Then
                grdVoucher.Enabled = True
            Else
                grdVoucher.Enabled = False
            End If

            grdVoucher.RowCount = cls.ds.Tables(1).Rows.Count + 1
            For i As Integer = 0 To cls.ds.Tables(1).Rows.Count - 1
                grdVoucher.Item("Sr", i).Value = i + 1
                grdVoucher.Item("EmployerCode", i).Value = cls.ds.Tables(1).Rows(i)("EmployerCode")
                grdVoucher.Item("EmployerName", i).Value = cls.ds.Tables(1).Rows(i)("EmployerName")
                grdVoucher.Item("ActApplicable", i).Value = CType(cls.ds.Tables(1).Rows(i)("ActApplicability"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("ActiveStatus", i).Value = cls.ds.Tables(1).Rows(i)("ActiveStatus")
                grdVoucher.Item("PeriodFrom", i).Value = CType(cls.ds.Tables(1).Rows(i)("PeriodFrom"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("PeriodTo", i).Value = CType(cls.ds.Tables(1).Rows(i)("PeriodTo"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("VerifiedFrom", i).Value = CType(cls.ds.Tables(1).Rows(i)("VerifiedFrom"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("VerifiedTo", i).Value = CType(cls.ds.Tables(1).Rows(i)("VerifiedTo"), Date).ToString("dd-MM-yyyy")
                grdVoucher.Item("RegionName", i).Value = cls.ds.Tables(1).Rows(i)("RegionName")
                grdVoucher.Item("Beat", i).Value = cls.ds.Tables(1).Rows(i)("Beat")

            Next

            txtPetitionNo.Focus()

            cls = Nothing
            btnImportData.Enabled = False
            intFIRID = Nothing
            CalculateTotal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ActionDelete()
    End Sub

    Private Sub grdVoucher_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grdVoucher.RowsAdded
        FillSerial(grdVoucher)

    End Sub

    Public Sub ActionAdd() Implements IAddBtn.ActionAdd
        If btnAdd.Visible = False Then Exit Sub
        ButtonPosition(ButtonPos.Add, btnAdd, btnEdit, btnSave, btnCancel, btnDelete)

        grdVoucher.Enabled = True
        grpClaimant.Enabled = True
        grpIP.Enabled = True
        grpCaseFacts.Enabled = True
        btnSameAbove.Enabled = True
        btnImportData.Enabled = True

        cboNatureOfBenefit.Enabled = True
        txtPetitionNo.Focus()
        grdVoucher.RowCount = 1
        FillSerial(grdVoucher)
        'GetVoucherNo()

    End Sub

    Public Sub ActionEdit() Implements IEditBtn.ActionEdit
        If btnEdit.Visible = False Then Exit Sub

        frmVoucherSearch.myTag = "Authority_Comments"
        frmVoucherSearch.ShowDialog()

    End Sub

    Public Sub ActionSave() Implements ISaveBtn.ActionSave

        If btnSave.Visible = False Then Exit Sub
        Cursor = Cursors.WaitCursor

        '-------------Chacking Savings Constraints--------------------------------
        'If txtFIRNo.Text = Nothing Then
        '    MessageBox.Show("Please Enter FIR/Application Number", "Error")
        '    Cursor = Cursors.Default
        '    Exit Sub
        'End If
        If txtFIRDate.Text = Nothing Then
            MessageBox.Show("Please Enter Valid FIR Date", "Error")
            Cursor = Cursors.Default
            Exit Sub
        End If

        If txtClaimantName.Text = Nothing Then
            MessageBox.Show("Please Enter Claimant Name", "Error")
            Cursor = Cursors.Default
            Exit Sub
        End If
        '------Checking the Claimant CNIC and Gender---------------
        If Len(txtClaimantCNIC.Text) < 15 Then
            MessageBox.Show("Please Enter Valid Claimant CNIC Number", "Error")
            Cursor = Cursors.Default
            Exit Sub
        Else
            Dim lastDigit As Integer = CInt(txtClaimantCNIC.Text.Last().ToString())
            If lastDigit Mod 2 <> 0 Then  '---Checking CNIC Last Digit and Male ... Even for Male
                If optMale1.Checked = False Then
                    MessageBox.Show("Please Select Proper Claimant Gender", "Error")
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            Else
                If optFemale1.Checked = False Then
                    MessageBox.Show("Please Select Proper Claimant Gender", "Error")
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            End If

        End If

        '------Checking the Insured Person CNIC and Gender---------------
        If Len(txtIPCNIC.Text) < 15 Then
            MessageBox.Show("Please Enter Valid IP CNIC Number", "Error")
            Cursor = Cursors.Default
            Exit Sub
        Else
            Dim lastDigit As Integer = CInt(txtIPCNIC.Text.Last().ToString())
            If lastDigit Mod 2 <> 0 Then  '---Checking CNIC Last Digit and Male ... Even for Male
                If optMale2.Checked = False Then
                    MessageBox.Show("Please Select Proper IP Gender", "Error")
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            Else
                If optFemale2.Checked = False Then
                    MessageBox.Show("Please Select Proper IP Gender", "Error")
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            End If

        End If
        '-----------------------------------------------------------------
        If Not (cboNatureOfBenefit.Text = "Old Age") And txtIPDeathDate.Text = "  -  -" Then
            'If Not (cboNatureOfBenefit.Text = "Old Age" Or cboNatureOfBenefit.Text = "Invalidity") And txtIPDeathDate.Text = "  -  -" Then
            MessageBox.Show("Please Enter Valid IP Death/Invalidity Date", "Error")
            Cursor = Cursors.Default
            Exit Sub

        End If

        If (cboNatureOfBenefit.Text = "Old Age") And Not (txtIPDeathDate.Text = "  -  -") Then
            'If (cboNatureOfBenefit.Text = "Old Age" Or cboNatureOfBenefit.Text = "Invalidity") And Not (txtIPDeathDate.Text = "  -  -") Then
            MessageBox.Show("Please Remove Death/Invalidity Date", "Error")
            Cursor = Cursors.Default
            Exit Sub

        End If

        If grdVoucher.RowCount = 1 And Len(txtPreviousClaimNo.Text) < 3 Then
            MessageBox.Show("Please Enter Employment History OR Valid Convered CLAIM No", "Error")
            Cursor = Cursors.Default
            Exit Sub
        End If


        '-------------------------------Converting DataGrid into Data table---------------------


        Dim tblDetail As New DataTable

        tblDetail.Columns.Add("EmployerCode", GetType(String))
        tblDetail.Columns.Add("EmployerName", GetType(String))
        tblDetail.Columns.Add("ActApplicability", GetType(Date))
        tblDetail.Columns.Add("ActiveStatus", GetType(String))
        tblDetail.Columns.Add("PeriodFrom", GetType(Date))
        tblDetail.Columns.Add("PeriodTo", GetType(Date))
        tblDetail.Columns.Add("Remarks1", GetType(String))
        tblDetail.Columns.Add("VerifiedFrom", GetType(Date))
        tblDetail.Columns.Add("VerifiedTo", GetType(Date))
        tblDetail.Columns.Add("Remarks2", GetType(String))
        tblDetail.Columns.Add("RejectionReason", GetType(String))
        tblDetail.Columns.Add("RegionName", GetType(String))
        tblDetail.Columns.Add("Beat", GetType(String))

        Try
            For Each row As DataGridViewRow In grdVoucher.Rows
                If row.Index < grdVoucher.RowCount - 1 Then
                    Dim dr As DataRow = tblDetail.NewRow()  'dr = data row

                    dr("EmployerCode") = If(row.Cells("EmployerCode").Value, "")
                    dr("EmployerName") = row.Cells("EmployerName").Value.ToString()
                    dr("ActApplicability") = row.Cells("ActApplicable").Value.ToString()
                    dr("ActiveStatus") = row.Cells("ActiveStatus").Value.ToString()
                    dr("PeriodFrom") = fnStringDate_to_SqlDate(row.Cells("PeriodFrom").Value)
                    dr("PeriodTo") = fnStringDate_to_SqlDate(row.Cells("PeriodTo").Value)
                    dr("Remarks1") = row.Cells("Remarks1").Value
                    dr("VerifiedFrom") = fnStringDate_to_SqlDate(row.Cells("VerifiedFrom").Value)
                    dr("VerifiedTo") = fnStringDate_to_SqlDate(row.Cells("VerifiedTo").Value)
                    dr("Remarks2") = row.Cells("Remarks2").Value
                    dr("RejectionReason") = row.Cells("RejectionReason").Value
                    dr("RegionName") = If(row.Cells("RegionName").Value, "")
                    dr("Beat") = If(row.Cells("Beat").Value, "")
                    tblDetail.Rows.Add(dr)

                End If
            Next

        Catch ex As Exception
            MsgBox(ex)
            Exit Sub
        End Try
        '---------------------------SAVING MAIN AND DETAIL TABLE-------------------------


        Dim cls As New ClsWriter

        Dim fldNames As String() = New String() {"PetitionNo", "CommentsDate", "FIRID", "FIRNo", "FIRDate", "ClaimantName", "ClaimantRelative", "ClaimantCNIC", "ClaimantGender", "ClaimantDoB", "CaseType", "PreviousClaimNo", "ClaimantMobile", "ClaimantAddress", "IPName", "IPRelative", "IPCNIC", "IPGender", "IPDoB", "EOBINo", "IPDeathDate", "BreifFacts", "PetitionerContention", "RespondantRebuttal", "AnyBenefitAwarded", "MootPoint", "Decision33", "Decision34", "OtherCourtProceeeds", "Editable", "VSource", "PreparedBy", "FYID"}
        Dim fldValues As Object = New Object() {txtPetitionNo.Text, Date.ParseExact(Today, "dd-MM-yyyy", Nothing), intFIRID, txtFIRNo.Text, Date.ParseExact(txtFIRDate.Text, "dd-MM-yyyy", Nothing),
                txtClaimantName.Text, txtClaimantRelativeName.Text, txtClaimantCNIC.Text,
                IIf(Me.optMale1.Checked = True, "Male", "Female"), Date.ParseExact(txtClaimnatDOB.Text, "dd-MM-yyyy", Nothing),
                cboNatureOfBenefit.Text, txtPreviousClaimNo.Text, txtMobileNo.Text, txtAddress.Text,
                txtIPName.Text, txtIPRelativeName.Text, txtIPCNIC.Text,
                IIf(Me.optMale2.Checked = True, "Male", "Female"), Date.ParseExact(txtIPDOB.Text, "dd-MM-yyyy", Nothing),
                txtEOBINo.Text, If(txtIPDeathDate.MaskCompleted, Date.ParseExact(txtIPDeathDate.Text, "dd-MM-yyyy", Nothing), New Date(1900, 1, 1)),
                txtBriefFactsofCase.Text, txtPetitionerContention.Text, txtRespondentRebuttal.Text, txtAnyBenefitAwarded.Text, txtMootPoint.Text, txtDecision33.Text, txtDecision34.Text, txtOtherCourtProceed.Text,
                1, "SELF", strUser, intFYID}

        If EditMode = False Then GoTo AddMode
        If EditMode = True Then GoTo EditMode
AddMode:
        Try

            cls.AddRecord_U(tblDetail, cn, "tblAuthorityDetail", "tblAuthorityMain", "AuthorityID", fldNames, fldValues)

            cls = Nothing
            ZeroPoint()
            Cursor = Cursors.Default
            Exit Sub
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
EditMode:
        Try

            cls.UpdateRecord_U(tblDetail, cn, "tblAuthorityDetail", "tblAuthorityMain", "AuthorityID", fldNames, fldValues, intAuthorityID)
            cls = Nothing
            ZeroPoint()
            Cursor = Cursors.Default
            Exit Sub
        Catch ex As Exception
            Cursor = Cursors.Default
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
        If MessageBox.Show("Are you Want to Delete The Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then Exit Sub
        Dim cls As New ClsWriter
        cls.DeleteRecord_U("tblAuthorityMain", "tblAuthorityDetail", "AuthorityID", intAuthorityID, cn)
        cls = Nothing
        ZeroPoint()


    End Sub

    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFIRDate.GotFocus
        SelectText(sender)
    End Sub



    Private Sub txtFIRVDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFIRDate.Validating
        Try
            dtDate.Value = Convert.ToDateTime(txtFIRDate.Text)
            If Not (dtDate.Value >= dtStartDate And dtDate.Value <= dtEndDate) Then

                MsgBox("Please Enter Date Between " & dtStartDate & " And " & dtEndDate)
                txtFIRDate.Focus()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtFIRDate.Focus()
        End Try


    End Sub

    Private Sub txtClaimantDOB_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtClaimnatDOB.Validating
        Dim dt1 As New DateTimePicker
        Try
            dt1.Value = Convert.ToDateTime(txtClaimnatDOB.Text)
        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtClaimnatDOB.Focus()
        End Try
    End Sub

    Private Sub txtIPDOB_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIPDOB.Validating
        Dim dt1 As New DateTimePicker
        Try
            dt1.Value = Convert.ToDateTime(txtIPDOB.Text)
        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtIPDOB.Focus()
        End Try
    End Sub

    Private Sub txtIPDeathDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIPDeathDate.Validating
        If txtIPDeathDate.Text = "  -  -" Then Exit Sub
        Dim dt1 As New DateTimePicker
        Try
            dt1.Value = Convert.ToDateTime(txtIPDeathDate.Text)
        Catch ex As Exception
            MsgBox("Please Enter Valid Date", MsgBoxStyle.OkOnly)
            txtIPDeathDate.Focus()
        End Try
    End Sub

    Private Sub grdVoucher_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdVoucher.CellValidating
        Dim dt7 As Date
        Dim dt8 As Date

        If e.ColumnIndex = grdVoucher.Columns("PeriodFrom").Index Then
            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt7) Then
                MessageBox.Show("Enter correct Date")

                e.Cancel = True
                Exit Sub

            End If
            grdVoucher.Item("PeriodFrom", e.RowIndex).Value = Format(dt7, "dd-MM-yyyy")

        End If
        If e.ColumnIndex = grdVoucher.Columns("PeriodTo").Index Then
            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt8) Then
                MessageBox.Show("Enter correct Date")
                e.Cancel = True
                Exit Sub

            End If
            grdVoucher.Item("PeriodTo", e.RowIndex).Value = Format(dt8, "dd-MM-yyyy")

        End If

        Dim dt9 As Date
        Dim dt10 As Date

        If e.ColumnIndex = grdVoucher.Columns("VerifiedFrom").Index Then
            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt9) Then
                MessageBox.Show("Enter correct Date")

                e.Cancel = True
                Exit Sub

            End If
            grdVoucher.Item("VerifiedFrom", e.RowIndex).Value = Format(dt9, "dd-MM-yyyy")

        End If
        If e.ColumnIndex = grdVoucher.Columns("VerifiedTo").Index Then
            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt10) Then
                MessageBox.Show("Enter correct Date")
                e.Cancel = True
                Exit Sub

            End If
            grdVoucher.Item("VerifiedTo", e.RowIndex).Value = Format(dt10, "dd-MM-yyyy")

        End If
    End Sub

    Private Sub btnSameAbove_Click(sender As Object, e As EventArgs) Handles btnSameAbove.Click
        txtIPName.Text = txtClaimantName.Text
        txtIPRelativeName.Text = txtClaimantRelativeName.Text
        txtIPCNIC.Text = txtClaimantCNIC.Text
        optMale2.Checked = optMale1.Checked
        optFemale2.Checked = optFemale1.Checked
        txtIPDOB.Text = txtClaimnatDOB.Text

    End Sub

    Private Sub txtPreviousClaimNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPreviousClaimNo.KeyUp
        If Me.txtPreviousClaimNo.Text = Nothing Then
            grdVoucher.Enabled = True
        Else
            grdVoucher.Enabled = False
            grdVoucher.RowCount = 0
            grdVoucher.RowCount = 1
        End If
    End Sub

    'Private Sub txtFIRNo_Validating(sender As Object, e As CancelEventArgs) Handles txtFIRNo.Validating
    '    Dim cls As New clsReader
    '    If EditMode = True And strFIRNo = txtFIRNo.Text Then Exit Sub
    '    cls.GetRecord("select FIRNo from tblFIRMain where FIRNo = '" & txtFIRNo.Text & "'", cn)
    '    If cls.EOF = False Then
    '        MessageBox.Show("This FIR/Case Number Already Exists, Please Enter Other FIR No", "ERROR", MessageBoxButtons.OK)
    '        txtFIRNo.Focus()
    '    End If
    'End Sub

    'Private Sub txtClaimantCNIC_Validating(sender As Object, e As CancelEventArgs) Handles txtClaimantCNIC.Validating
    '    Dim cls As New clsReader
    '    If EditMode = True And strClaimantCNIC = txtClaimantCNIC.Text Then Exit Sub
    '    cls.GetRecord("select ClaimantCNIC from tblFIRMain where ClaimantCNIC = '" & txtClaimantCNIC.Text & "'", cn)
    '    If cls.EOF = False Then
    '        MessageBox.Show("This CNIC Number Already Exists, Please Enter Other CNIC Number", "ERROR", MessageBoxButtons.OK)
    '        txtClaimantCNIC.Focus()
    '    End If
    'End Sub
    Private Sub cboNatureOfBenefit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNatureOfBenefit.SelectedIndexChanged
        If (cboNatureOfBenefit.Text = "Old Age" Or cboNatureOfBenefit.Text = "Invalidity") Then
            txtPreviousClaimNo.Enabled = False
            txtPreviousClaimNo.Text = Nothing
            grdVoucher.Enabled = True
        Else
            txtPreviousClaimNo.Enabled = True
        End If
    End Sub


    Private Sub CalculateTotal()
        Try

            Dim bd As Date = New Date(1983, 6, 30)
            TotalVerified = 0
            Dim tblVerifiedPeriod As New DataTable
            Dim strColumns As String() = New String() {"DateFrom", "DateTo", "BeforeDays", "AfterDays", "BeforeYears", "AfterYears", "TotalYears"}

            For i As Integer = 0 To UBound(strColumns)
                tblVerifiedPeriod.Columns.Add(strColumns(i).ToString)
            Next
            For i As Integer = 0 To grdVoucher.RowCount - 2
                tblVerifiedPeriod.Rows.Add()
                tblVerifiedPeriod.Rows(i)("DateFrom") = IIf((grdVoucher.Item("VerifiedFrom", i).Value = Nothing Or grdVoucher.Item("VerifiedFrom", i).Value = "01-01-0001"), "01-01-1900", grdVoucher.Item("VerifiedFrom", i).Value)
                tblVerifiedPeriod.Rows(i)("DateTo") = IIf((grdVoucher.Item("VerifiedTo", i).Value = Nothing Or grdVoucher.Item("VerifiedTo", i).Value = "01-01-0001"), "01-01-1900", grdVoucher.Item("VerifiedTo", i).Value)
                Dim dt5 As Date = CType(tblVerifiedPeriod.Rows(i)("DateFrom"), Date)
                Dim dt6 As Date = CType(tblVerifiedPeriod.Rows(i)("DateTo"), Date)

                Dim md As Date
                If dt6 < bd Then
                    md = dt6
                Else
                    md = bd
                End If

                tblVerifiedPeriod.Rows(i)("BeforeDays") = IIf(dt5 <= bd And Not (dt5 = New Date(1900, 1, 1)), DateDiff(DateInterval.Day, dt5, md) + 1, 0)

                tblVerifiedPeriod.Rows(i)("AfterDays") = DateDiff(DateInterval.Day, dt5, dt6) - (tblVerifiedPeriod.Rows(i)("BeforeDays")) + IIf((dt5 = New Date(1900, 1, 1)), 0, 1)
                tblVerifiedPeriod.Rows(i)("BeforeYears") = CType((tblVerifiedPeriod.Rows(i)("BeforeDays")) / 312, Decimal)
                tblVerifiedPeriod.Rows(i)("AfterYears") = CType((tblVerifiedPeriod.Rows(i)("AfterDays")) / 365, Decimal)
                tblVerifiedPeriod.Rows(i)("TotalYears") = CType(tblVerifiedPeriod.Rows(i)("BeforeYears"), Decimal) + CType(tblVerifiedPeriod.Rows(i)("AfterYears"), Decimal)
                TotalVerified = TotalVerified + CType(tblVerifiedPeriod.Rows(i)("TotalYears"), Decimal)
            Next
            lblTotalVerified.Text = Format(TotalVerified, "#,###.##")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnImportData_Click(sender As Object, e As EventArgs) Handles btnImportData.Click
        frmVoucherSearch.myTag = "Authority_Comments_ImportData"
        frmVoucherSearch.ShowDialog()
    End Sub

    Private Sub btnBriefFacts_Click(sender As Object, e As EventArgs) Handles btnBriefFacts.Click
        txtBriefFactsofCase.Text = Nothing
        txtPetitionerContention.Text = Nothing
        txtRespondentRebuttal.Text = Nothing
        txtAnyBenefitAwarded.Text = Nothing
        txtMootPoint.Text = Nothing
        txtDecision33.Text = Nothing
        txtDecision34.Text = Nothing
        txtOtherCourtProceed.Text = Nothing

        CalculateTotal()

        Select Case cboNatureOfBenefit.Text
            Case "Old Age"
                txtBriefFactsofCase.Text = "The claimant applied for old age pension but due to less than 15 years of verified insurable employment, the case is rejected for pension"
                txtPetitionerContention.Text = "To award Old Age Pension to the petitioner"
                txtRespondentRebuttal.Text = "The Claimant is not entitled for old age pension because verified insurable employemnt is " & Math.Round(TotalVerified, 2) & " Years only"
                txtAnyBenefitAwarded.Text = "An old age grant has been awarded to the petitioner"
            Case "Survivor"
                txtBriefFactsofCase.Text = "The claimant applied for Survivor pension but due to less than 5 years of verified insurable employment, the case is rejected for pension"
                txtPetitionerContention.Text = "To award Survivor Pension to the petitioner"
                txtRespondentRebuttal.Text = "The Claimant is not entitled for Survivor pension because verified insurable employemnt is " & Math.Round(TotalVerified, 2) & " Years only"
            Case "Minor Child"
                txtBriefFactsofCase.Text = "The claimant applied for Minor Child pension but due to less than 5 years of verified insurable employment, the case is rejected for pension"
                txtPetitionerContention.Text = "To award Old Age Pension to the petitioner"
                txtRespondentRebuttal.Text = "The Claimant is not entitled for Minor pension because verified insurable employemnt is " & Math.Round(TotalVerified, 2) & " Years only"
            Case "Estate Pension"

                txtBriefFactsofCase.Text = "The claimant applied for Estate pension but due to less than 5 years of verified insurable employment, the case is rejected for pension"
                txtPetitionerContention.Text = "To provide Estate Pension to the petitioner"
                txtRespondentRebuttal.Text = "The Claimant is not entitled for Estate pension because verified insurable employemnt is " & Math.Round(TotalVerified, 2) & " Years only"

            Case "Invalidity"
                txtBriefFactsofCase.Text = "The claimant applied for Invalidity pension but due to less than 15 years of verified insurable employment, the case is rejected for pension"
                txtPetitionerContention.Text = "To award Invalidity Pension to the Claimant"
                txtRespondentRebuttal.Text = "The Claimant is not entitled for Invalidity pension because verified insurable employemnt is " & Math.Round(TotalVerified, 2) & " Years only"
        End Select

    End Sub
End Class