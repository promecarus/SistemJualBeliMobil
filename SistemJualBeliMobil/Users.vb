Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Users
    Private username As String
    Private email As String
    Private password As String

    Private user_Account As New ArrayList()
    Private tripleDes As New TripleDESCryptoServiceProvider

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "db_sistem_jual_beli_mobil"

    Public Property usernameProperty() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Property emailProperty() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property

    Public Property passwordProperty() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

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

    Public Sub AddUsersDatabase(username_regist As String, email_regist As String, password_regist As String)
        Dim query = "INSERT INTO users(username, email, password) VALUE('" & username_regist & "', '" & email_regist & "', '" & EncryptMD5(password_regist) & "')"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function CheckAuthenticationDatabase(username_login As String, password_login As String) As List(Of String)
        Dim query = "SELECT id_user, username FROM users WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"
        Return FormSignIn.db.ExecuteGetOneRow(query, 2)
    End Function

    Public Function ValidateUser(username As String)
        Try
            Dim result

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryValidation = "SELECT id_user, username FROM USERS
                                   WHERE username='" & username & "'"

            sqlCommand.CommandText = queryValidation
            Debug.WriteLine(queryValidation)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result = True
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

    Public Function ValidateEmail(email As String)
        Try
            Dim result

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryValidation = "SELECT id_user, email FROM USERS
                                   WHERE email='" & email & "'"

            sqlCommand.CommandText = queryValidation
            Debug.WriteLine(queryValidation)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result = True
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
End Class
