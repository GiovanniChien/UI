Imports System.Windows.Media.Media3D
Imports System.Math
Class MainWindow
    Dim Model As clsModel
    Dim Camera1, Camera2 As clsCamera
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
End Class
