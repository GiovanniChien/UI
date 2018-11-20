Public Enum RegionOp
    [Union]
    [Intersect]
    [Xor]
End Enum

Public Class clsRegions
    Private rs As List(Of clsRegion)

    Public Sub New()
        rs = New List(Of clsRegion)
    End Sub
    Public Sub Append(points As List(Of PointF))
        rs.Add(New clsRegion(points))
    End Sub
    Public Sub Draw(g As Graphics)
        For i = 0 To rs.Count - 1
            rs(i).Draw(g)
        Next
    End Sub

    Public Sub DoSelect(ByVal p As PointF)
        For i = 0 To rs.Count - 1
            rs(i).SelectbyPoint(p)
        Next
    End Sub
    Public Sub DoSelect(ByVal index As Integer)
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
        r3.Op(r2, opkind)
        rs.Add(r3)
    End Sub

End Class
