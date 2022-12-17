Public Class FormBukuPenjualanHapus
    Private Sub ButtonNo_Click(sender As Object, e As EventArgs) Handles ButtonNo.Click
        Me.Close()
        FormBukuPenjualan.Show()
    End Sub

    Private Sub FormBukuPenjualanHapus_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub
End Class