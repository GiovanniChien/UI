Imports System.Windows.Media

Class MainWindow
    Dim Geometrys As GeometryGroup      '几何对象的数据
    Dim Drawing As New GeometryDrawing  '几何对象的图形

    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click
        '建立连接
        Geometrys = New GeometryGroup : Drawing = New GeometryDrawing
        With Drawing
            .Geometry = Geometrys
            .Pen = New Pen(Brushes.Black, 2)
        End With
        '存入图像控件
        Image1.Source = New DrawingImage(Drawing)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button2.Click
        '绘图
        Dim r1 As Rect = New Rect(10, 10, 100, 50)
        Geometrys.Children.Add(New EllipseGeometry(r1))
        Dim r2 As Rect = New Rect(50, 50, 50, 100)
        Geometrys.Children.Add(New EllipseGeometry(r2))
        Geometrys.Children.Add(New RectangleGeometry(r2))
    End Sub


End Class
