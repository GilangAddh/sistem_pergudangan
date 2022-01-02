Public Class ClassJenisBarang
    Private jenisBarang As String
    Private satuan As String
    Private catatan As String
    Private maxCatatan As Integer = 255

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

    Public Property catatanProperty() As String
        Get
            Return catatan
        End Get
        Set(ByVal value As String)
            catatan = value
        End Set
    End Property

    Public Property maxCatatanroperty() As Integer
        Get
            Return maxCatatan
        End Get
        Set(ByVal value As Integer)
            maxCatatan = value
        End Set
    End Property





End Class


