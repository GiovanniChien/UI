Imports System.Math

' 多边形：环的集合（环逆时针方向的环是外环，顺时针方向的环是内环） 
Public Class clsPolygon
    Private Rings As List(Of clsRing)
    Public Box As clsBox
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
        Me.Rings.Add(New clsRing(Pts1))   '外环

        Dim x, y As Single
        Dim Pts2 As New List(Of PointF)
        For angle = 360 To 1 Step -60
            x = 20 * Cos(angle / 180 * PI)
            y = 20 * Sin(angle / 180 * PI)
            Pts2.Add(New PointF(150 + x, 200 + y))
        Next
        Me.Rings.Add(New clsRing(Pts2))   '内环1

        Dim Pts3 As New List(Of PointF)
        For angle = 360 To 1 Step -45
            x = 20 * Cos(angle / 180 * PI)
            y = 20 * Sin(angle / 180 * PI)
            Pts3.Add(New PointF(250 + x, 200 + y))
        Next
        Me.Rings.Add(New clsRing(Pts3))   '内环2
        Me.Box = New clsBox(Rings(0).Box)
        For i = 1 To Rings.Count - 1
            Me.Box.Contain((Rings(i).Box))
        Next
    End Sub

    Sub New(Rings As List(Of clsRing))
        Me.Pen = New Pen(Color.Black)
        Me.Rings = Rings
        Me.Box = New clsBox(Rings(0).Box)
        For i = 1 To Rings.Count - 1
            Me.Box.Contain((Rings(i).Box))
        Next
    End Sub

    Sub Draw(g As Graphics)
        For i = 0 To Rings.Count - 1
            Rings(i).Draw(g, Pen)
        Next
    End Sub

    Function Inside(p As PointF) As Boolean
        '水平射线： p -> ep 的线段
        Dim ep As PointF = New PointF(p.X + 2 * Box.Wx, p.Y)
        ' 该射线的参数方程对象
        Dim RayLine As clsParaEquation = New clsParaEquation(p, ep)
        Dim IpCount As Integer = 0
        For i = 0 To Rings.Count - 1
            IpCount += Rings(i).GetIpCount(RayLine)
        Next
        If IpCount Mod 2 = 1 Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
