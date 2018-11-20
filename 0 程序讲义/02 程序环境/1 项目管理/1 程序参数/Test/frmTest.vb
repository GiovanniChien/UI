Public Class frmTest

    '显示My.Settings
    Private Sub DisplaySettings()
        txtUserName.Text = My.Settings.UserName
        Me.BackColor = My.Settings.BkColor
    End Sub

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DisplaySettings()
    End Sub

    Private Sub btnChange_Click(sender As System.Object, e As System.EventArgs) Handles btnChange.Click
        Dim dlg As New ColorDialog
        If dlg.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return
        My.Settings.BkColor = dlg.Color
        DisplaySettings()
    End Sub

    Private Sub txtUserName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUserName.TextChanged
        My.Settings.UserName = txtUserName.Text
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        '将Settings还原为默认值。
        My.Settings.Reset()
        DisplaySettings()
    End Sub

End Class
