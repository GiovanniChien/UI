Imports System.Math

' 多边形：环的集合（环逆时针方向的环是外环，顺时针方向的环是内环） 
Public Class clsPolygon
    Private Rings As List(Of clsRing)
    Private Pen As Pen

    Sub New()
        Me.Pen = New Pen(Color.Black)
        Me.Rings = New List(Of clsRing)
        Dim Pts1 As New List(Of PointF)
        Pts1.Add(New PointF(100, 100))
        Pts1.Add(New PointF(200, 150))
        Pts1.Add(New PointF(300, 110))
        Pts1.Add(New PointF(300, 300))
        Pts1.Add(New PointF(100, 300))
        Rings.Add(New clsRing(Pts1))   '外环

        Dim x, y As Single
        Dim Pts2 As New List(Of PointF)
        For angle = 360 To 1 Step -60
            x = 20 * Cos(angle / 180 * PI)
            y = 20 * Sin(angle / 180 * PI)
            Pts2.Add(New PointF(150 + x, 200 + y))
        Next
        Rings.Add(New clsRing(Pts2))   '内环1

        Dim Pts3 As New List(Of PointF)
        For angle = 360 To 1 Step -45
            x = 20 * Cos(angle / 180 * PI)
            y = 20 * Sin(angle / 180 * PI)
            Pts3.Add(New PointF(250 + x, 200 + y))
        Next
        Rings.Add(New clsRing(Pts3))   '内环2
    End Sub

    Sub New(Rings As List(Of clsRing))
        Me.Pen = New Pen(Color.Black)
        Me.Rings = Rings
    End Sub

    Sub Draw(g As Graphics)
        For i = 0 To Rings.Count - 1
            Rings(i).Draw(g, Pen)
        Next
    End Sub

    Function Inside(p As PointF) As Boolean
        Return True
    End Function


End Class
