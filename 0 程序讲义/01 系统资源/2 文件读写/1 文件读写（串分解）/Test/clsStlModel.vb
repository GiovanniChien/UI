Imports System.IO

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
        Dim facet, endfacet As Integer
        Dim sTris As String
        facet = 0
        Do
            facet = content.IndexOf("facet", facet)
            endfacet = content.IndexOf("endfacet", facet)
            If endfacet = -1 Then Exit Do
            '将content分解多个facet...endfacet块
            sTris = content.Substring(facet, endfacet - facet)
            Tris.Add(New clsTriangle(sTris))
            facet = endfacet + 1
        Loop
    End Sub

    Sub Display(lstTri As ListBox)
        With lstTri.Items
            .Clear()
            For i = 0 To Tris.Count - 1
                .Add(Tris(i).ToString)
            Next
        End With
    End Sub

    Public Sub Save(fname As String)
        Using fs As New IO.FileStream(fname, FileMode.Create)
            Using sw As New StreamWriter(fs, System.Text.Encoding.Default)
                sw.WriteLine("solid Model")
                For i = 0 To Tris.Count - 1
                    sw.WriteLine(Tris(i).ToString)
                Next
                sw.WriteLine("endsolid Model")
            End Using
        End Using
    End Sub

End Class
