<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEasy = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "您想从什么难度开始？"
        '
        'btnEasy
        '
        Me.btnEasy.Location = New System.Drawing.Point(12, 79)
        Me.btnEasy.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(361, 50)
        Me.btnEasy.TabIndex = 1
        Me.btnEasy.Text = "初级"
        Me.btnEasy.UseVisualStyleBackColor = True
        '
        'btnMedium
        '
        Me.btnMedium.Location = New System.Drawing.Point(12, 144)
        Me.btnMedium.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(361, 50)
        Me.btnMedium.TabIndex = 2
        Me.btnMedium.Text = "中级"
        Me.btnMedium.UseVisualStyleBackColor = True
        '
        'btnHard
        '
        Me.btnHard.Location = New System.Drawing.Point(12, 213)
        Me.btnHard.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(361, 50)
        Me.btnHard.TabIndex = 3
        Me.btnHard.Text = "高级"
        Me.btnHard.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.Location = New System.Drawing.Point(9, 299)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "注意： 您可以稍后单击""游戏""菜单上的""选项""来更改难度级别。"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 357)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnEasy)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmStart"
        Me.Text = "选择难度"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEasy As Button
    Friend WithEvents btnMedium As Button
    Friend WithEvents btnHard As Button
    Friend WithEvents Label2 As Label
End Class
