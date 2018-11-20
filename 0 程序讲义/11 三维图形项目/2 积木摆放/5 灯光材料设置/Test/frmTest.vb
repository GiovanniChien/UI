Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class frmTest
    Dim Opengl As clsOpenGL  ' 封装了OpenGL的设置和显示流程
    Dim vcs As clsVCS3       ' 观察坐标系对象
    Dim Spaces As clsSpaces
    Dim boxes As List(Of clsBox)

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Opengl = New clsOpenGL
        Opengl.Init()
        vcs = New clsVCS3(New clsBox(-1, 1, -1, 1, -1, 1))
        boxes = New List(Of clsBox)
    End Sub

    Private Sub btnNewBoxes_Click(sender As System.Object, e As System.EventArgs) Handles btnNewBoxes.Click
        For i = 1 To 400
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
        If Opengl Is Nothing Then Return
        Opengl.Clear(Color.SkyBlue)
        Opengl.SetProjection3(vcs)
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

    '交互数据
    Public MousePressed As Boolean, sp As Point

    Private Sub glCanvas_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles glCanvas.MouseDown
        MousePressed = True : sp = e.Location
    End Sub
    Private Sub glCanvas_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles glCanvas.MouseUp
        MousePressed = False
    End Sub

    Private Sub glCanvas_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles glCanvas.MouseMove
        If MousePressed = False Then Exit Sub
        With vcs
            ' 根据鼠标器的移动改变旋转的经度、纬度  纬度在0到360度之间
            .Rotate((.Azimuth - (e.X - sp.X) + 360) Mod 360, (.Elevation + (e.Y - sp.Y) + 360) Mod 360)
            Draw()
        End With
        sp.X = e.X : sp.Y = e.Y
    End Sub
    Private Sub glCanvas_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCanvas.MouseWheel
        If Opengl Is Nothing Then Exit Sub
        vcs.Zoom(e.Delta / 100)
        Draw()
    End Sub

    Private Sub chkLight1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkLight1.CheckedChanged, chkLight2.CheckedChanged, chkLight3.CheckedChanged
        Opengl.SetLight(0, chkLight1.Checked)
        Opengl.SetLight(1, chkLight2.Checked)
        Opengl.SetLight(2, chkLight3.Checked)
        Draw()
    End Sub

    Private Sub chkUseNormal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUseNormal.CheckedChanged
        clsBox.UseNormal = chkUseNormal.Checked
        Draw()
    End Sub
End Class
