Public Class ResetAkun

    Public Shared users As Users

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        users = New Users()
    End Sub

    Private Sub ToolStripButtonResetBack_Click(sender As Object, e As EventArgs) Handles ToolStripButtonResetBack.Click
        Dim login = New Login()
        login.Show()
        Me.Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Dim usernamereset As String = TxtResetUsername.Text
        Dim nama_pegawaireset As String = TxtResetNamaPegawai.Text
        Dim kode_aksesreset As String = TxtResetKodeAkses.Text

        Dim data_user As List(Of String) = users.AksesPemulihan(usernamereset,
                                         nama_pegawaireset,
                                         kode_aksesreset)

        If data_user.Count > 0 Then
            users.IduserProperty = data_user(0)

            MessageBox.Show("Pemulihan Diproses")
            Dim resetPassword = New ResetPassword()
            resetPassword.Show()
            Me.Hide()
        Else
            MessageBox.Show("Akses Pemulihan Ditolak")
        End If
    End Sub
End Class