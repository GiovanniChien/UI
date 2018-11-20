Public Class clsBoy
    Inherits clsYoung
    Public Event Propose(ByVal girl As clsGirl)   ' 男孩的求婚事件

    Public Sub New(ByVal Interval As Integer, ByVal Image As clsCircle)
        MyBase.new(Interval, Image)
    End Sub

    Public Overrides Sub Meet(ByVal Girl As clsYoung)
        Heart = Girl         ' 将女孩记在心中
        Tick.Enabled = True  ' 启动青春
    End Sub

    Protected Overrides Function Missing() As State
        Count += 1
        If Count < Max Then
            Say("男孩思念女孩" & Count & "次")
        Else
            Say("让我们在一起吧？")      ' 男孩婚誓事件
            RaiseEvent Propose(Heart)
        End If
        Return State.Continuing
    End Function

    Public Overrides Sub Draw(ByVal buffer As System.Drawing.Bitmap)
        Image.Draw(buffer)
    End Sub

End Class
