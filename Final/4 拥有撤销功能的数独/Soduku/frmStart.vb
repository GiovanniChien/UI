Public Class frmStart
    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        frmTest.hard = 0
        Me.Close()
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        frmTest.hard = 1
        Me.Close()
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        frmTest.hard = 2
        Me.Close()
    End Sub
End Class