Public Class ucProgressBar
    Private _Min, _Max, _Value As Integer
    Private ValueColor, NothingColor As Color
    Private buff As Bitmap

    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        ValueColor = Color.Blue
        NothingColor = Color.White
    End Sub
    Private Sub picCanvas_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCanvas.Resize
        buff = New Bitmap(picCanvas.Width, picCanvas.Height)
    End Sub

    Property Max As Integer
        Get
            Return _Max
        End Get
        Set(ByVal v As Integer)
            _Max = v
        End Set
    End Property

    Property Min As Integer
        Get
            Return _Min
        End Get
        Set(ByVal v As Integer)
            _Min = v
        End Set
    End Property

    Property Value As Integer
        Get
            Return _Value
        End Get
        Set(ByVal v As Integer)
            If v < _Min Then Return
            If v > _Max Then Return
            _Value = v
            Dim dx As Single = buff.Width / (Max - Min + 1)
            Dim x As Integer = dx * Value
            For x1 = 0 To buff.Width - 1
                If x1 < x Then
                    ' 用ValueColor填充区域(0,0)-(x-1,picCanvas.Height-1)
                    For y = 0 To buff.Height - 1
                        buff.SetPixel(x1, y, ValueColor)
                    Next
                Else
                    ' 用NothingColor填充区域(x,0)-(picCanvas.Width-1,picCanvas.Height-1)
                    For y = 0 To buff.Height - 1
                        buff.SetPixel(x1, y, NothingColor)
                    Next
                End If
            Next
            picCanvas.Image = buff
            picCanvas.Refresh()
        End Set
    End Property




End Class
