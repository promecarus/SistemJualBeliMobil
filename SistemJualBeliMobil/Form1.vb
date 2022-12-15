Public Class Form1
    Private Sub ButtonFormSignInAdmin_Click(sender As Object, e As EventArgs) Handles ButtonFormSignInAdmin.Click
        FormSignInAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormSignUpAdmin_Click(sender As Object, e As EventArgs) Handles ButtonFormSignUpAdmin.Click
        FormSignUpAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormSignInUser_Click(sender As Object, e As EventArgs) Handles ButtonFormSignInUser.Click
        FormSignInUser.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormSignUpUser_Click(sender As Object, e As EventArgs) Handles ButtonFormSignUpUser.Click
        FormSignUpUser.Show()
        Me.Hide()
    End Sub
End Class
