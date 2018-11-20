Class clsBitmapModifier
    Public SourceBuff, TargetBuff As Bitmap
    Private Mark As Color      '区域中的点的表示色
    Private Points As List(Of Point)

    Public Sub New(fname As String, red As Tuple(Of Integer, Integer), green As Tuple(Of Integer, Integer), blue As Tuple(Of Integer, Integer), Mark As Color)
        Me.SourceBuff = New Bitmap(fname)
        Me.TargetBuff = New Bitmap(Me.SourceBuff.Width, Me.SourceBuff.Height)
        Me.Mark = Mark
        ' 将SourceBuff中符合条件的像素值，改为Mark色，写入TargetBuff
        Dim c As Color
        For x = 0 To Me.SourceBuff.Width - 1
            For y = 0 To Me.SourceBuff.Height - 1
                c = Me.SourceBuff.GetPixel(x, y)
                If c.R >= red.Item1 And c.R <= red.Item2 And c.G >= green.Item1 And c.G <= green.Item2 And c.B >= blue.Item1 And c.B <= blue.Item2 Then
                    TargetBuff.SetPixel(x, y, Mark)
                Else
                    TargetBuff.SetPixel(x, y, Color.White)
                End If
            Next
        Next
    End Sub

    '在TargetBuff中，根据Mark识别、创建区域，保存到区域集合对象中
    Function GetRegions() As clsRegions
        Dim Regions As clsRegions = New clsRegions()
        Dim Width As Integer = TargetBuff.Width, Height As Integer = TargetBuff.Height
        Dim flagMatrix(Width - 1, Height - 1) As Boolean    '访问标记数组
        For x = 0 To Width - 1
            For y = 0 To Height - 1
                flagMatrix(x, y) = False  '未访问过
            Next
        Next
        Dim p As Point
        For x = 0 To Width - 1
            For y = 0 To Height - 1
                If TargetBuff.GetPixel(x, y).ToArgb <> Mark.ToArgb Then Continue For
                If flagMatrix(x, y) = True Then Continue For '已经访问过
                p.X = x : p.Y = y
                '以p为起点，对相邻的Mark色的像素点进行层次遍历，同时修改flagMatrix(x, y)为True
                Dim PointsInRegion As List(Of Point) = Bfs(TargetBuff, p, flagMatrix) '该区域中所有点的集合
                Regions.Add(New clsRegion(PointsInRegion))
            Next
        Next
        Return Regions
    End Function

    ' 在Buff中，以sp为起点，查找sp所在的连通分量，返回其中的所有点的集合
    Private Function Bfs(Buff As Bitmap, sp As Point, flagMatrix(,) As Boolean) As List(Of Point)
        Dim region As List(Of Point) = New List(Of Point)()
        Dim Width As Integer = Buff.Width, Height As Integer = Buff.Height
        Dim Q As New Queue(Of Point)
        Q.Enqueue(sp) : flagMatrix(sp.X, sp.Y) = True
        Dim p, adjPoints(3) As Point
        While Q.Count > 0
            p = Q.Dequeue() : region.Add(p)
            adjPoints(0) = New Point(p.X - 1, p.Y)  ' 左右邻接点
            adjPoints(1) = New Point(p.X + 1, p.Y)
            adjPoints(2) = New Point(p.X, p.Y - 1)  ' 上下邻接点
            adjPoints(3) = New Point(p.X, p.Y + 1)
            For i = 0 To 3
                If adjPoints(i).X < 0 Or adjPoints(i).X >= Width Then Continue For ' 越界检查
                If adjPoints(i).Y < 0 Or adjPoints(i).Y >= Height Then Continue For ' 越界检查
                If Buff.GetPixel(adjPoints(i).X, adjPoints(i).Y).ToArgb <> Mark.ToArgb Then Continue For ' 点颜色检查
                If flagMatrix(adjPoints(i).X, adjPoints(i).Y) = True Then Continue For ' 访问标记检查
                Q.Enqueue(adjPoints(i)) : flagMatrix(adjPoints(i).X, adjPoints(i).Y) = True
            Next
        End While
        Return region
    End Function

End Class
