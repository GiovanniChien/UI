Imports System.Windows.Forms.DataVisualization.Charting

Public Class clsCounter
    Private WithEvents Ticker As Timer
    Protected Counter As PerformanceCounter
    Private chtValue As Chart, lblValue As Label
    Private Q As Queue(Of Single)
    Private Const QueueLength As Integer = 100  ' 队列的最大长度
    Private Const TickerInterval As Integer = 1000 ' 时钟中断的间隔

    Public Sub New(Counter As PerformanceCounter, Chart As Chart, lblValue As Label)
        Me.Counter = Counter
        Me.chtValue = Chart : Me.lblValue = lblValue
        Me.Q = New Queue(Of Single)
        Ticker = New Timer : Ticker.Interval = TickerInterval : Ticker.Enabled = True
    End Sub

    Private Sub Ticker_Tick(sender As Object, e As System.EventArgs) Handles Ticker.Tick
        Q.Enqueue(GetValue)
        If Q.Count > QueueLength Then
            Q.Dequeue()
        End If
        lblValue.Text = Q.Last
        DisplayChart()
    End Sub

    ' NextValue和RawValue的区别是什么？原理是什么？
    Private Function GetValue() As Single
        Return Counter.NextValue
    End Function

    Sub DisplayChart()
        Me.chtValue.Series(0).ChartType = SeriesChartType.Line
        Me.chtValue.Series("Series1").Points.Clear()
        For i = 0 To Q.Count - 1
            Me.chtValue.Series("Series1").Points.AddXY(i, Q(i))
        Next
        chtValue.Legends("Legend1").Docking = Docking.Top
    End Sub

End Class
