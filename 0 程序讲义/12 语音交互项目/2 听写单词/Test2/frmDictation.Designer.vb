<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDictation
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
        Me.btnRecog1 = New System.Windows.Forms.Button()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.btnRecog2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRecog1
        '
        Me.btnRecog1.Location = New System.Drawing.Point(46, 36)
        Me.btnRecog1.Name = "btnRecog1"
        Me.btnRecog1.Size = New System.Drawing.Size(75, 23)
        Me.btnRecog1.TabIndex = 0
        Me.btnRecog1.Text = "识别文件"
        Me.btnRecog1.UseVisualStyleBackColor = True
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(46, 79)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(200, 117)
        Me.txtContent.TabIndex = 1
        '
        'btnRecog2
        '
        Me.btnRecog2.Location = New System.Drawing.Point(143, 36)
        Me.btnRecog2.Name = "btnRecog2"
        Me.btnRecog2.Size = New System.Drawing.Size(75, 23)
        Me.btnRecog2.TabIndex = 0
        Me.btnRecog2.Text = "识别人"
        Me.btnRecog2.UseVisualStyleBackColor = True
        '
        'frmDictation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.btnRecog2)
        Me.Controls.Add(Me.btnRecog1)
        Me.Name = "frmDictation"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRecog1 As System.Windows.Forms.Button
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents btnRecog2 As System.Windows.Forms.Button

End Class
