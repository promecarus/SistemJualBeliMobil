Imports System.Security.Cryptography

Public Class Users
    Private db As New Database
    Private query As String
    Private username As String
    Private email As String
    Private password As String

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

    Public Function EncryptMD5(ByVal password As String) As String
        Dim x As New MD5CryptoServiceProvider()
        Dim bs As Byte() = Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New Text.StringBuilder()

        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next

        Return s.ToString()
    End Function

    Public Sub Add(username As String, email As String, password As String)
        query = "
            INSERT INTO users(username, email, password)
                VALUE('" & username & "', '" & email & "', '" & EncryptMD5(password) & "')
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Function Authentication(username As String, password As String) As List(Of String)
        query = "
            SELECT
                id_user,
                username
            FROM users
            WHERE 
                (username='" & username & "' OR email='" & username & "') AND
                password='" & EncryptMD5(password) & "'
        "
        Return db.ExecuteGetOneRow(query, 2)
    End Function

    Public Function AvailabilityUsername(username As String) As Boolean
        query = "
            SELECT username
            FROM users
            WHERE username='" & username & "'"
        Return db.CheckAvailability(query)
    End Function

    Public Function AvailabilityEmail(email As String) As Boolean
        query = "
            SELECT email
            FROM users
            WHERE email='" & email & "'
        "
        Return db.CheckAvailability(query)
    End Function
End Class
