Public Class Info_Barang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If Not String.IsNullOrEmpty(Form_Barang.barang.GambarBarangProperty) Then
            PictureBoxGambar.Load(Form_Barang.barang.GambarBarangProperty)
            PictureBoxGambar.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNamaBarang.Text = Form_Barang.barang.NamaBarangProperty
        LblJenis.Text = Form_Barang.barang.JenisBarangProperty
        LblDeskripsi.Text = Form_Barang.barang.DeskripsiProperty
        LblTahun.Text = Form_Barang.barang.TahunPembuatanProperty
        LblTanggal.Text = Form_Barang.barang.TanggalMasukBarangProperty
        LblPerubahan.Text = Form_Barang.barang.TerakhirPembaharuanProperty
        LblLokasi.Text = Form_Barang.barang.LokasiPenyimpananProperty
        LblStock.Text = Form_Barang.barang.StockBarangProperty
        LblKualitas.Text = Form_Barang.barang.KualitasProperty

        ListBoxTargetPasar.Items.Clear()
        For Each pasar In Form_Barang.barang.getTargetPasar
            ListBoxTargetPasar.Items.Add(pasar)
        Next

        Form_Barang.barang.resetTargetPasar()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class