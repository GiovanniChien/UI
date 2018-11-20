Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Class clsFace
    Public p1, p2, p3 As Vector3

    Public Sub New(ByVal p1 As Vector3, ByVal p2 As Vector3, ByVal p3 As Vector3)
        Me.p1 = p1
        Me.p2 = p2
        Me.p3 = p3
    End Sub

    Public Sub Draw()
        GL.Begin(PrimitiveType.Triangles)
        GL.Vertex3(p1) : GL.Vertex3(p2) : GL.Vertex3(p3)
        GL.End()
    End Sub
End Class
