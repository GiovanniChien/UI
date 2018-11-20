' 环：顶点的有序序列
Public Class clsRing
    Private Points As List(Of PointF)
    Public Box As clsBox

    Public Sub New(Points As List(Of PointF))
        Me.Points = Points
        Me.Box = New clsBox(Points(0))
        For i = 1 To Points.Count - 1
            Me.Box.Contain(Points(i))
        Next
    End Sub

    Public Sub Draw(g As Graphics, pen As Pen)
        For i = 0 To Points.Count - 2
            g.DrawLine(pen, Points(i), Points(i + 1))
        Next
        g.DrawLine(pen, Points(Points.Count - 1), Points(0))
    End Sub

    Public Function GetIpCount(Line As clsParaEquation) As Integer
        Dim IpCount As Integer = 0
        Dim Linei As clsParaEquation
        For i = 0 To Points.Count - 2
            Linei = New clsParaEquation(Points(i), Points(i + 1))
            If Line.ExistIp(Linei) = True Then IpCount += 1
        Next
        Linei = New clsParaEquation(Points(Points.Count - 1), Points(0))
        If Line.ExistIp(Linei) = True Then IpCount += 1
        Return IpCount
    End Function
End Class
