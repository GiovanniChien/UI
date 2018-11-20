Public Class ClsTimer
    Private WithEvents timer As Timer
    Private lblTime As Label
    Private time As Integer

    Public ReadOnly Property GetTime As Integer
        Get
            Return time
        End Get
    End Property

    Public Sub New(lblTime As Label)
        timer = New Timer
        timer.Interval = 1000
        Me.lblTime = lblTime
        time = 0
        Me.lblTime.Text = time
    End Sub

    Public Sub StartTimer()
        timer.Enabled = True
    End Sub

    Public Sub StopTimer()
        timer.Enabled = False
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        time += 1
        lblTime.Text = time
    End Sub

    Public Sub Clear()
        time = 0
        lblTime.Text = time
    End Sub
End Class
