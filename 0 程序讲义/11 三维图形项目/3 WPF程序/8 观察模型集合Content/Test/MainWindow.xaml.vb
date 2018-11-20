Imports System.Windows.Media.Media3D
Imports System.Math
Class MainWindow
    Dim obj As MeshGeometry3D
    Dim myModels As clsGeometryModels  '模型数据的组织对象
    Dim myCamera As clsCamera          '相机数据的组织对象
    Dim DrawModels As ModelVisual3D    '模型的图形绘制对象
    Dim Trans As Transform3D             '视图中的图形变换矩阵
    Dim Matrix As Matrix3D                  '模型数据的变换矩阵
    Dim lastp1, lastp2 As Point
    'VP1：Viewport3D对象
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        DrawModels = New ModelVisual3D : VP1.Children.Add(DrawModels) '建立绘图流水线
        myCamera = New clsCamera(New Point3D(0, 0, 0), 500, 20, 50)
        VP1.Camera = myCamera.Camera
        'VP1.
        myModels = New clsGeometryModels '创建2个模型的数据
    End Sub
    Private Sub btnOpen_Click(sender As Object, e As RoutedEventArgs) Handles btnOpen.Click
        '启动绘图流水线
        DrawModels.Content = myModels.Draw()
    End Sub
    Private Sub VP1_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles VP1.MouseLeftButtonDown
        lastp1 = e.GetPosition(sender)
        Dim delta As Point3D = New Point3D(10, 10, 10)
        Dim Trans As Transform3D = New TranslateTransform3D(delta)
        Dim mg As Model3DGroup = DrawModels.Content
        'vp1: Viewport3D
        '     Viewport3DVisual
        'VP1.InputHitTest()
        Dim p As Point = e.GetPosition(sender)
        Dim vpv As Viewport3DVisual = New Viewport3DVisual()

        'For i = 0 To 
        '    vpv.HitTest(p)
        '    DrawModels.Content.Transform = Trans
        'Next
        'DrawModels.Content.Transform = Trans




    End Sub

    Private Sub btnJD_Click(sender As Object, e As RoutedEventArgs) Handles btnJD.Click
        myCamera.AddJD(5)
    End Sub
    Private Sub btnWD_Click(sender As Object, e As RoutedEventArgs) Handles btnWD.Click
        myCamera.AddWD(5)
    End Sub

    Private Sub Viewport3D_MouseWheel(sender As Object, e As MouseWheelEventArgs) Handles VP1.MouseWheel
        If e.Delta < 0 Then
            myCamera.AddRadius(-10)
        Else
            myCamera.AddRadius(10)
        End If
    End Sub

    Private Sub VP1_MouseMove(sender As Object, e As MouseEventArgs) Handles VP1.MouseMove
        If e.LeftButton = MouseButtonState.Released Then Return
        Dim p As Point = e.GetPosition(sender)
        Dim Camera As clsCamera = Nothing, offset As Point
        If sender Is VP1 Then
            Camera = Camera : offset = p - lastp1 : lastp1 = p
        End If
        myCamera.AddJD(offset.X)
        myCamera.AddWD(offset.Y)
    End Sub
    '实施图形的外观变换
    Private Sub btnPan_Click(sender As Object, e As RoutedEventArgs) Handles btnPan.Click
        Dim delta As Point3D = New Point3D(1, 1, 1)
        Trans = New TranslateTransform3D(delta)
        DrawModels.Content.Transform = Trans
    End Sub
    Private Sub btnMatrix_Click(sender As Object, e As RoutedEventArgs) Handles btnMatrix.Click
        Dim m As Matrix3D = New Matrix3D
        Dim offset As Vector3D = New Vector3D(1, 2, 3)
        m.Translate(offset)
        Dim scale As Vector3D = New Vector3D(0.2, 0.4, 0.6)
        Dim center As Vector3D = New Vector3D(0, 0, 0)
        m.ScaleAt(scale, center)
        Dim axis As Vector3D = New Vector3D(0, 0, 1)
        Dim angle As Single = 30
        m.Rotate(New Quaternion(axis, angle))
        Trans = New MatrixTransform3D(m)
        DrawModels.Content.Transform = Trans
    End Sub
    Private Sub btnRotate_Click(sender As Object, e As RoutedEventArgs) Handles btnRotateX.Click, btnRotateY.Click, btnRotateZ.Click
        Dim axis As Vector3D = New Vector3D(0, 0, 0)
        If sender Is btnRotateX Then axis = New Vector3D(1, 2, 3)
        If sender Is btnRotateY Then axis = New Vector3D(0, 1, 0)
        If sender Is btnRotateZ Then axis = New Vector3D(0, 0, 1)
        axis.Normalize()
        Dim delta As Single = 30
        Dim R As Rotation3D
        'R = New AxisAngleRotation3D(axis, delta)
        R = New QuaternionRotation3D(New Quaternion(axis, delta))
        Trans = New RotateTransform3D(R)
        DrawModels.Content.Transform = Trans
    End Sub

    Private Sub btnScale_Click(sender As Object, e As RoutedEventArgs) Handles btnScale.Click
        Dim scale As Vector3D = New Vector3D(0.2, 0.4, 0.6)
        Dim center As Vector3D = New Vector3D(0, 0, 0)
        Trans = New ScaleTransform3D(scale, center)
        DrawModels.Content.Transform = Trans
    End Sub

    '实施图形的数据变换
    Private Sub btnSave_Click(sender As Object, e As RoutedEventArgs) Handles btnSave.Click
        Dim m As Matrix3D = Trans.Value
        myModels.Transform(m)
        DrawModels.Content.Transform = Nothing
    End Sub

End Class
