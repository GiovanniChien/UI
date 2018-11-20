Public Class frmTest
    Dim polygon As clsPolygon
    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        Dim Points As New List(Of PointF)
        Points.Add(New PointF(30, 200))
        Points.Add(New PointF(200, 180))
        Points.Add(New PointF(120, 100))
        Points.Add(New PointF(50, 80))
        polygon = New clsPolygon(Points)
        Dim g As Graphics = picCanvas.CreateGraphics()
        polygon.Draw(g)
        g.Flush()
    End Sub

    Private Sub picCanvas_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        Dim p As PointF = e.Location
        If polygon.Inside(p) Then
            Text = "Inside"
        Else
            Text = "Outside"
        End If
    End Sub
End Class
