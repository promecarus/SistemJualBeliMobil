Public Class FormDashboard
    Private Sub FormDashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Parent = PictureBox2
        Label3.Parent = PictureBox2
        Label4.Parent = PictureBox2
    End Sub


    Private Sub manageCarBtn_Click(sender As Object, e As EventArgs) Handles manageCarBtn.Click
        FormMobil.Show()
        Me.Hide()
    End Sub

    Private Sub ManageUserBtn_Click(sender As Object, e As EventArgs) Handles ManageUserBtn.Click
        FormPembeli.Show()
        Me.Hide()
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub BtnIndex_Click(sender As Object, e As EventArgs) Handles BtnIndex.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

End Class