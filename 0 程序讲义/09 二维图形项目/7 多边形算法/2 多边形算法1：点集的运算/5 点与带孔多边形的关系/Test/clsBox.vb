Public Class clsBox
    Public xmin, xmax, ymin, ymax As Single

    Public Sub New(p As PointF)
        xmin = p.X : xmax = p.X
        ymin = p.Y : ymax = p.Y
    End Sub

    Sub New(Box As clsBox)
        xmin = Box.xmin : xmax = Box.xmax
        ymin = Box.ymin : ymax = Box.ymax
    End Sub

    Public Sub Contain(p As PointF)
        If p.x < xmin Then xmin = p.x
        If p.x > xmax Then xmax = p.x
        If p.y < ymin Then ymin = p.y
        If p.y > ymax Then ymax = p.y
    End Sub

    Public Sub Contain(Box As clsBox)
        If Box.xmin < xmin Then xmin = Box.xmin
        If Box.xmax > xmax Then xmax = Box.xmax
        If Box.ymin < ymin Then ymin = Box.ymin
        If Box.ymax > ymax Then ymax = Box.ymax
    End Sub

    Function Wx() As Single
        Return xmax - xmin
    End Function

End Class
