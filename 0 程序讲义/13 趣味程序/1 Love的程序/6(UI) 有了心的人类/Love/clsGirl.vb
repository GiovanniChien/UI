Public Class clsGirl
    Inherits clsYoung

    Public Overloads Overrides Sub Meet(ByVal Boy As clsYoung)
        Heart = Boy   ' 将男孩记在心中
    End Sub

    Public Overloads Overrides Sub Missing()
        Count += 1
        If Count < Max Then
            Say("女孩思念男孩" & Count)  ' 女孩继续恋爱游戏：再想念我一次
            Heart.Missing()
        Else
            Say("我们在一起！")          ' 女孩愿意
        End If
    End Sub

End Class



