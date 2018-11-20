Imports System.Windows
Imports System.Reflection

Public Class frmTest
    Dim student As clsStudent
    Dim ui As clsUI

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        student = New clsStudent
        ui = New clsUI(student, grpUI)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        ui.Collect(student)
        MsgBox(student.ToString)
    End Sub

End Class
