Imports System.IO

Public Class ClaDirectory
    Dim Files As List(Of String)
    Dim Directories As List(Of ClaDirectory)

    Public Sub New(path As String)
        Files = Directory.GetFiles(path).ToList
        Directories = New List(Of ClaDirectory)
        Dim ds As String()
        ds = Directory.GetDirectories(path)
        For i = 0 To ds.Count - 1
            Dim obj As New ClaDirectory(ds(i))
            Directories.Add(obj)
        Next
    End Sub
    Sub Display(lstInfo As ListBox)
        For i = 0 To Files.Count - 1
            lstInfo.Items.Add(Files(i))
        Next

        For i = 0 To Directories.Count - 1
            Directories(i).Display(lstInfo)
        Next
    End Sub
End Class
