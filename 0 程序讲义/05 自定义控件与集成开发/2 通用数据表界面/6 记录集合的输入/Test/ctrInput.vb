Public Class ctrInput
    Public Data As Object
    Dim UI As clsUI

    Public Sub SetData(Data As Object)
        Me.Data = Data
        If UI Is Nothing Then
            UI = New clsUI(Data, Me)
        Else
            UI.SetData(Data)
        End If
    End Sub

    Public Function GetData() As Object
        UI.Collect(Data)
        Return Data
    End Function

End Class
