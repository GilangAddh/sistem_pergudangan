Public Class Transisi
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBack.Click
        MessageBox.Show("Anda sudah logout")
        Dim login = New Login()
        login.Show()
        Me.Close()
    End Sub
End Class