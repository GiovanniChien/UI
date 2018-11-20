Imports System.Math

Public Class Form1
    Dim lines As List(Of clsLine)
    Dim sp As Point

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lines = New List(Of clsLine)
    End Sub
    Private Sub picCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub

    Private Sub picCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim line = New clsLine(sp, e.Location)
        lines.Add(line)
        draw(picCanvas.CreateGraphics)
    End Sub

    Private Sub draw(ByVal g As Graphics)
        Dim pen As Pen = New Pen(Color.Red)
        For i = 0 To lines.Count - 1
            lines(i).draw(g, pen)
        Next
    End Sub

    Private Sub picCanvas_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        draw(e.Graphics)
    End Sub
End Class
