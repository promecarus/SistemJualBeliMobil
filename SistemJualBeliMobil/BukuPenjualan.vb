Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class BukuPenjualan
    Private id_mobil As Integer
    Private id_pembeli As Integer
    Private harga_terjual As Integer
    Private tanggal_penjualan As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "db_sistem_jual_beli_mobil"

    Public Property idMobilProperty() As String
        Get
            Return id_mobil
        End Get
        Set(ByVal value As String)
            id_mobil = value
        End Set
    End Property

    Public Property idPembeliProperty() As String
        Get
            Return id_pembeli
        End Get
        Set(ByVal value As String)
            id_pembeli = value
        End Set
    End Property

    Public Property hargaTerjualProperty() As String
        Get
            Return harga_terjual
        End Get
        Set(ByVal value As String)
            harga_terjual = value
        End Set
    End Property

    Public Property tanggalPenjualanProperty() As String
        Get
            Return tanggal_penjualan
        End Get
        Set(ByVal value As String)
            tanggal_penjualan = value
        End Set
    End Property

    Public Sub AddDataBukuPenjualanDatabase(
        id_mobil As Integer,
        id_pembeli As Integer,
        harga_terjual As Integer,
        tanggal_penjualan As Date
     )
        Dim query = "INSERT INTO BUKU_PENJUALAN(id_mobil, id_pembeli, harga_terjual, tanggal_penjualan) VALUES('" & id_mobil & "', '" & id_pembeli & "', '" & harga_terjual & "', '" & tanggal_penjualan.ToString("yyyy/MM/dd") & "')"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function GetDataBukuPenjualanDatabase() As DataTable
        Dim query = "SELECT id_penjualan AS 'ID', id_mobil AS 'ID Mobil', id_pembeli AS 'ID Pembeli', harga_terjual AS 'Harga Terjual', tanggal_penjualan AS 'Tanggal Penjualan' FROM buku_penjualan"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataBukuPenjualanDatabaseSearch(ID As Integer) As DataTable
        Dim query = "SELECT id_penjualan AS 'ID', id_mobil AS 'ID Mobil', id_pembeli AS 'ID Pembeli', harga_terjual AS 'Harga Terjual', tanggal_penjualan AS 'Tanggal Penjualan' FROM buku_penjualan WHERE id_penjualan='" & ID & "'"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataBukuPenjualanByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_penjualan,
                                  id_mobil,
                                  id_pembeli,
                                  harga_terjual,
                                  tanggal_penjualan
                                  FROM BUKU_PENJUALAN
                                  WHERE id_penjualan='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
        End While

        sqlRead.Close()

        dbConn.Close()

        Return result
    End Function

    Public Function UpdateDataBukuPenjualanByIDDatabase(ID As Integer,
                                                  id_mobil As Integer,
                                                  id_pembeli As Integer,
                                                  harga_terjual As Integer,
                                                  tanggal_penjualan As Date)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
            + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE buku_penjualan SET " &
                        "id_mobil='" & id_mobil & "', " &
                        "id_pembeli='" & id_pembeli & "', " &
                        "harga_terjual='" & harga_terjual & "', " &
                        "tanggal_penjualan='" & tanggal_penjualan.ToString("yyyy/MM/dd") & "' " &
                        "WHERE id_penjualan='" & ID & "'"

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

    Public Function DeleteDataBukuPenjualanByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM buku_penjualan " &
                        "WHERE id_penjualan='" & ID & "'"

            Debug.WriteLine(sqlQuery)

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
End Class