Imports System.IO

Public Enum ViewKind
    XY
    XZ
    YZ
End Enum

Public Class clsSkeleton
    '0  HipCenter（臀部中心）      Spine（脊柱）,      ShoulderCenter    Head,          
    '4  ShoulderLeft   ElbowLeft   WristLeft   HandLeft,       
    '8  ShoulderRight  ElbowRight  WristRight  HandRight
    '12 HipLeft,       KneeLeft,      AnkleLeft,     FootLeft
    '16 HipRight,      KneeRight,     AnkleRight,    FootRight
    Private Points(19) As clsSkeletonPoint

    Public Sub New(fname As String)
        Dim Line As String, xyz(2) As String
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

    Public Sub Draw(picCanvas As PictureBox, viewKind As ViewKind)
        ' 准备用于显示的点坐标
        Dim vp(19) As PointF
        If viewKind = Test.ViewKind.XY Then
            For i = 0 To 19
                vp(i).X = Points(i).x : vp(i).Y = Points(i).y
            Next
        End If
        If viewKind = Test.ViewKind.XZ Then
            For i = 0 To 19
                vp(i).X = Points(i).x : vp(i).Y = Points(i).z
            Next
        End If
        If viewKind = Test.ViewKind.YZ Then
            For i = 0 To 19
                vp(i).X = Points(i).y : vp(i).Y = Points(i).z
            Next
        End If
        For i = 0 To 19
            vp(i).X = 100 * vp(i).X : vp(i).Y = 100 * vp(i).Y
        Next

        ' 分段绘制骨骼
        Dim g As Graphics = picCanvas.CreateGraphics()
        Dim pen As Pen = New Pen(Brushes.Black)
        For i = 0 To 2
            g.DrawLine(pen, vp(i), vp(i + 1))
        Next
        For i = 4 To 6
            g.DrawLine(pen, vp(i), vp(i + 1))
        Next
        For i = 8 To 10
            g.DrawLine(pen, vp(i), vp(i + 1))
        Next
        For i = 12 To 14
            g.DrawLine(pen, vp(i), vp(i + 1))
        Next
        For i = 16 To 18
            g.DrawLine(pen, vp(i), vp(i + 1))
        Next
    End Sub

End Class
