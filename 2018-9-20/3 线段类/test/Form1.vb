Imports System.Math

Public Class Form1
    Dim line As clsLine
    Dim sp As Point

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        line = Nothing
    End Sub
    Private Sub picCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub

    Private Sub picCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        line = New clsLine(sp, e.Location)
        Dim pen As Pen = New Pen(Color.Red)
        line.draw(picCanvas .CreateGraphics, pen)
    End Sub
End Class
