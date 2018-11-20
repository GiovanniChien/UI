Public Class clsTriangle
    Public Point(2) As clsPoint3

    Public Sub New(content As String)
        '将content分解3个vertex....块
        Dim k1 As Integer = content.IndexOf("vertex", 0)
        Dim k2 As Integer = content.IndexOf("vertex", k1 + 1)
        Dim k3 As Integer = content.IndexOf("vertex", k2 + 1)
        Dim k4 As Integer = content.IndexOf("endloop", k3 + 1)
        Dim sp(2) As String
        sp(0) = content.Substring(k1, k2 - k1)
        sp(1) = content.Substring(k2, k3 - k2)
        sp(2) = content.Substring(k3, k4 - k3)
        Point(0) = New clsPoint3(sp(0))
        Point(1) = New clsPoint3(sp(1))
        Point(2) = New clsPoint3(sp(2))
    End Sub
    Public Sub New(p() As clsPoint3)
        Point(0) = p(0) : Point(1) = p(1) : Point(2) = p(2)
    End Sub

    Overrides Function ToString() As String
        Return Point(0).ToString & vbTab & Point(1).ToString & vbTab & Point(2).ToString
    End Function

End Class
