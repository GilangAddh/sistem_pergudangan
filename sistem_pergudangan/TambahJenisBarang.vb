Imports System.IO
Public Class TambahJenisBarang


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnTambahJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnTambahJenisBarang.Click
        JenisBarang.ClassJenisBarang.jenisBarangProperty = TxtInputJenisBarang.Text
        JenisBarang.ClassJenisBarang.satuanProperty = TxtInputSatuan.Text
        JenisBarang.ClassJenisBarang.catatanProperty = RtxInputCatatan.Text

        Dim InfoJenisBarang As New InfoJenisBarang
        InfoJenisBarang.Show()
        Me.Close()
    End Sub

    Private Sub RtxInputCatatan_TextChanged(sender As Object, e As EventArgs) Handles RtxInputCatatan.TextChanged
        TxtCatatanLimit.Text = (JenisBarang.ClassJenisBarang.maxCatatanroperty - RtxInputCatatan.Text.Length)
        If TxtCatatanLimit.Text <= 0 Then
            MessageBox.Show("Max Limit!!!")

        End If



    End Sub

    Private Sub BtnTambahCatatan_Click(sender As Object, e As EventArgs) Handles BtnTambahCatatan.Click
        Dim fileReader As System.IO.StreamReader
        OpenFileDialog1.InitialDirectory = "~\Documents"
        OpenFileDialog1.Title = "Buka Catatan Dokter"
        OpenFileDialog1.Filter = "Text File [*.txt]|*.txt|All Files [*.*]|*.*"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.OpenFile()
            fileReader = file.OpenText(OpenFileDialog1.FileName)
            RtxInputCatatan.Text = fileReader.ReadToEnd
            fileReader.Close()
        End If


    End Sub
End Class