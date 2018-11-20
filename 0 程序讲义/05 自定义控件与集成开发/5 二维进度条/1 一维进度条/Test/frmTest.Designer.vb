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
        Me.btnInit = New System.Windows.Forms.Button()
        Me.btnSetValue = New System.Windows.Forms.Button()
        Me.pbProgress = New Test.ucProgressBar()
        Me.SuspendLayout()
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(76, 91)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(75, 23)
        Me.btnInit.TabIndex = 1
        Me.btnInit.Text = "btnInit"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnSetValue
        '
        Me.btnSetValue.Location = New System.Drawing.Point(221, 91)
        Me.btnSetValue.Name = "btnSetValue"
        Me.btnSetValue.Size = New System.Drawing.Size(95, 23)
        Me.btnSetValue.TabIndex = 2
        Me.btnSetValue.Text = "btnSetValue"
        Me.btnSetValue.UseVisualStyleBackColor = True
        '
        'pbProgress
        '
        Me.pbProgress.Location = New System.Drawing.Point(76, 46)
        Me.pbProgress.Max = 0
        Me.pbProgress.Min = 0
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(240, 24)
        Me.pbProgress.TabIndex = 3
        Me.pbProgress.Value = 0
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 271)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.btnSetValue)
        Me.Controls.Add(Me.btnInit)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInit As System.Windows.Forms.Button
    Friend WithEvents btnSetValue As System.Windows.Forms.Button
    Friend WithEvents pbProgress As Test.ucProgressBar

End Class
