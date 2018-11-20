Public Class ctrlTextBox
    Dim regex As clsRegex
    Dim WithEvents myTextBox As System.Windows.Forms.TextBox

    Private _DataType As DataType
    Public Property DataType As DataType
        Get
            Return _DataType
        End Get
        Set(value As DataType)
            _DataType = value
        End Set
    End Property


    Private Sub ctrlTextBox_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        myTextBox = New System.Windows.Forms.TextBox
        With myTextBox
            .Location = New System.Drawing.Point(0, 0)
            .Name = "myTextBox"
            .Size = New System.Drawing.Size(Me.Size)
            .Multiline = True
            .Text = ""
        End With
        Me.Controls.Add(myTextBox)
        Me.ResumeLayout(False) '恢复正常的布局逻辑，可以选择强制对挂起的布局请求立即进行布局。
        Me.PerformLayout()     '强制控件将布局逻辑应用于其所有子控件。
        regex = New clsRegex
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles myTextBox.Validating
        If Not regex.IsValidate(myTextBox.Text, DataType) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ctrlTextBox_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If myTextBox Is Nothing Then Exit Sub
        myTextBox.Size = Me.Size
    End Sub
End Class
