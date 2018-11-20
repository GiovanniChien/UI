Imports System.Speech
Imports System.Speech.Recognition

'问题1：听写效果不好
'问题2：没有尝试控制“听写完成时”的参数：大约是安静多长时间，表示“听写完成”
'问题3：听写开始的噪音阶段，应该如何排除？
'问题4：通过控制面板中的语音训练，可以到达较好的效果。但如何在程序中达到听写“方言”的效果，没有进展

Public Class frmDictation
    Dim WithEvents Re As SpeechRecognitionEngine

    Private Sub frmDictation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Re = New SpeechRecognitionEngine(New System.Globalization.CultureInfo("zh-CN"))
        ' Dim info As RecognizerInfo = Re.RecognizerInfo   '用于了解识别引擎的配置
        Dim dg As DictationGrammar = New DictationGrammar()
        'Re.LoadGrammar(dg)
    End Sub

    Private Sub btnRecog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecog1.Click, btnRecog2.Click
        '"It is nice day. We are going to school."
        If sender Is btnRecog1 Then
            Re.SetInputToWaveFile("Test3.wav")    '识别语音文件中的文本
        Else
            Re.SetInputToDefaultAudioDevice()    '识别人音中的文本
        End If
        Re.RecognizeAsync(RecognizeMode.Multiple) 'Multiple  Single
    End Sub

    Private Sub Re_SpeechDetected(ByVal sender As Object, ByVal e As System.Speech.Recognition.SpeechDetectedEventArgs) Handles Re.SpeechDetected
        txtContent.Text = ""
    End Sub

    '识别中的识别结果
    Private Sub Re_SpeechHypothesized(ByVal sender As Object, ByVal e As System.Speech.Recognition.SpeechHypothesizedEventArgs) Handles Re.SpeechHypothesized
        txtContent.Text = e.Result.Text & "(" & e.Result.Confidence & ")"
    End Sub
    '识别完成时的识别结果
    Private Sub Re_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles Re.RecognizeCompleted
        'txtContent.Text = e.Result.Text + "ok" & "(" & e.Result.Confidence & ")"
    End Sub

End Class
