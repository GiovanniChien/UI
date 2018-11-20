Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class frmTest
    Dim Spaces As clsSpaces
    Dim boxes As List(Of clsBox)

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        boxes = New List(Of clsBox)
    End Sub

    Private Sub btnNewBoxes_Click(sender As System.Object, e As System.EventArgs) Handles btnNewBoxes.Click
        For i = 1 To 30
            boxes.Add(New clsBox(New Vector3(-1, -1, -1), 0.1 + Rnd() * 0.3, 0.1 + Rnd() * 0.3, 0.1 + Rnd() * 0.3))
        Next
        Draw()
    End Sub
    Private Sub btnArrange_Click(sender As System.Object, e As System.EventArgs) Handles btnArrange.Click
        Dim Space As clsBox = New clsBox(-0.5, 1, -0.5, 1, -0.5, 1)
        Spaces = New clsSpaces(Space)
        For i = 0 To boxes.Count - 1
            Dim arrange As Arrangement = Spaces.Arrange(boxes(i))
            If arrange.Flag = False Then
                MsgBox("无法安排" & i)
            End If
        Next
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

    Private Sub RadioMin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioMin.CheckedChanged, RadioMax.CheckedChanged
        If sender Is RadioMax Then
            clsSpaces.Method = ArrangeMethod.RemainVolumeMax
        End If
        If sender Is RadioMin Then
            clsSpaces.Method = ArrangeMethod.RemainVolumeMin
        End If
    End Sub

End Class
