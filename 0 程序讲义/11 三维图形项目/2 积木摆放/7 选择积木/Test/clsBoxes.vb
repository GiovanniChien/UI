Imports OpenTK
Imports System.IO

Public Class BoxComparer
    Implements IComparer(Of clsBox)

    Public Function Compare(x As clsBox, y As clsBox) As Integer Implements IComparer(Of clsBox).Compare
        Dim xzb As Single = x.Volume, yzb As Single = y.Volume
        If xzb < yzb Then
            Return 1
        Else
            If xzb = yzb Then
                Return 0
            Else
                Return -1
            End If
        End If
    End Function

End Class

Public Class clsBoxes
    Private boxes As List(Of clsBox)

    Public Sub New(Optional n As Integer = 0)
        boxes = New List(Of clsBox)
        For i = 1 To n
            boxes.Add(New clsBox(New Vector3(-1, -1, -1), 0.1 + Rnd() * 0.3, 0.1 + Rnd() * 0.3, 0.1 + Rnd() * 0.3))
        Next
        Sort()
    End Sub

    Public Function Count() As Integer
        Return boxes.Count
    End Function
    Public Sub Sort()
        Dim comparer As BoxComparer = New BoxComparer
        boxes.Sort(comparer)
    End Sub

    Public Sub Draw()
        For i = 0 To boxes.Count - 1
            boxes(i).Draw()
        Next
    End Sub

    Function Arrange(Spaces As clsSpaces) As clsBoxes
        Dim Accept As clsBoxes = New clsBoxes
        For i = 0 To boxes.Count - 1
            Dim arrangei As Arrangement = Spaces.Arrange(boxes(i))
            If arrangei.Flag = True Then
                Accept.boxes.Add(boxes(i))
            End If
        Next
        For i = 0 To Accept.boxes.Count - 1
            boxes.Remove(Accept.boxes(i))
        Next
        Return Accept
    End Function

    Public Function Volume() As Single
        Dim V As Single = 0
        For i = 0 To boxes.Count - 1
            V += boxes(i).Volume
        Next
        Return V
    End Function

    Sub Save(fname As String)
        Using fs As New IO.FileStream(fname, FileMode.Create)
            Using sw As New StreamWriter(fs, System.Text.Encoding.Default)
                sw.WriteLine(boxes.Count)
                For i = 0 To boxes.Count - 1
                    sw.WriteLine(boxes(i).ToString)
                Next
            End Using
        End Using
    End Sub

    Function SelectbyEyeLight(ByVal near As Vector3, ByVal far As Vector3) As clsBox
        For i = 0 To boxes.Count - 1
            If boxes(i).ExistXP(near, far) = True Then
                Return boxes(i)
            End If
        Next
    End Function

End Class
