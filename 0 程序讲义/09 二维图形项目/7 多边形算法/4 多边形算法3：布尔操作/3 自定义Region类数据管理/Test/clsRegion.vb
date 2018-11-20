Public Class clsRegion
    Private points As List(Of PointF), path As Drawing2D.GraphicsPath
    Private region As Region
    Private _Selected As Boolean
    Public node As clsTreeNode

    Private Sub Init()
        path = New Drawing2D.GraphicsPath
        For i = 0 To points.Count - 2
            path.AddLine(points(i), points(i + 1))
        Next
        path.AddLine(points(points.Count - 1), points(0))
        region = New Region(path)
        _Selected = False
        node = New clsTreeNode(Me)
        UpdateNode()
    End Sub

    Private Sub UpdateNode()
        node.Text = "Polygon"
        With node.Nodes
            .Clear()
            Dim Node0 As TreeNode = .Add("端点表")
            For i = 0 To points.Count - 1
                Node0.Nodes.Add(points(i).X & "," & points(i).Y)
            Next
            Dim Node1 As TreeNode = .Add("包围盒")
            For i = 0 To points.Count - 1
                Node1.Nodes.Add(points(i).X & "," & points(i).Y)
            Next
        End With
    End Sub

    Public Sub New(points As List(Of PointF))
        Me.points = New List(Of PointF)(points) : Init()
    End Sub
    Public Sub New(r As clsRegion)
        Me.points = New List(Of PointF)(r.points) : Init()
    End Sub
    Function Clone() As clsRegion
        Return New clsRegion(Me)
    End Function

    Sub Draw(g As Graphics)
        g.FillRegion(Brushes.Blue, region)
        If _Selected = True Then
            g.DrawPath(Pens.Red, path)
        Else
            g.DrawPath(Pens.Black, path)
        End If
    End Sub
    Sub Op(r As clsRegion, kind As RegionOp)
        Select Case kind
            Case RegionOp.Intersect
                Me.region.Intersect(r.region)
            Case RegionOp.Union
                Me.region.Union(r.region)
            Case RegionOp.Xor
                Me.region.Xor(r.region)
        End Select
        '!!!!! UpdatePoints()
    End Sub
    Sub [In](p As PointF)
        If region.IsVisible(p) = True Then
            _Selected = Not _Selected
            node.Active = _Selected
        End If
    End Sub
    Public Property Selected As Boolean
        Set(value As Boolean)
            _Selected = value
            node.Active = _Selected
        End Set
        Get
            Return _Selected
        End Get
    End Property


End Class
