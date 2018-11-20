Imports System.Windows.Forms.DataVisualization.Charting

Public Class clsCounter
    Private Sensor As SensorFlag
    Private chtValue As Chart, lblValue As GroupBox
    Private Q As Queue(Of Integer)
    Private Const QueueLength As Integer = 10  ' 队列的最大长度

    Public Sub New(ByVal Sensor As SensorFlag, ByVal Chart As Chart, ByVal GroupBox As GroupBox)
        Me.Sensor = Sensor
        Me.chtValue = Chart : Me.lblValue = GroupBox
        Me.Q = New Queue(Of Integer)
        If Sensor = SensorFlag.T1 Then lblValue.Text = "T1: "
        If Sensor = SensorFlag.T2 Then lblValue.Text = "T2: "
        If Sensor = SensorFlag.Q Then lblValue.Text = "Q: "
    End Sub

    Public Sub Append(ByVal v As Integer)
        Q.Enqueue(v)
        If Q.Count > QueueLength Then
            Q.Dequeue()
        End If
        If Sensor = SensorFlag.T1 Then lblValue.Text = "T1: " & Q.Last
        If Sensor = SensorFlag.T2 Then lblValue.Text = "T2: " & Q.Last
        If Sensor = SensorFlag.Q Then lblValue.Text = "Q: " & Q.Last
        DisplayChart()
    End Sub

    Sub DisplayChart()
        Me.chtValue.ChartAreas("ChartArea1").AxisY.MajorGrid.LineDashStyle = ChartDashStyle.DashDot
        Me.chtValue.ChartAreas("ChartArea1").AxisY.MinorGrid.LineDashStyle = ChartDashStyle.DashDot
        Me.chtValue.ChartAreas("ChartArea1").AxisX.Enabled = AxisEnabled.Auto '.False
        Me.chtValue.Series(0).ChartType = SeriesChartType.Point
        For i = 0 To Q.Count - 1
            Me.chtValue.Series("Series1").Points.AddXY(i, Q(i))
        Next
        Me.chtValue.ChartAreas(0).AxisX.Minimum = 0
        chtValue.Legends("Legend1").Enabled = False ' .Docking = Docking.Left
    End Sub

End Class
