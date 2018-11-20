Imports System.IO

Public Class clsDirectory
    Public Files As List(Of String)
    Public Directories As List(Of clsDirectory)

    Public Sub New(PathName As String)
        Create(PathName)
    End Sub
    Private Sub Create(PathName As String)
        Files = Directory.GetFiles(PathName).ToList
        directories = New List(Of clsDirectory)
        Dim foldes() As String = Directory.GetDirectories(PathName)
        For i = 0 To foldes.Count - 1
            Directories.Add(New clsDirectory(foldes(i)))
        Next
    End Sub

    Public Sub Output(lstFile As ListBox)
        For i = 0 To Files.Count - 1
            lstFile.Items.Add(Files(i))
        Next
        For i = 0 To Directories.Count - 1
            Directories(i).Output(lstFile)
        Next

    End Sub

End Class
