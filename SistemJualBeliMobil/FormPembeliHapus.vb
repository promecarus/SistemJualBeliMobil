Public Class FormPembeliHapus
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelNamaPembeli.Text = FormPembeli.dataPembeli.namaProperty
    End Sub

    Private Sub FormPembeliHapus_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class