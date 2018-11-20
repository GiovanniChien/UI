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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnNoFilter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(29, 29)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "屏蔽"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnNoFilter
        '
        Me.btnNoFilter.Location = New System.Drawing.Point(120, 29)
        Me.btnNoFilter.Name = "btnNoFilter"
        Me.btnNoFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnNoFilter.TabIndex = 2
        Me.btnNoFilter.Text = "取消屏蔽"
        Me.btnNoFilter.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 150)
        Me.Controls.Add(Me.btnNoFilter)
        Me.Controls.Add(Me.btnFilter)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnNoFilter As System.Windows.Forms.Button
End Class
