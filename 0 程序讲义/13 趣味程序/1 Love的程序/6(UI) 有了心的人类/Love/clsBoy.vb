Public Class clsBoy
    Inherits clsYoung

    Public Overloads Overrides Sub Meet(ByVal Girl As clsYoung)
        Heart = Girl  ' 将女孩记在心中
    End Sub

    Public Overrides Sub Missing()
        Count += 1
        If Count < Max Then
            Say("男孩思念女孩" & Count)  ' 男孩的想念事件
        Else
            Say("让我们在一起吧？")      ' 男孩婚誓事件
        End If
        Heart.Missing()
    End Sub

End Class
