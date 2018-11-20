Public Class clsCS2
    Private xmin, xmax, ymin, ymax As Single
    Private Const margin As Single = 0.1

    Public Sub New(xmin As Single, xmax As Single, ymin As Single, ymax As Single)
        Me.xmin = xmin : Me.xmax = xmax
        Me.ymin = ymin : Me.ymax = ymax
    End Sub
    Public Sub draw(g As Graphics, RM As clsMatrix)
        Dim xmarginlen As Single = (xmax - xmin) * margin
        Dim ymarginlen As Single = (ymax - ymin) * margin
        Dim p1, p2 As PointF

        p1.Y = 0 : p1.X = xmin + xmarginlen
        p2.Y = 0 : p2.X = xmax - xmarginlen
        g.DrawLine(Pens.Blue, RM.Transform(p1), RM.Transform(p2))

        p1.X = 0 : p1.Y = ymin + ymarginlen
        p2.X = 0 : p2.Y = ymax - ymarginlen
        g.DrawLine(Pens.Blue, RM.Transform(p1), RM.Transform(p2))

    End Sub
End Class
