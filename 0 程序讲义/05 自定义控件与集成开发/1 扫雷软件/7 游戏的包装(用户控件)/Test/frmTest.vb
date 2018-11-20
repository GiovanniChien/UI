Public Class frmTest

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click, btnGameOver.Click
        If sender Is btnStart Then
            MineGame1.GameStart(10, 10, 15)
        End If
        If sender Is btnGameOver Then
            MineGame1.GameOver()
        End If
    End Sub
End Class

