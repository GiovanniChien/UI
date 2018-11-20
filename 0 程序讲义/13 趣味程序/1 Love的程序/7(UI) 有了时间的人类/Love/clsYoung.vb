Public MustInherit Class clsYoung
    Protected Const Max As Integer = 9

    ' 每个人都有一颗心，都有追求心的努力Count
    Protected Heart As clsYoung, Count As Integer
    Public MustOverride Sub Meet(ByVal Young As clsYoung)
    Protected MustOverride Sub Missing()
    Protected WithEvents Tick As Timer             ' 流淌的时间

    Public Sub New()
        ' 生命诞生了，青春还没有到达
        Heart = Nothing : Count = 0
        Tick = New Timer : Tick.Enabled = False
        Tick.Interval = 1000    ' 假设：步伐一致
    End Sub

    Private Sub Tick_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tick.Tick
        Missing()   ' 男孩女孩的思念是不一样的
    End Sub

    Protected Sub Say(ByVal words As String)   ' 爱要说出口
        frmLove.lstWords.Items.Add(words)
    End Sub

End Class
