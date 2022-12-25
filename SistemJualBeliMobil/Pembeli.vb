Public Class Pembeli
    Private nik As String
    Private nama As String
    Private alamat As String

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

    Public Sub AddDataPembeliDatabase(
        nik As String,
        nama As String,
        alamat As String
    )
        Dim query = "INSERT INTO PEMBELI(nik, nama, alamat) VALUES('" & nik & "', '" & nama & "', '" & alamat & "')"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function GetDataPembeliDatabase() As DataTable
        Dim query = "SELECT id_pembeli AS 'ID', nik AS 'NIK', nama AS 'Nama', alamat AS 'Alamat' FROM pembeli"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataPembeliDatabaseSearch(ID As Integer) As DataTable
        Dim query = "SELECT id_pembeli AS 'ID', nik AS 'NIK', nama AS 'Nama', alamat AS 'Alamat' FROM pembeli WHERE id_pembeli='" & ID & "'"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataPembeliByIDDatabase(ID As Integer) As List(Of String)
        Dim query = "SELECT id_pembeli, nik, nama, alamat FROM pembeli WHERE id_pembeli='" & ID & "'"
        Return FormSignIn.db.ExecuteGetOneRow(query, 4)
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
