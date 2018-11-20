Imports System.Windows
Imports System.Reflection

Public Class clsUI
    Private grpUI As GroupBox
    Private Labels As List(Of Forms.Label)
    Private TextBoxs As List(Of Forms.TextBox)

    Public Sub New(student As clsStudent, grpUI As GroupBox)
        Me.grpUI = grpUI
        Me.Labels = New List(Of Forms.Label)
        Me.TextBoxs = New List(Of Forms.TextBox)

        Dim cp1 As clsCornerPoint = New clsCornerPoint(New Point(20, 40))
        Dim cp2 As clsCornerPoint = cp1.GetRight()
        Me.grpUI.SuspendLayout()
        CreateLabels(cp1, student)
        CreateTextBoxs(cp2, student)
        Me.grpUI.ResumeLayout(False)
        Me.grpUI.PerformLayout()
    End Sub

    Private Sub CreateLabels(cp As clsCornerPoint, student As clsStudent)
        Dim tp As Type = student.GetType()
        Dim Fields() As FieldInfo = tp.GetFields()

        Dim n As Integer = Fields.Count
        For i = 0 To n - 1
            Dim Label As Forms.Label = New Forms.Label
            Label.Name = "Label" & i
            Label.Location = cp.CornerPoint : Label.Size = New Size(40, 20)
            Label.Text = Fields(i).Name  '!!!!!
            cp = cp.GetBottom
            Labels.Add(Label)
            Me.grpUI.Controls.Add(Label)
        Next
    End Sub

    Private Sub CreateTextBoxs(cp As clsCornerPoint, student As clsStudent)
        Dim tp As Type = student.GetType()
        Dim Fields() As FieldInfo = tp.GetFields()
        Dim n As Integer = Fields.Count
        For i = 0 To n - 1
            Dim TextBox As Forms.TextBox = New Forms.TextBox
            TextBox.Name = "TextBox" & i
            TextBox.Location = cp.CornerPoint
            TextBox.Text = Fields(i).GetValue(student)  '!!!!!
            TextBox.Size = New System.Drawing.Size(100, 20)
            cp = cp.GetBottom
            TextBoxs.Add(TextBox)
            Me.grpUI.Controls.Add(TextBox)
        Next
    End Sub

    Public Sub Collect(student As clsStudent)
        Dim tp As Type = student.GetType()
        Dim Fields() As FieldInfo = tp.GetFields()
        Dim n As Integer = Fields.Count
        For i = 0 To n - 1
            Dim value As String = TextBoxs(i).Text ' Me.grpUI.Controls("TextBox" & i).Text
            Dim type As Type = Fields(i).FieldType
            Fields(i).SetValue(student, Convert.ChangeType(value, type))
        Next
    End Sub

End Class
