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
        Me.btnStart1 = New System.Windows.Forms.Button()
        Me.txtResult1 = New System.Windows.Forms.TextBox()
        Me.btnStart2 = New System.Windows.Forms.Button()
        Me.txtResult2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStart1
        '
        Me.btnStart1.Location = New System.Drawing.Point(12, 12)
        Me.btnStart1.Name = "btnStart1"
        Me.btnStart1.Size = New System.Drawing.Size(75, 23)
        Me.btnStart1.TabIndex = 0
        Me.btnStart1.Text = "btnStart1"
        Me.btnStart1.UseVisualStyleBackColor = True
        '
        'txtResult1
        '
        Me.txtResult1.Location = New System.Drawing.Point(122, 14)
        Me.txtResult1.Name = "txtResult1"
        Me.txtResult1.Size = New System.Drawing.Size(141, 21)
        Me.txtResult1.TabIndex = 2
        '
        'btnStart2
        '
        Me.btnStart2.Location = New System.Drawing.Point(12, 61)
        Me.btnStart2.Name = "btnStart2"
        Me.btnStart2.Size = New System.Drawing.Size(75, 23)
        Me.btnStart2.TabIndex = 0
        Me.btnStart2.Text = "btnStart2"
        Me.btnStart2.UseVisualStyleBackColor = True
        '
        'txtResult2
        '
        Me.txtResult2.Location = New System.Drawing.Point(122, 61)
        Me.txtResult2.Name = "txtResult2"
        Me.txtResult2.Size = New System.Drawing.Size(141, 21)
        Me.txtResult2.TabIndex = 2
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 273)
        Me.Controls.Add(Me.txtResult2)
        Me.Controls.Add(Me.txtResult1)
        Me.Controls.Add(Me.btnStart2)
        Me.Controls.Add(Me.btnStart1)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart1 As System.Windows.Forms.Button
    Friend WithEvents txtResult1 As System.Windows.Forms.TextBox
    Friend WithEvents btnStart2 As System.Windows.Forms.Button
    Friend WithEvents txtResult2 As System.Windows.Forms.TextBox

End Class
