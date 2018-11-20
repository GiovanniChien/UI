Public Enum OpState  '可扩展的状态类型
    Pan
    Rotate
End Enum

Public Class clsMenuOpState
    Private MenuOpState As ContextMenuStrip  ' 菜单条
    Private WithEvents MenuOpStatePan, MenuOpStateRotate As ToolStripMenuItem  '菜单项
    Private Flag As OpState                  ' 状态
    Public Event FlagChange(ByVal flag As OpState)

    Public Sub New()
        MenuOpState = New ContextMenuStrip
        MenuOpStatePan = New ToolStripMenuItem : MenuOpStateRotate = New ToolStripMenuItem
        MenuOpState.Items.AddRange(New ToolStripItem() {Me.MenuOpStatePan, Me.MenuOpStateRotate})
        With MenuOpState
            .Name = "MenuOpState"
            .Size = New System.Drawing.Size(113, 48)
        End With
        With MenuOpStatePan
            .Text = "Pan"
            .Size = New System.Drawing.Size(112, 22)
        End With
        With MenuOpStateRotate
            .Text = "Rotate"
            .Size = New System.Drawing.Size(112, 22)
        End With
        Flag = OpState.Pan : SetMenuOpState()
    End Sub

    Private Sub SetMenuOpState()
        Select Case Flag
            Case OpState.Pan
                MenuOpStatePan.Checked = True : MenuOpStateRotate.Checked = False
            Case OpState.Rotate
                MenuOpStatePan.Checked = False : MenuOpStateRotate.Checked = True
        End Select
    End Sub

    Private Sub MenuOpState_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuOpStatePan.Click, MenuOpStateRotate.Click
        If sender Is MenuOpStatePan Then Flag = OpState.Pan
        If sender Is MenuOpStateRotate Then Flag = OpState.Rotate
        SetMenuOpState()
        RaiseEvent FlagChange(Flag)
    End Sub

    Public Sub Show(ByVal x As Integer, ByVal y As Integer)
        MenuOpState.Show(x, y)
    End Sub

End Class
