<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTest
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
        Me.glCtrl = New OpenTK.GLControl()
        Me.SuspendLayout()
        '
        'glCtrl
        '
        Me.glCtrl.BackColor = System.Drawing.Color.Black
        Me.glCtrl.Location = New System.Drawing.Point(12, 25)
        Me.glCtrl.Name = "glCtrl"
        Me.glCtrl.Size = New System.Drawing.Size(573, 255)
        Me.glCtrl.TabIndex = 0
        Me.glCtrl.VSync = False
        '
        'FrmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 325)
        Me.Controls.Add(Me.glCtrl)
        Me.Name = "FrmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents glCtrl As OpenTK.GLControl

End Class
