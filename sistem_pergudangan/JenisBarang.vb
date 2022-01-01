Public Class JenisBarang
    Private Sub BtnTambahJenis_Click(sender As Object, e As EventArgs) Handles BtnTambahJenis.Click
        Dim TambahJenisBarang As TambahJenisBarang
        TambahJenisBarang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnEditJenis_Click(sender As Object, e As EventArgs) Handles BtnEditJenis.Click
        Dim EditJenisBarang As EditJenisBarang
        EditJenisBarang.Show()

    End Sub

    Private Sub BtnHapusJenis_Click(sender As Object, e As EventArgs) Handles BtnHapusJenis.Click
        Dim HapusJenisBarang As HapusJenisBarang
        HapusJenisBarang.Show()
        Me.Hide()
    End Sub
End Class