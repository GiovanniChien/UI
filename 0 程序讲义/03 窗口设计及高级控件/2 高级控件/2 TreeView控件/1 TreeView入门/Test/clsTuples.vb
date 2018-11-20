
'管理树形结构中的二元关系集合
Public Class clsTree
    Public Tuples As List(Of Tuple(Of String, String)) '树形结构中的二元关系集合
    Public Root As TreeNode   '二元关系集合的图形表示

    Public Sub New()
        Tuples = New List(Of Tuple(Of String, String))
        Tuples.Add(New Tuple(Of String, String)("Elems", "Lines"))
        Tuples.Add(New Tuple(Of String, String)("Elems", "Circles"))
        Tuples.Add(New Tuple(Of String, String)("Elems", "Rectangles"))
        Tuples.Add(New Tuple(Of String, String)("Lines", "Line1"))
        Tuples.Add(New Tuple(Of String, String)("Lines", "Line2"))
        Tuples.Add(New Tuple(Of String, String)("Lines", "Line3"))
        Tuples.Add(New Tuple(Of String, String)("Circles", "Circle1"))
        Tuples.Add(New Tuple(Of String, String)("Circles", "Circle2"))
        Tuples.Add(New Tuple(Of String, String)("Circles", "Circle3"))
        Tuples.Add(New Tuple(Of String, String)("Rectangles", "Rectangle1"))
        Tuples.Add(New Tuple(Of String, String)("Rectangles", "Rectangle2"))
        Tuples.Add(New Tuple(Of String, String)("Rectangles", "Rectangle3"))
        CreateRoot()
    End Sub

    Private Sub CreateRoot()
        Dim parant As String = Tuples(0).Item1
        Dim child As String = Tuples(0).Item2
        Root = New TreeNode(parant) : Root.Nodes.Add(child)
        For i = 1 To Tuples.Count - 1
            AppendNode(Tuples(i))
        Next
    End Sub
    Private Function AppendNode(tuple As Tuple(Of String, String)) As Boolean
        Dim parentnode As TreeNode = SearchNode(Root, tuple.Item1)
        If parentnode Is Nothing Then Return False
        parentnode.Nodes.Add(tuple.Item2)
        Return True
    End Function

    Public Sub Append(tuple As Tuple(Of String, String))
        If AppendNode(tuple) = True Then
            '树中添加了节点，二元关系集合才能添加二元关系
            Tuples.Add(tuple)
        End If
    End Sub

    '在node所表示的属性结构中，查找关键值为key的节点
    Private Function SearchNode(node As TreeNode, key As String) As TreeNode
        If node.Text = key Then Return node
        For i = 0 To node.Nodes.Count - 1
            Dim node1 As TreeNode = SearchNode(node.Nodes(i), key)
            If node1 IsNot Nothing Then Return node1
        Next
        Return Nothing
    End Function

    Public Sub Remove(key As String)
        If RemoveNode(key) = False Then Return
        For i = Tuples.Count - 1 To 0 Step -1
            If Tuples(i).Item1 = key Or Tuples(i).Item2 = key Then
                Tuples.RemoveAt(i)
            End If
        Next
    End Sub
    Private Function RemoveNode(key As String) As Boolean
        Dim node As TreeNode = SearchNode(Root, key)
        If node Is Nothing Then Return False
        Dim parentnode As TreeNode = node.Parent()
        If parentnode Is Nothing Then Return False '企图删除根节点
        parentnode.Nodes.Remove(node)
        Return True
    End Function

End Class
