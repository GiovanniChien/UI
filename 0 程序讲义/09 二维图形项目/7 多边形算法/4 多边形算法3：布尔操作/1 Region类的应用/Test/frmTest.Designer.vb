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
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.btnCreate1 = New System.Windows.Forms.Button()
        Me.btnCreate2 = New System.Windows.Forms.Button()
        Me.btnUnion = New System.Windows.Forms.Button()
        Me.btnIntersect = New System.Windows.Forms.Button()
        Me.btnXor = New System.Windows.Forms.Button()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Location = New System.Drawing.Point(21, 23)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(566, 211)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'btnCreate1
        '
        Me.btnCreate1.Location = New System.Drawing.Point(37, 240)
        Me.btnCreate1.Name = "btnCreate1"
        Me.btnCreate1.Size = New System.Drawing.Size(64, 30)
        Me.btnCreate1.TabIndex = 1
        Me.btnCreate1.Text = "Create1"
        Me.btnCreate1.UseVisualStyleBackColor = True
        '
        'btnCreate2
        '
        Me.btnCreate2.Location = New System.Drawing.Point(144, 240)
        Me.btnCreate2.Name = "btnCreate2"
        Me.btnCreate2.Size = New System.Drawing.Size(63, 30)
        Me.btnCreate2.TabIndex = 1
        Me.btnCreate2.Text = "Create2"
        Me.btnCreate2.UseVisualStyleBackColor = True
        '
        'btnUnion
        '
        Me.btnUnion.Location = New System.Drawing.Point(240, 240)
        Me.btnUnion.Name = "btnUnion"
        Me.btnUnion.Size = New System.Drawing.Size(73, 30)
        Me.btnUnion.TabIndex = 1
        Me.btnUnion.Text = "Union"
        Me.btnUnion.UseVisualStyleBackColor = True
        '
        'btnIntersect
        '
        Me.btnIntersect.Location = New System.Drawing.Point(319, 240)
        Me.btnIntersect.Name = "btnIntersect"
        Me.btnIntersect.Size = New System.Drawing.Size(73, 30)
        Me.btnIntersect.TabIndex = 1
        Me.btnIntersect.Text = "Intersect"
        Me.btnIntersect.UseVisualStyleBackColor = True
        '
        'btnXor
        '
        Me.btnXor.Location = New System.Drawing.Point(398, 240)
        Me.btnXor.Name = "btnXor"
        Me.btnXor.Size = New System.Drawing.Size(73, 30)
        Me.btnXor.TabIndex = 1
        Me.btnXor.Text = "Xor"
        Me.btnXor.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 332)
        Me.Controls.Add(Me.btnXor)
        Me.Controls.Add(Me.btnIntersect)
        Me.Controls.Add(Me.btnUnion)
        Me.Controls.Add(Me.btnCreate2)
        Me.Controls.Add(Me.btnCreate1)
        Me.Controls.Add(Me.picCanvas)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents btnCreate1 As System.Windows.Forms.Button
    Friend WithEvents btnCreate2 As System.Windows.Forms.Button
    Friend WithEvents btnUnion As System.Windows.Forms.Button
    Friend WithEvents btnIntersect As System.Windows.Forms.Button
    Friend WithEvents btnXor As System.Windows.Forms.Button

End Class
