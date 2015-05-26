Public Class frmTambahProgram

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtBlnKuasa.Text = ""
        txtNamaProgram.Text = ""
        txtPeringkat.Text = ""
        txtProgram.Text = ""
        txtThnKuasa.Text = ""
    End Sub

    Private Sub btnTambahJabatan_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles btnTambahJabatan.LinkClicked
        frmTambahJabatan.Show()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

    End Sub
End Class