Public Class clsStates
    Private States As List(Of Boolean)
    Private RowN As Integer, ColN As Integer, MineN As Integer

    Public Sub New(RowN As Integer, ColN As Integer, MineN As Integer)
        Me.RowN = RowN : Me.ColN = ColN : Me.MineN = MineN
        Me.States = New List(Of Boolean)(RowN * ColN)
        For i = 0 To RowN * ColN - 1
            Me.States.Add(False)
        Next
        For i = 0 To MineN - 1
            Dim k As Integer = Fix(Rnd() * RowN * ColN)
            If Me.States(k) = False Then
                Me.States(k) = True
            Else
                i = i - 1
            End If
        Next
    End Sub

    ' 计算State(i,j)周围8个单元中雷的数量
    Public Function GetMineCount(i As Integer, j As Integer) As Integer
        Dim Count As Integer = 0
        If isMine(i - 1, j - 1) Then Count += 1
        If isMine(i - 1, j) Then Count += 1
        If isMine(i - 1, j + 1) Then Count += 1
        If isMine(i, j - 1) Then Count += 1
        If isMine(i, j + 1) Then Count += 1
        If isMine(i + 1, j - 1) Then Count += 1
        If isMine(i + 1, j) Then Count += 1
        If isMine(i + 1, j + 1) Then Count += 1
        Return Count
    End Function

    ' 判断State(i,j)是否是雷
    Public Function isMine(i As Integer, j As Integer) As Boolean
        Dim k As Integer
        k = i * ColN + j
        If i < 0 Or i >= RowN Then Return False ' 行越界
        If j < 0 Or j >= ColN Then Return False ' 列越界
        Return States(k)
    End Function

    ' 设(i,j)无雷，计算包含(i,j)在内的无雷区
    Public Function BFS(i As Integer, j As Integer) As List(Of Point)
        Dim points As New List(Of Point)
        Dim visited(RowN - 1, ColN - 1) As Boolean  '访问标记数组，默认为False
        Dim Q As New Queue(Of Point)
        Q.Enqueue(New Point(i, j)) : visited(i, j) = True
        While Q.Count > 0
            Dim p As Point = Q.Dequeue() : points.Add(p)
            i = p.X : j = p.Y
            If j - 1 >= 0 Then
                If isMine(i, j - 1) = False And visited(i, j - 1) = False Then Q.Enqueue(New Point(i, j - 1)) : visited(i, j - 1) = True
            End If
            If j + 1 < ColN Then
                If isMine(i, j + 1) = False And visited(i, j + 1) = False Then Q.Enqueue(New Point(i, j + 1)) : visited(i, j + 1) = True
            End If
            If i - 1 >= 0 Then
                If isMine(i - 1, j) = False And visited(i - 1, j) = False Then Q.Enqueue(New Point(i - 1, j)) : visited(i - 1, j) = True
            End If
            If i + 1 < RowN Then
                If isMine(i + 1, j) = False And visited(i + 1, j) = False Then Q.Enqueue(New Point(i + 1, j)) : visited(i + 1, j) = True
            End If
        End While
        Return points
    End Function

End Class
