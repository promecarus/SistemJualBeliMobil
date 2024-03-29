﻿Public Class Pembeli
    Private db As New Database
    Private query As String
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

    Public Sub Add(nik As String, nama As String, alamat As String)
        query = "
            INSERT INTO pembeli(nik, nama, alamat)
                VALUES('" & nik & "', '" & nama & "', '" & alamat & "')
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Function Read() As DataTable
        query = "
            SELECT
                id_pembeli AS 'ID',
                nik AS 'NIK',
                nama AS 'Nama',
                alamat AS 'Alamat'
            FROM pembeli
            ORDER BY id_pembeli
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function SearchById(id As Integer) As DataTable
        query = "
            SELECT
                id_pembeli AS 'ID',
                nik AS 'NIK',
                nama AS 'Nama',
                alamat AS 'Alamat'
            FROM pembeli
            WHERE id_pembeli='" & id & "'
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function DetailsById(id As Integer) As List(Of String)
        query = "
            SELECT
                id_pembeli,
                nik,
                nama,
                alamat
            FROM pembeli
            WHERE id_pembeli='" & id & "'
        "
        Return db.ExecuteGetOneRow(query, 4)
    End Function

    Public Sub Update(id As Integer, nik As String, nama As String, alamat As String)
        query = "
            UPDATE pembeli
            SET " & "
                nik='" & nik & "', " & "
                nama='" & nama & "', " & "
                alamat='" & alamat & "' " & "
            WHERE id_pembeli='" & id & "'
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Sub Delete(id As Integer)
        query = "
            DELETE FROM pembeli " & "
            WHERE id_pembeli='" & id & "'
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Function List() As DataTable
        query = "
            SELECT
                id_pembeli,
                nama
            FROM pembeli
            ORDER BY id_pembeli
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function AvailabilityNik(nik As String) As Boolean
        query = "
            SELECT nik
            FROM pembeli
            WHERE nik='" & nik & "'"
        Return db.CheckAvailability(query)
    End Function
End Class
