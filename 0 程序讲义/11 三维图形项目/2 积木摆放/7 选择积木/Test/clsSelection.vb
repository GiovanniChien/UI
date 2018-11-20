Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Public Class clsSelection
    Private Boxes As clsBoxes   '所有的积木对象
    Private Box As clsBox       '单个被选择的对象

    Public Sub New(ByVal Boxes As clsBoxes)
        Me.Boxes = Boxes
        Me.Box = Nothing
    End Sub

    Public Sub SelectbyPoint(ByVal p As Point)
        Dim near, far As Vector3
        SelectbyPoint(p, near, far)  '视线: near -> far
        Box = Boxes.SelectbyEyeLight(near, far)
    End Sub


    '根据二维像素坐标，及当前矩阵设置，计算对应的三维坐标点near->far
    Private Sub SelectbyPoint(ByVal point As Point, ByRef near As Vector3, ByRef far As Vector3)
        Dim viewport(3) As Integer
        Dim MvMatrix(15), ProjMatrix(15) As Double
        GL.GetInteger(GetPName.Viewport, viewport)
        GL.GetDouble(GetPName.ModelviewMatrix, MvMatrix)
        GL.GetDouble(GetPName.ProjectionMatrix, ProjMatrix)
        Dim realy As Integer = viewport(3) - point.Y - 1 ' 左下角为坐标原点
        OpenTK.Graphics.Glu.UnProject(point.X, realy, 0.0, MvMatrix(0), ProjMatrix(0), viewport(0), near.X, near.Y, near.Z)
        OpenTK.Graphics.Glu.UnProject(point.X, realy, 1.0, MvMatrix(0), ProjMatrix(0), viewport(0), far.X, far.Y, far.Z)
    End Sub

End Class
