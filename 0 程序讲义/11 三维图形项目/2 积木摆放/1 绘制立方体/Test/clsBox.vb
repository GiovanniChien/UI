Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class clsBox
    Private xmin, xmax, ymin, ymax, zmin, zmax As Single
    Private Color As Color
    Private points(7) As Vector3

    Public Sub New(color As Color, xmin As Single, xmax As Single, ymin As Single, ymax As Single, zmin As Single, zmax As Single)
        Me.color = color
        Me.xmin = xmin : Me.xmax = xmax
        Me.ymin = ymin : Me.ymax = ymax
        Me.zmin = zmin : Me.zmax = zmax
        points(0) = New Vector3(xmin, ymin, zmin)
        points(1) = New Vector3(xmax, ymin, zmin)
        points(2) = New Vector3(xmax, ymax, zmin)
        points(3) = New Vector3(xmin, ymax, zmin)

        points(4) = New Vector3(xmin, ymin, zmax)
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

End Class
