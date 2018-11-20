Public Class clsButtonMatrix
    Private Buttons As List(Of Button)
    Private States As clsStates
    Private RowN As Integer, ColN As Integer
    Private MineN As Integer
    Private Width As Integer         ' 方形按钮的宽度
    Private XGap, YGap As Integer    ' X,Y方向按钮的间距
    Private Start As Point     ' 按钮集合的排列起点（左上角）

    Public Sub New(Start As Point, RowN As Integer, ColN As Integer)
        Me.Width = 25 : Me.XGap = 1 : Me.YGap = 1 : Me.MineN = 10
        Me.RowN = RowN : Me.ColN = ColN
        Me.Start = Start
        States = New clsStates(RowN, ColN, MineN)  ' 创建状态集合
        CreateButtons(RowN, ColN)                  ' 创建按钮集合
    End Sub
    Public Sub Show(frm As frmTest)
        ' 将按钮集合加入frm中
        For i = 0 To RowN * ColN - 1
            frm.Controls.Add(Buttons(i))
        Next
        frm.ResumeLayout(False)  '恢复正常的布局逻辑，可以选择强制对挂起的布局请求立即进行布局。
        frm.PerformLayout()      '强制控件将布局逻辑应用于其所有子控件。
    End Sub
    Public Sub ShowMine()
        For i = 0 To RowN - 1
            For j = 0 To ColN - 1
                If States.isMine(i, j) Then
                    Buttons(i * ColN + j).Text = "雷"
                Else
                    Buttons(i * ColN + j).Text = States.GetMineCount(i, j)
                End If
            Next
        Next
    End Sub

    Public Sub CreateButtons(RowN As Integer, ColN As Integer)
        Buttons = New List(Of Button)
        For i = 0 To RowN - 1
            For j = 0 To ColN - 1
                Buttons.Add(New Button)
                Dim k As Integer = i * ColN + j  '二维下标转换为一维下标
                With Buttons(k)
                    .Name = "btn" & "_" & i & "_" & j
                    .Text = ""
                    .TabIndex = k
                    .UseVisualStyleBackColor = True
                    .Size = New System.Drawing.Size(Width, Width)
                    .Location = New Point(Start.X + j * (Width + XGap), Start.Y + i * (Width + YGap))
                End With
                AddHandler Buttons(k).Click, AddressOf Button_Click
            Next
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        MsgBox("Hello " & sender.name)
        Dim button1 As Button = sender
        If Button1.FlatStyle = FlatStyle.Standard Then
            Button1.FlatStyle = FlatStyle.Flat
        Else
            Button1.FlatStyle = FlatStyle.Standard
        End If

    End Sub




End Class
