Imports System.Math

Public Class Form1
    Dim lines As clsLines
    Dim sp As Point

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lines = New clsLines
    End Sub
    Private Sub picCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub

    Private Sub picCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim line = New clsLine(sp, e.Location)
        lines.Append(line)
        draw(picCanvas.CreateGraphics)
    End Sub

    Private Sub picCanvas_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        draw(e.Graphics)
    End Sub

    Private Sub draw(ByVal g As Graphics)
        lines.Draw(g)
    End Sub
End Class
