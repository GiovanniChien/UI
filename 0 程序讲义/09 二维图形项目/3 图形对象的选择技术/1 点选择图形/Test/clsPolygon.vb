Public Class clsPolygon
    Inherits clsElem
    Private Points As List(Of PointF)

    Public Sub New(Points As List(Of PointF))
        Me.Points = Points
    End Sub

    Public Overrides Sub Draw(g As Graphics)
        Dim myPen As New Pen(Color.Red, 1)
        g.DrawPolygon(myPen, Points.ToArray)
    End Sub
    Public Overloads Overrides Sub Draw(ByVal g As System.Drawing.Graphics, ByVal color As System.Drawing.Color)
        Dim pen As Pen = New Pen(color, 1)
        g.DrawPolygon(pen, Points.ToArray)
    End Sub


    Public Overrides Function ToString() As String
        Dim s As String = "Polygon: "
        For i = 0 To Points.Count - 1
            s = s & Points(i).ToString & " "
        Next
        Return s
    End Function

    Public Overrides Function SelectByPoint(p As PointF) As Boolean
        Dim sp, ep As PointF
        sp = Points(Points.Count - 1)
        For i = 0 To Points.Count - 1
            ep = Points(i)
            If clsLine.SelectByPoint(p, sp, ep) = True Then Return True
            sp = ep
        Next
        Return False
    End Function

End Class
