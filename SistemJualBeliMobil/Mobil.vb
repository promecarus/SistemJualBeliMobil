Public Class Mobil
    Private id_jenis_mobil As Integer
    Private tipe_mobil As String
    Private tahun_pembuatan As String
    Private kondisi As String
    Private harga As Integer
    Private garansi As Integer
    Private status_terjual As Integer
    Private harga_default As Integer

    Public Property idjenisMobillProperty() As String
        Get
            Return id_jenis_mobil
        End Get
        Set(ByVal value As String)
            id_jenis_mobil = value
        End Set
    End Property

    Public Property tipeMobilProperty() As String
        Get
            Return tipe_mobil
        End Get
        Set(ByVal value As String)
            tipe_mobil = value
        End Set
    End Property

    Public Property tahunPembuatanProperty() As String
        Get
            Return tahun_pembuatan
        End Get
        Set(ByVal value As String)
            tahun_pembuatan = value
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
            Return status_terjual
        End Get
        Set(ByVal value As String)
            status_terjual = value
        End Set
    End Property

    Public Property hargaDefaultProperty() As String
        Get
            Return harga_default
        End Get
        Set(ByVal value As String)
            harga_default = value
        End Set
    End Property

    Public Sub AddDataMobilDatabase(
        id_jenis_mobil As Integer,
        tipe_mobil As String,
        tahun_pembuatan As String,
        kondisi As String,
        harga As Integer,
        garansi As Integer,
        harga_default As Integer
    )
        Dim query = "INSERT INTO mobil(id_jenis_mobil, tipe_mobil, tahun_pembuatan, kondisi, harga, garansi, harga_default) VALUES('" & id_jenis_mobil & "', '" & tipe_mobil & "', '" & tahun_pembuatan & "', '" & kondisi & "', '" & harga & "', '" & garansi & "', '" & harga_default & "')"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function GetDataMobilDatabase() As DataTable
        Dim query = "SELECT id AS 'ID', id_jenis_mobil AS 'ID Jenis Mobil', tipe_mobil AS 'Tipe Mobil', tahun_pembuatan AS 'Tahun Pembuatan', kondisi AS 'Kondisi', harga AS 'Harga', garansi AS 'Garansi', status_terjual AS 'Status Terjual', harga_default AS 'Harga Default' FROM mobil"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataMobilDatabaseTerjual() As DataTable
        Dim query = "SELECT id AS 'ID', id_jenis_mobil AS 'ID Jenis Mobil', tipe_mobil AS 'Tipe Mobil', tahun_pembuatan AS 'Tahun Pembuatan', kondisi AS 'Kondisi', harga AS 'Harga', garansi AS 'Garansi', status_terjual AS 'Status Terjual', harga_default AS 'Harga Default' FROM mobil WHERE status_terjual = 1"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataMobilDatabaseBelumTerjual() As DataTable
        Dim query = "SELECT id AS 'ID', id_jenis_mobil AS 'ID Jenis Mobil', tipe_mobil AS 'Tipe Mobil', tahun_pembuatan AS 'Tahun Pembuatan', kondisi AS 'Kondisi', harga AS 'Harga', garansi AS 'Garansi', status_terjual AS 'Status Terjual', harga_default AS 'Harga Default' FROM mobil WHERE status_terjual = 0"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataMobilDatabaseSearchNone(ID As Integer) As DataTable
        Dim query = "SELECT id AS 'ID', id_jenis_mobil AS 'ID Jenis Mobil', tipe_mobil AS 'Tipe Mobil', tahun_pembuatan AS 'Tahun Pembuatan', kondisi AS 'Kondisi', harga AS 'Harga', garansi AS 'Garansi', status_terjual AS 'Status Terjual', harga_default AS 'Harga Default' FROM mobil WHERE id='" & ID & "'"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataMobilDatabaseSearchTerjual(ID As Integer) As DataTable
        Dim query = "SELECT id AS 'ID', id_jenis_mobil AS 'ID Jenis Mobil', tipe_mobil AS 'Tipe Mobil', tahun_pembuatan AS 'Tahun Pembuatan', kondisi AS 'Kondisi', harga AS 'Harga', garansi AS 'Garansi', status_terjual AS 'Status Terjual', harga_default AS 'Harga Default' FROM mobil WHERE id='" & ID & "' AND status_terjual=1"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataMobilDatabaseSearchBelumTerjual(ID As Integer) As DataTable
        Dim query = "SELECT id AS 'ID', id_jenis_mobil AS 'ID Jenis Mobil', tipe_mobil AS 'Tipe Mobil', tahun_pembuatan AS 'Tahun Pembuatan', kondisi AS 'Kondisi', harga AS 'Harga',garansi AS 'Garansi', status_terjual AS 'Status Terjual', harga_default AS 'Harga Default' FROM mobil WHERE id='" & ID & "' AND status_terjual=0"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function

    Public Function GetDataMobilByIDDatabase(ID As Integer) As List(Of String)
        Dim query = "SELECT id, id_jenis_mobil, tipe_mobil, tahun_pembuatan, kondisi, harga, garansi, status_terjual, harga_default FROM mobil WHERE id='" & ID & "'"
        Return FormSignIn.db.ExecuteGetOneRow(query, 9)
    End Function

    Public Sub UpdateDataMobilByIDDatabase(
        ID As Integer,
        id_jenis_mobil As Integer,
        tipe_mobil As String,
        tahun_pembuatan As String,
        kondisi As String,
        garansi As String,
        harga_default As Integer
    )
        Dim query = "UPDATE mobil SET " & "id_jenis_mobil='" & id_jenis_mobil & "', " & "tipe_mobil='" & tipe_mobil & "', " & "tahun_pembuatan='" & tahun_pembuatan & "', " & "kondisi='" & kondisi & "', " & "garansi='" & garansi & "', " & "harga_default='" & harga_default & "' " & "WHERE id='" & ID & "'"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Sub DeleteDataMobilByIDDatabase(ID As Integer)
        Dim query = "DELETE FROM mobil " & "WHERE id='" & ID & "'"
        FormSignIn.db.ExecuteNonQuery(query)
    End Sub

    Public Function ListDataMobil() As DataTable
        Dim query = "SELECT id FROM mobil WHERE status_terjual=FALSE ORDER BY id"
        Return FormSignIn.db.ExecuteQuery(query)
    End Function
End Class
