Public Class Login

    Public Shared users As Users
    Public Shared transisi As Transisi

    Dim colors As DialogResult

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        users = New Users()
        transisi = New Transisi()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            users.UsernameProperty = data_user(1)
            users.Dir_fotoProperty = data_user(2)
            MessageBox.Show("Login Berhasil!")
            transisi.Show()
            Me.Hide()
            Else
                MessageBox.Show("Login Tidak Berhasil!")
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtUsername.Text = Nothing
        TxtPassword.Text = Nothing
    End Sub

    Private Sub LblReset_Click(sender As Object, e As EventArgs) Handles LblReset.Click
        Dim resetAkun = New ResetAkun()
        resetAkun.Show()
        Me.Hide()
    End Sub

    Private Sub LblDaftar_Click(sender As Object, e As EventArgs) Handles LblDaftar.Click
        Dim daftar = New Daftar()
        daftar.Show()
        Me.Hide()
    End Sub

    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsername.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukkan input berupa huruf!")
        End If
    End Sub

    Private Sub LblDaftar_MouseEnter(sender As Object, e As EventArgs) Handles LblDaftar.MouseEnter
        LblDaftar.ForeColor = Color.FromArgb("-65536")
    End Sub

    Private Sub LblDaftar_MouseLeave(sender As Object, e As EventArgs) Handles LblDaftar.MouseLeave
        LblDaftar.ForeColor = Color.FromArgb("-16776961")
    End Sub

    Private Sub LblReset_MouseEnter(sender As Object, e As EventArgs) Handles LblReset.MouseEnter
        LblReset.ForeColor = Color.FromArgb("-65536")
    End Sub

    Private Sub LblReset_MouseLeave(sender As Object, e As EventArgs) Handles LblReset.MouseLeave
        LblReset.ForeColor = Color.FromArgb("-16776961")
    End Sub
End Class

