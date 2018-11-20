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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.glCanvas = New OpenTK.GLControl()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.btnRender = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'glCanvas
        '
        Me.glCanvas.BackColor = System.Drawing.Color.Black
        Me.glCanvas.Location = New System.Drawing.Point(12, 60)
        Me.glCanvas.Name = "glCanvas"
        Me.glCanvas.Size = New System.Drawing.Size(419, 252)
        Me.glCanvas.TabIndex = 0
        Me.glCanvas.VSync = False
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(38, 12)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(75, 23)
        Me.btnDraw.TabIndex = 1
        Me.btnDraw.Text = "btnDraw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'btnRender
        '
        Me.btnRender.Location = New System.Drawing.Point(154, 12)
        Me.btnRender.Name = "btnRender"
        Me.btnRender.Size = New System.Drawing.Size(75, 23)
        Me.btnRender.TabIndex = 1
        Me.btnRender.Text = "btnRender"
        Me.btnRender.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRender.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 334)
        Me.Controls.Add(Me.btnRender)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.glCanvas)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents glCanvas As OpenTK.GLControl
    Friend WithEvents btnDraw As System.Windows.Forms.Button
    Friend WithEvents btnRender As System.Windows.Forms.Button

End Class
