Imports System.IO
Imports System.Threading.Tasks

Public Class clsBitmaps
    Private path As String
    Private xyBitmaps, xzBitmaps, yzBitmaps As List(Of Bitmap)
    Public Nx, Ny, Nz As Integer
    Private TaskCount As Integer = 4

    Public Sub New(path As String)
        Me.path = path
        xyBitmaps = New List(Of Bitmap)
        Dim files() As String = Directory.GetFiles(path)
        Nz = files.Count
        For i = 0 To Nz - 1
            xyBitmaps.Add(New Bitmap(files(i)))
        Next
        Nx = xyBitmaps(0).Width : Ny = xyBitmaps(0).Height

        yzBitmaps = New List(Of Bitmap)
        For i = 0 To Nx - 1
            yzBitmaps.Add(New Bitmap(Ny, Nz))
        Next
        xzBitmaps = New List(Of Bitmap)
        For i = 0 To Ny - 1
            xzBitmaps.Add(New Bitmap(Nx, Nz))
        Next
    End Sub

    Public Function CreateXYZBitmaps() As Integer
        Dim sw As Stopwatch = New Stopwatch()
        sw.Start() ' 启动计时
        Parallel.For(0, TaskCount, AddressOf DoParallel) '将任务分成TaskCount个子任务：编号为[0,TaskCount-1]
        sw.Stop()  ' 停止计时
        Dim UsedTime As Integer = sw.ElapsedMilliseconds '获取算法执行时间
        Return UsedTime
    End Function

    Private Sub DoParallel(i As Integer)
        ' 根据子任务的编号i，计算子任务的参数
        Dim n1 As Integer = Nz / TaskCount  ' 子任务计算的数据个数
        Dim si As Integer = i * n1          ' 子任务计算的起始下标
        If si + n1 > Nz Then n1 = Nz - si
        ' 读取xyBitmaps(si)...xyBitmaps(si+n1-1)像素值，写入相应的xzBitmaps(y)，yzBitmaps(x)中
        Do1(si, n1)
    End Sub

    '对A(si)...A(si+n1-1)中的每个元素，重复执行1000次基本操作
    Private Sub Do1(si As Integer, n1 As Integer)
        Dim pcolor As Color
        ' Try整个循环：结果图像非常不完整，本质上一个时刻只进行了一个子任务 
        For z = si To si + n1 - 1
            For x = 0 To Nx - 1
                For y = 0 To Ny - 1
                    ' Try两个SetPixel： 图像完整，但耗时超过不并行的算法
                    ' System.InvalidOperationException：对象当前正在其他地方使用 
                    pcolor = xyBitmaps(z).GetPixel(x, y)
                    yzBitmaps(x).SetPixel(y, z, pcolor)
                    xzBitmaps(y).SetPixel(x, z, pcolor)
                    'Catch ex As Exception
                    '    Continue For
                    'End Try
                Next
            Next
        Next
    End Sub

    Public Function GetXYBitmap(index As Integer) As Bitmap
        Return xyBitmaps(index)
    End Function
    Public Function GetXZBitmap(index As Integer) As Bitmap
        Return xzBitmaps(index)
    End Function
    Public Function GetYZBitmap(index As Integer) As Bitmap
        Return yzBitmaps(index)
    End Function

End Class
