' 思念分两种：1 由初始见面引发的思念动作； 2 由约会引发的思念动作
' 步伐的含义：个人的性子有快慢之别，体现在时机出现后，思念动作的延迟时间上 
Public Enum State
    Continuing   ' 继续爱情游戏
    Achieve      ' 爱情成功
    Setback      ' 爱情失意(未用，待扩展)
End Enum

Public MustInherit Class clsYoung
    Protected Const Max As Integer = 9

    Protected Heart As clsYoung, Count As Integer         ' 每个人都有一颗心，都有追求心的努力Count

    Public MustOverride Sub Meet(ByVal Young As clsYoung) ' 外在的相遇动作（为强调性别差异，在子类中实现）
    Protected MustOverride Function Missing() As State    ' 内在的思念动作（为强调性别差异，在子类中实现）

    Protected WithEvents Tick As Timer                    ' 流淌的时间（体现个性的快慢）

    Public Event TryDating(ByVal Young As clsYoung)        ' 期待再一次约会

    Public Sub New(ByVal Interval As Integer)
        ' 生命诞生了，青春还没有到达
        Heart = Nothing : Count = 0
        Tick = New Timer : Tick.Enabled = False
        Tick.Interval = Interval   ' 个性：每个人的步伐不一样
    End Sub

    Public Sub Dating()           ' 外在的约会动作
        ' 目前，约会的动作无法表达.....
        Tick.Enabled = True       ' 刺激内心，过一会儿，就会有思念
    End Sub

    Private Sub Tick_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tick.Tick
        ' 经过了一段时间，开始思念
        If Missing() = State.Continuing Then ' 男孩女孩的思念是不一样的
            RaiseEvent TryDating(Heart) ' 期待再一次和心上人约会
        End If
        Tick.Enabled = False       ' 思念冷却，等待下一次的激发
    End Sub

    Protected Sub Say(ByVal words As String)   ' 爱要说出口
        frmLove.lstWords.Items.Add(words)
    End Sub

End Class
