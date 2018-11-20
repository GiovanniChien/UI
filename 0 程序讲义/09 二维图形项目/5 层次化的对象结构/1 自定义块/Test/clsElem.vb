Public MustInherit Class clsElem
    Protected CommonPen, SelectedPen As Pen

    Public MustOverride Sub Draw(ByVal g As Graphics, Optional ByVal isSelectElem As Boolean = False)
    Public MustOverride Sub Draw(ByVal g As Graphics, ByVal M As clsMatrix3, Optional ByVal isSelectElem As Boolean = False)
    Public MustOverride Function SelectByPoint(ByVal p As PointF) As Boolean
    Public MustOverride Sub Transform(m As clsMatrix3)
    Public MustOverride Function Clone() As clsElem

    Public Sub New()
        CommonPen = New Pen(Color.Blue, 1)
        SelectedPen = New Pen(Color.Red, 1)
    End Sub
End Class

