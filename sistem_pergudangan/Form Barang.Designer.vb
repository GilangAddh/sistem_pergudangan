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
        Me.ToolStripFormBarang.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewKatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripFormBarang
        '
        Me.ToolStripFormBarang.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStripFormBarang.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripFormBarang.Name = "ToolStripFormBarang"
        Me.ToolStripFormBarang.Size = New System.Drawing.Size(1049, 25)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1049, 24)
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
        Me.LblCaptKapasitas.Size = New System.Drawing.Size(176, 13)
        Me.LblCaptKapasitas.TabIndex = 43
        Me.LblCaptKapasitas.Text = "Jumlah Barang di Gudang:"
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
        Me.TxtCariBarang.Location = New System.Drawing.Point(700, 222)
        Me.TxtCariBarang.Name = "TxtCariBarang"
        Me.TxtCariBarang.Size = New System.Drawing.Size(246, 20)
        Me.TxtCariBarang.TabIndex = 48
        '
        'DataGridViewKatalog
        '
        Me.DataGridViewKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKatalog.Location = New System.Drawing.Point(15, 257)
        Me.DataGridViewKatalog.Name = "DataGridViewKatalog"
        Me.DataGridViewKatalog.Size = New System.Drawing.Size(1018, 349)
        Me.DataGridViewKatalog.TabIndex = 49
        '
        'BtnCariBarang
        '
        Me.BtnCariBarang.Location = New System.Drawing.Point(952, 221)
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
        Me.LblCaptSearch.Location = New System.Drawing.Point(698, 207)
        Me.LblCaptSearch.Name = "LblCaptSearch"
        Me.LblCaptSearch.Size = New System.Drawing.Size(130, 12)
        Me.LblCaptSearch.TabIndex = 51
        Me.LblCaptSearch.Text = "Masukkan Nama Barang:"
        '
        'BtnAksesBarang
        '
        Me.BtnAksesBarang.Location = New System.Drawing.Point(737, 623)
        Me.BtnAksesBarang.Name = "BtnAksesBarang"
        Me.BtnAksesBarang.Size = New System.Drawing.Size(140, 23)
        Me.BtnAksesBarang.TabIndex = 52
        Me.BtnAksesBarang.Text = "Akses Barang"
        Me.BtnAksesBarang.UseVisualStyleBackColor = True
        '
        'BtnEditStock
        '
        Me.BtnEditStock.Location = New System.Drawing.Point(894, 623)
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
        Me.PnlLogo.Location = New System.Drawing.Point(467, 52)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(125, 66)
        Me.PnlLogo.TabIndex = 40
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(593, 623)
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
        'Form_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 667)
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
End Class
