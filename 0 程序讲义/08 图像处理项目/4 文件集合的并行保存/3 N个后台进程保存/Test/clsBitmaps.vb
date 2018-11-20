Imports System.IO
Imports System.Threading.Tasks

Public Class clsBitmaps
    Private path As String
    Private Bitmaps As List(Of Bitmap)
    Public N As Integer
    Private TaskCount As Integer = 4

    Event SaveProgress(ByVal ith As Integer)

    Public Sub New(ByVal path As String)
        Me.path = path
        Bitmaps = New List(Of Bitmap)
        Dim files() As String = Directory.GetFiles(path)
        N = files.Count
        For i = 0 To N - 1
            Bitmaps.Add(New Bitmap(files(i)))
        Next
    End Sub

    Public Function GetBitmap(ByVal index As Integer) As Bitmap
        Return Bitmaps(index)
    End Function

    Public Sub Save(ByVal path As String, ByVal si As Integer, ByVal ei As Integer)
        For i = si To ei - 1
            Bitmaps(i).Save(path & "xy" & i & ".bmp", Imaging.ImageFormat.Bmp)
            RaiseEvent SaveProgress(i)
        Next
    End Sub


End Class
