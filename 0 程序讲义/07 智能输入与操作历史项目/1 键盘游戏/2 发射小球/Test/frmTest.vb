Public Class frmTest

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        picCanvas.BackColor = Color.White
    End Sub

    Private Sub frmTest_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim p As Point
        p.X = 0 : p.Y = picCanvas.Height / 2
        Dim x As clsBox = New clsBox(BoxKind.Circle, p, picCanvas.DisplayRectangle, picCanvas.CreateGraphics())
    End Sub

    Private Sub frmTest_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Dim p As Point
        p.X = 0 : p.Y = picCanvas.Height / 2
        Dim x As clsBox = New clsBox(BoxKind.Box, p, picCanvas.DisplayRectangle, picCanvas.CreateGraphics())
    End Sub
End Class
