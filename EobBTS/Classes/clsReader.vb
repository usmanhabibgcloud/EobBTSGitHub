Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class clsReader
    'Inherits DataGridView
    Private _cmdText As String
    Public Property cmdtext() As String
        Get
            Return _cmdText
        End Get
        Set(ByVal value As String)
            _cmdText = value
        End Set

    End Property
    Private _Con As SqlConnection
    Public Property Con() As SqlConnection
        Get
            Return _Con
        End Get
        Set(ByVal value As SqlConnection)
            _Con = value
        End Set
    End Property
    Private _ds As New DataSet
    Public Property ds() As DataSet
        Get
            Return _ds
        End Get
        Set(ByVal value As DataSet)
            _ds = value
        End Set
    End Property

    Public ReadOnly Property tblRows(Optional ByVal tblIndex As Integer = 0) As Integer
        Get
            Return _ds.Tables(tblIndex).Rows.Count
        End Get
    End Property

    Public ReadOnly Property countTables() As Integer
        Get
            Return _ds.Tables.Count
        End Get
    End Property

    Public Sub GetRecord()
        Dim rs As New SqlDataAdapter(_cmdText, _Con)
        rs.Fill(_ds)
    End Sub

    Public Sub GetRecord(ByVal myText As String)
        Dim rs As New SqlDataAdapter(myText, _Con)
        rs.Fill(_ds)
    End Sub

    Public Sub GetRecord(ByVal myText As String, ByVal myCn As SqlConnection)
        Dim rs As New SqlDataAdapter(myText, myCn)
        rs.Fill(_ds)
    End Sub
    Public ReadOnly Property EOF(Optional ByVal tblIndex As Integer = 0) As Boolean
        Get
            If _ds.Tables(tblIndex).Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

#Region "TextProperty"
    Public ReadOnly Property TextValue(ByVal ColName As String, ByVal RowIndex As Integer)
        Get
            Return _ds.Tables(0).Rows(RowIndex)(ColName)
        End Get
    End Property
    Public ReadOnly Property TextValue(ByVal ColIndex As Integer, ByVal RowIndex As Integer)
        Get
            Return _ds.Tables(0).Rows(RowIndex)(ColIndex)
        End Get
    End Property
    Public ReadOnly Property TextValue(ByVal ColName As String, ByVal RowIndex As Integer, ByVal tblName As String)
        Get
            Return _ds.Tables(tblName).Rows(RowIndex)(ColName)
        End Get
    End Property
    Public ReadOnly Property TextValue(ByVal ColIndex As Integer, ByVal RowIndex As Integer, ByVal tblName As String)
        Get
            Return _ds.Tables(tblName).Rows(RowIndex)(ColIndex)
        End Get
    End Property
    Public ReadOnly Property TextValue(ByVal ColName As String, ByVal RowIndex As Integer, ByVal tblIndex As Integer)
        Get
            Return _ds.Tables(tblIndex).Rows(RowIndex)(ColName)
        End Get
    End Property
    Public ReadOnly Property TextValue(ByVal ColIndex As Integer, ByVal RowIndex As Integer, ByVal tblIndex As Integer)
        Get
            Return _ds.Tables(tblIndex).Rows(RowIndex)(ColIndex)
        End Get
    End Property
#End Region

    
End Class
