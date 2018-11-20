Imports System.IO

' 在TreeNode中，管理目录树结构
Public Class clsDirectoryTree

    Public Root As TreeNode   '根节点

    Public Sub New(pathname As String)
        Root = CreateTree(pathname)
    End Sub

    Public Function CreateTree(pathname As String) As TreeNode
        Dim directories() As String = Directory.GetDirectories(pathname)
        Dim node As TreeNode = New TreeNode(Path.GetFileName(pathname)) '不含路径
        If Root Is Nothing Then
            Root = New TreeNode(pathname) '含路径
            node = Root                   '丢弃已创建的对象
        End If
        For i = 0 To directories.Count - 1
            node.Nodes.Add(CreateTree(directories(i)))
        Next
        Return node
    End Function
    Public Sub CreateNode(node As TreeNode, key As String)
        node.Nodes.Add(key)
        Dim path As String = node.FullPath & "\" & key
        Directory.CreateDirectory(path)
    End Sub

    Public Sub DeleteFolder(node As TreeNode)
        Dim path As String = node.FullPath
        Try
            Directory.Delete(path)
        Catch ex As Exception
            Return
        End Try
        node.Remove()
    End Sub

    Public Sub RenameFolder(node As TreeNode, NewFolderName As String)
        Dim Fullpath As String = Path.GetFullPath(NewFolderName)
        Try
            Directory.Move(node.FullPath, NewFolderName)
        Catch ex As Exception
            Return
        End Try
        node.Text = NewFolderName
    End Sub

End Class
