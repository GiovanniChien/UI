Imports System.Math

Public Class clsMatrix3
    Private M(2, 2) As Single

    Public Sub New()
        M(0, 0) = 1 : M(0, 1) = 0 : M(0, 2) = 0
        M(1, 0) = 0 : M(1, 1) = 1 : M(1, 2) = 0
        M(2, 0) = 0 : M(2, 1) = 0 : M(2, 2) = 1
    End Sub

    Public Sub SetPan(xoffset As Single, yoffset As Single)
        M(0, 0) = 1 : M(0, 1) = 0 : M(0, 2) = 0
        M(1, 0) = 0 : M(1, 1) = 1 : M(1, 2) = 0
        M(2, 0) = xoffset : M(2, 1) = yoffset : M(2, 2) = 1
    End Sub
    Public Sub SetRotate(angle As Single)
        M(0, 0) = Cos(angle) : M(0, 1) = Sin(angle) : M(0, 2) = 0
        M(1, 0) = -Sin(angle) : M(1, 1) = Cos(angle) : M(1, 2) = 0
        M(2, 0) = 0 : M(2, 1) = 0 : M(2, 2) = 1
    End Sub
    Public Sub SetScale(xscale As Single, yscale As Single)
        M(0, 0) = xscale : M(0, 1) = 0 : M(0, 2) = 0
        M(1, 0) = 0 : M(1, 1) = yscale : M(1, 2) = 0
        M(2, 0) = 0 : M(2, 1) = 0 : M(2, 2) = 1
    End Sub

    Public Function Tranform(p As PointF) As PointF
        Dim newp As PointF
        newp.X = p.X * M(0, 0) + p.Y * M(1, 0) + M(2, 0)
        newp.Y = p.X * M(0, 1) + p.Y * M(1, 1) + M(2, 1)
        Return newp
    End Function

    Public Sub Tranform(points() As PointF)
        For i = 0 To points.Count - 1
            points(i) = Tranform(points(i))
        Next
    End Sub

    Public Sub Tranform(Points As List(Of PointF))
        For i = 0 To Points.Count - 1
            Points(i) = Tranform(Points(i))
        Next
    End Sub
    '当前对象中的矩阵 左乘 M1中的矩阵，结果存在当前对象中
    Public Sub Mul(M1 As clsMatrix3)
        Dim v(2, 2) As Single
        For i = 0 To 2
            For j = 0 To 2
                v(i, j) = 0
                For k = 0 To 2
                    v(i, j) += M(i, k) * M1.M(k, j)
                Next
            Next
        Next
        For i = 0 To 2
            For j = 0 To 2
                M(i, j) = v(i, j)
            Next
        Next
    End Sub

    Public Function Clone() As clsMatrix3
        Dim Matrix As New clsMatrix3
        For i = 0 To 2
            For j = 0 To 2
                Matrix.M(i, j) = M(i, j)
            Next
        Next
        Return Matrix
    End Function

    '计算行列式的值
    Public Function Determinant() As Single
        Dim d1, d2 As Single
        d1 = M(0, 0) * M(1, 1) * M(2, 2) + M(0, 1) * M(1, 2) * M(2, 0) + M(0, 2) * M(1, 0) * M(2, 1)
        d2 = M(0, 0) * M(1, 2) * M(2, 1) + M(0, 1) * M(1, 0) * M(2, 2) + M(0, 2) * M(1, 1) * M(2, 0)
        Return d1 - d2
    End Function

    Public Function Invert() As clsMatrix3
        Dim D As Single = Determinant()
        Dim InvertM As New clsMatrix3
        InvertM.M(0, 0) = M(1, 1) * M(2, 2) - M(1, 2) * M(2, 1)
        InvertM.M(1, 0) = -M(1, 0) * M(2, 2) + M(1, 2) * M(2, 0)
        InvertM.M(2, 0) = M(1, 0) * M(2, 1) - M(1, 1) * M(2, 0)
        InvertM.M(0, 1) = -M(0, 1) * M(2, 2) + M(0, 2) * M(2, 1)
        InvertM.M(1, 1) = M(0, 0) * M(2, 2) - M(0, 2) * M(2, 0)
        InvertM.M(2, 1) = -M(0, 0) * M(2, 1) + M(0, 1) * M(2, 0)
        InvertM.M(0, 2) = M(0, 1) * M(1, 2) - M(0, 2) * M(1, 1)
        InvertM.M(1, 2) = -M(0, 0) * M(1, 2) + M(0, 2) * M(1, 0)
        InvertM.M(2, 2) = M(0, 0) * M(1, 1) - M(0, 1) * M(1, 0)
        For i = 0 To 2
            For j = 0 To 2
                InvertM.M(i, j) = InvertM.M(i, j) / D
            Next
        Next
        Return InvertM
    End Function

    Public Overrides Function ToString() As String
        Dim s As String = "Matrix: "
        For i = 0 To 2
            Dim s1 As String = ""
            For j = 0 To 2
                s1 = s1 & M(i, j) & " "
            Next
            s = s & " (" & s1 & ") "
        Next
        Return s
    End Function

End Class
