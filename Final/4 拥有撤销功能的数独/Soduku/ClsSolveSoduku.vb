Public Class ClsSolveSoduku
    '表示数独某格是否是0，及是否待求解
    Private isZero(8, 8) As Boolean
    'isUsed(0,i,j)表示在i行是否已经存在数字j+1，isUsed(1,i,j)表示在i列是否已经存在数字j，isUsed(2,i,j)表示在第i个九宫格是否已经存在数字j
    Private isUsed(2, 8, 8) As Boolean
    '初始待求解数独
    Private waitSolvedMatrix(8, 8) As Integer
    Private numOfAns As Integer

    Public ReadOnly Property GetNumOfAns As Integer
        Get
            Return numOfAns
        End Get
    End Property

    Public Sub New(waitSolvedMatrix(,) As Integer)
        numOfAns = 0
        For i = 0 To 8
            For j = 0 To 8
                isZero(i, j) = False
            Next
        Next
        For k = 0 To 2
            For i = 0 To 8
                For j = 0 To 8
                    isUsed(k, i, j) = False
                Next
            Next
        Next
        For i = 0 To 8
            For j = 0 To 8
                Me.waitSolvedMatrix(i, j) = waitSolvedMatrix(i, j)
                If waitSolvedMatrix(i, j) = 0 Then
                    isZero(i, j) = True
                Else
                    ChangeIsUsed(i, j, True)
                End If
            Next
        Next
    End Sub

    Private Sub ChangeIsUsed(i As Integer, j As Integer, flag As Boolean)
        Dim index As Integer = 3 * (Fix(i / 3)) + Fix(j / 3)
        Dim value As Integer = waitSolvedMatrix(i, j) - 1
        isUsed(0, i, value) = flag
        isUsed(1, j, value) = flag
        isUsed(2, index, value) = flag
    End Sub

    Public Sub SolveMatrix(rowIndex As Integer, colIndex As Integer)
        If colIndex = 9 Then rowIndex += 1 : colIndex = 0
        While rowIndex < 9
            If isZero(rowIndex, colIndex) Then
                Exit While
            End If
            colIndex += 1
            If colIndex = 9 Then
                rowIndex += 1
                colIndex = 0
            End If
        End While
        If rowIndex > 8 Then
            numOfAns += 1
            Return
        End If
        waitSolvedMatrix(rowIndex, colIndex) = FindNextValue(rowIndex, colIndex, waitSolvedMatrix(rowIndex, colIndex))
        While waitSolvedMatrix(rowIndex, colIndex) <> 0
            ChangeIsUsed(rowIndex, colIndex, True)
            SolveMatrix(rowIndex, colIndex + 1)
            ChangeIsUsed(rowIndex, colIndex, False)
            waitSolvedMatrix(rowIndex, colIndex) = FindNextValue(rowIndex, colIndex, waitSolvedMatrix(rowIndex, colIndex))
        End While
    End Sub

    Private Function FindNextValue(rowIndex As Integer, colIndex As Integer, start As Integer) As Integer
        Dim index As Integer = 3 * (Fix(rowIndex / 3)) + Fix(colIndex / 3)
        For i = start To 8
            If isUsed(0, rowIndex, i) Then Continue For
            If isUsed(1, colIndex, i) Then Continue For
            If isUsed(2, index, i) Then Continue For
            Return i + 1
        Next
        Return 0
    End Function

End Class
