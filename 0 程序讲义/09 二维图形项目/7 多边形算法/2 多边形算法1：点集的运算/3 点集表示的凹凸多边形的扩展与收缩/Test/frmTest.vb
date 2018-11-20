Public Class frmTest
    Dim polygon As clsPolygon
    Dim points As clsPoints

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        Dim pts As New List(Of PointF)
        pts.Add(New PointF(30, 200))
        pts.Add(New PointF(200, 180))
        pts.Add(New PointF(120, 100))
        pts.Add(New PointF(50, 80))
        polygon = New clsPolygon(pts)
        points = New clsPoints(polygon)
        Draw()
    End Sub

    Private Sub btnExpand_Click(sender As System.Object, e As System.EventArgs) Handles btnExpand.Click, btnShrink.Click
        If sender Is btnExpand Then points.Expand(New PointF(100, 100), 1.05, 3 / 180 * Math.PI)
        If sender Is btnShrink Then points.Expand(New PointF(100, 100), 1 / 1.05, -3 / 180 * Math.PI)
        Draw()
    End Sub

    Private Sub Draw()
        Dim g As Graphics = picCanvas.CreateGraphics()
        g.Clear(picCanvas.BackColor)
        points.Draw(g)
        g.Flush()
    End Sub

End Class
