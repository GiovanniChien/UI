Public Class clsBox
    Private xmin, xmax, ymin, ymax, zmin, zmax As Single

    Public Sub New(p As clsSkeletonPoint)
        xmin = p.x : xmax = p.x
        ymin = p.y : ymax = p.y
        zmin = p.z : zmax = p.z
    End Sub

    Public Sub Contain(p As clsSkeletonPoint)
        If p.x < xmin Then xmin = p.x
        If p.x > xmax Then xmax = p.x
        If p.y < ymin Then ymin = p.y
        If p.y > ymax Then ymax = p.y
        If p.z < zmin Then zmin = p.z
        If p.z > zmax Then zmax = p.z
    End Sub

    Public Function GetRect(kind As ViewKind) As RectangleF
        Dim Rect As RectangleF
        If kind = ViewKind.XY Then Rect = New RectangleF(xmin, ymin, xmax - xmin, ymax - ymin)
        If kind = ViewKind.XZ Then Rect = New RectangleF(xmin, zmin, xmax - xmin, zmax - zmin)
        If kind = ViewKind.YZ Then Rect = New RectangleF(ymin, zmin, ymax - ymin, zmax - zmin)
        Return Rect
    End Function

End Class
