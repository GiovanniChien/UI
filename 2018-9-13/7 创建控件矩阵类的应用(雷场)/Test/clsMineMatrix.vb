Imports System.Math

Public Class clsMineMatrix
    Private num As Integer
    Private row As Integer, col As Integer
    Private mineMatrix(,) As Boolean
    Public Sub New(ByVal row As Integer, ByVal col As Integer, ByVal num As Integer)
        Me.row = row
        Me.col = col
        Me.num = num
        ReDim mineMatrix(row - 1, col - 1)
        For i = 0 To row - 1
            For j = 0 To col - 1
                mineMatrix(i, j) = False
            Next
        Next
        Dim k As Integer
        While k < num
            Randomize()
            Dim rand As Integer = Fix(Rnd() * row * col)
            Dim i As Integer = Fix(rand / col)
            Dim j As Integer = rand Mod col
            If mineMatrix(i, j) = False Then
                mineMatrix(i, j) = True
                k += 1
            End If
        End While
    End Sub
    Public Function IsMine(ByVal i As Integer, ByVal j As Integer) As Integer
        If mineMatrix(i, j) Then Return -1
        Dim mineCnt As Integer = 0
        For dx = -1 To 1
            For dy = -1 To 1
                If i + dx >= 0 And i + dx < row And j + dy >= 0 And j + dy < col Then
                    If mineMatrix(i + dx, j + dy) Then
                        mineCnt += 1
                    End If
                End If
            Next
        Next
        Return mineCnt
    End Function
End Class
