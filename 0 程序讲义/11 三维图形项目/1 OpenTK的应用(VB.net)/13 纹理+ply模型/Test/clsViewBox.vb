Imports System.Math
Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Public Enum ProjectKind
    ProjectKindOrtho         '平行投影
    ProjectKindPerspective   '透视投影
End Enum

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
    Public Box As clsBox3      '模型的观察范围
    Public Target As Vector3   '视口的观察点，初始为模型的中心
    Public EyePosition As Vector3 '视口的眼睛位置的极坐标表示(相对观察点的经度ViewAngleX, 维度ViewAngleY, 半径ViewRadius)
    Public Up As Vector3       '视口的朝上方向
    Dim Dist As Single = 15000   '平行投影时观察点与坐标平面的距离，初始为1000(与模型大小有关)
    Public Node As New TreeNode

    Public Sub SetEye(ByVal Eyeposition As Vector3)
        Me.EyePosition = Eyeposition
    End Sub

    Private Sub Init(ByVal Rect As Rectangle, ByVal box As clsBox3)
        Me.Rect = Rect
        '视景体中的观察范围比模型盒子稍大20%
        Me.Box = box : Me.Target = box.GetMid()
        Me.Box.xmin -= Me.Box.Wx * 0.1 : Me.Box.xmax += Me.Box.Wx * 0.1
        Me.Box.ymin -= Me.Box.Wy * 0.1 : Me.Box.ymax += Me.Box.Wy * 0.1
        Me.Box.zmin -= Me.Box.Wz * 0.1 : Me.Box.zmax += Me.Box.Wz * 0.1
    End Sub
    Public Sub New(ByVal Rect As Rectangle, ByVal box As clsBox3, ByVal Kind As ViewKind)
        InitNode()
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
                EyePosition = New Vector3(20, 30, Dist) : Up = New Vector3(0, 1, 0)
            Case ViewKind.ViewKindUp    ' 仰视图
                EyePosition = New Vector3(0, -90, Dist) : Up = New Vector3(0, 1, 0)
        End Select
    End Sub
    Public Sub New(ByVal Rect As Rectangle, ByVal box As clsBox3, ByVal EyePosition As Vector3, ByVal Up As Vector3)
        InitNode()
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
        If EyePosition.Z < -1400 Then EyePosition.Z = -1400
        If EyePosition.Z > 15000 Then EyePosition.Z = 15000
    End Sub

    Public Sub Project(ByVal Kind As ProjectKind)
        '视口变换
        GL.Viewport(Rect.X, Rect.Y, Rect.Width, Rect.Height)
        '平行投影
        GL.MatrixMode(MatrixMode.Projection)
        GL.LoadIdentity()
        'nearDist, farDist相对与lookat中的eye的位置，与模型大小有关，不求精确，但要求留有余量
        Dim nearDist As Single = 10, farDist As Single = 50000
        Dim persp As Matrix4
        If Kind = ProjectKind.ProjectKindOrtho Then
            '平行投影
            Dim width As Single = 2400, height As Single = 2400  'Box.Wx *2  Box.Wy *2
            persp = Matrix4.CreateOrthographic(width, height, nearDist, farDist)
        Else
            '透视投影
            Dim fovy As Single = 16 / 180.0 * PI, aspect As Single = 1
            persp = Matrix4.CreatePerspectiveFieldOfView(fovy, aspect, nearDist, farDist)
        End If
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

    Private Sub InitNode()
        Node = New TreeNode("视景体:")
        Node.Nodes.Add(New TreeNode("视口范围: "))
        Node.Nodes.Add(New TreeNode("观察范围X: "))
        Node.Nodes.Add(New TreeNode("观察范围Y: "))
        Node.Nodes.Add(New TreeNode("观察范围Z: "))
        Node.Nodes.Add(New TreeNode("观察点: "))
        Node.Nodes.Add(New TreeNode("视点: "))
        Node.Nodes.Add(New TreeNode("朝上方向: "))
    End Sub

    Function UpdateInfoNode() As TreeNode
        Node.Nodes(0).Text = "视口范围: " & Rect.ToString()
        Node.Nodes(1).Text = "观察范围X: " & Box.XToString()
        Node.Nodes(2).Text = "观察范围Y: " & Box.YToString()
        Node.Nodes(3).Text = "观察范围Z: " & Box.ZToString()
        Node.Nodes(4).Text = "观察点: " & Target.ToString
        Node.Nodes(5).Text = "视点: " & EyePosition.ToString
        Node.Nodes(6).Text = "朝上方向: " & Up.ToString
        Return Node
    End Function

End Class
