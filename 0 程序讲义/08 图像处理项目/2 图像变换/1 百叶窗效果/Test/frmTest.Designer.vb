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
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.RadioVertical = New System.Windows.Forms.RadioButton()
        Me.RadioHorizontal = New System.Windows.Forms.RadioButton()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(32, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Location = New System.Drawing.Point(12, 41)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(602, 459)
        Me.picCanvas.TabIndex = 1
        Me.picCanvas.TabStop = False
        '
        'RadioVertical
        '
        Me.RadioVertical.AutoSize = True
        Me.RadioVertical.Checked = True
        Me.RadioVertical.Location = New System.Drawing.Point(654, 20)
        Me.RadioVertical.Name = "RadioVertical"
        Me.RadioVertical.Size = New System.Drawing.Size(71, 16)
        Me.RadioVertical.TabIndex = 2
        Me.RadioVertical.TabStop = True
        Me.RadioVertical.Text = "Vertical"
        Me.RadioVertical.UseVisualStyleBackColor = True
        '
        'RadioHorizontal
        '
        Me.RadioHorizontal.AutoSize = True
        Me.RadioHorizontal.Location = New System.Drawing.Point(654, 42)
        Me.RadioHorizontal.Name = "RadioHorizontal"
        Me.RadioHorizontal.Size = New System.Drawing.Size(83, 16)
        Me.RadioHorizontal.TabIndex = 2
        Me.RadioHorizontal.Text = "Horizontal"
        Me.RadioHorizontal.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 512)
        Me.Controls.Add(Me.RadioHorizontal)
        Me.Controls.Add(Me.RadioVertical)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents RadioVertical As System.Windows.Forms.RadioButton
    Friend WithEvents RadioHorizontal As System.Windows.Forms.RadioButton

End Class
