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
        Me.CtrInputStudent = New Test.ctrInput()
        Me.lstStudent = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'CtrInputStudent
        '
        Me.CtrInputStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtrInputStudent.Location = New System.Drawing.Point(303, 56)
        Me.CtrInputStudent.Name = "CtrInputStudent"
        Me.CtrInputStudent.Size = New System.Drawing.Size(349, 255)
        Me.CtrInputStudent.TabIndex = 1
        '
        'lstStudent
        '
        Me.lstStudent.FormattingEnabled = True
        Me.lstStudent.ItemHeight = 12
        Me.lstStudent.Location = New System.Drawing.Point(12, 56)
        Me.lstStudent.Name = "lstStudent"
        Me.lstStudent.Size = New System.Drawing.Size(271, 256)
        Me.lstStudent.TabIndex = 2
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 336)
        Me.Controls.Add(Me.lstStudent)
        Me.Controls.Add(Me.CtrInputStudent)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrInputStudent As Test.ctrInput
    Friend WithEvents lstStudent As System.Windows.Forms.ListBox

End Class
