Imports System.IO

Public Class ClaDirectory
    Dim Files As New List(Of String)
    Dim Directories As New List(Of String)

    Public Sub New(path As String)
        Files = Directory.GetFiles(path).ToList
        Directories = Directory.GetDirectories(path).ToList
    End Sub
    Sub Display(lstInfo As ListBox)
        For i = 0 To Files.Count - 1
            lstInfo.Items.Add(Files(i))
        Next

        For i = 0 To Directories.Count - 1
            lstInfo.Items.Add(Directories(i))
        Next
    End Sub
End Class
