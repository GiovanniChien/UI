Imports System.Math

Public Class frmTest
    Dim points As List(Of PointF)

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        points = New List(Of PointF)
        Dim cp As PointF = New PointF(200, 200)
        Dim r As Single = 150
        For angle = 0 To 359 Step 30
            Dim x As Single = cp.X + r * Cos(angle / 180 * PI)
            Dim y As Single = cp.X + r * Sin(angle / 180 * PI)
            points.Add(New PointF(x, y))
        Next
    End Sub

    Sub Draw()
        Dim g As Graphics = picCanvas.CreateGraphics
        For i = 0 To points.Count - 2
            g.DrawLine(Pens.Black, points(i), points(i + 1))
        Next
        g.DrawLine(Pens.Black, points(points.Count - 1), points(0))
        g.Flush()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Draw()
    End Sub
End Class
