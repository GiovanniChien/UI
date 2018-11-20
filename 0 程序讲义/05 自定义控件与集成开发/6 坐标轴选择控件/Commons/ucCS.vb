Public Enum Axis
    X
    Y
    Z
    None
End Enum

Public Class ucCS
    Public bmX, bmY, bmZ As Bitmap
    Private _Axis As Axis
    Public Event AxisChange(ByVal Axis As Axis)

    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Axis = Axis.x
    End Sub

    Public Property Axis
        Set(ByVal value)
            _Axis = value
            Select Case _Axis
                Case Axis.x : BackgroundImage = bmX
                Case Axis.y : BackgroundImage = bmY
                Case Axis.Z : BackgroundImage = bmZ
            End Select
        End Set
        Get
            Return _Axis
        End Get
    End Property

    Private Sub ucCS_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Dim axis As Axis = Search(e.X, e.Y)
        If axis <> axis.None And axis <> _Axis Then
            _Axis = axis
            RaiseEvent AxisChange(_Axis)
        End If
        ' 改变形象
        Select Case axis
            Case axis.X : BackgroundImage = bmX
            Case axis.Y : BackgroundImage = bmY
            Case axis.Z : BackgroundImage = bmZ
        End Select
    End Sub

    Private Function Search(ByVal x As Integer, ByVal y As Integer) As Axis
        If Search(bmX, x, y) = True Then Return Axis.X
        If Search(bmY, x, y) = True Then Return Axis.Y
        If Search(bmZ, x, y) = True Then Return Axis.Z
        Return Axis.None
    End Function

    Function Search(ByVal bm, ByVal x, ByVal y) As Boolean
        Dim SelectAxis As Color = Color.FromArgb(255, 0, 0)
        Dim c As Color
        Try
            For dx = -2 To 2
                For dy = -2 To 2
                    c = bm.GetPixel(x + dx, y + dy)
                    If c.ToArgb = SelectAxis.ToArgb Then Return True
                Next
            Next
        Catch ex As Exception
        End Try
        Return False
    End Function
End Class
