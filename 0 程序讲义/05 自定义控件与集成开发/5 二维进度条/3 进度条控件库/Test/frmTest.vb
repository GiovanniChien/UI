Public Class frmTest

    Private Sub btnInit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInit.Click
        pbProgress1.Min = 0
        pbProgress1.Max = 100
        pbProgress1.Value = 90
    End Sub
    Private Sub btnSetValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetValue.Click
        pbProgress1.Value = pbProgress1.Value - 1
        Text = pbProgress1.Value
    End Sub

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbProgress2.TaskCount = 100
        For i = 0 To 99
            lstTask.Items.Add(i)
        Next
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        pbProgress2.SetValue(lstTask.SelectedIndex)
    End Sub


End Class
