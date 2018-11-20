Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class FrmTest
    Private LeftViewBox As clsViewBox, RightViewBox As clsViewBox

    Private Sub FrmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LeftViewBox = New clsViewBox(-10, 10, -20, 20, -1, 1)
        RightViewBox = New clsViewBox(-10, 10, -20, 20, -1, 1)
    End Sub

    Private Sub DrawViewPortLeft()
        '左视图的图形数据
        Dim LeftPoints As List(Of Vector2)
        LeftPoints = New List(Of Vector2)
        LeftPoints.Add(New Vector2(0.5, 0.5))
        LeftPoints.Add(New Vector2(-0.5, 0.5))
        LeftPoints.Add(New Vector2(-0.5, -0.5))

        GL.Viewport(0, 0, glCtrl.Width / 2, glCtrl.Height)
        GL.MatrixMode(MatrixMode.Projection)
        GL.LoadIdentity()
        With LeftViewBox
            GL.Ortho(.left, .right, .bottom, .top, .near, .far)
        End With
        GL.MatrixMode(MatrixMode.Modelview)
        GL.Begin(PrimitiveType.Triangles)
        For i = 0 To Leftpoints.Count - 1
            GL.Vertex2(Leftpoints(i))
        Next
        GL.End()
    End Sub
    Private Sub DrawViewPortRight()
        '右视图的图形数据
        Dim RightPoints As List(Of Vector2)
        RightPoints = New List(Of Vector2)
        RightPoints.Add(New Vector2(5, 5))
        RightPoints.Add(New Vector2(-5, 5))
        RightPoints.Add(New Vector2(-5, -5))
        RightPoints.Add(New Vector2(5, -5))

        GL.Viewport(glCtrl.Width / 2, 0, glCtrl.Width / 2, glCtrl.Height)
        GL.MatrixMode(MatrixMode.Projection)
        GL.LoadIdentity()
        With RightViewBox
            GL.Ortho(.left, .right, .bottom, .top, .near, .far)
        End With

        GL.MatrixMode(MatrixMode.Modelview)
        GL.Begin(PrimitiveType.Lines)
        For i = 0 To RightPoints.Count - 1
            GL.Vertex2(RightPoints(i))
        Next
        GL.End()
    End Sub

    Private Sub Draw()
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit)
        DrawViewPortLeft()
        DrawViewPortRight()
        GL.Flush()
        glCtrl.SwapBuffers()
    End Sub

    Private Sub glCtrl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles glCtrl.Paint
        Draw()
    End Sub

    Private Sub GLCtrl_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseWheel
        If e.X < glCtrl.Width / 2 Then
            If e.Delta > 0 Then
                LeftViewBox.Zoom(0.9)
            Else
                LeftViewBox.Zoom(1.1)
            End If
        Else
            If e.Delta > 0 Then
                RightViewBox.Zoom(0.9)
            Else
                RightViewBox.Zoom(1.1)
            End If
        End If
        Draw()
    End Sub

End Class
