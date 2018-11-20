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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'glCanvas
        '
        Me.glCanvas.BackColor = System.Drawing.Color.Black
        Me.glCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.glCanvas.Location = New System.Drawing.Point(0, 0)
        Me.glCanvas.Name = "glCanvas"
        Me.glCanvas.Size = New System.Drawing.Size(385, 516)
        Me.glCanvas.TabIndex = 0
        Me.glCanvas.VSync = False
        '
        'btnNewBoxes
        '
        Me.btnNewBoxes.Location = New System.Drawing.Point(31, 13)
        Me.btnNewBoxes.Name = "btnNewBoxes"
        Me.btnNewBoxes.Size = New System.Drawing.Size(75, 23)
        Me.btnNewBoxes.TabIndex = 1
        Me.btnNewBoxes.Text = "NewBoxes"
        Me.btnNewBoxes.UseVisualStyleBackColor = True
        '
        'btnArrange
        '
        Me.btnArrange.Location = New System.Drawing.Point(31, 53)
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
        Me.RadioMin.Location = New System.Drawing.Point(31, 82)
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
        Me.RadioMax.Location = New System.Drawing.Point(31, 104)
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
        Me.GroupBox1.Controls.Add(Me.chkUseNormal)
        Me.GroupBox1.Controls.Add(Me.chkLight1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 132)
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
        Me.chkUseNormal.Location = New System.Drawing.Point(28, 86)
        Me.chkUseNormal.Name = "chkUseNormal"
        Me.chkUseNormal.Size = New System.Drawing.Size(78, 16)
        Me.chkUseNormal.TabIndex = 3
        Me.chkUseNormal.Text = "UseNormal"
        Me.chkUseNormal.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(27, 138)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioMax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnNewBoxes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioMin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnArrange)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.glCanvas)
        Me.SplitContainer1.Size = New System.Drawing.Size(542, 516)
        Me.SplitContainer1.SplitterDistance = 153
        Me.SplitContainer1.TabIndex = 5
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 516)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

End Class
