Public Class clsBox
    Public xmin, xmax, ymin, ymax As Single

    Public Sub New(p As PointF)
        xmin = p.x : xmax = p.x
        ymin = p.y : ymax = p.y
    End Sub

    Public Sub Contain(p As PointF)
        If p.x < xmin Then xmin = p.x
        If p.x > xmax Then xmax = p.x
        If p.y < ymin Then ymin = p.y
        If p.y > ymax Then ymax = p.y
    End Sub


End Class
