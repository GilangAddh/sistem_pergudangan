Imports System.IO

Public Class Add_Barang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateMasukBarang.Format = DateTimePickerFormat.Custom
        DateMasukBarang.CustomFormat = "yyyy/MM/dd"
        CbxJenis.DataSource = Form_Barang.barang.GetDataJenisDatabase
        CbxJenis.SelectedItem = Nothing
        CbxJenis.Text = Nothing
    End Sub

    Private Sub ToolStripButtonBacl_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBack.Click
        Me.Close()
    End Sub

    Private Sub BtnTambahBarang_Click(sender As Object, e As EventArgs) Handles BtnTambahBarang.Click
        If TxtNamaBarang.Text.Length < 1 Then
            TxtNamaBarang.Select()
            MessageBox.Show("Nama Barang tidak boleh kosong!")
        ElseIf CbxJenis.SelectedItem Is Nothing Then
            MessageBox.Show("Pilih Jenis Barang!")
        ElseIf PictureBoxGambarBarang.Image Is Nothing Then
            MessageBox.Show("Tambah foto barang!")
        ElseIf RtxDeskripsi.Text.Length < 1 Then
            RtxDeskripsi.Select()
            MessageBox.Show("Deskripsi tidak boleh kosong!")
        ElseIf TxtTahunProduksi.Text.Length < 1 Then
            TxtTahunProduksi.Select()
            MessageBox.Show("Tahun Produksi tidak boleh kosong!")
        ElseIf TxtLokasi.Text.Length < 1 Then
            TxtLokasi.Select()
            MessageBox.Show("Lokasi Penyimpanan tidak boleh kosong!")
        ElseIf TxtStock.Text.Length < 1 Then
            TxtStock.Select()
            MessageBox.Show("Stock tidak boleh kosong!")
        ElseIf (RadioButtonOriginal.Checked = False) And (RadioButtonPremium.Checked = False) Then
            MessageBox.Show("Pilih kualitas barang!")
        ElseIf (CheckBoxGrosir.Checked = False) And (CheckBoxOnlineShop.Checked = False) And (CheckBoxTokoBrand.Checked = False) Then
            MessageBox.Show("Setidaknya pilih satu target pasar!")
        Else
            Form_Barang.barang.NamaBarangProperty = TxtNamaBarang.Text
            Form_Barang.barang.JenisBarangProperty = CbxJenis.SelectedItem
            Form_Barang.barang.DeskripsiProperty = RtxDeskripsi.Text
            Form_Barang.barang.TahunPembuatanProperty = TxtTahunProduksi.Text
            Form_Barang.barang.TanggalMasukBarangProperty = DateMasukBarang.Value.ToShortDateString()
            Form_Barang.barang.LokasiPenyimpananProperty = TxtLokasi.Text
            Form_Barang.barang.StockBarangProperty = TxtStock.Text

            If RadioButtonOriginal.Checked Then
                Form_Barang.barang.KualitasProperty = "Original"
            End If

            If RadioButtonPremium.Checked Then
                Form_Barang.barang.KualitasProperty = "Premium"
            End If

            If CheckBoxGrosir.Checked Then
                Form_Barang.barang.AddTargetPasar("Grosir")
            End If

            If CheckBoxOnlineShop.Checked Then
                Form_Barang.barang.AddTargetPasar("Online Shop")
            End If

            If CheckBoxTokoBrand.Checked Then
                Form_Barang.barang.AddTargetPasar("Toko Brand")
            End If

            Dim convertedKoleksi = Form_Barang.barang.ConvertKoleksiToString(Form_Barang.barang.getTargetPasar)

            Dim today = Date.Now()
            Form_Barang.barang.TerakhirPembaharuanProperty = today.ToShortDateString()

            Form_Barang.barang.AddDataKatalogDatabase(Form_Barang.barang.JenisBarangProperty,
                                                  Form_Barang.barang.NamaBarangProperty,
                                                  Form_Barang.barang.StockBarangProperty,
                                                  Form_Barang.barang.GambarBarangProperty,
                                                  Form_Barang.barang.DeskripsiProperty,
                                                  Form_Barang.barang.TahunPembuatanProperty,
                                                  Form_Barang.barang.TanggalMasukBarangProperty,
                                                  Form_Barang.barang.TerakhirPembaharuanProperty,
                                                  Form_Barang.barang.LokasiPenyimpananProperty,
                                                  Form_Barang.barang.KualitasProperty,
                                                  convertedKoleksi)

            MessageBox.Show(Form_Barang.barang.NamaBarangProperty + " berhasil ditambahkan ke katalog")

            Dim infoBarang = New Info_Barang()
            infoBarang.Show()
            Me.Close()
        End If
    End Sub

    Private Sub TxtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukkan karakter berupa angka!")
        End If
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Pilih Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBoxGambarBarang.Load(picKoleksiDir)
        PictureBoxGambarBarang.SizeMode = PictureBoxSizeMode.StretchImage
        Form_Barang.barang.GambarBarangProperty = picKoleksiDir.ToString()
        Form_Barang.barang.GambarBarangProperty = Form_Barang.barang.GambarBarangProperty.Replace("\", "/")
    End Sub

    Private Sub TxtTahunMasuk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTahunProduksi.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukkan karakter berupa angka!")
        End If

        If TxtTahunProduksi.Text.Length >= 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Tahun tidak bisa melebihi 4 digit")
            End If
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        PictureBoxGambarBarang.Image = Nothing
        TxtNamaBarang.Text = Nothing
        CbxJenis.SelectedItem = Nothing
        CbxJenis.Text = Nothing
        RtxDeskripsi.Text = Nothing
        TxtTahunProduksi.Text = Nothing
        DateMasukBarang.Value = Now
        TxtLokasi.Text = Nothing
        TxtStock.Text = Nothing
        RadioButtonOriginal.Checked = False
        RadioButtonPremium.Checked = False
        CheckBoxGrosir.Checked = False
        CheckBoxOnlineShop.Checked = False
        CheckBoxTokoBrand.Checked = False
    End Sub
End Class