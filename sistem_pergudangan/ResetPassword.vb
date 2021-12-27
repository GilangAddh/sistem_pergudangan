Public Class ResetPassword

    Dim newPassChar = 10

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtHurufPasswordBaru.Text = newPassChar
    End Sub

    Private Sub BtnNewPasswordClear_Click(sender As Object, e As EventArgs) Handles BtnNewPasswordClear.Click
        TxtNewPassword.Text = Nothing
        TxtNewPasswordLagi.Text = Nothing
    End Sub

    Private Sub TxtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtNewPassword.TextChanged
        TxtHurufPasswordBaru.Text = (newPassChar - TxtNewPassword.Text.Length)
    End Sub

    Private Sub TxtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNewPassword.KeyPress
        If TxtNewPassword.Text.Length >= newPassChar Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Password harus terdiri dari 10 karakter")
            End If
        End If
    End Sub

    Private Sub BtnBuatNewPassword_Click(sender As Object, e As EventArgs) Handles BtnBuatNewPassword.Click
        If TxtNewPassword.Text.Length <> 10 Then
            TxtNewPassword.Select()
            MessageBox.Show("Password harus terdiri dari 10 karakter")
        ElseIf TxtNewPasswordLagi.Text <> TxtNewPassword.Text Then
            TxtNewPasswordLagi.Select()
            MessageBox.Show("Konfirmasi Password Tidak Sesuai")
        Else
            ResetAkun.users.UpdateDataUserByIDDatabase(ResetAkun.users.IduserProperty,
                                                       TxtNewPassword.Text)

            MessageBox.Show("Password baru berhasil dibuat")
            Dim login = New Login()
            login.Show()
            Me.Close()
        End If
    End Sub
End Class