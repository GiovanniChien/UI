Public Class clsLine2s
    Public myPen As Pen
    Public Points As List(Of PointF)
    Public Node As clsTreeNode

    Private Sub Init()
        myPen = New Pen(Color.Red, 1)
        Me.Points = New List(Of PointF)
        Me.Node = New clsTreeNode(Me) : Me.Node.Text = "多段线" : Me.Node.ExpandAll()
    End Sub
    Public Sub New(points As List(Of PointF))
        Init()
        For i = 0 To points.Count - 1
            Me.Points.Add(points(i))
            Me.Node.Nodes.Add(points(i).X & "," & points(i).Y)
        Next
    End Sub
    Public Sub Clear()
        Me.Points.Clear()
        Me.Node.Nodes.Clear()
    End Sub
    Public Sub New()
        Init()
    End Sub
    Public Sub Append(point As PointF)
        Me.Points.Add(point)
        Me.Node.Nodes.Add(point.X & "," & point.Y)
        Me.Node.ExpandAll()
    End Sub
    Public Sub Draw(g As Graphics, CS As clsCS2)
        If Points.Count < 2 Then Exit Sub
        Dim line As clsLine2
        For i = 0 To Points.Count - 2
            line = New clsLine2(CS.Lp2Dp(Points(i)), CS.Lp2Dp(Points(i + 1)))
            line.Draw(g, myPen)
        Next
    End Sub


End Class
