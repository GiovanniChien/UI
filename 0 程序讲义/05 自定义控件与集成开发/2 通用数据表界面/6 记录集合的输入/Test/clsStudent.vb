Public Class clsStudent
    Public id As Integer
    Public name As String
    Public score As Single

    Public Sub New()
        Me.id = 101
        Me.name = "aaa"
        Me.score = 99.9
    End Sub
    Public Sub New(id As Integer, name As String, score As Single)
        Me.id = id
        Me.name = name
        Me.score = score
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = id
        s = s & vbTab & name
        s = s & vbTab & score
        Return s
    End Function

End Class

Public Class clsStudents
    Private Students As List(Of clsStudent)

    Public Sub New()
        Students = New List(Of clsStudent)
        Students.Add(New clsStudent(101, "aaa", 95.5))
        Students.Add(New clsStudent(102, "bbb", 85.5))
        Students.Add(New clsStudent(103, "ccc", 75.5))
    End Sub

    Public Sub Display(lst As ListBox)
        lst.Items.Clear()
        For i = 0 To Students.Count
            lst.Items.Add(Students(i).ToString())
        Next
    End Sub
    Public Function Count() As Integer
        Return Students.Count
    End Function
    Public Function Item(index As Integer) As clsStudent
        Return Students(index)
    End Function

    Public Sub SetData(Index As Integer, Student As clsStudent)
        Students(Index) = Student
    End Sub

End Class
