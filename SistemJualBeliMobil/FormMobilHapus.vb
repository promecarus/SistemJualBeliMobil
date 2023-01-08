Public Class FormMobilHapus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblMobil.Text = FormMobil.SelectedRowMobil

    End Sub

    Private Sub ButtonYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        FormMobil.Mobil.Delete(FormMobil.SelectedRowMobil)

        MessageBox.Show("Data mobil dengan id " & FormMobil.SelectedRowMobil & " Berhasil dihapus.")

        Me.Hide()
    End Sub

    Private Sub ButtonNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Hide()
    End Sub

End Class