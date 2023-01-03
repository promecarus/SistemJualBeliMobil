Public Class FormDashboard
    Private Sub FormDashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Parent = PictureBox2
        Label3.Parent = PictureBox2
        Label4.Parent = PictureBox2
    End Sub

    Private Sub ButtonManageCar_Click(sender As Object, e As EventArgs) Handles manageCarBtn.Click
        FormMobil.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonManageUser_Click(sender As Object, e As EventArgs) Handles ManageUserBtn.Click
        FormPembeli.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonTransaction_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles SignoutBtn.Click
        FormSignIn.Show()
        Me.Hide()
    End Sub
End Class