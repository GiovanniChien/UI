Imports System.IO

Public Class clsBitmaps
    Private path As String
    Private xyBitmaps, xzBitmaps, yzBitmaps As List(Of Bitmap)
    Public Nx, Ny, Nz As Integer

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
        Dim pcolor As Color
        For z = 0 To Nz - 1
            For x = 0 To Nx - 1
                For y = 0 To Ny - 1
                    pcolor = xyBitmaps(z).GetPixel(x, y)
                    yzBitmaps(x).SetPixel(y, z, pcolor)
                    xzBitmaps(y).SetPixel(x, z, pcolor)
                Next
            Next
        Next
        sw.Stop()  ' 停止计时
        Dim UsedTime As Integer = sw.ElapsedMilliseconds '获取算法执行时间
        Return UsedTime
    End Function

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
