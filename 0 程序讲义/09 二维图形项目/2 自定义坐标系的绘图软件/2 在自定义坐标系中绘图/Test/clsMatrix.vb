
Public Class clsMatrix
    Dim M11, M12, M13 As Single
    Dim M21, M22, M23 As Single
    Dim M31, M32, M33 As Single
    Public Sub Mul(m As clsMatrix)
        Dim V11 As Single = M11 * m.M11 + M12 * m.M21 + M13 * m.M31
        Dim V12 As Single = M11 * m.M12 + M12 * m.M22 + M13 * m.M32
        Dim V13 As Single = M11 * m.M13 + M12 * m.M23 + M13 * m.M33
        Dim V21 As Single = M21 * m.M11 + M22 * m.M21 + M23 * m.M31
        Dim V22 As Single = M21 * m.M12 + M22 * m.M22 + M23 * m.M32
        Dim V23 As Single = M21 * m.M13 + M22 * m.M23 + M23 * m.M33
        Dim V31 As Single = M31 * m.M11 + M32 * m.M21 + M33 * m.M31
        Dim V32 As Single = M31 * m.M12 + M32 * m.M22 + M33 * m.M32
        Dim V33 As Single = M31 * m.M13 + M22 * m.M23 + M33 * m.M33
        M11 = V11 : M12 = V12 : M13 = V13
        M21 = V21 : M22 = V22 : M23 = V23
        M31 = V31 : M32 = V32 : M33 = V33
    End Sub

    Public Sub New()
        M11 = 1 : M12 = 0 : M13 = 0
        M21 = 0 : M22 = 1 : M23 = 0
        M31 = 0 : M32 = 0 : M33 = 1
    End Sub
    Public Sub SetPan(dx As Single, dy As Single)
        M11 = 1 : M12 = 0 : M13 = 0
        M21 = 0 : M22 = 1 : M23 = 0
        M31 = dx : M32 = dy : M33 = 1
    End Sub
    Public Sub SetScale(xscale As Single, yscale As Single)
        M11 = xscale : M12 = 0 : M13 = 0
        M21 = 0 : M22 = yscale : M23 = 0
        M31 = 0 : M32 = 0 : M33 = 1
    End Sub

    Public Function Transform(p As PointF) As PointF
        Dim newp As PointF
        newp.X = p.X * M11 + p.Y * M21 + M31
        newp.Y = p.X * M12 + p.Y * M22 + M32
        Return newp
    End Function

End Class
