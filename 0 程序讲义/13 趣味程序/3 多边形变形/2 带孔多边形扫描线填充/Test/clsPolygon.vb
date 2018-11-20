Public Class clsPolygon
    Private OutVertexes As List(Of Point)         ' 外框端点序列
    Private InVertexes As List(Of List(Of Point)) ' 内框端点序列的集合

    Public Sub New(ByVal OutVertexes As List(Of Point), ByVal InVertexes As List(Of List(Of Point)))
        Me.OutVertexes = OutVertexes
        Me.InVertexes = InVertexes
    End Sub

    '扫描线填充算法
    Public Sub Fill(ByVal buffer As Bitmap, ByVal color As Color)
        Dim EdgeLists As clsEdgeLists = New clsEdgeLists(OutVertexes, InVertexes)
        Dim Points As SortedList(Of Integer, List(Of Integer)) = EdgeLists.Fill()
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
        g.DrawPolygon(Pen, OutVertexes.ToArray)
        For i = 0 To InVertexes.Count - 1
            g.DrawPolygon(Pen, InVertexes(i).ToArray)
        Next
    End Sub

End Class




