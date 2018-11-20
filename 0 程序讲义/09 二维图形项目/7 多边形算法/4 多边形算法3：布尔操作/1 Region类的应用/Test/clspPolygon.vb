Public Class clspPolygon
    Private KeyPoints() As PointF

    Public Sub New(Points As List(Of PointF))
        Dim N As Integer = Points.Count
        ReDim KeyPoints(N - 1)
        For i = 0 To N - 1
            KeyPoints(i) = Points(i)
        Next
    End Sub

    Public Sub Draw(g As Graphics)
        Dim myPen As New Pen(Color.Red, 1)
        g.DrawPolygon(myPen, KeyPoints)
    End Sub

End Class
