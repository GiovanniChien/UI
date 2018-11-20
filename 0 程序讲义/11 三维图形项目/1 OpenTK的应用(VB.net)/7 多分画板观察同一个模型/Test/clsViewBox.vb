Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Public Class clsViewBox
    Public Rect As Rectangle  '视口的范围
    Public Box As clsBox3     '模型的范围

    Public Sub New(ByVal Rect As Rectangle, ByVal box As clsBox3)
        Me.Rect = Rect : Me.Box = box
        Me.Box.xmin -= 100 : Me.Box.xmax += 100
        Me.Box.ymin -= 100 : Me.Box.ymax += 100
        Me.Box.zmin -= 100 : Me.Box.zmax += 100
    End Sub

    Public Sub Project(Optional ByVal newRect As Rectangle = Nothing)
        If newRect = Nothing Then
            GL.Viewport(Rect.X, Rect.Y, Rect.Width, Rect.Height)
        Else
            GL.Viewport(newRect.X, newRect.Y, newRect.Width, newRect.Height)
        End If
        GL.MatrixMode(MatrixMode.Projection)
        GL.LoadIdentity()
        GL.Ortho(Box.xmin, Box.xmax, Box.ymin, Box.ymax, Box.zmin, Box.zmax)
    End Sub

    Public Function Contains(ByVal x As Integer, ByVal y As Integer) As Boolean
        Return Rect.Contains(x, y)
    End Function
End Class
