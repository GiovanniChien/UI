Imports System.Drawing.Drawing2D

Public Class frmTest
    Dim M As Matrix   '将 像素坐标系 转换为 世界(自定义的逻辑)坐标系
    Dim RM As Matrix  '将 世界(自定义的逻辑)坐标系 转换为 像素坐标系
    Dim cs As clsCS2

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        M = New Matrix
        RM = New Matrix
    End Sub

    Private Sub btnSetup_Click(sender As System.Object, e As System.EventArgs) Handles btnSetup.Click
        Dim xmin As Single = txtXmin.Text, xmax As Single = txtXmax.Text
        Dim ymin As Single = txtYmin.Text, ymax As Single = txtYmax.Text
        Dim xscale As Single = (xmax - xmin) / picCanvas.Width
        Dim yscale As Single = (ymax - ymin) / picCanvas.Height
        M = New Matrix
        M.Scale(xscale, -yscale, MatrixOrder.Append)
        M.Translate(xmin, ymax, MatrixOrder.Append)

        'RM = M.Clone : RM.Invert()
        RM = New Matrix()
        RM.Translate(-xmin, -ymax, MatrixOrder.Append)
        RM.Scale(1 / xscale, -1 / yscale, MatrixOrder.Append)
        cs = New clsCS2(xmin, xmax, ymin, ymax)
        Dim g As Graphics = picCanvas.CreateGraphics
        cs.draw(g, RM)
    End Sub

    Private Sub picCanvas_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        Dim ps(0) As PointF
        ps(0) = e.Location
        M.TransformPoints(ps)   '获得像素点在自定义坐标系中的坐标表示
        Text = ps(0).X & "," & ps(0).Y
    End Sub

    Private Sub picCanvas_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        If cs Is Nothing Then Return
        Dim g As Graphics = e.Graphics
        cs.draw(g, RM)
    End Sub
End Class