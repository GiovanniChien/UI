Imports System.Math

Public Class clsPolygon2
    Public CommonPen, ActivePen As Pen
    Private Points As List(Of PointF), ActiveIndex As Integer
    Public Node As clsTreeNode
    Private Const BoxWidth As Single = 6   '点的方框6*6像素

    Public Sub Clear()
        Me.Points.Clear() : Me.Node.Nodes.Clear()
        ActiveIndex = -1
    End Sub

    Private Sub Init()
        CommonPen = New Pen(Color.Blue, 1) : ActivePen = New Pen(Color.Red, 1)
        Me.Points = New List(Of PointF)
        Me.Node = New clsTreeNode(Me) : Me.Node.Text = "多边形" : Me.Node.ExpandAll()
        ActiveIndex = -1
    End Sub
    Sub New(Lines As clsLine2s)
        Init()
        For i = 0 To Lines.Points.Count - 3   '总是多2个重复的点
            Me.Points.Add(Lines.Points(i))
            Me.Node.Nodes.Add(Lines.Points(i).X & "," & Lines.Points(i).Y)
        Next
        ActiveIndex = -1
    End Sub

    '计算各条线段的法线向量
    Private Function ComputeNormals(points As List(Of PointF)) As List(Of PointF)
        Dim normals As List(Of PointF) = New List(Of PointF)
        Dim ptsN As Integer = points.Count
        Dim sp, ep, normal As PointF
        For i = 0 To ptsN - 1
            sp = points(i)
            ep = points((i + 1) Mod ptsN)
            normal.X = sp.Y - ep.Y : normal.Y = ep.X - sp.X
            Dim dist As Single = Sqrt(normal.X * normal.X + normal.Y * normal.Y)
            normal.X = normal.X / dist
            normal.Y = normal.Y / dist
            normals.Add(normal)
        Next
        Return normals
    End Function

    '凸出dist距离量
    Public Sub New(polygon As clsPolygon2, dist As Single)
        Init()
        Dim normals As List(Of PointF) = ComputeNormals(polygon.Points)
        Dim ptsN As Integer = polygon.Points.Count
        Dim n1, n2, n, newp As PointF
        For i = 0 To ptsN - 1
            '取相邻法线向量
            n1 = normals((i - 1 + ptsN) Mod ptsN) : n2 = normals(i)
            '计算法线向量，并规范化
            n.X = n1.X + n2.X : n.Y = n1.Y + n2.Y
            Dim d As Single = Sqrt(n.X * n.X + n.Y * n.Y)
            n.X = n.X / d : n.Y = n.Y / d
            '计算新点坐标
            newp.X = polygon.Points(i).X + dist * n.X
            newp.Y = polygon.Points(i).Y + dist * n.Y
            Me.Points.Add(newp)
        Next
    End Sub

    Sub New(fname As String)
        '
    End Sub
    Sub Save(fname As String)
        '
    End Sub

    Public Sub Draw(g As Graphics, CS As clsCS2)
        Dim dps As New List(Of PointF)
        For i = 0 To Points.Count - 1
            dps.Add(CS.Lp2Dp(Points(i)))
            If i = ActiveIndex Then
                g.DrawRectangle(ActivePen, dps(i).X - BoxWidth / 2, dps(i).Y - BoxWidth / 2, BoxWidth, BoxWidth)
            Else
                g.DrawRectangle(CommonPen, dps(i).X - BoxWidth / 2, dps(i).Y - BoxWidth / 2, BoxWidth, BoxWidth)
            End If
        Next
        For i = 0 To Points.Count - 2
            g.DrawLine(CommonPen, dps(i), dps(i + 1))
        Next
        g.DrawLine(CommonPen, dps(dps.Count - 1), dps(0))
    End Sub

    Public Sub SetActive(index As Integer)
        ActiveIndex = index
    End Sub

    Sub Move(dx As Single, dy As Single)
        If ActiveIndex = -1 Then Exit Sub
        Dim p As PointF
        p.X = Points(ActiveIndex).X + dx : p.Y = Points(ActiveIndex).Y + dy
        Points.RemoveAt(ActiveIndex)
        Points.Insert(ActiveIndex, p)
        Node.Nodes(ActiveIndex).Text = Points(ActiveIndex).X & "," & Points(ActiveIndex).Y
    End Sub

    Function SelectPoint(dp As Point, cs As clsCS2) As Boolean
        ActiveIndex = -1
        For i = 0 To Points.Count - 1
            Dim dpi As Point = cs.Lp2Dp(Points(i))
            If Sqrt((dpi.X - dp.X) ^ 2 + (dpi.Y - dp.Y) ^ 2) < BoxWidth Then
                ActiveIndex = i : Return True
            End If
        Next
        Return False
    End Function

End Class
