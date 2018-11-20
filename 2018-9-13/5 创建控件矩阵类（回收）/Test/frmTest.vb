Public Class frmTest
    Dim ButtonMatrix As clsButtonMatrix

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim Row As Integer = txtRow.Text, Col As Integer = txtCol.Text
        If ButtonMatrix IsNot Nothing Then
            ButtonMatrix.RemoveContainer(Me)
        End If
        ButtonMatrix = New clsButtonMatrix(Row, Col)
        ButtonMatrix.AppendContainer(Me)
    End Sub


End Class


'

