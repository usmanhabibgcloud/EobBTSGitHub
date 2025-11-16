Imports System.Data.SqlClient
'Public Class ClsReport
'    Private arrParamNames() As String
'    Public ReadOnly Property ParamNames() As String()
'        Get
'            Return arrParamNames
'        End Get
'    End Property
'    Private arrParamTypes() As SqlDbType
'    Public ReadOnly Property ParamTypes() As SqlDbType()
'        Get
'            Return arrParamTypes
'        End Get
'    End Property
'    Private arrParamValues() As String
'    Public ReadOnly Property ParamValues() As Object
'        Get
'            Return arrParamValues
'        End Get
'    End Property
'    Private intParamLen As Integer
'    Public Property ParamCount() As Integer
'        Get
'            Return intParamLen
'        End Get
'        Set(ByVal value As Integer)
'            intParamLen = value
'        End Set
'    End Property
'    Private objLocalParams() As Object
'    Public Property LocalParams() As Object
'        Get
'            Return objLocalParams
'        End Get
'        Set(ByVal value As Object)
'            objLocalParams = value
'        End Set
'    End Property

'    Public Sub AssignParams(ByVal myNames As String(), ByVal mytypes As SqlDbType(), ByVal myValues As Object)
'        ReDim arrParamNames(paramCount - 1)
'        ReDim arrParamTypes(paramCount - 1)
'        ReDim arrParamValues(paramCount - 1)

'        For i As Integer = 0 To paramCount - 1
'            arrParamNames(i) = myNames(i)
'            arrParamTypes(i) = mytypes(i)
'            arrParamValues(i) = myValues(i)
'        Next
'    End Sub
'    Private rptData As New DataSet
'    Public Property DsReport() As DataSet
'        Get
'            Return rptData
'        End Get
'        Set(ByVal value As DataSet)
'            rptData = value
'        End Set
'    End Property
'    Private tblData As New DataTable
'    Public Property TblReport() As DataTable
'        Get
'            Return tblData
'        End Get
'        Set(ByVal value As DataTable)
'            tblData = value
'        End Set
'    End Property
'    Private mycmdType As CommandType
'    Public Property CmdType() As CommandType
'        Get
'            Return mycmdType
'        End Get
'        Set(ByVal value As CommandType)
'            mycmdType = value
'        End Set
'    End Property
'    Private myText As String
'    Public Property CmdText() As String
'        Get
'            Return myText
'        End Get
'        Set(ByVal value As String)
'            myText = value
'        End Set
'    End Property
'    Public Sub FillReportData()
'        Dim adp As New SqlDataAdapter
'        Dim cmd As New SqlCommand(CmdText, cn) With {
'            .CommandType = CmdType
'        }

'        If CmdType = CommandType.StoredProcedure Then
'            For i As Integer = 0 To ParamCount - 1
'                cmd.Parameters.Add(ParamNames(i), ParamTypes(i)).Value = ParamValues(i)
'            Next
'        End If
'        adp.SelectCommand = cmd
'        adp.Fill(rptData)
'        tblData = rptData.Tables(0)
'    End Sub
'    'Public Sub ShowReports(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal rptData As DataTable)
'    '    Dim frm As New frmReports
'    '    Dim myview As CrystalDecisions.Windows.Forms.CrystalReportViewer
'    '    myview = frm.crView
'    '    rpt.SetDataSource(rptData)
'    '    myview.ReportSource = rpt
'    '    myview.ShowRefreshButton = False
'    '    frm.Show()
'    'End Sub
'    'Public Sub fillReport(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal rptData As DataTable, ByVal myView As CrystalDecisions.Windows.Forms.CrystalReportViewer)
'    '    rpt.SetDataSource(rptData)
'    '    Dim p As New CrystalDecisions.Shared.ParameterDiscreteValue
'    '    For i As Integer = 0 To UBound(LocalParams)
'    '        p.Value = LocalParams(i)
'    '        rpt.SetParameterValue(i, p)
'    '    Next
'    '    myView.ReportSource = rpt
'    '    myView.ShowRefreshButton = False
'    '    myView.DisplayToolbar = True
'    '    myView.DisplayStatusBar = True
'    '    myView.Show()
'    'End Sub
'End Class
