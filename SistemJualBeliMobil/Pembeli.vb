Imports MySql.Data.MySqlClient

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

    Public Function AddDataPembeliDatabase(
        nik As String,
        nama As String,
        alamat As String
    )
        Dim query = "INSERT INTO PEMBELI(nik, nama, alamat) VALUES('" & nik & "', '" & nama & "', '" & alamat & "')"
        FormSignIn.db.ExecuteNonQuery(query)
    End Function

    Public Function GetDataPembeliDatabase() As DataTable
        Dim query = "SELECT id_pembeli AS 'ID', nik AS 'NIK', nama AS 'Nama', alamat AS 'Alamat' FROM pembeli"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataPembeliDatabaseSearch(ID As Integer) As DataTable
        Dim query = "SELECT id_pembeli AS 'ID', nik AS 'NIK', nama AS 'Nama', alamat AS 'Alamat' FROM pembeli WHERE id_pembeli='" & ID & "'"
        Return FormSignIn.db.ExecuteQuery(query)
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

    Public Sub UpdateDataPembeliByIDDatabase(
        ID As Integer,
        nik As String,
        nama As String,
        alamat As String
     )
        Dim query = "UPDATE pembeli SET " & "nik='" & nik & "', " & "nama='" & nama & "', " & "alamat='" & alamat & "' " & "WHERE id_pembeli='" & ID & "'"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Sub DeleteDataPembeliByIDDatabase(ID As Integer)
        Dim query = "DELETE FROM pembeli " & "WHERE id_pembeli='" & ID & "'"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function ListDataPembeli() As DataTable
        Dim query = "SELECT id_pembeli, nama FROM pembeli"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function
End Class
