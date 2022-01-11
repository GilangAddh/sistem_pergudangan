Public Class Data_Barang
    Public Shared orderbarang As New ClassOrder
    Public Shared NamaBarang As String
    Public Shared IDBarang As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        orderbarang = New ClassOrder
        ReloadDataBarangDatabase()
    End Sub

    Public Sub ReloadDataBarangDatabase()

        DGV_Data_Barang.DataSource = orderbarang.GetDataBarangBySearchNamaBarangDatabase(Form_Order.Txt_CariNama.Text)

    End Sub

    Private Sub Data_Barang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataBarangDatabase()
    End Sub

    Private Sub DGV_Data_Barang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Data_Barang.CellMouseClick
        NamaBarang = DGV_Data_Barang.Rows(e.RowIndex).Cells(2).Value
        IDBarang = DGV_Data_Barang.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub Button_Tutup_Click(sender As Object, e As EventArgs) Handles Button_Tutup.Click
        Me.Close()
    End Sub

    Private Sub Button_Pilih_Click(sender As Object, e As EventArgs) Handles Button_Pilih.Click
        Form_Order.TxtBox_NamaBarang.Text = NamaBarang
        Form_Order.LabelIDBarang.Text = IDBarang

    End Sub
End Class