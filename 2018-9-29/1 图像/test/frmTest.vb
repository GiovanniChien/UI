Imports System.IO

Public Class frmTest
    Dim picFileNames As List(Of String)
    Dim index As Integer

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click, btnNext.Click
        If sender Is btnPrev Then
            If index <> 0 Then index -= 1
        Else
            If index <> picFileNames.Count - 1 Then index += 1
        End If
        Display(index)
    End Sub

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        picFileNames = New List(Of String)
        Dim jpgs() As String = Directory.GetFiles("D:\00UI_2018-09-20-12-47-03\9-29\picture", "*.jpg")
        picFileNames.AddRange(jpgs)
        index = 0
    End Sub

    Private Sub Display(ByVal index As Integer)
        Dim buff As Bitmap
        buff = New Bitmap(picFileNames(index))
        picBox.Image = buff
    End Sub

End Class
