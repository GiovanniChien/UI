Imports System.Math

Public Class clsEquation2
    Private a, b, c As Single
    Public Sub New(ByVal a As Single, ByVal b As Single, ByVal c As Single)
        Me.a = a : Me.b = b : Me.c = c
    End Sub

    Function Solve01() As List(Of Single)
        Dim delta As Single = b * b - 4 * a * c
        Dim t As Single, ts As New List(Of Single)
        If delta > 0 Then
            t = (-b + Sqrt(delta)) / 2
            If t >= 0 And t <= 1 Then ts.Add(t)
            t = (-b - Sqrt(delta)) / 2
            If t >= 0 And t <= 1 Then ts.Add(t)
        End If
        If delta = 0 Then
            t = -b / 2
            If t >= 0 And t <= 1 Then ts.Add(t)
        End If
        Return ts
    End Function

End Class
