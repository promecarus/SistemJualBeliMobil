Public Class FormPembeliEdit
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextBoxNik.Text = FormPembeli.dataPembeli.nikProperty
        TextBoxNama.Text = FormPembeli.dataPembeli.namaProperty
        RichTextBoxAlamat.Text = FormPembeli.dataPembeli.alamatProperty
    End Sub

    Private Sub FormPembeliEdit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class