<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTest
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
        Me.glCtrl = New OpenTK.GLControl()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnTop = New System.Windows.Forms.Button()
        Me.btnBottom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'glCtrl
        '
        Me.glCtrl.BackColor = System.Drawing.Color.Black
        Me.glCtrl.Location = New System.Drawing.Point(12, 25)
        Me.glCtrl.Name = "glCtrl"
        Me.glCtrl.Size = New System.Drawing.Size(310, 255)
        Me.glCtrl.TabIndex = 0
        Me.glCtrl.VSync = False
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(55, 286)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnLeft.TabIndex = 1
        Me.btnLeft.Text = "btnLeft"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(152, 286)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 23)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = "btnRight"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnTop
        '
        Me.btnTop.Location = New System.Drawing.Point(328, 86)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(75, 23)
        Me.btnTop.TabIndex = 1
        Me.btnTop.Text = "btnTop"
        Me.btnTop.UseVisualStyleBackColor = True
        '
        'btnBottom
        '
        Me.btnBottom.Location = New System.Drawing.Point(328, 115)
        Me.btnBottom.Name = "btnBottom"
        Me.btnBottom.Size = New System.Drawing.Size(75, 23)
        Me.btnBottom.TabIndex = 1
        Me.btnBottom.Text = "btnBottom"
        Me.btnBottom.UseVisualStyleBackColor = True
        '
        'FrmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 325)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnBottom)
        Me.Controls.Add(Me.btnTop)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.glCtrl)
        Me.Name = "FrmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents glCtrl As OpenTK.GLControl
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnTop As System.Windows.Forms.Button
    Friend WithEvents btnBottom As System.Windows.Forms.Button

End Class
