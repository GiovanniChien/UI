' 块：保管着被选择的图形对象的副本的集合 
Public Class clsBlock
    Private Elems As List(Of clsElem)
    Private BasePoint As PointF

    Public Sub New(ByVal Elems As clsSelection, ByVal BasePoint As PointF)
        Me.Elems = Elems.Clone
        Me.BasePoint = BasePoint
    End Sub

    Public Function Count() As Integer
        Return Elems.Count
    End Function
    Public Function Item(ByVal index As Integer) As clsElem
        Return Elems(index)
    End Function
    Public Function GetBasePoint() As PointF
        Return BasePoint
    End Function
End Class

