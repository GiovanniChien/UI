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
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.lstOp = New System.Windows.Forms.ListBox()
        Me.btnRedo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtContent
        '
        Me.txtContent.AcceptsTab = True
        Me.txtContent.Location = New System.Drawing.Point(16, 52)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(356, 292)
        Me.txtContent.TabIndex = 0
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(233, 16)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(103, 28)
        Me.btnUndo.TabIndex = 1
        Me.btnUndo.Text = "btnUndo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'lstOp
        '
        Me.lstOp.FormattingEnabled = True
        Me.lstOp.ItemHeight = 16
        Me.lstOp.Location = New System.Drawing.Point(381, 52)
        Me.lstOp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstOp.Name = "lstOp"
        Me.lstOp.Size = New System.Drawing.Size(280, 292)
        Me.lstOp.TabIndex = 2
        '
        'btnRedo
        '
        Me.btnRedo.Location = New System.Drawing.Point(344, 16)
        Me.btnRedo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(103, 28)
        Me.btnRedo.TabIndex = 1
        Me.btnRedo.Text = "btnRedo"
        Me.btnRedo.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 368)
        Me.Controls.Add(Me.lstOp)
        Me.Controls.Add(Me.btnRedo)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.txtContent)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents lstOp As System.Windows.Forms.ListBox
    Friend WithEvents btnRedo As System.Windows.Forms.Button

End Class
