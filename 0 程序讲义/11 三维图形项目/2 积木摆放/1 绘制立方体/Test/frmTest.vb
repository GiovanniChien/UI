Imports OpenTK.Graphics.OpenGL

Public Class frmTest
    Dim boxes As List(Of clsBox)

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        boxes = New List(Of clsBox)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim color As Color
        color = color.FromArgb(0, 128, 128, 255)
        boxes.Add(New clsBox(color, 0.1, 0.5, 0.1, 0.5, 0.1, 0.5))
        boxes.Add(New clsBox(color, -0.1, -0.5, -0.1, -0.5, -0.1, -0.5))
        Draw()
    End Sub

    Private Sub glCanvas_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles glCanvas.Paint
        Draw()
    End Sub

    Private Sub Draw()
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit)
        For i = 0 To boxes.Count - 1
            boxes(i).Draw()
        Next
        GL.Flush()
        glCanvas.SwapBuffers()
    End Sub

End Class
