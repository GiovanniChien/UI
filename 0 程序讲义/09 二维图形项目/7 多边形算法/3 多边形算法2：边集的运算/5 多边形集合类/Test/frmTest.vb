Imports System.Math

Public Class frmTest
    Dim polygon As clsPolygon            ' 最初的多边形对象
    Dim polygons As clsPolygons          ' 偏移后的多边形对象的集合（不含polygon）
    Dim sourceColor As Color = Color.FromArgb(255, 0, 0)    ' 最初的多边形对象的颜色
    Dim TargetColor As Color = Color.FromArgb(0, 255, 255)  ' 偏移量最大的多边形对象的颜色
    Dim obstacles As clsPolygons         ' 在polygon中的障碍物

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        polygon = New clsPolygon(sourceColor, True)
        polygons = New clsPolygons
        obstacles = New clsPolygons
        Dim pts As New List(Of PointF)
        pts.Add(New PointF(150, 150))
        pts.Add(New PointF(250, 150))
        pts.Add(New PointF(250, 250))
        pts.Add(New PointF(150, 250))
        obstacles.Add(New clsPolygon(Color.Black, pts))
    End Sub

    Private Sub btnExpand_Click(sender As System.Object, e As System.EventArgs) Handles btnExpand.Click
        Dim n As Integer = 5
        polygons = polygon.Expand(TargetColor, 12, n)
        Draw()
    End Sub

    Private Sub picCanvas_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        Draw()
    End Sub

    Private Sub Draw()
        If polygon Is Nothing Then Return
        Dim g As Graphics = picCanvas.CreateGraphics
        polygon.Draw(g)
        polygons.Draw(g)
        obstacles.Draw(g)
        g.Flush()
    End Sub
End Class






