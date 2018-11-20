Imports System.Windows

Public Class frmTest
    Dim N As Integer
    Dim Labels As List(Of Forms.Label)
    Dim TextBoxs As List(Of Forms.TextBox)
    Dim Buttons As List(Of Forms.Button)    ' List不支持WithEvents
    Dim WithEvents Button As Forms.Button

    Private Sub btnLayout_Click(sender As System.Object, e As System.EventArgs) Handles btnLayout.Click
        Dim N As Integer = txtN.Text
        Controls_Create(N)
        Controls_Layout(N)
    End Sub

    Private Sub Controls_Layout(N As Integer)
        Me.SuspendLayout()
        For i = 0 To N - 1
            Me.Controls.Add(Labels(i))
            Me.Controls.Add(TextBoxs(i))
            Me.Controls.Add(Buttons(i))
        Next
        Me.ResumeLayout(False) '恢复正常的布局逻辑，可以选择强制对挂起的布局请求立即进行布局。
        Me.PerformLayout()     '强制控件将布局逻辑应用于其所有子控件。
    End Sub

    Private Sub Controls_Create(N As Integer)
        Dim cp1 As clsCornerPoint = New clsCornerPoint(New Point(20, 40))
        Dim cp2 As clsCornerPoint = cp1.GetRight()
        Dim cp3 As clsCornerPoint = cp2.GetRight()
        Labels = New List(Of Forms.Label)
        TextBoxs = New List(Of Forms.TextBox)
        Buttons = New List(Of Forms.Button)
        For i = 0 To N - 1
            Dim Label As Forms.Label = New Forms.Label
            Label.Name = "Label" & i
            Label.Location = cp1.CornerPoint
            Label.Text = "请输入数据" & i
            Label.Size = New Size(100, 20)
            cp1 = cp1.GetBottom
            Labels.Add(Label)
        Next
        For i = 0 To N - 1
            Dim TextBox As Forms.TextBox = New Forms.TextBox
            TextBox.Name = "TextBox" & i
            TextBox.Location = cp2.CornerPoint
            TextBox.Text = "默认值"
            TextBox.Size = New System.Drawing.Size(100, 20)
            TextBox.TabIndex = 1
            cp2 = cp2.GetBottom
            TextBoxs.Add(TextBox)
        Next
        For i = 0 To N - 1
            Button = New Forms.Button()
            AddHandler Button.Click, AddressOf Button_Click
            Button.Name = "Button" & i
            Button.Location = cp3.CornerPoint
            Button.Text = "Button" & i
            Button.Size = New System.Drawing.Size(70, 20)
            Button.TabIndex = 0
            cp3 = cp3.GetBottom
            Buttons.Add(Button)
        Next
    End Sub

    Private Sub Button_Click(sender As System.Object, e As System.EventArgs)
        MsgBox(sender.name)
        Dim index As Integer = sender.name.ToString.Substring(6)
        Dim txtname As String = "TextBox" & index
        MsgBox(Me.Controls(txtname).Text)
    End Sub


End Class
