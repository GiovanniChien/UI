Public Class clsPolygon
    Inherits clsElem

    Private Points As List(Of PointF)

    Public Sub New(ByVal Points As List(Of PointF))
        Me.Points = Points
    End Sub


    Public Overloads Overrides Sub Draw(ByVal g As Graphics, ByVal M As clsMatrix3, ByVal State As ObjectState)
        Dim ps(Points.Count - 1) As PointF
        For i = 0 To Points.Count - 1
            ps(i) = M.Tranform(Points(i))
        Next
        g.DrawPolygon(GetPen(State), ps)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = "Polygon: "
        For i = 0 To Points.Count - 1
            s = s & Points(i).ToString & " "
        Next
        Return s
    End Function

    Public Overrides Function SelectByPoint(ByVal p As PointF) As Boolean
        Dim sp, ep As PointF
        sp = Points(Points.Count - 1)
        For i = 0 To Points.Count - 1
            ep = Points(i)
            If clsLine.SelectByPoint(p, sp, ep) = True Then Return True
            sp = ep
        Next
        Return False
    End Function

    Public Overrides Function Clone() As clsElem
        Dim newPoints As New List(Of PointF)
        newPoints.AddRange(Points)
        Return New clsPolygon(newPoints)
    End Function

    Public Overrides Sub Transform(ByVal m As clsMatrix3)
        For i = 0 To Points.Count - 1
            Points(i) = m.Tranform(Points(i))
        Next
    End Sub

End Class
