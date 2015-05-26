<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTambah
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
        Me.CRreport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SadadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DdadsaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRreport
        '
        Me.CRreport.ActiveViewIndex = -1
        Me.CRreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRreport.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRreport.Location = New System.Drawing.Point(12, 54)
        Me.CRreport.Name = "CRreport"
        Me.CRreport.Size = New System.Drawing.Size(550, 324)
        Me.CRreport.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SadadToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(706, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SadadToolStripMenuItem
        '
        Me.SadadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DdadsaToolStripMenuItem})
        Me.SadadToolStripMenuItem.Name = "SadadToolStripMenuItem"
        Me.SadadToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SadadToolStripMenuItem.Text = "sadad"
        '
        'DdadsaToolStripMenuItem
        '
        Me.DdadsaToolStripMenuItem.Name = "DdadsaToolStripMenuItem"
        Me.DdadsaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DdadsaToolStripMenuItem.Text = "ddadsa"
        '
        'frmTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 465)
        Me.Controls.Add(Me.CRreport)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTambah"
        Me.Text = "Tambah"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CRreport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SadadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DdadsaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
