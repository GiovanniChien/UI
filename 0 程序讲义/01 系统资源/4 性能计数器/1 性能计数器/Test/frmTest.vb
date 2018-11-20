Public Class frmTest

    Dim Counters As List(Of PerformanceCounter)    ' 动态数组的连接不方便，所以选择List作为存储结构
    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        ' PerformanceCounterCategory: 性能对象（定义了性能计数器的类别）
        Dim Categories() As PerformanceCounterCategory = PerformanceCounterCategory.GetCategories()
        For i = 0 To Categories.Count - 1
            lstCategory.Items.Add(Categories(i).CategoryName)
        Next
    End Sub

    Private Sub lstCategory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstCategory.SelectedIndexChanged
        Dim CategoryName As String = lstCategory.Items(lstCategory.SelectedIndex)
        ' 查询计数器对象列表
        Dim Counters As List(Of PerformanceCounter) = GetCounters(CategoryName)
        DisplayList(Counters)
    End Sub
    ' 查询计数器对象列表
    Private Function GetCounters(CategoryName As String) As List(Of PerformanceCounter)
        ' 建立性能对象
        Dim Category As PerformanceCounterCategory = New PerformanceCounterCategory(CategoryName)
        Dim InstanceNames() As String = Category.GetInstanceNames() ' 检索性能对象的实例
        If InstanceNames.Length = 0 Then
            Counters = Category.GetCounters().ToList   '检索正好包含一个实例的某性能计数器类别中的计数器列表。
        Else
            Counters = New List(Of PerformanceCounter)
            For i = 0 To InstanceNames.Length - 1
                Dim tmp As List(Of PerformanceCounter) = Category.GetCounters(InstanceNames(i)).ToList
                Counters.AddRange(tmp)
            Next
        End If
        Return Counters
    End Function

    Private Sub DisplayList(Counters As List(Of PerformanceCounter))
        lstCounter.Items.Clear()
        Try
            For i = 0 To Counters.Count - 1
                Dim counter As PerformanceCounter = Counters(i)
                ' RawValue: 计数器的原始值
                lstCounter.Items.Add(counter.InstanceName & vbTab & counter.CounterName & vbTab & counter.RawValue)
            Next
        Catch ex As Exception
            lstCounter.Items.Add("错误！！！！")
        End Try
    End Sub

    Private Sub lstCounter_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstCounter.SelectedIndexChanged
        Dim k As Integer = lstCounter.SelectedIndex
        ' CounterHelp：性能计数器的说明
        lblCounterHelp.Text = Counters(k).CounterHelp
    End Sub
End Class
