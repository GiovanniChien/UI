Public Class clsGirl
    Inherits clsYoung

    Public Overloads Overrides Sub Meet(ByVal Young As clsYoung)
        Heart = Young          ' 将男孩记在心中
        Tick.Enabled = True    ' 启动青春
    End Sub

    Protected Overloads Overrides Sub Missing()
        Count += 1
        If Count < Max Then
            Say("女孩思念男孩" & Count)
        Else
            Say("我们在一起！")
            Tick.Enabled = False   ' 关闭青春
        End If
    End Sub

End Class



