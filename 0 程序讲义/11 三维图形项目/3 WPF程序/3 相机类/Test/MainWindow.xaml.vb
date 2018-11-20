Imports System.Windows.Media.Media3D
Imports System.Math
Class MainWindow

    Dim points As Point3DCollection
    Dim pindex As Int32Collection
    Dim Camera As clsCamera
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        points = New Point3DCollection()
        points.Add(New Point3D(0, 0, 0))
        points.Add(New Point3D(-1, 0, 0))
        points.Add(New Point3D(0, 1, 0))
        points.Add(New Point3D(1, 0, 0))
        pindex = New Int32Collection
        pindex.Add(2) : pindex.Add(1) : pindex.Add(0)
        pindex.Add(3) : pindex.Add(2) : pindex.Add(0)

        Camera = New clsCamera(myCamera, New Point3D(0, 0, 0), 10, 30, 20)
    End Sub

    Private Sub btn1_Click(sender As Object, e As RoutedEventArgs) Handles btn1.Click
        my3D.Positions = points
        my3D.TriangleIndices = pindex
    End Sub

    Private Sub btn2_Click(sender As Object, e As RoutedEventArgs) Handles btn2.Click
        Camera.AddJD(5)
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Camera.AddWD(5)
    End Sub
End Class
