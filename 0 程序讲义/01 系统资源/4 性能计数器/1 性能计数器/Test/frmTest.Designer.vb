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
        Me.lstCategory = New System.Windows.Forms.ListBox()
        Me.lstCounter = New System.Windows.Forms.ListBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblCounterHelp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstCategory
        '
        Me.lstCategory.FormattingEnabled = True
        Me.lstCategory.ItemHeight = 12
        Me.lstCategory.Location = New System.Drawing.Point(12, 36)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(872, 76)
        Me.lstCategory.TabIndex = 6
        '
        'lstCounter
        '
        Me.lstCounter.FormattingEnabled = True
        Me.lstCounter.ItemHeight = 12
        Me.lstCounter.Location = New System.Drawing.Point(12, 132)
        Me.lstCounter.Name = "lstCounter"
        Me.lstCounter.Size = New System.Drawing.Size(872, 280)
        Me.lstCounter.TabIndex = 7
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(24, 7)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 8
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblCounterHelp
        '
        Me.lblCounterHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCounterHelp.Location = New System.Drawing.Point(12, 436)
        Me.lblCounterHelp.Name = "lblCounterHelp"
        Me.lblCounterHelp.Size = New System.Drawing.Size(872, 70)
        Me.lblCounterHelp.TabIndex = 9
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 515)
        Me.Controls.Add(Me.lblCounterHelp)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lstCategory)
        Me.Controls.Add(Me.lstCounter)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCategory As System.Windows.Forms.ListBox
    Friend WithEvents lstCounter As System.Windows.Forms.ListBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lblCounterHelp As System.Windows.Forms.Label

End Class
