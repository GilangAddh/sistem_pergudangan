<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Barang
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.LblNamaBarangEdit = New System.Windows.Forms.Label()
        Me.TxtNamaEdit = New System.Windows.Forms.TextBox()
        Me.LblCaptEdit = New System.Windows.Forms.Label()
        Me.BtnEditStock = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.CbxJenis = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTahunProduk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RtxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.BtnEditGambar = New System.Windows.Forms.Button()
        Me.PictureBoxGambarBarang = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxOnlineShop = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTokoBrand = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGrosir = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonOriginal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPremium = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtLokasi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePickerTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip.SuspendLayout()
        CType(Me.PictureBoxGambarBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(453, 25)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Image = Global.sistem_pergudangan.My.Resources.Resources.back_exit
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBack.Text = "ToolStripButton1"
        '
        'LblNamaBarangEdit
        '
        Me.LblNamaBarangEdit.AutoSize = True
        Me.LblNamaBarangEdit.Location = New System.Drawing.Point(132, 69)
        Me.LblNamaBarangEdit.Name = "LblNamaBarangEdit"
        Me.LblNamaBarangEdit.Size = New System.Drawing.Size(72, 13)
        Me.LblNamaBarangEdit.TabIndex = 61
        Me.LblNamaBarangEdit.Text = "Nama Barang"
        '
        'TxtNamaEdit
        '
        Me.TxtNamaEdit.Location = New System.Drawing.Point(135, 85)
        Me.TxtNamaEdit.Name = "TxtNamaEdit"
        Me.TxtNamaEdit.Size = New System.Drawing.Size(292, 20)
        Me.TxtNamaEdit.TabIndex = 56
        '
        'LblCaptEdit
        '
        Me.LblCaptEdit.AutoSize = True
        Me.LblCaptEdit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaptEdit.Location = New System.Drawing.Point(12, 37)
        Me.LblCaptEdit.Name = "LblCaptEdit"
        Me.LblCaptEdit.Size = New System.Drawing.Size(88, 14)
        Me.LblCaptEdit.TabIndex = 54
        Me.LblCaptEdit.Text = "Edit Barang:"
        '
        'BtnEditStock
        '
        Me.BtnEditStock.Location = New System.Drawing.Point(135, 534)
        Me.BtnEditStock.Name = "BtnEditStock"
        Me.BtnEditStock.Size = New System.Drawing.Size(132, 23)
        Me.BtnEditStock.TabIndex = 62
        Me.BtnEditStock.Text = "Simpan dan Edit Stock"
        Me.BtnEditStock.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(358, 534)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(69, 23)
        Me.BtnSimpan.TabIndex = 63
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'CbxJenis
        '
        Me.CbxJenis.FormattingEnabled = True
        Me.CbxJenis.Location = New System.Drawing.Point(135, 134)
        Me.CbxJenis.Name = "CbxJenis"
        Me.CbxJenis.Size = New System.Drawing.Size(292, 21)
        Me.CbxJenis.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Jenis Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Tahun Produksi Barang"
        '
        'TxtTahunProduk
        '
        Me.TxtTahunProduk.Location = New System.Drawing.Point(135, 263)
        Me.TxtTahunProduk.Name = "TxtTahunProduk"
        Me.TxtTahunProduk.Size = New System.Drawing.Size(292, 20)
        Me.TxtTahunProduk.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Deskripsi"
        '
        'RtxDeskripsi
        '
        Me.RtxDeskripsi.Location = New System.Drawing.Point(135, 194)
        Me.RtxDeskripsi.Name = "RtxDeskripsi"
        Me.RtxDeskripsi.Size = New System.Drawing.Size(292, 39)
        Me.RtxDeskripsi.TabIndex = 69
        Me.RtxDeskripsi.Text = ""
        '
        'BtnEditGambar
        '
        Me.BtnEditGambar.Location = New System.Drawing.Point(15, 188)
        Me.BtnEditGambar.Name = "BtnEditGambar"
        Me.BtnEditGambar.Size = New System.Drawing.Size(96, 23)
        Me.BtnEditGambar.TabIndex = 68
        Me.BtnEditGambar.Text = "Edit Gambar"
        Me.BtnEditGambar.UseVisualStyleBackColor = True
        '
        'PictureBoxGambarBarang
        '
        Me.PictureBoxGambarBarang.Location = New System.Drawing.Point(15, 70)
        Me.PictureBoxGambarBarang.Name = "PictureBoxGambarBarang"
        Me.PictureBoxGambarBarang.Size = New System.Drawing.Size(96, 112)
        Me.PictureBoxGambarBarang.TabIndex = 67
        Me.PictureBoxGambarBarang.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxOnlineShop)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTokoBrand)
        Me.GroupBox2.Controls.Add(Me.CheckBoxGrosir)
        Me.GroupBox2.Location = New System.Drawing.Point(135, 463)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 44)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Target Pasar"
        '
        'CheckBoxOnlineShop
        '
        Me.CheckBoxOnlineShop.AutoSize = True
        Me.CheckBoxOnlineShop.Location = New System.Drawing.Point(202, 21)
        Me.CheckBoxOnlineShop.Name = "CheckBoxOnlineShop"
        Me.CheckBoxOnlineShop.Size = New System.Drawing.Size(84, 17)
        Me.CheckBoxOnlineShop.TabIndex = 2
        Me.CheckBoxOnlineShop.Text = "Online Shop"
        Me.CheckBoxOnlineShop.UseVisualStyleBackColor = True
        '
        'CheckBoxTokoBrand
        '
        Me.CheckBoxTokoBrand.AutoSize = True
        Me.CheckBoxTokoBrand.Location = New System.Drawing.Point(101, 19)
        Me.CheckBoxTokoBrand.Name = "CheckBoxTokoBrand"
        Me.CheckBoxTokoBrand.Size = New System.Drawing.Size(82, 17)
        Me.CheckBoxTokoBrand.TabIndex = 1
        Me.CheckBoxTokoBrand.Text = "Toko Brand"
        Me.CheckBoxTokoBrand.UseVisualStyleBackColor = True
        '
        'CheckBoxGrosir
        '
        Me.CheckBoxGrosir.AutoSize = True
        Me.CheckBoxGrosir.Location = New System.Drawing.Point(18, 19)
        Me.CheckBoxGrosir.Name = "CheckBoxGrosir"
        Me.CheckBoxGrosir.Size = New System.Drawing.Size(53, 17)
        Me.CheckBoxGrosir.TabIndex = 0
        Me.CheckBoxGrosir.Text = "Grosir"
        Me.CheckBoxGrosir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonOriginal)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPremium)
        Me.GroupBox1.Location = New System.Drawing.Point(135, 404)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 44)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kualitas Barang"
        '
        'RadioButtonOriginal
        '
        Me.RadioButtonOriginal.AutoSize = True
        Me.RadioButtonOriginal.Location = New System.Drawing.Point(9, 19)
        Me.RadioButtonOriginal.Name = "RadioButtonOriginal"
        Me.RadioButtonOriginal.Size = New System.Drawing.Size(60, 17)
        Me.RadioButtonOriginal.TabIndex = 69
        Me.RadioButtonOriginal.TabStop = True
        Me.RadioButtonOriginal.Text = "Original"
        Me.RadioButtonOriginal.UseVisualStyleBackColor = True
        '
        'RadioButtonPremium
        '
        Me.RadioButtonPremium.AutoSize = True
        Me.RadioButtonPremium.Location = New System.Drawing.Point(92, 21)
        Me.RadioButtonPremium.Name = "RadioButtonPremium"
        Me.RadioButtonPremium.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonPremium.TabIndex = 70
        Me.RadioButtonPremium.TabStop = True
        Me.RadioButtonPremium.Text = "Premium"
        Me.RadioButtonPremium.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Lokasi Penyimpanan"
        '
        'TxtLokasi
        '
        Me.TxtLokasi.Location = New System.Drawing.Point(135, 366)
        Me.TxtLokasi.Name = "TxtLokasi"
        Me.TxtLokasi.Size = New System.Drawing.Size(292, 20)
        Me.TxtLokasi.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Tanggal Masuk Barang"
        '
        'DateTimePickerTanggalMasuk
        '
        Me.DateTimePickerTanggalMasuk.Location = New System.Drawing.Point(135, 315)
        Me.DateTimePickerTanggalMasuk.Name = "DateTimePickerTanggalMasuk"
        Me.DateTimePickerTanggalMasuk.Size = New System.Drawing.Size(292, 20)
        Me.DateTimePickerTanggalMasuk.TabIndex = 77
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Edit_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 581)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtLokasi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePickerTanggalMasuk)
        Me.Controls.Add(Me.CbxJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTahunProduk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RtxDeskripsi)
        Me.Controls.Add(Me.BtnEditGambar)
        Me.Controls.Add(Me.PictureBoxGambarBarang)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnEditStock)
        Me.Controls.Add(Me.LblNamaBarangEdit)
        Me.Controls.Add(Me.TxtNamaEdit)
        Me.Controls.Add(Me.LblCaptEdit)
        Me.Controls.Add(Me.ToolStrip)
        Me.Name = "Edit_Barang"
        Me.Text = "Edit_Barang"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.PictureBoxGambarBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
    Friend WithEvents LblNamaBarangEdit As Label
    Friend WithEvents TxtNamaEdit As TextBox
    Friend WithEvents LblCaptEdit As Label
    Friend WithEvents BtnEditStock As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents CbxJenis As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTahunProduk As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RtxDeskripsi As RichTextBox
    Friend WithEvents BtnEditGambar As Button
    Friend WithEvents PictureBoxGambarBarang As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBoxOnlineShop As CheckBox
    Friend WithEvents CheckBoxTokoBrand As CheckBox
    Friend WithEvents CheckBoxGrosir As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonOriginal As RadioButton
    Friend WithEvents RadioButtonPremium As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtLokasi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePickerTanggalMasuk As DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
