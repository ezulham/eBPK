Imports System.Data.OleDb

Public Class frmTambah

    Dim IdJabatan As Integer
    Dim PilihJabatan As String

    Private Sub TambahID()
        Dim sConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\db_ProgramPengajian.mdb;"
        Dim oAccessConn As New OleDbConnection(sConnectionString)
        oAccessConn.Open()
        Dim oCmdSelect As New OleDbCommand("SELECT Top 1 ID FROM Jabatan order by ID desc;", oAccessConn)
        Dim oReader As OleDbDataReader = oCmdSelect.ExecuteReader()

        While oReader.Read()
            IdJabatan = CInt(oReader("ID")) + 1
        End While
    End Sub
    Private Sub frmTambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlJabatan.Visible = False
        pnlPengguna.Visible = False
        pnlProgram.Visible = False



    End Sub

    Private Sub tmbhUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmbhUser.Click
        pnlPengguna.Visible = True
        pnlProgram.Visible = False
        pnlJabatan.Visible = False
    End Sub

    Private Sub tmbhJab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmbhJab.Click
        pnlJabatan.Visible = True
        pnlPengguna.Visible = False
        pnlProgram.Visible = False
    End Sub

    Private Sub tmbhProg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmbhProg.Click
        pnlProgram.Visible = True
        pnlJabatan.Visible = False
        pnlPengguna.Visible = False

        Try
            Dim fillcon As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\db_ProgramPengajian.mdb")
            Dim query As String = ("SELECT * from Jabatan")
            Dim da As New OleDb.OleDbDataAdapter(query, fillcon)
            Dim ds As New DataSet
            da.Fill(ds)
            comboJabatan.ValueMember = "ID"
            comboJabatan.DisplayMember = "Nama_Jabatan"
            comboJabatan.DataSource = ds.Tables(0)
            comboJabatan.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("ERROR : " & ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnSubJab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubJab.Click
        TambahID()

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\db_ProgramPengajian.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO Jabatan (ID, Nama_jabatan) VALUES (@idJab, @jabatan);"
            sqlquery.Parameters.AddWithValue("@idJab", IdJabatan.ToString)
            sqlquery.Parameters.AddWithValue("@jabatan", txtJabatan.Text)

            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            MsgBox("DATA TELAH BERJAYA DI TAMBAH")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnSubProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubProgram.Click
        Try
            Dim objcon As New conBPK
            Dim sqlquery As New OleDb.OleDbCommand("INSERT INTO Program (Kod_Program, Nama_Program, Bulan_kuatkuasa, Tahun_kuatkuasa, ID, Tahap) VALUES (@Kod_Program, @Nama_Program, @Bulan_kuatkuasa, @Tahun_kuatkuasa, @ID, @Tahap);", objcon.con)
            If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open()
            sqlquery.Parameters.AddWithValue("@Kod_Program", txtProgram.Text)
            sqlquery.Parameters.AddWithValue("@Nama_Program", txtNamaProgram.Text)
            sqlquery.Parameters.AddWithValue("@Bulan_kuatkuasa", cboBulan.SelectedItem.ToString)
            sqlquery.Parameters.AddWithValue("@Tahun_kuatkuasa", txtThnKuasa.Text)
            sqlquery.Parameters.AddWithValue("@ID", lblTest.Text)
            sqlquery.Parameters.AddWithValue("@Tahap", cboTahap.SelectedItem.ToString)
            sqlquery.ExecuteNonQuery()
            objcon.con.Close()
            MsgBox("DATA TELAH BERJAYA DI TAMBAH")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub comboJabatan_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboJabatan.SelectedIndexChanged
        Dim idJab As Integer = 0
        idJab = CInt(comboJabatan.SelectedValue)
        lblTest.Text = idJab.ToString
    End Sub
End Class