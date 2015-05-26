<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTambahProgram
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboJabatan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.txtNamaProgram = New System.Windows.Forms.TextBox()
        Me.txtBlnKuasa = New System.Windows.Forms.TextBox()
        Me.txtPeringkat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtThnKuasa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnTambahJabatan = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jabatan :"
        '
        'comboJabatan
        '
        Me.comboJabatan.FormattingEnabled = True
        Me.comboJabatan.Location = New System.Drawing.Point(127, 23)
        Me.comboJabatan.Name = "comboJabatan"
        Me.comboJabatan.Size = New System.Drawing.Size(334, 21)
        Me.comboJabatan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kod Program :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Program :"
        '
        'txtProgram
        '
        Me.txtProgram.Location = New System.Drawing.Point(127, 84)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(124, 20)
        Me.txtProgram.TabIndex = 4
        '
        'txtNamaProgram
        '
        Me.txtNamaProgram.Location = New System.Drawing.Point(127, 123)
        Me.txtNamaProgram.Name = "txtNamaProgram"
        Me.txtNamaProgram.Size = New System.Drawing.Size(334, 20)
        Me.txtNamaProgram.TabIndex = 5
        '
        'txtBlnKuasa
        '
        Me.txtBlnKuasa.Location = New System.Drawing.Point(127, 200)
        Me.txtBlnKuasa.Name = "txtBlnKuasa"
        Me.txtBlnKuasa.Size = New System.Drawing.Size(124, 20)
        Me.txtBlnKuasa.TabIndex = 9
        '
        'txtPeringkat
        '
        Me.txtPeringkat.Location = New System.Drawing.Point(127, 161)
        Me.txtPeringkat.Name = "txtPeringkat"
        Me.txtPeringkat.Size = New System.Drawing.Size(124, 20)
        Me.txtPeringkat.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Bulan Kuat kuasa :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Peringkat :"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(151, 299)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Hantar"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(251, 299)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtThnKuasa
        '
        Me.txtThnKuasa.Location = New System.Drawing.Point(127, 235)
        Me.txtThnKuasa.Name = "txtThnKuasa"
        Me.txtThnKuasa.Size = New System.Drawing.Size(124, 20)
        Me.txtThnKuasa.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tahun Kuat kuasa :"
        '
        'btnTambahJabatan
        '
        Me.btnTambahJabatan.AutoSize = True
        Me.btnTambahJabatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahJabatan.Location = New System.Drawing.Point(344, 52)
        Me.btnTambahJabatan.Name = "btnTambahJabatan"
        Me.btnTambahJabatan.Size = New System.Drawing.Size(114, 15)
        Me.btnTambahJabatan.TabIndex = 14
        Me.btnTambahJabatan.TabStop = True
        Me.btnTambahJabatan.Text = "Tambah Jabatan"
        '
        'frmTambahProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 357)
        Me.Controls.Add(Me.btnTambahJabatan)
        Me.Controls.Add(Me.txtThnKuasa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtBlnKuasa)
        Me.Controls.Add(Me.txtPeringkat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNamaProgram)
        Me.Controls.Add(Me.txtProgram)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboJabatan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTambahProgram"
        Me.Text = "Tambah Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProgram As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaProgram As System.Windows.Forms.TextBox
    Friend WithEvents txtBlnKuasa As System.Windows.Forms.TextBox
    Friend WithEvents txtPeringkat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtThnKuasa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnTambahJabatan As System.Windows.Forms.LinkLabel
End Class
