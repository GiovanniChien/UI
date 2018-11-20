Imports System.Math

Public Structure LineSegment    ' y=A+Bx
    Public A As Single
    Public B As Single
End Structure

Public Class clsFitLineSegment
    Private Points As List(Of Point)

    Private A, B As Single  ' 拟合直线方程：y=A+Bx
    Public r As Single     ' 相关系数[-1,1], 若r->0表示x,y无线性关系；若abs(r)->1表示x,y线性关系好

    Public Function GetLineSegment() As LineSegment
        Dim LS As New LineSegment
        LS.A = A : LS.B = B
        Return LS
    End Function

    Public Sub New(Points As List(Of Point))
        Me.Points = Points
        Fit()
    End Sub

    Public Sub Fit()
        ' 将点集Points拟合为直线 y=A+Bx
        Dim n As Integer = Points.Count
        Dim sumX As Single = 0, sumY As Single = 0
        Dim sumXX As Single = 0, sumXY As Single = 0
        For i = 0 To n - 1
            sumX += Points(i).X : sumY += Points(i).Y
            sumXX += Points(i).X * Points(i).X
            sumXY += Points(i).X * Points(i).Y
        Next
        Dim ab As Single = sumX * sumX - n * sumXX
        A = (sumXY * sumX - sumY * sumXX) / ab
        B = (sumX * sumY - n * sumXY) / ab
        If Single.IsNaN(B) Then   ' 竖直线段的斜率为无穷大，A为x(0)
            A = Points(0).X       ' 方程为 x=A
        End If
        ' 计算相关系数
        Dim meanX As Single = sumX / n, meanY As Single = sumY / n
        Dim dx, dy As Single
        Dim sumDxDy As Single = 0, sumDxDx As Single = 0, sumDyDy As Single = 0
        For i = 0 To n - 1
            dx = Points(i).X - meanX : dy = Points(i).Y - meanY
            sumDxDy += dx * dy
            sumDxDx += dx * dx : sumDyDy += dy * dy
        Next
        r = sumDxDy / (Sqrt(sumDxDx) * Sqrt(sumDyDy))
    End Sub

End Class

