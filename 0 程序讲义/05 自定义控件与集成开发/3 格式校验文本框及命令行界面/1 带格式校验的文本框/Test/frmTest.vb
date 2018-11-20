Public Class frmTest

    Dim regex As clsRegex
    Dim myTextBox1 As System.Windows.Forms.TextBox

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myTextBox1 = New System.Windows.Forms.TextBox
        With myTextBox1
            .Location = New System.Drawing.Point(50, 50)
            .Name = "myTextBox1"
            .Size = New System.Drawing.Size(200, 25)
            .TabIndex = 0
            .Text = ""
            AddHandler myTextBox1.Validating, AddressOf TextBox1_Validating
        End With
        Me.Controls.Add(myTextBox1)
        Me.ResumeLayout(False) '恢复正常的布局逻辑，可以选择强制对挂起的布局请求立即进行布局。
        Me.PerformLayout()     '强制控件将布局逻辑应用于其所有子控件。
        regex = New clsRegex
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If Not regex.IsValidate(myTextBox1.Text) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click

    End Sub
End Class
