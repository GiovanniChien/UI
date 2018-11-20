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
        Dim r0 As Rect = New Rect(0, 0, Image1.Width - 4, Image1.Height - 4)
        Geometrys.Children.Add(New RectangleGeometry(r0))

        'Dim r1 As Rect = New Rect(50, 50, 200, 50)
        'Geometrys.Children.Add(New EllipseGeometry(r1))
        Dim r2 As Rect = New Rect(50, 50, 50, 100)
        Dim gg As New GeometryGroup
        gg.Children.Add(New EllipseGeometry(r2))
        gg.Children.Add(New RectangleGeometry(r2))
        Geometrys.Children.Add(gg)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button4.Click
        Dim myLineSegment1 As New LineSegment()
        myLineSegment1.Point = New Point(200, 70)
        Dim myLineSegment2 As New PolyLineSegment
        myLineSegment2.Points.Add(New Point(220, 100))
        myLineSegment2.Points.Add(New Point(200, 80))
        myLineSegment2.Points.Add(New Point(180, 50))
        myLineSegment2.Points.Add(New Point(500, 500))

        Dim myPathSegmentCollection As New PathSegmentCollection()
        myPathSegmentCollection.Add(myLineSegment1)
        myPathSegmentCollection.Add(myLineSegment2)

        Dim myPathFigure As New PathFigure  '一系列单独连接的二维几何线段
        myPathFigure.StartPoint = New Point(10, 50)
        myPathFigure.Segments = myPathSegmentCollection

        Dim myPathGeometry As New PathGeometry
        myPathGeometry.Figures.Add(myPathFigure)

        Geometrys.Children.Add(myPathGeometry)
    End Sub

    Private Sub Image1_MouseDown(sender As System.Object, e As System.Windows.Input.MouseButtonEventArgs) Handles Image1.MouseDown
        Dim p As Point = e.GetPosition(sender)
        Dim Trans As Transform = New TranslateTransform(10, 10)

        For i = 1 To Geometrys.Children.Count - 1
            If Geometrys.Children(i).FillContains(p) = True Then
                Geometrys.Children(i).Transform = Trans
            End If
        Next
    End Sub
End Class
