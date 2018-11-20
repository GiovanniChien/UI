Imports System.Math

Public Class clsCircle
    Private cp As Point
    Public r As Integer
    Public color As Color

    Public Sub New(ByVal cp As Point, ByVal r As Integer, ByVal color As Color)
        Me.cp = cp : Me.r = r
        Me.color = color
    End Sub
    Public Sub New(ByVal cp As Point, ByVal ep As Point, ByVal color As Color)
        Me.cp = cp
        Me.r = Sqrt((ep.X - cp.X) * (ep.X - cp.X) + (ep.Y - cp.Y) * (ep.Y - cp.Y))
        Me.color = color
    End Sub

    Public Sub Draw(ByVal buffer As Bitmap)
        Dim d As Integer = 1 - r
        Dim p As Point = New Point(0, r)
        While p.X < p.Y
            buffer.SetPixel(cp.X + p.X, cp.Y + p.Y, color)
            buffer.SetPixel(cp.X - p.X, cp.Y + p.Y, color)
            buffer.SetPixel(cp.X + p.X, cp.Y - p.Y, color)
            buffer.SetPixel(cp.X - p.X, cp.Y - p.Y, color)

            buffer.SetPixel(cp.X + p.Y, cp.Y + p.X, color)
            buffer.SetPixel(cp.X - p.Y, cp.Y + p.X, color)
            buffer.SetPixel(cp.X + p.Y, cp.Y - p.X, color)
            buffer.SetPixel(cp.X - p.Y, cp.Y - p.X, color)
            p.X += 1
            If d < 0 Then
                d = d + 2 * p.X + 1
            Else
                p.Y -= 1 : d = d + 2 * p.X - 2 * p.Y + 1
            End If
        End While
    End Sub
End Class
