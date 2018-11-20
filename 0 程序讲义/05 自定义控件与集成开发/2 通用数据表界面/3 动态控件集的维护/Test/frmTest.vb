Imports System.Windows

Public Class frmTest
    Dim Labels As List(Of Forms.Label)
    Dim TextBoxs As List(Of Forms.TextBox)
    Dim Buttons As List(Of Forms.Button) 'List没有事件WithEvents
    Dim WithEvents Button As Forms.Button

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Labels = New List(Of Forms.Label)
        TextBoxs = New List(Of Forms.TextBox)
        Buttons = New List(Of Forms.Button)
    End Sub
    Private Sub btnLayout_Click(sender As System.Object, e As System.EventArgs) Handles btnLayout.Click
        Me.SuspendLayout()
        Controls_Remove()
        Dim n As Integer = txtN.Text     ' 目标的控件个数
        Controls_Create(n)
        Me.ResumeLayout(False) '恢复正常的布局逻辑，可以选择强制对挂起的布局请求立即进行布局。
        Me.PerformLayout()     '强制控件将布局逻辑应用于其所有子控件。
    End Sub

    ' 删除所有动态控件
    Private Sub Controls_Remove()
        For i = Labels.Count - 1 To 0 Step -1
            Me.Controls.Remove(Labels(i)) : Labels.RemoveAt(i)
        Next
        For i = TextBoxs.Count - 1 To 0 Step -1
            Me.Controls.Remove(TextBoxs(i)) : TextBoxs.RemoveAt(i)
        Next
        For i = Buttons.Count - 1 To 0 Step -1
            Me.Controls.Remove(Buttons(i)) : Buttons.RemoveAt(i)
        Next
    End Sub
    ' 建立n组控件
    Private Sub Controls_Create(n As Integer)
        ' 增加控件
        Dim cp1 As clsCornerPoint = New clsCornerPoint(New Point(20, 40))
        Dim cp2 As clsCornerPoint = cp1.GetRight()
        Dim cp3 As clsCornerPoint = cp2.GetRight()
        CreateLabels(cp1, n)
        CreateTextBoxs(cp2, n)
        CreateButtons(cp3, n)
    End Sub

    Private Sub CreateLabels(cp As clsCornerPoint, n As Integer)
        For i = 0 To n - 1
            Dim Label As Forms.Label = New Forms.Label
            Label.Name = "Label" & i
            Label.Location = cp.CornerPoint
            Label.Text = "请输入数据" & i
            Label.Size = New Size(40, 20)
            cp = cp.GetBottom
            Labels.Add(Label)
            Me.Controls.Add(Label)
        Next
    End Sub
    Private Sub CreateTextBoxs(cp As clsCornerPoint, n As Integer)
        For i = 0 To n - 1
            Dim TextBox As Forms.TextBox = New Forms.TextBox
            TextBox.Name = "TextBox" & i
            TextBox.Location = cp.CornerPoint
            TextBox.Text = "默认值"
            TextBox.Size = New System.Drawing.Size(100, 20)
            TextBox.TabIndex = 1
            cp = cp.GetBottom
            TextBoxs.Add(TextBox)
            Me.Controls.Add(TextBox)
        Next
    End Sub
    Private Sub CreateButtons(cp As clsCornerPoint, n As Integer)
        For i = 0 To n - 1
            Button = New Forms.Button()
            AddHandler Button.Click, AddressOf Button_Click
            Button.Name = "Button" & i
            Button.Location = cp.CornerPoint
            Button.Text = "Button" & i
            Button.Size = New System.Drawing.Size(70, 20)
            Button.TabIndex = 0
            cp = cp.GetBottom
            Buttons.Add(Button)
            Me.Controls.Add(Button)
        Next
    End Sub

    Private Sub Button_Click(sender As System.Object, e As System.EventArgs)
        MsgBox(sender.name)
        Dim index As Integer = sender.name.ToString.Substring(6)
        Dim txtname As String = "TextBox" & index
        MsgBox(Me.Controls(txtname).Text)
    End Sub

End Class
