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
        Me.lstWMI = New System.Windows.Forms.ListBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.lstWMIPath = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstWMI
        '
        Me.lstWMI.FormattingEnabled = True
        Me.lstWMI.ItemHeight = 16
        Me.lstWMI.Location = New System.Drawing.Point(2, 109)
        Me.lstWMI.Name = "lstWMI"
        Me.lstWMI.Size = New System.Drawing.Size(789, 532)
        Me.lstWMI.TabIndex = 3
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(256, 13)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(100, 31)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'lstWMIPath
        '
        Me.lstWMIPath.FormattingEnabled = True
        Me.lstWMIPath.ItemHeight = 16
        Me.lstWMIPath.Location = New System.Drawing.Point(2, 3)
        Me.lstWMIPath.Name = "lstWMIPath"
        Me.lstWMIPath.Size = New System.Drawing.Size(247, 100)
        Me.lstWMIPath.TabIndex = 3
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 673)
        Me.Controls.Add(Me.lstWMIPath)
        Me.Controls.Add(Me.lstWMI)
        Me.Controls.Add(Me.btnOpen)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstWMI As System.Windows.Forms.ListBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents lstWMIPath As System.Windows.Forms.ListBox

End Class
