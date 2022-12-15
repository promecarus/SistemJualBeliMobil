Public Class Form1
    Private Sub ButtonFormSignIn_Click(sender As Object, e As EventArgs) Handles ButtonFormSignIn.Click
        FormSignIn.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormSignUp_Click(sender As Object, e As EventArgs) Handles ButtonFormSignUp.Click
        FormSignUp.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormJenisMobil_Click(sender As Object, e As EventArgs) Handles ButtonFormJenisMobil.Click
        FormJenisMobil.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormTambahJenisMobil_Click(sender As Object, e As EventArgs) Handles ButtonFormTambahJenisMobil.Click
        FormJenisMobilTambah.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormEditJenisMobil_Click(sender As Object, e As EventArgs) Handles ButtonFormEditJenisMobil.Click
        FormJenisMobilEdit.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormHapusJenisMobil_Click(sender As Object, e As EventArgs) Handles ButtonFormHapusJenisMobil.Click
        FormJenisMobilHapus.Show()
        Me.Hide()
    End Sub
End Class
