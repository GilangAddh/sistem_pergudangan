Public Class Barang_Masuk
    Public Shared IDORDER
    Public Shared JumlahOrder
    Public Shared jumlahmasukbarang
    Public Shared statusbarang
    Public Shared namaBarang
    Public Shared IDbarang
    Public Shared selecteIDBarangMasuk
    Public Shared selectedIDOrder




    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TxtBoxIDOrder.Text = IDORDER
        TextBoxJumlahOrder.Text = JumlahOrder
        LabelIDBarang.Text = IDbarang

        ReloadDataOrderDatabase()


    End Sub

    Private Sub ReloadDataOrderDatabase()
        DGV_Barang_Order.DataSource = Data_Barang.orderbarang.GetDataOrderDatabase()
    End Sub

    Public Sub ReloadDataBarangMasuk()
        DataGridView1.DataSource = Data_Barang.orderbarang.GetDataBarangMasukDatabase()
    End Sub

    Private Sub ReloadDataOrderJoinBarangMasukDatabase()
        DGV_Barang_Order.DataSource = Data_Barang.orderbarang.GetDataOrderJoinBarangMasukBYIDOrderDatabase(TxtBoxIDOrder.Text)
    End Sub


    Private Sub Barang_Masuk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataOrderDatabase()

    End Sub

    Private Sub DGV_Barang_Order_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Barang_Order.CellMouseClick
        JumlahOrder = DGV_Barang_Order.Rows(e.RowIndex).Cells(2).Value
        IDORDER = DGV_Barang_Order.Rows(e.RowIndex).Cells(0).Value
        IDbarang = DGV_Barang_Order.Rows(e.RowIndex).Cells(1).Value
    End Sub



    Private Sub Button_Tampilkan_Click(sender As Object, e As EventArgs) Handles Button_Tampilkan.Click

        TxtBoxIDOrder.Text = IDORDER
        TextBoxJumlahOrder.Text = JumlahOrder
        LabelIDBarang.Text = IDbarang




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
        Data_Barang.orderbarang.GSStockBarang = TxtboxJumlahMasuk.Text + Form_Order.selectedstockbarang

        Data_Barang.orderbarang.GSIDOrder = TxtBoxIDOrder.Text


        Data_Barang.orderbarang.UpdateDataStockDatabase(Data_Barang.orderbarang.GSStockBarang,
                                                        Data_Barang.orderbarang.GSIDBarang)




        Form_Order.DGV_Barang_Order.DataSource = Data_Barang.orderbarang.GetDataOrderJoinBarangDatabase(Form_Order.LabelIDBarang.Text)



    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Data_Barang.orderbarang.GSStatusOrder = LabelStatus.Text
        Data_Barang.orderbarang.GSIDOrder = Integer.Parse(TxtBoxIDOrder.Text)
        Data_Barang.orderbarang.GSJumlahMasuk = Integer.Parse(TxtboxJumlahMasuk.Text)
        Data_Barang.orderbarang.GSIDBarang = Integer.Parse(LabelIDBarang.Text)

        Data_Barang.orderbarang.UpdateDataStatusBarangMasukBYIDOrderDatabase(Data_Barang.orderbarang.GSStatusOrder,
                                                                             Data_Barang.orderbarang.GSIDOrder)

        Data_Barang.orderbarang.AddDataBarangMasukDatabase(Data_Barang.orderbarang.GSIDOrder,
                                                           Data_Barang.orderbarang.GSJumlahMasuk)

        DataGridView1.DataSource = Data_Barang.orderbarang.GetDataBarangMasukDatabase()


    End Sub





    Private Sub Button_Japus_Click(sender As Object, e As EventArgs) Handles Button_Japus.Click

        Dim HO = New Hapus_Order()

        HO.Show()

    End Sub

    Private Sub DGV_Barang_Order_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Barang_Order.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DGV_Barang_Order.Rows(index)

        selectedIDOrder = selectedrow.Cells(0).Value
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(index)

        selecteIDBarangMasuk = selectedrow.Cells(0).Value
    End Sub

    Private Sub Btn_Hapus_Barang_Masuk_Click(sender As Object, e As EventArgs) Handles Btn_Hapus_Barang_Masuk.Click
        Dim HBM = New Hapus_Barang_Masuk()

        HBM.Show()
    End Sub
End Class