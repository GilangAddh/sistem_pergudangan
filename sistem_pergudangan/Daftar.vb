Imports System.IO
Public Class Daftar
    Public Shared users As Users

    Dim idchar = 6
    Dim namechar = 30
    Dim emailchar = 30

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        users = New Users()
        TxtHurufID.Text = idchar
        TxtHurufNama.Text = namechar
        TxtHurufEmail.Text = emailchar
    End Sub

    Private Sub ToolStripButtonBack_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBack.Click
        Dim login = New Login()
        login.Show()
        Me.Close()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If TxtIDPegawai.Text.Length <> 6 Then
            TxtIDPegawai.Select()
            MessageBox.Show("ID pegawai harus berjumlah 6 digit")
        ElseIf TxtNamaPegawai.Text.Length < 3 Then
            TxtNamaPegawai.Select()
            MessageBox.Show("Nama Pegawai tidak boleh kurang dari 3 huruf!")
        ElseIf TxtEmailPegawai.Text.Length < 1 Then
            TxtEmailPegawai.Select()
            MessageBox.Show("Email tidak boleh kosong!")
        ElseIf PictureBoxFotoPegawai.Image Is Nothing Then
            BtnTambahFoto.Select()
            MessageBox.Show("Masukkan Gambar!")
        ElseIf ComboBoxJabatan.SelectedItem() Is Nothing Then
            ComboBoxJabatan.Select()
            MessageBox.Show("Pilih Jabatan Anda!")
        ElseIf TxtKodeAkses.Text.Length < 1 Then
            TxtKodeAkses.Select()
            MessageBox.Show("Masukkan Kode Akses!")
        ElseIf CheckBoxAturan.Checked = False Then
            CheckBoxAturan.Select()
            MessageBox.Show("Anda harus menyetujui aturan gudang")
        Else
            Dim kodeAkses As String = TxtKodeAkses.Text
            Dim jabatan As String = ComboBoxJabatan.SelectedItem

            Dim AuthStatus As Boolean = users.CheckAuth(kodeAkses, jabatan)
            If AuthStatus Then
                users.Id_pegawaiProperty = TxtIDPegawai.Text
                users.Nama_pegawaiProperty = TxtNamaPegawai.Text
                users.Email_pegawaiProperty = TxtEmailPegawai.Text
                users.JabatanProperty = ComboBoxJabatan.SelectedItem
                users.Kode_aksesProperty = TxtKodeAkses.Text
                MessageBox.Show("Pendaftaran Berhasil!")
                Dim buatAkun = New BuatAkun()
                buatAkun.Show()
                Me.Hide()
            Else
                MessageBox.Show("Kode Akses Tidak Tepat")
            End If
        End If
    End Sub

    Private Sub BtnTambahFoto_Click(sender As Object, e As EventArgs) Handles BtnTambahFoto.Click
        OpenFileDialog1.Title = "Pilih Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBoxFotoPegawai.Load(picKoleksiDir)
        PictureBoxFotoPegawai.SizeMode = PictureBoxSizeMode.StretchImage
        users.Dir_fotoProperty = picKoleksiDir.ToString()
        users.Dir_fotoProperty = users.Dir_fotoProperty.Replace("\", "/")
    End Sub

    Private Sub TxtNamaPegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaPegawai.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Masukkan karakter berupa huruf!")
        End If

        If TxtNamaPegawai.Text.Length >= namechar Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Nama Pegawai tidak bisa melebihi 30 karakter")
            End If
        End If
    End Sub

    Private Sub TxtIDPegawai_TextChanged(sender As Object, e As EventArgs) Handles TxtIDPegawai.TextChanged
        TxtHurufID.Text = (idchar - TxtIDPegawai.Text.Length)
    End Sub

    Private Sub TxtNamaPegawai_TextChanged(sender As Object, e As EventArgs) Handles TxtNamaPegawai.TextChanged
        TxtHurufNama.Text = (namechar - TxtNamaPegawai.Text.Length)
    End Sub

    Private Sub TxtIDPegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIDPegawai.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukkan karakter berupa angka!")
        End If

        If TxtIDPegawai.Text.Length >= idchar Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("ID Pegawai harus terdiri dari 6 digit angka")
            End If
        End If
    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        Dim fileReader As System.IO.StreamReader
        OpenFileDialog1.InitialDirectory = "~\Documents"
        OpenFileDialog1.Title = "Pilih File Kode Akses"
        OpenFileDialog1.Filter = "Text File [*.txt]|*.txt|All Files [*.*]|*.*"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.OpenFile()
            fileReader = File.OpenText(OpenFileDialog1.FileName)
            TxtKodeAkses.Text = fileReader.ReadToEnd() '
            fileReader.Close() '
        End If
    End Sub

    Private Sub TxtEmailPegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmailPegawai.KeyPress
        If TxtEmailPegawai.Text.Length >= emailchar Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Email tidak bisa melebihi 30 karakter")
            End If
        End If
    End Sub

    Private Sub TxtEmailPegawai_TextChanged(sender As Object, e As EventArgs) Handles TxtEmailPegawai.TextChanged
        TxtHurufEmail.Text = (emailchar - TxtEmailPegawai.Text.Length)
    End Sub
End Class