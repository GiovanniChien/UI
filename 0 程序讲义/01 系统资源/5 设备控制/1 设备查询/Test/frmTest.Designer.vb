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
        Me.btnPorts = New System.Windows.Forms.Button()
        Me.lstPorts = New System.Windows.Forms.ListBox()
        Me.btnAudio = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnPing = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPorts
        '
        Me.btnPorts.Location = New System.Drawing.Point(12, 12)
        Me.btnPorts.Name = "btnPorts"
        Me.btnPorts.Size = New System.Drawing.Size(75, 23)
        Me.btnPorts.TabIndex = 1
        Me.btnPorts.Text = "Ports"
        Me.btnPorts.UseVisualStyleBackColor = True
        '
        'lstPorts
        '
        Me.lstPorts.FormattingEnabled = True
        Me.lstPorts.ItemHeight = 12
        Me.lstPorts.Location = New System.Drawing.Point(12, 51)
        Me.lstPorts.Name = "lstPorts"
        Me.lstPorts.Size = New System.Drawing.Size(120, 88)
        Me.lstPorts.TabIndex = 2
        '
        'btnAudio
        '
        Me.btnAudio.Location = New System.Drawing.Point(141, 12)
        Me.btnAudio.Name = "btnAudio"
        Me.btnAudio.Size = New System.Drawing.Size(75, 23)
        Me.btnAudio.TabIndex = 1
        Me.btnAudio.Text = "Audio"
        Me.btnAudio.UseVisualStyleBackColor = True
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(154, 72)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(75, 23)
        Me.btnDownload.TabIndex = 1
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'btnPing
        '
        Me.btnPing.Location = New System.Drawing.Point(154, 116)
        Me.btnPing.Name = "btnPing"
        Me.btnPing.Size = New System.Drawing.Size(75, 23)
        Me.btnPing.TabIndex = 1
        Me.btnPing.Text = "Ping"
        Me.btnPing.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 304)
        Me.Controls.Add(Me.lstPorts)
        Me.Controls.Add(Me.btnPing)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnAudio)
        Me.Controls.Add(Me.btnPorts)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPorts As System.Windows.Forms.Button
    Friend WithEvents lstPorts As System.Windows.Forms.ListBox
    Friend WithEvents btnAudio As System.Windows.Forms.Button
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnPing As System.Windows.Forms.Button

End Class
