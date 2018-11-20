Public Class frmTest
    Dim Label1 As System.Windows.Forms.Label
    Dim TextBox1 As System.Windows.Forms.TextBox

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label

        Me.Label1.Name = "Label1"
        Me.Label1.Text = "请输入数据："
        Me.Label1.Location = New System.Drawing.Point(20, 40)
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.Visible = True

        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Text = "默认值"
        Me.TextBox1.Location = New System.Drawing.Point(100, 40)
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)

        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.ResumeLayout(False) '恢复正常的布局逻辑，可以选择强制对挂起的布局请求立即进行布局。
        Me.PerformLayout()     '强制控件将布局逻辑应用于其所有子控件。
    End Sub

    Private Sub btnDoSomething_Click(sender As System.Object, e As System.EventArgs) Handles btnDoSomething.Click
        Me.TextBox1.Left = Me.TextBox1.Left + 10
    End Sub
End Class
