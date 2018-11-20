Public Class frmTest
    Dim points As List(Of PointF)
    Dim rs As clsRegions

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        points = New List(Of PointF)
        rs = New clsRegions
    End Sub
    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        If RadioCreate.Checked = True Then
            points.Add(e.Location)
        Else
            rs.DoSelect(e.Location)
            Redraw()
        End If
    End Sub

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        rs.Append(points)
        Redraw()
        points.Clear()
    End Sub

    Private Sub btnUnion_Click(sender As System.Object, e As System.EventArgs) Handles btnUnion.Click
        If lstRegion.SelectedIndices.Count <> 2 Then Exit Sub
        rs.Op(RegionOp.Union)
        Redraw()
    End Sub

    Private Sub lstRegion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstRegion.SelectedIndexChanged
        Dim k = lstRegion.SelectedIndex
        rs.DoSelect(k)
        rs.Draw(picCanvas.CreateGraphics)
    End Sub

    Private Sub btnRedraw_Click(sender As System.Object, e As System.EventArgs) Handles btnRedraw.Click
        Redraw()
    End Sub
    Private Sub Redraw()
        rs.Draw(picCanvas.CreateGraphics)
        rs.Fill(lstRegion)
    End Sub
End Class
