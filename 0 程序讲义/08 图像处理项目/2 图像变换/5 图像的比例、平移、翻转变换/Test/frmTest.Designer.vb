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
        Me.btnScale = New System.Windows.Forms.Button()
        Me.picCanvas1 = New System.Windows.Forms.PictureBox()
        Me.radioLinear = New System.Windows.Forms.RadioButton()
        Me.radioNoLinear = New System.Windows.Forms.RadioButton()
        Me.btnRotate = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        CType(Me.picCanvas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnScale
        '
        Me.btnScale.Location = New System.Drawing.Point(12, 41)
        Me.btnScale.Name = "btnScale"
        Me.btnScale.Size = New System.Drawing.Size(75, 23)
        Me.btnScale.TabIndex = 0
        Me.btnScale.Text = "Scale"
        Me.btnScale.UseVisualStyleBackColor = True
        '
        'picCanvas1
        '
        Me.picCanvas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas1.Location = New System.Drawing.Point(12, 103)
        Me.picCanvas1.Name = "picCanvas1"
        Me.picCanvas1.Size = New System.Drawing.Size(533, 397)
        Me.picCanvas1.TabIndex = 1
        Me.picCanvas1.TabStop = False
        '
        'radioLinear
        '
        Me.radioLinear.AutoSize = True
        Me.radioLinear.Checked = True
        Me.radioLinear.Location = New System.Drawing.Point(105, 44)
        Me.radioLinear.Name = "radioLinear"
        Me.radioLinear.Size = New System.Drawing.Size(59, 16)
        Me.radioLinear.TabIndex = 2
        Me.radioLinear.TabStop = True
        Me.radioLinear.Text = "Linear"
        Me.radioLinear.UseVisualStyleBackColor = True
        '
        'radioNoLinear
        '
        Me.radioNoLinear.AutoSize = True
        Me.radioNoLinear.Location = New System.Drawing.Point(170, 44)
        Me.radioNoLinear.Name = "radioNoLinear"
        Me.radioNoLinear.Size = New System.Drawing.Size(71, 16)
        Me.radioNoLinear.TabIndex = 2
        Me.radioNoLinear.Text = "NoLinear"
        Me.radioNoLinear.UseVisualStyleBackColor = True
        '
        'btnRotate
        '
        Me.btnRotate.Location = New System.Drawing.Point(12, 74)
        Me.btnRotate.Name = "btnRotate"
        Me.btnRotate.Size = New System.Drawing.Size(75, 23)
        Me.btnRotate.TabIndex = 0
        Me.btnRotate.Text = "Rotate"
        Me.btnRotate.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 647)
        Me.Controls.Add(Me.radioNoLinear)
        Me.Controls.Add(Me.radioLinear)
        Me.Controls.Add(Me.picCanvas1)
        Me.Controls.Add(Me.btnRotate)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnScale)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnScale As System.Windows.Forms.Button
    Friend WithEvents picCanvas1 As System.Windows.Forms.PictureBox
    Friend WithEvents radioLinear As System.Windows.Forms.RadioButton
    Friend WithEvents radioNoLinear As System.Windows.Forms.RadioButton
    Friend WithEvents btnRotate As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button

End Class
