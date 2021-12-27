Public Class BuatAkun

    Dim usernamechar = 16
    Dim passwordchar = 10

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtHurufUsername.Text = usernamechar
        TxtHurufPassword.Text = passwordchar
    End Sub

    Private Sub BtnRegBuat_Click(sender As Object, e As EventArgs) Handles BtnRegBuat.Click
        If TxtRegUsername.Text.Length < 5 Then
            TxtRegUsername.Select()
            MessageBox.Show("Username harus terdiri dari 5-16 karakter")
        ElseIf TxtRegPassword.Text.Length <> 10 Then
            TxtRegPassword.Select()
            MessageBox.Show("Password harus terdiri dari 10 karakter")
        ElseIf TxtPasswordLagi.Text <> TxtRegPassword.Text Then
            TxtPasswordLagi.Select()
            MessageBox.Show("Konfirmasi Password Tidak Sesuai")
        Else
            Daftar.users.AddUsersDatabase(TxtRegUsername.Text,
                                   TxtRegPassword.Text,
                                   Daftar.users.Dir_fotoProperty,
                                   Daftar.users.Id_pegawaiProperty,
                                   Daftar.users.Nama_pegawaiProperty,
                                   Daftar.users.JabatanProperty,
                                   Daftar.users.Kode_aksesProperty)

            MessageBox.Show("Akun berhasil dibuat")
            Dim login = New Login()
            login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnRegClear_Click(sender As Object, e As EventArgs) Handles BtnRegClear.Click
        TxtRegUsername.Text = Nothing
        TxtRegPassword.Text = Nothing
        TxtPasswordLagi.Text = Nothing
    End Sub

    Private Sub TxtRegUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtRegUsername.TextChanged
        TxtHurufUsername.Text = (usernamechar - TxtRegUsername.Text.Length)
    End Sub

    Private Sub TxtRegUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRegUsername.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukkan karakter berupa huruf!")
        End If

        If TxtRegUsername.Text.Length >= usernamechar Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Username harus terdiri dari 5-16 karakter")
            End If
        End If
    End Sub

    Private Sub TxtRegPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtRegPassword.TextChanged
        TxtHurufPassword.Text = (passwordchar - TxtRegPassword.Text.Length)
    End Sub

    Private Sub TxtRegPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRegPassword.KeyPress
        If TxtRegPassword.Text.Length >= passwordchar Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Password harus terdiri dari 10 karakter")
            End If
        End If
    End Sub
End Class