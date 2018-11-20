Public Class frmTest

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim sum As Single = 0
        For i = 1 To 1000000000
            sum += i   '10亿次的计算
        Next
        TextBox1.Text = sum
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim sum As Single = 0
        For i = 1 To 1000000000
            sum += i  '10亿次的计算
        Next
        TextBox2.Text = sum
    End Sub
End Class
