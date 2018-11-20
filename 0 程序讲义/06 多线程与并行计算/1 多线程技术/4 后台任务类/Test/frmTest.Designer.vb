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
        Me.btnStart1 = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.lstPara = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnStart1
        '
        Me.btnStart1.Location = New System.Drawing.Point(12, 12)
        Me.btnStart1.Name = "btnStart1"
        Me.btnStart1.Size = New System.Drawing.Size(75, 23)
        Me.btnStart1.TabIndex = 0
        Me.btnStart1.Text = "btnStart1"
        Me.btnStart1.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 12
        Me.lstResult.Location = New System.Drawing.Point(216, 45)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(176, 124)
        Me.lstResult.TabIndex = 1
        '
        'lstPara
        '
        Me.lstPara.FormattingEnabled = True
        Me.lstPara.ItemHeight = 12
        Me.lstPara.Location = New System.Drawing.Point(12, 45)
        Me.lstPara.Name = "lstPara"
        Me.lstPara.Size = New System.Drawing.Size(198, 124)
        Me.lstPara.TabIndex = 1
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 197)
        Me.Controls.Add(Me.lstPara)
        Me.Controls.Add(Me.lstResult)
        Me.Controls.Add(Me.btnStart1)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart1 As System.Windows.Forms.Button
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents lstPara As System.Windows.Forms.ListBox

End Class
