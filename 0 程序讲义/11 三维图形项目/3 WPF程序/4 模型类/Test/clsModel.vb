Imports System.Windows.Media.Media3D

Public Class clsModel
    Private points As Point3DCollection
    Private pindex As Int32Collection

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
