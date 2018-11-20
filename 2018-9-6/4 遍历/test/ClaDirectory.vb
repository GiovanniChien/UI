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

    Friend Function Count() As Integer
        Dim sum As Integer = Files.Count
        For i = 0 To Directories.Count - 1
            sum += Directories(i).Count()
        Next
        Return sum
    End Function

    Friend Function Depth() As Integer
        Dim maxDepth As Integer = 0
        For i = 0 To Directories.Count - 1
            Dim temp As Integer = Directories(i).Depth()
            If temp > maxDepth Then
                maxDepth = temp
            End If
        Next
        Return maxDepth + 1
    End Function

    Friend Function Search(text As String) As List(Of String)
        Dim res As List(Of String) = New List(Of String)
        For i = 0 To Files.Count - 1
            If Files(i).ToLower.Contains(text.ToLower) Then
                res.Add(Files(i))
            End If
        Next
        For i = 0 To Directories.Count - 1
            Dim tempRes As List(Of String) = New List(Of String)
            tempRes = Directories(i).Search(text)
            res.AddRange(tempRes)
        Next
        Return res
    End Function
End Class
