Public Class Form1

    Dim WithEvents Button1 As System.Windows.Forms.Button

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        Button1 = New System.Windows.Forms.Button
        With Button1
            .Location = New System.Drawing.Point(50, 50)
            .Name = "btnInit"
            .Size = New System.Drawing.Size(25, 25)
            .TabIndex = 0
            .Text = ""
            .UseVisualStyleBackColor = True
        End With
        Me.Controls.Add(Button1)
        Me.ResumeLayout(False) '恢复正常的布局逻辑，可以选择强制对挂起的布局请求立即进行布局。
        Me.PerformLayout()     '强制控件将布局逻辑应用于其所有子控件。
    End Sub

    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
        If Button1.FlatStyle = FlatStyle.Standard Then
            Button1.FlatStyle = FlatStyle.Flat
        Else
            Button1.FlatStyle = FlatStyle.Standard
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("Hello")
    End Sub
End Class
