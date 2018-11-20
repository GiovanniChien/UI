Imports System.Windows.Media.Media3D

Public Class clsModels
    Private Models As List(Of clsModel)
    Public Sub New()
        Models = New List(Of clsModel)
    End Sub

    Public Sub Append(model As clsModel)
        Models.Add(model)
    End Sub

    Public Sub Draw(my3D As MeshGeometry3D)
        For i = 0 To Models.Count - 1
            Models(i).Draw(my3D)
        Next
    End Sub

End Class
