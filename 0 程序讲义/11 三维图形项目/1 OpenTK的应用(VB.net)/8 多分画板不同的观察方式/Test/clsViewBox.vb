Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Public Enum ViewKind  '视口中的视图种类
    ViewKindBack
    ViewKindRight
    ViewKindDown
End Enum

Public Class clsViewBox
    Public Rect As Rectangle  '视口的范围
    Public Box As clsBox3     '模型的范围
    Public Target As Vector3  '视口的观察点，初始为模型的中心
    Public Eye As Vector3     '视口的眼睛的位置
    Public Up As Vector3      '视口的朝上方向
    Dim Dist As Single = 500  '平行投影时观察点与坐标平面的距离，初始为500(与模型大小有关)
    Private Sub Init(ByVal Rect As Rectangle, ByVal box As clsBox3)
        Me.Rect = Rect : Me.Box = Box
        Me.Target = Box.GetMid()
        Me.Box.xmin -= 100 : Me.Box.xmax += 100
        Me.Box.ymin -= 100 : Me.Box.ymax += 100
        Me.Box.zmin -= 100 : Me.Box.zmax += 100
    End Sub
    Public Sub New(ByVal Rect As Rectangle, ByVal box As clsBox3, ByVal Kind As ViewKind)
        Init(Rect, box)
        Select Case Kind
            Case ViewKind.ViewKindBack ' 后视图
                Eye = New Vector3(Target.X, -Dist, Target.Z) : Up = New Vector3(0, 0, 1)
            Case ViewKind.ViewKindRight  ' 右视图
                Eye = New Vector3(Dist, Target.Y, Target.Z) : Up = New Vector3(0, 0, 1)
            Case ViewKind.ViewKindDown  ' 俯视图
                Eye = New Vector3(Target.X, Target.Y, Dist) : Up = New Vector3(0, 1, 0)
        End Select
    End Sub
    Public Sub New(ByVal Rect As Rectangle, ByVal box As clsBox3, ByVal Eye As Vector3, ByVal Up As Vector3)
        Init(Rect, box)
        Me.Eye = Eye
        Me.Up = Up
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
        Dim nearDist As Single = 100, farDist As Single = 1000
        Dim width As Single = 400, height As Single = 400
        Dim persp As Matrix4 = Matrix4.CreateOrthographic(width, height, nearDist, farDist)
        GL.LoadMatrix(persp)

        '观察变换
        GL.MatrixMode(MatrixMode.Modelview)
        Dim lookat As Matrix4 = Matrix4.LookAt(Eye, Target, Up)
        GL.LoadMatrix(lookat)
    End Sub

    Public Function Contains(ByVal x As Integer, ByVal y As Integer) As Boolean
        Return Rect.Contains(x, y)
    End Function
End Class
