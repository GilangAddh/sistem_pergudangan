<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Barang
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
        Me.ToolStripFormBarang = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuJenis = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuMasukBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblCaptKapasitas = New System.Windows.Forms.Label()
        Me.LblKapasitasTersedia = New System.Windows.Forms.Label()
        Me.LblSortKatalog = New System.Windows.Forms.Label()
        Me.CbxSortKatalog = New System.Windows.Forms.ComboBox()
        Me.TxtCariBarang = New System.Windows.Forms.TextBox()
        Me.DataGridViewKatalog = New System.Windows.Forms.DataGridView()
        Me.BtnCariBarang = New System.Windows.Forms.Button()
        Me.LblCaptSearch = New System.Windows.Forms.Label()
        Me.BtnAksesBarang = New System.Windows.Forms.Button()
        Me.BtnEditStock = New System.Windows.Forms.Button()
        Me.BtnTambahBarang = New System.Windows.Forms.Button()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.CbxTampilkanBerdasarkan = New System.Windows.Forms.ComboBox()
        Me.LblPerubahan = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBoxTargetPasar = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblKualitas = New System.Windows.Forms.Label()
        Me.LblCaptKualitas = New System.Windows.Forms.Label()
        Me.LblLokasi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblTahun = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxGambar = New System.Windows.Forms.PictureBox()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblNamaBarang = New System.Windows.Forms.Label()
        Me.LblJenis = New System.Windows.Forms.Label()
        Me.LblNamaBarangInfo = New System.Windows.Forms.Label()
        Me.LblIDJenisInfo = New System.Windows.Forms.Label()
        Me.LblStockInfo = New System.Windows.Forms.Label()
        Me.ToolStripFormBarang.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewKatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripFormBarang
        '
        Me.ToolStripFormBarang.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStripFormBarang.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripFormBarang.Name = "ToolStripFormBarang"
        Me.ToolStripFormBarang.Size = New System.Drawing.Size(1155, 25)
        Me.ToolStripFormBarang.TabIndex = 0
        Me.ToolStripFormBarang.Text = "ToolStrip1"
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Image = Global.sistem_pergudangan.My.Resources.Resources.back_exit
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBack.Text = "ToolStripButtonBack"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1155, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenu
        '
        Me.ToolStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuJenis, Me.ToolStripMenuItem3, Me.ToolStripMenuMasukBarang})
        Me.ToolStripMenu.Name = "ToolStripMenu"
        Me.ToolStripMenu.Size = New System.Drawing.Size(53, 20)
        Me.ToolStripMenu.Text = "Menu "
        '
        'ToolStripMenuJenis
        '
        Me.ToolStripMenuJenis.Name = "ToolStripMenuJenis"
        Me.ToolStripMenuJenis.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuJenis.Text = "Jenis Barang"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuItem3.Text = "Order Barang"
        '
        'ToolStripMenuMasukBarang
        '
        Me.ToolStripMenuMasukBarang.Name = "ToolStripMenuMasukBarang"
        Me.ToolStripMenuMasukBarang.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuMasukBarang.Text = "Masuk Barang"
        '
        'LblCaptKapasitas
        '
        Me.LblCaptKapasitas.AutoSize = True
        Me.LblCaptKapasitas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaptKapasitas.Location = New System.Drawing.Point(12, 93)
        Me.LblCaptKapasitas.Name = "LblCaptKapasitas"
        Me.LblCaptKapasitas.Size = New System.Drawing.Size(166, 13)
        Me.LblCaptKapasitas.TabIndex = 43
        Me.LblCaptKapasitas.Text = "Jumlah Stock di Gudang:"
        '
        'LblKapasitasTersedia
        '
        Me.LblKapasitasTersedia.AutoSize = True
        Me.LblKapasitasTersedia.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKapasitasTersedia.Location = New System.Drawing.Point(68, 122)
        Me.LblKapasitasTersedia.Name = "LblKapasitasTersedia"
        Me.LblKapasitasTersedia.Size = New System.Drawing.Size(35, 16)
        Me.LblKapasitasTersedia.TabIndex = 44
        Me.LblKapasitasTersedia.Text = "100"
        '
        'LblSortKatalog
        '
        Me.LblSortKatalog.AutoSize = True
        Me.LblSortKatalog.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSortKatalog.Location = New System.Drawing.Point(13, 177)
        Me.LblSortKatalog.Name = "LblSortKatalog"
        Me.LblSortKatalog.Size = New System.Drawing.Size(163, 12)
        Me.LblSortKatalog.TabIndex = 46
        Me.LblSortKatalog.Text = "Tampilkan Katalog Berdasakan:"
        '
        'CbxSortKatalog
        '
        Me.CbxSortKatalog.FormattingEnabled = True
        Me.CbxSortKatalog.Location = New System.Drawing.Point(15, 221)
        Me.CbxSortKatalog.Name = "CbxSortKatalog"
        Me.CbxSortKatalog.Size = New System.Drawing.Size(196, 21)
        Me.CbxSortKatalog.TabIndex = 47
        '
        'TxtCariBarang
        '
        Me.TxtCariBarang.Location = New System.Drawing.Point(543, 221)
        Me.TxtCariBarang.Name = "TxtCariBarang"
        Me.TxtCariBarang.Size = New System.Drawing.Size(211, 20)
        Me.TxtCariBarang.TabIndex = 48
        '
        'DataGridViewKatalog
        '
        Me.DataGridViewKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKatalog.Location = New System.Drawing.Point(15, 257)
        Me.DataGridViewKatalog.Name = "DataGridViewKatalog"
        Me.DataGridViewKatalog.Size = New System.Drawing.Size(823, 349)
        Me.DataGridViewKatalog.TabIndex = 49
        '
        'BtnCariBarang
        '
        Me.BtnCariBarang.Location = New System.Drawing.Point(757, 220)
        Me.BtnCariBarang.Name = "BtnCariBarang"
        Me.BtnCariBarang.Size = New System.Drawing.Size(81, 21)
        Me.BtnCariBarang.TabIndex = 50
        Me.BtnCariBarang.Text = "Cari"
        Me.BtnCariBarang.UseVisualStyleBackColor = True
        '
        'LblCaptSearch
        '
        Me.LblCaptSearch.AutoSize = True
        Me.LblCaptSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaptSearch.Location = New System.Drawing.Point(541, 206)
        Me.LblCaptSearch.Name = "LblCaptSearch"
        Me.LblCaptSearch.Size = New System.Drawing.Size(130, 12)
        Me.LblCaptSearch.TabIndex = 51
        Me.LblCaptSearch.Text = "Masukkan Nama Barang:"
        '
        'BtnAksesBarang
        '
        Me.BtnAksesBarang.Location = New System.Drawing.Point(543, 623)
        Me.BtnAksesBarang.Name = "BtnAksesBarang"
        Me.BtnAksesBarang.Size = New System.Drawing.Size(140, 23)
        Me.BtnAksesBarang.TabIndex = 52
        Me.BtnAksesBarang.Text = "Akses Data Barang"
        Me.BtnAksesBarang.UseVisualStyleBackColor = True
        '
        'BtnEditStock
        '
        Me.BtnEditStock.Location = New System.Drawing.Point(699, 623)
        Me.BtnEditStock.Name = "BtnEditStock"
        Me.BtnEditStock.Size = New System.Drawing.Size(139, 23)
        Me.BtnEditStock.TabIndex = 53
        Me.BtnEditStock.Text = "Edit Stock"
        Me.BtnEditStock.UseVisualStyleBackColor = True
        '
        'BtnTambahBarang
        '
        Me.BtnTambahBarang.Location = New System.Drawing.Point(15, 623)
        Me.BtnTambahBarang.Name = "BtnTambahBarang"
        Me.BtnTambahBarang.Size = New System.Drawing.Size(137, 23)
        Me.BtnTambahBarang.TabIndex = 54
        Me.BtnTambahBarang.Text = "Tambah Barang"
        Me.BtnTambahBarang.UseVisualStyleBackColor = True
        '
        'PnlLogo
        '
        Me.PnlLogo.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.Adidas
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(477, 52)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(125, 66)
        Me.PnlLogo.TabIndex = 40
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(399, 623)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(126, 23)
        Me.BtnRefresh.TabIndex = 55
        Me.BtnRefresh.Text = "Refresh Katalog"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'CbxTampilkanBerdasarkan
        '
        Me.CbxTampilkanBerdasarkan.FormattingEnabled = True
        Me.CbxTampilkanBerdasarkan.Items.AddRange(New Object() {"Tidak Berdasarkan", "Stock", "Tanggal Masuk", "Kualitas"})
        Me.CbxTampilkanBerdasarkan.Location = New System.Drawing.Point(15, 192)
        Me.CbxTampilkanBerdasarkan.Name = "CbxTampilkanBerdasarkan"
        Me.CbxTampilkanBerdasarkan.Size = New System.Drawing.Size(126, 21)
        Me.CbxTampilkanBerdasarkan.TabIndex = 56
        '
        'LblPerubahan
        '
        Me.LblPerubahan.AutoSize = True
        Me.LblPerubahan.Location = New System.Drawing.Point(962, 403)
        Me.LblPerubahan.Name = "LblPerubahan"
        Me.LblPerubahan.Size = New System.Drawing.Size(0, 13)
        Me.LblPerubahan.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(853, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Perubahan Terakhir:"
        '
        'ListBoxTargetPasar
        '
        Me.ListBoxTargetPasar.FormattingEnabled = True
        Me.ListBoxTargetPasar.Location = New System.Drawing.Point(855, 550)
        Me.ListBoxTargetPasar.Name = "ListBoxTargetPasar"
        Me.ListBoxTargetPasar.Size = New System.Drawing.Size(277, 56)
        Me.ListBoxTargetPasar.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(852, 526)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Target Pasar:"
        '
        'LblKualitas
        '
        Me.LblKualitas.AutoSize = True
        Me.LblKualitas.Location = New System.Drawing.Point(962, 494)
        Me.LblKualitas.Name = "LblKualitas"
        Me.LblKualitas.Size = New System.Drawing.Size(0, 13)
        Me.LblKualitas.TabIndex = 96
        '
        'LblCaptKualitas
        '
        Me.LblCaptKualitas.AutoSize = True
        Me.LblCaptKualitas.Location = New System.Drawing.Point(852, 494)
        Me.LblCaptKualitas.Name = "LblCaptKualitas"
        Me.LblCaptKualitas.Size = New System.Drawing.Size(47, 13)
        Me.LblCaptKualitas.TabIndex = 95
        Me.LblCaptKualitas.Text = "Kualitas:"
        '
        'LblLokasi
        '
        Me.LblLokasi.AutoSize = True
        Me.LblLokasi.Location = New System.Drawing.Point(962, 434)
        Me.LblLokasi.Name = "LblLokasi"
        Me.LblLokasi.Size = New System.Drawing.Size(0, 13)
        Me.LblLokasi.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(852, 434)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Lokasi Penyimpanan:"
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Location = New System.Drawing.Point(962, 369)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(0, 13)
        Me.LblTanggal.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(852, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Tanggal Masuk:"
        '
        'LblTahun
        '
        Me.LblTahun.AutoSize = True
        Me.LblTahun.Location = New System.Drawing.Point(962, 332)
        Me.LblTahun.Name = "LblTahun"
        Me.LblTahun.Size = New System.Drawing.Size(0, 13)
        Me.LblTahun.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(852, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Tahun Pembuatan:"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(962, 285)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(0, 13)
        Me.LblDeskripsi.TabIndex = 88
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(852, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Deskripsi:"
        '
        'PictureBoxGambar
        '
        Me.PictureBoxGambar.Location = New System.Drawing.Point(965, 78)
        Me.PictureBoxGambar.Name = "PictureBoxGambar"
        Me.PictureBoxGambar.Size = New System.Drawing.Size(96, 120)
        Me.PictureBoxGambar.TabIndex = 86
        Me.PictureBoxGambar.TabStop = False
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(962, 466)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(0, 13)
        Me.LblStock.TabIndex = 85
        '
        'LblNamaBarang
        '
        Me.LblNamaBarang.AutoSize = True
        Me.LblNamaBarang.Location = New System.Drawing.Point(962, 221)
        Me.LblNamaBarang.Name = "LblNamaBarang"
        Me.LblNamaBarang.Size = New System.Drawing.Size(0, 13)
        Me.LblNamaBarang.TabIndex = 84
        '
        'LblJenis
        '
        Me.LblJenis.AutoSize = True
        Me.LblJenis.Location = New System.Drawing.Point(962, 254)
        Me.LblJenis.Name = "LblJenis"
        Me.LblJenis.Size = New System.Drawing.Size(0, 13)
        Me.LblJenis.TabIndex = 83
        '
        'LblNamaBarangInfo
        '
        Me.LblNamaBarangInfo.AutoSize = True
        Me.LblNamaBarangInfo.Location = New System.Drawing.Point(852, 221)
        Me.LblNamaBarangInfo.Name = "LblNamaBarangInfo"
        Me.LblNamaBarangInfo.Size = New System.Drawing.Size(75, 13)
        Me.LblNamaBarangInfo.TabIndex = 82
        Me.LblNamaBarangInfo.Text = "Nama Barang:"
        '
        'LblIDJenisInfo
        '
        Me.LblIDJenisInfo.AutoSize = True
        Me.LblIDJenisInfo.Location = New System.Drawing.Point(852, 254)
        Me.LblIDJenisInfo.Name = "LblIDJenisInfo"
        Me.LblIDJenisInfo.Size = New System.Drawing.Size(71, 13)
        Me.LblIDJenisInfo.TabIndex = 81
        Me.LblIDJenisInfo.Text = "Jenis Barang:"
        '
        'LblStockInfo
        '
        Me.LblStockInfo.AutoSize = True
        Me.LblStockInfo.Location = New System.Drawing.Point(852, 466)
        Me.LblStockInfo.Name = "LblStockInfo"
        Me.LblStockInfo.Size = New System.Drawing.Size(38, 13)
        Me.LblStockInfo.TabIndex = 80
        Me.LblStockInfo.Text = "Stock:"
        '
        'Form_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 667)
        Me.Controls.Add(Me.LblPerubahan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBoxTargetPasar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblKualitas)
        Me.Controls.Add(Me.LblCaptKualitas)
        Me.Controls.Add(Me.LblLokasi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblTahun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBoxGambar)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.LblNamaBarang)
        Me.Controls.Add(Me.LblJenis)
        Me.Controls.Add(Me.LblNamaBarangInfo)
        Me.Controls.Add(Me.LblIDJenisInfo)
        Me.Controls.Add(Me.LblStockInfo)
        Me.Controls.Add(Me.CbxTampilkanBerdasarkan)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnTambahBarang)
        Me.Controls.Add(Me.BtnEditStock)
        Me.Controls.Add(Me.BtnAksesBarang)
        Me.Controls.Add(Me.LblCaptSearch)
        Me.Controls.Add(Me.BtnCariBarang)
        Me.Controls.Add(Me.DataGridViewKatalog)
        Me.Controls.Add(Me.TxtCariBarang)
        Me.Controls.Add(Me.CbxSortKatalog)
        Me.Controls.Add(Me.LblSortKatalog)
        Me.Controls.Add(Me.LblKapasitasTersedia)
        Me.Controls.Add(Me.LblCaptKapasitas)
        Me.Controls.Add(Me.PnlLogo)
        Me.Controls.Add(Me.ToolStripFormBarang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form_Barang"
        Me.Text = "Form_Barang"
        Me.ToolStripFormBarang.ResumeLayout(False)
        Me.ToolStripFormBarang.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridViewKatalog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripFormBarang As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuJenis As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuMasukBarang As ToolStripMenuItem
    Friend WithEvents PnlLogo As Panel
    Friend WithEvents LblCaptKapasitas As Label
    Friend WithEvents LblKapasitasTersedia As Label
    Friend WithEvents LblSortKatalog As Label
    Friend WithEvents CbxSortKatalog As ComboBox
    Friend WithEvents TxtCariBarang As TextBox
    Friend WithEvents DataGridViewKatalog As DataGridView
    Friend WithEvents BtnCariBarang As Button
    Friend WithEvents LblCaptSearch As Label
    Friend WithEvents BtnAksesBarang As Button
    Friend WithEvents BtnEditStock As Button
    Friend WithEvents BtnTambahBarang As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents CbxTampilkanBerdasarkan As ComboBox
    Friend WithEvents LblPerubahan As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBoxTargetPasar As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblKualitas As Label
    Friend WithEvents LblCaptKualitas As Label
    Friend WithEvents LblLokasi As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblTanggal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblTahun As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBoxGambar As PictureBox
    Friend WithEvents LblStock As Label
    Friend WithEvents LblNamaBarang As Label
    Friend WithEvents LblJenis As Label
    Friend WithEvents LblNamaBarangInfo As Label
    Friend WithEvents LblIDJenisInfo As Label
    Friend WithEvents LblStockInfo As Label
End Class
