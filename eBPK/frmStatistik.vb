Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmStatistik

    Private Sub MengikutJabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MengikutJabatanToolStripMenuItem.Click
        Dim cdReportDocument As New CRstatProgram
        crStatistikViewer.ReportSource = cdReportDocument
        Try
            crStatistikViewer.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class