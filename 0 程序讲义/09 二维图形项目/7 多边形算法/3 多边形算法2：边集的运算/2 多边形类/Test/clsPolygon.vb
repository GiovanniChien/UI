Imports System.Math

Public Class clsPolygon
    Private points As List(Of PointF)
    Private color As Color           '用于表示材料

    Public Sub New(color As Color, points As List(Of PointF))
        Me.color = color
        Me.points = points
    End Sub

    Public Sub New(color As Color)
        Me.color = color
        points = New List(Of PointF)
        Dim cp As PointF = New PointF(200, 200)
        Dim r As Single = 150
        For angle = 0 To 359 Step 30
            Dim x As Single = cp.X + r * Cos(angle / 180 * PI)
            Dim y As Single = cp.X + r * Sin(angle / 180 * PI)
            points.Add(New PointF(x, y))
        Next
    End Sub

    Public Sub Draw(g As Graphics)
        Dim pen As Pen = New Pen(color)
        For i = 0 To points.Count - 2
            g.DrawLine(pen, points(i), points(i + 1))
        Next
        g.DrawLine(pen, points(points.Count - 1), points(0))
    End Sub

End Class
