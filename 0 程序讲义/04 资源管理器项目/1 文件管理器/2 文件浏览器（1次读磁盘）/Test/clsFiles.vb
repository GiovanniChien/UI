Imports System.IO

Public Class clsFiles
    Public files() As String
    Public items() As ListViewItem

    Public Sub New(pathname As String)
        files = Directory.GetFiles(pathname, "*.*", SearchOption.TopDirectoryOnly)
        ReDim items(files.Count - 1)
        For i = 0 To files.Count - 1
            Dim file As clsFile = New clsFile(files(i))
            items(i) = file.item
        Next
    End Sub

End Class
