Public Class Edit_Stock

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNamaBarang.Text = Form_Barang.barang.NamaBarangProperty
        LblStock.Text = Form_Barang.barang.StockBarangProperty
        TxtSetStock.Text = LblStock.Text
        colorStock()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButtonBack.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdateStock_Click(sender As Object, e As EventArgs) Handles BtnUpdateStock.Click
        Dim today = Date.Now()
        Form_Barang.barang.TerakhirPembaharuanProperty = today.ToString("yyyy/MM/dd")

        Form_Barang.barang.StockBarangProperty = LblStock.Text
        Form_Barang.barang.UpdateStockByIDDatabase(Form_Barang.selectedTableKoleksi, Form_Barang.barang.StockBarangProperty, Form_Barang.barang.TerakhirPembaharuanProperty)
        MessageBox.Show("Stock " + Form_Barang.barang.NamaBarangProperty + " diperbarui")
        Dim infoBarang = New Info_Barang()
        infoBarang.Show()
        Me.Close()
    End Sub

    Private Sub colorStock()
        If LblStock.Text = 0 Then
            LblStock.ForeColor = Color.FromArgb("-65536")
        Else
            LblStock.ForeColor = Color.FromArgb("-16777216")
        End If
    End Sub

    Private Sub BtnMinStock_Click(sender As Object, e As EventArgs) Handles BtnMinStock.Click
        If LblStock.Text > 0 Then
            LblStock.Text -= 1
            colorStock()
            TxtSetStock.Text = LblStock.Text
        Else
            MessageBox.Show("Stock sudah kosong")
        End If
    End Sub

    Private Sub BtnPlusStock_Click(sender As Object, e As EventArgs) Handles BtnPlusStock.Click
        LblStock.Text += 1
        colorStock()
        TxtSetStock.Text = LblStock.Text
    End Sub

    Private Sub TxtSetStock_TextChanged(sender As Object, e As EventArgs) Handles TxtSetStock.TextChanged
        If TxtSetStock.Text.Length > 0 Then
            LblStock.Text = TxtSetStock.Text
            colorStock()

            If TxtSetStock.Text.IndexOf(0) = 0 Then
                TxtSetStock.Text = 0
            End If
        End If
    End Sub

    Private Sub TxtSetStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSetStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukkan karakter berupa angka!")
        End If
    End Sub
End Class