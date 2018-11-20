Public Class ClsTree
    Private root As TreeNode

    Sub New(ByVal tuples As List(Of System.Tuple(Of String, String)))
        root = New TreeNode(tuples(0).Item1)
        root.Nodes.Add(tuples(0).Item2)
        For i = 1 To tuples.Count - 1
            Dim parent As String = tuples(i).Item1
            Dim child As String = tuples(i).Item2
            Append(parent, child)
        Next
    End Sub

    ReadOnly Property GetRoot
        Get
            Return root
        End Get
    End Property

    Private Sub Append(ByVal parent As String, ByVal child As String)
        Dim parentNode As TreeNode = Search(root, parent)
        If parentNode Is Nothing Then Return
        Dim childNode As New TreeNode(child)
        parentNode.Nodes.Add(childNode)
    End Sub

    Private Function Search(ByVal root As TreeNode, ByVal key As String) As TreeNode
        If root.Text = key Then
            Return root
        End If
        Dim child As TreeNode = root.FirstNode
        While child IsNot Nothing
            Dim resultNode As TreeNode = Search(child, key)
            If resultNode IsNot Nothing Then
                Return resultNode
            End If
            child = child.NextNode
        End While
        Return Nothing
    End Function

End Class
