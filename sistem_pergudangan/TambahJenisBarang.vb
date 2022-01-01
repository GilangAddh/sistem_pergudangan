Public Class TambahJenisBarang
    Private Sub BtnTambahJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnTambahJenisBarang.Click
        Dim JenisBarang As JenisBarang
        JenisBarang.Show()
        Me.Close()
    End Sub
End Class