Imports System.IO

Public Class clsPointCloud
    Private Points As List(Of clsPoint)
    Private box As clsBox

    Public Sub New(fname As String)
        Points = New List(Of clsPoint)
        box = Nothing
        Dim Line As String, xyzargb(6) As String
        Using fs As New IO.FileStream(fname, FileMode.Open, FileAccess.Read)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                Dim i As Integer = 0
                While Not sr.EndOfStream
                    Line = sr.ReadLine()
                    xyzargb = Line.Split(" ")
                    Points.Add(New clsPoint(xyzargb))
                    If box Is Nothing Then
                        box = New clsBox(Points(i).x, Points(i).y, Points(i).z)
                    Else
                        box.Contain(Points(i).x, Points(i).y, Points(i).z)
                    End If
                End While
            End Using
        End Using
    End Sub

End Class
