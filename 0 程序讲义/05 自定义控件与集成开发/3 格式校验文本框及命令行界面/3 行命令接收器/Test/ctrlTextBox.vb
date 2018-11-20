Imports System.Windows

Public Class ctrlTextBox
    Dim Commands As clsCommands
    Dim WithEvents myTextBox As System.Windows.Forms.TextBox

    Private Sub ctrlTextBox_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Commands = New clsCommands

        myTextBox = New System.Windows.Forms.TextBox
        With myTextBox
            .Location = New System.Drawing.Point(0, 0)
            .Name = "TextBox1"
            .Size = New System.Drawing.Size(Me.Size)
            .Multiline = False
            .Text = ""
        End With
        Me.Controls.Add(myTextBox)
        Me.ResumeLayout(False) '恢复正常的布局逻辑，可以选择强制对挂起的布局请求立即进行布局。
        Me.PerformLayout()     '强制控件将布局逻辑应用于其所有子控件。
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles myTextBox.Validating
        '输入命令串是否合法
        If Commands.IsMatch(myTextBox.Text) = CmdType.cmdNone Then
            e.Cancel = True
        End If
    End Sub
    Private Sub myTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles myTextBox.KeyPress
        If e.KeyChar = vbCr Then
            Dim type As CmdType = Commands.IsMatch(myTextBox.Text)
            If type = CmdType.cmdNone Then Return
            Dim para() As Integer = Commands.GetPara(myTextBox.Text, type)
            Dim spara As String = para(0)
            For i = 1 To para.Count - 1
                spara = spara & vbCr & para(i)
            Next
            MsgBox(spara)
        End If
    End Sub

    Private Sub ctrlTextBox_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If myTextBox Is Nothing Then Exit Sub
        myTextBox.Size = Me.Size
    End Sub
End Class
