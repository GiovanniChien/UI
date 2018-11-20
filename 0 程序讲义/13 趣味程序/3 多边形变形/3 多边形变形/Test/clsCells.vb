' 假设某盒子受力为F，
' 1 保持不变形的最大受力F0(静态阻力)；
' 2 压扁系数k1是一样的； dw=k1*(F-F0)*wx;  w=w-dw; 变形尺寸与力量、原始尺寸成正比
' 3 传递给相邻盒子的力的传递系数k2； F = F - dw * k2
'                              k2越大，传递的力就越小（k2是材料的抵抗力）

Public Class clsCells
    Private Cells As List(Of clsCell)
    Private RightIDs As List(Of Integer)   '每行最右侧的单元的下标的集合，用于施加受力

    Public Sub Force(ByVal F As Single)
        For i = 0 To RightIDs.Count - 1
            Force(RightIDs(i), F)
        Next
    End Sub
    Public Sub Force(ByVal k As Integer, ByVal F As Single)
        Dim cell As clsCell = Cells(k)
        Dim dws As New Queue(Of Single) ' 从cell开始受力已知到边界单元的压扁量
        While cell IsNot Nothing
            Dim dw As Single = cell.Flatten(F)
            dws.Enqueue(-dw)
            cell = cell.Next
        End While
        cell = Cells(k)
        dws.Dequeue()
        While cell.Next IsNot Nothing
            Dim dw As Single = dws.Sum()
            If dws.Count = 0 Then Exit While
            cell.Move(dw)
            dws.Dequeue()
            cell = cell.Next
        End While
    End Sub

    Public Sub New(ByVal polygon As clsPolygon, ByVal dw As Single)
        Dim nextcell, cell As clsCell
        Dim nextx, x As Single   ' 上一个单元的x值，当前单元的x值
        Cells = New List(Of clsCell) : RightIDs = New List(Of Integer)
        Dim points As SortedList(Of Integer, List(Of Integer)) = polygon.GetInPoints()
        For y = points.Keys.Min To points.Keys.Max
            If points(y).Count = 0 Then Continue For
            nextx = points(y)(0) - 2 * dw : nextcell = Nothing
            ' points(y)中的x值一定是增序
            For i = 0 To points(y).Count - 1
                x = points(y)(i)
                cell = New clsCell(x, y, dw, dw)
                If x - dw = nextx Then
                    cell.Next = nextcell
                Else
                    cell.Next = Nothing
                End If
                Cells.Add(cell)
                nextcell = cell : nextx = x
            Next
            RightIDs.Add(Cells.Count - 1)
        Next
        SetAdjs()
    End Sub
    Private Function SearchCell(ByVal cp As PointF) As Integer
        For i = 0 To Cells.Count - 1
            If Cells(i).cp.X = cp.X And Cells(i).cp.Y = cp.Y Then Return i
        Next
        Return -1
    End Function


    Private Sub SetAdjs()
        For i = 0 To Cells.Count - 1
            Dim cp1 As PointF = New PointF(Cells(i).cp.X, Cells(i).cp.Y - 1)
            Dim cp2 As PointF = New PointF(Cells(i).cp.X, Cells(i).cp.Y + 1)
            Dim k1 As Integer = SearchCell(cp1)
            If k1 <> -1 Then Cells(i).Adjs.Add(Cells(k1))
            Dim k2 As Integer = SearchCell(cp2)
            If k2 <> -1 Then Cells(i).Adjs.Add(Cells(k2))
        Next
    End Sub

    Public Sub Draw(ByVal buffer As Bitmap, ByVal color As Color)
        Dim g As Graphics = Graphics.FromImage(buffer)
        Dim Pen As Pen = New Pen(color)
        For i = 0 To Cells.Count - 1
            Cells(i).Draw(g, color)
        Next
    End Sub

    Sub Remove()
        Cells.RemoveRange(19, 52 - 18)
        Cells.RemoveRange(0, 11)
    End Sub




End Class
