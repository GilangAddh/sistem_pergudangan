Public Class Transisi
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBack.Click
        MessageBox.Show("Anda sudah logout")
        Dim login = New Login()
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAksesBarang.Click
        MessageBox.Show("Anda Mengakses Data Barang")
        Dim formBarang = New Form_Barang()
        formBarang.Show()
        Me.Close()
    End Sub

    Private Sub BtnAksesJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnAksesJenisBarang.Click
        MessageBox.Show("Anda Mengakses Jenis Barang")
        Dim jenisBarang = New JenisBarang()
        jenisBarang.Show()
        Me.Close()
    End Sub
End Class