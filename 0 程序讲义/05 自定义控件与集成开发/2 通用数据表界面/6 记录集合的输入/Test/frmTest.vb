Imports System.Windows
Imports System.Reflection

Public Class frmTest
    Dim Students As clsStudents, Student As clsStudent
    Dim LastSelectedIndex As Integer

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Students = New clsStudents
        For i = 0 To Students.Count - 1
            lstStudent.Items.Add(Students.Item(i).ToString)
        Next
        LastSelectedIndex = -1 : Student = Nothing
        lstStudent.SelectedIndex = 0
    End Sub

    Private Sub lstStudent_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstStudent.SelectedIndexChanged
        If Student IsNot Nothing Then
            '保存当前对象的数据
            Student = CtrInputStudent.GetData()
            Students.SetData(LastSelectedIndex, Student)
            lstStudent.Items(LastSelectedIndex) = Student.ToString
        End If
        '显示新的当前对象
        LastSelectedIndex = lstStudent.SelectedIndex
        Student = Students.Item(lstStudent.SelectedIndex)
        CtrInputStudent.SetData(Student)
    End Sub

End Class
