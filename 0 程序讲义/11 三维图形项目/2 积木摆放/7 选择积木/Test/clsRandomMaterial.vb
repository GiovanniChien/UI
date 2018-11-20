Imports OpenTK.Graphics.OpenGL

Public Class clsRandomMaterial
    Private A(3), D(3), S(3), W(3), Sh(3) As Single
    Public Sub New()
        For i = 0 To 3
            A(i) = Rnd()   ' 对环境光发射的随机颜色
            D(i) = 0
            S(i) = 0
            W(i) = 0
            Sh(i) = 0
        Next
        A(3) = 0.9  '透明度   =1完全不透明    =0完全透明
    End Sub

    Public Sub SetMaterial()
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Ambient, A)
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Diffuse, A)
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, A)
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Emission, A)
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, A)
    End Sub
End Class
