Public Class Hapus_Order

    Public Shared selectedIDOrder
    Public Shared IDOrder

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnHapusOrder_Click(sender As Object, e As EventArgs) Handles BtnHapusOrder.Click
        Data_Barang.orderbarang.DeleteDataOrderByIDOrderDatabase(Barang_Masuk.selectedIDOrder)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class