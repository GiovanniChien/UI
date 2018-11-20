Public Class clsParaEquation
    Dim x1, dx As Single
    Dim y1, dy As Single
    '参数方程： t: [0,1]
    ' x = x1 + dx * t
    ' y = y1 + dy * t
    Public Sub New(sp As PointF, ep As PointF)
        x1 = sp.X : dx = ep.X - sp.X
        y1 = sp.Y : dy = ep.Y - sp.Y
    End Sub

    Public Function ExistIp(Line As clsParaEquation) As Boolean
        ' 平行线
        Dim delta As Single = dx * Line.dy - dy * Line.dx
        If delta = 0 Then Return False
        Dim t2 As Single = (dy * (Line.x1 - x1) - dx * (Line.y1 - y1)) / delta
        Dim t1 As Single
        If Math.Abs(dx) > Math.Abs(dy) Then
            t1 = (Line.x1 - x1 + Line.dx * t2) / dx
        Else
            t1 = (Line.y1 - y1 + Line.dy * t2) / dy
        End If
        ' 上开下闭： 避免端点处交点重复计算 
        If t1 >= 0 And t1 < 1 And t2 >= 0 And t2 < 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
