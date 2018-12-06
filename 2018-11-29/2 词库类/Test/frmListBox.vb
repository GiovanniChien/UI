Imports System.IO

Public Class frmListBox
    Dim Words As List(Of String) = New List(Of String)
    Private LastChars As String
    Public Event WordSelected(ByVal Word As String)
    Public Event CharPress(ByVal C As Char)

    Private Sub frmListBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim content As String
        Using fs As New IO.FileStream("Words.txt", FileMode.Open)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                content = sr.ReadToEnd()
            End Using
        End Using
        Dim separator() As Char = {vbLf, vbCr}
        Words = content.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList
    End Sub

    Public Sub WordListInit(ByVal LastChars As String)
        Me.LastChars = LastChars
        lstWords.Items.Clear()
        Dim len As Integer = Me.LastChars.Length
        For i = 0 To Words.Count - 1
            If Words(i).Length >= len Then
                If Words(i).StartsWith(LastChars) Then
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

    Private Sub lstWords_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstWords.KeyPress
        If Asc(e.KeyChar) = ConsoleKey.Escape Then
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
        Dim len As Integer = Me.LastChars.Length
        For i = 0 To lstWords.Items.Count - 1
            If lstWords.Items(i).ToString.Length >= len Then
                If lstWords.Items(i).ToString.StartsWith(LastChars) Then
                    lstWords.SelectedIndex = i
                    RaiseEvent CharPress(e.KeyChar)
                    Return
                End If
            End If
        Next
        RaiseEvent CharPress(e.KeyChar)
        Me.LastChars = "" : Me.Hide()
    End Sub

    Private Function GetRestChars(ByVal Word As String, ByVal LastChars As String) As Object
        Return Word.Substring(LastChars.Length)
    End Function

End Class