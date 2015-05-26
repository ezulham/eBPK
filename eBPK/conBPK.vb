Imports System.Data.OleDb

Public Class conBPK
    Public constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\db_ProgramPengajian.mdb"
    Public con As New OleDbConnection(constring)
End Class
