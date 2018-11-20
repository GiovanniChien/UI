Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class frmTest
    Private points As List(Of Vector2)

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        points = New List(Of Vector2)
        points.Add(New Vector2(0.5, 0.5))
        points.Add(New Vector2(-0.5, 0.5))
        points.Add(New Vector2(-0.5, -0.5))
        points.Add(New Vector2(0.5, -0.5))
    End Sub

    Private Sub Draw()
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.Begin(PrimitiveType.Lines)
        For i = 0 To points.Count - 1
            GL.Vertex2(points(i))
        Next
        GL.End()
        GL.Flush()
        glCtrl.SwapBuffers()
    End Sub

    Private Sub glCtrl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles glCtrl.Paint
        Draw()
    End Sub

    Private Sub glCtrl_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseDown
        points.Add(DpToLp(e.X, e.Y))
    End Sub

    Private Sub glCtrl_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseUp
        points.Add(DpToLp(e.X, e.Y))
        Draw()
    End Sub

    Private Function DpToLp(ByVal x As Integer, ByVal y As Integer) As Vector2
        Dim p As New Vector2
        p.X = (x - glCtrl.Width / 2) / (glCtrl.Width / 2)
        p.Y = (-y + glCtrl.Height / 2) / (glCtrl.Height / 2)
        Return p
    End Function

End Class
