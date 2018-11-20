Public Class clsCS2
    Private DBox As clsBox2   '设备坐标的范围
    Private LBox As clsBox2   '逻辑坐标的范围
    Private M_Lp2Dp, M_Dp2Lp As clsMatrix3
    Public myPen As Pen

    Public Sub New(DBox As clsBox2, LBox As clsBox2)
        Me.DBox = New clsBox2(DBox) : Me.LBox = New clsBox2(LBox)
        Dim a, b, c, d As Single
        a = (DBox.xmax - DBox.xmin) / (LBox.xmax - LBox.xmin) : b = DBox.xmin - a * LBox.xmin
        c = (DBox.ymax - DBox.ymin) / (LBox.ymax - LBox.ymin) : d = DBox.ymin - c * LBox.ymin
        M_Lp2Dp = New clsMatrix3(a, b, c, d)
        a = (LBox.xmax - LBox.xmin) / (DBox.xmax - DBox.xmin) : b = LBox.xmin - a * DBox.xmin
        c = (LBox.ymax - LBox.ymin) / (DBox.ymax - DBox.ymin) : d = LBox.ymin - c * DBox.ymin
        M_Dp2Lp = New clsMatrix3(a, b, c, d)
    End Sub

    Public Sub Draw(g As Graphics)
        Dim myPen = New Pen(Color.Blue, 1)
        Dim sp, ep As PointF
        sp.X = LBox.xmin : sp.Y = 0
        ep.X = LBox.xmax : ep.Y = 0
        Dim sp1 As Point = Lp2Dp(sp)
        Dim ep1 As Point = Lp2Dp(ep)
        g.DrawLine(myPen, sp1, ep1)
        sp.X = 0 : sp.Y = LBox.ymin
        ep.X = 0 : ep.Y = LBox.ymax
        Dim sp2 As Point = Lp2Dp(sp)
        Dim ep2 As Point = Lp2Dp(ep)
        g.DrawLine(myPen, sp2, ep2)
    End Sub

    Public Function Lp2Dp(Lp As PointF) As Point
        Dim p As PointF = M_Lp2Dp.Tranform(Lp)
        Dim newp As Point
        newp.X = p.X : newp.Y = p.Y
        Return newp
    End Function

    Public Function Dp2Lp(Dp As Point) As PointF
        Return M_Dp2Lp.Tranform(Dp)
    End Function

End Class
