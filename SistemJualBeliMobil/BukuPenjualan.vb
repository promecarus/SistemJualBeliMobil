Public Class BukuPenjualan
    Private id_mobil As Integer
    Private id_pembeli As Integer
    Private harga_terjual As Integer
    Private tanggal_penjualan As String

    Public Property idMobilProperty() As String
        Get
            Return id_mobil
        End Get
        Set(ByVal value As String)
            id_mobil = value
        End Set
    End Property

    Public Property idPembeliProperty() As String
        Get
            Return id_pembeli
        End Get
        Set(ByVal value As String)
            id_pembeli = value
        End Set
    End Property

    Public Property hargaTerjualProperty() As String
        Get
            Return harga_terjual
        End Get
        Set(ByVal value As String)
            harga_terjual = value
        End Set
    End Property

    Public Property tanggalPenjualanProperty() As String
        Get
            Return tanggal_penjualan
        End Get
        Set(ByVal value As String)
            tanggal_penjualan = value
        End Set
    End Property

    Public Sub AddDataBukuPenjualanDatabase(
        id_mobil As Integer,
        id_pembeli As Integer,
        harga_terjual As Integer,
        tanggal_penjualan As Date
     )
        Dim query = "INSERT INTO BUKU_PENJUALAN(id_mobil, id_pembeli, harga_terjual, tanggal_penjualan) VALUES('" & id_mobil & "', '" & id_pembeli & "', '" & harga_terjual & "', '" & tanggal_penjualan.ToString("yyyy/MM/dd") & "')"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function GetDataBukuPenjualanDatabase() As DataTable
        Dim query = "SELECT id_penjualan AS 'ID', id_mobil AS 'ID Mobil', id_pembeli AS 'ID Pembeli', harga_terjual AS 'Harga Terjual', tanggal_penjualan AS 'Tanggal Penjualan' FROM buku_penjualan"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataBukuPenjualanDatabaseSearch(ID As Integer) As DataTable
        Dim query = "SELECT id_penjualan AS 'ID', id_mobil AS 'ID Mobil', id_pembeli AS 'ID Pembeli', harga_terjual AS 'Harga Terjual', tanggal_penjualan AS 'Tanggal Penjualan' FROM buku_penjualan WHERE id_penjualan='" & ID & "'"
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