Public Class InfoJenisBarang


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblOutputJenisBarang.Text = JenisBarang.ClassJenisBarang.jenisBarangProperty
        LblOutputSatuan.Text = JenisBarang.ClassJenisBarang.satuanProperty
        LblOutputCatatan.Text = JenisBarang.ClassJenisBarang.catatanProperty

    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class