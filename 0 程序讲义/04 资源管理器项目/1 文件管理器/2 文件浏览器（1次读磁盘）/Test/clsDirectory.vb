Imports System.IO

Public Class clsDirectory

    Public Root As TreeNode

    Public Sub New(pathname As String)
        Root = CreateNode(pathname)
    End Sub

    Public Function CreateNode(pathname As String) As TreeNode
        Dim directories() As String = Directory.GetDirectories(pathname)
        Dim node As TreeNode = New TreeNode(Path.GetFileNameWithoutExtension(pathname))
        ' node.Tag存储了文件夹pathname中的所有文件组成的集合对象
        node.Tag = New clsFiles(pathname)
        For i = 0 To directories.Count - 1
            node.Nodes.Add(CreateNode(directories(i)))
        Next
        Return node
    End Function
End Class
