Public Class frmMain

   
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        frmTambah.Show()
    End Sub

    Private Sub btnLembaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLembaga.Click
        frmLembaga.Show()
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnStatistik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatistik.Click
        frmStatistik.Show()
    End Sub


End Class