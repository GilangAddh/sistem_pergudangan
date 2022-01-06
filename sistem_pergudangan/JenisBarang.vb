Public Class JenisBarang
    Public Shared ClassJenisBarang As ClassJenisBarang
    Public Shared SelectedTableKoleksi
    Public Shared SelectedTableKoleksiJenis
    Dim data_kategori As List(Of String)


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ClassJenisBarang = New ClassJenisBarang
        'UpdateDataTableArrayList()
        ReloadDataTableKoleksi()

    End Sub

    Private Sub JenisBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'UpdateDataTableArrayList()
        ReloadDataTableKoleksi()
    End Sub

    Private Sub ReloadDataTableKoleksi()
        DataGridJenisBarang.DataSource = ClassJenisBarang.GetDataKoleksiDatabase()

    End Sub

    'Public Sub UpdateDataTableArrayList()
    '    'DataGridJenisBarang.Rows.Clear()

    '    'For Each rowKoleksi In ClassJenisBarang.GetKoleksiDataTable()
    '    '    Dim dataTable As String() = {rowKoleksi(1),
    '    '        rowKoleksi(2),
    '    '        rowKoleksi(3),
    '    '        rowKoleksi(4)}

    '    '    DataGridJenisBarang.Rows.Add(dataTable)
    '    'Next



    'End Sub

    Private Sub BtnTambahJenis_Click(sender As Object, e As EventArgs) Handles BtnTambahJenis.Click
        Dim TambahJenisBarang As New TambahJenisBarang
        TambahJenisBarang.Show()
        'Me.Hide()
    End Sub

    Private Sub BtnEditJenis_Click(sender As Object, e As EventArgs) Handles BtnEditJenis.Click
        Dim SelectedKoleksi As List(Of String) = ClassJenisBarang.GetDataKoleksiByIDDatabase(SelectedTableKoleksi)

        ClassJenisBarang.jenisBarangProperty = SelectedKoleksi(1)
        ClassJenisBarang.satuanProperty = SelectedKoleksi(2)
        ClassJenisBarang.catatanProperty = SelectedKoleksi(3)


        Dim EditJenisBarang As New EditJenisBarang
        EditJenisBarang.Show()

    End Sub

    Private Sub BtnHapusJenis_Click(sender As Object, e As EventArgs) Handles BtnHapusJenis.Click
        Dim HapusJenisBarang As New HapusJenisBarang
        HapusJenisBarang.Show()
        'Me.Hide()
    End Sub

    Private Sub DataGridJenisBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJenisBarang.CellClick
        'Selectedtablekolesi = DataGridJenisBarang.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DataGridJenisBarang.Rows(index)

        SelectedTableKoleksi = SelectedRow.Cells(0).Value
        SelectedTableKoleksiJenis = SelectedRow.Cells(1).Value


    End Sub
End Class