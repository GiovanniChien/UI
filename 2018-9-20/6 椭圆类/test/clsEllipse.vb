Imports System.Math

Public Class clsEllipse
    Dim X As Integer
    Dim Y As Integer
    Dim Width As Integer
    Dim Height As Integer

    Public Sub New(ByVal sp As Point, ByVal ep As Point)
        If sp.X < ep.X Then
            X = sp.X
        Else
            X = ep.X
        End If
        If sp.Y < ep.Y Then
            Y = sp.Y
        Else
            Y = ep.Y
        End If
        Width = Abs(sp.X - ep.X)
        Height = Abs(sp.Y - ep.Y)
    End Sub

    Public Sub Draw(ByVal g As Graphics, ByVal pen As Pen)
        g.DrawEllipse(pen, X, Y, Width, Height)
    End Sub
End Class
