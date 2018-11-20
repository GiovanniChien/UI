Imports System.Math
Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Public Class clsOpenGL
    Public Sub Init()
        GL.Enable(EnableCap.DepthTest)   '打开深度比较开关
        GL.DepthFunc(DepthFunction.Less) 'z值小者可见，解决多个实体之间的遮挡问题

        GL.Enable(EnableCap.Normalize)
        GL.Enable(EnableCap.CullFace)   '剔除与视线方向背离的面，解决单个实体的消隐问题

        GL.Enable(EnableCap.Blend)     '色彩混合开关
        GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha)  '解决透明面的色彩混合

        GL.LineWidth(1)
        GL.Enable(EnableCap.LineSmooth)  '线平滑
        GL.Enable(EnableCap.PolygonSmooth)

        GL.FrontFace(FrontFaceDirection.Ccw)
        GL.Enable(EnableCap.AutoNormal)
        GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill)

        GL.Hint(HintTarget.LineSmoothHint, HintMode.Nicest)

        GL.Enable(EnableCap.Texture2D)   '打开纹理

        GL.Enable(EnableCap.Lighting)
        'Lights.Open(EnableCap.Light0)
        'Lights.Open(EnableCap.Light1)
        'Lights.Open(EnableCap.Light2)
        'GL.LightModel(LightModelParameter.LightModelTwoSide, 1)

        GL.ShadeModel(ShadingModel.Smooth)
        GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest)
    End Sub

    Public Sub Clear(ByVal clrBackground As Color)
        GL.ClearColor(clrBackground) '设置绘图背景色
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.Clear(ClearBufferMask.AccumBufferBit)
        GL.Clear(ClearBufferMask.DepthBufferBit)
    End Sub

    Public Sub SetProjection3(ByVal SCS As clsVCS3)
        '观察变换
        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadIdentity()
        Dim lookat As Matrix4 = Matrix4.LookAt(SCS.Vp, SCS.Origin, SCS.Up)
        GL.LoadMatrix(lookat)

        '透视投影
        GL.MatrixMode(MatrixMode.Projection)
        GL.LoadIdentity()

        Dim persp As Matrix4
        'nearDist, farDist相对与lookat中的eye的位置，不求精确，但要求留有余量
        Dim nearDist As Single = 0.1, farDist As Single = SCS.Radius * 20
        If farDist <= nearDist Then
            farDist = nearDist + 1   ' 保证farDist>nearDist
        End If
        Dim fovy As Single = 16 / 180.0 * PI, aspect As Single = 1
        persp = Matrix4.CreatePerspectiveFieldOfView(fovy, aspect, nearDist, farDist) '
        GL.LoadMatrix(persp)

    End Sub


End Class
