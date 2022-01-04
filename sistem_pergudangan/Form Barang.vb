﻿Public Class Form_Barang

    Public Shared barang As Barang

    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Public Shared selectedTableKoleksiStock

    Dim stockSort As New List(Of String) From {"Stock Banyak-Sedikit", "Stock Sedikit-Banyak"}
    Dim tanggalSort As New List(Of String) From {"Tanggal Masuk Terlama-Terbaru", "Tanggal Masuk Terbaru-Terlama"}
    Dim kualitasSort As New List(Of String) From {"Original", "Premium"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        barang = New Barang()

        ReloadAllTableKatalogDatabase()
        ReloadSUMStock()
        colorStock()
    End Sub

    Private Sub ToolStripButtonBack_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBack.Click
        MessageBox.Show("Anda sudah logout")
        Dim login = New Login()
        login.Show()
        Me.Close()
    End Sub

    Private Sub BtnAksesBarang_Click(sender As Object, e As EventArgs) Handles BtnAksesBarang.Click
        If selectedTableKoleksi IsNot Nothing Then
            Dim aksesBarang = New Akses_Barang()
            aksesBarang.Show()
        Else
            MessageBox.Show("Pilih katalog barang yang ingin diakses!")
        End If
    End Sub

    Private Sub BtnEditStock_Click(sender As Object, e As EventArgs) Handles BtnEditStock.Click
        If selectedTableKoleksi IsNot Nothing Then
            Try
                Dim selectedKatalog As List(Of String) = Form_Barang.barang.GetDataKatalogByIDDatabase(Form_Barang.selectedTableKoleksi)

                Form_Barang.barang.NamaBarangProperty = selectedKatalog(2)
                Form_Barang.barang.StockBarangProperty = selectedKatalog(3)
                Form_Barang.barang.GambarBarangProperty = selectedKatalog(4)
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

                Dim editStock = New Edit_Stock()
                editStock.Show()
            Catch ex As Exception
                MessageBox.Show("Katalog yang dipilih kosong!")
            End Try
        Else
            MessageBox.Show("Pilih katalog barang yang ingin diubah stocknya!")
        End If
    End Sub

    Private Sub BtnTambahBarang_Click(sender As Object, e As EventArgs) Handles BtnTambahBarang.Click
        Dim tambahBarang = New Add_Barang()
        tambahBarang.Show()
    End Sub

    Private Sub ReloadAllTableKatalogDatabase()
        DataGridViewKatalog.DataSource = barang.GetDataKatalogDatabase()
    End Sub

    Private Sub Form_Barang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadSUMStock()
        ReloadAllTableKatalogDatabase()
        colorStock()
        selectedTableKoleksi = Nothing
    End Sub

    Private Sub DataGridViewKatalog_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKatalog.CellClick
        Try
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewKatalog.Rows(index)

            selectedTableKoleksi = selectedRow.Cells(0).Value
            selectedTableKoleksiNama = selectedRow.Cells(1).Value
            selectedTableKoleksiStock = selectedRow.Cells(4).Value
        Catch ex As Exception
            MessageBox.Show("Pilih satu katalog yang ada di tabel!")
        End Try
    End Sub
    Private Sub ReloadSUMStock()
        Dim sumStock As List(Of String) = barang.GetSUMStockDatabase()
        If sumStock Is Nothing Then
            LblKapasitasTersedia.Text = 0
        Else
            LblKapasitasTersedia.Text = sumStock(0)
        End If
    End Sub

    Private Sub CbxSortKatalog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSortKatalog.SelectedIndexChanged
        If CbxSortKatalog.SelectedItem() = "Stock Banyak-Sedikit" Then
            DataGridViewKatalog.DataSource = barang.GetDataKatalogDatabaseStockDESC
        ElseIf CbxSortKatalog.SelectedItem() = "Stock Sedikit-Banyak" Then
            DataGridViewKatalog.DataSource = barang.GetDataKatalogDatabaseStockASC
        ElseIf CbxSortKatalog.SelectedItem() = "Tanggal Masuk Terlama-Terbaru" Then
            DataGridViewKatalog.DataSource = barang.GetDataKatalogDatabaseTanggalASC
        ElseIf CbxSortKatalog.SelectedItem() = "Tanggal Masuk Terbaru-Terlama" Then
            DataGridViewKatalog.DataSource = barang.GetDataKatalogDatabaseTanggalDESC
        ElseIf CbxSortKatalog.SelectedItem() = "Original" Then
            DataGridViewKatalog.DataSource = barang.GetDataKatalogDatabaseOriginal
        ElseIf CbxSortKatalog.SelectedItem() = "Premium" Then
            DataGridViewKatalog.DataSource = barang.GetDataKatalogDatabasePremium
        End If
    End Sub

    Private Sub BtnCariBarang_Click(sender As Object, e As EventArgs) Handles BtnCariBarang.Click
        If TxtCariBarang.Text.Length < 1 Then
            MessageBox.Show("Masukkan Nama Barang yang ingin dicari!")
        Else
            DataGridViewKatalog.DataSource = barang.GetDataKatalogDatabaseBySearch(TxtCariBarang.Text)
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        CbxTampilkanBerdasarkan.Text = Nothing
        CbxTampilkanBerdasarkan.SelectedItem() = Nothing
        CbxSortKatalog.Text = Nothing
        CbxSortKatalog.SelectedItem() = Nothing
        TxtCariBarang.Text = Nothing
        ReloadAllTableKatalogDatabase()
    End Sub

    Private Sub colorStock()
        If LblKapasitasTersedia.Text = 0 Then
            LblKapasitasTersedia.ForeColor = Color.FromArgb("-65536")
        Else
            LblKapasitasTersedia.ForeColor = Color.FromArgb("-16777216")
        End If
    End Sub

    Private Sub CbxTampilkanBerdasarkan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxTampilkanBerdasarkan.SelectedIndexChanged
        If CbxTampilkanBerdasarkan.SelectedItem() = "Tidak Berdasarkan" Then
            ReloadAllTableKatalogDatabase()
            CbxSortKatalog.DataSource = Nothing
            CbxSortKatalog.Text = Nothing
            CbxSortKatalog.SelectedItem = Nothing
        ElseIf CbxTampilkanBerdasarkan.SelectedItem() = "Stock" Then
            CbxSortKatalog.DataSource = stockSort
        ElseIf CbxTampilkanBerdasarkan.SelectedItem() = "Tanggal Masuk" Then
            CbxSortKatalog.DataSource = tanggalSort
        ElseIf CbxTampilkanBerdasarkan.SelectedItem() = "Kualitas" Then
            CbxSortKatalog.DataSource = kualitasSort
        End If
    End Sub
End Class