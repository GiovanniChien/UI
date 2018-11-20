
Class ClsBall

    Private WithEvents Tick As Timer
    Private Shared r As Integer = 5
    Private x, y As Single
    Private dx, dy As Single
    Public Event Changed()

    Public Sub New(ByVal x As Single, ByVal y As Single, ByVal dx As Single, ByVal dy As Single)
        Tick = New Timer
        Tick.Enabled = False
        Tick.Interval = 100
        Me.x = x : Me.y = y : Me.dx = dx : Me.dy = dy
    End Sub

    Public Sub Start()
        Tick.Enabled = True
    End Sub

    Public Sub [Stop]()
        Tick.Enabled = False
    End Sub

    Private Sub Tick_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tick.Tick
        x += dx : y += dy
        If x > 400 Or x < 0 Then dx = -dx 
        If y > 400 Or y < 0 Then dy = -dy
        RaiseEvent Changed()
    End Sub

    Sub Draw(ByVal g As Graphics)
        g.DrawEllipse(Pens.Red, x - r, y - r, r * 2, r * 2)
    End Sub

End Class
