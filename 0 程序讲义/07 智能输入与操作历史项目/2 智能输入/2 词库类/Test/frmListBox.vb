Imports System.IO

' 单词表窗口: 
' 1 读文件，初始化词库
' 2 显示最接近的单词集； 
' 3 接受输入的字符，将其传入主窗口的文本框中，同时调整当前选项的位置； 
' 4 接受空格字符，表示选定当前选项，并将选定单词传入主窗口的文本框中； 

Public Class frmListBox
    Dim Words() As String        ' 词库
    Private LastChars As String  ' 主窗口中正在输入的单词，已经输入的部分
    Public Event WordSelected(Word As String)
    Public Event CharPress(C As Char)

    ' 1 读文件，初始化词库
    Private Sub frmListBox_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim content As String
        Using fs As New IO.FileStream("Words.txt", FileMode.Open)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                content = sr.ReadToEnd()
            End Using
        End Using
        Dim separator() As Char = {vbLf, vbCr}
        Words = content.Split(separator, StringSplitOptions.RemoveEmptyEntries)
    End Sub

    ' 2 显示最接近的单词集； 
    Public Sub WordListInit(LastChars As String)
        Me.LastChars = LastChars
        lstWords.Items.Clear()
        Dim len As Integer = Me.LastChars.Length()
        For i = 0 To Words.Count - 1
            If Words(i).Length >= len Then
                If Words(i).Substring(0, len) = LastChars Then
                    lstWords.Items.Add(Words(i))
                End If
            End If
        Next
        If lstWords.Items.Count = 0 Then
            Me.Hide()
        Else
            lstWords.SelectedIndex = 0
        End If
    End Sub

    ' 3 接受输入的字符，将其传入主窗口的文本框中，同时调整当前选项的位置； 
    ' 4 接受空格字符，表示选定当前选项，并将选定单词传入主窗口的文本框中； 
    Private Sub lstWords_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lstWords.KeyPress
        If Asc(e.KeyChar) = ConsoleKey.Escape Then   'Esc键：关闭单词表窗口
            Me.LastChars = "" : Me.Hide()
            Return
        End If

        If e.KeyChar = " " Then
            Dim Word As String = lstWords.Text
            RaiseEvent WordSelected(GetRestChars(lstWords.Text, Me.LastChars))
            Me.LastChars = "" : Me.Hide()
            Return
        End If

        Me.LastChars = Me.LastChars & e.KeyChar
        Dim len As Integer = Me.LastChars.Length()
        For i = 0 To lstWords.Items.Count - 1
            If lstWords.Items(i).ToString.Length >= len Then
                If lstWords.Items(i).ToString.Substring(0, len) = LastChars Then
                    lstWords.SelectedIndex = i
                    RaiseEvent CharPress(e.KeyChar) '输入词库中单词中的字符
                    Return
                End If
            End If
        Next
        RaiseEvent CharPress(e.KeyChar)  '输入单词不在词库中
        Me.LastChars = "" : Me.Hide()
    End Sub

    Private Function GetRestChars(word As String, preword As String) As String
        Return word.Substring(preword.Length)
    End Function
End Class