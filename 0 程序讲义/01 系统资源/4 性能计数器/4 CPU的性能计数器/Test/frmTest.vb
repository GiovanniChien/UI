Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmTest
    Dim Processor_Time As clsCounter
    Dim User_Time As clsCounter

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        User_Time = New clsCounter(New PerformanceCounter("Process", "% User Time", "_Total"), Chart1, lblUserTime)
        Processor_Time = New clsCounter(New PerformanceCounter("Process", "% Processor Time", "_Total"), Chart2, lblProcessorTime)
    End Sub
End Class

