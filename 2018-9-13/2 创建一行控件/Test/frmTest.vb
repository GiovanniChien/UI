Public Class frmTest

    Dim Buttons As List(Of Button)
    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Buttons = New List(Of Button)
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim n As Integer = txtNumber.Text
        For i = 0 To n - 1
            Dim Button1 As New Button
            Button1.Name = "Button" & i
            Button1.Size = New System.Drawing.Size(30, 30)
            Button1.Location = New System.Drawing.Point(10 + 40 * i, 50)
            ' !!!!!
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

