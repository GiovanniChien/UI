Public Enum BoxKind
    Circle
    Box
End Enum

Public Class clsBox
    Private kind As BoxKind
    Private p As Point  ' 中心点坐标
    Private radius As Integer   ' 半径
    Private vx, vy As Integer   ' 速度x
    Private rect As Rectangle, g As Graphics   ' 舞台的大小
    Private WithEvents Ticker As Timer

    Public Sub New(kind As BoxKind, p As Point, rect As Rectangle, g As Graphics)
        Me.kind = kind : Me.p = p : Me.rect = rect : Me.g = g
        Me.radius = 5
        Me.vx = 5 * Rnd() : Me.vy = 5 * Rnd()
        Me.Ticker = New Timer : Ticker.Interval = 10 : Ticker.Enabled = True
    End Sub

    Private Sub ticker_Tick(sender As Object, e As System.EventArgs) Handles Ticker.Tick
        Draw(New Pen(Color.White))   ' 消除运动之前的影子
        Move()
        Draw(New Pen(Color.Blue))    ' 绘制运动之后的影子
    End Sub

    Private Sub Move()
        If p.X + vx > rect.Right Then vx = -vx
        If p.X + vx < rect.Left Then vx = -vx
        If p.Y + vy > rect.Bottom Then vy = -vy
        If p.Y + vy < rect.Top Then vy = -vy
        p.X = p.X + vx
        p.Y = p.Y + vy
    End Sub
    Private Sub Draw(pen As Pen)
        If kind = BoxKind.Circle Then
            g.DrawEllipse(pen, p.X - radius, p.Y - radius, 2 * radius, 2 * radius)
        End If
        If kind = BoxKind.Box Then
            g.DrawRectangle(pen, p.X - radius, p.Y - radius, 2 * radius, 2 * radius)
        End If
    End Sub

End Class
