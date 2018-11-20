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
        Me.picCanvas1 = New System.Windows.Forms.PictureBox()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.picCanvas2 = New System.Windows.Forms.PictureBox()
        CType(Me.picCanvas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCanvas2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCanvas1
        '
        Me.picCanvas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas1.Location = New System.Drawing.Point(21, 23)
        Me.picCanvas1.Name = "picCanvas1"
        Me.picCanvas1.Size = New System.Drawing.Size(250, 165)
        Me.picCanvas1.TabIndex = 0
        Me.picCanvas1.TabStop = False
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(84, 194)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(91, 30)
        Me.btnDraw.TabIndex = 1
        Me.btnDraw.Text = "btnDraw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(386, 194)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(91, 30)
        Me.btnDivide.TabIndex = 1
        Me.btnDivide.Text = "btnDivide"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'picCanvas2
        '
        Me.picCanvas2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas2.Location = New System.Drawing.Point(317, 23)
        Me.picCanvas2.Name = "picCanvas2"
        Me.picCanvas2.Size = New System.Drawing.Size(250, 165)
        Me.picCanvas2.TabIndex = 0
        Me.picCanvas2.TabStop = False
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 275)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.picCanvas2)
        Me.Controls.Add(Me.picCanvas1)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCanvas2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCanvas1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDraw As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents picCanvas2 As System.Windows.Forms.PictureBox

End Class
