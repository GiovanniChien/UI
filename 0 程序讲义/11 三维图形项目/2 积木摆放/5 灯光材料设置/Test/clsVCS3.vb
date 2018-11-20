Imports OpenTK
Imports System.Math

' 球面坐标系
Public Class clsVCS3
    Private _Azimuth As Single     '方位角azimuth
    Private _Elevation As Single   '仰角elevation
    Private _Radius As Single      '球半径
    Private _Origin As Vector3     '坐标原点

    Public Vp As Vector3      '观察点的直角坐标表示
    Public Up As Vector3      '观察点的向上的方向

    Public Sub New(ByVal box As clsBox)
        _Azimuth = 55
        _Elevation = 20
        Resize(box)
        UpdateVpUp()
    End Sub

    Public Sub Resize(ByVal box As clsBox)
        '设置观察球为包围盒的最大尺寸的2倍
        _Radius = box.Wx
        If box.WY > _Radius Then _Radius = box.WY
        If box.WZ > _Radius Then _Radius = box.WZ
        _Radius *= 10
        '设置观察的目标点为包围盒的中心
        _Origin = New Vector3(box.CX, box.CY, box.CZ)
        UpdateVpUp()
    End Sub

    Public Sub Rotate(ByVal Azimuth As Single, ByVal Elevation As Single)
        Me._Azimuth = Azimuth
        Me._Elevation = Elevation
        UpdateVpUp()
    End Sub

    Public Sub Zoom(ByVal deltaRadius As Single)
        Me._Radius += deltaRadius
        UpdateVpUp()
    End Sub

    Public Sub MoveOrigin(ByVal d As Vector3)
        Me._Origin.X -= d.X * 0.1
        Me._Origin.Y -= d.Y * 0.1
        Me._Origin.Z -= d.Z * 0.1
        UpdateVpUp()
    End Sub

    Private Sub UpdateVpUp()
        Vp.X = _Origin.X + _Radius * Cos(_Elevation / 180.0 * PI) * Cos(_Azimuth / 180.0 * PI)
        Vp.Y = _Origin.Y + _Radius * Cos(_Elevation / 180.0 * PI) * Sin(_Azimuth / 180.0 * PI)
        Vp.Z = _Origin.Z + _Radius * Sin(_Elevation / 180.0 * PI)
        If _Elevation > 90 And _Elevation <= 270 Then
            Up = New Vector3(0, 0, -1)   '从下向上看
        Else
            Up = New Vector3(0, 0, 1)    '从上向下看
        End If
    End Sub

    Public ReadOnly Property Origin As Vector3
        Get
            Return _Origin
        End Get
    End Property
    Public ReadOnly Property Radius As Single
        Get
            Return _Radius
        End Get
    End Property
    Public ReadOnly Property Azimuth As Single
        Get
            Return _Azimuth
        End Get
    End Property
    Public ReadOnly Property Elevation As Single
        Get
            Return _Elevation
        End Get
    End Property
End Class
