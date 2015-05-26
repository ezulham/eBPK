Imports System.Data.OleDb

Public Class frmMain


    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        frmTambahProgram.Show()
    End Sub

    Private Sub btnLembaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLembaga.Click
        frmLembaga.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\db_ProgramPengajian.mdb;"
        Dim oAccessConn As New OleDbConnection(sConnectionString)
        oAccessConn.Open()
        Dim oCmdSelect As New OleDbCommand("SELECT * FROM Pengguna", oAccessConn)
        Dim oReader As OleDbDataReader = oCmdSelect.ExecuteReader()

        While oReader.Read()
            lblName.Text = oReader("Nama")
        End While

    End Sub
End Class