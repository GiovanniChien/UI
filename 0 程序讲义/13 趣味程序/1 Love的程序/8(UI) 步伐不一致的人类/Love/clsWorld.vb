Public Class clsWorld
    Private World As List(Of clsYoung)  ' 一个世界

    Public Sub New()
        ' 创世纪：一个男孩和一个女孩的世界
        World = New List(Of clsYoung)
        Dim Boy As clsBoy = New clsBoy(1000)    ' 急性子的男孩
        AddHandler Boy.TryDating, AddressOf Boy_TryDating
        AddHandler Boy.Propose, AddressOf Boy_Propose
        World.Add(Boy)
        Dim Girl As clsGirl = New clsGirl(2000) ' 慢性子的女孩
        AddHandler Girl.TryDating, AddressOf Girl_TryDating
        World.Add(Girl)
    End Sub

    Public Sub Start()
        frmLove.lstWords.Items.Clear()
        World(0).Meet(World(1)) ' 男孩遇见女孩
        World(1).Meet(World(0)) ' 女孩遇见男孩
    End Sub

    Private Sub Boy_TryDating(ByVal Girl As clsYoung)
        Girl.Dating()
    End Sub
    Private Sub Boy_Propose(ByVal Girl As clsYoung)
        Girl.Dating()
    End Sub
    Private Sub Girl_TryDating(ByVal Boy As clsYoung)
        Boy.Dating()
    End Sub
End Class

' 世界中还缺少一个上帝角色，来安排大家的缘分
