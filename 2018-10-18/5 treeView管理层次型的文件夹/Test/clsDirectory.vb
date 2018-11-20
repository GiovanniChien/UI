Imports System.IO

Public Class clsDirectory
    'Dim files() As String
    'Dim Directories() As String
    Dim name As String
    Dim files As List(Of String)
    Dim Directories As List(Of clsDirectory)
    Public Node As TreeNode

    Public Sub New(ByVal pathName As String)
        name = pathName
        files = Directory.GetFiles(name).ToList
        Dim Ds() As String = Directory.GetDirectories(name)
        Node = New TreeNode(Path.GetFileNameWithoutExtension(name))
        Directories = New List(Of clsDirectory)
        For i = 0 To files.Count - 1
            Dim fileNode As TreeNode = New TreeNode(Path.GetFileName(files(i)))
            Node.Nodes.Add(fileNode)
        Next
        For i = 0 To Ds.Count - 1
            Dim objD As New clsDirectory(Ds(i))
            Directories.Add(objD)
            Node.Nodes.Add(objD.Node)
        Next
    End Sub


End Class
