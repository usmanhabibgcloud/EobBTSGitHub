<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainscreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainscreen))
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.mnuDefGeneral = New DevComponents.DotNetBar.RibbonBar()
        Me.mnuDefGeneralRegInfo = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuDefGeneralUsers = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuDefGeneralUserRole = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuDefGeneralFinancialYear = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuDefGeneralDBBackup = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuDefEmp = New DevComponents.DotNetBar.RibbonBar()
        Me.mnuDefEmpDef = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuDefEmpJobAssignment = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.mnuRptBTS = New DevComponents.DotNetBar.RibbonBar()
        Me.mnuRptFIRHistory = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuRptBTSProcessSheet = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.mnuRptORVerification = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuRptORVeriReminder = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.mnuRptClaimCasesReport = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuRptEmp = New DevComponents.DotNetBar.RibbonBar()
        Me.mnuRptEmpRegionEmployees = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.mnuActCases = New DevComponents.DotNetBar.RibbonBar()
        Me.mnuActCaseReceived = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuActVerificationReceived = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuActCaseRecommended = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuActCaseSettle = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer5 = New DevComponents.DotNetBar.ItemContainer()
        Me.mnuActORVerification = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuActORVerificationReminder = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuActCaseUpdates = New DevComponents.DotNetBar.ButtonItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.mnuDefinitions = New DevComponents.DotNetBar.RibbonTabItem()
        Me.mnuActivities = New DevComponents.DotNetBar.RibbonTabItem()
        Me.mnuReports = New DevComponents.DotNetBar.RibbonTabItem()
        Me.Office2007StartButton1 = New DevComponents.DotNetBar.Office2007StartButton()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.mnuAdd = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuEdit = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuSave = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuCancel = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.mnuExit = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.striplblSystem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.striplblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.RibbonPanel3.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel3)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.Images = Me.ImageList1
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuDefinitions, Me.mnuActivities, Me.mnuReports})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Office2007StartButton1, Me.ButtonItem1, Me.QatCustomizeItem1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1211, 190)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 1
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonPanel1.Controls.Add(Me.mnuDefGeneral)
        Me.RibbonPanel1.Controls.Add(Me.mnuDefEmp)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 55)
        Me.RibbonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.RibbonPanel1.Size = New System.Drawing.Size(1211, 133)
        Me.RibbonPanel1.TabIndex = 1
        '
        'mnuDefGeneral
        '
        Me.mnuDefGeneral.AutoOverflowEnabled = True
        Me.mnuDefGeneral.Dock = System.Windows.Forms.DockStyle.Left
        Me.mnuDefGeneral.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuDefGeneralRegInfo, Me.mnuDefGeneralUsers, Me.mnuDefGeneralUserRole, Me.mnuDefGeneralFinancialYear, Me.mnuDefGeneralDBBackup})
        Me.mnuDefGeneral.Location = New System.Drawing.Point(201, 0)
        Me.mnuDefGeneral.Margin = New System.Windows.Forms.Padding(4)
        Me.mnuDefGeneral.Name = "mnuDefGeneral"
        Me.mnuDefGeneral.Size = New System.Drawing.Size(402, 129)
        Me.mnuDefGeneral.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.mnuDefGeneral.TabIndex = 2
        Me.mnuDefGeneral.Text = "General"
        '
        'mnuDefGeneralRegInfo
        '
        Me.mnuDefGeneralRegInfo.Image = Global.EobBTS.My.Resources.Resources.Region_Info
        Me.mnuDefGeneralRegInfo.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuDefGeneralRegInfo.ImagePaddingHorizontal = 8
        Me.mnuDefGeneralRegInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuDefGeneralRegInfo.Name = "mnuDefGeneralRegInfo"
        Me.mnuDefGeneralRegInfo.SubItemsExpandWidth = 14
        Me.mnuDefGeneralRegInfo.Text = "   Region" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Information"
        '
        'mnuDefGeneralUsers
        '
        Me.mnuDefGeneralUsers.Image = Global.EobBTS.My.Resources.Resources._1396
        Me.mnuDefGeneralUsers.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuDefGeneralUsers.ImagePaddingHorizontal = 8
        Me.mnuDefGeneralUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuDefGeneralUsers.Name = "mnuDefGeneralUsers"
        Me.mnuDefGeneralUsers.SubItemsExpandWidth = 14
        Me.mnuDefGeneralUsers.Text = "Users"
        '
        'mnuDefGeneralUserRole
        '
        Me.mnuDefGeneralUserRole.Image = Global.EobBTS.My.Resources.Resources.User_Roles
        Me.mnuDefGeneralUserRole.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuDefGeneralUserRole.ImagePaddingHorizontal = 8
        Me.mnuDefGeneralUserRole.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuDefGeneralUserRole.Name = "mnuDefGeneralUserRole"
        Me.mnuDefGeneralUserRole.SubItemsExpandWidth = 14
        Me.mnuDefGeneralUserRole.Text = "User Role"
        '
        'mnuDefGeneralFinancialYear
        '
        Me.mnuDefGeneralFinancialYear.Image = Global.EobBTS.My.Resources.Resources.Year
        Me.mnuDefGeneralFinancialYear.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuDefGeneralFinancialYear.ImagePaddingHorizontal = 8
        Me.mnuDefGeneralFinancialYear.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuDefGeneralFinancialYear.Name = "mnuDefGeneralFinancialYear"
        Me.mnuDefGeneralFinancialYear.SubItemsExpandWidth = 14
        Me.mnuDefGeneralFinancialYear.Text = "Financial Year"
        '
        'mnuDefGeneralDBBackup
        '
        Me.mnuDefGeneralDBBackup.Image = Global.EobBTS.My.Resources.Resources.backupDB_to_NAS
        Me.mnuDefGeneralDBBackup.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuDefGeneralDBBackup.ImagePaddingHorizontal = 8
        Me.mnuDefGeneralDBBackup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuDefGeneralDBBackup.Name = "mnuDefGeneralDBBackup"
        Me.mnuDefGeneralDBBackup.SubItemsExpandWidth = 14
        Me.mnuDefGeneralDBBackup.Text = "Database" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Backup"
        '
        'mnuDefEmp
        '
        Me.mnuDefEmp.AutoOverflowEnabled = True
        Me.mnuDefEmp.Dock = System.Windows.Forms.DockStyle.Left
        Me.mnuDefEmp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuDefEmpDef, Me.mnuDefEmpJobAssignment})
        Me.mnuDefEmp.Location = New System.Drawing.Point(4, 0)
        Me.mnuDefEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.mnuDefEmp.Name = "mnuDefEmp"
        Me.mnuDefEmp.Size = New System.Drawing.Size(197, 129)
        Me.mnuDefEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.mnuDefEmp.TabIndex = 0
        Me.mnuDefEmp.Text = "Employees"
        '
        'mnuDefEmpDef
        '
        Me.mnuDefEmpDef.Image = Global.EobBTS.My.Resources.Resources._1277
        Me.mnuDefEmpDef.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuDefEmpDef.ImagePaddingHorizontal = 8
        Me.mnuDefEmpDef.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuDefEmpDef.Name = "mnuDefEmpDef"
        Me.mnuDefEmpDef.SubItemsExpandWidth = 14
        Me.mnuDefEmpDef.Text = "Employee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Definition"
        '
        'mnuDefEmpJobAssignment
        '
        Me.mnuDefEmpJobAssignment.Image = Global.EobBTS.My.Resources.Resources.Job_Assignment
        Me.mnuDefEmpJobAssignment.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuDefEmpJobAssignment.ImagePaddingHorizontal = 8
        Me.mnuDefEmpJobAssignment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuDefEmpJobAssignment.Name = "mnuDefEmpJobAssignment"
        Me.mnuDefEmpJobAssignment.SubItemsExpandWidth = 14
        Me.mnuDefEmpJobAssignment.Text = " Job" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Assignment"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonPanel3.Controls.Add(Me.mnuRptBTS)
        Me.RibbonPanel3.Controls.Add(Me.mnuRptEmp)
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.RibbonPanel3.Size = New System.Drawing.Size(1211, 188)
        Me.RibbonPanel3.TabIndex = 3
        Me.RibbonPanel3.Visible = False
        '
        'mnuRptBTS
        '
        Me.mnuRptBTS.AutoOverflowEnabled = True
        Me.mnuRptBTS.Dock = System.Windows.Forms.DockStyle.Left
        Me.mnuRptBTS.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuRptFIRHistory, Me.mnuRptBTSProcessSheet, Me.LabelItem2, Me.mnuRptORVerification, Me.mnuRptORVeriReminder, Me.LabelItem1, Me.mnuRptClaimCasesReport})
        Me.mnuRptBTS.Location = New System.Drawing.Point(137, 0)
        Me.mnuRptBTS.Margin = New System.Windows.Forms.Padding(4)
        Me.mnuRptBTS.Name = "mnuRptBTS"
        Me.mnuRptBTS.Size = New System.Drawing.Size(503, 184)
        Me.mnuRptBTS.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.mnuRptBTS.TabIndex = 1
        '
        'mnuRptFIRHistory
        '
        Me.mnuRptFIRHistory.Image = Global.EobBTS.My.Resources.Resources.MedicalReportHo
        Me.mnuRptFIRHistory.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuRptFIRHistory.ImagePaddingHorizontal = 8
        Me.mnuRptFIRHistory.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuRptFIRHistory.Name = "mnuRptFIRHistory"
        Me.mnuRptFIRHistory.SubItemsExpandWidth = 14
        Me.mnuRptFIRHistory.Text = "Case History"
        '
        'mnuRptBTSProcessSheet
        '
        Me.mnuRptBTSProcessSheet.Image = Global.EobBTS.My.Resources.Resources.VoucherReport
        Me.mnuRptBTSProcessSheet.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuRptBTSProcessSheet.ImagePaddingHorizontal = 8
        Me.mnuRptBTSProcessSheet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuRptBTSProcessSheet.Name = "mnuRptBTSProcessSheet"
        Me.mnuRptBTSProcessSheet.SubItemsExpandWidth = 14
        Me.mnuRptBTSProcessSheet.Text = "Process Sheet"
        '
        'LabelItem2
        '
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "    "
        '
        'mnuRptORVerification
        '
        Me.mnuRptORVerification.Image = Global.EobBTS.My.Resources.Resources.AnnextA_Icon
        Me.mnuRptORVerification.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuRptORVerification.ImagePaddingHorizontal = 8
        Me.mnuRptORVerification.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuRptORVerification.Name = "mnuRptORVerification"
        Me.mnuRptORVerification.SubItemsExpandWidth = 14
        Me.mnuRptORVerification.Text = "Other Region" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Verification"
        '
        'mnuRptORVeriReminder
        '
        Me.mnuRptORVeriReminder.ForeColor = System.Drawing.Color.Red
        Me.mnuRptORVeriReminder.Image = Global.EobBTS.My.Resources.Resources.AnnextA_Icon
        Me.mnuRptORVeriReminder.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuRptORVeriReminder.ImagePaddingHorizontal = 8
        Me.mnuRptORVeriReminder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuRptORVeriReminder.Name = "mnuRptORVeriReminder"
        Me.mnuRptORVeriReminder.SubItemsExpandWidth = 14
        Me.mnuRptORVeriReminder.Text = "OR Verification" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reminder"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "    "
        '
        'mnuRptClaimCasesReport
        '
        Me.mnuRptClaimCasesReport.Image = Global.EobBTS.My.Resources.Resources.tune_up_v2__3D
        Me.mnuRptClaimCasesReport.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuRptClaimCasesReport.ImagePaddingHorizontal = 8
        Me.mnuRptClaimCasesReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuRptClaimCasesReport.Name = "mnuRptClaimCasesReport"
        Me.mnuRptClaimCasesReport.SubItemsExpandWidth = 14
        Me.mnuRptClaimCasesReport.Text = "Claim Cases" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Reports"
        '
        'mnuRptEmp
        '
        Me.mnuRptEmp.AutoOverflowEnabled = True
        Me.mnuRptEmp.Dock = System.Windows.Forms.DockStyle.Left
        Me.mnuRptEmp.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuRptEmpRegionEmployees})
        Me.mnuRptEmp.Location = New System.Drawing.Point(4, 0)
        Me.mnuRptEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.mnuRptEmp.Name = "mnuRptEmp"
        Me.mnuRptEmp.Size = New System.Drawing.Size(133, 184)
        Me.mnuRptEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.mnuRptEmp.TabIndex = 0
        Me.mnuRptEmp.Text = "Employees"
        '
        'mnuRptEmpRegionEmployees
        '
        Me.mnuRptEmpRegionEmployees.Image = Global.EobBTS.My.Resources.Resources._1277
        Me.mnuRptEmpRegionEmployees.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuRptEmpRegionEmployees.ImagePaddingHorizontal = 8
        Me.mnuRptEmpRegionEmployees.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuRptEmpRegionEmployees.Name = "mnuRptEmpRegionEmployees"
        Me.mnuRptEmpRegionEmployees.SubItemsExpandWidth = 14
        Me.mnuRptEmpRegionEmployees.Text = "Region" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Employees"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonPanel2.Controls.Add(Me.mnuActCases)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 55)
        Me.RibbonPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.RibbonPanel2.Size = New System.Drawing.Size(1211, 133)
        Me.RibbonPanel2.TabIndex = 2
        Me.RibbonPanel2.Visible = False
        '
        'mnuActCases
        '
        Me.mnuActCases.AutoOverflowEnabled = True
        Me.mnuActCases.Dock = System.Windows.Forms.DockStyle.Left
        Me.mnuActCases.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuActCaseReceived, Me.mnuActVerificationReceived, Me.mnuActCaseRecommended, Me.mnuActCaseSettle, Me.ItemContainer5, Me.mnuActORVerification, Me.mnuActORVerificationReminder, Me.mnuActCaseUpdates})
        Me.mnuActCases.Location = New System.Drawing.Point(4, 0)
        Me.mnuActCases.Margin = New System.Windows.Forms.Padding(4)
        Me.mnuActCases.Name = "mnuActCases"
        Me.mnuActCases.Size = New System.Drawing.Size(661, 129)
        Me.mnuActCases.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.mnuActCases.TabIndex = 1
        Me.mnuActCases.Text = "Claim Cases"
        '
        'mnuActCaseReceived
        '
        Me.mnuActCaseReceived.Image = Global.EobBTS.My.Resources.Resources.Receipt_Voucher
        Me.mnuActCaseReceived.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuActCaseReceived.ImagePaddingHorizontal = 8
        Me.mnuActCaseReceived.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuActCaseReceived.Name = "mnuActCaseReceived"
        Me.mnuActCaseReceived.SubItemsExpandWidth = 14
        Me.mnuActCaseReceived.Text = "    FIR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Case Receive"
        '
        'mnuActVerificationReceived
        '
        Me.mnuActVerificationReceived.Image = Global.EobBTS.My.Resources.Resources.Script_Editor
        Me.mnuActVerificationReceived.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuActVerificationReceived.ImagePaddingHorizontal = 8
        Me.mnuActVerificationReceived.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuActVerificationReceived.Name = "mnuActVerificationReceived"
        Me.mnuActVerificationReceived.SubItemsExpandWidth = 14
        Me.mnuActVerificationReceived.Text = "Verification " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Received"
        '
        'mnuActCaseRecommended
        '
        Me.mnuActCaseRecommended.Image = Global.EobBTS.My.Resources.Resources.Opening_Balance
        Me.mnuActCaseRecommended.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuActCaseRecommended.ImagePaddingHorizontal = 8
        Me.mnuActCaseRecommended.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuActCaseRecommended.Name = "mnuActCaseRecommended"
        Me.mnuActCaseRecommended.SubItemsExpandWidth = 14
        Me.mnuActCaseRecommended.Text = "Case" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recommended"
        '
        'mnuActCaseSettle
        '
        Me.mnuActCaseSettle.Image = Global.EobBTS.My.Resources.Resources.dossier_partage_3D
        Me.mnuActCaseSettle.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuActCaseSettle.ImagePaddingHorizontal = 8
        Me.mnuActCaseSettle.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuActCaseSettle.Name = "mnuActCaseSettle"
        Me.mnuActCaseSettle.SubItemsExpandWidth = 14
        Me.mnuActCaseSettle.Text = "Case" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Settle"
        '
        'ItemContainer5
        '
        Me.ItemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer5.Name = "ItemContainer5"
        '
        'mnuActORVerification
        '
        Me.mnuActORVerification.Image = Global.EobBTS.My.Resources.Resources.designer_3D
        Me.mnuActORVerification.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuActORVerification.ImagePaddingHorizontal = 8
        Me.mnuActORVerification.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuActORVerification.Name = "mnuActORVerification"
        Me.mnuActORVerification.SubItemsExpandWidth = 14
        Me.mnuActORVerification.Text = "Other Region" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Verification"
        '
        'mnuActORVerificationReminder
        '
        Me.mnuActORVerificationReminder.ForeColor = System.Drawing.Color.Red
        Me.mnuActORVerificationReminder.Image = Global.EobBTS.My.Resources.Resources.designer_3D
        Me.mnuActORVerificationReminder.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.mnuActORVerificationReminder.ImagePaddingHorizontal = 8
        Me.mnuActORVerificationReminder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuActORVerificationReminder.Name = "mnuActORVerificationReminder"
        Me.mnuActORVerificationReminder.SubItemsExpandWidth = 14
        Me.mnuActORVerificationReminder.Text = "Other Region" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Reminder"
        '
        'mnuActCaseUpdates
        '
        Me.mnuActCaseUpdates.Image = Global.EobBTS.My.Resources.Resources.Update
        Me.mnuActCaseUpdates.ImageFixedSize = New System.Drawing.Size(50, 40)
        Me.mnuActCaseUpdates.ImagePaddingHorizontal = 8
        Me.mnuActCaseUpdates.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.mnuActCaseUpdates.Name = "mnuActCaseUpdates"
        Me.mnuActCaseUpdates.SubItemsExpandWidth = 14
        Me.mnuActCaseUpdates.Text = "Update Case" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Status"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Save-1.jpg")
        Me.ImageList1.Images.SetKeyName(1, "Add-3.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Undo-2.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Delete-2.bmp")
        Me.ImageList1.Images.SetKeyName(4, "Exit-1.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Edit-1.jpg")
        Me.ImageList1.Images.SetKeyName(6, "PNG Add-2.png")
        Me.ImageList1.Images.SetKeyName(7, "PNG Edit.png")
        Me.ImageList1.Images.SetKeyName(8, "PNG Cancel.png")
        '
        'mnuDefinitions
        '
        Me.mnuDefinitions.Checked = True
        Me.mnuDefinitions.ImagePaddingHorizontal = 8
        Me.mnuDefinitions.Name = "mnuDefinitions"
        Me.mnuDefinitions.Panel = Me.RibbonPanel1
        Me.mnuDefinitions.Text = "Definitions"
        '
        'mnuActivities
        '
        Me.mnuActivities.ImagePaddingHorizontal = 8
        Me.mnuActivities.Name = "mnuActivities"
        Me.mnuActivities.Panel = Me.RibbonPanel2
        Me.mnuActivities.Text = "Activities"
        '
        'mnuReports
        '
        Me.mnuReports.ImagePaddingHorizontal = 8
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Panel = Me.RibbonPanel3
        Me.mnuReports.Text = "Reports"
        '
        'Office2007StartButton1
        '
        Me.Office2007StartButton1.AutoExpandOnClick = True
        Me.Office2007StartButton1.CanCustomize = False
        Me.Office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.Office2007StartButton1.ImageFixedSize = New System.Drawing.Size(10, 10)
        Me.Office2007StartButton1.ImagePaddingHorizontal = 2
        Me.Office2007StartButton1.ImagePaddingVertical = 2
        Me.Office2007StartButton1.Name = "Office2007StartButton1"
        Me.Office2007StartButton1.ShowSubItems = False
        Me.Office2007StartButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1, Me.ItemContainer4})
        Me.Office2007StartButton1.Text = "&File"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2})
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.ItemContainer2.ItemSpacing = 0
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3})
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuSave, Me.mnuCancel, Me.mnuDelete})
        '
        'mnuAdd
        '
        Me.mnuAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuAdd.ImageIndex = 6
        Me.mnuAdd.ImagePaddingHorizontal = 8
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.mnuAdd.SubItemsExpandWidth = 24
        Me.mnuAdd.Text = "Add"
        '
        'mnuEdit
        '
        Me.mnuEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuEdit.ImageIndex = 5
        Me.mnuEdit.ImagePaddingHorizontal = 8
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE)
        Me.mnuEdit.SubItemsExpandWidth = 24
        Me.mnuEdit.Text = "Edit"
        '
        'mnuSave
        '
        Me.mnuSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuSave.ImageIndex = 0
        Me.mnuSave.ImagePaddingHorizontal = 8
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.mnuSave.SubItemsExpandWidth = 24
        Me.mnuSave.Text = "Save"
        '
        'mnuCancel
        '
        Me.mnuCancel.BeginGroup = True
        Me.mnuCancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuCancel.ImageIndex = 2
        Me.mnuCancel.ImagePaddingHorizontal = 8
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.mnuCancel.SubItemsExpandWidth = 24
        Me.mnuCancel.Text = "Cancel"
        '
        'mnuDelete
        '
        Me.mnuDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuDelete.ImageIndex = 3
        Me.mnuDelete.ImagePaddingHorizontal = 8
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.mnuDelete.SubItemsExpandWidth = 24
        Me.mnuDelete.Text = "Delete"
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer"
        Me.ItemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem12, Me.mnuExit})
        '
        'ButtonItem12
        '
        Me.ButtonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem12.ImagePaddingHorizontal = 8
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.SubItemsExpandWidth = 24
        Me.ButtonItem12.Text = "Opt&ions"
        '
        'mnuExit
        '
        Me.mnuExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.mnuExit.ImageIndex = 4
        Me.mnuExit.ImagePaddingHorizontal = 8
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.SubItemsExpandWidth = 24
        Me.mnuExit.Text = "E&xit"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ImagePaddingHorizontal = 8
        Me.ButtonItem1.Name = "ButtonItem1"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.striplblSystem, Me.striplblUser, Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 572)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1211, 29)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'striplblSystem
        '
        Me.striplblSystem.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.striplblSystem.Name = "striplblSystem"
        Me.striplblSystem.Size = New System.Drawing.Size(286, 24)
        Me.striplblSystem.Text = "EOBI Benefits Cases Management System"
        '
        'striplblUser
        '
        Me.striplblUser.Name = "striplblUser"
        Me.striplblUser.Size = New System.Drawing.Size(0, 24)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(34, 27)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'frmMainscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1211, 601)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMainscreen"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Main Screen"
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel1.ResumeLayout(False)
        Me.RibbonPanel3.ResumeLayout(False)
        Me.RibbonPanel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents mnuDefEmp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents mnuDefinitions As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents mnuActivities As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents Office2007StartButton1 As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents mnuAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuEdit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuSave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuCancel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuDelete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents mnuReports As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents mnuDefEmpDef As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents striplblSystem As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents striplblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuDefGeneral As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents mnuDefGeneralRegInfo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuDefGeneralUsers As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuDefGeneralUserRole As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuDefGeneralFinancialYear As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuRptEmp As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents mnuRptEmpRegionEmployees As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuActCases As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents mnuActCaseReceived As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents mnuDefEmpJobAssignment As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuRptBTS As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents mnuRptBTSProcessSheet As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuActVerificationReceived As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuActCaseSettle As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer5 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents mnuActORVerification As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuRptORVerification As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuRptClaimCasesReport As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuActCaseRecommended As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuRptFIRHistory As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuActORVerificationReminder As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuRptORVeriReminder As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents mnuActCaseUpdates As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuDefGeneralDBBackup As DevComponents.DotNetBar.ButtonItem
End Class
