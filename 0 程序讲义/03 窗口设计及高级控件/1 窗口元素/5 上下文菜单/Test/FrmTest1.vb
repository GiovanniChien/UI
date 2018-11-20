Imports System.Math
Imports Microsoft.VisualBasic
Public Class FrmTest1

    Private Sub FrmTest1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Double
        x = Log(10)
        MsgBox(x)
        Dim s As String
        s = "abcdef"
        MsgBox(Microsoft.VisualBasic.Left(s, 2))
    End Sub
End Class