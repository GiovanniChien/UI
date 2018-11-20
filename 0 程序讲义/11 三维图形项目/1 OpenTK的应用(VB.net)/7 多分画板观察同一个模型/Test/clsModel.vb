Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class clsBox3
    Public xmin, xmax As Single
    Public ymin, ymax As Single
    Public zmin, zmax As Single

    Sub New(ByVal xmin As Integer, ByVal xmax As Integer, ByVal ymin As Integer, ByVal ymax As Integer, ByVal zmin As Integer, ByVal zmax As Integer)
        Me.xmin = xmin : Me.xmax = xmax
        Me.ymin = ymin : Me.ymax = ymax
        Me.zmin = zmin : Me.zmax = zmax
    End Sub
End Class

Public Class clsModel
    Private faces As List(Of clsFace)
    Public box As clsBox3

    Public Sub New()
        box = New clsBox3(0, 200, 0, 200, 0, 300)
        faces = New List(Of clsFace)
        faces.Add(New clsFace(New Vector3(0, 0, 0), New Vector3(0, 200, 0), New Vector3(200, 200, 0)))
        faces.Add(New clsFace(New Vector3(50, 50, 0), New Vector3(50, 150, 0), New Vector3(150, 150, 0)))
        faces.Add(New clsFace(New Vector3(200, 200, 0), New Vector3(200, 0, 0), New Vector3(0, 0, 0)))
        faces.Add(New clsFace(New Vector3(150, 150, 100), New Vector3(150, 50, 100), New Vector3(50, 50, 100)))
        faces.Add(New clsFace(New Vector3(50, 50, 100), New Vector3(100, 100, 300), New Vector3(50, 150, 100)))
        faces.Add(New clsFace(New Vector3(50, 150, 100), New Vector3(100, 100, 300), New Vector3(150, 150, 100)))
        faces.Add(New clsFace(New Vector3(150, 150, 100), New Vector3(100, 100, 300), New Vector3(150, 50, 100)))
        faces.Add(New clsFace(New Vector3(150, 50, 100), New Vector3(100, 100, 300), New Vector3(50, 50, 100)))
        faces.Add(New clsFace(New Vector3(0, 0, 0), New Vector3(50, 50, 100), New Vector3(0, 200, 0)))
        faces.Add(New clsFace(New Vector3(50, 50, 100), New Vector3(50, 150, 100), New Vector3(0, 200, 0)))
        faces.Add(New clsFace(New Vector3(0, 200, 0), New Vector3(50, 150, 100), New Vector3(200, 200, 0)))
        faces.Add(New clsFace(New Vector3(50, 150, 100), New Vector3(150, 150, 100), New Vector3(200, 200, 0)))
        faces.Add(New clsFace(New Vector3(200, 200, 0), New Vector3(150, 150, 100), New Vector3(200, 0, 0)))
        faces.Add(New clsFace(New Vector3(150, 150, 100), New Vector3(150, 50, 100), New Vector3(200, 0, 0)))
        faces.Add(New clsFace(New Vector3(200, 0, 0), New Vector3(150, 50, 100), New Vector3(0, 0, 0)))
        faces.Add(New clsFace(New Vector3(150, 50, 100), New Vector3(50, 50, 100), New Vector3(0, 0, 0)))
    End Sub
    Public Sub Draw()
        GL.MatrixMode(MatrixMode.Modelview)
        For i = 0 To faces.Count - 1
            faces(i).draw()
        Next
    End Sub

End Class
