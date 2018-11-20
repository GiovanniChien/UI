Imports System.Windows.Media.Media3D
Imports System.IO
Imports System.Text.RegularExpressions

Public Class clsGeometry3D
    Private points As Point3DCollection
    Private pindex As Int32Collection

    Public Sub New(fname As String)
        points = New Point3DCollection()
        pindex = New Int32Collection()
        Dim content As String
        Using fs As New FileStream(fname, FileMode.Open)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                content = sr.ReadToEnd()
            End Using
        End Using
        Dim Reg As New Regex("[\s*\-\+]?\d*.\d+(E)+[[\+\-]?\d+]?")
        Dim Match As Match = Reg.Match(content)
        Dim x, y, z As Single
        While Match.Success = True
            x = Match.Value : Match = Match.NextMatch()
            y = Match.Value : Match = Match.NextMatch()
            z = Match.Value : Match = Match.NextMatch()
            For i = 1 To 3
                x = Match.Value : Match = Match.NextMatch()
                y = Match.Value : Match = Match.NextMatch()
                z = Match.Value : Match = Match.NextMatch()
                points.Add(New Point3D(x, y, z))
            Next
        End While
        For i = 0 To points.Count / 3 - 1
            pindex.Add(i * 3) : pindex.Add(i * 3 + 1) : pindex.Add(i * 3 + 2)
        Next
    End Sub

    Public Function Draw() As MeshGeometry3D
        Dim Mesh3D As New MeshGeometry3D
        Mesh3D.Positions = points
        Mesh3D.TriangleIndices = pindex
        Return Mesh3D
    End Function


    Public Sub Transform(m As Matrix3D)
        For i = 0 To points.Count - 1
            points(i) = m.Transform(points(i))
        Next
    End Sub

End Class
