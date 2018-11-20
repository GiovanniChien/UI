Public Class clsCell
    Public Shared F0 As Single  ' 每个单元保持不变形的最大受力F0(静态阻力)
    ' 每个单元是均质的，压扁系数k1是一样的；
    ' 每个单元的压扁量dw   （压扁量与力量、原始尺寸成正比）
    ' if  F>f0  then dw=k1*(F-F0)*wx  else dw=0  endif 
    ' 每个单元变形后的尺寸w=w-dw; 
    Public Shared k1 As Single
    ' 传递给Next单元的力的衰减系数k2；
    ' F = F - dw * k2 = F- k1*(F-F0)*wx* k2
    ' k2越大，传给Next单元的力就越小（k2是材料的抵抗性能）
    Public Shared k2 As Single

    Public cp As PointF      ' 中心点坐标
    Public wx, wy As Single  ' 宽度
    Public [Next] As clsCell  ' 受力直接传导的单元
    Public [Adjs] As List(Of clsCell)   ' 受力相邻传导的单元

    Public Sub New(ByVal x As Single, ByVal y As Single, ByVal wx As Single, ByVal wy As Single)
        Me.cp = New PointF(x, y) : Me.wx = wx : Me.wy = wy
        [Next] = Nothing
        [Adjs] = New List(Of clsCell)
    End Sub
    Public Sub SetNext(ByVal [Next] As clsCell)
        Me.Next = [Next]
    End Sub
    Public Sub Draw(ByVal g As Graphics, ByVal color As Color)
        g.DrawEllipse(New Pen(color), (cp.X - wx / 2) * 1, (cp.Y - wy / 2) * 1, wx * 1, wy * 1)
    End Sub

    ' 仅仅是X方向的压扁，F被衰减了
    Public Function Flatten(ByRef F As Single) As Single
        Dim dw As Single
        If F > F0 Then
            dw = k1 * (F - F0) * wx
            If dw > wx Then
                dw = wx      '压扁为一条线
            End If
            cp.X -= dw / 2 : wx -= dw
        Else
            dw = 0
        End If
        F = F - dw * k2
        Return dw
    End Function
    ' 仅仅是X方向的位移
    Public Sub Move(ByVal dw As Single)
        cp.X += dw
    End Sub
End Class
