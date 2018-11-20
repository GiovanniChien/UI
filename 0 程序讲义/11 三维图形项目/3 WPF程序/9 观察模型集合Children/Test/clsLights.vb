Imports System.Windows.Media.Media3D

Public Class clsLights
    Public Lights(3) As Light

    Public Sub New()
        Lights(0) = New AmbientLight(Color.FromRgb(127, 127, 127))
        Lights(1) = New DirectionalLight(Color.FromRgb(0, 255, 0), New Vector3D(1, 1, 1))
        Lights(2) = New PointLight(Color.FromRgb(0, 255, 0), New Vector3D(1, 1, 1))
        Lights(3) = New SpotLight(Color.FromRgb(0, 255, 0), New Vector3D(0, 0, 0), New Vector3D(1, 1, 1), 30, 20)
    End Sub
End Class
