Public Class FormJenisMobilHapus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblJenisMobil.Text = FormJenisMobil.SelectedTableJenisMobilNama

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        FormJenisMobil.JenisMobil.DeleteDataJenisMobilByIDDatabase(FormJenisMobil.SelectedTableJenisMobil)

        Me.Close()
    End Sub

    'Private Sub FormJenisMobilHapus_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    Form1.Show()
    'End Sub
End Class