Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class Users

    Private TripleDes As New TripleDESCryptoServiceProvider

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

    Private id_user As Integer
    Private dir_foto As String
    Private id_pegawai As Integer
    Private nama_pegawai As String
    Private jabatan As String
    Private kode_akses As String

    Public Property Dir_fotoProperty() As String
        Get
            Return dir_foto
        End Get
        Set(ByVal value As String)
            dir_foto = value
        End Set
    End Property

    Public Property Id_pegawaiProperty() As Integer
        Get
            Return id_pegawai
        End Get
        Set(ByVal value As Integer)
            id_pegawai = value
        End Set
    End Property

    Public Property Nama_pegawaiProperty() As String
        Get
            Return nama_pegawai
        End Get
        Set(ByVal value As String)
            nama_pegawai = value
        End Set
    End Property

    Public Property JabatanProperty() As String
        Get
            Return jabatan
        End Get
        Set(ByVal value As String)
            jabatan = value
        End Set
    End Property

    Public Property Kode_aksesProperty() As String
        Get
            Return kode_akses
        End Get
        Set(ByVal value As String)
            kode_akses = value
        End Set
    End Property

    Public Property UsernameProperty() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property
    Public Property IduserProperty() As String
        Get
            Return id_user
        End Get
        Set(ByVal value As String)
            id_user = value
        End Set
    End Property

    Public Function EncryptData(ByVal plaintext As String) As String

        'Convert the plaintext string to a byte array
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        'Create the stream
        Dim ms As New System.IO.MemoryStream
        'Create the encoder to write to the stream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        'use the crypto stream to write the byte array to stream
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'Convert the encrypted stream to a printable string
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function AddUsersDatabase(username_regist As String,
                                     password_regist As String,
                                     dir_foto As String,
                                     id_pegawai As Integer,
                                     nama_pegawai As String,
                                     jabatan As String,
                                     kode_akses As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
          + "password=" + password + ";" + "database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO USERS( username, password, registered_at, dir_foto, id_pegawai, nama_pegawai, jabatan, kode_akses) VALUE('" _
                        & username_regist & "', '" _
                        & EncryptMD5(password_regist) & "', '" _
                        & today.ToString("yyyy/MM/dd") & "', '" _
                        & dir_foto & "', '" _
                        & id_pegawai & "', '" _
                        & nama_pegawai & "', '" _
                        & jabatan & "', '" _
                        & kode_akses & "')"
            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

        Return ""
    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
          + "password=" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM users
                            WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function CheckAuth(kodeAkses As String, jabatan As String) As String
        Dim validasi As Boolean = False

        If jabatan = "Admin Gudang" Then
            Dim realkodeAkses As String = "22HGX-728MX-BBWX9-7BB8X"

            If String.Compare(kodeAkses, realkodeAkses) = 0 Then
                validasi = True
            End If
        End If

        If jabatan = "Helper Gudang" Then
            Dim realkodeAkses As String = "NMMKJ-6RK4F-KMJVX-8D9MJ"

            If String.Compare(kodeAkses, realkodeAkses) = 0 Then
                validasi = True
            End If
        End If

        If jabatan = "Manajer Gudang" Then
            Dim realkodeAkses As String = "PQCFB-YGXGC-TXB66-DH3VW"

            If String.Compare(kodeAkses, realkodeAkses) = 0 Then
                validasi = True
            End If
        End If

        Return validasi
    End Function

    Public Function AksesPemulihan(username_reset As String, nama_pegawai_reset As String, kode_akses_reset As String) As List(Of String)

        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
          + "password=" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM users
                            WHERE username='" & username_reset & "' AND nama_pegawai='" & nama_pegawai_reset & "' AND kode_akses='" & kode_akses_reset & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0))
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdateDataUserByIDDatabase(ID As Integer,
                                       newPassword As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE users SET " &
                       "password='" & EncryptMD5(newPassword) & "' " &
                       "WHERE id_user='" & ID & "'"

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