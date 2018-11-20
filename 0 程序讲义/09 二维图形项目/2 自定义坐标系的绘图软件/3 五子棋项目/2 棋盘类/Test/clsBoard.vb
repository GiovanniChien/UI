Public Class clsBoard
    Private box As Rectangle, n As Integer
    Private dx As Integer, dy As Integer   '行列间距
    Private penbox, penchessblack, penchesswhite As Pen
    Private brushchessblack, brushchesswhite As Brush
    '在Box中放置一个n*n的棋盘
    Public Sub New(ByVal box As Rectangle, ByVal n As Integer)
        Me.box = box : Me.n = n
        Me.dx = box.Width / (n - 1) : Me.box.Width = dx * (n - 1)
        Me.dy = box.Height / (n - 1) : Me.box.Height = dy * (n - 1)
        Me.penbox = Pens.Black
        Me.penchessblack = Pens.Black
        Me.penchesswhite = Pens.White
        Me.brushchessblack = Brushes.Black
        Me.brushchesswhite = Brushes.White
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        Dim pt1, pt2 As Point
        For i = 0 To n - 1
            pt1 = New Point(box.Left + i * dx, box.Top)
            pt2 = New Point(box.Left + i * dx, box.Bottom)
            g.DrawLine(penbox, pt1, pt2)
        Next
        For i = 0 To n - 1
            pt1 = New Point(box.Left, box.Top + i * dy)
            pt2 = New Point(box.Right, box.Top + i * dy)
            g.DrawLine(Pens.Black, pt1, pt2)
        Next
        g.Flush()
    End Sub

    Function GetLocation(ByVal p As Point) As Point
        Dim loc As Point
        loc.X = (p.X - box.Left) / dx
        loc.Y = (p.Y - box.Top) / dy
        Return loc
    End Function

    Sub DrawChess(ByVal g As Graphics, ByVal chess As Point)
        If chess.X < 0 Or chess.X >= n Then Return
        If chess.Y < 0 Or chess.Y >= n Then Return
        Dim x As Integer = box.Left + chess.X * dx - dx / 2
        Dim y As Integer = box.Top + chess.Y * dy - dy / 2
        g.DrawEllipse(penchesswhite, x, y, dx, dy)
        g.FillEllipse(brushchesswhite, x, y, dx, dy)
        g.Flush()
    End Sub

End Class
