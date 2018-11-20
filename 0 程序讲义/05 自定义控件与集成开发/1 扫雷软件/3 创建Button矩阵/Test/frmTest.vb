Public Class frmTest

    Dim ButtonMatrix As clsButtonMatrix

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        Dim start As Point
        start.X = 50 : start.Y = 50
        ButtonMatrix = New clsButtonMatrix(Me, start, 5, 8)
    End Sub

End Class
