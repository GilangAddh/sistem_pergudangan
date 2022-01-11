<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Daftar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblDaftarAkun = New System.Windows.Forms.Label()
        Me.ToolStripDaftar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.BtnTambahFoto = New System.Windows.Forms.Button()
        Me.TxtNamaPegawai = New System.Windows.Forms.TextBox()
        Me.TxtIDPegawai = New System.Windows.Forms.TextBox()
        Me.LblNamaPegawai = New System.Windows.Forms.Label()
        Me.LblIDPegawai = New System.Windows.Forms.Label()
        Me.LblJabatan = New System.Windows.Forms.Label()
        Me.ComboBoxJabatan = New System.Windows.Forms.ComboBox()
        Me.TxtKodeAkses = New System.Windows.Forms.TextBox()
        Me.LblKodeAkses = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.CheckBoxAturan = New System.Windows.Forms.CheckBox()
        Me.TxtHurufID = New System.Windows.Forms.TextBox()
        Me.TxtHurufNama = New System.Windows.Forms.TextBox()
        Me.PictureBoxFotoPegawai = New System.Windows.Forms.PictureBox()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.TxtHurufEmail = New System.Windows.Forms.TextBox()
        Me.TxtEmailPegawai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripDaftar.SuspendLayout()
        CType(Me.PictureBoxFotoPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblDaftarAkun
        '
        Me.LblDaftarAkun.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDaftarAkun.Location = New System.Drawing.Point(12, 25)
        Me.LblDaftarAkun.Name = "LblDaftarAkun"
        Me.LblDaftarAkun.Size = New System.Drawing.Size(118, 16)
        Me.LblDaftarAkun.TabIndex = 12
        Me.LblDaftarAkun.Text = "Daftar Akun"
        Me.LblDaftarAkun.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolStripDaftar
        '
        Me.ToolStripDaftar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStripDaftar.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDaftar.Name = "ToolStripDaftar"
        Me.ToolStripDaftar.Size = New System.Drawing.Size(361, 25)
        Me.ToolStripDaftar.TabIndex = 13
        Me.ToolStripDaftar.Text = "ToolStripDaftar"
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Image = Global.sistem_pergudangan.My.Resources.Resources.back_exit
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(23, 22)
        '
        'BtnTambahFoto
        '
        Me.BtnTambahFoto.Location = New System.Drawing.Point(140, 179)
        Me.BtnTambahFoto.Name = "BtnTambahFoto"
        Me.BtnTambahFoto.Size = New System.Drawing.Size(97, 23)
        Me.BtnTambahFoto.TabIndex = 15
        Me.BtnTambahFoto.Text = "Tambah Foto"
        Me.BtnTambahFoto.UseVisualStyleBackColor = True
        '
        'TxtNamaPegawai
        '
        Me.TxtNamaPegawai.Location = New System.Drawing.Point(23, 303)
        Me.TxtNamaPegawai.Name = "TxtNamaPegawai"
        Me.TxtNamaPegawai.Size = New System.Drawing.Size(282, 20)
        Me.TxtNamaPegawai.TabIndex = 19
        '
        'TxtIDPegawai
        '
        Me.TxtIDPegawai.Location = New System.Drawing.Point(23, 235)
        Me.TxtIDPegawai.Name = "TxtIDPegawai"
        Me.TxtIDPegawai.Size = New System.Drawing.Size(282, 20)
        Me.TxtIDPegawai.TabIndex = 18
        '
        'LblNamaPegawai
        '
        Me.LblNamaPegawai.AutoSize = True
        Me.LblNamaPegawai.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaPegawai.Location = New System.Drawing.Point(20, 275)
        Me.LblNamaPegawai.Name = "LblNamaPegawai"
        Me.LblNamaPegawai.Size = New System.Drawing.Size(91, 13)
        Me.LblNamaPegawai.TabIndex = 17
        Me.LblNamaPegawai.Text = "Nama Pegawai"
        '
        'LblIDPegawai
        '
        Me.LblIDPegawai.AutoSize = True
        Me.LblIDPegawai.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDPegawai.Location = New System.Drawing.Point(20, 209)
        Me.LblIDPegawai.Name = "LblIDPegawai"
        Me.LblIDPegawai.Size = New System.Drawing.Size(72, 13)
        Me.LblIDPegawai.TabIndex = 16
        Me.LblIDPegawai.Text = "ID Pegawai"
        '
        'LblJabatan
        '
        Me.LblJabatan.AutoSize = True
        Me.LblJabatan.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJabatan.Location = New System.Drawing.Point(20, 397)
        Me.LblJabatan.Name = "LblJabatan"
        Me.LblJabatan.Size = New System.Drawing.Size(51, 13)
        Me.LblJabatan.TabIndex = 20
        Me.LblJabatan.Text = "Jabatan"
        '
        'ComboBoxJabatan
        '
        Me.ComboBoxJabatan.FormattingEnabled = True
        Me.ComboBoxJabatan.Items.AddRange(New Object() {"Helper Gudang", "Manajer Gudang", "Admin Gudang"})
        Me.ComboBoxJabatan.Location = New System.Drawing.Point(23, 425)
        Me.ComboBoxJabatan.Name = "ComboBoxJabatan"
        Me.ComboBoxJabatan.Size = New System.Drawing.Size(315, 21)
        Me.ComboBoxJabatan.TabIndex = 21
        '
        'TxtKodeAkses
        '
        Me.TxtKodeAkses.Location = New System.Drawing.Point(23, 489)
        Me.TxtKodeAkses.Name = "TxtKodeAkses"
        Me.TxtKodeAkses.Size = New System.Drawing.Size(246, 20)
        Me.TxtKodeAkses.TabIndex = 23
        '
        'LblKodeAkses
        '
        Me.LblKodeAkses.AutoSize = True
        Me.LblKodeAkses.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKodeAkses.Location = New System.Drawing.Point(20, 462)
        Me.LblKodeAkses.Name = "LblKodeAkses"
        Me.LblKodeAkses.Size = New System.Drawing.Size(74, 13)
        Me.LblKodeAkses.TabIndex = 22
        Me.LblKodeAkses.Text = "Kode Akses"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(23, 562)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(315, 23)
        Me.BtnSubmit.TabIndex = 24
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'CheckBoxAturan
        '
        Me.CheckBoxAturan.AutoSize = True
        Me.CheckBoxAturan.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAturan.Location = New System.Drawing.Point(61, 528)
        Me.CheckBoxAturan.Name = "CheckBoxAturan"
        Me.CheckBoxAturan.Size = New System.Drawing.Size(253, 16)
        Me.CheckBoxAturan.TabIndex = 25
        Me.CheckBoxAturan.Text = "Anda Siap Mematuhi Aturan-Aturan yang Ada"
        Me.CheckBoxAturan.UseVisualStyleBackColor = True
        '
        'TxtHurufID
        '
        Me.TxtHurufID.Location = New System.Drawing.Point(311, 235)
        Me.TxtHurufID.Name = "TxtHurufID"
        Me.TxtHurufID.Size = New System.Drawing.Size(27, 20)
        Me.TxtHurufID.TabIndex = 26
        '
        'TxtHurufNama
        '
        Me.TxtHurufNama.Location = New System.Drawing.Point(311, 303)
        Me.TxtHurufNama.Name = "TxtHurufNama"
        Me.TxtHurufNama.Size = New System.Drawing.Size(27, 20)
        Me.TxtHurufNama.TabIndex = 27
        '
        'PictureBoxFotoPegawai
        '
        Me.PictureBoxFotoPegawai.Location = New System.Drawing.Point(140, 59)
        Me.PictureBoxFotoPegawai.Name = "PictureBoxFotoPegawai"
        Me.PictureBoxFotoPegawai.Size = New System.Drawing.Size(97, 114)
        Me.PictureBoxFotoPegawai.TabIndex = 14
        Me.PictureBoxFotoPegawai.TabStop = False
        '
        'PnlLogo
        '
        Me.PnlLogo.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.Adidas
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(279, 25)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(82, 39)
        Me.PnlLogo.TabIndex = 28
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnImport
        '
        Me.BtnImport.Location = New System.Drawing.Point(274, 487)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(64, 23)
        Me.BtnImport.TabIndex = 29
        Me.BtnImport.Text = "Import"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'TxtHurufEmail
        '
        Me.TxtHurufEmail.Location = New System.Drawing.Point(311, 364)
        Me.TxtHurufEmail.Name = "TxtHurufEmail"
        Me.TxtHurufEmail.Size = New System.Drawing.Size(27, 20)
        Me.TxtHurufEmail.TabIndex = 32
        '
        'TxtEmailPegawai
        '
        Me.TxtEmailPegawai.Location = New System.Drawing.Point(23, 364)
        Me.TxtEmailPegawai.Name = "TxtEmailPegawai"
        Me.TxtEmailPegawai.Size = New System.Drawing.Size(282, 20)
        Me.TxtEmailPegawai.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Email Pegawai"
        '
        'Daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 601)
        Me.Controls.Add(Me.TxtHurufEmail)
        Me.Controls.Add(Me.TxtEmailPegawai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnImport)
        Me.Controls.Add(Me.PnlLogo)
        Me.Controls.Add(Me.TxtHurufNama)
        Me.Controls.Add(Me.TxtHurufID)
        Me.Controls.Add(Me.CheckBoxAturan)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtKodeAkses)
        Me.Controls.Add(Me.LblKodeAkses)
        Me.Controls.Add(Me.ComboBoxJabatan)
        Me.Controls.Add(Me.LblJabatan)
        Me.Controls.Add(Me.TxtNamaPegawai)
        Me.Controls.Add(Me.TxtIDPegawai)
        Me.Controls.Add(Me.LblNamaPegawai)
        Me.Controls.Add(Me.LblIDPegawai)
        Me.Controls.Add(Me.BtnTambahFoto)
        Me.Controls.Add(Me.PictureBoxFotoPegawai)
        Me.Controls.Add(Me.ToolStripDaftar)
        Me.Controls.Add(Me.LblDaftarAkun)
        Me.Name = "Daftar"
        Me.Text = "Daftar"
        Me.ToolStripDaftar.ResumeLayout(False)
        Me.ToolStripDaftar.PerformLayout()
        CType(Me.PictureBoxFotoPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDaftarAkun As Label
    Friend WithEvents ToolStripDaftar As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
    Friend WithEvents PictureBoxFotoPegawai As PictureBox
    Friend WithEvents BtnTambahFoto As Button
    Friend WithEvents TxtNamaPegawai As TextBox
    Friend WithEvents TxtIDPegawai As TextBox
    Friend WithEvents LblNamaPegawai As Label
    Friend WithEvents LblIDPegawai As Label
    Friend WithEvents LblJabatan As Label
    Friend WithEvents ComboBoxJabatan As ComboBox
    Friend WithEvents TxtKodeAkses As TextBox
    Friend WithEvents LblKodeAkses As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents CheckBoxAturan As CheckBox
    Friend WithEvents TxtHurufID As TextBox
    Friend WithEvents TxtHurufNama As TextBox
    Friend WithEvents PnlLogo As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnImport As Button
    Friend WithEvents TxtHurufEmail As TextBox
    Friend WithEvents TxtEmailPegawai As TextBox
    Friend WithEvents Label1 As Label
End Class
