Public Class ucProgressBar2
    Private _TaskCount As Integer  ' 任务的个数
    Private Tasks() As Boolean    ' 任务的状态
    Private ValueColor, NothingColor As Color
    Private buff As Bitmap


    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        ValueColor = Color.Blue
        NothingColor = Color.White
    End Sub
    Private Sub ucProgressBar_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ' 排除图像框的边框厚度
        buff = New Bitmap(picCanvas.Width - 4, picCanvas.Height - 5)
        picCanvas.Image = buff
    End Sub

    Public Property TaskCount As Integer
        Get
            Return _TaskCount
        End Get
        Set(ByVal TaskCount As Integer)
            _TaskCount = TaskCount
            ReDim Tasks(_TaskCount - 1)  '默认均为False
            ClearBuff()
            picCanvas.Refresh()
        End Set
    End Property
    Private Sub ClearBuff()
        For x = 0 To buff.Width - 1
            For y = 0 To buff.Height - 1
                buff.SetPixel(x, y, NothingColor)
            Next
        Next
    End Sub

    Public Sub SetValue(ByVal TaskIndex As Integer)
        Tasks(TaskIndex) = True
        DrawTasks(TaskIndex)
        picCanvas.Refresh()
    End Sub

    Private Sub DrawTasks(ByVal TaskIndex As Integer)
        Dim Rows As Integer = 4, Cols As Integer = _TaskCount / Rows
        ' 每个方块的尺寸
        Dim dx As Single = buff.Width / Cols, dy As Single = buff.Height / Rows
        ' 任务TaskIndex对应的行号列号
        Dim rowid As Integer = Fix(TaskIndex / Cols), colid As Integer = TaskIndex Mod Cols
        For x As Integer = Fix(colid * dx) To Fix(colid * dx) + dx - 1
            For y As Integer = Fix(rowid * dy) To Fix(rowid * dy) + dy - 1
                buff.SetPixel(x, y, ValueColor)
            Next
        Next
    End Sub

End Class
