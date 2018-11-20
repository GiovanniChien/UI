Public Class ctrInput
    Public Data As Object
    Dim UI As clsUI

    Public Sub SetData(Data As Object)
        Me.Data = Data
        UI = New clsUI(Data, Me)
    End Sub

    Public Function GetData() As Object
        UI.Collect(Data)
        Return Data
    End Function

    Private Sub ctrInput_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
