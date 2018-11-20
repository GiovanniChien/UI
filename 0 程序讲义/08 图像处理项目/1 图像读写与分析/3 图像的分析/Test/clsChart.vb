Imports System.Windows.Forms.DataVisualization.Charting

Public Structure DateSerial
    Public Title As String    '子图标题
    Public XTitle As String   'X轴标题
    Public YTitle As String   'Y轴标题
    Public Data() As Integer   '数据序列
End Structure

Public Class clsChart
    Private Chart As Chart

    Public Sub New(Chart As Chart)
        Me.Chart = Chart
    End Sub

    Public Sub Draw(Title As String, DS As List(Of DateSerial))
        Me.Chart.Titles.Clear()
        Me.Chart.Titles.Add(New Title(Title))
        '设置多个子图区
        With Me.Chart.ChartAreas
            .Clear()
            For i = 0 To DS.Count - 1
                .Add(New ChartArea(DS(i).Title))
                .Item(DS(i).Title).AxisX.Title = DS(i).XTitle : .Item(DS(i).Title).AxisY.Title = DS(i).YTitle
            Next
        End With

        '设置多个图例
        With Me.Chart.Legends
            .Clear()
            For i = 0 To DS.Count - 1
                .Add(New Legend(DS(i).Title)) : .Item(DS(i).Title).Docking = Docking.Top
            Next
        End With

        '设置多个数列
        With Me.Chart.Series
            .Clear()
            For i = 0 To DS.Count - 1
                .Add(New Series(DS(i).Title))
            Next
        End With
        For i = 0 To DS.Count - 1
            With Me.Chart.Series(DS(i).Title)
                .ChartArea = DS(i).Title : .ChartType = SeriesChartType.Line
                .Points.Clear()
                For j = 0 To 255
                    .Points.AddXY(j, DS(i).Data(j))    '为这个Series加数据点
                Next
            End With
        Next
    End Sub

End Class
