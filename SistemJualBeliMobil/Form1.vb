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
End Class
