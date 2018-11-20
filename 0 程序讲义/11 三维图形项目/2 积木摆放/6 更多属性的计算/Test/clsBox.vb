Imports OpenTK.Graphics.OpenGL
Imports OpenTK

'Enum Style
'    Bottom
'    Bottom_Left
'    Bottom_Back
'    Bottom_Left_Back
'End Enum

Public Class clsBox
    Public Shared UseNormal As Boolean = True
    Private xmin, xmax, ymin, ymax, zmin, zmax As Single
    Private material As clsRandomMaterial
    Private points(7) As Vector3

    Public Sub New(xmin As Single, xmax As Single, ymin As Single, ymax As Single, zmin As Single, zmax As Single)
        material = New clsRandomMaterial
        Init(xmin, xmax, ymin, ymax, zmin, zmax)
    End Sub
    ' base是左下后角
    Public Sub New(base As Vector3, wx As Single, wy As Single, wz As Single)
        material = New clsRandomMaterial
        Init(base.X, base.X + wx, base.Y, base.Y + wy, base.Z, base.Z + wz)
    End Sub
    Private Sub Init(xmin As Single, xmax As Single, ymin As Single, ymax As Single, zmin As Single, zmax As Single)
        Me.xmin = xmin : Me.xmax = xmax
        Me.ymin = ymin : Me.ymax = ymax
        Me.zmin = zmin : Me.zmax = zmax
    End Sub

    Public Sub Draw()
        points(0) = New Vector3(xmin, ymin, zmin)  '底面4个点
        points(1) = New Vector3(xmax, ymin, zmin)
        points(2) = New Vector3(xmax, ymax, zmin)
        points(3) = New Vector3(xmin, ymax, zmin)
        points(4) = New Vector3(xmin, ymin, zmax)  '顶面4个点
        points(5) = New Vector3(xmax, ymin, zmax)
        points(6) = New Vector3(xmax, ymax, zmax)
        points(7) = New Vector3(xmin, ymax, zmax)

        GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill)
        material.SetMaterial()
        '底面
        GL.Begin(PrimitiveType.Polygon)
        If UseNormal Then GL.Normal3(GetNormal(points(0), points(3), points(2)))
        GL.Vertex3(points(0)) : GL.Vertex3(points(3)) : GL.Vertex3(points(2)) : GL.Vertex3(points(1))
        GL.End()
        '顶面
        GL.Begin(PrimitiveType.Polygon)
        If UseNormal Then GL.Normal3(GetNormal(points(4), points(5), points(6)))
        GL.Vertex3(points(4)) : GL.Vertex3(points(5)) : GL.Vertex3(points(6)) : GL.Vertex3(points(7))
        GL.End()
        '后面
        GL.Begin(PrimitiveType.Polygon)
        If UseNormal Then GL.Normal3(GetNormal(points(0), points(4), points(7)))
        GL.Vertex3(points(0)) : GL.Vertex3(points(4)) : GL.Vertex3(points(7)) : GL.Vertex3(points(3))
        GL.End()
        '前面
        GL.Begin(PrimitiveType.Polygon)
        If UseNormal Then GL.Normal3(GetNormal(points(1), points(2), points(6)))
        GL.Vertex3(points(1)) : GL.Vertex3(points(2)) : GL.Vertex3(points(6)) : GL.Vertex3(points(5))
        GL.End()
        '右侧面
        GL.Begin(PrimitiveType.Polygon)
        If UseNormal Then GL.Normal3(GetNormal(points(0), points(1), points(5)))
        GL.Vertex3(points(0)) : GL.Vertex3(points(1)) : GL.Vertex3(points(5)) : GL.Vertex3(points(4))
        GL.End()
        '左侧面
        GL.Begin(PrimitiveType.Polygon)
        If UseNormal Then GL.Normal3(GetNormal(points(2), points(3), points(7)))
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
    '移到新的基点base上
    Public Sub Move(base As Vector3)
        Dim xw As Single = Wx()
        Dim yw As Single = Wy()
        Dim zw As Single = Wz()
        xmin = base.X : xmax = xmin + xw
        ymin = base.Y : ymax = ymin + yw
        zmin = base.Z : zmax = zmin + zw
    End Sub

    Function CX() As Single
        Return (xmin + xmax) / 2
    End Function
    Function CY() As Single
        Return (ymin + ymax) / 2
    End Function
    Function CZ() As Single
        Return (zmin + zmax) / 2
    End Function
    Function CP() As Vector3
        Return New Vector3(CX, CY, CZ)
    End Function

    Private Function GetNormal(p0 As Vector3, p1 As Vector3, p2 As Vector3) As Vector3
        Dim n As Vector3
        n = Vector3.Cross((p1 - p0), (p2 - p0))
        n.Normalize()  ' 标准化，长度为1
        Return n
    End Function

    Public Sub Expand(offset As Vector3)
        xmax += offset.X
        ymax += offset.Y
        zmax += offset.Z
    End Sub

    Public Function Volume() As Single
        Return Wx() * Wy() * Wz()
    End Function
    Public Overrides Function ToString() As String
        Return String.Format("({0},{1},{2})-({3},{4},{5})", xmin, ymin, zmin, xmax, ymax, zmax)
    End Function
End Class
