Public Class clsPolygon
    Inherits clsElem
    Private KeyPoints() As PointF

    Public Sub New(Points As List(Of PointF))
        Dim N As Integer = Points.Count
        ReDim KeyPoints(N - 1)
        For i = 0 To N - 1
            KeyPoints(i) = Points(i)
        Next
    End Sub

    Public Overrides Sub Draw(g As Graphics, Optional isSelectElem As Boolean = False)
        If isSelectElem = True Then
            g.DrawPolygon(SelectedPen, KeyPoints)
        Else
            g.DrawPolygon(CommonPen, KeyPoints)
        End If
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = "Polygon: "
        For i = 0 To KeyPoints.Count - 1
            s = s & ": " & KeyPoints(i).ToString & " "
        Next
        Return s
    End Function

    Public Overrides Function SelectByPoint(p As PointF) As Boolean
        Dim sp, ep As PointF
        sp = KeyPoints(KeyPoints.Count - 1)
        For i = 0 To KeyPoints.Count - 1
            ep = KeyPoints(i)
            If clsLine.SelectByPoint(p, sp, ep) = True Then Return True
            sp = ep
        Next
        Return False
    End Function

    Public Overrides Sub Transform(m As clsMatrix3)
        For i = 0 To KeyPoints.Count - 1
            KeyPoints(i) = m.Tranform(KeyPoints(i))
        Next
    End Sub

End Class
