Imports System.Drawing

Public Class clsPLine
    Private Points As List(Of Point)

    Public Sub New(ByVal Points As List(Of Point))
        Me.Points = Points
    End Sub

    Public Sub Draw(ByVal g As Graphics, ByVal color As Color)
        Dim pen As Pen = New Pen(color, 1)
        g.DrawLines(pen, Points.ToArray)
    End Sub

End Class
