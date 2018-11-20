Public Class clsEdge
    Public Hermite As clsHermite
    Public ymin, ymax As Integer

    Public Sub New(ByVal p1 As Point, ByVal p2 As Point, ByVal p3 As Point)
        Hermite = New clsHermite(p1, p2, p3)
        Hermite.GetYminmax(ymin, ymax)
    End Sub

    Function getX(ByVal y As Single) As List(Of Single)
        Dim ts As List(Of Single) = Hermite.GetT(y)
        Dim xs As New List(Of Single)
        For i = 0 To ts.Count - 1
            xs.Add(Hermite.GetPoint(ts(i)).X)
        Next
        Return (xs)
    End Function

End Class
