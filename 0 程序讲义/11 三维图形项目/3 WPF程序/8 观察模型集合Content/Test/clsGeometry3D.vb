Imports System.Windows.Media.Media3D
Imports System.IO
Imports System.Text.RegularExpressions

Public Class clsGeometry3D
    Private points As Point3DCollection
    Private pindex As Int32Collection
    Private normals As Vector3DCollection
    Dim TexturePoints As PointCollection

    Public Sub New(fname As String)
        points = New Point3DCollection()
        pindex = New Int32Collection()
        normals = New Vector3DCollection
        TexturePoints = New PointCollection
        Dim content As String
        Using fs As New FileStream(fname, FileMode.Open)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                content = sr.ReadToEnd()
            End Using
        End Using
        Dim Reg As New Regex(" [\s*\-\+]?\d*.\d+(E)+[[\+\-]?\d+]?")  '[\s*\-\+]?\d*.\d+[\e][[\+\-]?\d+]?"
        Dim Match As Match = Reg.Match(content)
        Dim x, y, z As Single
        While Match.Success = True
            x = Match.Value : Match = Match.NextMatch()
            y = Match.Value : Match = Match.NextMatch()
            z = Match.Value : Match = Match.NextMatch()
            normals.Add(New Vector3D(x, y, z))
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
        TexturePoints.Add(New Point(0, 0))
    End Sub

    Public Function Draw() As MeshGeometry3D
        Dim Mesh3D As New MeshGeometry3D
        Mesh3D.Positions = points
        Mesh3D.TriangleIndices = pindex
        Mesh3D.Normals = normals
        Mesh3D.TextureCoordinates = TexturePoints
        Return Mesh3D
    End Function

    Public Sub Transform(m As Matrix3D)
        For i = 0 To points.Count - 1
            points(i) = m.Transform(points(i))
        Next
    End Sub

End Class
