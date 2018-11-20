Public Class frmGame
    Const N As Integer = 11
    Dim Score(N - 1) As Single
    Dim txtScores(N - 1) As TextBox
    Dim ith As Integer = 0

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtScores(0) = txtScore0
        txtScores(1) = txtScore1
        txtScores(2) = txtScore2
        txtScores(3) = txtScore3
        txtScores(4) = txtScore4
        txtScores(5) = txtScore5
        txtScores(6) = txtScore6
        txtScores(7) = txtScore7
        txtScores(8) = txtScore8
        txtScores(9) = txtScore9
        txtScores(10) = txtScore10
        For i = 0 To N - 1
            AddHandler txtScores(i).Leave, AddressOf txtScore_Leave
            AddHandler txtScores(i).KeyPress, AddressOf txtScore_KeyPress
            AddHandler txtScores(i).Validating, AddressOf txtScore_Validating
            txtScores(i).TabIndex = i
        Next
        btnTj.TabIndex = N
        btnNext.TabIndex = N + 1
        ith = 1
        Text = "南京师范大学: " & ith
    End Sub
    Private Sub txtScore_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> vbCr Then Return
        Dim i As Integer
        For i = 0 To N - 1
            If sender Is txtScores(i) Then
                Exit For
            End If
        Next
        If i < N - 1 Then
            txtScores(i + 1).Focus()
        Else
            btnTj.Focus()
        End If
    End Sub

    Private Sub txtScore_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim textbox As TextBox = sender
        Dim v As Single = textbox.Text
        If v > 10 Or v < 0 Then
            e.Cancel = True
        End If
    End Sub
    Private Sub txtScore_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TJ()
    End Sub
    Private Sub btnTj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTj.Click
        TJ()
        btnNext.Focus()
    End Sub
    Sub TJ() ' 核心
        ' 取数 保持与界面一致
        For i = 0 To N - 1
            Score(i) = Val(txtScores(i).Text)
            txtScores(i).Text = Score(i)
        Next
        ' 计算
        Dim imax As Integer = GetiMax()
        Dim imin As Integer = GetiMin()
        Dim mean As Single = (Score.Sum - Score(imin) - Score(imax)) / (N - 2)
        ' 界面
        Dim imean As Integer = mean * 1000
        mean = imean / 1000
        lblScore.Text = "总成绩：" & vbCrLf & String.Format("{0:0.000}", mean)
        For i = 0 To N - 1
            If i = imin Or i = imax Then
                txtScores(i).ForeColor = Color.Red
            Else
                txtScores(i).ForeColor = Color.Black
            End If
        Next
    End Sub
    Function GetiMax() As Integer
        Dim iMax As Integer = 0
        For i = 1 To N - 1
            If Score(i) > Score(iMax) Then
                iMax = i
            End If
        Next
        Return iMax
    End Function
    Function GetiMin() As Integer
        Dim iMin As Integer = 0
        For i = 1 To N - 1
            If Score(i) < Score(iMin) Then
                iMin = i
            End If
        Next
        Return iMin
    End Function

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        SaveBitMap()
        For i = 0 To N - 1
            txtScores(i).Text = 0
        Next
        txtScores(0).Focus()
        ith += 1
        Text = "南京师范大学: " & ith
        lblScore.Text = "总成绩"
    End Sub

    Private Sub SaveBitMap()
        Dim memory As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(memory)
        g.CopyFromScreen(Me.Left, Me.Top, 0, 0, Me.Size)
        Dim fname As String = "D:\" & ith & ".bmp"
        memory.Save(fname)
    End Sub
End Class
