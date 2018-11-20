Imports System.Windows.Media.Media3D

Public Class clsGeometryModels
    Public Models As List(Of clsGeometryModel)
    Private Lights As clsLights
    Public Sub New()
        Lights = New clsLights
        Models = New List(Of clsGeometryModel)
        Models.Add(New clsGeometryModel("Twoman1.stl"))
        Models.Add(New clsGeometryModel("4212duck.stl"))
    End Sub

    Public Function Draw() As Model3D
        Dim Ms As New Model3DGroup
        For i = 0 To Lights.Lights.Count - 1
            Ms.Children.Add(Lights.Lights(i))
        Next
        For i = 0 To Models.Count - 1
            Dim m As GeometryModel3D = Models(i).Draw()
            Ms.Children.Add(m)
        Next
        Return Ms
    End Function

    Public Sub Transform(m As Matrix3D)
        For i = 0 To Models.Count - 1
            Models(i).Transform(m)
        Next
    End Sub

End Class
