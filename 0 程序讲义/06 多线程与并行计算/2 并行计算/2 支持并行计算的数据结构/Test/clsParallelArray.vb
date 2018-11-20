Imports System.Threading.Tasks

Public Class clsParallelArray
    Const ElemCount As Integer = 1000000
    Private A(ElemCount) As Single
    Private TaskCount As Integer  '并行的任务个数

    Public Sub New(TaskCount As Integer)
        Me.TaskCount = TaskCount
    End Sub

    ' 顺序计算
    Public Function RunSquence() As Integer
        Dim sw As Stopwatch = New Stopwatch()
        sw.Start() ' 启动计时
        Do1(0, ElemCount)
        sw.Stop()  ' 停止计时
        Dim UsedTime As Integer = sw.ElapsedMilliseconds '获取算法执行时间
        Return UsedTime
    End Function

    ' 并行计算
    Public Function RunParallel() As Integer
        Dim sw As Stopwatch = New Stopwatch()
        sw.Start() ' 启动计时
        Parallel.For(0, TaskCount, AddressOf DoParallel) '将任务分成TaskCount个子任务：编号为[0,TaskCount-1]
        sw.Stop()  ' 停止计时
        Dim UsedTime As Integer = sw.ElapsedMilliseconds '获取算法执行时间
        Return UsedTime
    End Function
    Private Sub DoParallel(i As Integer)
        ' 根据子任务的编号i，计算子任务的参数
        Dim n1 As Integer = ElemCount / TaskCount  ' 子任务计算的数据个数
        Dim si As Integer = i * n1                 ' 子任务计算的起始下标
        '每个任务的计算范围A(si)...A(si+n1-1)
        Do1(si, n1)  '任务之间的数据范围交叉时，不报错
    End Sub

    '对A(si)...A(si+n1-1)中的每个元素，重复执行1000次基本操作
    Private Sub Do1(si As Integer, n1 As Integer)
        For I = si To si + n1 - 1
            For j = 0 To 1000
                A(I) += 1
            Next
        Next
    End Sub

End Class
