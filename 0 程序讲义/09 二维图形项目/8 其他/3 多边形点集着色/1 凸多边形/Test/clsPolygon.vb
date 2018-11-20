Imports System.Math

Public Class clsPolygon
    Private colors As List(Of Integer)
    Private points As List(Of Point)

    Public Sub New()
        colors = New List(Of Integer)
        points = New List(Of Point)
        points.Add(New Point(50, 50)) : colors.Add(250)
        points.Add(New Point(150, 50)) : colors.Add(0)
        points.Add(New Point(150, 150)) : colors.Add(125)
        points.Add(New Point(50, 150)) : colors.Add(0)
    End Sub

    Public Sub Draw(ByVal picCanvas As PictureBox)
        Dim buff As Bitmap = New Bitmap(picCanvas.Width, picCanvas.Height)
        DrawKeyPoints(buff)
        FillPoints(buff)
        picCanvas.Image = buff
    End Sub

    Public Sub DrawKeyPoints(ByVal buff As Bitmap)
        '绘制关键点的位置及颜色
        For i = 0 To points.Count - 1
            buff.SetPixel(points(i).X, points(i).Y, Color.FromArgb(colors(i), 0, 0))
        Next
    End Sub
    Public Sub FillPoints(ByVal buff As Bitmap)
        '绘制区域中所有点的位置及颜色
        For x = 10 To 160
            For y = 10 To 160
                Dim v As Integer = GetColor(x, y)
                buff.SetPixel(x, y, Color.FromArgb(v, 0, 0))
            Next
        Next
    End Sub

    Private Function GetColor(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim dx, dy As Integer
        Dim dists As New List(Of Single)
        For i = 0 To points.Count - 1
            dx = points(i).X - x : dy = points(i).Y - y
            dists.Add(sqrt(dx * dx + dy * dy))
        Next
        ' dists已经是距离向量
        Dim sum As Single = dists.Sum()
        For i = 0 To dists.Count - 1
            dists(i) = dists(i) / sum
        Next
        ' dists已经是距离向量的单位向量，即dists(i)的总和等于1
        For i = 0 To dists.Count - 1
            If dists(i) = 0 Then
                dists(i) = 1
            Else
                dists(i) = 1 / dists(i)
            End If
        Next
        ' dists 成为倒数向量
        Dim sumum As Single = 0
        For i = 0 To dists.Count - 1
            sumum += dists(i) * dists(i)
        Next
        For i = 0 To dists.Count - 1
            dists(i) = dists(i) * dists(i) / sumum
        Next
        ' dists 成为影响力的权重向量
        Dim val As Single = 0
        For i = 0 To points.Count - 1
            val += colors(i) * dists(i)
        Next
        Return val
    End Function

End Class
