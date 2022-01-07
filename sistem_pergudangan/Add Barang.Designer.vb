<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Barang
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.LblCaptTambah = New System.Windows.Forms.Label()
        Me.TxtNamaBarang = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.BtnTambahBarang = New System.Windows.Forms.Button()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblNamaBarang = New System.Windows.Forms.Label()
        Me.PictureBoxGambarBarang = New System.Windows.Forms.PictureBox()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.RtxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTahunProduksi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxJenis = New System.Windows.Forms.ComboBox()
        Me.DateMasukBarang = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtLokasi = New System.Windows.Forms.TextBox()
        Me.RadioButtonOriginal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPremium = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxOnlineShop = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTokoBrand = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGrosir = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBoxGambarBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(443, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Image = Global.sistem_pergudangan.My.Resources.Resources.back_exit
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBack.Text = "ToolStripButton"
        '
        'LblCaptTambah
        '
        Me.LblCaptTambah.AutoSize = True
        Me.LblCaptTambah.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaptTambah.Location = New System.Drawing.Point(12, 34)
        Me.LblCaptTambah.Name = "LblCaptTambah"
        Me.LblCaptTambah.Size = New System.Drawing.Size(115, 14)
        Me.LblCaptTambah.TabIndex = 44
        Me.LblCaptTambah.Text = "Tambah Barang:"
        '
        'TxtNamaBarang
        '
        Me.TxtNamaBarang.Location = New System.Drawing.Point(131, 87)
        Me.TxtNamaBarang.Name = "TxtNamaBarang"
        Me.TxtNamaBarang.Size = New System.Drawing.Size(292, 20)
        Me.TxtNamaBarang.TabIndex = 46
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(131, 425)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(292, 20)
        Me.TxtStock.TabIndex = 47
        '
        'BtnTambahBarang
        '
        Me.BtnTambahBarang.Location = New System.Drawing.Point(302, 586)
        Me.BtnTambahBarang.Name = "BtnTambahBarang"
        Me.BtnTambahBarang.Size = New System.Drawing.Size(121, 23)
        Me.BtnTambahBarang.TabIndex = 49
        Me.BtnTambahBarang.Text = "Tambah Barang"
        Me.BtnTambahBarang.UseVisualStyleBackColor = True
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(129, 409)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(35, 13)
        Me.LblStock.TabIndex = 51
        Me.LblStock.Text = "Stock"
        '
        'LblNamaBarang
        '
        Me.LblNamaBarang.AutoSize = True
        Me.LblNamaBarang.Location = New System.Drawing.Point(128, 71)
        Me.LblNamaBarang.Name = "LblNamaBarang"
        Me.LblNamaBarang.Size = New System.Drawing.Size(72, 13)
        Me.LblNamaBarang.TabIndex = 53
        Me.LblNamaBarang.Text = "Nama Barang"
        '
        'PictureBoxGambarBarang
        '
        Me.PictureBoxGambarBarang.Location = New System.Drawing.Point(12, 71)
        Me.PictureBoxGambarBarang.Name = "PictureBoxGambarBarang"
        Me.PictureBoxGambarBarang.Size = New System.Drawing.Size(107, 124)
        Me.PictureBoxGambarBarang.TabIndex = 57
        Me.PictureBoxGambarBarang.TabStop = False
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(12, 201)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(107, 23)
        Me.BtnTambahGambar.TabIndex = 58
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'RtxDeskripsi
        '
        Me.RtxDeskripsi.Location = New System.Drawing.Point(131, 201)
        Me.RtxDeskripsi.Name = "RtxDeskripsi"
        Me.RtxDeskripsi.Size = New System.Drawing.Size(292, 39)
        Me.RtxDeskripsi.TabIndex = 59
        Me.RtxDeskripsi.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Tahun Produksi Barang"
        '
        'TxtTahunProduksi
        '
        Me.TxtTahunProduksi.Location = New System.Drawing.Point(131, 270)
        Me.TxtTahunProduksi.Name = "TxtTahunProduksi"
        Me.TxtTahunProduksi.Size = New System.Drawing.Size(292, 20)
        Me.TxtTahunProduksi.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Jenis Barang"
        '
        'CbxJenis
        '
        Me.CbxJenis.FormattingEnabled = True
        Me.CbxJenis.Location = New System.Drawing.Point(131, 141)
        Me.CbxJenis.Name = "CbxJenis"
        Me.CbxJenis.Size = New System.Drawing.Size(292, 21)
        Me.CbxJenis.TabIndex = 64
        '
        'DateMasukBarang
        '
        Me.DateMasukBarang.Location = New System.Drawing.Point(131, 326)
        Me.DateMasukBarang.Name = "DateMasukBarang"
        Me.DateMasukBarang.Size = New System.Drawing.Size(292, 20)
        Me.DateMasukBarang.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Tanggal Masuk Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Lokasi Penyimpanan"
        '
        'TxtLokasi
        '
        Me.TxtLokasi.Location = New System.Drawing.Point(131, 377)
        Me.TxtLokasi.Name = "TxtLokasi"
        Me.TxtLokasi.Size = New System.Drawing.Size(292, 20)
        Me.TxtLokasi.TabIndex = 67
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonOriginal)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPremium)
        Me.GroupBox1.Location = New System.Drawing.Point(131, 461)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 44)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kualitas Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxOnlineShop)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTokoBrand)
        Me.GroupBox2.Controls.Add(Me.CheckBoxGrosir)
        Me.GroupBox2.Location = New System.Drawing.Point(129, 521)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 44)
        Me.GroupBox2.TabIndex = 72
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(131, 586)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 73
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Add_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 629)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtLokasi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateMasukBarang)
        Me.Controls.Add(Me.CbxJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTahunProduksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RtxDeskripsi)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PictureBoxGambarBarang)
        Me.Controls.Add(Me.LblNamaBarang)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.BtnTambahBarang)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtNamaBarang)
        Me.Controls.Add(Me.LblCaptTambah)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Add_Barang"
        Me.Text = "Add_Barang"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBoxGambarBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
    Friend WithEvents LblCaptTambah As Label
    Friend WithEvents TxtNamaBarang As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents BtnTambahBarang As Button
    Friend WithEvents LblStock As Label
    Friend WithEvents LblNamaBarang As Label
    Friend WithEvents PictureBoxGambarBarang As PictureBox
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents RtxDeskripsi As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTahunProduksi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbxJenis As ComboBox
    Friend WithEvents DateMasukBarang As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtLokasi As TextBox
    Friend WithEvents RadioButtonOriginal As RadioButton
    Friend WithEvents RadioButtonPremium As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBoxOnlineShop As CheckBox
    Friend WithEvents CheckBoxTokoBrand As CheckBox
    Friend WithEvents CheckBoxGrosir As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnClear As Button
End Class
