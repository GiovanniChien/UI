Imports System.IO

Public Class frmTest
    Dim Students As clsStudents

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Students = New clsStudents
    End Sub

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Students.ListView_Init(lvStudent)
        Students.ListView_Display(lvStudent)
    End Sub
    '通过 IComparer 接口对项进行排序，并使用 ArrayList 的 Sort 方法。
    Private Sub ListView1_ColumnClick(sender As System.Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lvStudent.ColumnClick
        Dim Columnid As Integer = e.Column
        Students.Sort(Columnid)
        Students.ListView_Display(lvStudent)
    End Sub

End Class

