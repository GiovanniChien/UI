Public Class frmTest

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbProgress.TaskCount = 100
        For i = 0 To 99
            lstTask.Items.Add(i)
        Next
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        pbProgress.SetValue(lstTask.SelectedIndex)
    End Sub
End Class
