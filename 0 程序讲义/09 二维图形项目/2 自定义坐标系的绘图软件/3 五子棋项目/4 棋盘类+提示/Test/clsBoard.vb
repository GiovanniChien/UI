Public Class clsBoard
    Enum Status
        Outside ' 棋盘之外
        Empty   ' 空位置
        White   '白棋
        Black   '黑棋
    End Enum

    Private box As Rectangle, n As Integer
    Private dx As Integer, dy As Integer   '行列间距
    Private penbox As Pen
    Private brushchessblack, brushchesswhite As Brush
    Private StatusMatrix(,) As Status   '状态矩阵

    ' 在Box中，从左上角开始放置一个n*n的棋盘
    ' 棋盘网格线的间距为dx,dy，棋盘与Box的边界距离为dx,dy 
    Public Sub New(ByVal box As Rectangle, ByVal n As Integer)
        Me.n = n
        Resize(box)
        ReDim StatusMatrix(n - 1, n - 1)
        For i = 0 To n - 1
            For j = 0 To n - 1
                StatusMatrix(i, j) = Status.Empty
            Next
        Next
        Me.penbox = Pens.Black
        Me.brushchessblack = Brushes.Black : Me.brushchesswhite = Brushes.White
    End Sub
    Public Sub Resize(box As Rectangle)
        Me.dx = box.Width / (n + 1) : Me.dy = box.Height / (n + 1)
        '棋盘的范围
        Me.box = New Rectangle(dx, dy, dx * (n - 1), dy * (n - 1))
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        g.Clear(Color.Gray)
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
        For i = 0 To n - 1
            For j = 0 To n - 1
                If StatusMatrix(i, j) <> Status.Empty Then
                    DrawChess(g, i, j)
                End If
            Next
        Next
        g.Flush()
    End Sub

    Private Sub DrawChess(g As Graphics, i As Integer, j As Integer)
        Dim dx1 As Integer = dx - 4, dy1 As Integer = dy - 4  '棋子的半径
        Dim x As Integer = box.Left + i * dx - dx1 / 2
        Dim y As Integer = box.Top + j * dy - dy1 / 2
        If StatusMatrix(i, j) = Status.White Then
            g.FillEllipse(brushchesswhite, x, y, dx1, dy1)
        Else
            g.FillEllipse(brushchessblack, x, y, dx1, dy1)
        End If

    End Sub

    Public Function GetLocation(ByVal p As Point) As Point
        Dim loc As Point
        loc.X = (p.X - box.Left) / dx
        loc.Y = (p.Y - box.Top) / dy
        Return loc
    End Function

    '下一步棋
    Public Sub PlaceChess(ByVal player As Status, ByVal loc As Point)
        If loc.X < 0 Or loc.X >= n Then Return
        If loc.Y < 0 Or loc.Y >= n Then Return
        StatusMatrix(loc.X, loc.Y) = player
    End Sub

    Public Function GetStatus(loc As Point) As Status
        If loc.X < 0 Or loc.X >= n Then Return Status.Outside
        If loc.Y < 0 Or loc.Y >= n Then Return Status.Outside
        Return StatusMatrix(loc.X, loc.Y)
    End Function

    '计算达到k个棋子的连线
    Public Function GetLines(chess As Status, k As Integer) As List(Of List(Of Point))
        Dim Lines As List(Of List(Of Point)) = New List(Of List(Of Point))
        Dim Line As List(Of Point) = New List(Of Point)
        '逐行检查
        For i = 0 To n - 1
            For j = 0 To n - k - 1
                '?????
                StatusMatrix(i, j) = chess
            Next
        Next

        Return Lines
    End Function


End Class
