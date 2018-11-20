Public Class frmTest
    Dim polygon As clsPolygon
    Dim points As clsPoints

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        Dim pts As New List(Of PointF)
        Pts.Add(New PointF(30, 200))
        Pts.Add(New PointF(200, 180))
        Pts.Add(New PointF(120, 100))
        Pts.Add(New PointF(50, 80))
        Dim g As Graphics = picCanvas.CreateGraphics()

        polygon = New clsPolygon(pts) : polygon.Draw(g)
        points = New clsPoints(polygon) : points.Draw(g)
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
