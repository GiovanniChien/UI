Public Class frmTest

    Dim WithEvents Button1 As Button

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Button1 = New Button
        Button1.Location = New System.Drawing.Point(100, 50)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(30, 20)
        Me.Controls.Add(Button1)
    End Sub

    Private Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(Button1.Name)
    End Sub
End Class


'

