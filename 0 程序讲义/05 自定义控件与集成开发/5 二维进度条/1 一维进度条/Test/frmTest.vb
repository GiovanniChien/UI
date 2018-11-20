Public Class frmTest

    Private Sub btnInit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInit.Click
        pbProgress.Min = 0
        pbProgress.Max = 100
        pbProgress.Value = 90
    End Sub

    Private Sub btnSetValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetValue.Click
        pbProgress.Value = pbProgress.Value - 1
        Text = pbProgress.Value
    End Sub
End Class
