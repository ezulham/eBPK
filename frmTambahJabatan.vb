Public Class frmTambahJabatan

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtJabatan.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        Try
            Dim objcon As New conBPK
            Dim sqlquery As New OleDb.OleDbCommand("INSERT INTO Jabatan(Nama_Jabatan)VALUES(@Username)", objcon.con)
            If (objcon.con.State = ConnectionState.Closed) Then objcon.con.Open() 
            sqlquery.Parameters.AddWithValue("@Username", txtJabatan.Text) 
            sqlquery.ExecuteNonQuery()
            objcon.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class