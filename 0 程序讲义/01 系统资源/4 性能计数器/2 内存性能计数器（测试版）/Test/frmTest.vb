Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmTest
    ' Pages/sec 是指为解决硬页错误从磁盘读取或写入磁盘的速度。
    ' 这个计数器是可以显示导致系统范围延缓类型错误的主要指示器。
    ' 它是 Memory\\Pages Input/sec 和 Memory\\Pages Output/sec 的总和。
    ' 是用页数计算的，以便在不用做转换的情况下就可以同其他页计数如: Memory\\Page Faults/sec 做比较，
    ' 这个值包括为满足错误而在文件系统缓存(通常由应用程序请求)的非缓存映射内存文件中检索的页。

    ' Memory_Pages.CounterType: RateOfCountsPerSecond32 
    ' 差异计数器，它显示在采用间隔的每一秒内完成的操作的平均数目。这种类型的计数器用系统时钟的滴答 (Tick) 来测量时间。
    Dim Memory_AvaiableMBytes As PerformanceCounter
    Dim QAvailableMBytes As Queue(Of Long)

    Dim Memory_Pages, Memory_InputPages, Memory_OutputPages As PerformanceCounter
    Dim LastMemoryPages_RawValue, LastMemoryInputPages_RawValue, LastMemoryOutputPages_RawValue As Long
    Dim QPages As Queue(Of Long)

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        QAvailableMBytes = New Queue(Of Long)
        Memory_AvaiableMBytes = New PerformanceCounter("Memory", "Available MBytes")

        QPages = New Queue(Of Long)
        Memory_Pages = New PerformanceCounter("Memory", "Pages/sec")
        Memory_InputPages = New PerformanceCounter("Memory", "Pages Input/sec")
        Memory_OutputPages = New PerformanceCounter("Memory", "Pages Output/sec")
        LastMemoryPages_RawValue = Memory_Pages.RawValue
        LastMemoryInputPages_RawValue = Memory_InputPages.RawValue
        LastMemoryOutputPages_RawValue = Memory_OutputPages.RawValue

        Timer1.Interval = 100 : Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblMemoryAvailableMBytes.Text = Memory_AvaiableMBytes.RawValue
        QAvailableMBytes.Enqueue(lblMemoryAvailableMBytes.Text)
        DisplayQAvaiableMBytes()

        lblMemory_Pages.Text = Memory_Pages.RawValue - LastMemoryPages_RawValue
        lblMemory_InputPages.Text = Memory_InputPages.RawValue - LastMemoryInputPages_RawValue
        lblMemory_OutputPages.Text = Memory_OutputPages.RawValue - LastMemoryOutputPages_RawValue
        QPages.Enqueue(lblMemory_Pages.Text)
        If QPages.Count > 100 Then
            QPages.Dequeue()
        End If
        LastMemoryPages_RawValue = Memory_Pages.RawValue
        LastMemoryInputPages_RawValue = Memory_InputPages.RawValue
        LastMemoryOutputPages_RawValue = Memory_OutputPages.RawValue
        DisplayQPages()
    End Sub

    Sub DisplayQAvaiableMBytes()
        Me.Chart1.Series(0).ChartType = SeriesChartType.Line
        Me.Chart1.Series("Series1").Points.Clear()
        For i = 0 To QAvailableMBytes.Count - 1
            Me.Chart1.Series("Series1").Points.AddXY(i, QAvailableMBytes(i))
        Next
        Chart1.Legends("Legend1").Docking = Docking.Top
    End Sub

    Sub DisplayQPages()
        Me.Chart2.Series(0).ChartType = SeriesChartType.Line
        Me.Chart2.Series("Series1").Points.Clear()
        For i = 0 To QPages.Count - 1
            Me.Chart2.Series("Series1").Points.AddXY(i, QPages(i))
        Next
        Chart2.Legends("Legend1").Docking = Docking.Top
    End Sub

End Class

