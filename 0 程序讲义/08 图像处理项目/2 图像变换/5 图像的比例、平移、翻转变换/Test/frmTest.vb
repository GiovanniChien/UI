Imports System.Math
Public Class frmTest
    Dim Bitmap As clsBitmap
    Dim WithEvents Ticker As Timer

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Bitmap = New clsBitmap("Tulips.jpg", picCanvas1)
    End Sub
    Private Sub btnScale_Click(sender As System.Object, e As System.EventArgs) Handles btnScale.Click
        Ticker = New Timer
        Ticker.Interval = 150 : Ticker.Enabled = True
    End Sub

    Private Sub btnRotate_Click(sender As System.Object, e As System.EventArgs) Handles btnRotate.Click
        If Bitmap Is Nothing Then Return
        Bitmap.Rotate()
    End Sub

    Private Sub Ticker_Tick(sender As Object, e As System.EventArgs) Handles Ticker.Tick
        If Bitmap Is Nothing Then Return
        If radioLinear.Checked Then Linear()
        If radioNoLinear.Checked Then NoLinear()
    End Sub

    ' 由小（线性比例）变大
    Private Sub Linear()
        Static scale As Single = 0
        If scale >= 1 Then
            scale = 0 : Ticker.Enabled = False : Return
        End If
        Bitmap.Scale(scale, scale)
        scale += 0.02
        picCanvas1.Refresh()
    End Sub

    ' 由小变大再变小，周期2次
    Private Sub NoLinear()
        Static angle As Integer = 0
        If angle >= 360 Then
            angle = 0 : Ticker.Enabled = False : Return
        End If
        Dim scale As Single = Abs(Sin(angle / 180 * PI))
        Bitmap.Scale(scale, scale)
        angle += 3
        picCanvas1.Refresh()
    End Sub

End Class
