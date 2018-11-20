Imports System.Math

Structure Complex
    Public real As Single
    Public image As Single
    Sub New(ByVal real As Single, ByVal image As Single)
        Me.real = real
        Me.image = image
    End Sub

End Structure
Public Class clsEquation3
    Private a, b, c, d As Single

    Public Sub New(ByVal a As Single, ByVal b As Single, ByVal c As Single, ByVal d As Single)
        Me.a = a : Me.b = b : Me.c = c : Me.d = d
    End Sub

    '求解方程 a*x^3 + b*x^2 +c*x +d = 0 在[0,1]之间的实数解
    Function Solve01() As List(Of Single)
        Dim x() As Complex = Solve()
        Dim x01 As New List(Of Single)
        For i = 0 To 2
            If x(i).real >= 0 And x(i).real <= 1 And Abs(x(i).image) < 0.00001 Then
                x01.Add(x(i).real)
            End If
        Next
        Return x01
    End Function

    '求解方程 a*x^3 + b*x^2 +c*x +d = 0
    Private Function Solve() As Complex()
        Dim p As Single = (3 * a * c - b * b) / (3 * a * a)
        Dim q As Single = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a)
        Dim x() As Complex = Solve1(p, q)
        For i = 0 To 2
            x(i).real = x(i).real - b / (3 * a)
        Next
        Return x
    End Function

    ' 求解方程的解 x^3 + px +q = 0
    Private Function Solve1(ByVal p As Single, ByVal q As Single) As Complex()
        Dim x(2) As Complex
        Dim delta As Single = q * q / 4 + p * p * p / 27
        If delta > 0 Then
            Dim b1 As Complex = New Complex(-1 / 2, Sqrt(3) / 2)
            Dim b2 As Complex = New Complex(-1 / 2, -Sqrt(3) / 2)
            Dim a1 As Single = Pow(-q / 2 + Sqrt(delta), 1 / 3)
            Dim a2 As Single = Pow(-q / 2 - Sqrt(delta), 1 / 3)
            x(0).real = a1 + a2 : x(0).image = 0
            x(1).real = a1 * b1.real + a2 * b2.real : x(1).image = a1 * b1.image + a2 * b2.image
            x(2).real = a1 * b2.real + a2 * b1.real : x(2).image = a1 * b2.image + a2 * b1.image
        End If
        If delta = 0 Then
            x(0).real = -2 * Sqrt(-p / 3) : x(0).image = 0
            x(1).real = Sqrt(-p / 3) : x(1).image = 0
            x(2).real = Sqrt(-p / 3) : x(2).image = 0
        End If
        If delta < 0 Then
            Dim theta As Single = Acos((-q * Sqrt(-27 * p)) / (2 * p * p))
            x(0).real = 2 * Sqrt(-p / 3) * Cos(theta / 3) : x(0).image = 0
            x(1).real = 2 * Sqrt(-p / 3) * Cos(theta / 3 + 2 / 3 * PI) : x(1).image = 0
            x(2).real = 2 * Sqrt(-p / 3) * Cos(theta / 3 - 2 / 3 * PI) : x(2).image = 0
        End If
        Return x
    End Function
End Class
