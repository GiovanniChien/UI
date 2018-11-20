Imports System.Math

Public Class Form1

    Private Sub picCanvas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCanvas.Click
        Dim g As Graphics = picCanvas.CreateGraphics
        Dim pen As Pen = New Pen(Color.Red)
        Dim sp As Point = New Point(100, 100)
        Dim ep As Point = New Point(200, 200)
        g.DrawLine(pen, sp, ep)
        draw(sp, 100)
    End Sub
    Sub draw(ByVal sp As Point, ByVal radius As Integer)
        Dim g As Graphics = picCanvas.CreateGraphics
        Dim pen As Pen = New Pen(Color.Blue)
        Dim ep As New Point
        Dim delta = 10
        For angle = 0 To 360 - delta Step delta
            ep.X = sp.X + radius * Cos(angle / 180 * PI)
            ep.Y = sp.Y + radius * Sin(angle / 180 * PI)
            g.DrawLine(pen, sp, ep)
        Next
    End Sub
End Class
