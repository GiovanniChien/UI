Public Class clsEdgeLists
    Private EdgeLists As SortedList(Of Integer, clsEdgeList) ' 按扫描线行号排序的表

    Public Sub New(ByVal OutVertexes As List(Of Point), ByVal InVertexes As List(Of List(Of Point)))
        EdgeLists = New SortedList(Of Integer, clsEdgeList)
        Append(OutVertexes)
        For i = 0 To InVertexes.Count - 1
            Append(InVertexes(i))
        Next
    End Sub
    Private Sub Append(ByVal Vertexes As List(Of Point))
        For i = 0 To Vertexes.Count - 1
            Dim p1 As Point = Vertexes(i)
            Dim p2 As Point = Vertexes((i + 1) Mod Vertexes.Count)
            Dim p3 As Point = Vertexes((i + 2) Mod Vertexes.Count)
            Dim e As clsEdge = New clsEdge(p1, p2, p3)
            Insert(e)
        Next
    End Sub
    Private Sub Insert(ByVal e As clsEdge)
        Dim EdgeList As clsEdgeList = Nothing
        If EdgeLists.ContainsKey(e.ymin) Then
            EdgeList = EdgeLists(e.ymin)
        Else
            EdgeList = New clsEdgeList
            EdgeLists.Add(e.ymin, EdgeList)
        End If
        EdgeList.Append(e)
    End Sub

    Public Function Fill() As SortedList(Of Integer, List(Of Integer))
        Dim Y_Xs As New SortedList(Of Integer, List(Of Integer))
        Dim ActiveList As New clsEdgeList
        Dim maxY As Integer = EdgeLists(EdgeLists.Keys.Max).MaxY
        For y = EdgeLists.Keys.Min To maxY '逐条处理每个扫描线
            ' 将有序边表EdgeLists(y)，添加到ActiveList中
            If EdgeLists.ContainsKey(y) Then
                ActiveList.Append(EdgeLists(y))
            End If
            ' 计算交点对的集合
            Dim Xps As List(Of Single) = ActiveList.GetXps(y)
            Xps.Sort()       ' 保持当前边表按照X值增序
            ' 计算内部点集
            Dim InnPs As New List(Of Integer)
            For i = 0 To Xps.Count - 2 Step 2
                ' 忽略左边界点 x:5=>x1:6   x:5.1=>x1:6  x:5.9=>x1:6
                Dim x1 As Integer = Int(Xps(i) + 1)
                Dim x2 As Integer = Cell(Xps(i + 1)) - 1
                ' 忽略右边界点 x:5=>x2:4   x:5.1=>x1:5  x:5.9=>x1:5
                For x = x1 To x2
                    InnPs.Add(x)
                Next
            Next
            ' 记录每条扫描线中的多边形的内部点集
            Y_Xs.Add(y, InnPs)
            ActiveList.Purge(y)     ' 清除无效的边结点
        Next
        Return Y_Xs
    End Function

    Private Function Cell(ByVal x As Single) As Integer
        Dim y As Integer = Fix(x)
        If x > y Then
            Return y + 1
        Else
            Return y
        End If
    End Function

End Class
