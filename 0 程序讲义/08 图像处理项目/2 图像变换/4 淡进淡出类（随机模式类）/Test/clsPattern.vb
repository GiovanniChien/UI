Public Class clsPattern
    Private N, M() As Integer ' M的存储结构是一维数组，逻辑结构是二维数组
    ' M()存储0...N*N-1之间的随机数列
    Public Sub New(N As Integer)
        Randomize()
        Me.N = N
        ReDim Me.M(N * N - 1)
        For k = 0 To N * N - 1
            Me.M(k) = k
        Next
        '随机交换Count次
        Dim Count As Integer = Rnd() * N * N / 2
        Dim i, j, tmp As Integer
        For k = 0 To Count - 1
            i = Fix(Rnd() * N * N)
            j = Fix(Rnd() * N * N)
            tmp = M(i) : M(i) = M(j) : M(j) = tmp
        Next
    End Sub

    Public Function GetValue(k As Integer) As Integer
        Return M(k)
    End Function
End Class
