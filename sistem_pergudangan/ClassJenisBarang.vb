Public Class ClassJenisBarang
    Private jenisBarang As String
    Private satuan As String

    Public Property jenisBarangProperty() As String
        Get
            Return jenisBarang
        End Get
        Set(ByVal value As String)
            jenisBarang = value
        End Set
    End Property

    Public Property satuanProperty() As String
        Get
            Return satuan
        End Get
        Set(ByVal value As String)
            satuan = value
        End Set
    End Property






End Class


