Imports System.Math

Public Class clsPolygon
    Private Points As List(Of PointF)   ' 点的序列（边的序列）
    Private EdgeNormals As List(Of PointF)   ' 边的法线向量的序列
    Private PointNormals As List(Of PointF)  ' 点的法线向量的序列
    Private Color As Color              ' 用颜色表示材料

    Public Sub New(color As Color, points As List(Of PointF))
        Me.color = color
        Me.Points = points
        ComputeNormals()
    End Sub
    Public Sub New(color As Color)
        Me.color = color
        Points = New List(Of PointF)
    End Sub

    '计算所有的法线向量
    Private Sub ComputeNormals()
        '计算返回所有边的法线向量
        EdgeNormals = New List(Of PointF)
        Dim sp, ep, normal As PointF
        For i = 0 To Points.Count - 1
            sp = Points(i)                        '边的起点
            ep = Points((i + 1) Mod Points.Count) '边的终点
            '直线方程的ax+by+c=0     a=sp.Y-ep.Y   b=ep.X-sp.X
            normal.X = sp.Y - ep.Y : normal.Y = ep.X - sp.X
            ' 规格化法线向量
            Dim d As Single = Sqrt(normal.X * normal.X + normal.Y * normal.Y)
            normal.X = normal.X / d : normal.Y = normal.Y / d
            EdgeNormals.Add(normal)
        Next
        '计算返回所有顶点的法线向量
        PointNormals = New List(Of PointF)
        Dim n1, n2, n As PointF
        For i = 0 To Points.Count - 1
            '取相邻法线向量
            n1 = EdgeNormals((i - 1 + Points.Count) Mod Points.Count) : n2 = EdgeNormals(i)
            '计算法线向量，并规范化
            n.X = n1.X + n2.X : n.Y = n1.Y + n2.Y
            Dim d As Single = Sqrt(n.X * n.X + n.Y * n.Y)
            n.X = n.X / d : n.Y = n.Y / d
            PointNormals.Add(n)
        Next
    End Sub

    Public Sub Draw(g As Graphics)
        Dim pen As Pen = New Pen(Color)
        For i = 0 To Points.Count - 2
            g.DrawLine(pen, Points(i), Points(i + 1))
        Next
        g.DrawLine(pen, Points(Points.Count - 1), Points(0))
    End Sub

    Public Function Expand(delta As Single, newcolor As Color) As clsPolygon
        Dim polygon As clsPolygon = New clsPolygon(newcolor) ' 建立一个顶点表为空的多边形
        Dim newp As PointF
        For i = 0 To Points.Count - 1
            '计算新点坐标
            newp.X = Points(i).X + delta * PointNormals(i).X
            newp.Y = Points(i).Y + delta * PointNormals(i).Y
            polygon.Points.Add(newp)
        Next
        polygon.ComputeNormals()
        Return polygon
    End Function



End Class
