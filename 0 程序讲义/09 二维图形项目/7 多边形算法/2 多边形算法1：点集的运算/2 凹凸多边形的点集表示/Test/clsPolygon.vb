Imports System.Math

Public Class clsPolygon
    Private Points As List(Of PointF)
    Public Box As clsBox
    Private Pen As Pen

    Sub New(Points As List(Of PointF))
        Pen = New Pen(Color.Black)
        Me.Points = New List(Of PointF)
        For i = 0 To Points.Count - 1
            Me.Points.Add(Points(i))
        Next
        Box = New clsBox(Points(0))
        For i = 0 To Points.Count - 1
            Box.Contain(Points(i))
        Next
    End Sub

    Sub Draw(g As Graphics)
        g.DrawPolygon(Pen, Points.ToArray)
    End Sub

    Function Inside(p As PointF) As Boolean
        Dim angle As Double = 0
        For i = 0 To Points.Count - 2
            Dim angle1 As Single = GetAngle(Points(i), p, Points(i + 1))
            angle += angle1
        Next
        angle += GetAngle(Points(Points.Count - 1), p, Points(0))
        If (Abs(angle) < 0.01) Then
            Return False
        Else
            Return True
        End If
    End Function

    '计算p1->p->p2的夹角
    Private Function GetAngle(p1 As PointF, p As PointF, p2 As PointF)
        Dim v1 As PointF = New PointF(p1.X - p.X, p1.Y - p.Y)
        Dim v2 As PointF = New PointF(p2.X - p.X, p2.Y - p.Y)
        Dim x1 As Single = v1.X * v2.X + v1.Y * v2.Y
        Dim x2 As Single = Sqrt(v1.X * v1.X + v1.Y * v1.Y)
        Dim x3 As Single = Sqrt(v2.X * v2.X + v2.Y * v2.Y)
        Dim cos_angle As Single = x1 / (x2 * x3)
        If Product(v1, v2) > 0 Then
            Return Acos(cos_angle)
        Else
            Return -Acos(cos_angle)
        End If
    End Function

    '计算v1 * v2 的叉积
    Private Function Product(v1 As PointF, v2 As PointF) As Single
        Return v1.X * v2.Y - v2.X * v1.Y
    End Function


End Class
