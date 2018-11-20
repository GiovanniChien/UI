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
    Private box As clsBox

    Public Sub New(fname As String)
        box = Nothing
        Dim Line As String, xyz(2) As String
        Using fs As New IO.FileStream(fname, FileMode.Open, FileAccess.Read)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                For i = 0 To 19
                    Line = sr.ReadLine()
                    xyz = Line.Split(" ")
                    Points(i) = New clsSkeletonPoint(xyz)
                    If box Is Nothing Then
                        box = New clsBox(Points(i))
                    Else
                        box.Contain(Points(i))
                    End If
                Next
            End Using
        End Using
    End Sub

    Public Sub Draw(picCanvas As PictureBox, Kind As ViewKind)
        ' 准备用于显示的点坐标
        Dim vp(19) As PointF
        Dim windowrect As RectangleF = box.GetRect(Kind)
        'Dim viewrect As RectangleF = New RectangleF(0, picCanvas.Height, picCanvas.Width, -picCanvas.Height)
        Dim viewrect As RectangleF = New RectangleF(picCanvas.Width / 2, picCanvas.Height / 2, picCanvas.Width / 4, -picCanvas.Height / 4)
        Dim M As clsMatrix3 = New clsMatrix3
        M.SetWindowView(windowrect, viewrect)
        For i = 0 To 19
            If Kind = ViewKind.XY Then vp(i).X = Points(i).x : vp(i).Y = Points(i).y
            If Kind = ViewKind.XZ Then vp(i).X = Points(i).x : vp(i).Y = Points(i).z
            If Kind = ViewKind.YZ Then vp(i).X = Points(i).y : vp(i).Y = Points(i).z
        Next
        M.Tranform(vp)

        ' 分段绘制骨骼
        Dim g As Graphics = picCanvas.CreateGraphics()
        g.Clear(picCanvas.BackColor)
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
        g.Flush()
    End Sub

End Class
