Public Class frmTest

    Dim ButtonRow As clsButtonRow

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        Dim start As Point
        start.X = 50 : start.Y = 50 '100
        ButtonRow = New clsButtonRow(Me, start, 10)
    End Sub


End Class
