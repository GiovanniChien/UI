
Public Class Form1
    Dim RotateObject As clsRotateObject
    Dim sp As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RotateObject = New clsRotateObject("方向盘.png")
        picCanvas.Width = RotateObject.Width
        picCanvas.Height = RotateObject.Height
        picCanvas.Image = RotateObject.Image
    End Sub

    Private Sub picCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub

    Private Sub picCanvas_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Return
        Dim delta As Integer = e.Location.X - sp.X
        UpdateRotateObject(delta)
    End Sub

    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim delta As Integer = e.Location.X - sp.X
        UpdateRotateObject(delta)
    End Sub

    Private Sub UpdateRotateObject(ByVal delta As Integer)
        delta = delta / 3
        If delta > 45 Then delta = 45
        If delta < -45 Then delta = -45
        txtAngle.Text = delta
        picCanvas.Image = RotateObject.Rotate(delta)
        picCanvas.Refresh()
    End Sub

    Private Sub picCanvas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCanvas.Click

    End Sub
End Class
