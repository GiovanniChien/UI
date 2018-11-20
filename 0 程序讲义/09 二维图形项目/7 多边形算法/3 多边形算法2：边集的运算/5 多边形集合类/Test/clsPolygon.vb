Imports System.Math

Public Class clsPolygon
    Private Points As List(Of PointF)   ' 点的序列（边的序列）
    Private EdgeNormals As List(Of PointF)   ' 边的法线向量的序列
    Private PointNormals As List(Of PointF)  ' 点的法线向量的序列
    Private Color As Color              ' 用颜色表示材料

    Public Sub New(color As Color, def As Boolean)
        Me.Color = color
        Points = New List(Of PointF)
        If def = True Then
            Dim cp As PointF = New PointF(200, 200)
            Dim r As Single = 150
            For angle = 0 To 359 Step 30
                Dim x As Single = cp.X + r * Cos(angle / 180 * PI)
                Dim y As Single = cp.X + r * Sin(angle / 180 * PI)
                Points.Add(New PointF(x, y))
            Next
        End If
        ComputeNormals()
    End Sub

    Public Sub New(color As Color, points As List(Of PointF))
        Me.color = color
        Me.Points = New List(Of PointF)(points)
        ComputeNormals()
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
        Dim polygon As clsPolygon = New clsPolygon(newcolor, False) ' 建立一个顶点表为空的多边形
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

    ' 根据当前对象，扩展n个对象，扩展间距为delta,最终扩展对象的颜色为TargetColor
    ' 函数返回“所有扩展对象组成的集合”
    Public Function Expand(TargetColor As Color, delta As Single, n As Integer) As clsPolygons
        Dim polygons As New clsPolygons
        For i = 1 To n
            Dim newcolor As Color = GetColor(Color, TargetColor, n, i)
            Dim newpolygon As clsPolygon = Expand(delta * i, newcolor)
            polygons.Add(newpolygon)
        Next
        Return polygons
    End Function

    '经过n次插值，sc变为tc    (index=1第一层，  index=n最后一层）
    Private Function GetColor(sc As Color, tc As Color, n As Integer, index As Integer) As Color
        Dim r As Integer = (-sc.R + tc.R) / n * index + sc.R
        Dim g As Integer = (-sc.G + tc.G) / n * index + sc.G
        Dim b As Integer = (-sc.B + tc.B) / n * index + sc.B
        Return Color.FromArgb(r, g, b)
    End Function
End Class
