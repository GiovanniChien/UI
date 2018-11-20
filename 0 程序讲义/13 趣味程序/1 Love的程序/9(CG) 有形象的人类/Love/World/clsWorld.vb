Public Class clsWorld
    Private World As List(Of clsYoung)  ' 世界
    Private picWorld As PictureBox, buffer As Bitmap  ' 展现世界的控件及位图对象

    Public Sub New(ByVal picWorld As PictureBox)
        Me.picWorld = picWorld
        buffer = New Bitmap(picWorld.Width, picWorld.Height)

        ' 创世纪：一个男孩和一个女孩的世界
        Me.World = New List(Of clsYoung)
        Dim BoyImage As clsCircle = New clsCircle(New Point(150, 150), 30, Color.Blue)
        Dim Boy As clsBoy = New clsBoy(1000, BoyImage)    ' 急性子的男孩
        AddHandler Boy.TryDating, AddressOf Boy_TryDating
        AddHandler Boy.Propose, AddressOf Boy_Propose
        World.Add(Boy)
        Dim GirlImage As clsCircle = New clsCircle(New Point(200, 150), 30, Color.Red)
        Dim Girl As clsGirl = New clsGirl(2000, GirlImage) ' 慢性子的女孩
        AddHandler Girl.TryDating, AddressOf Girl_TryDating
        World.Add(Girl)
        Draw()
    End Sub

    Public Sub Start()
        World(0).Meet(World(1)) ' 男孩遇见女孩
        World(1).Meet(World(0)) ' 女孩遇见男孩
    End Sub

    Private Sub Boy_TryDating(ByVal Girl As clsYoung)
        Girl.Dating()
        Draw()
    End Sub
    Private Sub Boy_Propose(ByVal Girl As clsYoung)
        Girl.Dating()
        Draw()
    End Sub
    Private Sub Girl_TryDating(ByVal Boy As clsYoung)
        Boy.Dating()
        Draw()
    End Sub

    Private Sub Draw()
        For i = 0 To World.Count - 1
            World(i).Draw(buffer)
        Next
        picWorld.Image = buffer
    End Sub

End Class

' 世界中还缺少一个上帝角色，来安排大家的缘分
