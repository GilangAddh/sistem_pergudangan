Public Class Form_Order

    Public Shared selectedIDOrder
    Public Shared selecttableorderbarang


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtB_JumlahOrder.Text = Data_Barang.orderbarang.GSJumlahOrder
        TextBox_TanggalOrder.Text = Data_Barang.orderbarang.GSTanggalOrder

    End Sub

    Private Sub Button_Cari_Click(sender As Object, e As EventArgs) Handles Button_Cari.Click
        Dim dataBarang = New Data_Barang()


        If Txt_CariNama.Text.Length = 0 Then
            Txt_CariNama.Select()
            MessageBox.Show("Isi Nama Barang yang Ingin Dicari!")
        Else
            dataBarang.Show()
            Data_Barang.ReloadDataBarangDatabase()
        End If

    End Sub

    Private Sub ReloadDataBarangJoinOrderDatabase()
        DGV_Barang_Order.DataSource = Data_Barang.orderbarang.GetDataOrderJoinBarangDatabase()
    End Sub

    Private Sub Form_Order_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataBarangJoinOrderDatabase()
    End Sub

    Private Sub DGV_Barang_Order_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Barang_Order.CellMouseClick
        selectedIDOrder = DGV_Barang_Order.Rows(e.RowIndex).Cells(0)
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click




        Data_Barang.orderbarang.GSJumlahOrder = Integer.Parse(TxtB_JumlahOrder.Text)
        Data_Barang.orderbarang.GSTanggalOrder = TextBox_TanggalOrder.Text
        Data_Barang.orderbarang.GSIDBarang = LabelIDBarang.Text


        Data_Barang.orderbarang.UpdateDataOrderJoinBarangBYIDBarangDatabase(Data_Barang.orderbarang.GSJumlahOrder,
                                                                            Data_Barang.orderbarang.GSTanggalOrder,
                                                                            Data_Barang.orderbarang.GSIDBarang)
    End Sub

    Private Sub Btn_Tampilkan_Click(sender As Object, e As EventArgs) Handles Btn_Tampilkan.Click
        TextBox_TanggalOrder.Text = DateTimePicker_TanggalOrder.Value.ToString("yyyy/MM/dd")
    End Sub

    Private Sub DGV_Barang_Order_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Barang_Order.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGV_Barang_Order.Rows(index)

        selecttableorderbarang = selectedRow.Cells(0).Value

    End Sub

   

    Private Sub Button_Tambah_Click(sender As Object, e As EventArgs) Handles Button_Tambah.Click

        Dim BM = New Barang_Masuk

        BM.Show()
    End Sub
End Class