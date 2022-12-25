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
        Dim query = "SELECT id_jenis, jenis FROM jenis_mobil WHERE id_jenis='" & ID & "'"
        Return FormSignIn.db.ExecuteGetOneRow(query, 2)
    End Function

    Public Sub UpdateDataJenisMobilByIDDatabase(
        ID As Integer,
        jenis As String
    )
        Dim query = "UPDATE jenis_mobil SET " & "jenis='" & jenis & "' " & "WHERE id_jenis='" & ID & "'"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Sub DeleteDataJenisMobilByIDDatabase(ID As Integer)
        Dim query = "DELETE FROM jenis_mobil " & "WHERE id_jenis='" & ID & "'"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function ListDataJenisMobil() As DataTable
        Dim query = "SELECT id_jenis, jenis FROM jenis_mobil"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function
End Class
