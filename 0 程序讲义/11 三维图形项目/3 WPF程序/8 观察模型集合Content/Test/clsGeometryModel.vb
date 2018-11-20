Imports System.Windows.Media.Media3D

Public Class clsGeometryModel
    Private objGeometry As clsGeometry3D
    Private objMaterial As Material
    Private objBackMaterial As Material
    Public Sub New(fname As String)
        objGeometry = New clsGeometry3D(fname)
        Dim BrushMaterial As Brush = New SolidColorBrush(Color.FromRgb(255, 0, 0))
        objMaterial = New DiffuseMaterial(BrushMaterial)
        Dim BrushBackMaterial As Brush = New SolidColorBrush(Color.FromRgb(0, 255, 0))
        objBackMaterial = New DiffuseMaterial(BrushBackMaterial)
    End Sub

    Public Function Draw() As GeometryModel3D
        Dim Model As New GeometryModel3D
        Model.Geometry = objGeometry.Draw()
        Model.Material = objMaterial
        Model.BackMaterial = objBackMaterial
        Return Model
    End Function
    Public Sub Transform(m As Matrix3D)
        objGeometry.Transform(m)
    End Sub

End Class
