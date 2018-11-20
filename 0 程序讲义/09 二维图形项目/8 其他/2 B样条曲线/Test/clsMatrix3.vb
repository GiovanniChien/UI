Class clsMatrix3
    Private M11, M12, M13 As Single
    Private M21, M22, M23 As Single
    Private M31, M32, M33 As Single

    Public Sub New()
        M11 = 1 : M12 = 0 : M13 = 0
        M21 = 0 : M22 = 1 : M23 = 0
        M31 = 0 : M32 = 0 : M33 = 1
    End Sub
    Sub New(a As Single, b As Single, c As Single, d As Single)
        M11 = a : M12 = 0 : M13 = 0
        M21 = 0 : M22 = c : M23 = 0
        M31 = b : M32 = d : M33 = 1
    End Sub

    Function Tranform(p As PointF) As PointF
        Dim newp As PointF
        newp.X = p.X * M11 + p.Y * M21 + M31
        newp.Y = p.X * M12 + p.Y * M22 + M32
        Return newp
    End Function

End Class
