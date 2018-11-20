Public Class clsCornerPoint
    Public CornerPoint As Point
    Public ColGap As Integer = 100  ' 列间距
    Public RowGap As Integer = 50   ' 行间距

    Public Sub New(CornerPoint As Point)
        Me.CornerPoint = CornerPoint
    End Sub

    Public Function GetRight() As clsCornerPoint
        Return New clsCornerPoint(New Point(CornerPoint.X + ColGap, CornerPoint.Y))
    End Function

    Public Function GetBottom() As clsCornerPoint
        Return New clsCornerPoint(New Point(CornerPoint.X, CornerPoint.Y + RowGap))
    End Function
End Class
