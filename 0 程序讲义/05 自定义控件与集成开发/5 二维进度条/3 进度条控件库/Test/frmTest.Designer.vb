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
        Me.btnSetValue = New System.Windows.Forms.Button()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.pbProgress1 = New LibProgressBar.ucProgressBar1()
        Me.lstTask = New System.Windows.Forms.ListBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pbProgress2 = New LibProgressBar.ucProgressBar2()
        Me.SuspendLayout()
        '
        'btnSetValue
        '
        Me.btnSetValue.Location = New System.Drawing.Point(168, 60)
        Me.btnSetValue.Name = "btnSetValue"
        Me.btnSetValue.Size = New System.Drawing.Size(95, 23)
        Me.btnSetValue.TabIndex = 4
        Me.btnSetValue.Text = "btnSetValue"
        Me.btnSetValue.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(26, 60)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(75, 23)
        Me.btnInit.TabIndex = 3
        Me.btnInit.Text = "btnInit"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'pbProgress1
        '
        Me.pbProgress1.Location = New System.Drawing.Point(26, 23)
        Me.pbProgress1.Max = 0
        Me.pbProgress1.Min = 0
        Me.pbProgress1.Name = "pbProgress1"
        Me.pbProgress1.Size = New System.Drawing.Size(237, 31)
        Me.pbProgress1.TabIndex = 5
        Me.pbProgress1.Value = 0
        '
        'lstTask
        '
        Me.lstTask.FormattingEnabled = True
        Me.lstTask.ItemHeight = 12
        Me.lstTask.Location = New System.Drawing.Point(26, 106)
        Me.lstTask.Name = "lstTask"
        Me.lstTask.Size = New System.Drawing.Size(75, 148)
        Me.lstTask.TabIndex = 7
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(26, 274)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "btnOk"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pbProgress2
        '
        Me.pbProgress2.Location = New System.Drawing.Point(117, 106)
        Me.pbProgress2.Name = "pbProgress2"
        Me.pbProgress2.Size = New System.Drawing.Size(146, 148)
        Me.pbProgress2.TabIndex = 8
        Me.pbProgress2.TaskCount = 0
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 309)
        Me.Controls.Add(Me.pbProgress2)
        Me.Controls.Add(Me.lstTask)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.pbProgress1)
        Me.Controls.Add(Me.btnSetValue)
        Me.Controls.Add(Me.btnInit)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSetValue As System.Windows.Forms.Button
    Friend WithEvents btnInit As System.Windows.Forms.Button
    Friend WithEvents pbProgress1 As LibProgressBar.ucProgressBar1
    Friend WithEvents lstTask As System.Windows.Forms.ListBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents pbProgress2 As LibProgressBar.ucProgressBar2

End Class
