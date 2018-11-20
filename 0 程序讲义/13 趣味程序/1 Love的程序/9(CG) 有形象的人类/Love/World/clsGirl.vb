Public Class clsGirl
    Inherits clsYoung

    Public Sub New(ByVal Interval As Integer, ByVal Image As clsCircle)
        MyBase.new(Interval, Image)
    End Sub

    Public Overrides Sub Meet(ByVal Young As clsYoung)
        Heart = Young          ' 将男孩记在心中
        Tick.Enabled = True    ' 启动青春
    End Sub

    Protected Overrides Function Missing() As State
        Count += 1
        If Count < Max Then
            Say("女孩思念男孩" & Count & "次")   ' 女孩继续恋爱游戏：再思念我一次
            Return State.Continuing
        Else
            Say("我们在一起！")           ' 女孩愿意
            Return State.Achieve
        End If
    End Function

    Public Overrides Sub Draw(ByVal buffer As System.Drawing.Bitmap)
        Image.Draw(buffer)
    End Sub
End Class



