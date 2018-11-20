Public Class frmTest
    Dim ButtonMatrix As clsButtonMatrix

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim Row As Integer = txtRow.Text, Col As Integer = txtCol.Text
        ButtonMatrix = New clsButtonMatrix(Me, Row, Col)
    End Sub


End Class


'

