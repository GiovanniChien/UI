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

    Public Function GetMid() As Vector3
        Return New Vector3((xmin + xmax) / 2, (ymin + ymax) / 2, (zmin + zmax) / 2)
    End Function

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
        Dim A1() As Single = {0.4411765, 0.6117647, 0.5019608, 1.0}
        Dim D1() As Single = {0.4411765, 0.6117647, 0.5019608, 1.0}
        Dim S1() As Single = {1.0, 1.0, 1.0, 1.0}
        Dim E1() As Single = {0.0, 0.0, 0.0, 0.0}
        Dim SH1 As Single = 30.0
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Ambient, A1)
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Diffuse, D1)
        GL.Material(MaterialFace.Front, MaterialParameter.Specular, S1)
        GL.Material(MaterialFace.Front, MaterialParameter.Emission, E1)
        GL.Material(MaterialFace.Front, MaterialParameter.Shininess, SH1)
        For i = 0 To faces.Count - 1
            faces(i).Draw(True)  '绘制平面
        Next

        Dim A2() As Single = {0.9411765, 0.6117647, 0.5019608, 1.0}
        Dim D2() As Single = {0.9411765, 0.6117647, 0.5019608, 1.0}
        Dim S2() As Single = {1.0, 1.0, 1.0, 1.0}
        Dim E2() As Single = {0.0, 0.0, 0.0, 0.0}
        Dim SH2 As Single = 30.0
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Ambient, A2)
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Diffuse, D2)
        GL.Material(MaterialFace.Front, MaterialParameter.Specular, S2)
        GL.Material(MaterialFace.Front, MaterialParameter.Emission, E2)
        GL.Material(MaterialFace.Front, MaterialParameter.Shininess, SH2)
        For i = 0 To faces.Count - 1
            faces(i).Draw(False)  '绘制线段
        Next
    End Sub

End Class
