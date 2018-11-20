Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class FrmTest
    Private points As List(Of Vector2)
    Private ViewBox As clsViewBox

    Private Sub FrmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        points = New List(Of Vector2)
        points.Add(New Vector2(0.5, 0.5))
        points.Add(New Vector2(-0.5, 0.5))
        points.Add(New Vector2(-0.5, -0.5))
        points.Add(New Vector2(0.5, -0.5))
        ViewBox = New clsViewBox(-10, 10, -20, 20, -1, 1)
    End Sub

    Private Sub Draw()
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit)

        GL.MatrixMode(MatrixMode.Projection)
        GL.LoadIdentity()
        With ViewBox
            GL.Ortho(.left, .right, .bottom, .top, .near, .far)
        End With
        GL.MatrixMode(MatrixMode.Modelview)
        GL.Begin(PrimitiveType.Lines)
        For i = 0 To points.Count - 1
            GL.Vertex2(points(i))
        Next
        GL.End()
        GL.Flush()
        glCtrl.SwapBuffers()
    End Sub

    Private Sub glCtrl_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseDown
        points.Add(ViewBox.DpToLp(glCtrl, e.X, e.Y))
    End Sub
    Private Sub glCtrl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseUp
        points.Add(ViewBox.DpToLp(glCtrl, e.X, e.Y))
        Draw()
    End Sub

    Private Sub glCtrl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles glCtrl.Paint
        Draw()
    End Sub

    Private Sub GLCtrl_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseWheel
        If e.Delta > 0 Then
            ViewBox.Zoom(0.9)
        Else
            ViewBox.Zoom(1.1)
        End If
        Draw()
    End Sub


End Class
