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
        Me.lstCreation = New System.Windows.Forms.ListBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lstProperty = New System.Windows.Forms.ListBox()
        Me.lstDeletion = New System.Windows.Forms.ListBox()
        Me.lstModification = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstCreation
        '
        Me.lstCreation.FormattingEnabled = True
        Me.lstCreation.ItemHeight = 16
        Me.lstCreation.Location = New System.Drawing.Point(12, 81)
        Me.lstCreation.Name = "lstCreation"
        Me.lstCreation.Size = New System.Drawing.Size(330, 116)
        Me.lstCreation.TabIndex = 3
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(198, 29)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(100, 31)
        Me.btnStop.TabIndex = 0
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(16, 29)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 31)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lstProperty
        '
        Me.lstProperty.FormattingEnabled = True
        Me.lstProperty.ItemHeight = 16
        Me.lstProperty.Location = New System.Drawing.Point(395, 6)
        Me.lstProperty.Name = "lstProperty"
        Me.lstProperty.Size = New System.Drawing.Size(393, 660)
        Me.lstProperty.TabIndex = 3
        '
        'lstDeletion
        '
        Me.lstDeletion.FormattingEnabled = True
        Me.lstDeletion.ItemHeight = 16
        Me.lstDeletion.Location = New System.Drawing.Point(12, 345)
        Me.lstDeletion.Name = "lstDeletion"
        Me.lstDeletion.Size = New System.Drawing.Size(330, 116)
        Me.lstDeletion.TabIndex = 3
        '
        'lstModification
        '
        Me.lstModification.FormattingEnabled = True
        Me.lstModification.ItemHeight = 16
        Me.lstModification.Location = New System.Drawing.Point(12, 214)
        Me.lstModification.Name = "lstModification"
        Me.lstModification.Size = New System.Drawing.Size(330, 116)
        Me.lstModification.TabIndex = 3
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 673)
        Me.Controls.Add(Me.lstProperty)
        Me.Controls.Add(Me.lstDeletion)
        Me.Controls.Add(Me.lstModification)
        Me.Controls.Add(Me.lstCreation)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCreation As System.Windows.Forms.ListBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lstProperty As System.Windows.Forms.ListBox
    Friend WithEvents lstDeletion As System.Windows.Forms.ListBox
    Friend WithEvents lstModification As System.Windows.Forms.ListBox

End Class
