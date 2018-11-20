Imports System.Math

Public Class clsLineSegement
    Private sp, ep As PointF
    '线段的参数方程：  1>=t>=0
    ' x= sp.x+ (ep.x-sp.x) * t
    ' y= sp.y+ (ep.y-sp.y) * t
    Public Sub New(sp As PointF, ep As PointF)
        Me.sp = sp : Me.ep = ep
    End Sub

    '计算当前线段与射线ray的交点，在射线中的t值
    Function GetXp(ray As clsLineSegement) As Single
        Dim a As Single = Me.ep.X - Me.sp.X
        Dim b As Single = Me.ep.Y - Me.sp.Y
        Dim c As Single = ray.ep.X - ray.sp.X
        Dim d As Single = ray.ep.Y - ray.sp.Y
        If a * d - b * c = 0 Then
            Return -1 '  平行线无交点
        End If
        Dim t2 As Single = (b * (ray.sp.X - Me.sp.X) - a * (ray.sp.Y - Me.sp.Y)) / (a * d - b * c)
        Dim t1 As Single
        If Abs(a) > Abs(b) Then
            t1 = (ray.sp.X - Me.sp.X + c * t2) / a
        Else
            t1 = (ray.sp.Y - Me.sp.Y + d * t2) / b
        End If
        ' t1是当前线段中的参数，t2是线段Line中的参数
        If t1 >= 0 And t1 <= 1 And t2 >= 0 Then
            Return t2
        Else
            Return -1
        End If
    End Function

    Function Value(t As Single) As PointF
        Dim xp As PointF
        xp.X = sp.X + (ep.X - sp.X) * t
        xp.Y = sp.Y + (ep.Y - sp.Y) * t
        Return xp
    End Function
    '从Value(0)到Value(t)的距离
    Function Dist(t As Single) As Single
        Dim p As PointF = Value(t)
        Return Sqrt((p.X - sp.X) * (p.X - sp.X) + (p.Y - sp.Y) * (p.Y - sp.Y))
    End Function

End Class
