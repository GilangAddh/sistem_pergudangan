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

    Private Sub RtxCatatan_TextChanged(sender As Object, e As EventArgs) Handles RtxCatatan.TextChanged
        TxtCatatanLimit.Text = (JenisBarang.ClassJenisBarang.maxCatatanroperty - RtxCatatan.Text.Length)
        If TxtCatatanLimit.Text <= 0 Then
            MessageBox.Show("Max Length")
        End If
    End Sub

    Private Sub RtxCatatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RtxCatatan.KeyPress
        If RtxCatatan.Text.Length >= JenisBarang.ClassJenisBarang.maxCatatanroperty Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
    End Sub

    Private Sub EditJenisBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtCatatanLimit.Text = (JenisBarang.ClassJenisBarang.maxCatatanroperty - RtxCatatan.Text.Length)
    End Sub
End Class