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
        Me.btnDisplayProc = New System.Windows.Forms.Button()
        Me.btnKill = New System.Windows.Forms.Button()
        Me.lvProcess = New System.Windows.Forms.ListView()
        Me.lstThread = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplayProc
        '
        Me.btnDisplayProc.Location = New System.Drawing.Point(82, 12)
        Me.btnDisplayProc.Name = "btnDisplayProc"
        Me.btnDisplayProc.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayProc.TabIndex = 0
        Me.btnDisplayProc.Text = "DisplayProc"
        Me.btnDisplayProc.UseVisualStyleBackColor = True
        '
        'btnKill
        '
        Me.btnKill.Location = New System.Drawing.Point(294, 12)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(75, 23)
        Me.btnKill.TabIndex = 2
        Me.btnKill.Text = "Kill"
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'lvProcess
        '
        Me.lvProcess.Location = New System.Drawing.Point(12, 64)
        Me.lvProcess.Name = "lvProcess"
        Me.lvProcess.Size = New System.Drawing.Size(695, 232)
        Me.lvProcess.TabIndex = 3
        Me.lvProcess.UseCompatibleStateImageBehavior = False
        '
        'lstThread
        '
        Me.lstThread.FormattingEnabled = True
        Me.lstThread.ItemHeight = 12
        Me.lstThread.Location = New System.Drawing.Point(12, 316)
        Me.lstThread.Name = "lstThread"
        Me.lstThread.Size = New System.Drawing.Size(695, 328)
        Me.lstThread.TabIndex = 4
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 656)
        Me.Controls.Add(Me.lstThread)
        Me.Controls.Add(Me.lvProcess)
        Me.Controls.Add(Me.btnKill)
        Me.Controls.Add(Me.btnDisplayProc)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplayProc As System.Windows.Forms.Button
    Friend WithEvents btnKill As System.Windows.Forms.Button
    Friend WithEvents lvProcess As System.Windows.Forms.ListView
    Friend WithEvents lstThread As System.Windows.Forms.ListBox

End Class
