Imports System.IO

Public Class Edit_Barang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        PictureBoxGambarBarang.Load(Form_Barang.barang.GambarBarangProperty)
        PictureBoxGambarBarang.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerTanggalMasuk.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalMasuk.CustomFormat = "yyyy/MM/dd"
        TxtNamaEdit.Text = Form_Barang.barang.NamaBarangProperty
        CbxJenis.DataSource = Form_Barang.barang.GetDataJenisDatabase
        CbxJenis.SelectedItem() = Form_Barang.barang.JenisBarangProperty
        RtxDeskripsi.Text = Form_Barang.barang.DeskripsiProperty
        TxtTahunProduk.Text = Form_Barang.barang.TahunPembuatanProperty
        TxtLokasi.Text = Form_Barang.barang.LokasiPenyimpananProperty
        DateTimePickerTanggalMasuk.Value = Form_Barang.barang.TanggalMasukBarangProperty

        If String.Compare(Form_Barang.barang.KualitasProperty, "Original") = 0 Then
            RadioButtonOriginal.Checked = True
        ElseIf String.Compare(Form_Barang.barang.KualitasProperty, "Premium") = 0 Then
            RadioButtonPremium.Checked = True
        End If

        For Each targetPasar In Form_Barang.barang.getTargetPasar
            If String.Compare(targetPasar, "Grosir") = 0 Then
                CheckBoxGrosir.Checked = True
            ElseIf String.Compare(targetPasar, "Online Shop") = 0 Then
                CheckBoxOnlineShop.Checked = True
            ElseIf String.Compare(targetPasar, "Toko Brand") = 0 Then
                CheckBoxTokoBrand.Checked = True
            End If
        Next

        Form_Barang.barang.resetTargetPasar()
    End Sub

    Private Sub ToolStripButtonBack_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBack.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        saveUpdate(True)
    End Sub

    Private Sub BtnEditStock_Click(sender As Object, e As EventArgs) Handles BtnEditStock.Click
        saveUpdate(False)
    End Sub

    Private Sub BtnEditGambar_Click(sender As Object, e As EventArgs) Handles BtnEditGambar.Click
        OpenFileDialog1.Title = "Ubah foto barang"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBoxGambarBarang.Load(picKoleksiDir)
        PictureBoxGambarBarang.SizeMode = PictureBoxSizeMode.StretchImage
        Form_Barang.barang.GambarBarangProperty = picKoleksiDir.ToString()
        Form_Barang.barang.GambarBarangProperty = Form_Barang.barang.GambarBarangProperty.Replace("\", "/")
    End Sub

    Private Sub TxtTahunProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTahunProduk.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukkan karakter berupa angka!")
        End If

        If TxtTahunProduk.Text.Length >= 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Tahun tidak bisa melebihi 4 digit")
            End If
        End If
    End Sub

    Private Sub saveUpdate(Decision As Boolean)
        If TxtNamaEdit.Text.Length < 1 Then
            TxtNamaEdit.Select()
            MessageBox.Show("Nama Barang tidak boleh kosong!")
        ElseIf CbxJenis.SelectedItem Is Nothing Then
            MessageBox.Show("Pilih Jenis Barang!")
        ElseIf PictureBoxGambarBarang.Image Is Nothing Then
            MessageBox.Show("Tambah foto barang!")
        ElseIf RtxDeskripsi.Text.Length < 1 Then
            RtxDeskripsi.Select()
            MessageBox.Show("Deskripsi tidak boleh kosong!")
        ElseIf TxtTahunProduk.Text.Length < 1 Then
            TxtTahunProduk.Select()
            MessageBox.Show("Tahun Produksi tidak boleh kosong!")
        ElseIf TxtLokasi.Text.Length < 1 Then
            TxtLokasi.Select()
            MessageBox.Show("Lokasi Penyimpanan tidak boleh kosong!")
        ElseIf (RadioButtonOriginal.Checked = False) And (RadioButtonPremium.Checked = False) Then
            MessageBox.Show("Pilih kualitas barang!")
        ElseIf (CheckBoxGrosir.Checked = False) And (CheckBoxOnlineShop.Checked = False) And (CheckBoxTokoBrand.Checked = False) Then
            MessageBox.Show("Setidaknya pilih satu target pasar!")
        Else
            Form_Barang.barang.NamaBarangProperty = TxtNamaEdit.Text.ToString()
            Form_Barang.barang.JenisBarangProperty = CbxJenis.SelectedItem.ToString()
            Form_Barang.barang.StockBarangProperty = Integer.Parse(Form_Barang.selectedTableKoleksiStock)
            Form_Barang.barang.DeskripsiProperty = RtxDeskripsi.Text.ToString()
            Form_Barang.barang.TahunPembuatanProperty = TxtTahunProduk.Text.ToString()
            Form_Barang.barang.TanggalMasukBarangProperty = DateTimePickerTanggalMasuk.Value.ToString("yyyy/MM/dd")
            Form_Barang.barang.LokasiPenyimpananProperty = TxtLokasi.Text.ToString()

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
            Form_Barang.barang.TerakhirPembaharuanProperty = today.ToString("yyyy/MM/dd")

            Form_Barang.barang.UpdateDataKatalogByIDDatabase(Form_Barang.selectedTableKoleksi,
                                      Form_Barang.barang.JenisBarangProperty,
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

            MessageBox.Show("Perubahan berhasil disimpan")

            If Decision Then
                Dim infoBarang = New Info_Barang()
                infoBarang.Show()
                Me.Close()
            Else
                Dim editStock = New Edit_Stock()
                editStock.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class