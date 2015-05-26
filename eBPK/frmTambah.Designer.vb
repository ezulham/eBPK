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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TambahProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmbhJab = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmbhProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmbhUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlJabatan = New System.Windows.Forms.Panel()
        Me.btnResetJab = New System.Windows.Forms.Button()
        Me.btnSubJab = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJabatan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlPengguna = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlProgram = New System.Windows.Forms.Panel()
        Me.cboTahap = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtThnKuasa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnResetProgram = New System.Windows.Forms.Button()
        Me.btnSubProgram = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNamaProgram = New System.Windows.Forms.TextBox()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboJabatan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.AhliLembagaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboBulan = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlJabatan.SuspendLayout()
        Me.pnlPengguna.SuspendLayout()
        Me.pnlProgram.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(706, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TambahProgramToolStripMenuItem
        '
        Me.TambahProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmbhJab, Me.tmbhProg, Me.tmbhUser, Me.AhliLembagaToolStripMenuItem})
        Me.TambahProgramToolStripMenuItem.Name = "TambahProgramToolStripMenuItem"
        Me.TambahProgramToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.TambahProgramToolStripMenuItem.Text = "Tambah "
        '
        'tmbhJab
        '
        Me.tmbhJab.Name = "tmbhJab"
        Me.tmbhJab.Size = New System.Drawing.Size(152, 22)
        Me.tmbhJab.Text = "&Jabatan"
        '
        'tmbhProg
        '
        Me.tmbhProg.Name = "tmbhProg"
        Me.tmbhProg.Size = New System.Drawing.Size(152, 22)
        Me.tmbhProg.Text = "&Program"
        '
        'tmbhUser
        '
        Me.tmbhUser.Name = "tmbhUser"
        Me.tmbhUser.Size = New System.Drawing.Size(152, 22)
        Me.tmbhUser.Text = "&Pengguna"
        '
        'pnlJabatan
        '
        Me.pnlJabatan.Controls.Add(Me.btnResetJab)
        Me.pnlJabatan.Controls.Add(Me.btnSubJab)
        Me.pnlJabatan.Controls.Add(Me.Label8)
        Me.pnlJabatan.Controls.Add(Me.txtJabatan)
        Me.pnlJabatan.Controls.Add(Me.Label9)
        Me.pnlJabatan.Controls.Add(Me.Label7)
        Me.pnlJabatan.Location = New System.Drawing.Point(86, 30)
        Me.pnlJabatan.Name = "pnlJabatan"
        Me.pnlJabatan.Size = New System.Drawing.Size(519, 398)
        Me.pnlJabatan.TabIndex = 1
        '
        'btnResetJab
        '
        Me.btnResetJab.Location = New System.Drawing.Point(300, 191)
        Me.btnResetJab.Name = "btnResetJab"
        Me.btnResetJab.Size = New System.Drawing.Size(75, 23)
        Me.btnResetJab.TabIndex = 18
        Me.btnResetJab.Text = "Reset"
        Me.btnResetJab.UseVisualStyleBackColor = True
        '
        'btnSubJab
        '
        Me.btnSubJab.Location = New System.Drawing.Point(200, 191)
        Me.btnSubJab.Name = "btnSubJab"
        Me.btnSubJab.Size = New System.Drawing.Size(75, 23)
        Me.btnSubJab.TabIndex = 17
        Me.btnSubJab.Text = "Hantar"
        Me.btnSubJab.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Masukkan nama Jabatan baru:"
        '
        'txtJabatan
        '
        Me.txtJabatan.Location = New System.Drawing.Point(107, 148)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.Size = New System.Drawing.Size(392, 20)
        Me.txtJabatan.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Nama Jabatan :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(193, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "TAMBAH JABATAN"
        '
        'pnlPengguna
        '
        Me.pnlPengguna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPengguna.Controls.Add(Me.Label11)
        Me.pnlPengguna.Location = New System.Drawing.Point(68, 43)
        Me.pnlPengguna.Name = "pnlPengguna"
        Me.pnlPengguna.Size = New System.Drawing.Size(537, 385)
        Me.pnlPengguna.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(196, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "TAMBAH PENGGUNA"
        '
        'pnlProgram
        '
        Me.pnlProgram.Controls.Add(Me.Label12)
        Me.pnlProgram.Controls.Add(Me.cboBulan)
        Me.pnlProgram.Controls.Add(Me.lblTest)
        Me.pnlProgram.Controls.Add(Me.cboTahap)
        Me.pnlProgram.Controls.Add(Me.Label10)
        Me.pnlProgram.Controls.Add(Me.txtThnKuasa)
        Me.pnlProgram.Controls.Add(Me.Label6)
        Me.pnlProgram.Controls.Add(Me.btnResetProgram)
        Me.pnlProgram.Controls.Add(Me.btnSubProgram)
        Me.pnlProgram.Controls.Add(Me.Label4)
        Me.pnlProgram.Controls.Add(Me.Label5)
        Me.pnlProgram.Controls.Add(Me.txtNamaProgram)
        Me.pnlProgram.Controls.Add(Me.txtProgram)
        Me.pnlProgram.Controls.Add(Me.Label3)
        Me.pnlProgram.Controls.Add(Me.Label2)
        Me.pnlProgram.Controls.Add(Me.comboJabatan)
        Me.pnlProgram.Controls.Add(Me.Label1)
        Me.pnlProgram.Location = New System.Drawing.Point(38, 43)
        Me.pnlProgram.Name = "pnlProgram"
        Me.pnlProgram.Size = New System.Drawing.Size(537, 419)
        Me.pnlProgram.TabIndex = 2
        '
        'cboTahap
        '
        Me.cboTahap.FormattingEnabled = True
        Me.cboTahap.Items.AddRange(New Object() {"Sijil", "Pra Diploma", "Diploma", "Diploma Lanjutan", "Sarjana Muda"})
        Me.cboTahap.Location = New System.Drawing.Point(155, 188)
        Me.cboTahap.Name = "cboTahap"
        Me.cboTahap.Size = New System.Drawing.Size(121, 21)
        Me.cboTahap.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(212, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "TAMBAH PROGRAM"
        '
        'txtThnKuasa
        '
        Me.txtThnKuasa.Location = New System.Drawing.Point(154, 259)
        Me.txtThnKuasa.Name = "txtThnKuasa"
        Me.txtThnKuasa.Size = New System.Drawing.Size(124, 20)
        Me.txtThnKuasa.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tahun Kuat kuasa :"
        '
        'btnResetProgram
        '
        Me.btnResetProgram.Location = New System.Drawing.Point(278, 321)
        Me.btnResetProgram.Name = "btnResetProgram"
        Me.btnResetProgram.Size = New System.Drawing.Size(75, 23)
        Me.btnResetProgram.TabIndex = 25
        Me.btnResetProgram.Text = "Reset"
        Me.btnResetProgram.UseVisualStyleBackColor = True
        '
        'btnSubProgram
        '
        Me.btnSubProgram.Location = New System.Drawing.Point(178, 321)
        Me.btnSubProgram.Name = "btnSubProgram"
        Me.btnSubProgram.Size = New System.Drawing.Size(75, 23)
        Me.btnSubProgram.TabIndex = 24
        Me.btnSubProgram.Text = "Hantar"
        Me.btnSubProgram.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Bulan Kuat kuasa :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Peringkat :"
        '
        'txtNamaProgram
        '
        Me.txtNamaProgram.Location = New System.Drawing.Point(154, 147)
        Me.txtNamaProgram.Name = "txtNamaProgram"
        Me.txtNamaProgram.Size = New System.Drawing.Size(334, 20)
        Me.txtNamaProgram.TabIndex = 19
        '
        'txtProgram
        '
        Me.txtProgram.Location = New System.Drawing.Point(154, 108)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(124, 20)
        Me.txtProgram.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nama Program :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Kod Program :"
        '
        'comboJabatan
        '
        Me.comboJabatan.FormattingEnabled = True
        Me.comboJabatan.Location = New System.Drawing.Point(154, 71)
        Me.comboJabatan.Name = "comboJabatan"
        Me.comboJabatan.Size = New System.Drawing.Size(334, 21)
        Me.comboJabatan.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Jabatan :"
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(30, 343)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(10, 13)
        Me.lblTest.TabIndex = 30
        Me.lblTest.Text = " "
        '
        'AhliLembagaToolStripMenuItem
        '
        Me.AhliLembagaToolStripMenuItem.Name = "AhliLembagaToolStripMenuItem"
        Me.AhliLembagaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AhliLembagaToolStripMenuItem.Text = "&Ahli Lembaga"
        '
        'cboBulan
        '
        Me.cboBulan.FormattingEnabled = True
        Me.cboBulan.Items.AddRange(New Object() {"Januari", "Februari", "Mac", "April", "Mei", "Jun", "Julai", "Ogos", "September", "Oktober", "November", "Disember"})
        Me.cboBulan.Location = New System.Drawing.Point(154, 225)
        Me.cboBulan.Name = "cboBulan"
        Me.cboBulan.Size = New System.Drawing.Size(121, 21)
        Me.cboBulan.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(286, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Contoh: 2013, 2014"
        '
        'frmTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 465)
        Me.Controls.Add(Me.pnlProgram)
        Me.Controls.Add(Me.pnlJabatan)
        Me.Controls.Add(Me.pnlPengguna)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTambah"
        Me.Text = "Tambah"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlJabatan.ResumeLayout(False)
        Me.pnlJabatan.PerformLayout()
        Me.pnlPengguna.ResumeLayout(False)
        Me.pnlPengguna.PerformLayout()
        Me.pnlProgram.ResumeLayout(False)
        Me.pnlProgram.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TambahProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmbhJab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmbhProg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmbhUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlJabatan As System.Windows.Forms.Panel
    Friend WithEvents pnlPengguna As System.Windows.Forms.Panel
    Friend WithEvents pnlProgram As System.Windows.Forms.Panel
    Friend WithEvents txtThnKuasa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnResetProgram As System.Windows.Forms.Button
    Friend WithEvents btnSubProgram As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNamaProgram As System.Windows.Forms.TextBox
    Friend WithEvents txtProgram As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnResetJab As System.Windows.Forms.Button
    Friend WithEvents btnSubJab As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtJabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboTahap As System.Windows.Forms.ComboBox
    Friend WithEvents lblTest As System.Windows.Forms.Label
    Friend WithEvents AhliLembagaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboBulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
