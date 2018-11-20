Public Class clsPoints
    Private Points As List(Of PointF)
    Private Pen As Pen
    Private Const delta As Single = 10

    Public Sub New(Polygon As clsPolygon)
        Pen = New Pen(Color.Red)
        Points = New List(Of PointF)
        Dim box As clsBox = Polygon.Box
        For x = box.xmin To box.xmax Step delta
            For y = box.ymin To box.ymax Step delta
                Dim p As PointF = New PointF(x, y)
                If Polygon.Inside(p) Then
                    Points.Add(p)
                End If
            Next
        Next
    End Sub

    Sub Draw(g As Graphics)
        For i = 0 To Points.Count - 1
            g.DrawEllipse(Pen, Points(i).X - delta / 2, Points(i).Y - delta / 2, delta, delta)
        Next
    End Sub

End Class
