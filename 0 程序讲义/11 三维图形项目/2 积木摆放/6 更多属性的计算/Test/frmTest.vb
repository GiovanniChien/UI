Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class frmTest
    Dim Opengl As clsOpenGL  ' 封装了OpenGL的设置和显示流程
    Dim vcs As clsVCS3       ' 观察坐标系对象
    Dim Spaces As clsSpaces  ' 摆放积木的空间
    Dim boxes As clsBoxes    ' 未被安排的积木集合
    Dim result As clsBoxes   ' 被安排好的积木集合

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Opengl = New clsOpenGL
        Opengl.Init()
        vcs = New clsVCS3(New clsBox(-1, 1, -1, 1, -1, 1))
    End Sub

    Private Sub btnNewBoxes_Click(sender As System.Object, e As System.EventArgs) Handles btnNewBoxes.Click
        boxes = New clsBoxes(80)
        Draw()
    End Sub
    Private Sub btnArrange_Click(sender As System.Object, e As System.EventArgs) Handles btnArrange.Click
        Spaces = New clsSpaces(New clsBox(-0.5, 1, -0.5, 1, -0.5, 1))
        ' boxes对象中原有的box, 能够被安排的box被存入result，无法安排的box被保留boxes中
        result = boxes.Arrange(Spaces)
        MsgBox(result.Count & "," & result.Volume)
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
        If boxes IsNot Nothing Then boxes.Draw()
        If result IsNot Nothing Then result.Draw()
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

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If result IsNot Nothing Then result.Save("r.txt")
    End Sub
End Class
