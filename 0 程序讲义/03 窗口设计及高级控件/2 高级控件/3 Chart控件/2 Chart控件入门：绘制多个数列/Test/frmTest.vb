Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmTest
    Dim Reds(255), Greens(255), Blues(255) As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For i = 0 To 255
            Reds(i) = Rnd() * 100
            Greens(i) = 2 * Rnd() * 100
            Blues(i) = 3 * Rnd() * 100
        Next
        '取出以下预定义的成分
        'Chart1中预定义了ChartAreas("ChartArea1")
        'Chart1.Legends中预定义了"Legend1"
        'Chart1.Series中预定义了"Series1"，其图例为"Legend1"，其图形为"ChartArea1"
        '设置1个子图区
        Me.Chart1.Titles.Add(New Title("RGB分析"))
        With Me.Chart1.ChartAreas
            .Clear()
            .Add(New ChartArea("RGB分析"))
            .Item("RGB分析").AxisX.Title = "颜色分量"
            .Item("RGB分析").AxisY.Title = "像素个数"
        End With

        '设置3个图例
        With Me.Chart1.Legends
            .Clear()
            .Add(New Legend("Red")) : .Item("Red").Docking = Docking.Bottom
            .Add(New Legend("Green")) : .Item("Green").Docking = Docking.Bottom
            .Add(New Legend("Blue")) : .Item("Blue").Docking = Docking.Bottom
        End With

        '设置3个数列
        With Me.Chart1.Series
            .Clear()
            .Add(New Series("Red"))
            .Add(New Series("Green"))
            .Add(New Series("Blue"))
        End With
        With Me.Chart1.Series("Red")
            .ChartArea = "RGB分析" : .Legend = "Red" : .ChartType = SeriesChartType.Line
            .Points.Clear()
            For i = 0 To 255
                .Points.AddXY(i, Reds(i))    '为这个Series加数据点
            Next
        End With
        With Me.Chart1.Series("Green")
            .ChartArea = "RGB分析" : .Legend = "Green" : .ChartType = SeriesChartType.StepLine
            .Points.Clear()
            For i = 0 To 255
                .Points.AddXY(i, Greens(i))    '为这个Series加数据点
            Next
        End With
        With Me.Chart1.Series("Blue")
            .ChartArea = "RGB分析" : .Legend = "Blue" : .ChartType = SeriesChartType.Column
            .Points.Clear()
            For i = 0 To 255
                .Points.AddXY(i, Blues(i))    '为这个Series加数据点
            Next
        End With
    End Sub
End Class
