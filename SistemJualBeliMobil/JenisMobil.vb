Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class JenisMobil
    Private jenis As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "db_sistem_jual_beli_mobil"

    Public Property jenisProperty() As String
        Get
            Return jenis
        End Get
        Set(ByVal value As String)
            jenis = value
        End Set
    End Property

    Public Sub AddDataJenisMobilDatabase(jenis As String)
        Dim query = "INSERT INTO jenis_mobil(jenis) VALUES('" & jenis & "')"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function GetDataJenisMobilDatabase() As DataTable
        Dim query = "SELECT id_jenis AS 'ID', jenis AS 'Jenis Mobil' FROM jenis_mobil ORDER BY id_jenis"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataJenisMobilDatabaseSearch(ID As Integer) As DataTable
        Dim query = "SELECT id_jenis AS 'ID', jenis AS 'Jenis Mobil' FROM jenis_mobil WHERE id_jenis='" & ID & "' ORDER BY id_jenis"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataJenisMobilByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis,
                                  jenis
                                  FROM JENIS_MOBIL
                                  WHERE id_jenis='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
        End While

        sqlRead.Close()

        dbConn.Close()

        Return result
    End Function

    Public Function UpdateDataJenisMobilByIDDatabase(ID As Integer,
                                                     jenis As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
            + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE JENIS_MOBIL SET " &
                        "jenis='" & jenis & "' " &
                        "WHERE id_jenis='" & ID & "'"

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

    Public Function DeleteDataJenisMobilByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM JENIS_MOBIL " &
                        "WHERE id_jenis='" & ID & "'"

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

    Public Function ListDataJenisMobil() As DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT id_jenis, jenis FROM jenis_mobil"

            Debug.WriteLine(sqlQuery)

            Dim adapter As New MySqlDataAdapter(sqlQuery, dbConn)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dbConn.Close()

            Return dataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
