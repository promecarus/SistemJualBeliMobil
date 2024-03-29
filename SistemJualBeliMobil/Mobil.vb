﻿Public Class Mobil
    Private db As New Database
    Private query As String
    Private idJenisMobil As String
    Private tipeMobil As String
    Private tahunPembuatan As String
    Private kondisi As String
    Private harga As String
    Private garansi As String
    Private statusTerjual As String
    Private hargaDefault As String

    Public Property idJenisMobilProperty() As String
        Get
            Return idJenisMobil
        End Get
        Set(ByVal value As String)
            idJenisMobil = value
        End Set
    End Property

    Public Property tipeMobilProperty() As String
        Get
            Return tipeMobil
        End Get
        Set(ByVal value As String)
            tipeMobil = value
        End Set
    End Property

    Public Property tahunPembuatanProperty() As String
        Get
            Return tahunPembuatan
        End Get
        Set(ByVal value As String)
            tahunPembuatan = value
        End Set
    End Property

    Public Property kondisiProperty() As String
        Get
            Return kondisi
        End Get
        Set(ByVal value As String)
            kondisi = value
        End Set
    End Property

    Public Property hargaProperty() As String
        Get
            Return harga
        End Get
        Set(ByVal value As String)
            harga = value
        End Set
    End Property

    Public Property garansiProperty() As String
        Get
            Return garansi
        End Get
        Set(ByVal value As String)
            garansi = value
        End Set
    End Property

    Public Property statusTerjualProperty() As String
        Get
            Return statusTerjual
        End Get
        Set(ByVal value As String)
            statusTerjual = value
        End Set
    End Property

    Public Property hargaDefaultProperty() As String
        Get
            Return hargaDefault
        End Get
        Set(ByVal value As String)
            hargaDefault = value
        End Set
    End Property

    Public Sub Add(idJenisMobil As Integer, tipeMobil As String, tahunPembuatan As String, kondisi As String, harga As Integer, garansi As Integer, hargaDefault As Integer)
        query = "
            INSERT INTO mobil(id_jenis_mobil, tipe_mobil, tahun_pembuatan, kondisi, harga, garansi, harga_default)
                VALUES('" & idJenisMobil & "', '" & tipeMobil & "', '" & tahunPembuatan & "', '" & kondisi & "', '" & harga & "', '" & garansi & "', '" & hargaDefault & "')
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Function Read() As DataTable
        query = "
            SELECT
                a.id AS 'ID',
                b.jenis AS 'Jenis Mobil',
                a.tipe_mobil AS 'Tipe Mobil',
                a.tahun_pembuatan AS 'Tahun Pembuatan',
                a.kondisi AS 'Kondisi',
                a.harga AS 'Harga',
                a.garansi AS 'Garansi (Hari)',
                a.status_terjual AS 'Status Terjual',
                a.harga_default AS 'Harga Default'
            FROM mobil AS a
            JOIN jenis_mobil AS b
	            ON a.id_jenis_mobil=b.id_jenis
            ORDER BY a.id
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function ReadTerjual() As DataTable
        query = "
            SELECT
                a.id AS 'ID',
                b.jenis AS 'Jenis Mobil',
                a.tipe_mobil AS 'Tipe Mobil',
                a.tahun_pembuatan AS 'Tahun Pembuatan',
                a.kondisi AS 'Kondisi',
                a.harga AS 'Harga',
                a.garansi AS 'Garansi (Hari)',
                a.status_terjual AS 'Status Terjual',
                a.harga_default AS 'Harga Default'
            FROM mobil AS a
            JOIN jenis_mobil AS b
	            ON a.id_jenis_mobil=b.id_jenis
            WHERE a.status_terjual=1
            ORDER BY a.id
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function ReadTerjualBelum() As DataTable
        query = "
            SELECT
                a.id AS 'ID',
                b.jenis AS 'Jenis Mobil',
                a.tipe_mobil AS 'Tipe Mobil',
                a.tahun_pembuatan AS 'Tahun Pembuatan',
                a.kondisi AS 'Kondisi',
                a.harga AS 'Harga',
                a.garansi AS 'Garansi (Hari)',
                a.status_terjual AS 'Status Terjual',
                a.harga_default AS 'Harga Default'
            FROM mobil AS a
            JOIN jenis_mobil AS b
	            ON a.id_jenis_mobil=b.id_jenis
            WHERE a.status_terjual=FALSE
            ORDER BY a.id
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function SearchNone(id As Integer) As DataTable
        query = "
            SELECT
                a.id AS 'ID',
                b.jenis AS 'Jenis Mobil',
                a.tipe_mobil AS 'Tipe Mobil',
                a.tahun_pembuatan AS 'Tahun Pembuatan',
                a.kondisi AS 'Kondisi',
                a.harga AS 'Harga',
                a.garansi AS 'Garansi (Hari)',
                a.status_terjual AS 'Status Terjual',
                a.harga_default AS 'Harga Default'
            FROM mobil AS a
            JOIN jenis_mobil AS b
	            ON a.id_jenis_mobil=b.id_jenis
            WHERE a.id='" & id & "'
            ORDER BY a.id
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function SearchTerjual(id As Integer) As DataTable
        query = "
            SELECT
                a.id AS 'ID',
                b.jenis AS 'Jenis Mobil',
                a.tipe_mobil AS 'Tipe Mobil',
                a.tahun_pembuatan AS 'Tahun Pembuatan',
                a.kondisi AS 'Kondisi',
                a.harga AS 'Harga',
                a.garansi AS 'Garansi (Hari)',
                a.status_terjual AS 'Status Terjual',
                a.harga_default AS 'Harga Default'
            FROM mobil AS a
            JOIN jenis_mobil AS b
	            ON a.id_jenis_mobil=b.id_jenis
            WHERE
                a.id='" & id & "' AND
                a.status_terjual=TRUE
            ORDER BY a.id
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function SearchTerjualBelum(id As Integer) As DataTable
        query = "
            SELECT
                a.id AS 'ID',
                b.jenis AS 'Jenis Mobil',
                a.tipe_mobil AS 'Tipe Mobil',
                a.tahun_pembuatan AS 'Tahun Pembuatan',
                a.kondisi AS 'Kondisi',
                a.harga AS 'Harga',
                a.garansi AS 'Garansi (Hari)',
                a.status_terjual AS 'Status Terjual',
                a.harga_default AS 'Harga Default'
            FROM mobil AS a
            JOIN jenis_mobil AS b
	            ON a.id_jenis_mobil=b.id_jenis
            WHERE
                a.id='" & id & "' AND
                a.status_terjual=FALSE
            ORDER BY a.id
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function DetailsById(id As Integer) As List(Of String)
        query = "
            SELECT
                id,
                id_jenis_mobil,
                tipe_mobil,
                tahun_pembuatan,
                kondisi,
                harga,
                garansi,
                status_terjual,
                harga_default
            FROM mobil
            WHERE id='" & id & "'
        "
        Return db.ExecuteGetOneRow(query, 9)
    End Function

    Public Sub Update(id As Integer, idJenisMobil As Integer, tipeMobil As String, tahunPembuatan As String, kondisi As String, garansi As String, hargaDefault As Integer)
        query = "
            UPDATE mobil
            SET " & "
                id_jenis_mobil='" & idJenisMobil & "', " & "
                tipe_mobil='" & tipeMobil & "', " & "
                tahun_pembuatan='" & tahunPembuatan & "', " & "
                kondisi='" & kondisi & "', " & "
                garansi='" & garansi & "', " & "
                harga_default='" & hargaDefault & "' " & "
            WHERE id='" & id & "'
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Sub Delete(id As Integer)
        query = "
            DELETE FROM mobil " & "
            WHERE id='" & id & "'
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Function ListAdd() As DataTable
        query = "
            SELECT id
            FROM mobil
            WHERE status_terjual=FALSE
            ORDER BY id
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function ListEdit(id As Integer) As DataTable
        query = "
            SELECT id
            FROM mobil
            WHERE
                status_terjual=FALSE OR
                id=" & id & "
            ORDER BY id
        "
        Return db.ExecuteQuery(query)
    End Function
End Class
