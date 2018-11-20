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
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.radXY = New System.Windows.Forms.RadioButton()
        Me.radXZ = New System.Windows.Forms.RadioButton()
        Me.radYZ = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(30, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(30, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 323)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'radXY
        '
        Me.radXY.AutoSize = True
        Me.radXY.Checked = True
        Me.radXY.Location = New System.Drawing.Point(152, 12)
        Me.radXY.Name = "radXY"
        Me.radXY.Size = New System.Drawing.Size(35, 16)
        Me.radXY.TabIndex = 2
        Me.radXY.TabStop = True
        Me.radXY.Text = "XY"
        Me.radXY.UseVisualStyleBackColor = True
        '
        'radXZ
        '
        Me.radXZ.AutoSize = True
        Me.radXZ.Location = New System.Drawing.Point(204, 12)
        Me.radXZ.Name = "radXZ"
        Me.radXZ.Size = New System.Drawing.Size(35, 16)
        Me.radXZ.TabIndex = 2
        Me.radXZ.Text = "XZ"
        Me.radXZ.UseVisualStyleBackColor = True
        '
        'radYZ
        '
        Me.radYZ.AutoSize = True
        Me.radYZ.Location = New System.Drawing.Point(264, 12)
        Me.radYZ.Name = "radYZ"
        Me.radYZ.Size = New System.Drawing.Size(35, 16)
        Me.radYZ.TabIndex = 2
        Me.radYZ.Text = "YZ"
        Me.radYZ.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 422)
        Me.Controls.Add(Me.radYZ)
        Me.Controls.Add(Me.radXZ)
        Me.Controls.Add(Me.radXY)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents radXY As System.Windows.Forms.RadioButton
    Friend WithEvents radXZ As System.Windows.Forms.RadioButton
    Friend WithEvents radYZ As System.Windows.Forms.RadioButton

End Class
