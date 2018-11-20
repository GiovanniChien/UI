Public Class ClsNumMatrix
    Private numMatrix(8, 8) As Integer
    Private waitSolveMatrix(8, 8) As Integer
    Private boolMatrix(8, 8) As Boolean
    Private hard As Integer
    Private eachRow(8) As Integer

    Public ReadOnly Property GetWaitSolveMatrix(i As Integer, j As Integer) As Integer
        Get
            Return waitSolveMatrix(i, j)
        End Get
    End Property

    Public Sub New(hard As Integer)
        Me.hard = hard
        '用现有数独初始化数独矩阵
        numMatrix = {{8, 7, 4, 6, 3, 1, 5, 9, 2},
                     {5, 9, 6, 7, 2, 8, 4, 3, 1},
                     {2, 3, 1, 4, 5, 9, 6, 8, 7},
                     {4, 8, 2, 1, 9, 6, 7, 5, 3},
                     {7, 6, 5, 3, 8, 4, 2, 1, 9},
                     {9, 1, 3, 5, 7, 2, 8, 4, 6},
                     {3, 2, 9, 8, 6, 5, 1, 7, 4},
                     {1, 5, 7, 2, 4, 3, 9, 6, 8},
                     {6, 4, 8, 9, 1, 7, 3, 2, 5}}
        '通过变换生成随机的数独矩阵
        CreateNumMatrix()
        '根据难度随机生成数独
        CreateBoolMatrix()
    End Sub

    Private Sub CreateBoolMatrix()
        Dim numOfAns As Integer
        Do
            For i = 0 To 8
                For j = 0 To 8
                    boolMatrix(i, j) = False
                Next
            Next
            If hard = 0 Then
                SayEasyWay()
            ElseIf hard = 1 Then
                SayMediumWay()
            ElseIf hard = 2 Then
                SayHardWay()
            End If
            '根据每行需要显示的数字个数生成最终的数独地图
            GenerateMap()
            CreateWaitMatrix()
            Dim solveSudoku As ClsSolveSoduku = New ClsSolveSoduku(waitSolveMatrix)
            solveSudoku.SolveMatrix(0, 0)
            numOfAns = solveSudoku.GetNumOfAns
        Loop While numOfAns <> 1
    End Sub

    Private Sub CreateWaitMatrix()
        For i = 0 To 8
            For j = 0 To 8
                If boolMatrix(i, j) Then
                    waitSolveMatrix(i, j) = numMatrix(i, j)
                Else
                    waitSolveMatrix(i, j) = 0
                End If
            Next
        Next
    End Sub

    Private Sub GenerateMap()
        '简单、中等和困难难度按每行需要显示的数字个数随机生成
        For i = 0 To 8
            CreateMapRow(i)
        Next
    End Sub

    Private Sub CreateMapRow(i As Integer)
        Randomize()
        Dim k As Integer = 0
        While k < eachRow(i)
            Dim n As Integer = Fix(Rnd() * 9)
            If boolMatrix(i, n) = False Then
                boolMatrix(i, n) = True
                k += 1
            End If
        End While
    End Sub

    Private Sub SayEasyWay()
        '显示36-39个数
        Randomize()
        '0行、3行、6行显示4-6个数，共12-18个数
        eachRow(0) = Fix(Rnd() * 3 + 4) : eachRow(3) = eachRow(0) : eachRow(6) = eachRow(0)
        '1行、7行显示3-4个数，共6-8个数，加上之前共20-26个数
        eachRow(1) = Fix(Rnd() * 2 + 3) : eachRow(7) = eachRow(1)
        '确保此8行输出33个数
        eachRow(2) = Fix((33 - (3 * eachRow(0) + 2 * eachRow(1))) / 3) : eachRow(5) = eachRow(2) : eachRow(8) = eachRow(2)
        '最后一行显示3-6个数，则共显示37-39个数
        eachRow(4) = Fix(Rnd() * 4 + 3)
    End Sub
    Private Sub SayMediumWay()
        '显示30-33个数
        Randomize()
        '0行、3行、6行显示3-5个数，共9-15个数
        eachRow(0) = Fix(Rnd() * 3 + 3) : eachRow(3) = eachRow(0) : eachRow(6) = eachRow(0)
        '1行、7行显示2-3个数，共4-6个数，加上之前共13-21个数
        eachRow(1) = Fix(Rnd() * 2 + 2) : eachRow(7) = eachRow(1)
        '确保此8行输出28个数
        eachRow(2) = Fix((28 - (3 * eachRow(0) + 2 * eachRow(1))) / 3) : eachRow(5) = eachRow(2) : eachRow(8) = eachRow(2)
        '最后一行显示2-5个数，则共显示30-33个数
        eachRow(4) = Fix(Rnd() * 4 + 2)
    End Sub
    Private Sub SayHardWay()
        '显示29-31个数
        Randomize()
        '0行、8行显示3-5个数，要求0行+1行=7行+8行=7，则共14个数
        eachRow(0) = Fix(Rnd() * 3 + 3) : eachRow(8) = eachRow(0) : eachRow(1) = 7 - eachRow(0) ： eachRow(7) = eachRow(1)
        '2行、6行显示2-3个数，要求2行+3行=5行+6行=7，则共14个数，加上之前共28个数
        eachRow(2) = Fix(Rnd() * 2 + 2) : eachRow(6) = eachRow(2) : eachRow(3) = 7 - eachRow(2) ： eachRow(5) = eachRow(3)
        '最后一行显示1-3个数，则共显示29-31个数
        eachRow(4) = Fix(Rnd() * 3 + 1)
    End Sub

    Private Sub CreateNumMatrix()
        Randomize()
        For i = 0 To 14
            Dim v1 As Integer = Fix(Rnd() * 9 + 1), v2 As Integer = Fix(Rnd() * 9 + 1)
            If (v1 <> v2) Then
                ExchangeNum(v1, v2)
            End If
        Next
        For i = 0 To 9
            Dim r1 As Integer = Fix(Rnd() * 3) * 3 + Fix(Rnd() * 3), r2 As Integer = Fix(Rnd() * 3) * 3 + Fix(Rnd() * 3)
            If r1 <> r2 Then
                SwapRow(r1, r2)
            End If
            Dim c1 As Integer = Fix(Rnd() * 3) * 3 + Fix(Rnd() * 3), c2 As Integer = Fix(Rnd() * 3) * 3 + Fix(Rnd() * 3)
            If c1 <> c2 Then
                SwapCol(c1, c2)
            End If
        Next
        For i = 0 To 4
            Dim r1 As Integer = Fix(Rnd() * 3), r2 As Integer = Fix(Rnd() * 3)
            If r1 <> r2 Then
                SwapThreeRow(r1, r2)
            End If
            Dim c1 As Integer = Fix(Rnd() * 3), c2 As Integer = Fix(Rnd() * 3)
            If c1 <> c2 Then
                SwapThreeCol(c1, c2)
            End If
        Next
    End Sub

    Private Sub SwapThreeCol(c1 As Integer, c2 As Integer)
        For i = 0 To 2
            SwapCol(c1 + i, c2 + i)
        Next
    End Sub

    Private Sub SwapThreeRow(r1 As Integer, r2 As Integer)
        For i = 0 To 2
            SwapRow(r1 + i, r2 + i)
        Next
    End Sub

    Private Sub SwapCol(c1 As Integer, c2 As Integer)
        For i = 0 To 8
            Swap(numMatrix(i, c1), numMatrix(i, c2))
        Next
    End Sub

    Private Sub SwapRow(r1 As Integer, r2 As Integer)
        For j = 0 To 8
            Swap(numMatrix(r1, j), numMatrix(r2, j))
        Next
    End Sub

    Private Sub Swap(v1 As Integer, v2 As Integer)
        Dim tmp As Integer = v1
        v1 = v2
        v2 = tmp
    End Sub

    Private Sub ExchangeNum(v1 As Integer, v2 As Integer)
        For i = 0 To 8
            For j = 0 To 8
                If numMatrix(i, j) = v1 Then
                    numMatrix(i, j) = v2
                ElseIf numMatrix(i, j) = v2 Then
                    numMatrix(i, j) = v1
                End If
            Next
        Next
    End Sub
End Class
