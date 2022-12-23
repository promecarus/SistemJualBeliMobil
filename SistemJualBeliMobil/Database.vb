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
End Class
