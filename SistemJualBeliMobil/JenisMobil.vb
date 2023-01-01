Public Class JenisMobil
    Private db As New Database
    Private query As String
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
        query = "
            INSERT INTO jenis_mobil(jenis)
                VALUES('" & jenis & "')
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Function Read() As DataTable
        query = "
            SELECT
                id_jenis AS 'ID',
                jenis AS 'Jenis Mobil'
            FROM jenis_mobil
            ORDER BY id_jenis
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function SearchById(id As Integer) As DataTable
        query = "
            SELECT
                id_jenis AS 'ID',
                jenis AS 'Jenis Mobil'
            FROM jenis_mobil
            WHERE id_jenis='" & id & "'
            ORDER BY id_jenis
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function DetailsById(id As Integer) As List(Of String)
        query = "
            SELECT
                id_jenis,
                jenis
            FROM jenis_mobil
            WHERE id_jenis='" & id & "'
        "
        Return db.ExecuteGetOneRow(query, 2)
    End Function

    Public Sub Update(id As Integer, jenis As String)
        query = "
            UPDATE jenis_mobil
            SET " & "jenis='" & jenis & "' " & "
            WHERE id_jenis='" & id & "'
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Sub Delete(id As Integer)
        query = "
            DELETE FROM jenis_mobil " & "
            WHERE id_jenis='" & id & "'
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Function List() As DataTable
        query = "
            SELECT
                id_jenis,
                jenis
            FROM jenis_mobil
            ORDER BY id_jenis
        "
        Return db.ExecuteQuery(query)
    End Function
End Class
