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
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.picCanvas1 = New System.Windows.Forms.PictureBox()
        Me.picCanvas2 = New System.Windows.Forms.PictureBox()
        CType(Me.picCanvas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCanvas2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(32, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'picCanvas1
        '
        Me.picCanvas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas1.Location = New System.Drawing.Point(12, 41)
        Me.picCanvas1.Name = "picCanvas1"
        Me.picCanvas1.Size = New System.Drawing.Size(514, 459)
        Me.picCanvas1.TabIndex = 1
        Me.picCanvas1.TabStop = False
        '
        'picCanvas2
        '
        Me.picCanvas2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas2.Location = New System.Drawing.Point(532, 41)
        Me.picCanvas2.Name = "picCanvas2"
        Me.picCanvas2.Size = New System.Drawing.Size(514, 459)
        Me.picCanvas2.TabIndex = 1
        Me.picCanvas2.TabStop = False
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 512)
        Me.Controls.Add(Me.picCanvas2)
        Me.Controls.Add(Me.picCanvas1)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCanvas2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents picCanvas1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCanvas2 As System.Windows.Forms.PictureBox

End Class
