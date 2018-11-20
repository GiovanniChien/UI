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
        Me.btnRun2 = New System.Windows.Forms.Button()
        Me.btnRun1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRun2
        '
        Me.btnRun2.Location = New System.Drawing.Point(134, 29)
        Me.btnRun2.Name = "btnRun2"
        Me.btnRun2.Size = New System.Drawing.Size(75, 23)
        Me.btnRun2.TabIndex = 3
        Me.btnRun2.Text = "Run2"
        Me.btnRun2.UseVisualStyleBackColor = True
        '
        'btnRun1
        '
        Me.btnRun1.Location = New System.Drawing.Point(37, 29)
        Me.btnRun1.Name = "btnRun1"
        Me.btnRun1.Size = New System.Drawing.Size(75, 23)
        Me.btnRun1.TabIndex = 2
        Me.btnRun1.Text = "Run1"
        Me.btnRun1.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 113)
        Me.Controls.Add(Me.btnRun2)
        Me.Controls.Add(Me.btnRun1)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRun2 As System.Windows.Forms.Button
    Friend WithEvents btnRun1 As System.Windows.Forms.Button
End Class
