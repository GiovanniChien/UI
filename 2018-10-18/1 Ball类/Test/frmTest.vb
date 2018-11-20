Public Class frmTest

    Dim WithEvents Ball1 As ClsBall
    Dim WithEvents Ball2 As ClsBall
    Dim WithEvents Ball3 As ClsBall

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Ball1 = New ClsBall(100, 100, 3, 5)
        Ball2 = New ClsBall(100, 100, 2, 8)
        Ball3 = New ClsBall(100, 100, 7, 9)
        'PictureBox1.Parent = Me
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Ball1.Start()
        Ball2.Start()
        Ball3.Start()
    End Sub

    
    Private Sub Ball_Changed() Handles Ball1.Changed, Ball2.Changed, Ball3.Changed
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        Ball1.Draw(g)
        Ball2.Draw(g)
        Ball3.Draw(g)
    End Sub
End Class
