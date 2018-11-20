Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class clsBox
    Private xmin, xmax, ymin, ymax, zmin, zmax As Single
    Private Color As Color
    Private points(7) As Vector3

    Public Sub New(xmin As Single, xmax As Single, ymin As Single, ymax As Single, zmin As Single, zmax As Single)
        Color = Color.FromArgb(0, Rnd() * 255, Rnd() * 255, Rnd() * 255)
        Init(xmin, xmax, ymin, ymax, zmin, zmax)
    End Sub
    ' base是左下后角
    Public Sub New(base As Vector3, wx As Single, wy As Single, wz As Single)
        Color = Color.FromArgb(0, Rnd() * 255, Rnd() * 255, Rnd() * 255)
        Init(base.X, base.X + wx, base.Y, base.Y + wy, base.Z, base.Z + wz)
    End Sub
    Public Sub New(color As Color, xmin As Single, xmax As Single, ymin As Single, ymax As Single, zmin As Single, zmax As Single)
        Me.Color = color
        Init(xmin, xmax, ymin, ymax, zmin, zmax)
    End Sub
    Private Sub Init(xmin As Single, xmax As Single, ymin As Single, ymax As Single, zmin As Single, zmax As Single)
        Me.xmin = xmin : Me.xmax = xmax
        Me.ymin = ymin : Me.ymax = ymax
        Me.zmin = zmin : Me.zmax = zmax
        points(0) = New Vector3(xmin, ymin, zmin)  '底面4个点
        points(1) = New Vector3(xmax, ymin, zmin)
        points(2) = New Vector3(xmax, ymax, zmin)
        points(3) = New Vector3(xmin, ymax, zmin)
        points(4) = New Vector3(xmin, ymin, zmax)  '顶面4个点
        points(5) = New Vector3(xmax, ymin, zmax)
        points(6) = New Vector3(xmax, ymax, zmax)
        points(7) = New Vector3(xmin, ymax, zmax)
    End Sub

    Public Sub Draw()
        GL.Color3(Me.Color)
        '底面
        GL.Begin(PrimitiveType.Polygon)
        GL.Vertex3(points(0)) : GL.Vertex3(points(3)) : GL.Vertex3(points(2)) : GL.Vertex3(points(1))
        GL.End()
        '顶面
        GL.Begin(PrimitiveType.Polygon)
        GL.Vertex3(points(4)) : GL.Vertex3(points(5)) : GL.Vertex3(points(6)) : GL.Vertex3(points(7))
        GL.End()
        '后面
        GL.Begin(PrimitiveType.Polygon)
        GL.Vertex3(points(0)) : GL.Vertex3(points(4)) : GL.Vertex3(points(7)) : GL.Vertex3(points(3))
        GL.End()
        '前面
        GL.Begin(PrimitiveType.Polygon)
        GL.Vertex3(points(1)) : GL.Vertex3(points(2)) : GL.Vertex3(points(6)) : GL.Vertex3(points(5))
        GL.End()
        '右侧面
        GL.Begin(PrimitiveType.Polygon)
        GL.Vertex3(points(0)) : GL.Vertex3(points(1)) : GL.Vertex3(points(5)) : GL.Vertex3(points(4))
        GL.End()
        '左侧面
        GL.Begin(PrimitiveType.Polygon)
        GL.Vertex3(points(2)) : GL.Vertex3(points(3)) : GL.Vertex3(points(7)) : GL.Vertex3(points(6))
        GL.End()
    End Sub

    Public Function Base() As Vector3        '左下后角
        Return New Vector3(xmin, ymin, zmin)
    End Function
    Public Function BaseX() As Vector3       '右下后角
        Return New Vector3(xmax, ymin, zmin)
    End Function
    Public Function BaseY() As Vector3       '左下前角
        Return New Vector3(xmin, ymax, zmin)
    End Function
    Public Function BaseZ() As Vector3       '左上后角
        Return New Vector3(xmin, ymin, zmax)
    End Function

    Public Function Wx() As Single
        Return xmax - xmin
    End Function
    Public Function Wy() As Single
        Return ymax - ymin
    End Function
    Public Function Wz() As Single
        Return zmax - zmin
    End Function

    Public Function Subtract(box As clsBox) As Vector3
        Return New Vector3(Wx() - box.Wx, Wy() - box.Wy, Wz() - box.Wz)
    End Function

End Class
