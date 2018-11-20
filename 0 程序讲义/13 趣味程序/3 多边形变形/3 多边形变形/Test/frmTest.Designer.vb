<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.hsF0 = New System.Windows.Forms.HScrollBar()
        Me.hsF = New System.Windows.Forms.HScrollBar()
        Me.hsK1 = New System.Windows.Forms.HScrollBar()
        Me.hsK2 = New System.Windows.Forms.HScrollBar()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Location = New System.Drawing.Point(26, 60)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(374, 270)
        Me.picCanvas.TabIndex = 1
        Me.picCanvas.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(332, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'hsF0
        '
        Me.hsF0.Location = New System.Drawing.Point(26, 9)
        Me.hsF0.Name = "hsF0"
        Me.hsF0.Size = New System.Drawing.Size(93, 17)
        Me.hsF0.TabIndex = 4
        '
        'hsF
        '
        Me.hsF.Location = New System.Drawing.Point(26, 31)
        Me.hsF.Name = "hsF"
        Me.hsF.Size = New System.Drawing.Size(93, 17)
        Me.hsF.TabIndex = 4
        '
        'hsK1
        '
        Me.hsK1.Location = New System.Drawing.Point(153, 11)
        Me.hsK1.Name = "hsK1"
        Me.hsK1.Size = New System.Drawing.Size(93, 17)
        Me.hsK1.TabIndex = 4
        '
        'hsK2
        '
        Me.hsK2.Location = New System.Drawing.Point(153, 37)
        Me.hsK2.Name = "hsK2"
        Me.hsK2.Size = New System.Drawing.Size(93, 17)
        Me.hsK2.TabIndex = 4
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 342)
        Me.Controls.Add(Me.hsK2)
        Me.Controls.Add(Me.hsK1)
        Me.Controls.Add(Me.hsF)
        Me.Controls.Add(Me.hsF0)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picCanvas)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents hsF0 As System.Windows.Forms.HScrollBar
    Friend WithEvents hsF As System.Windows.Forms.HScrollBar
    Friend WithEvents hsK1 As System.Windows.Forms.HScrollBar
    Friend WithEvents hsK2 As System.Windows.Forms.HScrollBar

End Class
