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
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lstOp = New System.Windows.Forms.ListBox()
        Me.btnRedo = New System.Windows.Forms.Button()
        Me.btnStep = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtContent
        '
        Me.txtContent.AcceptsTab = True
        Me.txtContent.Location = New System.Drawing.Point(16, 52)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(356, 192)
        Me.txtContent.TabIndex = 0
        '
        'lstOp
        '
        Me.lstOp.FormattingEnabled = True
        Me.lstOp.ItemHeight = 16
        Me.lstOp.Location = New System.Drawing.Point(381, 52)
        Me.lstOp.Margin = New System.Windows.Forms.Padding(4)
        Me.lstOp.Name = "lstOp"
        Me.lstOp.Size = New System.Drawing.Size(280, 292)
        Me.lstOp.TabIndex = 2
        '
        'btnRedo
        '
        Me.btnRedo.Location = New System.Drawing.Point(149, 255)
        Me.btnRedo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(103, 28)
        Me.btnRedo.TabIndex = 1
        Me.btnRedo.Text = "btnRedo"
        Me.btnRedo.UseVisualStyleBackColor = True
        '
        'btnStep
        '
        Me.btnStep.Location = New System.Drawing.Point(16, 253)
        Me.btnStep.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStep.Name = "btnStep"
        Me.btnStep.Size = New System.Drawing.Size(100, 31)
        Me.btnStep.TabIndex = 3
        Me.btnStep.Text = "btnStep"
        Me.btnStep.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 292)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 149)
        Me.TextBox1.TabIndex = 0
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 459)
        Me.Controls.Add(Me.btnStep)
        Me.Controls.Add(Me.lstOp)
        Me.Controls.Add(Me.btnRedo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtContent)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents lstOp As System.Windows.Forms.ListBox
    Friend WithEvents btnRedo As System.Windows.Forms.Button
    Friend WithEvents btnStep As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
