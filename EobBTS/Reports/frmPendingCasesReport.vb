Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmPendingCasesReport
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If rbCompleteRange.Checked = True And rbPendingCases.Checked = True Then
            AllPendingCases_Report()
        End If
        If rbDateRange.Checked = True And rbPendingCases.Checked = True Then
            PendingCases_Date_Range_Report()
        End If

        If rbCompleteRange.Checked = True And rbPendingCasesExRecom.Checked = True Then
            PendingCases_Excluding_RecommendedCases_Report()
        End If
        If rbDateRange.Checked = True And rbPendingCasesExRecom.Checked = True Then
            PendingCases_Excluding_RecommendedCases_DateRange_Report()
        End If

        If rbCompleteRange.Checked = True And rbPendingCasesWithReason.Checked = True Then
            PendingCases_Exc_Recommended_WithReason()
        End If
        If rbDateRange.Checked = True And rbPendingCasesWithReason.Checked = True Then
            PendingCases_Exc_Recommended_WithReason_DateRange()
        End If

        If rbCompleteRange.Checked = True And rbPendingConverted.Checked = True Then
            PendingConvertedCases_Report()
        End If
        If rbDateRange.Checked = True And rbPendingConverted.Checked = True Then
            PendingConvertedCases_Date_Range_Report()
        End If

        If rbCompleteRange.Checked = True And rbRecommendedNotSet.Checked = True Then
            CasesRecommended_ButNotSettled_Report()
        End If
        If rbDateRange.Checked = True And rbRecommendedNotSet.Checked = True Then
            CasesRecommended_ButNotSettled_DateRange_Report()
        End If


        If rbCompleteRange.Checked = True And rbPendingORVerification.Checked = True Then
            OR_Pending_Cases()
        End If
        If rbDateRange.Checked = True And rbPendingORVerification.Checked = True Then
            OR_Pending_Cases_DateRange()
        End If


        If rbCompleteRange.Checked = True And rbPendingLocalVerification.Checked = True Then
            Local_Pending_Cases()
        End If
        If rbDateRange.Checked = True And rbPendingLocalVerification.Checked = True Then
            Local_Pending_Cases_DateRange()
        End If

        If rbCompleteRange.Checked = True And rbPendigRCC.Checked = True Then
            All_PendingRCC()
        End If
        If rbDateRange.Checked = True And rbPendigRCC.Checked = True Then
            PendingRCC_DateRange()
        End If

        If rbCompleteRange.Checked = True And rbCasesRecommended.Checked = True Then
            CasesRecommended()
        End If
        If rbDateRange.Checked = True And rbCasesRecommended.Checked = True Then
            CasesRecommended_DateRange()
        End If

        If rbCompleteRange.Checked = True And rbFIRRegister.Checked = True Then
            FIR_RegisterComplete()
        End If
        If rbDateRange.Checked = True And rbFIRRegister.Checked = True Then
            FIR_RegisterDateRange()
        End If

    End Sub
    Private Sub AllPendingCases_Report()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_Cases", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crAllPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "All Pending Cases"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PendingCases_Date_Range_Report()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_Cases", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crAllPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "All Pending Cases"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PendingCases_Excluding_RecommendedCases_Report()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_Cases", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myCommand.Parameters.Add("@excludingRecCases", SqlDbType.Bit).Value = 1

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crAllPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "All Pending Cases"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PendingCases_Excluding_RecommendedCases_DateRange_Report()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_Cases", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myCommand.Parameters.Add("@excludingRecCases", SqlDbType.Bit).Value = 1
            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crAllPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "All Pending Cases"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub PendingCases_Exc_Recommended_WithReason()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_Cases_WithReason", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crPendingCasesWithReason.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Pending Cases With Reason"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PendingCases_Exc_Recommended_WithReason_DateRange()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_Cases_WithReason", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crPendingCasesWithReason.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Pending Cases With Reason"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PendingConvertedCases_Report()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_Cases", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            myCommand.Parameters.Add("@ConvertedCase", SqlDbType.Bit).Value = 1


            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crAllPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "All Converted Pending Cases Only"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PendingConvertedCases_Date_Range_Report()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_Cases", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            myCommand.Parameters.Add("@ConvertedCase", SqlDbType.Bit).Value = 1
            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crAllPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Pending Converted Cases"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub CasesRecommended_ButNotSettled_Report()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spCasesRecommended_But_NotSettled", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crCaseRecommendedButNotSettled.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Cases Recommended But Not Settled/ Claim Nuber Not Generated"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub CasesRecommended_ButNotSettled_DateRange_Report()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spCasesRecommended_But_NotSettled", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crCaseRecommendedButNotSettled.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Cases Recommended But Not Settled/ Claim Nuber Not Generated"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub OR_Pending_Cases()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spORPendingVerification", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crORPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Other Region Pending Cross Verification"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OR_Pending_Cases_DateRange()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spORPendingVerification", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crORPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Other Region Pending Cross Verification"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Local_Pending_Cases()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spLocalPendingVerification", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crLocalPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Internal Region Pending  Verifications"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Local_Pending_Cases_DateRange()
        Try
            Cursor = Cursors.WaitCursor
            'Dim myReport As New crMedical_Summary_Sheet
            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spLocalPendingVerification", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crLocalPendingCases.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Internal Region Pending  Verifications"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FIR_RegisterComplete()
        Try
            Cursor = Cursors.WaitCursor

            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("SpFIRRegister", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crFIRRegister.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "FIR Register Complete"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try



    End Sub


    Private Sub FIR_RegisterDateRange()
        Try
            Cursor = Cursors.WaitCursor

            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("SpFIRRegister", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crFIRRegister.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "FIR Register Complete"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub All_PendingRCC()
        Try
            Cursor = Cursors.WaitCursor

            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_RCC", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crPendingRCC.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Pending RCCs"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub PendingRCC_DateRange()
        Try
            Cursor = Cursors.WaitCursor

            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spPending_RCC", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value


            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crPendingRCC.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Pending RCCs"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub CasesRecommended()
        Try
            Cursor = Cursors.WaitCursor

            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spRecommendedCases", cn) With {
                .CommandType = CommandType.StoredProcedure
            }


            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crCasesRecommended.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Cases Recommended"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub CasesRecommended_DateRange()
        Try
            Cursor = Cursors.WaitCursor

            Dim myReport As New ReportDocument
            Dim tbl As New DataTable
            Dim myAdp As New SqlDataAdapter
            Dim myCommand As New SqlCommand("spRecommendedCases", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            myCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = Me.dtDate_From.Value
            myCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = Me.dtDate_To.Value


            myAdp.SelectCommand = myCommand
            myAdp.Fill(tbl)

            myReport.Load(fnReportPath("crCasesRecommended.rpt"))
            myReport.SetDataSource(tbl)
            myReport.SetParameterValue("RegionName", mdlGeneral.strRegionName)
            myReport.SetParameterValue("RegionAddress", mdlGeneral.strRegionAddress)


            frmReports.crView.ReportSource = myReport
            frmReports.crView.Show()
            frmReports.Text = "Cases Recommended"
            frmReports.Show()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmPendingCasesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDate_From.Value = mdlGeneral.dtStartDate
        dtDate_To.Value = mdlGeneral.dtEndDate



    End Sub


End Class