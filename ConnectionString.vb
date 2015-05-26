Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb.OleDbCommand
Imports System.Data
Imports System.Data.OleDb
Public Class ConnectionString
    Private cnProgrameBPK As OleDbConnection
    Public Sub New()
        Dim sqlconn As New OleDb.OleDbConnection 
        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db_ProgramPengajian.mdb"
        sqlconn.ConnectionString = connString 
    End Sub
End Class
