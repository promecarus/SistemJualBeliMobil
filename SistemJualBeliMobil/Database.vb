Imports MySql.Data.MySqlClient

Public Class Database
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "db_sistem_jual_beli_mobil"

    Private connection As New MySqlConnection("server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database)
    Private command As New MySqlCommand

    Public Sub New()
        command.Connection = connection
    End Sub

    Public Function ExecuteQuery(query As String) As DataTable
        Dim dataTable As New DataTable()

        Try
            connection.Open()
            command.CommandText = query
            dataTable.Load(command.ExecuteReader())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try

        Return dataTable
    End Function

    Public Sub ExecuteNonQuery(query As String)
        Try
            connection.Open()
            command.CommandText = query
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub
End Class
