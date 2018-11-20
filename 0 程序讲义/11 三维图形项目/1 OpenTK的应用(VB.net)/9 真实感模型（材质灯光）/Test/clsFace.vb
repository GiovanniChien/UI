Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Class clsFace
    Public p1, p2, p3, Normal As Vector3

    Public Sub New(ByVal p1 As Vector3, ByVal p2 As Vector3, ByVal p3 As Vector3)
        Me.p1 = p1
        Me.p2 = p2
        Me.p3 = p3
        ComputeNormal()
    End Sub

    Public Sub ComputeNormal()
        Dim v1 As Vector3 = p2 - p1
        Dim v2 As Vector3 = p3 - p1
        Normal.X = v1.Y * v2.Z - v2.Y * v1.Z
        Normal.Y = v2.X * v1.Z - v1.X * v2.Z
        Normal.Z = v1.X * v2.Y - v2.X * v1.Y
        Normal.Normalize()
    End Sub

    Public Sub Draw(ByVal fill As Boolean)
        If fill = True Then
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill)
        Else
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line)
        End If
        GL.Begin(PrimitiveType.Triangles)
        GL.Normal3(Normal)
        GL.Vertex3(p1) : GL.Vertex3(p2) : GL.Vertex3(p3)
        GL.End()
    End Sub
End Class
