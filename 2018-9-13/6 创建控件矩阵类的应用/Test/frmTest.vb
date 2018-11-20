Public Class frmTest
    Dim ButtonMatrix1 As clsButtonMatrix
    Dim ButtonMatrix2 As clsButtonMatrix

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim Row As Integer = txtRow.Text, Col As Integer = txtCol.Text
        If ButtonMatrix1 IsNot Nothing Then
            ButtonMatrix1.RemoveContainer(GroupBox1.Controls)
        End If
        ButtonMatrix1 = New clsButtonMatrix(Row, Col)
        ButtonMatrix1.AppendContainer(GroupBox1.Controls)
    End Sub

    '    Container.SuspendLayout()
    'Container.ResumeLayout(False)
    'Container.PerformLayout()


End Class


'

