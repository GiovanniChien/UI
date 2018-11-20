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
        Me.glCanvas = New OpenTK.GLControl()
        Me.btnNewBoxes = New System.Windows.Forms.Button()
        Me.btnArrange = New System.Windows.Forms.Button()
        Me.RadioMin = New System.Windows.Forms.RadioButton()
        Me.RadioMax = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'glCanvas
        '
        Me.glCanvas.BackColor = System.Drawing.Color.Black
        Me.glCanvas.Location = New System.Drawing.Point(12, 122)
        Me.glCanvas.Name = "glCanvas"
        Me.glCanvas.Size = New System.Drawing.Size(239, 212)
        Me.glCanvas.TabIndex = 0
        Me.glCanvas.VSync = False
        '
        'btnNewBoxes
        '
        Me.btnNewBoxes.Location = New System.Drawing.Point(34, 12)
        Me.btnNewBoxes.Name = "btnNewBoxes"
        Me.btnNewBoxes.Size = New System.Drawing.Size(75, 23)
        Me.btnNewBoxes.TabIndex = 1
        Me.btnNewBoxes.Text = "NewBoxes"
        Me.btnNewBoxes.UseVisualStyleBackColor = True
        '
        'btnArrange
        '
        Me.btnArrange.Location = New System.Drawing.Point(132, 12)
        Me.btnArrange.Name = "btnArrange"
        Me.btnArrange.Size = New System.Drawing.Size(75, 23)
        Me.btnArrange.TabIndex = 1
        Me.btnArrange.Text = "Arrange"
        Me.btnArrange.UseVisualStyleBackColor = True
        '
        'RadioMin
        '
        Me.RadioMin.AutoSize = True
        Me.RadioMin.Checked = True
        Me.RadioMin.Location = New System.Drawing.Point(245, 15)
        Me.RadioMin.Name = "RadioMin"
        Me.RadioMin.Size = New System.Drawing.Size(71, 16)
        Me.RadioMin.TabIndex = 2
        Me.RadioMin.TabStop = True
        Me.RadioMin.Text = "RadioMin"
        Me.RadioMin.UseVisualStyleBackColor = True
        '
        'RadioMax
        '
        Me.RadioMax.AutoSize = True
        Me.RadioMax.Location = New System.Drawing.Point(245, 37)
        Me.RadioMax.Name = "RadioMax"
        Me.RadioMax.Size = New System.Drawing.Size(71, 16)
        Me.RadioMax.TabIndex = 2
        Me.RadioMax.Text = "RadioMax"
        Me.RadioMax.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 384)
        Me.Controls.Add(Me.RadioMax)
        Me.Controls.Add(Me.RadioMin)
        Me.Controls.Add(Me.btnArrange)
        Me.Controls.Add(Me.btnNewBoxes)
        Me.Controls.Add(Me.glCanvas)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents glCanvas As OpenTK.GLControl
    Friend WithEvents btnNewBoxes As System.Windows.Forms.Button
    Friend WithEvents btnArrange As System.Windows.Forms.Button
    Friend WithEvents RadioMin As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMax As System.Windows.Forms.RadioButton

End Class
