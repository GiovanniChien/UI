' 环：顶点的有序序列
Public Class clsRing
    Private Points As List(Of PointF)

    Public Sub New(Points As List(Of PointF))
        Me.Points = Points
    End Sub

    Sub Draw(g As Graphics, pen As Pen)
        For i = 0 To Points.Count - 2
            g.DrawLine(pen, Points(i), Points(i + 1))
        Next
        g.DrawLine(pen, Points(Points.Count - 1), Points(0))
    End Sub

End Class
