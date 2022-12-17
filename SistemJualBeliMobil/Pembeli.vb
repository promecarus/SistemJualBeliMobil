Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Pembeli
    Private nik As String
    Private nama As String
    Private alamat As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "db_sistem_jual_beli_mobil"

    Public Property nikProperty() As String
        Get
            Return nik
        End Get
        Set(ByVal value As String)
            nik = value
        End Set
    End Property

    Public Property namaProperty() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property

    Public Property alamatProperty() As String
        Get
            Return alamat
        End Get
        Set(ByVal value As String)
            alamat = value
        End Set
    End Property

    Public Function AddDataPembeliDatabase(nik As String,
                                              nama As String,
                                              alamat As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO PEMBELI(nik, nama, alamat) VALUES('" _
                        & nik & "', '" _
                        & nama & "', '" _
                        & alamat & "')"

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

    Public Function GetDataPembeliDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_pembeli AS 'ID',
                                  nik AS 'NIK',
                                  nama AS 'Nama',
                                  alamat AS 'Alamat'
                                  FROM PEMBELI"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function GetDataPembeliByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_pembeli,
                                  nik,
                                  nama,
                                  alamat
                                  FROM PEMBELI
                                  WHERE id_pembeli='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While

        sqlRead.Close()

        dbConn.Close()

        Return result
    End Function

    Public Function UpdateDataPembeliByIDDatabase(ID As Integer,
                                                     nik As String,
                                                     nama As String,
                                                     alamat As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
            + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE pembeli SET " &
                        "nik='" & nik & "', " &
                        "nama='" & nama & "', " &
                        "alamat='" & alamat & "' " &
                        "WHERE id_pembeli='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()

            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataPembeliByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM PEMBELI" &
                        "WHERE id_pembeli='" & ID & "'"

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
    End Function

    Public Function ListDataPembeli() As DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT id_pembeli, nama FROM pembeli"

            Debug.WriteLine(sqlQuery)

            Dim adapter As New MySqlDataAdapter(sqlQuery, dbConn)
            Dim table As New DataTable()

            adapter.Fill(table)

            dbConn.Close()

            Return table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
