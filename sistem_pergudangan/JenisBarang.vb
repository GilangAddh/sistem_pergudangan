Public Class JenisBarang
    Public Shared ClassJenisBarang As ClassJenisBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ClassJenisBarang = New ClassJenisBarang

    End Sub

    Private Sub JenisBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub BtnTambahJenis_Click(sender As Object, e As EventArgs) Handles BtnTambahJenis.Click
        Dim TambahJenisBarang As New TambahJenisBarang
        TambahJenisBarang.Show()
        'Me.Hide()
    End Sub

    Private Sub BtnEditJenis_Click(sender As Object, e As EventArgs) Handles BtnEditJenis.Click
        Dim EditJenisBarang As New EditJenisBarang
        EditJenisBarang.Show()

    End Sub

    Private Sub BtnHapusJenis_Click(sender As Object, e As EventArgs) Handles BtnHapusJenis.Click
        Dim HapusJenisBarang As New HapusJenisBarang
        HapusJenisBarang.Show()
        'Me.Hide()
    End Sub


End Class