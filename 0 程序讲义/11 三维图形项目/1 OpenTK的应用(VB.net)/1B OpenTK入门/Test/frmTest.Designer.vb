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
        Me.glCtrl1 = New OpenTK.GLControl()
        Me.glCtrl2 = New OpenTK.GLControl()
        Me.btnDraw1 = New System.Windows.Forms.Button()
        Me.btnDraw2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'glCtrl1
        '
        Me.glCtrl1.BackColor = System.Drawing.Color.Black
        Me.glCtrl1.Location = New System.Drawing.Point(22, 50)
        Me.glCtrl1.Name = "glCtrl1"
        Me.glCtrl1.Size = New System.Drawing.Size(234, 245)
        Me.glCtrl1.TabIndex = 0
        Me.glCtrl1.VSync = False
        '
        'glCtrl2
        '
        Me.glCtrl2.BackColor = System.Drawing.Color.Black
        Me.glCtrl2.Location = New System.Drawing.Point(327, 50)
        Me.glCtrl2.Name = "glCtrl2"
        Me.glCtrl2.Size = New System.Drawing.Size(232, 245)
        Me.glCtrl2.TabIndex = 1
        Me.glCtrl2.VSync = False
        '
        'btnDraw1
        '
        Me.btnDraw1.Location = New System.Drawing.Point(22, 12)
        Me.btnDraw1.Name = "btnDraw1"
        Me.btnDraw1.Size = New System.Drawing.Size(75, 23)
        Me.btnDraw1.TabIndex = 2
        Me.btnDraw1.Text = "btnDraw1"
        Me.btnDraw1.UseVisualStyleBackColor = True
        '
        'btnDraw2
        '
        Me.btnDraw2.Location = New System.Drawing.Point(327, 21)
        Me.btnDraw2.Name = "btnDraw2"
        Me.btnDraw2.Size = New System.Drawing.Size(75, 23)
        Me.btnDraw2.TabIndex = 2
        Me.btnDraw2.Text = "btnDraw2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDraw2.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 307)
        Me.Controls.Add(Me.btnDraw2)
        Me.Controls.Add(Me.btnDraw1)
        Me.Controls.Add(Me.glCtrl2)
        Me.Controls.Add(Me.glCtrl1)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents glCtrl1 As OpenTK.GLControl
    Friend WithEvents glCtrl2 As OpenTK.GLControl
    Friend WithEvents btnDraw1 As System.Windows.Forms.Button
    Friend WithEvents btnDraw2 As System.Windows.Forms.Button

End Class
