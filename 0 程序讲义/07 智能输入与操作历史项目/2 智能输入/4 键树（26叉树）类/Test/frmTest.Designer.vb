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
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 16
        Me.lstWords.Location = New System.Drawing.Point(13, 49)
        Me.lstWords.Margin = New System.Windows.Forms.Padding(4)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(403, 404)
        Me.lstWords.TabIndex = 1
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(13, 13)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(403, 26)
        Me.txtContent.TabIndex = 2
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 452)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.lstWords)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents txtContent As System.Windows.Forms.TextBox

End Class
