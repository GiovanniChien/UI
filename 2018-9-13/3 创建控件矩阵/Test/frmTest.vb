Public Class frmTest

    Dim Buttons As List(Of Button)
    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Buttons = New List(Of Button)
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim Width As Integer = 30
        Dim dx As Integer = 10, dy As Integer = 10
        Dim Row As Integer = txtRow.Text
        Dim Col As Integer = txtCol.Text
        For k = 0 To Row * Col - 1
            Dim i As Integer = Fix(k / Col), j As Integer = k Mod Col
            Dim Button1 As New Button
            Button1.Name = "Button " & i & " " & j
            Button1.Size = New System.Drawing.Size(30, 30)
            Button1.Location = New System.Drawing.Point(dy + j * (dy + Width), dx + i * (dx + Width))
            AddHandler Button1.Click, AddressOf Buttons_Click1
            Buttons.Add(Button1)
        Next
        For i = 0 To Buttons.Count - 1
            Me.Controls.Add(Buttons(i))
        Next
    End Sub

    Private Sub Buttons_Click1(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox(sender.Name)
    End Sub

End Class


'

