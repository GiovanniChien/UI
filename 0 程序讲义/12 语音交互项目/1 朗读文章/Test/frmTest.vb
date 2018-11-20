Imports System.IO
Imports System.Speech.Synthesis

Public Class frmTest

    Dim WithEvents Speaker As SpeechSynthesizer
   
    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim fs As FileStream, sr As StreamReader
        Dim fname As String
        fname = "Tom2.txt"  '"第1章 掉进兔子洞.txt"
        fs = New FileStream(fname, FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs, System.Text.Encoding.Default)
        txtContent.Text = sr.ReadToEnd()

        Speaker = New SpeechSynthesizer
        Speaker.Volume = 100  '设置朗读音量 [范围 0 ~ 100]
        Speaker.Rate = 0     '设置朗读频率 [范围 -10 ~ 10]
        'Speaker.SelectVoice("Microsoft Lili")  '中文女声语音库 支持中英文混读
        Speaker.SelectVoice("Microsoft Anna")   '英文女声语音库

        With trkRate
            .Minimum = -10 : .Maximum = 10 : .Value = Speaker.Rate
        End With
        With trkVolume
            .Minimum = 0 : .Maximum = 100 : .Value = Speaker.Volume
        End With
    End Sub
    Private Sub frmTest_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Speaker.Dispose()
    End Sub

    Private Sub btnSpeak_Click(sender As System.Object, e As System.EventArgs) Handles btnSpeak.Click
        Speaker.SpeakAsync(txtContent.Text)   '异步朗读
        'Speaker.Speak(txtContent.Text)       '同步朗读，直到读完，这条语句才结束
    End Sub

    Private Sub btnPause_Click(sender As System.Object, e As System.EventArgs) Handles btnPause.Click
        Speaker.Pause()
    End Sub
    Private Sub btnResume_Click(sender As System.Object, e As System.EventArgs) Handles btnResume.Click
        Speaker.Resume()
    End Sub
    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        'Speaker.SpeakAsyncCancel()???
        Speaker.SpeakAsyncCancelAll()
    End Sub

    Private Sub Speaker_StateChanged(ByVal sender As Object, ByVal e As System.Speech.Synthesis.StateChangedEventArgs) Handles Speaker.StateChanged

        Select Case e.State
            Case SynthesizerState.Paused
                Text = "Paused"
            Case SynthesizerState.Ready
                Text = "Ready"
            Case SynthesizerState.Speaking
                Text = "Speaking"
        End Select
    End Sub
    Private Sub Speaker_SpeakProgress(sender As Object, e As System.Speech.Synthesis.SpeakProgressEventArgs) Handles Speaker.SpeakProgress
        ListBox1.Items.Add(e.Text)
        txtContent.SelectionStart = e.CharacterPosition
        txtContent.SelectionLength = e.CharacterCount
        txtContent.Focus()
        txtContent.ScrollToCaret()
    End Sub

    Private Sub trkVolume_ValueChanged(sender As Object, e As System.EventArgs) Handles trkVolume.Scroll
        Speaker.Volume = trkVolume.Value
        Speaker.SpeakAsyncCancelAll()
        Speaker.SpeakAsync(txtContent.Text)   '异步朗读
    End Sub
    Private Sub trkRate_ValueChanged(sender As Object, e As System.EventArgs) Handles trkRate.Scroll
        Speaker.Rate = trkRate.Value      '设置朗读频率 [范围 -10 ~ 10]
        Speaker.SpeakAsyncCancelAll()
        Speaker.SpeakAsync(txtContent.Text)   '异步朗读
    End Sub

End Class
