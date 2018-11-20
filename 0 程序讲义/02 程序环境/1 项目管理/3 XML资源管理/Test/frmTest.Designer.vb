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
        Me.btnLights = New System.Windows.Forms.Button()
        Me.lstLight = New System.Windows.Forms.ListBox()
        Me.lstLightPara = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnLights
        '
        Me.btnLights.Location = New System.Drawing.Point(12, 13)
        Me.btnLights.Name = "btnLights"
        Me.btnLights.Size = New System.Drawing.Size(75, 23)
        Me.btnLights.TabIndex = 18
        Me.btnLights.Text = "Lights"
        Me.btnLights.UseVisualStyleBackColor = True
        '
        'lstLight
        '
        Me.lstLight.FormattingEnabled = True
        Me.lstLight.ItemHeight = 12
        Me.lstLight.Location = New System.Drawing.Point(12, 51)
        Me.lstLight.Name = "lstLight"
        Me.lstLight.Size = New System.Drawing.Size(220, 88)
        Me.lstLight.TabIndex = 19
        '
        'lstLightPara
        '
        Me.lstLightPara.FormattingEnabled = True
        Me.lstLightPara.ItemHeight = 12
        Me.lstLightPara.Location = New System.Drawing.Point(12, 145)
        Me.lstLightPara.Name = "lstLightPara"
        Me.lstLightPara.Size = New System.Drawing.Size(220, 112)
        Me.lstLightPara.TabIndex = 19
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 275)
        Me.Controls.Add(Me.lstLightPara)
        Me.Controls.Add(Me.lstLight)
        Me.Controls.Add(Me.btnLights)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLights As System.Windows.Forms.Button
    Friend WithEvents lstLight As System.Windows.Forms.ListBox
    Friend WithEvents lstLightPara As System.Windows.Forms.ListBox

End Class
