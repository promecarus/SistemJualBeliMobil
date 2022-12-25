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

    Public Function ValidateUser(username As String) As Boolean
        Dim query = "SELECT username FROM users WHERE username='" & username & "'"
        Return FormSignIn.db.CheckAvailability(query)
    End Function

    Public Function ValidateEmail(email As String) As Boolean
        Dim query = "SELECT email FROM users WHERE email='" & email & "'"
        Return FormSignIn.db.CheckAvailability(query)
    End Function
End Class
