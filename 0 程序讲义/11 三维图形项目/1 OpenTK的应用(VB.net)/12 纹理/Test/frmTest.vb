Imports OpenTK
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging

Public Class frmTest
    Private textureID As Integer

    Private Sub glCanvas_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles glCanvas.Paint
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit Or ClearBufferMask.DepthBufferBit)
        glCanvas.SwapBuffers()
    End Sub

    Private Sub btnDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraw.Click
        GL.Disable(EnableCap.Texture2D)
        Render()
    End Sub

    Private Sub btnRender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRender.Click
        SetTexture()
        Render()
    End Sub
    Private Sub SetTexture()
        GL.Enable(EnableCap.Texture2D)
        GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest)
        GL.GenTextures(1, textureID)
        GL.BindTexture(TextureTarget.Texture2D, textureID)
        Dim myBmp As Bitmap = New Bitmap("swimmer1.bmp")
        Dim rect As New Rectangle(0, 0, myBmp.Width, myBmp.Height)
        Dim bmpData As BitmapData = myBmp.LockBits(rect, ImageLockMode.ReadOnly, Imaging.PixelFormat.Format32bppArgb)
        GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, bmpData.Width, bmpData.Height, 0, Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, bmpData.Scan0)
        myBmp.UnlockBits(bmpData)
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, TextureMinFilter.Linear)
    End Sub

    Private Sub Render()
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit Or ClearBufferMask.DepthBufferBit)

        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadIdentity()
        GL.BindTexture(TextureTarget.ProxyTexture2D, textureID)
        GL.Begin(PrimitiveType.Polygon)
        GL.TexCoord2(0.0, 1.0) : GL.Vertex2(-0.6, -0.4)  '图像的左下
        GL.TexCoord2(1.0, 1.0) : GL.Vertex2(0.6, -0.4)   '图像的右下
        GL.TexCoord2(1.0, 0.0) : GL.Vertex2(0.6, 0.4)    '图像的右上
        GL.Vertex2(0, 0.7)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex2(-0.6, 0.4)   '图像的左上（图像原点）
        GL.End()
        GL.Flush()
        glCanvas.SwapBuffers()
    End Sub


End Class
