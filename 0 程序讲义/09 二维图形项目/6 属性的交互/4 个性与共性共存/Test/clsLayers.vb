Public Class clsLayers
    Private Layers As List(Of clsLayer)
    Private ActiveLayer As clsLayer

    Event Redraw()

    Public Sub New()
        Layers = New List(Of clsLayer)
        ActiveLayer = Nothing
    End Sub
    Public Property Active As clsLayer
        Get
            Return ActiveLayer
        End Get
        Set(ByVal Layer As clsLayer)
            If Layers.Contains(Layer) Then
                ActiveLayer = Layer
            End If
        End Set
    End Property

    Public Sub Append(ByVal Layer As clsLayer)
        Layers.Add(Layer)
    End Sub
    Public Function Count() As Integer
        Return Layers.Count
    End Function
    Public Function Item(ByVal index As Integer) As clsLayer
        Return Layers(index)
    End Function

    Public Sub SetShow(ByVal index As Integer)
        Layers.Item(index).Show = Not Layers.Item(index).Show
        RaiseEvent Redraw()
    End Sub
End Class
