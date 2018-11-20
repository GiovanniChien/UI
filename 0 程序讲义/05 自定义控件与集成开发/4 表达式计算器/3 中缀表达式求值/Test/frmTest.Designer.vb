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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstExpr = New System.Windows.Forms.ListBox()
        Me.btnEval = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.UcDigit = New Test.ucBeanch()
        Me.UcOp = New Test.ucBeanch()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtContent
        '
        Me.txtContent.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtContent.Location = New System.Drawing.Point(15, 27)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(301, 26)
        Me.txtContent.TabIndex = 3
        Me.txtContent.Text = "1+(12.45+(3+40.5)+5)+6"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1MinSize = 45
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstExpr)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnEval)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtContent)
        Me.SplitContainer1.Size = New System.Drawing.Size(654, 517)
        Me.SplitContainer1.SplitterDistance = 306
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 4
        '
        'lstExpr
        '
        Me.lstExpr.FormattingEnabled = True
        Me.lstExpr.ItemHeight = 16
        Me.lstExpr.Location = New System.Drawing.Point(15, 117)
        Me.lstExpr.Margin = New System.Windows.Forms.Padding(4)
        Me.lstExpr.Name = "lstExpr"
        Me.lstExpr.Size = New System.Drawing.Size(318, 388)
        Me.lstExpr.TabIndex = 5
        '
        'btnEval
        '
        Me.btnEval.Location = New System.Drawing.Point(15, 72)
        Me.btnEval.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEval.Name = "btnEval"
        Me.btnEval.Size = New System.Drawing.Size(124, 28)
        Me.btnEval.TabIndex = 4
        Me.btnEval.Text = "btnEval"
        Me.btnEval.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.UcDigit)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.UcOp)
        Me.SplitContainer2.Size = New System.Drawing.Size(306, 517)
        Me.SplitContainer2.SplitterDistance = 286
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 3
        '
        'UcDigit
        '
        Me.UcDigit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcDigit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDigit.Location = New System.Drawing.Point(0, 0)
        Me.UcDigit.Margin = New System.Windows.Forms.Padding(4)
        Me.UcDigit.Name = "UcDigit"
        Me.UcDigit.Size = New System.Drawing.Size(306, 286)
        Me.UcDigit.TabIndex = 0
        '
        'UcOp
        '
        Me.UcOp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcOp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcOp.Location = New System.Drawing.Point(0, 0)
        Me.UcOp.Margin = New System.Windows.Forms.Padding(4)
        Me.UcOp.Name = "UcOp"
        Me.UcOp.Size = New System.Drawing.Size(306, 226)
        Me.UcOp.TabIndex = 0
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 517)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcDigit As Test.ucBeanch
    Friend WithEvents UcOp As Test.ucBeanch
    Friend WithEvents btnEval As System.Windows.Forms.Button
    Friend WithEvents lstExpr As System.Windows.Forms.ListBox

End Class
