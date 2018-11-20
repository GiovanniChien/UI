Imports System.Drawing.Drawing2D

Public Class clsCS2
    Private xmin, xmax, ymin, ymax As Single
    Private Const margin As Single = 0.1

    Public Sub New(xmin As Single, xmax As Single, ymin As Single, ymax As Single)
        Me.xmin = xmin : Me.xmax = xmax
        Me.ymin = ymin : Me.ymax = ymax
    End Sub
    Public Sub draw(g As Graphics, RM As Matrix)
        Dim xmarginlen As Single = (xmax - xmin) * margin
        Dim ymarginlen As Single = (ymax - ymin) * margin
        Dim ps(1) As PointF

        ps(0).Y = 0 : ps(0).X = xmin + xmarginlen
        ps(1).Y = 0 : ps(1).X = xmax - xmarginlen
        RM.TransformPoints(ps)
        g.DrawLine(Pens.Blue, ps(0), ps(1))

        ps(0).X = 0 : ps(0).Y = ymin + ymarginlen
        ps(1).X = 0 : ps(1).Y = ymax - ymarginlen
        RM.TransformPoints(ps)
        g.DrawLine(Pens.Blue, ps(0), ps(1))

    End Sub
End Class
