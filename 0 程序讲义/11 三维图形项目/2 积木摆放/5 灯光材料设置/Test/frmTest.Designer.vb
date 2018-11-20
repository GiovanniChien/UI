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
        Me.chkLight1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkLight3 = New System.Windows.Forms.CheckBox()
        Me.chkLight2 = New System.Windows.Forms.CheckBox()
        Me.chkUseNormal = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'glCanvas
        '
        Me.glCanvas.BackColor = System.Drawing.Color.Black
        Me.glCanvas.Location = New System.Drawing.Point(2, 212)
        Me.glCanvas.Name = "glCanvas"
        Me.glCanvas.Size = New System.Drawing.Size(528, 292)
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
        'chkLight1
        '
        Me.chkLight1.AutoSize = True
        Me.chkLight1.Location = New System.Drawing.Point(28, 20)
        Me.chkLight1.Name = "chkLight1"
        Me.chkLight1.Size = New System.Drawing.Size(60, 16)
        Me.chkLight1.TabIndex = 3
        Me.chkLight1.Text = "Light1"
        Me.chkLight1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkLight3)
        Me.GroupBox1.Controls.Add(Me.chkLight2)
        Me.GroupBox1.Controls.Add(Me.chkLight1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 96)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lights"
        '
        'chkLight3
        '
        Me.chkLight3.AutoSize = True
        Me.chkLight3.Location = New System.Drawing.Point(28, 64)
        Me.chkLight3.Name = "chkLight3"
        Me.chkLight3.Size = New System.Drawing.Size(60, 16)
        Me.chkLight3.TabIndex = 3
        Me.chkLight3.Text = "Light3"
        Me.chkLight3.UseVisualStyleBackColor = True
        '
        'chkLight2
        '
        Me.chkLight2.AutoSize = True
        Me.chkLight2.Location = New System.Drawing.Point(28, 42)
        Me.chkLight2.Name = "chkLight2"
        Me.chkLight2.Size = New System.Drawing.Size(60, 16)
        Me.chkLight2.TabIndex = 3
        Me.chkLight2.Text = "Light2"
        Me.chkLight2.UseVisualStyleBackColor = True
        '
        'chkUseNormal
        '
        Me.chkUseNormal.AutoSize = True
        Me.chkUseNormal.Checked = True
        Me.chkUseNormal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUseNormal.Location = New System.Drawing.Point(12, 171)
        Me.chkUseNormal.Name = "chkUseNormal"
        Me.chkUseNormal.Size = New System.Drawing.Size(78, 16)
        Me.chkUseNormal.TabIndex = 3
        Me.chkUseNormal.Text = "UseNormal"
        Me.chkUseNormal.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 516)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioMax)
        Me.Controls.Add(Me.chkUseNormal)
        Me.Controls.Add(Me.RadioMin)
        Me.Controls.Add(Me.btnArrange)
        Me.Controls.Add(Me.btnNewBoxes)
        Me.Controls.Add(Me.glCanvas)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents glCanvas As OpenTK.GLControl
    Friend WithEvents btnNewBoxes As System.Windows.Forms.Button
    Friend WithEvents btnArrange As System.Windows.Forms.Button
    Friend WithEvents RadioMin As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMax As System.Windows.Forms.RadioButton
    Friend WithEvents chkLight1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLight3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkLight2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseNormal As System.Windows.Forms.CheckBox

End Class
