Public Class frmTest
    Dim WithEvents Lines As clsLines
    Dim sp As PointF

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Lines = New clsLines
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub
    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim ep As PointF = e.Location
        Dim line As clsLine = New clsLine(sp, ep)
        Lines.Append(line)
    End Sub

    Private Sub Lines_Redraw() Handles Lines.Redraw
        Dim g As Graphics = picCanvas.CreateGraphics()
        Lines.Draw(g)
    End Sub
End Class
