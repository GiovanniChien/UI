Public Class clsRectangle
    Inherits clsElem
    Private sp, ep As PointF
    Private points(3) As PointF

    Public Sub New(ByVal Layer As clsLayer, ByVal sp As PointF, ByVal ep As PointF)
        MyBase.New(Layer)
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

    Public Overrides Sub Draw(ByVal g As Graphics)
        g.DrawPolygon(Pen, points)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = "Rectangle "
        For i = 0 To points.Count - 1
            s = s & ": " & points(i).ToString & " "
        Next
        Return s
    End Function

End Class


