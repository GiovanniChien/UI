
Public Class frmTest
    Dim polygon As clsPolygon
    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        polygon = New clsPolygon(Color.FromArgb(255, 0, 0))
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim g As Graphics = picCanvas.CreateGraphics
        polygon.Draw(g)
        g.Flush()
    End Sub

End Class
