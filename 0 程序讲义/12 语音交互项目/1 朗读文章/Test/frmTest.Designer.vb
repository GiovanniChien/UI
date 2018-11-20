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
        Me.btnSpeak = New System.Windows.Forms.Button()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.trkVolume = New System.Windows.Forms.TrackBar()
        Me.trkRate = New System.Windows.Forms.TrackBar()
        CType(Me.trkVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSpeak
        '
        Me.btnSpeak.Location = New System.Drawing.Point(12, 71)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(75, 23)
        Me.btnSpeak.TabIndex = 0
        Me.btnSpeak.Text = "btnSpeak"
        Me.btnSpeak.UseVisualStyleBackColor = True
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(12, 12)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtContent.Size = New System.Drawing.Size(268, 44)
        Me.txtContent.TabIndex = 1
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(12, 168)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnResume
        '
        Me.btnResume.Location = New System.Drawing.Point(12, 129)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(75, 23)
        Me.btnResume.TabIndex = 3
        Me.btnResume.Text = "Resume"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(12, 100)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 2
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(317, 17)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(214, 160)
        Me.ListBox1.TabIndex = 5
        '
        'trkVolume
        '
        Me.trkVolume.Location = New System.Drawing.Point(185, 71)
        Me.trkVolume.Minimum = -10
        Me.trkVolume.Name = "trkVolume"
        Me.trkVolume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkVolume.Size = New System.Drawing.Size(42, 187)
        Me.trkVolume.TabIndex = 6
        '
        'trkRate
        '
        Me.trkRate.Location = New System.Drawing.Point(238, 71)
        Me.trkRate.Minimum = -10
        Me.trkRate.Name = "trkRate"
        Me.trkRate.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkRate.Size = New System.Drawing.Size(42, 187)
        Me.trkRate.TabIndex = 6
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 270)
        Me.Controls.Add(Me.trkRate)
        Me.Controls.Add(Me.trkVolume)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.btnSpeak)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.trkVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSpeak As System.Windows.Forms.Button
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents trkVolume As System.Windows.Forms.TrackBar
    Friend WithEvents trkRate As System.Windows.Forms.TrackBar

End Class
