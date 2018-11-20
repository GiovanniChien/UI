Public Class clsEdgeLists
    Private EdgeLists As SortedList(Of Integer, clsEdgeList) ' 按扫描线行号排序的表

    Public Sub New(ByVal Vertexes As List(Of Point))
        EdgeLists = New SortedList(Of Integer, clsEdgeList)
        For i = 0 To Vertexes.Count - 1
            Dim sp As Point = Vertexes(i)
            Dim ep As Point = Vertexes((i + 1) Mod Vertexes.Count)
            If sp.Y = ep.Y Then Continue For ' 舍弃水平线
            Dim e As clsEdge
            If sp.Y < ep.Y Then
                e = New clsEdge(sp, ep) : Insert(sp.Y, e)
            Else
                e = New clsEdge(ep, sp) : Insert(ep.Y, e)
            End If
        Next
        For Each EdgeList As clsEdgeList In EdgeLists.Values
            EdgeList.Sort()
        Next
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
            ActiveList.Sort()       ' 保持当前边表按照X值增序
            ' 记录每条扫描线中的多边形的内部点集
            Y_Xs.Add(y, ActiveList.GetPixels())
            ActiveList.NextY()      ' 计算下一条扫描线与边结点的交点
            ActiveList.Purge(y)     ' 清除无效的边结点
        Next
        Return Y_Xs
    End Function

    Private Sub Insert(ByVal y As Integer, ByVal e As clsEdge)
        Dim EdgeList As clsEdgeList = Nothing
        If EdgeLists.ContainsKey(y) Then EdgeList = EdgeLists(y)
        If EdgeList Is Nothing Then
            EdgeList = New clsEdgeList
            EdgeLists.Add(y, EdgeList)
        End If
        EdgeList.Append(e)
    End Sub

End Class
