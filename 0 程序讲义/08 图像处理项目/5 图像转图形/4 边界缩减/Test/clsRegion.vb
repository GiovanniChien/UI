' Buff中Mark的连通分量（区域）
Public Class clsRegion
    Private Points As List(Of Point)  '区域内部的点集合

    Public Sub New(Points As List(Of Point))
        Me.Points = Points
    End Sub

    Public Function PointCount() As Integer
        Return Points.Count
    End Function

    Public Sub Draw(Buff As Bitmap, Mark As Color)
        For i = 0 To Points.Count - 1
            Buff.SetPixel(Points(i).X, Points(i).Y, Mark)
        Next
    End Sub

    ' 计算边界点集。
    ' 边界点的约束条件：或是位图的边界点，或相邻上下左右点的颜色不等于MarkArgb
    Public Function GetBorder(Buff As Bitmap) As clsBorder
        Dim Border As clsBorder = New clsBorder       '区域边界的点集合对象
        Dim MarkArgb As Integer = Buff.GetPixel(Points(0).X, Points(0).Y).ToArgb
        Dim Width As Integer = Buff.Width, Height As Integer = Buff.Height
        Dim x, y As Integer
        For i = 0 To Points.Count - 1
            x = Points(i).X : y = Points(i).Y
            If x - 1 < 0 Then Border.Add(Points(i)) : Continue For
            If Buff.GetPixel(x - 1, y).ToArgb <> MarkArgb Then Border.Add(Points(i)) : Continue For
            If x + 1 >= Width Then Border.Add(Points(i)) : Continue For
            If Buff.GetPixel(x + 1, y).ToArgb <> MarkArgb Then Border.Add(Points(i)) : Continue For
            If y - 1 < 0 Then Border.Add(Points(i)) : Continue For
            If Buff.GetPixel(x, y - 1).ToArgb <> MarkArgb Then Border.Add(Points(i)) : Continue For
            If y + 1 >= Height Then Border.Add(Points(i)) : Continue For
            If Buff.GetPixel(x, y + 1).ToArgb <> MarkArgb Then Border.Add(Points(i)) : Continue For
        Next
        Return Border
    End Function
End Class
