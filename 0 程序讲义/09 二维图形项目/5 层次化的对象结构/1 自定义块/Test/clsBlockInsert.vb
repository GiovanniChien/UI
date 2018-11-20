Imports System.Drawing

Public Class clsBlockInsert
    Inherits clsElem

    Private Block As clsBlock
    Private M As clsMatrix3  ' 对Block中所有图形对象的变换矩阵

    Public Sub New(ByVal Block As clsBlock, ByVal InsertPoint As PointF, ByVal scaleX As Single, ByVal scaleY As Single, ByVal angle As Single)
        ' 先缩放,再旋转,再平移
        Me.Block = Block
        Dim basepoint As PointF = Block.GetBasePoint()
        Dim offsetx As Single = InsertPoint.X - basepoint.X, offsety As Single = InsertPoint.Y - basepoint.Y
        Me.M = New clsMatrix3
        M.SetPan(offsetx, offsety)
    End Sub
    Public Sub New(ByVal Block As clsBlock, ByVal M As clsMatrix3)
        Me.Block = Block
        Me.M = M.Clone
    End Sub
    Public Overrides Function Clone() As clsElem
        Return New clsBlockInsert(Block, M)
    End Function

    Public Overrides Function ToString() As String
        Dim s As String = "BlockInsert: FirstBlock "
        s = s & M.ToString
        Return s
    End Function

    Public Overrides Sub Draw(ByVal g As Graphics, Optional ByVal isSelectElem As Boolean = False)
        For i = 0 To Block.Count - 1
            Block.Item(i).Draw(g, M, isSelectElem)
        Next
    End Sub
    Public Overloads Overrides Sub Draw(ByVal g As Graphics, ByVal M As clsMatrix3, Optional ByVal isSelectElem As Boolean = False)
        For i = 0 To Block.Count - 1
            Block.Item(i).Draw(g, M, isSelectElem)
        Next
    End Sub

    Public Overrides Function SelectByPoint(ByVal p As PointF) As Boolean
        Dim InvertM As clsMatrix3 = M.Invert()
        ' p点与插入块对象的关系 等价于 q点与块对象的关系
        Dim q As PointF = InvertM.Tranform(p)
        For i = 0 To Block.Count - 1
            If Block.Item(i).SelectByPoint(q) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Overrides Sub Transform(ByVal m As clsMatrix3)
        Me.M.Mul(m)
    End Sub

End Class
