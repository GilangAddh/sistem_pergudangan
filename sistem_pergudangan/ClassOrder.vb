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

    Public Function GetDataOrderJoinBarangDatabase(id_barang As Integer) As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT b.id_barang as 'ID Barang',
                                 b.barang as 'Nama Barang',
                                 b.stock as 'Stock',
                                 t.jumlah_order as 'Jumlah Order',
                                 t.status as 'Status'
                                 FROM barang as b
                                 JOIN table_order as t ON b.id_barang = t.id_barang
                                 WHERE b.id_barang ='" & id_barang & "'"

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
        sqlCommand.CommandText = "SELECT id_barang_masuk as 'ID Barang Masuk',
                                 id_order as 'ID Order',
                                 jumlah_masuk as 'Barang Masuk'
                                 FROM barang_masuk"

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
            sqlQuery = "UPDATE table_order SET" &
                       "t.jumlah_order ='" & jumlah_order & "'" &
                       "tanggal_order ='" & tanggal_order & "'" &
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
        sqlCommand.CommandText = "SELECT id_barang as 'ID Barang',
                                 barang as 'Nama Barang',
                                 stock as 'Stock',
                                 tahun_pembuatan as 'Tahun Diproduksi'
                                 FROM barang 
                                 WHERE barang LIKE '%" & barang & "%'"

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

    Public Function AddDataTableOrderDatabase(jumlah_order As Integer,
                                              tanggal_order As Date,
                                              nama_barang As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database =" + database + ";"

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO TABLE_ORDER(id_barang, jumlah_order, tanggal_order)
                       VALUE(( SELECT id_barang  FROM 
                        barang as b WHERE barang ='" & nama_barang & "'), '" _
                        & jumlah_order & "', '" _
                        & tanggal_order.ToString("yyyy/MM/dd") & "')"



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

    Public Function AddDataBarangMasukDatabase(id_order As Integer,
                                              jumlah_masuk As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
           + "password =" + password + ";" + "database =" + database + ";"

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO BARANG_MASUK (id_order, jumlah_masuk)
                       VALUE('" _
                       & id_order & "', '" _
                       & jumlah_masuk & "')"

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

    Public Function GetDataOrderDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_order as 'ID Order',
                                 id_barang as 'ID Barang',
                                 jumlah_order as 'Jumlah Order',
                                 tanggal_order as 'Tanggal Order',
                                 status as 'Status'
                                 FROM table_order"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataOrderJoinBarangMasukBYIDOrderDatabase(id_order As Integer) As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT t.id_order as 'ID Order',
                                 t.id_barang as 'ID Barang',
                                 t.jumlah_order as 'Jumlah Order',
                                 t.tanggal_order as 'Tanggal Order',
                                 t.status as 'Status',
                                 m.id_barang_masuk as 'ID Barang Masuk',
                                 m.jumlah_masuk as 'Jumlah Masuk'
                                 FROM table_order as t
                                 JOIN barang_masuk as m ON t.id_order = m.id_order
                                 WHERE t.id_order ='" & id_order & "'"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function DeleteDataBarangMasukByBarangMasukDatabase(id_barang_masuk As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM barang_masuk " &
                       "WHERE id_barang_masuk ='" & id_barang_masuk & "'"

            Debug.WriteLine(sqlQuery)

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

    Public Function DeleteDataOrderByIDOrderDatabase(id_order As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM table_order " &
                       "WHERE id_order ='" & id_order & "'"

            Debug.WriteLine(sqlQuery)

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
