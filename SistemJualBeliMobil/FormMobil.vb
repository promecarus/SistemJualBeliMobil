Public Class FormMobil

    Public Shared Mobil As Mobil
    Public Shared SelectedTableMobil
    Public Shared SelectedTableMobilNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Mobil = New Mobil()
        ReloadDataTableDatabase()

    End Sub

    'Private Sub ResetGrid()
    '    Dim index As Integer = 0
    '    Dim selectedRow As DataGridViewRow
    '    selectedRow = DataGridMobil.Rows(index)
    '    SelectedTableMobil = selectedRow.Cells(0).Value
    'End Sub

    Public Sub ReloadDataTableDatabase()
        DataGridMobil.DataSource = Mobil.GetDataMobilDatabase()
    End Sub

    Private Sub FormMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub FormMobil_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'ResetGrid()
    End Sub

    Private Sub DataGridMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMobil.CellClick
        If (e.RowIndex >= 0) Then
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridMobil.Rows(index)

            SelectedTableMobil = selectedRow.Cells(0).Value
            SelectedTableMobilNama = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim MobilTambah = New FormMobilTambah()
        MobilTambah.Show()

        'ResetGrid()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            Dim selectedMobil As List(Of String) = Mobil.GetDataMobilByIDDatabase(SelectedTableMobil)

            Mobil.idjenisMobillProperty = selectedMobil(1)
            Mobil.tipeMobilProperty = selectedMobil(2)
            Mobil.tahunPembuatanProperty = selectedMobil(3)
            Mobil.kondisiProperty = selectedMobil(4)
            Mobil.garansiProperty = selectedMobil(6)
            Mobil.hargaDefaultProperty = selectedMobil(8)

            'ResetGrid()

            Dim MobilEdit = New FormMobilEdit()
            MobilEdit.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'ResetGrid()

        Dim MobilHapus = New FormMobilHapus()
        MobilHapus.Show()
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs)
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIndex_Click(sender As Object, e As EventArgs)
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ManageUserBtn_Click(sender As Object, e As EventArgs) Handles ManageUserBtn.Click
        FormPembeli.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIndex_Click_1(sender As Object, e As EventArgs) Handles BtnIndex.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub TransactionBtn_Click_1(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormJenisMobil.Show()
        Me.Hide()
    End Sub
End Class