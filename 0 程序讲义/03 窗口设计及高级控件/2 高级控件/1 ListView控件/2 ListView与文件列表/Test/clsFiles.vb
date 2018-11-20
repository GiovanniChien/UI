Imports System.IO

Public Class clsFiles
    Public Files() As String   '文件名
    Public Items() As ListViewItem

    Public Sub New(pathname As String)
        Files = Directory.GetFiles(pathname, "*.*", SearchOption.TopDirectoryOnly)
        ReDim Items(Files.Count - 1)
        For i = 0 To Files.Count - 1
            Dim file As clsFile = New clsFile(Files(i))
            Items(i) = file.Item
        Next
    End Sub

    Public Sub Sort(columnid As Integer)
        Dim compare As ItemComparer = New ItemComparer(columnid)
        Array.Sort(Items, compare)
    End Sub

End Class

