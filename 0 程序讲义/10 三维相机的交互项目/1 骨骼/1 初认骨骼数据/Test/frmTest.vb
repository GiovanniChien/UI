Imports System.IO

Public Class frmTest

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim fname As String = My.Application.Info.DirectoryPath & "\d\1s.txt"
        Dim Line As String, xyz(2) As String
        Dim Points(19) As clsSkeletonPoint
        Using fs As New IO.FileStream(fname, FileMode.Open, FileAccess.Read)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                For i = 0 To 19
                    Line = sr.ReadLine()
                    xyz = Line.Split(" ")
                    Points(i) = New clsSkeletonPoint(xyz)
                Next
            End Using
        End Using
    End Sub

    Private Sub rad_Click(sender As System.Object, e As System.EventArgs) Handles radXY.Click, radXZ.Click, radYZ.Click
        If radXY.Checked = True Then Draw(ViewKind.XY)
        If radXZ.Checked = True Then Draw(ViewKind.XZ)
        If radYZ.Checked = True Then Draw(ViewKind.YZ)
    End Sub

    Enum ViewKind
        XY
        XZ
        YZ
    End Enum
    Private Sub Draw(viewKind As ViewKind)
        Throw New NotImplementedException
    End Sub

End Class
