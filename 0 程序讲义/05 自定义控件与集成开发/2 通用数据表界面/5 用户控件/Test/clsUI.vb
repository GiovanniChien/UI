Imports System.Windows
Imports System.Reflection

Public Class clsUI
    Private Container As UserControl
    Private Labels As List(Of Forms.Label)
    Private TextBoxs As List(Of Forms.TextBox)

    Public Sub New(data As Object, Container As UserControl)
        Me.Container = Container
        Me.Labels = New List(Of Forms.Label)
        Me.TextBoxs = New List(Of Forms.TextBox)

        Dim cp1 As clsCornerPoint = New clsCornerPoint(New Point(20, 40))
        Dim cp2 As clsCornerPoint = cp1.GetRight()
        Me.Container.SuspendLayout()
        CreateLabels(cp1, data)
        CreateTextBoxs(cp2, data)
        Me.Container.ResumeLayout(False)
        Me.Container.PerformLayout()
    End Sub

    Private Sub CreateLabels(cp As clsCornerPoint, data As Object)
        Dim tp As Type = data.GetType()
        Dim Fields() As FieldInfo = tp.GetFields()

        Dim n As Integer = Fields.Count
        For i = 0 To n - 1
            Dim Label As Forms.Label = New Forms.Label
            Label.Name = "Label" & i
            Label.Location = cp.CornerPoint : Label.Size = New Size(40, 20)
            Label.Text = Fields(i).Name  '!!!!!
            cp = cp.GetBottom
            Labels.Add(Label)
            Me.Container.Controls.Add(Label)
        Next
    End Sub

    Private Sub CreateTextBoxs(cp As clsCornerPoint, data As Object)
        Dim tp As Type = data.GetType()
        Dim Fields() As FieldInfo = tp.GetFields()
        Dim n As Integer = Fields.Count
        For i = 0 To n - 1
            Dim TextBox As Forms.TextBox = New Forms.TextBox
            TextBox.Name = "TextBox" & i
            TextBox.Location = cp.CornerPoint
            TextBox.Text = Fields(i).GetValue(data)  '!!!!!
            TextBox.Size = New System.Drawing.Size(100, 20)
            cp = cp.GetBottom
            TextBoxs.Add(TextBox)
            Me.Container.Controls.Add(TextBox)
        Next
    End Sub

    Public Sub Collect(data As Object)
        Dim tp As Type = data.GetType()
        Dim Fields() As FieldInfo = tp.GetFields()
        Dim n As Integer = Fields.Count
        For i = 0 To n - 1
            Dim value As String = TextBoxs(i).Text ' Me.grpUI.Controls("TextBox" & i).Text
            Dim type As Type = Fields(i).FieldType
            Fields(i).SetValue(data, Convert.ChangeType(value, type))
        Next
    End Sub

End Class
