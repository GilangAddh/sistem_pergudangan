Public Class HapusJenisBarang
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        JenisBarang.ClassJenisBarang.DeleteDataKoleksiByIDDatabase(JenisBarang.SelectedTableKoleksi)
        MessageBox.Show("Berhasil Menghapus Jenis Barang Yang Dipilih!")
        Me.Close()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class