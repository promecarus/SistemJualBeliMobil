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
        Catch ex As MySqlException
            'MessageBox.Show("Error: " + ex.Message)
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
        Catch ex As MySqlException
            'MessageBox.Show("Error: " + ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub

    Public Function ExecuteGetOneRow(query As String, field As Integer) As List(Of String)
        Dim list As New List(Of String)

        Try
            connection.Open()
            command.CommandText = query

            Dim temp = command.ExecuteReader

            While temp.Read
                For i = 0 To field - 1
                    list.Add(temp.GetString(i).ToString())
                Next
            End While

            temp.Close()
        Catch ex As MySqlException
            'MessageBox.Show("Error: " + ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try

        Return list
    End Function

    Public Function CheckAvailability(query As String) As Boolean
        Dim result As Boolean = False

        Try
            connection.Open()
            command.CommandText = query

            Dim temp = command.ExecuteReader

            If temp.HasRows Then
                While temp.Read
                    result = True
                End While
            End If

            temp.Close()
        Catch ex As MySqlException
            'MessageBox.Show("Error: " + ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try

        Return result
    End Function
End Class
