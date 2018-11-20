Imports System.Math

Public Class Form1
    Dim sp As Point
    Private Sub picCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub

    Private Sub picCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim ep As Point = e.Location
        Dim pen As Pen = New Pen(Color.Red)
        Dim g As Graphics = picCanvas.CreateGraphics
        g.DrawLine(pen, sp, ep)
    End Sub
End Class
