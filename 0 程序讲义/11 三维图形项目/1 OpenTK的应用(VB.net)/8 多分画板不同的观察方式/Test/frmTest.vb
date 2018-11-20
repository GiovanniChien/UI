Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class FrmTest
    Private Model As clsModel
    Private ViewBoxs(3) As clsViewBox
    Private ID As Integer = -1   ' 占据控件glCtrl全部区域的视口的下标， ID=-1表示分屏显示

    Private Sub FrmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Model = New clsModel
        Dim rtLeftUp As Rectangle = glCtrl.ClientRectangle
        Dim rtLeftDown As Rectangle = glCtrl.ClientRectangle
        Dim rtRightDown As Rectangle = glCtrl.ClientRectangle
        Dim rtRightUp As Rectangle = glCtrl.ClientRectangle
        rtLeftUp.Height /= 2 : rtLeftUp.Width /= 2 : rtLeftUp.Y = rtLeftUp.Height
        rtLeftDown.Height /= 2 : rtLeftDown.Width /= 2
        rtRightUp.Height /= 2 : rtRightUp.Width /= 2 : rtRightUp.X = rtRightUp.Width : rtRightUp.Y = rtRightUp.Height
        rtRightDown.Height /= 2 : rtRightDown.Width /= 2 : rtRightDown.X = rtRightDown.Width

        ViewBoxs(0) = New clsViewBox(rtLeftUp, Model.box, ViewKind.ViewKindBack)  '左上
        ViewBoxs(1) = New clsViewBox(rtLeftDown, Model.box, ViewKind.ViewKindDown) '左下
        ViewBoxs(2) = New clsViewBox(rtRightUp, Model.box, ViewKind.ViewKindRight) '右上
        Dim eye As Vector3 = Model.box.GetMid() + New Vector3(500, 500, 500)
        Dim up As Vector3 = New Vector3(0, 0, 1)
        ViewBoxs(3) = New clsViewBox(rtRightDown, Model.box, eye, up) '右下
    End Sub

    Private Sub Draw()
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit)
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
End Class