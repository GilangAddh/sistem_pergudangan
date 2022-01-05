Public Class EditJenisBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtJenisBarang.Text = JenisBarang.ClassJenisBarang.jenisBarangProperty
        TxtSatuan.Text = JenisBarang.ClassJenisBarang.satuanProperty
        RtxCatatan.Text = JenisBarang.ClassJenisBarang.catatanProperty

    End Sub


    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        JenisBarang.ClassJenisBarang.jenisBarangProperty = TxtJenisBarang.Text.ToString()
        JenisBarang.ClassJenisBarang.satuanProperty = TxtSatuan.Text.ToString()
        JenisBarang.ClassJenisBarang.catatanProperty = RtxCatatan.Text.ToString()

        JenisBarang.ClassJenisBarang.UpdateDataKoleksiByIDDatabase(JenisBarang.SelectedTableKoleksi,
                                                                    JenisBarang.ClassJenisBarang.jenisBarangProperty,
                                                                    JenisBarang.ClassJenisBarang.satuanProperty,
                                                                    JenisBarang.ClassJenisBarang.catatanProperty)


        Dim infoJenisBarang As New InfoJenisBarang
        infoJenisBarang.Show()
        Me.Close()
    End Sub
End Class