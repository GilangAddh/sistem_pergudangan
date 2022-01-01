Public Class Hapus_Barang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNamaBarang.Text = Form_Barang.selectedTableKoleksiNama
        PictureBoxFotoBarang.Load(Form_Barang.barang.GambarBarangProperty)
        PictureBoxFotoBarang.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub ToolStripButtonBack_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBack.Click
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Form_Barang.barang.DeleteDataKatalogByIDDatabase(Form_Barang.selectedTableKoleksi)
        MessageBox.Show(Form_Barang.selectedTableKoleksiNama + " berhasil dihapus dari katalog")
        Me.Close()
    End Sub
End Class