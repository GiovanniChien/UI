<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListBox
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
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 12
        Me.lstWords.Location = New System.Drawing.Point(0, 0)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(155, 265)
        Me.lstWords.TabIndex = 0
        '
        'frmListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(155, 265)
        Me.Controls.Add(Me.lstWords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListBox"
        Me.Text = "frmListBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
End Class
