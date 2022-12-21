Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Mobil
    Private id_jenis_mobil As Integer
    Private tipe_mobil As String
    Private tahun_pembuatan As String
    Private kondisi As String
    Private harga As Integer
    Private garansi As Integer
    Private status_terjual As Integer
    Private harga_default As Integer

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "db_sistem_jual_beli_mobil"

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

    Public Function AddDataMobilDatabase(id_jenis_mobil As Integer,
                                         tipe_mobil As String,
                                         tahun_pembuatan As String,
                                         kondisi As String,
                                         harga As Integer,
                                         garansi As Integer,
                                         harga_default As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO mobil(id_jenis_mobil, tipe_mobil, tahun_pembuatan, kondisi, harga, garansi, harga_default) VALUES('" _
                        & id_jenis_mobil & "', '" _
                        & tipe_mobil & "', '" _
                        & tahun_pembuatan & "', '" _
                        & kondisi & "', '" _
                        & harga & "', '" _
                        & garansi & "', '" _
                        & harga_default & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataMobilDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  id_jenis_mobil AS 'ID Jenis Mobil',
                                  tipe_mobil AS 'Tipe Mobil',
                                  tahun_pembuatan AS 'Tahun Pembuatan',
                                  kondisi AS 'Kondisi',
                                  harga AS 'Harga',
                                  garansi AS 'Garansi',
                                  status_terjual AS 'Status Terjual',
                                  harga_default AS 'Harga Default'
                                  FROM MOBIL"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function GetDataMobilDatabaseTerjual() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  id_jenis_mobil AS 'ID Jenis Mobil',
                                  tipe_mobil AS 'Tipe Mobil',
                                  tahun_pembuatan AS 'Tahun Pembuatan',
                                  kondisi AS 'Kondisi',
                                  harga AS 'Harga',
                                  garansi AS 'Garansi',
                                  status_terjual AS 'Status Terjual',
                                  harga_default AS 'Harga Default'
                                  FROM MOBIL WHERE status_terjual = 1"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function GetDataMobilDatabaseBelumTerjual() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  id_jenis_mobil AS 'ID Jenis Mobil',
                                  tipe_mobil AS 'Tipe Mobil',
                                  tahun_pembuatan AS 'Tahun Pembuatan',
                                  kondisi AS 'Kondisi',
                                  harga AS 'Harga',
                                  garansi AS 'Garansi',
                                  status_terjual AS 'Status Terjual',
                                  harga_default AS 'Harga Default'
                                  FROM MOBIL WHERE status_terjual = 0"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function GetDataMobilDatabaseSearchNone(ID As Integer) As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  id_jenis_mobil AS 'ID Jenis Mobil',
                                  tipe_mobil AS 'Tipe Mobil',
                                  tahun_pembuatan AS 'Tahun Pembuatan',
                                  kondisi AS 'Kondisi',
                                  harga AS 'Harga',
                                  garansi AS 'Garansi',
                                  status_terjual AS 'Status Terjual',
                                  harga_default AS 'Harga Default'
                                  FROM MOBIL WHERE id='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function GetDataMobilDatabaseSearchTerjual(ID As Integer) As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  id_jenis_mobil AS 'ID Jenis Mobil',
                                  tipe_mobil AS 'Tipe Mobil',
                                  tahun_pembuatan AS 'Tahun Pembuatan',
                                  kondisi AS 'Kondisi',
                                  harga AS 'Harga',
                                  garansi AS 'Garansi',
                                  status_terjual AS 'Status Terjual',
                                  harga_default AS 'Harga Default'
                                  FROM MOBIL WHERE id='" & ID & "' AND status_terjual=1"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function GetDataMobilDatabaseSearchBelumTerjual(ID As Integer) As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  id_jenis_mobil AS 'ID Jenis Mobil',
                                  tipe_mobil AS 'Tipe Mobil',
                                  tahun_pembuatan AS 'Tahun Pembuatan',
                                  kondisi AS 'Kondisi',
                                  harga AS 'Harga',
                                  garansi AS 'Garansi',
                                  status_terjual AS 'Status Terjual',
                                  harga_default AS 'Harga Default'
                                  FROM MOBIL WHERE id='" & ID & "' AND status_terjual=0"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function GetDataMobilByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id,
                                  id_jenis_mobil,
                                  tipe_mobil,
                                  tahun_pembuatan,
                                  kondisi,
                                  harga,
                                  garansi,
                                  status_terjual,
                                  harga_default
                                  FROM MOBIL
                                  WHERE id='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
        End While

        sqlRead.Close()

        dbConn.Close()

        Return result
    End Function

    Public Function UpdateDataMobilByIDDatabase(ID As Integer,
                                                id_jenis_mobil As Integer,
                                                tipe_mobil As String,
                                                tahun_pembuatan As String,
                                                kondisi As String,
                                                garansi As String,
                                                harga_default As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
            + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE MOBIL SET " &
                        "id_jenis_mobil='" & id_jenis_mobil & "', " &
                        "tipe_mobil='" & tipe_mobil & "', " &
                        "tahun_pembuatan='" & tahun_pembuatan & "', " &
                        "kondisi='" & kondisi & "', " &
                        "garansi='" & garansi & "', " &
                        "harga_default='" & harga_default & "' " &
                        "WHERE id='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()

            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataMobilByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM MOBIL " &
                        "WHERE id='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()

            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function ListDataMobil() As DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT id FROM mobil ORDER BY id"

            Debug.WriteLine(sqlQuery)

            Dim adapter As New MySqlDataAdapter(sqlQuery, dbConn)
            Dim table As New DataTable()

            adapter.Fill(table)

            dbConn.Close()

            Return table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
