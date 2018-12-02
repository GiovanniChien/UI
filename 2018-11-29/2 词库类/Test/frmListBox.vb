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

    End Sub
End Class