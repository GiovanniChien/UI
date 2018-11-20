Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Structure glCtrlUI
    Dim MousePressed As Boolean, Spx, Spy As Double  '图形窗口的鼠标状态
    Dim ViewBoxID As Integer                         '当前操作的视口的下标
End Structure

Public Class frmMain
    Private Model As clsModel
    Private ViewBoxs(1) As clsViewBox  '2个视景体对象
    Private UI As glCtrlUI             '交互状态

    Private Sub glCanvas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles glCanvas.Load
        OpenGLSetup()
    End Sub

    Private Sub InitViewBoxs()
        Dim rtLeft As Rectangle = glCanvas.ClientRectangle
        rtLeft.Width /= 2
        Dim rtRight As Rectangle = glCanvas.ClientRectangle
        rtRight.Width /= 2 : rtRight.X = rtLeft.Width
        ViewBoxs(0) = New clsViewBox(rtLeft, Model.Box, ViewKind.ViewKindFront)
        ViewBoxs(1) = New clsViewBox(rtRight, Model.Box, ViewKind.ViewKindBack)
    End Sub

    Private Sub m_FileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_FileOpen.Click
        Model = New clsModel("4212duck.ply")  'texturedknot.ply
        InitViewBoxs()
        Render()
        With tvInfo
            .ShowLines = True
            .Nodes.Add(Model.UpdateInfoNode())
            For i = 0 To 1
                .Nodes.Add(ViewBoxs(i).UpdateInfoNode())
            Next
        End With
    End Sub

    '绘制所有视口中的图形
    Private Sub Render()
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.Clear(ClearBufferMask.AccumBufferBit)
        GL.Clear(ClearBufferMask.DepthBufferBit)
        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadIdentity()

        For i = 0 To 1
            'ViewBoxs(i).Project(ProjectKind.ProjectKindOrtho)
            ViewBoxs(i).Project(ProjectKind.ProjectKindPerspective)
            Model.Render()
        Next
        GL.Finish()
        glCanvas.SwapBuffers()

        Model.UpdateInfoNode()
        For i = 0 To 1
            ViewBoxs(i).UpdateInfoNode()
        Next
    End Sub

    Private Sub glCanvas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles glCanvas.Paint
        If Model Is Nothing Then Exit Sub
        Render()
    End Sub

    Private Sub glCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCanvas.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            UI.MousePressed = True : UI.Spx = e.X : UI.Spy = e.Y
            UI.ViewBoxID = getViewBoxID(e.X, e.Y)  '记住当前视口
        End If
    End Sub
    Private Sub glCanvas_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCanvas.MouseMove
        If UI.MousePressed = False Then Exit Sub
        ' 根据鼠标器的移动,改变当前视口中的眼睛位置
        Dim dx As Single = e.X - UI.Spx
        Dim dy As Single = e.Y - UI.Spy
        ViewBoxs(UI.ViewBoxID).Rotate(dx, dy)
        UI.Spx = e.X : UI.Spy = e.Y
        Text = ViewBoxs(UI.ViewBoxID).EyePosition.X
        Render()
    End Sub
    Private Sub glCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCanvas.MouseUp
        UI.MousePressed = False
    End Sub
    Private Sub glCanvas_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCanvas.MouseWheel
        UI.ViewBoxID = getViewBoxID(e.X, e.Y)
        ViewBoxs(UI.ViewBoxID).Zoom(e.Delta)
        Render()
    End Sub

    Private Function getViewBoxID(ByVal x As Integer, ByVal y As Integer) As Integer
        'glControl的视口划分的坐标系：原点在左下角, x向右, y向上
        'glControl的像素坐标系：原点在左上角, x向右, y向下
        y = glCanvas.Height - y
        For i = 0 To ViewBoxs.Count - 1
            If ViewBoxs(i).Contains(x, y) = True Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub OpenGLSetup()
        GL.Enable(EnableCap.DepthTest)   '打开深度比较开关
        GL.DepthFunc(DepthFunction.Less) 'z值小者可见，解决多个实体之间的遮挡问题

        GL.Enable(EnableCap.Normalize)
        GL.Enable(EnableCap.CullFace) '剔除与视线方向背离的面，解决单个实体的消隐问题

        GL.Enable(EnableCap.Blend) '色彩混合开关
        GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha)  '解决透明面的色彩混合

        GL.LineWidth(2)
        GL.Enable(EnableCap.LineSmooth)  '线平滑
        GL.Enable(EnableCap.PolygonSmooth)
        GL.Hint(HintTarget.LineSmoothHint, HintMode.Nicest)

        GL.Enable(EnableCap.Texture2D)
        GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest)

        GL.Enable(EnableCap.Lighting)
        GL.Enable(EnableCap.Light0)
        Dim P() As Single = {1000, 0, 0, 1}
        Dim A() As Single = {0.8, 0.8, 0.8, 1.0}
        Dim D() As Single = {0.8, 0.8, 0.8, 1.0}
        Dim S() As Single = {0.8, 0.8, 0.8, 1.0}
        GL.Light(EnableCap.Light0, LightParameter.Position, P) '位置
        GL.Light(EnableCap.Light0, LightParameter.Ambient, A)  '环境光
        GL.Light(EnableCap.Light0, LightParameter.Diffuse, D)  '散射光
        GL.Light(EnableCap.Light0, LightParameter.Specular, S) '镜面光

        GL.Enable(EnableCap.Light1)
        Dim P1() As Single = {0, 0, 1000, 1}
        Dim A1() As Single = {0.8, 0.8, 0.8, 1.0}
        Dim D1() As Single = {0.8, 0.8, 0.8, 1.0}
        Dim S1() As Single = {0.8, 0.8, 0.8, 1.0}
        GL.Light(EnableCap.Light1, LightParameter.Position, P1) '位置
        GL.Light(EnableCap.Light1, LightParameter.Ambient, A1)  '环境光
        GL.Light(EnableCap.Light1, LightParameter.Diffuse, D1)  '散射光
        GL.Light(EnableCap.Light1, LightParameter.Specular, S1) '镜面光

        GL.ShadeModel(ShadingModel.Smooth)
        GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest)

    End Sub

End Class
