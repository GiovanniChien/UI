' 对图形对象的所有操作，都是经过选集对象进行的
Public Class clsSelection
    Private Elems As List(Of clsElem)  ' 被选择的图形对象的集合

    Public Sub New()
        Elems = New List(Of clsElem)
    End Sub
    Public Sub Clear()
        Elems.Clear()
    End Sub

    ' 对选集的管理：添加、移除、判断
    Public Sub Append(ByVal Elem As clsElem) '向选集中添加Elem
        Elems.Add(Elem)
    End Sub
    Public Sub Remove(ByVal Elem As clsElem) '从选集中移除Elem
        Elems.Remove(Elem)
    End Sub
    '若Elem在选集中，则Elem移除选集；若Elem不在选集中，则将Elem加入选集
    Public Sub DoSelect(ByVal Elem As clsElem)
        If Elems.Contains(Elem) Then
            Elems.Remove(Elem)
        Else
            Elems.Add(Elem)
        End If
    End Sub
    Function Contains(ByVal elem As clsElem) As Boolean
        Return Elems.Contains(elem)
    End Function
    Public Function Count() As Integer
        Return Elems.Count
    End Function

    '' 对图形对象集合的管理：变换、删除
    'Public Sub Delete(ByVal Elem As clsElem) '从选集中移除Elem，并删除Elem
    '    Elems.Remove(Elem)
    '    '？？？？？
    'End Sub
    'Public Sub Transform(ByVal m As clsMatrix)
    '    For i = 0 To Elems.Count - 1
    '        Elems(i).Transform(m)
    '    Next
    'End Sub

End Class
