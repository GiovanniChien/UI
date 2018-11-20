Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Structure glCtrlUI
    Dim MousePressed As Boolean, Spx, Spy As Double  '图形窗口的鼠标状态
    Dim ViewBoxID As Integer                         '当前操作的视口的下标
End Structure

Public Class FrmTest
    Private Model As clsModel
    Private ViewBoxs(3) As clsViewBox
    Private ID As Integer = -1   ' 占据控件glCtrl全部区域的视口的下标， ID=-1表示分屏显示
    Private UI As glCtrlUI

    Private Sub FrmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        glCtrl.SendToBack()
        lineVertical.BringToFront()
        Model = New clsModel
        Dim rtLeftUp As Rectangle = glCtrl.ClientRectangle
        Dim rtLeftDown As Rectangle = glCtrl.ClientRectangle
        Dim rtRightDown As Rectangle = glCtrl.ClientRectangle
        Dim rtRightUp As Rectangle = glCtrl.ClientRectangle
        rtLeftUp.Height /= 2 : rtLeftUp.Width /= 2 : rtLeftUp.Y = rtLeftUp.Height
        rtLeftDown.Height /= 2 : rtLeftDown.Width /= 2
        rtRightUp.Height /= 2 : rtRightUp.Width /= 2 : rtRightUp.X = rtRightUp.Width : rtRightUp.Y = rtRightUp.Height
        rtRightDown.Height /= 2 : rtRightDown.Width /= 2 : rtRightDown.X = rtRightDown.Width

        ViewBoxs(0) = New clsViewBox(rtLeftUp, Model.box, ViewKind.ViewKindFront)  '左上
        ViewBoxs(1) = New clsViewBox(rtLeftDown, Model.box, ViewKind.ViewKindDown) '左下
        ViewBoxs(2) = New clsViewBox(rtRightUp, Model.box, ViewKind.ViewKindRight) '右上
        Dim EyePosition As Vector3 '视口的眼睛位置的极坐标表示(相对观察点的经度ViewAngleX, 维度ViewAngleY, 半径ViewRadius)
        With EyePosition
            .X = 200 : .Y = 30 : .Z = 1000
        End With
        Dim up As Vector3 = New Vector3(0, 0, 1)
        ViewBoxs(3) = New clsViewBox(rtRightDown, Model.box, EyePosition, up) '右下
    End Sub
    Private Sub glCtrl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles glCtrl.Load
        OpenGLSetup()
    End Sub

    Private Sub Draw()
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.Clear(ClearBufferMask.AccumBufferBit)
        GL.Clear(ClearBufferMask.DepthBufferBit)
        If ID = -1 Then
            For i = 0 To ViewBoxs.Count - 1
                ViewBoxs(i).Project()
                Model.Draw()
            Next
        Else
            ViewBoxs(ID).Project(glCtrl.ClientRectangle()) : Model.Draw()
        End If
        GL.Flush()
        glCtrl.SwapBuffers()


    End Sub

    Private Sub glCtrl_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles glCtrl.DoubleClick
        If ID = -1 Then
            Dim ee As MouseEventArgs = e
            ID = getViewBoxID(ee.X, ee.Y)  '分屏 -> 全屏
        Else
            ID = -1                       '全屏 -> 分屏
        End If
        Draw()
    End Sub

    Private Function getViewBoxID(ByVal x As Integer, ByVal y As Integer) As Integer
        'glControl的视口划分的坐标系：原点在左下角, x向右, y向上
        'glControl的像素坐标系：原点在左上角, x向右, y向下
        y = glCtrl.Height - y
        For i = 0 To ViewBoxs.Count - 1
            If ViewBoxs(i).Contains(x, y) = True Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub glCtrl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles glCtrl.Paint
        Draw()
    End Sub

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

        GL.Enable(EnableCap.Lighting)
        GL.Enable(EnableCap.Light0)
        Dim P() As Single = {0, 0, 0, 0}
        Dim A() As Single = {0.8, 0.2, 0.2, 1.0}
        Dim D() As Single = {0.0, 0.0, 0.0, 0.0}
        Dim S() As Single = {0.0, 0.0, 0.0, 0.0}
        GL.Light(EnableCap.Light0, LightParameter.Position, P) '位置
        GL.Light(EnableCap.Light0, LightParameter.Ambient, A)  '环境光
        GL.Light(EnableCap.Light0, LightParameter.Diffuse, D)  '散射光
        GL.Light(EnableCap.Light0, LightParameter.Specular, S) '镜面光
    End Sub

    Private Sub glCtrl_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            UI.MousePressed = True : UI.Spx = e.X : UI.Spy = e.Y
            If ID = -1 Then
                UI.ViewBoxID = getViewBoxID(e.X, e.Y)  '分屏状态
            Else
                UI.ViewBoxID = ID                      '视口ID占据全屏
            End If
        End If
    End Sub
    Private Sub GLCtrl_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseUp
        UI.MousePressed = False
    End Sub
    Private Sub GLCtrl_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseMove
        If UI.MousePressed = False Then Exit Sub
        ' 根据鼠标器的移动,改变当前视口中的眼睛位置
        Dim dx As Single = e.X - UI.Spx
        Dim dy As Single = e.Y - UI.Spy
        ViewBoxs(UI.ViewBoxID).Rotate(dx, dy)
        UI.Spx = e.X : UI.Spy = e.Y
        Text = ViewBoxs(UI.ViewBoxID).EyePosition.X
        Draw()
    End Sub

    Private Sub GLCtrl_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles glCtrl.MouseWheel
        UI.ViewBoxID = getViewBoxID(e.X, e.Y)
        ViewBoxs(UI.ViewBoxID).Zoom(e.Delta)
        Draw()
    End Sub

    Enum LineSplitKind
        LineNone
        LineHorizon
        lineVertical
    End Enum

    Dim LineSplit As LineSplitKind, sp As Point

    Private Sub Line_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LineHorizon.MouseDown, lineVertical.MouseDown
        If sender Is LineHorizon Then
            LineSplit = LineSplitKind.lineVertical
            sp.X = LineHorizon.X1 + e.X : sp.Y = LineHorizon.Y1 + e.Y  '换算为窗口坐标表示
        End If
        If sender Is lineVertical Then
            LineSplit = LineSplitKind.LineHorizon
            sp.X = lineVertical.X1 + e.X : sp.Y = lineVertical.Y1 + e.Y
        End If
    End Sub
    Private Sub FrmTest_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'If LineSplit = LineSplitKind.LineNone Then Exit Sub
        Dim dx As Integer = e.X - sp.X
        Dim dy As Integer = e.Y - sp.Y
        sp.X = e.X : sp.Y = e.Y

        If LineSplit = LineSplitKind.lineVertical Then LineHorizon.Y1 += dy : LineHorizon.Y2 += dy
        If LineSplit = LineSplitKind.LineHorizon Then lineVertical.X1 += dx : lineVertical.X2 += dx
    End Sub

    Private Sub line_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LineHorizon.MouseUp, lineVertical.MouseUp
        LineSplit = LineSplitKind.LineNone
    End Sub
    Private Sub FrmTest_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        LineSplit = LineSplitKind.LineNone
    End Sub

    Private Sub ShapeContainer1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        LineSplit = LineSplitKind.LineNone
    End Sub
End Class