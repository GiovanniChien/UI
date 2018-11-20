Public Class clsParaEquation
    Dim x1, dx As Single
    Dim y1, dy As Single
    '参数方程： t: [0,1]
    ' x = x1 + dx * t
    ' y = y1 + dy * t
    Public Sub New(sp As PointF, ep As PointF)
        If sp.Y <= ep.Y Then
            x1 = sp.X : dx = ep.X - sp.X
            y1 = sp.Y : dy = ep.Y - sp.Y
        Else
            x1 = ep.X : dx = sp.X - ep.X
            y1 = ep.Y : dy = sp.Y - ep.Y
        End If
    End Sub

    '  x1 + dx * t1 = Line.x1 + Line.dx * t2
    '  y1 + dy * t1 = Line.y1 + Line.dy * t2

    '  dx * t1 - Line.dx * t2 = Line.x1 - x1  ....1
    '  dy * t1 - Line.dy * t2 = Line.y1 - y1  ....2

    '  dx * dy * t1 - Line.dx * dy * t2 = dy * Line.x1 - dy * x1  ....3
    '  dx * dy * t1 - Line.dy * dx * t2 = dx * Line.y1 - dx * y1  ....4
    ' 式3 - 式4 :
    ' (Line.dy * dx - Line.dx * dy) * t2 = (dy * Line.x1 - dy * x1) - (dx * Line.y1 - dx * y1) 

    Public Function ExistIp(Line As clsParaEquation) As Boolean
        ' Double类型的精度很重要
        Dim delta As Double = dx * Line.dy - dy * Line.dx
        If delta = 0 Then Return False ' 排除平行线
        Dim t2 As Double = (dy * (Line.x1 - x1) - dx * (Line.y1 - y1)) / delta
        Dim t1 As Double
        If Math.Abs(dx) > Math.Abs(dy) Then
            t1 = (Line.x1 - x1 + Line.dx * t2) / dx
        Else
            t1 = (Line.y1 - y1 + Line.dy * t2) / dy
        End If
        ' 上开下闭： 避免端点处交点重复计算 
        ' t1=0，1 交点是当前线段的起点、终点
        ' t2=0，1 交点是线段Line的起点、终点
        If t1 > 0 And t1 < 1 And t2 >= 0 And t2 < 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
