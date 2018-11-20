Public Class frmTest

    Dim c As Integer = 0
    Private Sub TextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        c += 1
    End Sub
    Private Sub TextBox1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        TextBox2.Text = TextBox2.Text & e.KeyData.ToString & c
        c = 0
    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Text = e.KeyChar
    End Sub


    
End Class
