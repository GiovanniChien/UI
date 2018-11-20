Public Class frmTest

    Dim ButtonMatrix As clsButtonMatrix

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click, btnGameOver.Click
        If sender Is btnStart Then
            Dim start As Point
            start.X = 50 : start.Y = 50
            ButtonMatrix = New clsButtonMatrix(start, 10, 10, 15)
            ButtonMatrix.Show(Me)
        End If
        If sender Is btnGameOver Then
            ButtonMatrix.ShowMine()
        End If
    End Sub
End Class

