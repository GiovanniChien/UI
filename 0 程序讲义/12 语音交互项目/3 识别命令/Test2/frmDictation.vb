Imports System.Speech
Imports System.Speech.Recognition
Imports System.Speech.Recognition.SrgsGrammar
Imports System.IO
'中文识别效果完全失败：按理说能够听写英文，没有理由不能识别中文。一定有些事情是我所不知道的。

Public Class frmDictation
    Dim WithEvents Re As SpeechRecognitionEngine
    Dim Grammar As Speech.Recognition.Grammar

    Private Sub frmDictation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Re = New SpeechRecognitionEngine(New System.Globalization.CultureInfo("zh-CN"))
    End Sub

    Private Sub btnRecog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecog1.Click, btnRecog2.Click, btnRecog3.Click
        Dim dg As Grammar = Nothing
        If sender Is btnRecog1 Then dg = New Grammar("COMMANDS.xml", "OpWord2") '装入英文、数字命令语法
        If sender Is btnRecog2 Then dg = New Grammar("COMMANDS.xml", "OpSentence") '装入英文句子语法
        If sender Is btnRecog3 Then dg = New Grammar("COMMANDS.xml", "OpWord1") '装入中文命令语法
        Re.LoadGrammar(dg)
        Re.SetInputToDefaultAudioDevice()
        Re.RecognizeAsync(RecognizeMode.Multiple) '.Single
    End Sub

    Private Sub Re_AudioStateChanged(ByVal sender As Object, ByVal e As System.Speech.Recognition.AudioStateChangedEventArgs) Handles Re.AudioStateChanged
        'lstMessage.Items.Add(e.AudioState.ToString)
        'lstMessage.SelectedIndex = lstMessage.Items.Count - 1
        '保持继续识别状态
        If e.AudioState = AudioState.Stopped Then
            Re.RecognizeAsync(RecognizeMode.Single)
        End If
    End Sub

    Private Sub Re_SpeechDetected(ByVal sender As Object, ByVal e As System.Speech.Recognition.SpeechDetectedEventArgs) Handles Re.SpeechDetected
        'lstMessage.Items.Add("")
    End Sub
    Private Sub Re_SpeechHypothesized(ByVal sender As Object, ByVal e As System.Speech.Recognition.SpeechHypothesizedEventArgs) Handles Re.SpeechHypothesized
        If e.Result.Confidence > 0.9 Then   '可以保证识别正确率
            lstMessage.Items.Add(e.Result.Text)
            lstMessage.SelectedIndex = lstMessage.Items.Count - 1
        End If
    End Sub
    Private Sub Re_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles Re.RecognizeCompleted
        If e.Result Is Nothing Then Exit Sub
        lstMessage.Items.Add(e.Result.Text + "完成" + e.Result.Confidence)
        lstMessage.SelectedIndex = lstMessage.Items.Count - 1
    End Sub

End Class

