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
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.CtrlTextBox3 = New WindowsApplication1.ctrlTextBox()
        Me.CtrlTextBox2 = New WindowsApplication1.ctrlTextBox()
        Me.CtrlTextBox1 = New WindowsApplication1.ctrlTextBox()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(177, 205)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(92, 22)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'CtrlTextBox3
        '
        Me.CtrlTextBox3.DataType = WindowsApplication1.DataType.typeInteger
        Me.CtrlTextBox3.Location = New System.Drawing.Point(89, 117)
        Me.CtrlTextBox3.Name = "CtrlTextBox3"
        Me.CtrlTextBox3.Size = New System.Drawing.Size(236, 28)
        Me.CtrlTextBox3.TabIndex = 3
        '
        'CtrlTextBox2
        '
        Me.CtrlTextBox2.DataType = WindowsApplication1.DataType.typeInteger
        Me.CtrlTextBox2.Location = New System.Drawing.Point(89, 83)
        Me.CtrlTextBox2.Name = "CtrlTextBox2"
        Me.CtrlTextBox2.Size = New System.Drawing.Size(236, 28)
        Me.CtrlTextBox2.TabIndex = 2
        '
        'CtrlTextBox1
        '
        Me.CtrlTextBox1.DataType = WindowsApplication1.DataType.typeInteger
        Me.CtrlTextBox1.Location = New System.Drawing.Point(89, 49)
        Me.CtrlTextBox1.Name = "CtrlTextBox1"
        Me.CtrlTextBox1.Size = New System.Drawing.Size(236, 28)
        Me.CtrlTextBox1.TabIndex = 1
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 278)
        Me.Controls.Add(Me.CtrlTextBox3)
        Me.Controls.Add(Me.CtrlTextBox2)
        Me.Controls.Add(Me.CtrlTextBox1)
        Me.Controls.Add(Me.btnCheck)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents CtrlTextBox1 As WindowsApplication1.ctrlTextBox
    Friend WithEvents CtrlTextBox2 As WindowsApplication1.ctrlTextBox
    Friend WithEvents CtrlTextBox3 As WindowsApplication1.ctrlTextBox

End Class
