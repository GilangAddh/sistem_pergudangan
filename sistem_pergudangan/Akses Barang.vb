Public Class Akses_Barang
    Private Sub BtnShowInfo_Click(sender As Object, e As EventArgs) Handles BtnShowInfo.Click
        Try
            Dim selectedKatalog As List(Of String) = Form_Barang.barang.GetDataKatalogByIDDatabase(Form_Barang.selectedTableKoleksi)

            Form_Barang.barang.JenisBarangProperty = selectedKatalog(1)
            Form_Barang.barang.NamaBarangProperty = selectedKatalog(2)
            Form_Barang.barang.StockBarangProperty = selectedKatalog(3)
            Form_Barang.barang.GambarBarangProperty = selectedKatalog(4)
            Form_Barang.barang.DeskripsiProperty = selectedKatalog(5)
            Form_Barang.barang.TahunPembuatanProperty = selectedKatalog(6)
            Form_Barang.barang.TanggalMasukBarangProperty = selectedKatalog(7)
            Form_Barang.barang.TerakhirPembaharuanProperty = selectedKatalog(8)
            Form_Barang.barang.LokasiPenyimpananProperty = selectedKatalog(9)
            Form_Barang.barang.KualitasProperty = selectedKatalog(10)

            Dim data_pasar As List(Of String) = Form_Barang.barang.ConvertStringToKoleksi(selectedKatalog(11))
            For Each info_pasar In data_pasar
                Form_Barang.barang.AddTargetPasar(info_pasar)
            Next

            Dim infoBarang = New Info_Barang()
            infoBarang.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Katalog yang dipilih kosong!")
        End Try
    End Sub

    Private Sub BtnEditBarang_Click(sender As Object, e As EventArgs) Handles BtnEditBarang.Click
        Try
            Dim selectedKatalog As List(Of String) = Form_Barang.barang.GetDataKatalogByIDDatabase(Form_Barang.selectedTableKoleksi)
            Form_Barang.barang.GambarBarangProperty = selectedKatalog(4)

            Form_Barang.barang.NamaBarangProperty = selectedKatalog(2)
            Form_Barang.barang.JenisBarangProperty = selectedKatalog(1)
            Form_Barang.barang.DeskripsiProperty = selectedKatalog(5)
            Form_Barang.barang.TahunPembuatanProperty = selectedKatalog(6)
            Form_Barang.barang.TanggalMasukBarangProperty = selectedKatalog(7)
            Form_Barang.barang.LokasiPenyimpananProperty = selectedKatalog(9)
            Form_Barang.barang.KualitasProperty = selectedKatalog(10)

            Dim data_pasar As List(Of String) = Form_Barang.barang.ConvertStringToKoleksi(selectedKatalog(11))
            For Each info_pasar In data_pasar
                Form_Barang.barang.AddTargetPasar(info_pasar)
            Next

            Dim editBarang = New Edit_Barang()
            editBarang.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Katalog yang dipilih kosong!")
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            Dim selectedKatalog As List(Of String) = Form_Barang.barang.GetDataKatalogByIDDatabase(Form_Barang.selectedTableKoleksi)
            Form_Barang.barang.GambarBarangProperty = selectedKatalog(4)

            Dim hapusBarang = New Hapus_Barang()
            hapusBarang.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Katalog yang dipilih kosong!")
        End Try
    End Sub

    Private Sub ToolStripButtonBack_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBack.Click
        Me.Close()
    End Sub
End Class