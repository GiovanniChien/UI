Imports System.Math

Public Class frmTest
    Dim polygon As clsPolygon
    Dim polygons As List(Of clsPolygon)
    Dim sourceColor As Color = Color.FromArgb(255, 0, 0)
    Dim TargetColor As Color = Color.FromArgb(0, 255, 255)

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim points As New List(Of PointF)
        Dim cp As PointF = New PointF(200, 200)
        Dim r As Single = 150
        For angle = 0 To 359 Step 30
            Dim x As Single = cp.X + r * Cos(angle / 180 * PI)
            Dim y As Single = cp.X + r * Sin(angle / 180 * PI)
            points.Add(New PointF(x, y))
        Next
        polygon = New clsPolygon(sourceColor, points)
        polygons = New List(Of clsPolygon)
    End Sub

    Private Sub btnExpand_Click(sender As System.Object, e As System.EventArgs) Handles btnExpand.Click
        Dim n As Integer = 12    ' 扩展的层数 22 52
        Dim delta As Single = 8  ' 扩展的间距
        For i = 1 To n
            Dim newcolor As Color = GetColor(sourceColor, TargetColor, n, i)
            Dim newpolygon As clsPolygon = polygon.Expand(delta * i, newcolor)
            polygons.Add(newpolygon)
        Next
        Draw()
    End Sub

    '经过n次插值，sc变为tc    (index=1第一层，  index=n最后一层）
    Function GetColor(sc As Color, tc As Color, n As Integer, index As Integer) As Color
        Dim r As Integer = (-sc.R + tc.R) / n * index + sc.R
        Dim g As Integer = (-sc.G + tc.G) / n * index + sc.G
        Dim b As Integer = (-sc.B + tc.B) / n * index + sc.B
        Return Color.FromArgb(r, g, b)
    End Function

    Private Sub picCanvas_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        Draw()
    End Sub
    Private Sub Draw()
        Dim g As Graphics = picCanvas.CreateGraphics
        polygon.Draw(g)
        For i = 0 To polygons.Count - 1
            polygons(i).Draw(g)
        Next
        g.Flush()
    End Sub


End Class






