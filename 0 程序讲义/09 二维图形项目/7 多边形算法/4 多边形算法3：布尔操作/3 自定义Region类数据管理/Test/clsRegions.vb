Public Enum RegionOp
    [Union]
    [Intersect]
    [Xor]
End Enum

Public Class clsRegions
    Private rs As List(Of clsRegion)
    Public node As clsTreeNode

    Public Sub New()
        rs = New List(Of clsRegion)
        node = New clsTreeNode(Me)
    End Sub
    Private Sub UpdateNode()
        With node.Nodes
            .Clear()
            For i = 0 To rs.Count - 1
                .Add(rs(i).node)
            Next
        End With
    End Sub

    Public Sub Append(points As List(Of PointF))
        rs.Add(New clsRegion(points))
        UpdateNode()
    End Sub
    Public Sub Append(region As clsRegion)
        rs.Add(region)
        UpdateNode()
    End Sub
    Public Sub Draw(g As Graphics)
        For i = 0 To rs.Count - 1
            rs(i).Draw(g)
        Next
    End Sub

    Public Sub [Select](p As PointF)
        For i = 0 To rs.Count - 1
            rs(i).In(p)
        Next
    End Sub
    Public Sub [Select](index As Integer)
        rs(index).Selected = Not rs(index).Selected
    End Sub

    Public Sub Fill(lstRegion As ListBox)
        lstRegion.Items.Clear()
        For i = 0 To rs.Count - 1
            lstRegion.Items.Add(i)
        Next
    End Sub

    Public Sub Op(opkind As RegionOp)
        Dim r1 As clsRegion = rs(0)
        Dim r2 As clsRegion = rs(1)
        Dim r3 As clsRegion = r1.Clone
        Append(r3)
        r3.Op(r2, opkind)
    End Sub

End Class
