Imports MySql.Data.MySqlClient
Imports System.Text

Public Class Barang

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

    Private nama_barang As String
    Private jenis_barang As String
    Private deskripsi_barang As String
    Private tahunpembuatan_barang As String
    Private tanggalmasuk_barang As String
    Private terakhir_pembaharuan As String
    Private lokasipenyimpanan_barang As String
    Private stock_barang As Integer
    Private gambar_barang As String
    Private kualitas_barang As String
    Private target_pasar As New List(Of String)

    Public Property NamaBarangProperty() As String
        Get
            Return nama_barang
        End Get
        Set(ByVal value As String)
            nama_barang = value
        End Set
    End Property

    Public Property JenisBarangProperty() As String
        Get
            Return jenis_barang
        End Get
        Set(ByVal value As String)
            jenis_barang = value
        End Set
    End Property

    Public Property DeskripsiProperty() As String
        Get
            Return deskripsi_barang
        End Get
        Set(ByVal value As String)
            deskripsi_barang = value
        End Set
    End Property

    Public Property TahunPembuatanProperty() As String
        Get
            Return tahunpembuatan_barang
        End Get
        Set(ByVal value As String)
            tahunpembuatan_barang = value
        End Set
    End Property

    Public Property TanggalMasukBarangProperty() As String
        Get
            Return tanggalmasuk_barang
        End Get
        Set(ByVal value As String)
            tanggalmasuk_barang = value
        End Set
    End Property

    Public Property TerakhirPembaharuanProperty() As String
        Get
            Return terakhir_pembaharuan
        End Get
        Set(ByVal value As String)
            terakhir_pembaharuan = value
        End Set
    End Property

    Public Property LokasiPenyimpananProperty() As String
        Get
            Return lokasipenyimpanan_barang
        End Get
        Set(ByVal value As String)
            lokasipenyimpanan_barang = value
        End Set
    End Property

    Public Property StockBarangProperty() As Integer
        Get
            Return stock_barang
        End Get
        Set(ByVal value As Integer)
            stock_barang = value
        End Set
    End Property

    Public Property GambarBarangProperty() As String
        Get
            Return gambar_barang
        End Get
        Set(ByVal value As String)
            gambar_barang = value
        End Set
    End Property

    Public Property KualitasProperty() As String
        Get
            Return kualitas_barang
        End Get
        Set(ByVal value As String)
            kualitas_barang = value
        End Set
    End Property

    Public Function AddTargetPasar(value As String)
        target_pasar.Add(value)
        Return ""
    End Function

    Public ReadOnly Property getTargetPasar() As List(Of String)
        Get
            Return target_pasar
        End Get
    End Property

    Public Function resetTargetPasar()
        target_pasar.Clear()
        Return ""
    End Function

    Public Function GetDataKatalogDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang AS 'ID Barang',
                                  b.barang AS 'Nama Barang',
                                  j.jenis_barang AS 'Jenis Barang',
                                  j.satuan AS 'Satuan',
                                  b.stock AS 'Stock',
                                  b.tahun_pembuatan AS 'Tahun Produksi',
                                  b.tanggal_masuk_barang AS 'Tanggal Masuk',
                                  b.tanggal_terakhir_diperbarui AS 'Pembaharuan Terakhir',
                                  b.lokasi_penyimpanan AS 'Lokasi Penyimpanan',
                                  b.kualitas AS 'Kualitas'
                                  FROM barang AS b
                                  JOIN jenis_barang AS j ON j.id_jenis_barang = b.Id_jenis_barang"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKatalogDatabase(JenisBarang As String,
                                        namaBarang As String,
                                        stockBarang As Integer,
                                        gambarBarang As String,
                                        deskripsiBarang As String,
                                        tahunPembuatanBarang As String,
                                        tanggalMasukBarang As Date,
                                        tanggalPembaharuan As Date,
                                        lokasiBarang As String,
                                        kualitasBarang As String,
                                        targetPasarBarang As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO BARANG(Id_jenis_barang, barang, stock, dir_gambar_barang, deskripsi, tahun_pembuatan, tanggal_masuk_barang, tanggal_terakhir_diperbarui, lokasi_penyimpanan, kualitas, target_pasar) 
                        VALUE((SELECT id_jenis_barang
                        FROM jenis_barang AS j
                        WHERE jenis_barang='" & JenisBarang & "'), '" _
                        & namaBarang & "', '" _
                        & stockBarang & "', '" _
                        & gambarBarang & "', '" _
                        & deskripsiBarang & "', '" _
                        & tahunPembuatanBarang & "', '" _
                        & tanggalMasukBarang.ToString("yyyy/MM/dd") & "', '" _
                        & tanggalPembaharuan.ToString("yyyy/MM/dd") & "', '" _
                        & lokasiBarang & "', '" _
                        & kualitasBarang & "', '" _
                        & targetPasarBarang & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

        Return ""
    End Function

    Public Function GetDataKatalogByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang,
                                  j.jenis_barang,
                                  b.barang,
                                  b.stock,
                                  b.dir_gambar_barang,
                                  b.deskripsi,
                                  b.tahun_pembuatan,
                                  b.tanggal_masuk_barang,
                                  b.tanggal_terakhir_diperbarui,
                                  b.lokasi_penyimpanan,
                                  b.kualitas,
                                  b.target_pasar
                                  FROM barang AS b
                                  JOIN jenis_barang AS j ON j.id_jenis_barang = b.Id_jenis_barang
                                  WHERE b.id_barang='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKatalogByIDDatabase(ID As Integer,
                                        JenisBarang As String,
                                        namaBarang As String,
                                        stockBarang As Integer,
                                        gambarBarang As String,
                                        deskripsiBarang As String,
                                        tahunPembuatanBarang As String,
                                        tanggalMasukBarang As String,
                                        terakhirPembaharuan As String,
                                        lokasiBarang As String,
                                        kualitasBarang As String,
                                        targetPasarBarang As String)


        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE barang SET " &
                        "Id_jenis_barang= (SELECT id_jenis_barang 
                                           FROM jenis_barang AS j
                                           WHERE jenis_barang='" & JenisBarang & "'), " &
                        "barang='" & namaBarang & "', " &
                        "stock='" & stockBarang & "', " &
                        "dir_gambar_barang='" & gambarBarang & "', " &
                        "deskripsi='" & deskripsiBarang & "', " &
                        "tahun_pembuatan='" & tahunPembuatanBarang & "', " &
                        "tanggal_masuk_barang='" & tanggalMasukBarang & "', " &
                        "tanggal_terakhir_diperbarui='" & terakhirPembaharuan & "', " &
                        "lokasi_penyimpanan='" & lokasiBarang & "', " &
                        "kualitas='" & kualitasBarang & "', " &
                        "target_pasar='" & targetPasarBarang & "' " &
                        "WHERE id_barang='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

        Return ""
    End Function

    Public Function DeleteDataKatalogByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
           + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM barang " &
                "WHERE id_barang= '" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

        Return ""
    End Function

    Public Function GetSUMStockDatabase() As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password=" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT SUM(stock)
                                  FROM barang"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0))
            End While

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception

        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKatalogDatabaseStockDESC() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang AS 'ID Barang',
                                  b.barang AS 'Nama Barang',
                                  j.jenis_barang AS 'Jenis Barang',
                                  j.satuan AS 'Satuan',
                                  b.stock AS 'Stock',
                                  b.tahun_pembuatan AS 'Tahun Produksi',
                                  b.tanggal_masuk_barang AS 'Tanggal Masuk',
                                  b.tanggal_terakhir_diperbarui AS 'Pembaharuan Terakhir',
                                  b.lokasi_penyimpanan AS 'Lokasi Penyimpanan',
                                  b.kualitas AS 'Kualitas'
                                  FROM barang AS b
                                  JOIN jenis_barang AS j ON j.id_jenis_barang = b.Id_jenis_barang
                                  ORDER BY b.stock DESC"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataKatalogDatabaseStockASC() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang AS 'ID Barang',
                                  b.barang AS 'Nama Barang',
                                  j.jenis_barang AS 'Jenis Barang',
                                  j.satuan AS 'Satuan',
                                  b.stock AS 'Stock',
                                  b.tahun_pembuatan AS 'Tahun Produksi',
                                  b.tanggal_masuk_barang AS 'Tanggal Masuk',
                                  b.tanggal_terakhir_diperbarui AS 'Pembaharuan Terakhir',
                                  b.lokasi_penyimpanan AS 'Lokasi Penyimpanan',
                                  b.kualitas AS 'Kualitas'
                                  FROM barang AS b
                                  JOIN jenis_barang AS j ON j.id_jenis_barang = b.Id_jenis_barang
                                  ORDER BY b.stock ASC"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataKatalogDatabaseBySearch(searchNama As String) As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang AS 'ID Barang',
                                  b.barang AS 'Nama Barang',
                                  j.jenis_barang AS 'Jenis Barang',
                                  j.satuan AS 'Satuan',
                                  b.stock AS 'Stock',
                                  b.tahun_pembuatan AS 'Tahun Produksi',
                                  b.tanggal_masuk_barang AS 'Tanggal Masuk',
                                  b.tanggal_terakhir_diperbarui AS 'Pembaharuan Terakhir',
                                  b.lokasi_penyimpanan AS 'Lokasi Penyimpanan',
                                  b.kualitas AS 'Kualitas'
                                  FROM barang AS b
                                  JOIN jenis_barang AS j ON j.id_jenis_barang = b.Id_jenis_barang
                                  WHERE b.barang LIKE '%" & searchNama & "%'"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataJenisDatabase() As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT jenis_barang 
                                 FROM jenis_barang AS j"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataKatalogDatabaseTanggalDESC() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang AS 'ID Barang',
                                  b.barang AS 'Nama Barang',
                                  j.jenis_barang AS 'Jenis Barang',
                                  j.satuan AS 'Satuan',
                                  b.stock AS 'Stock',
                                  b.tahun_pembuatan AS 'Tahun Produksi',
                                  b.tanggal_masuk_barang AS 'Tanggal Masuk',
                                  b.tanggal_terakhir_diperbarui AS 'Pembaharuan Terakhir',
                                  b.lokasi_penyimpanan AS 'Lokasi Penyimpanan',
                                  b.kualitas AS 'Kualitas'
                                  FROM barang AS b
                                  JOIN jenis_barang AS j ON j.id_jenis_barang = b.Id_jenis_barang
                                  ORDER BY b.tanggal_masuk_barang DESC"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataKatalogDatabaseTanggalASC() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang AS 'ID Barang',
                                  b.barang AS 'Nama Barang',
                                  j.jenis_barang AS 'Jenis Barang',
                                  j.satuan AS 'Satuan',
                                  b.stock AS 'Stock',
                                  b.tahun_pembuatan AS 'Tahun Produksi',
                                  b.tanggal_masuk_barang AS 'Tanggal Masuk',
                                  b.tanggal_terakhir_diperbarui AS 'Pembaharuan Terakhir',
                                  b.lokasi_penyimpanan AS 'Lokasi Penyimpanan',
                                  b.kualitas AS 'Kualitas'
                                  FROM barang AS b
                                  JOIN jenis_barang AS j ON j.id_jenis_barang = b.Id_jenis_barang
                                  ORDER BY b.tanggal_masuk_barang ASC"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function


    Public Function GetDataKatalogDatabaseOriginal() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang AS 'ID Barang',
                                  b.barang AS 'Nama Barang',
                                  j.jenis_barang AS 'Jenis Barang',
                                  j.satuan AS 'Satuan',
                                  b.stock AS 'Stock',
                                  b.tahun_pembuatan AS 'Tahun Produksi',
                                  b.tanggal_masuk_barang AS 'Tanggal Masuk',
                                  b.tanggal_terakhir_diperbarui AS 'Pembaharuan Terakhir',
                                  b.lokasi_penyimpanan AS 'Lokasi Penyimpanan',
                                  b.kualitas AS 'Kualitas'
                                  FROM barang AS b
                                  JOIN jenis_barang AS j ON j.id_jenis_barang = b.Id_jenis_barang
                                  WHERE b.kualitas='Original'"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataKatalogDatabasePremium() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang AS 'ID Barang',
                                  b.barang AS 'Nama Barang',
                                  j.jenis_barang AS 'Jenis Barang',
                                  j.satuan AS 'Satuan',
                                  b.stock AS 'Stock',
                                  b.tahun_pembuatan AS 'Tahun Produksi',
                                  b.tanggal_masuk_barang AS 'Tanggal Masuk',
                                  b.tanggal_terakhir_diperbarui AS 'Pembaharuan Terakhir',
                                  b.lokasi_penyimpanan AS 'Lokasi Penyimpanan',
                                  b.kualitas AS 'Kualitas'
                                  FROM barang AS b
                                  JOIN jenis_barang AS j ON j.id_jenis_barang = b.Id_jenis_barang
                                  WHERE b.kualitas='Premium'"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateStockByIDDatabase(ID As Integer,
                                       stockBarang As Integer,
                                       waktuPembaharuan As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE barang SET " &
                       "stock='" & stockBarang & "', " &
                       "tanggal_terakhir_diperbarui='" & waktuPembaharuan & "' " &
                       "WHERE id_barang='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

        Return ""
    End Function
End Class
