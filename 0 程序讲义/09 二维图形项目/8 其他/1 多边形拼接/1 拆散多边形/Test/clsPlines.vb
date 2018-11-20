Public Class clsPlines
    Private plines As List(Of clsPline)
    Private OldCp As List(Of PointF)
    Private Cp As List(Of PointF)
    Private ActiveID As Integer  '当前操作的多段线的下标

    Public Sub New(Polygon As clsPline, k As Integer)
        plines = Polygon.Divide(k)
        'OldCp=...
        '爆炸位移
    End Sub

    Public Sub [Select](p As PointF)  '点选

    End Sub
    Public Sub [Select](p1 As PointF, p2 As PointF)  '窗口选

    End Sub

    Public Sub Move(dx As Single, dy As Single) '对当前多段线进行位移

    End Sub
    Public Function Success() As Boolean  '判断图形是否已经完全对齐
        '  OldCp=Cp
    End Function

End Class
