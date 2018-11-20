Imports System.Math

Public Class frmTest
    Dim points As List(Of PointF)
    Dim r1, r2, r3 As Region

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        points = New List(Of PointF)
    End Sub
    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        points.Add(e.Location)
    End Sub

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate1.Click, btnCreate2.Click
        Dim Path As New Drawing2D.GraphicsPath
        For i = 0 To points.Count - 2
            Path.AddLine(points(i), points(i + 1))
        Next
        Path.AddLine(points(points.Count - 1), points(0))
        Dim G As Graphics = picCanvas.CreateGraphics
        G.DrawPath(Pens.Black, Path)

        If sender Is btnCreate1 Then r1 = New Region(Path) : G.FillRegion(Brushes.Blue, r1)
        If sender Is btnCreate2 Then r2 = New Region(Path) : G.FillRegion(Brushes.Blue, r2)
        points.Clear()
    End Sub

    Private Sub btnUnion_Click(sender As System.Object, e As System.EventArgs) Handles btnUnion.Click
        Dim angle As Single = 10 / 180 * PI
        Dim m1, m2, m3 As Drawing2D.Matrix
        m1 = New Drawing2D.Matrix(1, 0, 0, 1, 200, 200)
        m2 = New Drawing2D.Matrix(Cos(angle), -Sin(angle), Sin(angle), Cos(angle), 100, 0)
        m3 = New Drawing2D.Matrix(1, 0, 0, 1, -200, -200)
        m1.Multiply(m2)
        m1.Multiply(m3)
        r1.Transform(m1)
        Dim G As Graphics = picCanvas.CreateGraphics
        G.FillRegion(Brushes.Blue, r1)
    End Sub
End Class
