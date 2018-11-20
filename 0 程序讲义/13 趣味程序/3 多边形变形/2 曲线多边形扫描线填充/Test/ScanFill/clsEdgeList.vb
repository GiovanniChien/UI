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

    Public Function MaxY() As Integer
        Dim max As Integer = Edges(0).ymax
        For i = 1 To Edges.Count - 1
            If Edges(i).ymax > max Then
                max = Edges(i).ymax
            End If
        Next
        Return max
    End Function

    Function GetXps(ByVal y As Integer) As List(Of Single)
        Dim xs As New List(Of Single)
        For i = 0 To Edges.Count - 1
            xs.AddRange(Edges(i).getX(y))
        Next
        Return xs
    End Function

End Class
