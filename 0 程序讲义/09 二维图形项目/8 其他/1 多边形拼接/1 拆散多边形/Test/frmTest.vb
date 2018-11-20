Imports System.Math

Public Class frmTest
    Dim points As List(Of PointF)
    Dim Polygon As clsPline

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        points = New List(Of PointF)
    End Sub
    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas1.MouseDown, picCanvas2.MouseDown
        points.Add(e.Location)
    End Sub

    Private Sub btnDraw_Click(sender As System.Object, e As System.EventArgs) Handles btnDraw.Click
        Dim n As Integer = 8, p As PointF
        For i = 0 To n
            p.X = 100 + 50 * Cos(i * 2 * PI / n)
            p.Y = 80 + 50 * Sin(i * 2 * PI / n)
            points.Add(p)
        Next
        Polygon = New clsPline(points)
        Polygon.DrawPolygon(picCanvas1.CreateGraphics)
    End Sub

    Private Sub btnDivide_Click(sender As System.Object, e As System.EventArgs) Handles btnDivide.Click
        Dim plines As List(Of clsPline) = Polygon.Divide(6)
        Dim cp As PointF = Polygon.GetCp()
        '以原多边形的中心点cp为中心,将多个多段线对象向外围爆炸平移
        Dim k As Single = 0.6  '爆炸位移的比例
        For i = 0 To plines.Count - 1
            Dim cpi As PointF = plines(i).GetCp()
            Dim dx As Single = (cpi.X - cp.X) * k
            Dim dy As Single = (cpi.Y - cp.Y) * k
            plines(i).Offset(dx, dy)
        Next
        For i = 0 To plines.Count - 1
            plines(i).DrawPline(picCanvas2.CreateGraphics)
        Next
    End Sub
End Class
