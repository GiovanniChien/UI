Public Class clsPolygon
    Private Vertexes As List(Of Point)

    Public Sub New(ByVal sps As List(Of Point))
        Vertexes = sps
    End Sub
    Public Sub New()
        Vertexes = New List(Of Point)
    End Sub
    Public Sub Append(ByVal p As Point)
        Vertexes.Add(p)
    End Sub

    '扫描线填充算法
    Public Function GetInPoints() As SortedList(Of Integer, List(Of Integer))
        Dim EdgeLists As clsEdgeLists = New clsEdgeLists(Vertexes)
        Return EdgeLists.Fill()
    End Function
    Public Sub Fill(ByVal buffer As Bitmap, ByVal color As Color)
        Dim Points As SortedList(Of Integer, List(Of Integer)) = GetInPoints()
        For y = Points.Keys.Min To Points.Keys.Max
            For Each x As Integer In Points(y)
                buffer.SetPixel(x, y, color)
            Next
        Next
    End Sub
    ' 绘制多边形的边界线
    Public Sub DrawBorder(ByVal buffer As Bitmap, ByVal color As Color)
        Dim g As Graphics = Graphics.FromImage(buffer)
        Dim Pen As Pen = New Pen(color)
        g.DrawPolygon(Pen, Vertexes.ToArray)
    End Sub

End Class




