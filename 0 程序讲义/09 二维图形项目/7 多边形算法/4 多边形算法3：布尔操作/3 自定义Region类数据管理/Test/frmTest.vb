Public Class frmTest
    Dim points As List(Of PointF)
    Dim rs As clsRegions

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        points = New List(Of PointF)
        rs = New clsRegions
        tvRegion.Nodes.Add(rs.node) '控件负责显示图形集合的节点
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        If RadioCreate.Checked = True Then
            points.Add(e.Location)
        Else
            rs.Select(e.Location)
            Redraw()  '选集被改变时，重绘
        End If
    End Sub

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        rs.Append(points)
        Redraw()  '点集新建图形对象时，重绘
        points.Clear()
    End Sub

    Private Sub btnOp_Click(sender As System.Object, e As System.EventArgs) Handles btnOp.Click
        rs.Op(RegionOp.Union)
        Redraw() '运算新建图形对象时，重绘
    End Sub
    Private Sub btnRedraw_Click(sender As System.Object, e As System.EventArgs) Handles btnRedraw.Click
        Redraw()
    End Sub
    '图形集合变动时，重绘图形集合
    Private Sub Redraw()
        rs.Draw(picCanvas.CreateGraphics)
    End Sub

    Private Sub tvRegion_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvRegion.AfterSelect
        If e.Node Is Nothing Then Exit Sub
        Dim region As clsRegion
        Try
            region = e.Node.Tag  '取出被选择的图形对象
        Catch ex As Exception
            Return
        End Try
        region.Selected = Not region.Selected
        Redraw() '点集新建图形对象时，重绘
    End Sub
End Class
