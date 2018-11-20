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
        Me.glCanvas = New OpenTK.GLControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'glCanvas
        '
        Me.glCanvas.BackColor = System.Drawing.Color.Black
        Me.glCanvas.Location = New System.Drawing.Point(34, 46)
        Me.glCanvas.Name = "glCanvas"
        Me.glCanvas.Size = New System.Drawing.Size(239, 212)
        Me.glCanvas.TabIndex = 0
        Me.glCanvas.VSync = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 270)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.glCanvas)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents glCanvas As OpenTK.GLControl
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
