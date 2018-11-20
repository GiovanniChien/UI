Imports System.IO
Imports System.Text.RegularExpressions

Public Class clsStlModel
    Public Tris As List(Of clsTriangle)

    Public Sub New(fname As String)
        Tris = New List(Of clsTriangle)
        Dim content As String
        'Using...End Using 在代码退出该块时，可确保系统释放其中资源。本例用于关闭文件。 
        Using fs As New IO.FileStream(fname, FileMode.Open)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                content = sr.ReadToEnd()
            End Using
        End Using
        CreateModel(content)
    End Sub

    Private Sub CreateModel(ByRef content As String)
        Dim reg As Regex = New Regex("([+|-])?([1-9]\d*|0)(\.\d+)?E([+|-])([0-9]\d*)")
        Dim result As MatchCollection = reg.Matches(content)
        Dim p(2) As clsPoint3
        For i = 0 To result.Count - 1 Step 12
            p(0) = New clsPoint3(result(i + 3).Value, result(i + 4).Value, result(i + 5).Value)
            p(1) = New clsPoint3(result(i + 6).Value, result(i + 7).Value, result(i + 8).Value)
            p(2) = New clsPoint3(result(i + 9).Value, result(i + 10).Value, result(i + 11).Value)
            Tris.Add(New clsTriangle(p))
        Next
    End Sub

    Sub Display(lstTri As ListBox)
        With lstTri.Items
            .Clear()
            For i = 0 To Tris.Count - 1
                .Add(Tris(i).ToString)
            Next
        End With


    End Sub

End Class
