Public Class frmTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSayHello.Click
        MessageBox.Show("HelloWorld!", "hello")
    End Sub

    Private Sub btnSayHello_MouseEnter(sender As Object, e As EventArgs) Handles btnSayHello.MouseEnter
        btnSayHello.Text = "Mouse is here"
    End Sub

    Private Sub btnSayHello_MouseLeave(sender As Object, e As EventArgs) Handles btnSayHello.MouseLeave
        btnSayHello.Text = "Mouse has gone"
    End Sub
End Class
