Public MustInherit Class clsElem
    Public Layer As clsLayer          ' 共性
    Public Properties As clsProperty  ' 个性

    Public MustOverride Sub Draw(ByVal g As Graphics)

    Public Sub New(ByVal Layer As clsLayer, ByVal Properties As clsProperty)
        Me.Layer = Layer
        Me.Properties = Properties
    End Sub

    Protected ReadOnly Property Pen
        Get
            If Properties Is Nothing Then
                Return Layer.Properties.Pen   ' 彰显个性
            Else
                Return Properties.Pen         ' 遵循共性 
            End If
        End Get
    End Property

    Public Sub SetProperty(ByVal Properties As clsProperty)
        Me.Properties = Properties   ' 设置个性
    End Sub
    Public Sub SetLayer(Optional ByVal Layer As clsLayer = Nothing)
        Me.Properties = Nothing      ' 取消个性 
        If Layer IsNot Nothing Then
            Me.Layer = Layer
        End If
    End Sub

End Class

