Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmTest
    Dim Reds(255) As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For i = 0 To 255
            Reds(i) = Math.Sin(2 * i / 255 * Math.PI) * 100
        Next
        'Chart1中预定义了ChartAreas("ChartArea1")
        'Chart1.Legends中预定义了"Legend1"
        'Chart1.Series中预定义了"Series1"，其图例为"Legend1"，其图形为"ChartArea1"
        With Me.Chart1.ChartAreas("ChartArea1")
            .AxisX.Title = "Red分量" : .AxisY.Title = "像素个数"
        End With
        Me.Chart1.Series(0).ChartType = SeriesChartType.Line '.Column
        Me.Chart1.Series("Series1").Points.Clear()
        For i = 0 To 255
            Me.Chart1.Series("Series1").Points.AddXY(i, Reds(i))    '为这个Series加数据点
        Next
        Chart1.Legends("Legend1").Docking = Docking.Top
    End Sub

End Class
