Public Class clsButtonRow
    Private Buttons As List(Of Button)
    Private Width As Integer   ' 方形按钮的宽度
    Private XGap As Integer    ' X方向按钮的间距
    Private Start As Point     ' 按钮集合的排列起点（左上角）

    Public Sub New(frm As frmTest, Start As Point, ButtonN As Integer)
        Me.Width = 25 : Me.XGap = 1
        Me.Start = Start
        ' 创建按钮集合
        CreateButtons(ButtonN)
        ' 将按钮集合加入frm中
        For i = 0 To ButtonN - 1
            frm.Controls.Add(Buttons(i))
        Next
        frm.ResumeLayout(False)  '恢复正常的布局逻辑，可以选择强制对挂起的布局请求立即进行布局。
        frm.PerformLayout()      '强制控件将布局逻辑应用于其所有子控件。
    End Sub

    Public Sub CreateButtons(ButtonN As Integer)
        Buttons = New List(Of Button)
        For i = 0 To ButtonN - 1
            Buttons.Add(New Button)
            With Buttons(i)
                .Name = "btn" & i
                .Text = ""
                .TabIndex = i
                .UseVisualStyleBackColor = True
                .Size = New System.Drawing.Size(Width, Width)

                .Location = New System.Drawing.Point(Start.X + i * (Width + XGap), Start.Y)
            End With
            AddHandler Buttons(i).Click, AddressOf Button_Click
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        MsgBox("Hello " & sender.name)
    End Sub

End Class
