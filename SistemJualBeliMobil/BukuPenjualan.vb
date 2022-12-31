Public Class BukuPenjualan
    Private db As New Database
    Private query As String
    Private idMobil As Integer
    Private idPembeli As Integer
    Private hargaTerjual As Integer
    Private tanggalPenjualan As String

    Public Property idMobilProperty() As String
        Get
            Return idMobil
        End Get
        Set(ByVal value As String)
            idMobil = value
        End Set
    End Property

    Public Property idPembeliProperty() As String
        Get
            Return idPembeli
        End Get
        Set(ByVal value As String)
            idPembeli = value
        End Set
    End Property

    Public Property hargaTerjualProperty() As String
        Get
            Return hargaTerjual
        End Get
        Set(ByVal value As String)
            hargaTerjual = value
        End Set
    End Property

    Public Property tanggalPenjualanProperty() As String
        Get
            Return tanggalPenjualan
        End Get
        Set(ByVal value As String)
            tanggalPenjualan = value
        End Set
    End Property

    Public Sub Add(idMobil As Integer, idPembeli As Integer, hargaTerjual As Integer, tanggalPenjualan As Date)
        query = "
            INSERT INTO buku_penjualan(id_mobil, id_pembeli, harga_terjual, tanggal_penjualan)
                VALUES('" & idMobil & "', '" & idPembeli & "', '" & hargaTerjual & "', '" & tanggalPenjualan.ToString("yyyy/MM/dd") & "')
        "
        db.ExecuteNonQuery(query)
        query = "
            UPDATE mobil
            SET
                status_terjual=TRUE,
                harga=" & hargaTerjual & "
            WHERE id=" & idMobil & "
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Function Read() As DataTable
        query = "
            SELECT
	            a.id_penjualan 'ID',
	            a.id_mobil AS 'ID Mobil',
	            b.nama AS 'Nama Pembeli',
	            a.harga_terjual AS 'Harga Terjual',
	            a.tanggal_penjualan AS 'Tanggal Penjualan'
            FROM buku_penjualan AS a
            JOIN pembeli AS b
	            ON a.id_pembeli=b.id_pembeli
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function SearchById(id As Integer) As DataTable
        query = "
            SELECT
	            a.id_penjualan AS 'ID',
	            a.id_mobil AS 'ID Mobil',
	            b.nama AS 'Nama Pembeli',
	            a.harga_terjual AS 'Harga Terjual',
	            a.tanggal_penjualan AS 'Tanggal Penjualan'
            FROM buku_penjualan AS a
            JOIN pembeli AS b
	            ON a.id_pembeli=b.id_pembeli
            WHERE id_penjualan='" & id & "'
        "
        Return db.ExecuteQuery(query)
    End Function

    Public Function DetailsById(id As Integer) As List(Of String)
        query = "
            SELECT
                id_penjualan,
                id_mobil,
                id_pembeli,
                harga_terjual,
                tanggal_penjualan
            FROM buku_penjualan
            WHERE id_penjualan='" & id & "'
        "
        Return db.ExecuteGetOneRow(query, 5)
    End Function

    Public Sub Update(id As Integer, idMobil As Integer, idPembeli As Integer, hargaTerjual As Integer, tanggalPenjualan As Date)
        query = "
            UPDATE buku_penjualan
            SET " & "
                id_mobil='" & idMobil & "', " & "
                id_pembeli='" & idPembeli & "', " & "
                harga_terjual='" & hargaTerjual & "', " & "
                tanggal_penjualan='" & tanggalPenjualan.ToString("yyyy/MM/dd") & "' " & "
            WHERE id_penjualan='" & id & "'
        "
        db.ExecuteNonQuery(query)
    End Sub

    Public Sub Delete(id As Integer)
        query = "
            DELETE FROM buku_penjualan" & "
            WHERE id_penjualan='" & id & "'
        "
        db.ExecuteNonQuery(query)
    End Sub
End Class