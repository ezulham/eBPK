<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistik
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MengikutJabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.crStatistikViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IkToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(505, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IkToolStripMenuItem
        '
        Me.IkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.IkToolStripMenuItem.Name = "IkToolStripMenuItem"
        Me.IkToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.IkToolStripMenuItem.Text = "Statistik"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MengikutJabatanToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'MengikutJabatanToolStripMenuItem
        '
        Me.MengikutJabatanToolStripMenuItem.Name = "MengikutJabatanToolStripMenuItem"
        Me.MengikutJabatanToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.MengikutJabatanToolStripMenuItem.Text = "Mengikut Jabatan"
        '
        'crStatistikViewer
        '
        Me.crStatistikViewer.ActiveViewIndex = -1
        Me.crStatistikViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crStatistikViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crStatistikViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crStatistikViewer.Location = New System.Drawing.Point(0, 24)
        Me.crStatistikViewer.Name = "crStatistikViewer"
        Me.crStatistikViewer.Size = New System.Drawing.Size(505, 407)
        Me.crStatistikViewer.TabIndex = 1
        '
        'frmStatistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 431)
        Me.Controls.Add(Me.crStatistikViewer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmStatistik"
        Me.Text = "frmStatistik"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents IkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MengikutJabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents crStatistikViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
