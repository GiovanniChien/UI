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
        Me.btnEnvironmentVariables = New System.Windows.Forms.Button()
        Me.lstEnvironmentVariables = New System.Windows.Forms.ListBox()
        Me.btnOS = New System.Windows.Forms.Button()
        Me.lstOS = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCommandLine = New System.Windows.Forms.Button()
        Me.lstArgs = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnEnvironmentVariables
        '
        Me.btnEnvironmentVariables.Location = New System.Drawing.Point(12, 183)
        Me.btnEnvironmentVariables.Name = "btnEnvironmentVariables"
        Me.btnEnvironmentVariables.Size = New System.Drawing.Size(75, 23)
        Me.btnEnvironmentVariables.TabIndex = 0
        Me.btnEnvironmentVariables.Text = "环境变量"
        Me.btnEnvironmentVariables.UseVisualStyleBackColor = True
        '
        'lstEnvironmentVariables
        '
        Me.lstEnvironmentVariables.FormattingEnabled = True
        Me.lstEnvironmentVariables.HorizontalScrollbar = True
        Me.lstEnvironmentVariables.ItemHeight = 12
        Me.lstEnvironmentVariables.Location = New System.Drawing.Point(12, 212)
        Me.lstEnvironmentVariables.Name = "lstEnvironmentVariables"
        Me.lstEnvironmentVariables.Size = New System.Drawing.Size(506, 184)
        Me.lstEnvironmentVariables.TabIndex = 1
        '
        'btnOS
        '
        Me.btnOS.Location = New System.Drawing.Point(12, 12)
        Me.btnOS.Name = "btnOS"
        Me.btnOS.Size = New System.Drawing.Size(75, 23)
        Me.btnOS.TabIndex = 0
        Me.btnOS.Text = "操作系统"
        Me.btnOS.UseVisualStyleBackColor = True
        '
        'lstOS
        '
        Me.lstOS.FormattingEnabled = True
        Me.lstOS.HorizontalScrollbar = True
        Me.lstOS.ItemHeight = 12
        Me.lstOS.Location = New System.Drawing.Point(12, 41)
        Me.lstOS.Name = "lstOS"
        Me.lstOS.Size = New System.Drawing.Size(506, 136)
        Me.lstOS.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 488)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "退出"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCommandLine
        '
        Me.btnCommandLine.Location = New System.Drawing.Point(12, 402)
        Me.btnCommandLine.Name = "btnCommandLine"
        Me.btnCommandLine.Size = New System.Drawing.Size(75, 23)
        Me.btnCommandLine.TabIndex = 0
        Me.btnCommandLine.Text = "命令行"
        Me.btnCommandLine.UseVisualStyleBackColor = True
        '
        'lstArgs
        '
        Me.lstArgs.FormattingEnabled = True
        Me.lstArgs.HorizontalScrollbar = True
        Me.lstArgs.ItemHeight = 12
        Me.lstArgs.Location = New System.Drawing.Point(15, 430)
        Me.lstArgs.Name = "lstArgs"
        Me.lstArgs.Size = New System.Drawing.Size(506, 52)
        Me.lstArgs.TabIndex = 1
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 523)
        Me.Controls.Add(Me.lstOS)
        Me.Controls.Add(Me.lstArgs)
        Me.Controls.Add(Me.lstEnvironmentVariables)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOS)
        Me.Controls.Add(Me.btnCommandLine)
        Me.Controls.Add(Me.btnEnvironmentVariables)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnvironmentVariables As System.Windows.Forms.Button
    Friend WithEvents lstEnvironmentVariables As System.Windows.Forms.ListBox
    Friend WithEvents btnOS As System.Windows.Forms.Button
    Friend WithEvents lstOS As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCommandLine As System.Windows.Forms.Button
    Friend WithEvents lstArgs As System.Windows.Forms.ListBox

End Class
