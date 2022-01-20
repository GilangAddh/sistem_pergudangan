Public Class Data_Barang
    Public Shared orderbarang As New ClassOrder
    Public Shared NamaBarang As String
    Public Shared IDBarang As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        orderbarang = New ClassOrder
    End Sub

    Private Sub DGV_Data_Barang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Data_Barang.CellMouseClick
        NamaBarang = DGV_Data_Barang.Rows(e.RowIndex).Cells(1).Value
        IDBarang = DGV_Data_Barang.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub Button_Tutup_Click(sender As Object, e As EventArgs) Handles Button_Tutup.Click
        Me.Close()
    End Sub

    Private Sub Button_Pilih_Click(sender As Object, e As EventArgs) Handles Button_Pilih.Click
        orderbarang.GSNamaBarang = NamaBarang
        orderbarang.GSIDBarang = IDBarang
        MessageBox.Show(NamaBarang + " berhasil dipilih")
    End Sub

    Private Sub Button_Cari_Data_Click(sender As Object, e As EventArgs) Handles Button_Cari_Data.Click
        If Txt_CariNama.Text.Length = 0 Then
            MessageBox.Show("Masukkan Nama Barang yang Dicari!")
        Else
            DGV_Data_Barang.DataSource = orderbarang.GetDataBarangBySearchNamaBarangDatabase(Txt_CariNama.Text)
        End If
    End Sub
End Class