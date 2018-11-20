<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOption
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
        Me.grpHard = New System.Windows.Forms.GroupBox()
        Me.rdoHard = New System.Windows.Forms.RadioButton()
        Me.rdoMedium = New System.Windows.Forms.RadioButton()
        Me.rdoEasy = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpHard.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpHard
        '
        Me.grpHard.Controls.Add(Me.rdoHard)
        Me.grpHard.Controls.Add(Me.rdoMedium)
        Me.grpHard.Controls.Add(Me.rdoEasy)
        Me.grpHard.Location = New System.Drawing.Point(55, 41)
        Me.grpHard.Name = "grpHard"
        Me.grpHard.Size = New System.Drawing.Size(569, 365)
        Me.grpHard.TabIndex = 0
        Me.grpHard.TabStop = False
        Me.grpHard.Text = "难度"
        '
        'rdoHard
        '
        Me.rdoHard.AutoSize = True
        Me.rdoHard.Location = New System.Drawing.Point(77, 269)
        Me.rdoHard.Name = "rdoHard"
        Me.rdoHard.Size = New System.Drawing.Size(89, 28)
        Me.rdoHard.TabIndex = 2
        Me.rdoHard.Text = "高级"
        Me.rdoHard.UseVisualStyleBackColor = True
        '
        'rdoMedium
        '
        Me.rdoMedium.AutoSize = True
        Me.rdoMedium.Location = New System.Drawing.Point(77, 176)
        Me.rdoMedium.Name = "rdoMedium"
        Me.rdoMedium.Size = New System.Drawing.Size(89, 28)
        Me.rdoMedium.TabIndex = 1
        Me.rdoMedium.Text = "中级"
        Me.rdoMedium.UseVisualStyleBackColor = True
        '
        'rdoEasy
        '
        Me.rdoEasy.AutoSize = True
        Me.rdoEasy.Checked = True
        Me.rdoEasy.Location = New System.Drawing.Point(77, 83)
        Me.rdoEasy.Name = "rdoEasy"
        Me.rdoEasy.Size = New System.Drawing.Size(89, 28)
        Me.rdoEasy.TabIndex = 0
        Me.rdoEasy.TabStop = True
        Me.rdoEasy.Text = "初级"
        Me.rdoEasy.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(209, 507)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(201, 60)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "确定"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(423, 507)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(201, 60)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 618)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.grpHard)
        Me.Name = "frmOption"
        Me.Text = "frmOption"
        Me.grpHard.ResumeLayout(False)
        Me.grpHard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpHard As GroupBox
    Friend WithEvents rdoHard As RadioButton
    Friend WithEvents rdoMedium As RadioButton
    Friend WithEvents rdoEasy As RadioButton
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
End Class
