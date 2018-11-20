Public Class clsPolygon
    Inherits clsElem
    Private Points As List(Of PointF)

    Public Sub New(Points As List(Of PointF))
        Me.Points = Points
    End Sub

    Public Overrides Sub Draw(g As Graphics)
        g.DrawPolygon(Pen, Points.ToArray)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = "Polygon: "
        For i = 0 To Points.Count - 1
            s = s & ": " & Points(i).ToString & " "
        Next
        Return s
    End Function

End Class
