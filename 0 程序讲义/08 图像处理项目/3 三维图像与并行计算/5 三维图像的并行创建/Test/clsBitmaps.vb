Imports System.IO
Imports System.Threading.Tasks

Public Class clsBitmaps
    Private path As String
    Private xyBitmaps, xzBitmaps, yzBitmaps As List(Of Bitmap)
    Public Nx, Ny, Nz As Integer
    Private TaskCount As Integer = 4
    Private Buff(,,) As Color

    Public Sub New(path As String)
        Me.path = path
        xyBitmaps = New List(Of Bitmap)
        Dim files() As String = Directory.GetFiles(path)
        Nz = files.Count
        For i = 0 To Nz - 1
            xyBitmaps.Add(New Bitmap(files(i)))
        Next
        Nx = xyBitmaps(0).Width : Ny = xyBitmaps(0).Height

        xzBitmaps = New List(Of Bitmap)
        For i = 0 To Ny - 1
            xzBitmaps.Add(New Bitmap(Nx, Nz))
        Next

        yzBitmaps = New List(Of Bitmap)
        For i = 0 To Nx - 1
            yzBitmaps.Add(New Bitmap(Ny, Nz))
        Next
    End Sub

    Public Function CreateXYZBitmaps() As Integer
        Dim sw As Stopwatch = New Stopwatch()
        sw.Start() ' 启动计时
        ReDim Buff(Nx - 1, Ny - 1, Nz - 1)
        Parallel.For(0, TaskCount, AddressOf ReadParalleXY)  ' 耗时4秒
        Parallel.For(0, TaskCount, AddressOf WriteParalleXZ) ' 耗时9秒
        Parallel.For(0, TaskCount, AddressOf WriteParalleYZ) ' 耗时9秒
        sw.Stop()  ' 停止计时
        Dim UsedTime As Integer = sw.ElapsedMilliseconds '获取算法执行时间
        Return UsedTime
    End Function
    Private Sub ReadParalleXY(i As Integer)
        ' 根据子任务的编号i，计算子任务的参数
        Dim n1 As Integer = Nz / TaskCount  ' 子任务计算的数据个数
        Dim si As Integer = i * n1          ' 子任务计算的起始下标
        If si + n1 > Nz Then n1 = Nz - si
        '每个任务的读取范围：xyBitmaps(si)...xyBitmaps(si+n1-1)
        ReadXY(si, n1)
    End Sub
    Private Sub ReadXY(si As Integer, n1 As Integer)
        For z = si To si + n1 - 1
            For x = 0 To Nx - 1
                For y = 0 To Ny - 1
                    Buff(x, y, z) = xyBitmaps(z).GetPixel(x, y)
                Next
            Next
        Next
    End Sub

    Private Sub WriteParalleXZ(i As Integer)
        ' 根据子任务的编号i，计算子任务的参数
        Dim n1 As Integer = Ny / TaskCount  ' 子任务计算的数据个数
        Dim si As Integer = i * n1          ' 子任务计算的起始下标
        If si + n1 > Ny Then n1 = Ny - si
        '每个任务的写入范围：xzBitmaps(si)...xzBitmaps(si+n1-1)
        WriteXZ(si, n1)
    End Sub
    Private Sub WriteXZ(si As Integer, n1 As Integer)
        For y = si To si + n1 - 1
            For x = 0 To Nx - 1
                For z = 0 To Nz - 1
                    xzBitmaps(y).SetPixel(x, z, Buff(x, y, z))
                Next
            Next
        Next
    End Sub

    Private Sub WriteParalleYZ(i As Integer)
        ' 根据子任务的编号i，计算子任务的参数
        Dim n1 As Integer = Nx / TaskCount  ' 子任务计算的数据个数
        Dim si As Integer = i * n1          ' 子任务计算的起始下标
        If si + n1 > Nx Then n1 = Nx - si
        '每个任务的写入范围：yzBitmaps(si)...yzBitmaps(si+n1-1)
        WriteYZ(si, n1)
    End Sub
    Private Sub WriteYZ(si As Integer, n1 As Integer)
        For x = si To si + n1 - 1
            For y = 0 To Ny - 1
                For z = 0 To Nz - 1
                    yzBitmaps(x).SetPixel(y, z, Buff(x, y, z))
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
