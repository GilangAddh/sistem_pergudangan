Public Class Hapus_Barang_Masuk
    Private Sub BtnHapusOrder_Click(sender As Object, e As EventArgs) Handles BtnHapusOrder.Click
        Data_Barang.orderbarang.DeleteDataBarangMasukByBarangMasukDatabase(Barang_Masuk.selecteIDBarangMasuk)
        Barang_Masuk.ReloadDataBarangMasuk()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class