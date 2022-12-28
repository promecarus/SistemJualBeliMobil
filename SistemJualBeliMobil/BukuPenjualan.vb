Public Class BukuPenjualan
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

    Public Sub AddDataBukuPenjualanDatabase(
        id_mobil As Integer,
        id_pembeli As Integer,
        harga_terjual As Integer,
        tanggal_penjualan As Date
    )
        Dim query = "INSERT INTO buku_penjualan(id_mobil, id_pembeli, harga_terjual, tanggal_penjualan) VALUES('" & id_mobil & "', '" & id_pembeli & "', '" & harga_terjual & "', '" & tanggal_penjualan.ToString("yyyy/MM/dd") & "')"
        FormSignIn.db.ExecuteNonQuery(query)
        query = "UPDATE mobil SET status_terjual=TRUE, harga=" & harga_terjual & " WHERE id=" & id_mobil
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function GetDataBukuPenjualanDatabase() As DataTable
        Dim query = "
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
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataBukuPenjualanDatabaseSearch(ID As Integer) As DataTable
        Dim query = "
            SELECT
	            a.id_penjualan AS 'ID',
	            a.id_mobil AS 'ID Mobil',
	            b.nama AS 'Nama Pembeli',
	            a.harga_terjual AS 'Harga Terjual',
	            a.tanggal_penjualan AS 'Tanggal Penjualan'
            FROM buku_penjualan AS a
            JOIN pembeli AS b
	            ON a.id_pembeli=b.id_pembeli
            WHERE id_penjualan='" & ID & "'
        "
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataBukuPenjualanByIDDatabase(ID As Integer) As List(Of String)
        Dim query = "SELECT id_penjualan, id_mobil, id_pembeli, harga_terjual, tanggal_penjualan FROM buku_penjualan WHERE id_penjualan='" & ID & "'"
        Return FormSignIn.db.ExecuteGetOneRow(query, 5)
    End Function

    Public Sub UpdateDataBukuPenjualanByIDDatabase(
        ID As Integer,
        id_mobil As Integer,
        id_pembeli As Integer,
        harga_terjual As Integer,
        tanggal_penjualan As Date
     )
        Dim query = "UPDATE buku_penjualan SET " & "id_mobil='" & id_mobil & "', " & "id_pembeli='" & id_pembeli & "', " & "harga_terjual='" & harga_terjual & "', " & "tanggal_penjualan='" & tanggal_penjualan.ToString("yyyy/MM/dd") & "' " & "WHERE id_penjualan='" & ID & "'"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Sub DeleteDataBukuPenjualanByIDDatabase(ID As Integer)
        Dim query = "DELETE FROM buku_penjualan " & "WHERE id_penjualan='" & ID & "'"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub
End Class