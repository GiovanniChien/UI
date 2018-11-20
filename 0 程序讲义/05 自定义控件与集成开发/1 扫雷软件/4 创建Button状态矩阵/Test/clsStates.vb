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
End Class
