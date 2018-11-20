Imports System.Math

Public Class clsHermite
    Private M(,) As Single = {{2, -2, 1, 1}, {-3, 3, -2, -1}, {0, 0, 1, 0}, {1, 0, 0, 0}}
    Private G(3, 1) As Single
    Private sp, ep As PointF

    Public Sub New(ByVal p1 As PointF, ByVal p2 As PointF, ByVal p3 As PointF)
        sp = New PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2)
        ep = New PointF((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2)
        G(0, 0) = sp.X : G(0, 1) = sp.Y
        G(1, 0) = ep.X : G(1, 1) = ep.Y
        G(2, 0) = p2.X - p1.X : G(2, 1) = p2.Y - p1.Y
        G(3, 0) = p3.X - p2.X : G(3, 1) = p3.Y - p2.Y
    End Sub
    Sub GetYminmax(ByRef ymin As Integer, ByRef ymax As Integer)
        ' ts是极值点的t值和起点、终点处的t值
        Dim ts As List(Of Single) = D0()
        ts.Add(0) : ts.Add(1)
        ' ys是ts对应的y值集合
        Dim ys As New List(Of Single)
        For i = 0 To ts.Count - 1
            ys.Add(GetPoint(ts(i)).Y)
        Next
        ymin = ys.Min
        ymax = ys.Max
    End Sub
    ' 求y对t的偏导数为0处的T实数解(解在[0,1]之间)
    Public Function D0() As List(Of Single)
        ' y对t的偏导数：
        ' (6*g01 - 6*g11 + 3*g21 + 3*g31)*t^2 + (6*g11 - 6*g01 - 4*g21 - 2*g31)*t + g21
        ' a*t^2 + b*t + c = 0
        Dim a As Single = 6 * G(0, 1) - 6 * G(1, 1) + 3 * G(2, 1) + 3 * G(3, 1)
        Dim b As Single = 6 * G(1, 1) - 6 * G(0, 1) - 4 * G(2, 1) - 2 * G(3, 1)
        Dim c As Single = G(2, 1)
        Dim Eq As New clsEquation2(a, b, c)
        Return Eq.Solve01()
    End Function


    ' 求解扫描线高度为y时的T值，可能有两个数值
    Public Function GetT(ByVal y As Single) As List(Of Single)
        Dim MG(3, 1) As Single
        For i = 0 To 3
            For j = 0 To 1
                MG(i, j) = 0
                For k = 0 To 3
                    MG(i, j) += M(i, k) * G(k, j)
                Next
            Next
        Next
        '为什么 MG(0, 0) = 0 并且 MG(0, 1) =0
        ' 求解方程：MG(0, 1)*T^3 + MG(1, 1)*T^2 + MG(2, 1)*T + MG(3, 1) = y  
        ' 求解方程：MG(1, 1)*T^2 + MG(2, 1)*T + MG(3, 1) - y  =0
        'Dim Eq As New clsEquation3(MG(0, 1), MG(1, 1), MG(2, 1), MG(3, 1) - y)
        'Return Eq.Solve01()
        Dim Eq As New clsEquation2(MG(1, 1), MG(2, 1), MG(3, 1) - y)
        Return Eq.Solve01()
    End Function

    ' 参数t: [0, 1]
    Public Function GetPoint(ByVal t As Single) As PointF
        Dim TT() As Single = {t * t * t, t * t, t, 1}
        Dim v(3) As Single
        For i = 0 To 3   ' TT * M => v
            v(i) = TT(0) * M(0, i) + TT(1) * M(1, i) + TT(2) * M(2, i) + TT(3) * M(3, i)
        Next
        Dim p As PointF ' v * G => p
        p.X = v(0) * G(0, 0) + v(1) * G(1, 0) + v(2) * G(2, 0) + v(3) * G(3, 0)
        p.Y = v(0) * G(0, 1) + v(1) * G(1, 1) + v(2) * G(2, 1) + v(3) * G(3, 1)
        Return p
    End Function

    ' 求导数的数值解
    Public Function D(ByVal t As Single) As PointF
        Dim dp As PointF
        Dim TT() As Single = {3 * t * t, 2 * t, 1}, V(3) As Single
        V(0) = TT(0) * M(0, 0) + TT(1) * M(1, 0) + TT(2) * M(2, 0)
        V(1) = TT(0) * M(0, 1) + TT(1) * M(1, 1) + TT(2) * M(2, 1)
        V(2) = TT(0) * M(0, 2) + TT(1) * M(1, 2) + TT(2) * M(2, 2)
        V(3) = TT(0) * M(0, 3) + TT(1) * M(1, 3) + TT(2) * M(2, 3)
        dp.X = V(0) * G(0, 0) + V(1) * G(1, 0) + V(2) * G(2, 0) + V(3) * G(3, 0)
        dp.Y = V(0) * G(0, 1) + V(1) * G(1, 1) + V(2) * G(2, 1) + V(3) * G(3, 1)
        Return dp
    End Function


End Class
