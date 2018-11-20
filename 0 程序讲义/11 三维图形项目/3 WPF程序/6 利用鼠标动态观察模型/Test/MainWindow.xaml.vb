Imports System.Windows.Media.Media3D
Imports System.Math
Class MainWindow
    Dim Model As clsModel
    Dim Camera1, Camera2 As clsCamera
    Dim lastp1, lastp2 As Point
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Model = New clsModel("Twoman.stl")
        Camera1 = New clsCamera(myCamera1, New Point3D(0, 0, 0), 200, 30, 20)
        Camera2 = New clsCamera(myCamera2, New Point3D(0, 0, 0), 200, 30, 20)
    End Sub

    Private Sub btn1_Click(sender As Object, e As RoutedEventArgs) Handles btn1.Click
        Model.Draw(my3D1)
        Model.Draw(my3D2)
    End Sub

    Private Sub btn2_Click(sender As Object, e As RoutedEventArgs) Handles btn2.Click
        Camera1.AddJD(5)
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Camera2.AddWD(5)
    End Sub

    Private Sub Viewport3D_MouseWheel(sender As Object, e As MouseWheelEventArgs)
        Dim Camera As clsCamera = Nothing
        If sender Is VP1 Then Camera = Camera1
        If sender Is VP2 Then Camera = Camera2
        If e.Delta < 0 Then
            Camera.AddRadius(-1)
        Else
            Camera.AddRadius(1)
        End If
    End Sub

    Private Sub VP1_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles VP1.MouseLeftButtonDown, VP2.MouseLeftButtonDown
        If sender Is VP1 Then lastp1 = e.GetPosition(sender)
        If sender Is VP2 Then lastp2 = e.GetPosition(sender)
    End Sub
    Private Sub VP1_MouseMove(sender As Object, e As MouseEventArgs) Handles VP1.MouseMove, VP2.MouseMove
        If e.LeftButton = MouseButtonState.Released Then Return
        Dim p As Point = e.GetPosition(sender)
        Dim Camera As clsCamera = Nothing, offset As Point
        If sender Is VP1 Then
            Camera = Camera1 : offset = p - lastp1 : lastp1 = p
        End If
        If sender Is VP2 Then
            Camera = Camera2 : offset = p - lastp2 : lastp2 = p
        End If
        Camera.AddJD(offset.X)
        Camera.AddWD(offset.Y)
    End Sub

End Class
