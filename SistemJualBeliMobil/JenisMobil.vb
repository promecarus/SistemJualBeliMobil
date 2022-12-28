Public Class JenisMobil
    Private jenis As String

    Public Property jenisProperty() As String
        Get
            Return jenis
        End Get
        Set(ByVal value As String)
            jenis = value
        End Set
    End Property

    Public Sub Add(jenis As String)
        Dim query = "
            INSERT INTO jenis_mobil(jenis)
                VALUES('" & jenis & "')
        "
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function Read() As DataTable
        Dim query = "
            SELECT
                id_jenis AS 'ID',
                jenis AS 'Jenis Mobil'
            FROM jenis_mobil
            ORDER BY id_jenis
        "
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function SearchById(id As Integer) As DataTable
        Dim query = "
            SELECT
                id_jenis AS 'ID',
                jenis AS 'Jenis Mobil'
            FROM jenis_mobil
            WHERE id_jenis='" & id & "'
            ORDER BY id_jenis
        "
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function DetailsById(id As Integer) As List(Of String)
        Dim query = "
            SELECT
                id_jenis,
                jenis
            FROM jenis_mobil
            WHERE id_jenis='" & id & "'
        "
        Return FormSignIn.db.ExecuteGetOneRow(query, 2)
    End Function

    Public Sub Update(id As Integer, jenis As String)
        Dim query = "
            UPDATE jenis_mobil
            SET " & "jenis='" & jenis & "' " & "
            WHERE id_jenis='" & id & "'
        "
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Sub Delete(id As Integer)
        Dim query = "
            DELETE FROM jenis_mobil " & "
            WHERE id_jenis='" & id & "'
        "
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function List() As DataTable
        Dim query = "
            SELECT
                id_jenis,
                jenis
            FROM jenis_mobil
            ORDER BY id_jenis
        "
        Return FormSignIn.db.ExecuteQuery(query)
    End Function
End Class
