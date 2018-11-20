Public Class ucOp
    Private ButtonTexts As List(Of String)
    Private Buttons As List(Of Button)
    Public Event ButtonPress(ByVal c As String, ByVal backOne As Boolean)

    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        InitButtonTexts()
        InitButtons()
        InitUI()
    End Sub

    Private Sub InitButtonTexts()
        ButtonTexts = New List(Of String)
        ButtonTexts.Add("+") : ButtonTexts.Add("-") : ButtonTexts.Add("*") : ButtonTexts.Add("/")
        ButtonTexts.Add("()")
        ButtonTexts.Add("sqrt()") : ButtonTexts.Add("sin()")
    End Sub

    Private Sub InitButtons()
        Buttons = New List(Of Button)
        Dim start As Point = New Point(10, 10), dy As Integer = 50
        Dim Op As Button
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
    End Sub

    Private Sub InitUI()
        Me.FlowLayoutPanelMain.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanelMain.SuspendLayout()
        For i = 0 To ButtonTexts.Count - 1
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
