Imports System.Windows.Media.Media3D
Imports System.Math

Public Class clsCamera
    Private Target As Point3D           ' 观察对象的中心点
    Private Radius As Single            ' 观察球的半径
    Private JD As Single, WD As Single  ' 经度，维度
    Private myCamera As PerspectiveCamera

    Public Sub New(myCamera As PerspectiveCamera, Target As Point3D, Radius As Single, JD As Single, WD As Single)
        Me.myCamera = myCamera
        Me.Target = Target
        Me.Radius = Radius
        Me.JD = JD : Me.WD = WD
        ReCompute()
    End Sub
    Public Sub AddRadius(delta As Single)
        Me.Radius += delta
        ReCompute()
    End Sub

    Public Sub AddWD(delta As Single)
        Me.WD = (Me.WD + delta) Mod 360
        ReCompute()
    End Sub
    Public Sub AddJD(delta As Single)
        Me.JD = (Me.JD + delta) Mod 360
        ReCompute()
    End Sub
    Private Sub ReCompute()
        Dim p As Point3D
        p.X = Radius * Cos(WD / 180 * PI) * Cos(JD / 180 * PI)
        p.Y = Radius * Cos(WD / 180 * PI) * Sin(JD / 180 * PI)
        p.Z = Radius * Sin(WD / 180 * PI)
        myCamera.Position = p
        myCamera.LookDirection = Target - p
    End Sub
End Class
