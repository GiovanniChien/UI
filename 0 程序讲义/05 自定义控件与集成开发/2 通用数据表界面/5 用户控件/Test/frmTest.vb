Imports System.Windows
Imports System.Reflection

Public Class frmTest
    Dim student As clsStudent
    Dim book As clsBook

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        student = New clsStudent
        book = New clsBook
        CtrInputStudent.SetData(student)
        CtrInputBook.SetData(book)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        student = CtrInputStudent.GetData()
        book = CtrInputBook.GetData()
        MsgBox(student.ToString)
        MsgBox(book.ToString)
    End Sub

End Class
