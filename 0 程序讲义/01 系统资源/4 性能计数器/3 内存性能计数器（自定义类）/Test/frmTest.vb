Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmTest
    Dim Memory_AvaiableMBytes As clsCounter
    Dim Memory_Pages As clsCounter

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Memory_AvaiableMBytes = New clsValueCounter(New PerformanceCounter("Memory", "Available MBytes"), Chart1, lblMemoryAvailableMBytes)
        Memory_Pages = New clsAccumulatedCounter(New PerformanceCounter("Memory", "Pages/sec"), Chart2, lblMemory_Pages)
    End Sub
End Class

