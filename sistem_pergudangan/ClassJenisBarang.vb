Imports MySql.Data.MySqlClient
Imports System.Text

Public Class ClassJenisBarang
    Private jenisBarang As String
    Private satuan As String
    Private catatan As String
    Private maxCatatan As Integer = 100

    Private KoleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

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

    Public Function AddKoleksiDataTable(jenis_barang As String,
                                        satuan As String,
                                        catatan As String)

        KoleksiDataTable.Add({jenisBarang,
                             satuan,
                             catatan})

    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        KoleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property GetKoleksiDataTable() As ArrayList
        Get
            Return KoleksiDataTable
        End Get

    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim Arr() As String = value.Split("|")

        Dim vals As List(Of String) = Arr.ToList
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang AS 'ID',
                                  jenis_barang AS 'jenis_barang',
                                  satuan AS 'satuan',
                                  catatan AS 'catatan'
                                  FROM jenis_barang"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(jenis_barang As String,
                                           satuan As String,
                                           Catatan As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jenis_barang(jenis_barang, satuan, catatan) VALUE('" _
            & jenis_barang & "','" _
            & satuan & "','" _
            & Catatan & "')"

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

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim Result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang,
                                    jenis_barang,
                                    satuan,
                                    catatan
                                    FROM jenis_barang
                                    Where id_jenis_barang ='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            Result.Add(sqlRead.GetString(0).ToString())
            Result.Add(sqlRead.GetString(1).ToString())
            Result.Add(sqlRead.GetString(2).ToString())
            Result.Add(sqlRead.GetString(3).ToString())
            'Result.Add(sqlRead.GetString(4).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return Result

    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  jenis_barang As String,
                                                  satuann As String,
                                                  catatann As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE jenis_barang SET " &
                       "jenis_barang='" & jenis_barang & "', " &
                       "satuan='" & satuann & "', " &
                       "catatan='" & catatann & "' " &
                       "WHERE id_jenis_barang='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try



    End Function






End Class


