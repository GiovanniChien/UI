Public Class MineGame

    Dim ButtonMatrix As clsButtonMatrix

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Public Sub GameStart(RowN As Integer, ColN As Integer, MineN As Integer)
        Dim start As Point
        start.X = 50 : start.Y = 50
        ButtonMatrix = New clsButtonMatrix(start, RowN, ColN, MineN)
        ButtonMatrix.Show(Me)
    End Sub

    Public Sub GameOver()
        ButtonMatrix.ShowMine()
    End Sub

End Class
