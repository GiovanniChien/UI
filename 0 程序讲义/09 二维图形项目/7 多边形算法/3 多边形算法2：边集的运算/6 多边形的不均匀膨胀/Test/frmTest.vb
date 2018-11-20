Imports System.Math

Public Class frmTest
    Dim polygon As clsPolygon            '最初的多边形对象
    Dim polygons As clsPolygons         '偏移后的多边形对象的集合（不含polygon）
    Dim sourceColor As Color = Color.FromArgb(255, 0, 0)    '最初的多边形对象的颜色
    Dim TargetColor As Color = Color.FromArgb(0, 255, 255)  '偏移量最大的多边形对象的颜色

    Dim obstacles As clsPolygons '约定是在polygon中的障碍物

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        polygon = New clsPolygon(sourceColor)
        polygon.CreateCircle(New PointF(200, 200), 150)
        polygons = New clsPolygons

        obstacles = New clsPolygons
        Dim obstacle1 = New clsPolygon(sourceColor) : obstacle1.CreateCircle(New PointF(150, 200), 55)
        Dim obstacle2 = New clsPolygon(sourceColor) : obstacle2.CreateCircle(New PointF(250, 200), 55)
        obstacles.Add(obstacle1)
        obstacles.Add(obstacle2)
    End Sub

    Private Sub btnExpand_Click(sender As System.Object, e As System.EventArgs) Handles btnExpand.Click
        Dim n As Integer = 25
        Dim MaxDeltas As List(Of Single)       ' 各个顶点的扩展间距的最大值
        MaxDeltas = polygon.GetLimits(obstacles)
        polygons = polygon.Expand(TargetColor, MaxDeltas, n)
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






