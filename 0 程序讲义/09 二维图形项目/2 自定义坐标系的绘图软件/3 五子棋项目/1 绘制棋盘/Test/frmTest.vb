Public Class frmTest

    '期待自定义的棋盘类
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim g As Graphics = picCanvas.CreateGraphics
        Dim pt1, pt2 As Point
        Dim dx As Integer = 25, dy As Integer = 25
        Dim box As Rectangle = New Rectangle(10, 10, 18 * dx, 18 * dy)
        For i = 0 To 18
            pt1 = New Point(box.Left + i * dx, box.Top)
            pt2 = New Point(box.Left + i * dx, box.Bottom)
            g.DrawLine(Pens.Black, pt1, pt2)
        Next
        For i = 0 To 18
            pt1 = New Point(box.Left, box.Top + i * dy)
            pt2 = New Point(box.Right, box.Top + i * dy)
            g.DrawLine(Pens.Black, pt1, pt2)
        Next
        g.Flush()
    End Sub

    '期待棋盘坐标
    Private Sub picCanvas_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        Dim p As Point = e.Location
        Me.Text = p.ToString
    End Sub
End Class
