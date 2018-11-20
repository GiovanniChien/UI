Imports System.Math
Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Public Enum ViewKind  '视口中的视图种类
    ViewKindFront
    ViewKindBack
    ViewKindLeft
    ViewKindRight
    ViewKindDown
    ViewKindUp
End Enum

Public Class clsViewBox
    Public Rect As Rectangle   '视口的范围
    Public Box As clsBox3      '模型的范围
    Public Target As Vector3   '视口的观察点，初始为模型的中心
    Public EyePosition As Vector3 '视口的眼睛位置的极坐标表示(相对观察点的经度ViewAngleX, 维度ViewAngleY, 半径ViewRadius)
    Public Up As Vector3       '视口的朝上方向
    Dim Dist As Single = 1000   '平行投影时观察点与坐标平面的距离，初始为1000(与模型大小有关)

    Public Sub SetEye(ByVal Eyeposition As Vector3)
        Me.EyePosition = Eyeposition
    End Sub

    Private Sub Init(ByVal Rect As Rectangle, ByVal box As clsBox3)
        Me.Rect = Rect : Me.Box = box
        Me.Target = box.GetMid()
        Me.Box.xmin -= 100 : Me.Box.xmax += 100
        Me.Box.ymin -= 100 : Me.Box.ymax += 100
        Me.Box.zmin -= 100 : Me.Box.zmax += 100
    End Sub
    Public Sub New(ByVal Rect As Rectangle, ByVal box As clsBox3, ByVal Kind As ViewKind)
        Init(Rect, box)
        Select Case Kind
            Case ViewKind.ViewKindFront ' 前视图
                EyePosition = New Vector3(89, 0, Dist) : Up = New Vector3(0, 0, 1)
            Case ViewKind.ViewKindBack ' 后视图
                EyePosition = New Vector3(-90, 0, Dist) : Up = New Vector3(0, 0, 1)
            Case ViewKind.ViewKindLeft  ' 左视图
                EyePosition = New Vector3(180, 0, Dist) : Up = New Vector3(0, 0, 1)
            Case ViewKind.ViewKindRight  ' 右视图
                EyePosition = New Vector3(0, 0, Dist) : Up = New Vector3(0, 0, 1)
            Case ViewKind.ViewKindDown  ' 俯视图
                EyePosition = New Vector3(0, 90, Dist) : Up = New Vector3(0, 1, 0)
            Case ViewKind.ViewKindUp    ' 仰视图
                EyePosition = New Vector3(0, -90, Dist) : Up = New Vector3(0, 1, 0)
        End Select
    End Sub
    Public Sub New(ByVal Rect As Rectangle, ByVal box As clsBox3, ByVal EyePosition As Vector3, ByVal Up As Vector3)
        Init(Rect, box)
        Me.EyePosition = EyePosition
        Me.Up = Up
    End Sub
    Public Sub Rotate(ByVal dx As Single, ByVal dy As Single)
        EyePosition.X = (EyePosition.X + dx + 360) Mod 360
        EyePosition.Y = (EyePosition.Y + dy + 360) Mod 360
    End Sub
    Public Sub Zoom(ByVal dz As Single)
        EyePosition.Z += dz
        If EyePosition.Z < 400 Then EyePosition.Z = 400
        If EyePosition.Z > 1500 Then EyePosition.Z = 1500
    End Sub

    Public Sub Project(Optional ByVal newRect As Rectangle = Nothing)
        '视口变换
        If newRect = Nothing Then
            GL.Viewport(Rect.X, Rect.Y, Rect.Width, Rect.Height)
        Else
            GL.Viewport(newRect.X, newRect.Y, newRect.Width, newRect.Height)
        End If

        '平行投影
        GL.MatrixMode(MatrixMode.Projection)
        GL.LoadIdentity()
        'nearDist, farDist相对与lookat中的eye的位置，与模型大小有关，不求精确，但要求留有余量
        Dim nearDist As Single = 100, farDist As Single = 2000
        'Dim width As Single = 400, height As Single = 400
        'Dim persp As Matrix4 = Matrix4.CreateOrthographic(width, height, nearDist, farDist)
        '透视投影
        Dim fovy As Single = 16 / 180.0 * PI, aspect As Single = 1
        Dim persp As Matrix4 = Matrix4.CreatePerspectiveFieldOfView(fovy, aspect, nearDist, farDist)
        GL.LoadMatrix(persp)

        '观察变换
        GL.MatrixMode(MatrixMode.Modelview)

        Dim Eye As Vector3     '眼睛位置的直角坐标表示 
        With EyePosition  '(ViewAngleX, ViewAngleY, ViewRadius)
            Eye.X = .Z * Cos(.Y / 180 * PI) * Sin(.X / 180 * PI)
            Eye.Y = .Z * Cos(.Y / 180 * PI) * Cos(.X / 180 * PI)
            Eye.Z = .Z * Sin(.Y / 180 * PI)
            Eye += Target
        End With
        Dim lookat As Matrix4 = Matrix4.LookAt(Eye, Target, Up)
        GL.LoadMatrix(lookat)
    End Sub

    Public Function Contains(ByVal x As Integer, ByVal y As Integer) As Boolean
        Return Rect.Contains(x, y)
    End Function
End Class
