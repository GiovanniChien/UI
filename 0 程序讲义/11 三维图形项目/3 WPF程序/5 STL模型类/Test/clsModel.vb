Imports System.Windows.Media.Media3D
Imports System.IO
Imports System.Text.RegularExpressions

Public Class clsModel
    Private points As Point3DCollection
    Private pindex As Int32Collection

    Public Sub New(fname As String)
        points = New Point3DCollection()
        pindex = New Int32Collection
        Dim content As String
        Using fs As New FileStream(fname, FileMode.Open)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                content = sr.ReadToEnd()
            End Using
        End Using
        Dim Reg As New Regex(" [\s*\-\+]?\d*.\d+(e)+[[\+\-]?\d+]?")  '[\s*\-\+]?\d*.\d+[\e][[\+\-]?\d+]?"
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

    Public Sub New()
        points = New Point3DCollection()
        points.Add(New Point3D(0, 0, 0))
        points.Add(New Point3D(-1, 0, 0))
        points.Add(New Point3D(0, 1, 0))
        points.Add(New Point3D(1, 0, 0))
        pindex = New Int32Collection
        pindex.Add(2) : pindex.Add(1) : pindex.Add(0)
        pindex.Add(3) : pindex.Add(2) : pindex.Add(0)
    End Sub

    Public Sub Draw(my3D As MeshGeometry3D)
        my3D.Positions = points
        my3D.TriangleIndices = pindex
    End Sub
End Class
