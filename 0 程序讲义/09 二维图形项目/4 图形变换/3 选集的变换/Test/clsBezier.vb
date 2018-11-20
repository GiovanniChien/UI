'贝塞尔曲线
Public Class clsBezier
    Private KeyPoints() As PointF

    Public Sub New(Points As List(Of PointF))
        Dim N As Integer = Points.Count
        N = ((N - 1) \ 3) * 3 + 1
        ReDim KeyPoints(N - 1)
        For i = 0 To N - 1
            KeyPoints(i) = Points(i)
        Next
    End Sub

    Public Sub Draw(g As Graphics)
        Dim myPen As New Pen(Color.Red, 1)
        g.DrawBeziers(myPen, KeyPoints)
    End Sub
End Class
