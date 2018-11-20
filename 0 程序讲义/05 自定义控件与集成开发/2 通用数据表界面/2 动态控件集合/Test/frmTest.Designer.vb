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
        Me.btnLayout = New System.Windows.Forms.Button()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLayout
        '
        Me.btnLayout.Location = New System.Drawing.Point(170, 12)
        Me.btnLayout.Name = "btnLayout"
        Me.btnLayout.Size = New System.Drawing.Size(75, 23)
        Me.btnLayout.TabIndex = 0
        Me.btnLayout.Text = "Layout"
        Me.btnLayout.UseVisualStyleBackColor = True
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(64, 12)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(100, 21)
        Me.txtN.TabIndex = 1
        Me.txtN.Text = "4"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.btnLayout)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLayout As System.Windows.Forms.Button
    Friend WithEvents txtN As System.Windows.Forms.TextBox

End Class
