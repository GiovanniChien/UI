Public Class frmTest

    Dim Board As clsBoard ' 自定义的棋盘类

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Board = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim box As Rectangle = New Rectangle(10, 10, 400, 400)
        Board = New clsBoard(box, 19)
        Dim g As Graphics = picCanvas.CreateGraphics
        Board.Draw(g)
    End Sub

    Private Sub picCanvas_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If Board Is Nothing Then Return
        Dim p As Point = e.Location
        p = Board.GetLocation(p)  '实现了棋盘坐标
        'Me.Text = p.ToString
        Dim g As Graphics = picCanvas.CreateGraphics
        Board.DrawChess(g, p)
    End Sub

End Class
