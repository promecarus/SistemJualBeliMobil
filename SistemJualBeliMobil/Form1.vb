Public Class Form1
    Private Sub ButtonFormSignIn_Click(sender As Object, e As EventArgs) Handles ButtonFormSignIn.Click
        FormSignIn.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormSignUp_Click(sender As Object, e As EventArgs) Handles ButtonFormSignUp.Click
        FormSignUp.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormDashboard_Click(sender As Object, e As EventArgs) Handles ButtonFormDashboard.Click
        FormDashboard.Show()
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

    Private Sub ButtonFormMobil_Click(sender As Object, e As EventArgs) Handles ButtonFormMobil.Click
        FormMobil.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormMobilTambah_Click(sender As Object, e As EventArgs) Handles ButtonFormMobilTambah.Click
        FormMobilTambah.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormMobilEdit_Click(sender As Object, e As EventArgs) Handles ButtonFormMobilEdit.Click
        FormMobilEdit.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFormMobilHapus_Click(sender As Object, e As EventArgs) Handles ButtonFormMobilHapus.Click
        FormMobilHapus.Show()
        Me.Hide()
    End Sub
End Class
