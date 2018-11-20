Imports System.IO

Public Class clsPointCloud
    Private Points As List(Of clsPoint)
    Private box As clsBox

    Public Sub New(fname As String)
        Points = New List(Of clsPoint)
        box = Nothing
        Dim Line As String, xyzargb(6) As String
        Using fs As New IO.FileStream(fname, FileMode.Open, FileAccess.Read)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                Dim i As Integer = 0
                While Not sr.EndOfStream
                    Line = sr.ReadLine()
                    xyzargb = Line.Split(" ")
                    Points.Add(New clsPoint(xyzargb))
                    If box Is Nothing Then
                        box = New clsBox(Points(i).x, Points(i).y, Points(i).z)
                    Else
                        box.Contain(Points(i).x, Points(i).y, Points(i).z)
                    End If
                    i += 1
                End While
            End Using
        End Using
    End Sub

    ' 在buff中绘制像素点
    Private Sub Draw(buff As Bitmap, vp As List(Of PointF))
        For i = 0 To vp.Count - 1
            buff.SetPixel(vp(i).X, vp(i).Y, Points(i).color)
        Next
    End Sub

    Public Sub Draw(picCanvas As PictureBox)
        ' 准备用于显示的点坐标
        ' 创建List对象时，指定List的容量，能够提高效率
        Dim xy As List(Of PointF) = New List(Of PointF)(Points.Count)
        Dim xz As List(Of PointF) = New List(Of PointF)(Points.Count)
        Dim yz As List(Of PointF) = New List(Of PointF)(Points.Count)
        For i = 0 To Points.Count - 1
            xy.Add(New PointF(Points(i).x, Points(i).y))
            xz.Add(New PointF(Points(i).x, Points(i).z))
            yz.Add(New PointF(Points(i).y, Points(i).z))
        Next
        Dim xyrect As RectangleF = box.GetRect(ViewKind.XY)
        Dim xzrect As RectangleF = box.GetRect(ViewKind.XZ)
        Dim yzrect As RectangleF = box.GetRect(ViewKind.YZ)
        ' 准备用于显示的视区范围
        '左侧
        Dim xyview As RectangleF = New RectangleF(0, picCanvas.Height, picCanvas.Width / 2, -picCanvas.Height)
        '右上方
        Dim xzview As RectangleF = New RectangleF(picCanvas.Width / 2, picCanvas.Height / 2, picCanvas.Width / 2, -picCanvas.Height / 2)
        '右下方
        Dim yzview As RectangleF = New RectangleF(picCanvas.Width / 2, picCanvas.Height, picCanvas.Width / 2, -picCanvas.Height / 2)
        ' 准备矩阵，变换点集合的坐标
        Dim Mxy As clsMatrix3 = New clsMatrix3 : Mxy.SetWindowView(xyrect, xyview) : Mxy.Tranform(xy)
        Dim Mxz As clsMatrix3 = New clsMatrix3 : Mxz.SetWindowView(xzrect, xzview) : Mxz.Tranform(xz)
        Dim Myz As clsMatrix3 = New clsMatrix3 : Myz.SetWindowView(yzrect, yzview) : Myz.Tranform(yz)
        ' 绘制点云的三视图
        Dim buff As Bitmap = New Bitmap(picCanvas.Width, picCanvas.Height)
        Dim g As Graphics = Graphics.FromImage(buff)
        g.Clear(Color.White) ' picCanvas.BackColor
        Draw(buff, xy) : Draw(buff, xz) : Draw(buff, yz)
        picCanvas.Image = buff : picCanvas.Refresh()
    End Sub

End Class
