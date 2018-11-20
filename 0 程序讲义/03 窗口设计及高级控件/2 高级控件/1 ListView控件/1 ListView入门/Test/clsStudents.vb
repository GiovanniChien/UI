Public Class clsStudent
    Public ID As Integer
    Public Name As String
    Public Score As Single
    Public item As ListViewItem

    Public Sub New(ID As Integer, Name As String, Score As Single)
        Me.ID = ID : Me.Name = Name : Me.Score = Score
        Me.item = New ListViewItem(Me.ID.ToString, 0)
        Me.item.SubItems.Add(Name)
        Me.item.SubItems.Add(Score)
    End Sub
End Class

Public Class clsStudents
    Public Students As List(Of clsStudent)
    Public Items() As ListViewItem

    Public Sub New()
        Students = New List(Of clsStudent)
        Students.Add(New clsStudent(2, "AAA", 71))
        Students.Add(New clsStudent(1, "CCC", 72))
        Students.Add(New clsStudent(4, "BBB", 73))
        Students.Add(New clsStudent(3, "DDD", 74))
        ReDim Items(Students.Count - 1)
        For i = 0 To Students.Count - 1
            Items(i) = Students(i).item
        Next
    End Sub

    Public Sub ListView_Init(lvItem As ListView)
        Dim ColumnHeaders As ListView.ColumnHeaderCollection
        ColumnHeaders = New ListView.ColumnHeaderCollection(lvItem)
        ColumnHeaders.Add("学号")
        ColumnHeaders.Add("姓名")
        ColumnHeaders.Add("成绩")
        With lvItem
            .View = View.Details
            .LabelEdit = True
            .AllowColumnReorder = True
            .CheckBoxes = False
            .FullRowSelect = True
            .GridLines = True
            .Sorting = SortOrder.None
        End With
    End Sub
    Public Sub ListView_Display(lvItem As ListView)
        lvItem.Items.Clear()
        lvItem.Items.AddRange(Items)
    End Sub

    Sub Sort(Columnid As Integer)
        Dim compare As StudentComparer = New StudentComparer(Columnid)
        Array.Sort(Items, compare)
    End Sub

End Class
