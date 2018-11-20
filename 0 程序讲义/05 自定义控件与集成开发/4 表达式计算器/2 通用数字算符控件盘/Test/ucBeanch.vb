Public Enum BeanchKind
    Digits   '数字盘
    Ops      '算符盘
    Custom   '自定义工作盘
End Enum
Public Class ucBeanch
    Private Buttons As List(Of Button)
    Public Event ButtonPress(ByVal c As String, ByVal backOne As Boolean)

    Private Function InitDigitTexts() As String()
        Dim ButtonTexts() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "."}
        Return ButtonTexts
    End Function
    Private Function InitOpTexts() As String()
        Dim ButtonTexts() As String = {"+", "-", "*", "/", "()", "sin()", "sqrt()"}
        Return ButtonTexts
    End Function

    WriteOnly Property Kind As BeanchKind
        Set(kind As BeanchKind)
            If kind = BeanchKind.Custom Then Return
            Dim ButtonTexts() As String = {}
            If kind = BeanchKind.Digits Then ButtonTexts = InitDigitTexts()
            If kind = BeanchKind.Ops Then ButtonTexts = InitOpTexts()
            InitButtons(ButtonTexts)
            InitUI()
        End Set
    End Property

    Public Sub InitButtons(ButtonTexts() As String)
        Dim Op As Button
        Buttons = New List(Of Button)
        For i = 0 To ButtonTexts.Count - 1
            Op = New System.Windows.Forms.Button()
            Op.Size = New System.Drawing.Size(23, 23)
            Op.Name = "Button" & i
            Op.Text = ButtonTexts(i)
            Op.AutoSize = True
            Op.TabIndex = i
            Op.UseVisualStyleBackColor = True
            AddHandler Op.Click, AddressOf ButtonClick
            Buttons.Add(Op)
        Next
        InitUI()
    End Sub

    Private Sub InitUI()
        Me.FlowLayoutPanelMain.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanelMain.SuspendLayout()
        For i = 0 To Buttons.Count - 1
            Me.FlowLayoutPanelMain.Controls.Add(Buttons(i))
        Next
        Me.FlowLayoutPanelMain.ResumeLayout(False)
    End Sub

    Private Sub ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Button As Button = sender
        If Button.Text.Last = ")" Then
            RaiseEvent ButtonPress(Button.Text, True)
        Else
            RaiseEvent ButtonPress(Button.Text, False)
        End If
    End Sub
End Class
