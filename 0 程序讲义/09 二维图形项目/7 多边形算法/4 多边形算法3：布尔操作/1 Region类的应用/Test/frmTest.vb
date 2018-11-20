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
        Path.AddLines(points.ToArray)
        Dim G As Graphics = picCanvas.CreateGraphics
        If sender Is btnCreate1 Then r1 = New Region(Path)
        If sender Is btnCreate2 Then r2 = New Region(Path)
        points.Clear()
        Draw(picCanvas.CreateGraphics)
    End Sub

    Private Sub btnUnion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnion.Click, btnXor.Click, btnIntersect.Click
        r3 = r1.Clone
        If sender Is btnUnion Then r3.Union(r2)
        If sender Is btnIntersect Then r3.Intersect(r2)
        If sender Is btnXor Then r3.Xor(r2)
        Draw(picCanvas.CreateGraphics)
    End Sub

    Private Sub Draw(ByVal G As Graphics)
        If r1 IsNot Nothing Then G.FillRegion(Brushes.Blue, r1)
        If r2 IsNot Nothing Then G.FillRegion(Brushes.Blue, r2)
        If r3 IsNot Nothing Then G.FillRegion(Brushes.Red, r3)
    End Sub

    Private Sub picCanvas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        Draw(e.Graphics)
    End Sub
End Class
