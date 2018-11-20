Imports System.Math

Public Class clsBorder
    Private Points As List(Of Point)  '点集合

    Public Sub New()
        Points = New List(Of Point)
    End Sub

    Public Sub Add(p As Point)
        Points.Add(p)
    End Sub

    Public Function PointCount() As Integer
        Return Points.Count
    End Function

    Public Sub Draw(Buff As Bitmap, Mark As Color)
        For i = 0 To Points.Count - 1
            Buff.SetPixel(Points(i).X, Points(i).Y, Mark)
        Next
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = ""
        For i = 0 To Points.Count - 1
            s = s & Points(i).X & "," & Points(i).Y & vbTab
        Next
        Return s
    End Function

    Public Function GetOrderPointSets() As clsOrderPointSets
        Dim OrderPointSets As clsOrderPointSets = New clsOrderPointSets  '点序列的集合
        '初始化RestPoints
        Dim RestPoints As List(Of Point) = New List(Of Point) ' 剩余的点集合
        For i = 0 To Points.Count - 1
            RestPoints.Add(New Point(Points(i)))
        Next
        ' 可能从RestPoints中，提取多个点序列对象
        While RestPoints.Count > 0
            OrderPointSets.Add(GetOrderPointSet(RestPoints))
        End While
        Return OrderPointSets
    End Function
    Private Function GetOrderPointSet(Points As List(Of Point)) As clsOrderPointSet
        Dim OrderPointSet As New clsOrderPointSet
        Dim p As Point = Points(0)   '点序列的起点
        OrderPointSet.Add(p) : Points.Remove(p)
        While Points.Count > 0
            ' 查找points中与p最近的点的下标k
            Dim k As Integer = FindNearest(Points, p)
            If k = -1 Then Exit While ' 没有连续的点
            p = Points(k)
            OrderPointSet.Add(p) : Points.Remove(p)  ' 新的当前点加入序列
        End While
        Return OrderPointSet
    End Function

    Private Function FindNearest(points As List(Of Point), p As Point) As Integer
        ' 采用棋盘距离
        ' 查找points中与p最近的点的下标imin
        Dim dmin As Integer = Abs(points(0).X - p.X) + Abs(points(0).Y - p.Y)
        Dim imin As Integer = 0
        For i = 1 To points.Count - 1
            Dim d As Integer = Abs(points(i).X - p.X) + Abs(points(i).Y - p.Y)
            If d < dmin Then
                dmin = d : imin = i
            End If
        Next
        If dmin <= 2 Then
            Return imin
        Else
            Return -1     '找不到连续的点
        End If
    End Function

End Class
