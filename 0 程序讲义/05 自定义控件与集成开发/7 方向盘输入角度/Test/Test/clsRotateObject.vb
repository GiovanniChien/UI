Imports System.Drawing.Drawing2D

Public Class clsRotateObject
    Private bkc As Color   '背景色（标记被忽略的点）
    Private src As Bitmap  '图像
    Private kps As List(Of PointF), kcs As List(Of Color)  '图像中的需要变换的点及其颜色

    Public Function Width() As Integer
        Return src.Width
    End Function
    Public Function Height() As Integer
        Return src.Height
    End Function
    Public Function Image() As Bitmap
        Return src
    End Function

    Public Sub New(ByVal picfname As String)
        bkc = Color.White
        src = New Bitmap(picfname)
        kps = New List(Of PointF) : kcs = New List(Of Color)
        For x = 0 To src.Width - 1
            For y = 0 To src.Height - 1
                If src.GetPixel(x, y).ToArgb <> bkc.ToArgb Then
                    kps.Add(New PointF(x, y))
                    kcs.Add(src.GetPixel(x, y))
                End If
            Next
        Next
    End Sub
    Public Function Rotate(ByVal angle As Integer) As Bitmap
        Dim target As Bitmap = New Bitmap(src.Width, src.Height)
        For x = 0 To src.Width - 1
            For y = 0 To src.Height - 1
                target.SetPixel(x, y, bkc)
            Next
        Next
        Dim cp As Point = New Point(src.Width / 2 - 1, src.Height / 2 - 1)
        Dim m As New Matrix : m.RotateAt(angle, cp)
        '图形的点集
        Dim ArrayKps As PointF() = kps.ToArray
        m.TransformPoints(ArrayKps)
        For i = 0 To ArrayKps.Count - 1
            target.SetPixel(ArrayKps(i).X, ArrayKps(i).Y, kcs(i))
        Next
        Return target
    End Function

End Class
