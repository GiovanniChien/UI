Public Class clsBoy
    Inherits clsYoung

    Public Overloads Overrides Sub Meet(ByVal Girl As clsYoung)
        Heart = Girl         ' 将女孩记在心中
        Tick.Enabled = True  ' 启动青春
    End Sub

    Protected Overrides Sub Missing()
        Count += 1
        If Count < Max Then
            Say("男孩思念女孩" & Count)
        Else
            Say("让我们在一起吧？")
            Tick.Enabled = False  ' 关闭青春
        End If
    End Sub

End Class
