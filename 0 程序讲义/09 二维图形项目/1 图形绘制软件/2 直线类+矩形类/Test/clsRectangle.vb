Public Class clsRectangle
    Private sp, ep As PointF
    Private points(3) As PointF

    Public Sub New(ByVal sp As PointF, ByVal ep As PointF)
        Me.sp = sp : Me.ep = ep
        Init()
    End Sub
    Private Sub Init()
        Dim xmin, xmax, ymin, ymax As Single
        If sp.X < ep.X Then
            xmin = sp.X : xmax = ep.X
        Else
            xmin = ep.X : xmax = sp.X
        End If
        If sp.Y < ep.Y Then
            ymin = sp.Y : ymax = ep.Y
        Else
            ymin = ep.Y : ymax = sp.Y
        End If
        points(0) = New PointF(xmin, ymin)
        points(1) = New PointF(xmax, ymin)
        points(2) = New PointF(xmax, ymax)
        points(3) = New PointF(xmin, ymax)
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        Dim myPen As New Pen(Color.Red, 1)
        g.DrawPolygon(myPen, Points)
    End Sub

End Class
