Public Class Barang_Masuk
    Public Shared IDORDER
    Public Shared Perbandingan
    Public Shared jumlahmasukbarang
    Public Shared statusbarang
    Public Shared stock
    Public Shared namaBarang
    Public Shared IDbarang




    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataBarangMasukDatabase()
        TxtBoxIDOrder.Text = IDORDER
        TextBoxJumlahOrder.Text = Perbandingan
        Label_idbarang.Text = IDbarang

    End Sub

    Private Sub ReloadDataBarangMasukDatabase()
        DGV_Barang_Order.DataSource = Data_Barang.orderbarang.GetDataBarangMasukDatabase()
    End Sub

    Private Sub Barang_Masuk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataBarangMasukDatabase()

    End Sub

    Private Sub DGV_Barang_Order_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Barang_Order.CellMouseClick
        IDORDER = DGV_Barang_Order.Rows(e.RowIndex).Cells(2).Value
        Perbandingan = DGV_Barang_Order.Rows(e.RowIndex).Cells(7).Value
        statusbarang = DGV_Barang_Order.Rows(e.RowIndex).Cells(9).Value
        stock = DGV_Barang_Order.Rows(e.RowIndex).Cells(4).Value
        namaBarang = DGV_Barang_Order.Rows(e.RowIndex).Cells(3).Value
        IDbarang = DGV_Barang_Order.Rows(e.RowIndex).Cells(0).Value
    End Sub



    Private Sub Button_Tampilkan_Click(sender As Object, e As EventArgs) Handles Button_Tampilkan.Click

        TxtBoxIDOrder.Text = IDORDER
        TextBoxJumlahOrder.Text = Perbandingan
        Label_idbarang.Text = IDbarang



        If TxtboxJumlahMasuk.Text.ToString = "" Then
            TxtboxJumlahMasuk.Select()
            MessageBox.Show("Masukkan Nilai!")

        ElseIf TxtboxJumlahMasuk.Text.ToString = TextBoxJumlahOrder.Text.ToString Then
            LabelStatus.Text = "Terpenuhi"


        ElseIf TextBoxJumlahOrder.Text.ToString > TxtboxJumlahMasuk.Text.ToString Then
            LabelStatus.Text = "Tidak Terpenuhi"



        End If

    End Sub



    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Data_Barang.orderbarang.GSStockBarang = TxtboxJumlahMasuk.Text + stock
        Data_Barang.orderbarang.GSIDBarang = Label_idbarang.Text
        Data_Barang.orderbarang.GSIDOrder = TxtBoxIDOrder.Text
        Data_Barang.orderbarang.GSJumlahMasuk = TxtboxJumlahMasuk.Text

        Data_Barang.orderbarang.UpdateDataStockDatabase(Data_Barang.orderbarang.GSStockBarang,
                                                        Data_Barang.orderbarang.GSIDBarang)

        Data_Barang.orderbarang.UpdateJumlahMasukBarangBYIDOrder(Data_Barang.orderbarang.GSIDOrder,
                                                                 Data_Barang.orderbarang.GSJumlahMasuk)




        DGV_Barang_Order.DataSource = Data_Barang.orderbarang.GetDataBarangMasukDatabase()

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Data_Barang.orderbarang.GSStatusOrder = LabelStatus.Text
        Data_Barang.orderbarang.GSIDOrder = TxtBoxIDOrder.Text


        Data_Barang.orderbarang.UpdateDataStatusBarangMasukBYIDOrderDatabase(Data_Barang.orderbarang.GSStatusOrder,
                                                                             Data_Barang.orderbarang.GSIDOrder)



        DGV_Barang_Order.DataSource = Data_Barang.orderbarang.GetDataBarangMasukDatabase()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs)
        Data_Barang.orderbarang.GSStatusOrder = LabelStatus.Text
        Data_Barang.orderbarang.GSIDOrder = TxtBoxIDOrder.Text

        Data_Barang.orderbarang.ClearDataOrderBarangDatabase(Data_Barang.orderbarang.GSStatusOrder,
                                                             Data_Barang.orderbarang.GSIDOrder)
    End Sub


End Class