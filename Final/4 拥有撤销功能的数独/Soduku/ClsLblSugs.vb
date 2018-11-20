Imports System.Math

Public Class ClsLblSugs
    Private lblClicked As Label
    Private lblSugs As List(Of Label)
    Private picLblSugs As PictureBox
    Private picLblMatrix As PictureBox
    Private waitSolveMatrix(,) As Integer
    Private numCanUse(8) As Boolean
    Private row As Integer, col As Integer
    Private Const width As Integer = 30, height As Integer = 30

    Public Sub New(lblClicked As Label, picLblMatrix As PictureBox, waitSolveMatrix As Integer(,))
        Me.picLblMatrix = picLblMatrix
        Me.lblClicked = lblClicked
        Dim lblClickedName As String = lblClicked.Name
        Dim splitedName() As String = lblClickedName.Split(" ")
        row = splitedName(1)
        col = splitedName(2)
        Me.waitSolveMatrix = waitSolveMatrix
        SetNumCanUse()
        lblSugs = New List(Of Label)
        DelPic()
        picLblSugs = New PictureBox
        InitPic()
        InitLblSugs()
    End Sub

    Private Sub SetNumCanUse()
        For i = 0 To 8
            numCanUse(i) = True
        Next
        Dim index As Integer = 3 * (Fix(row / 3)) + Fix(col / 3)
        For i = 1 To 9
            If NumInRow(i, row) Then
                numCanUse(i - 1) = False
                Continue For
            End If
            If NumInCol(i, col) Then
                numCanUse(i - 1) = False
                Continue For
            End If
            If numInBlock(i, Index) Then
                numCanUse(i - 1) = False
                Continue For
            End If
        Next
    End Sub

    Private Function numInBlock(i As Integer, index As Integer) As Boolean
        Dim startX As Integer = (Fix(index / 3)) * 3
        Dim startY As Integer = (index Mod 3) * 3
        For m = startX To startX + 2
            For n = startY To startY + 2
                If waitSolveMatrix(m, n) = i Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Private Function NumInCol(i As Integer, colIndex As Integer) As Boolean
        For k = 0 To 8
            If waitSolveMatrix(k, colIndex) = i Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function NumInRow(i As Integer, rowIndex As Integer) As Boolean
        For k = 0 To 8
            If waitSolveMatrix(rowIndex, k) = i Then
                Return True
            End If
        Next
        Return False
    End Function

    '将picBtnMatrix中原有的picLblSugs删除
    Private Sub DelPic()
        Dim controls() As Control = picLblMatrix.Controls.Find("picLblSugs", True)
        If controls.Count > 0 Then
            For i = 0 To controls.Count - 1
                picLblMatrix.Controls.Remove(controls(i))
            Next
        End If
    End Sub

    '根据单击的按钮的位置新建pictureBox显示可填数字
    Private Sub InitPic()
        picLblSugs.Name = "picLblSugs"
        picLblSugs.Size = New System.Drawing.Size(3 * width, 4 * height)
        picLblSugs.BorderStyle = BorderStyle.FixedSingle
        'picLblSugs.Parent = lblClicked
        'picLblSugs.BackColor = Color.FromArgb(0, 255, 255, 255)
        Dim basePoint As Point = New Point(lblClicked.Location.X + Fix(lblClicked.Width / 2), lblClicked.Location.Y + Fix(lblClicked.Height / 2))
        'picLblSugs.Location = New System.Drawing.Point(0, 0)
        If row < 4 Then
            If col < 4 Then
                picLblSugs.Location = New System.Drawing.Point(basePoint)
            Else
                picLblSugs.Location = New System.Drawing.Point(basePoint.X - picLblSugs.Width, basePoint.Y)
            End If
        Else
            If col < 4 Then
                picLblSugs.Location = New System.Drawing.Point(basePoint.X, basePoint.Y - picLblSugs.Height)
            Else
                picLblSugs.Location = New System.Drawing.Point(basePoint.X - picLblSugs.Width, basePoint.Y - picLblSugs.Height)
            End If
        End If
        picLblMatrix.Controls.Add(picLblSugs)
        picLblSugs.BringToFront()
    End Sub

    '在新建画布中新建可填数字
    Private Sub InitLblSugs()
        For i = 0 To 2
            For j = 0 To 2
                Dim label As New Label
                Dim k As Integer = i * 3 + j + 1
                label.Name = "lblSug " & k
                label.Size = New System.Drawing.Size(width, height)
                label.Text = k
                label.Location = New System.Drawing.Point(j * width, i * height)
                label.TextAlign = ContentAlignment.MiddleCenter
                label.BorderStyle = BorderStyle.FixedSingle
                label.Parent = picLblSugs
                label.BackColor = Color.Transparent
                If numCanUse(k - 1) Then
                    label.Cursor = Cursors.Hand
                    AddHandler label.Click, AddressOf LblSugs_clicks
                Else
                    label.ForeColor = Color.FromArgb(200, 200, 200)
                End If
                lblSugs.Add(label)
            Next
        Next
        Dim lblDelete As New Label
        Dim lblCancel As New Label
        '创建删除按钮
        lblDelete.Name = "btnDel"
        lblDelete.Text = "删除"
        lblDelete.Size = New System.Drawing.Size(2 * width, height)
        lblDelete.Location = New System.Drawing.Point(0, 3 * height)
        lblDelete.TextAlign = ContentAlignment.MiddleCenter
        lblDelete.BorderStyle = BorderStyle.FixedSingle
        lblDelete.Cursor = Cursors.Hand
        'lblDelete.BackColor = Color.Violet
        AddHandler lblDelete.Click, AddressOf LblDelete_click
        lblSugs.Add(lblDelete)
        '创建取消按钮
        lblCancel.Name = "btnCal"
        lblCancel.Text = "X"
        lblCancel.Size = New System.Drawing.Size(width, height)
        lblCancel.Location = New System.Drawing.Point(lblDelete.Size.Width, lblDelete.Location.Y)
        lblCancel.TextAlign = ContentAlignment.MiddleCenter
        lblCancel.BorderStyle = BorderStyle.FixedSingle
        lblCancel.Cursor = Cursors.Hand
        lblCancel.ForeColor = Color.Red
        AddHandler lblCancel.Click, AddressOf LblCancel_click
        lblSugs.Add(lblCancel)
        '将所有按钮添加到pictureBox容器中
        picLblSugs.Controls.Clear()
        For i = 0 To 10
            picLblSugs.Controls.Add(lblSugs(i))
        Next
    End Sub

    Private Sub LblCancel_click(sender As Object, e As EventArgs)
        'picLblSugs.Controls.Clear()
        DelPic()
    End Sub

    Private Sub LblDelete_click(sender As Object, e As EventArgs)
        Dim op As ClsOp = New ClsOp(lblClicked, lblClicked.Text, "", waitSolveMatrix(row, col))
        frmTest.ops.Add(op)
        lblClicked.Text = ""
        waitSolveMatrix(row, col) = 0
        DelPic()
    End Sub

    Private Sub LblSugs_clicks(sender As Object, e As EventArgs)
        Dim op As ClsOp = New ClsOp(lblClicked, lblClicked.Text, sender.text, waitSolveMatrix(row, col))
        frmTest.ops.Add(op)
        lblClicked.Text = sender.text
        waitSolveMatrix(row, col) = sender.text
        DelPic()
        If IsFinish() Then
            frmTest.timer.StopTimer()
            Dim time = frmTest.timer.GetTime
            Dim Str As String = String.Format("恭喜成功，您的用时为: {0}s，是否开始新游戏？", time)
            Dim msgRes As MsgBoxResult = MsgBox(Str, vbOKCancel + vbQuestion, "提示")
            If msgRes = MsgBoxResult.Ok Then
                frmTest.NewGame()
            Else
                frmTest.Close()
            End If
        End If
    End Sub

    Private Function IsFinish() As Boolean
        For i = 0 To 8
            For j = 0 To 8
                If waitSolveMatrix(i, j) = 0 Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
End Class
