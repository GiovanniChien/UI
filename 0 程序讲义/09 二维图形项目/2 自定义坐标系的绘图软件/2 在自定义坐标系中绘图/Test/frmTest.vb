Public Class frmTest
    Dim M As clsMatrix   '将 像素坐标系 转换为 世界(自定义的逻辑)坐标系
    Dim RM As clsMatrix  '将 世界(自定义的逻辑)坐标系 转换为 像素坐标系
    Dim cs As clsCS2
    Dim sp As PointF

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        M = New clsMatrix
        RM = New clsMatrix
    End Sub

    Private Sub btnSetup_Click(sender As System.Object, e As System.EventArgs) Handles btnSetup.Click
        Dim xmin As Single = txtXmin.Text, xmax As Single = txtXmax.Text
        Dim ymin As Single = txtYmin.Text, ymax As Single = txtYmax.Text
        Dim xscale As Single = (xmax - xmin) / picCanvas.Width
        Dim yscale As Single = (ymax - ymin) / picCanvas.Height
        Dim m2 As New clsMatrix
        M.SetScale(xscale, -yscale) : m2.SetPan(xmin, ymax) : M.Mul(m2)
        RM.SetPan(-xmin, -ymax) : m2.SetScale(1 / xscale, -1 / yscale) : RM.Mul(m2)

        cs = New clsCS2(xmin, xmax, ymin, ymax)
        Dim g As Graphics = picCanvas.CreateGraphics
        cs.draw(g, RM)
    End Sub

    Private Sub picCanvas_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        Dim p As PointF = e.Location
        p = M.Transform(p)   '获得像素点在自定义坐标系中的坐标表示
        Text = p.X & "," & p.Y
    End Sub

    Private Sub picCanvas_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = M.Transform(e.Location)
    End Sub

    Private Sub picCanvas_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim ep As PointF = M.Transform(e.Location)
        Dim Line As clsLine = New clsLine(sp, ep)
        Line.draw(picCanvas.CreateGraphics(), RM)
    End Sub

End Class
