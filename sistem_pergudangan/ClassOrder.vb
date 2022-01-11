Imports MySql.Data.MySqlClient

Public Class ClassOrder

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

    Private IDBarang As Integer
    Private JumlahOrder As Integer
    Private TanngalOrder As Date
    Private StatusOrder As String
    Private IDOrder As Integer
    Private JumlahMasuk As Integer
    Private namabarang As String
    Private StockBarang As Integer

    Public Property GSStockBarang() As Integer
        Get
            Return StockBarang
        End Get
        Set(ByVal value As Integer)
            StockBarang = value
        End Set
    End Property

    Public Property GSNamaBarang() As String
        Get
            Return namabarang
        End Get
        Set(ByVal value As String)
            namabarang = value
        End Set
    End Property


    Public Property GSIDBarang As Integer
        Get
            Return IDBarang
        End Get
        Set(ByVal value As Integer)
            IDBarang = value
        End Set
    End Property

    Public Property GSJumlahOrder As Integer
        Get
            Return JumlahOrder
        End Get
        Set(ByVal value As Integer)
            JumlahOrder = value
        End Set
    End Property

    Public Property GSTanggalOrder As String
        Get
            Return TanngalOrder
        End Get
        Set(ByVal value As String)
            TanngalOrder = value
        End Set
    End Property

    Public Property GSStatusOrder As String
        Get
            Return StatusOrder
        End Get
        Set(ByVal value As String)
            StatusOrder = value
        End Set
    End Property

    Public Property GSIDOrder As Integer
        Get
            Return IDOrder
        End Get
        Set(ByVal value As Integer)
            IDOrder = value
        End Set
    End Property

    Public Property GSJumlahMasuk As Integer
        Get
            Return JumlahMasuk
        End Get
        Set(ByVal value As Integer)
            JumlahMasuk = value
        End Set
    End Property


    Public Function GetDataBarangDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn

        sqlCommand.CommandText = "SELECT id_barang as 'ID Barang',
                                 barang as 'Nama Barang',
                                 stock as 'Stock',
                                 tahun_pembuatan as 'Tahun Pembuatan'
                                 FROM barang"


        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result



    End Function

    Public Function GetDataOrderJoinBarangDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang as 'ID Barang',
                                 b.barang as 'Nama Barang',
                                 b.stock as 'Stock',
                                 b.tahun_pembuatan as 'Tahun Diproduksi',
                                 t.jumlah_order as 'Jumlah Order',
                                 t.status as 'Status'
                                 FROM barang as b
                                 JOIN table_order as t ON b.id_barang = t.id_barang"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataBarangMasukDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang as 'ID Barang',
                                 m.id_barang_masuk as 'ID Barang Masuk',
                                 t.id_order as 'ID Order',
                                 b.barang as 'Nama Barang',
                                 b.stock as 'Stock',
                                 m.jumlah_masuk as 'Jumlah Barang Masuk',
                                 b.tahun_pembuatan as 'Tahun Diproduksi',
                                 t.jumlah_order as 'Jumlah Order',
                                 t.tanggal_order as 'Tanggal Order',
                                 t.status as 'Status'
                                 FROM table_order as t
                                 JOIN barang as b ON b.id_barang = t.id_barang
                                 JOIN barang_masuk as m ON t.id_order = m.id_order"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataOrderJoinBarangBYIDBarangDatabase(jumlah_order As Integer,
                                                                tanggal_order As Date,
                                                                id_barang As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE table_order SET " &
                       "jumlah_order ='" & jumlah_order & "', " &
                       "tanggal_order ='" & tanggal_order.ToString("yyyy/MM/dd") & "' " &
                       "WHERE id_barang ='" & id_barang & "'"




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
    End Function

    Public Function UpdateDataStatusBarangMasukBYIDOrderDatabase(status As String,
                                                                 id_order As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE table_order SET " &
                       "status ='" & status & "'" &
                       "WHERE id_order ='" & id_order & "'"


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
    End Function

    Public Function GetDataBarangBySearchNamaBarangDatabase(barang As String) As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang as 'ID Barang',
                                 t.id_order as 'ID Order',
                                 b.barang as 'Nama Barang',
                                 b.stock as 'Stock',
                                 b.tahun_pembuatan as 'Tahun Diproduksi',
                                 t.jumlah_order as 'Jumlah Order',
                                 t.status as 'Status'
                                 FROM barang as b
                                 JOIN table_order as t ON b.id_barang = t.id_barang
                                 WHERE b.barang LIKE '%" & barang & "%'"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataStockDatabase(stock As Integer,
                                            id_barang As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE barang SET " &
                "stock ='" & stock & "'" &
                "WHERE id_barang ='" & id_barang & "'"

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
    End Function

    Public Function ClearDataOrderBarangDatabase(barang As String,
                                                 status As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE  status
                       FROM table_order
                        WHERE id_order ='" & barang & "'"

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


    End Function

    Public Function UpdateJumlahMasukBarangBYIDOrder(id_order As Integer,
                                                     jumlah_masuk As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE barang_masuk SET " &
                       "jumlah_masuk ='" & jumlah_masuk & "' " &
                       "WHERE id_order ='" & id_order & "'"


            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception

            Return ex.Message()

        Finally
            dbConn.Dispose()

        End Try


    End Function
End Class
