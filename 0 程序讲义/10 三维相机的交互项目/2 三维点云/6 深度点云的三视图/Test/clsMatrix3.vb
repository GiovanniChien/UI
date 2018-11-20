Public Class clsMatrix3
    Private M(2, 2) As Single

    Public Sub New()
        M(0, 0) = 1 : M(0, 1) = 0 : M(0, 2) = 0
        M(1, 0) = 0 : M(1, 1) = 1 : M(1, 2) = 0
        M(2, 0) = 0 : M(2, 1) = 0 : M(2, 2) = 1
    End Sub
    Public Sub SetWindowView(windowrect As RectangleF, viewrect As RectangleF)
        Dim a As Single = viewrect.Width / windowrect.Width
        Dim c As Single = viewrect.Height / windowrect.Height
        Dim b As Single = viewrect.Left - a * windowrect.Left
        Dim d As Single = viewrect.Bottom - c * windowrect.Bottom
        M(0, 0) = a : M(0, 1) = 0 : M(0, 2) = 0
        M(1, 0) = 0 : M(1, 1) = c : M(1, 2) = 0
        M(2, 0) = b : M(2, 1) = d : M(2, 2) = 1
    End Sub

    Public Function Tranform(p As PointF) As PointF
        Dim newp As PointF
        newp.X = p.X * M(0, 0) + p.Y * M(1, 0) + M(2, 0)
        newp.Y = p.X * M(0, 1) + p.Y * M(1, 1) + M(2, 1)
        Return newp
    End Function

    Public Sub Tranform(points() As PointF)
        For i = 0 To points.Count - 1
            points(i) = Tranform(points(i))
        Next
    End Sub
    Public Sub Tranform(points As List(Of PointF))
        For i = 0 To points.Count - 1
            points(i) = Tranform(points(i))
        Next
    End Sub

End Class
