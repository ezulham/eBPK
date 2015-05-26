
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmTambah
     
    Private Sub DdadsaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DdadsaToolStripMenuItem.Click

        Dim cdReportDocumet As New crSenaraiAhliLembaga
        CRreport.ReportSource = cdReportDocumet
        Try
            CRreport.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class