Public Class clsPLine
    Inherits clsElem
    Private Points As List(Of PointF)

    Public Sub New(ByVal Points As List(Of PointF))
        Me.Points = Points
    End Sub

    Public Overrides Sub Draw(ByVal g As Graphics)
        g.DrawLines(Pen, Points.ToArray)
    End Sub
    Public Overloads Overrides Sub Draw(ByVal g As System.Drawing.Graphics, ByVal color As System.Drawing.Color)
        Dim pen As Pen = New Pen(color, 1)
        g.DrawLines(pen, Points.ToArray)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = "PLine: "
        For i = 0 To Points.Count - 1
            s = s & ": " & Points(i).ToString & " "
        Next
        Return s
    End Function

End Class
