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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lstTask = New System.Windows.Forms.ListBox()
        Me.pbProgress = New Test.ucProgressBar()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(51, 215)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "btnOk"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lstTask
        '
        Me.lstTask.FormattingEnabled = True
        Me.lstTask.ItemHeight = 12
        Me.lstTask.Location = New System.Drawing.Point(51, 61)
        Me.lstTask.Name = "lstTask"
        Me.lstTask.Size = New System.Drawing.Size(120, 148)
        Me.lstTask.TabIndex = 4
        '
        'pbProgress
        '
        Me.pbProgress.Location = New System.Drawing.Point(198, 32)
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(193, 177)
        Me.pbProgress.TabIndex = 5
        Me.pbProgress.TaskCount = 0
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 271)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.lstTask)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lstTask As System.Windows.Forms.ListBox
    Friend WithEvents pbProgress As Test.ucProgressBar

End Class
