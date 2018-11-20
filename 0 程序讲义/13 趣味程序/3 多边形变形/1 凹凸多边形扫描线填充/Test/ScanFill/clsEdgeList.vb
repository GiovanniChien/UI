Public Class clsEdgeList
    Private Edges As List(Of clsEdge)

    Public Sub New()
        Edges = New List(Of clsEdge)
    End Sub
    Public Sub Append(ByVal e As clsEdge)
        Edges.Add(e)
    End Sub
    Public Sub Append(ByVal EdgeList As clsEdgeList)
        Edges.AddRange(EdgeList.Edges)
    End Sub
    Public Function Count() As Integer
        Return Edges.Count
    End Function

    Private Function Cell(ByVal x As Single) As Integer
        Dim y As Integer = Fix(x)
        If x > y Then
            Return y + 1
        Else
            Return y
        End If
    End Function
    ' 返回结点之间的x值序列
    Public Function GetPixels() As List(Of Integer)
        Dim xs As New List(Of Integer)
        For i = 0 To Edges.Count - 2 Step 2
            Dim x1 As Integer = Int(Edges(i).x + 1)        ' 忽略左边界点 x:5=>x1:6   x:5.1=>x1:6  x:5.9=>x1:6
            Dim x2 As Integer = Cell(Edges(i + 1).x) - 1
            ' 忽略右边界点 x:5=>x2:4   x:5.1=>x1:5  x:5.9=>x1:5
            For x = x1 To x2
                xs.Add(x)
            Next
        Next
        Return xs
    End Function
    ' 计算下一条扫描线与边结点的交点
    Public Sub NextY()
        For i = 0 To Edges.Count - 1
            Edges(i).x += Edges(i).dx
        Next
    End Sub
    ' 清除无效的边结点
    Public Sub Purge(ByVal y As Integer)
        Dim es As New List(Of clsEdge)
        For Each e In Edges
            If y >= e.ymax Then
                es.Add(e)
            End If
        Next
        For i = 0 To es.Count - 1
            Edges.Remove(es(i))
        Next
    End Sub
    ' 按clsEdge中的X排序
    Public Sub Sort()
        Edges.Sort(AddressOf CompareX)
    End Sub
    Private Shared Function CompareX(ByVal e1 As clsEdge, ByVal e2 As clsEdge) As Integer
        If e1.x < e2.x Then Return -1
        If e1.x > e2.x Then Return 1
        Return 0
    End Function

    Public Function MaxY() As Integer
        Dim max As Integer = Edges(0).ymax
        For i = 1 To Edges.Count - 1
            If Edges(i).ymax > max Then
                max = Edges(i).ymax
            End If
        Next
        Return max
    End Function

End Class
