<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLayerManage
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
        Me.lstLayer = New System.Windows.Forms.ListBox()
        Me.btnSetActive = New System.Windows.Forms.Button()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.txtLayerName = New System.Windows.Forms.TextBox()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLayer
        '
        Me.lstLayer.FormattingEnabled = True
        Me.lstLayer.ItemHeight = 12
        Me.lstLayer.Location = New System.Drawing.Point(12, 12)
        Me.lstLayer.Name = "lstLayer"
        Me.lstLayer.Size = New System.Drawing.Size(268, 100)
        Me.lstLayer.TabIndex = 0
        '
        'btnSetActive
        '
        Me.btnSetActive.Location = New System.Drawing.Point(12, 128)
        Me.btnSetActive.Name = "btnSetActive"
        Me.btnSetActive.Size = New System.Drawing.Size(88, 24)
        Me.btnSetActive.TabIndex = 1
        Me.btnSetActive.Text = "当前层"
        Me.btnSetActive.UseVisualStyleBackColor = True
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(12, 158)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(88, 24)
        Me.btnAppend.TabIndex = 1
        Me.btnAppend.Text = "添加"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'txtLayerName
        '
        Me.txtLayerName.Location = New System.Drawing.Point(116, 161)
        Me.txtLayerName.Name = "txtLayerName"
        Me.txtLayerName.Size = New System.Drawing.Size(70, 21)
        Me.txtLayerName.TabIndex = 2
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(192, 161)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(52, 24)
        Me.btnColor.TabIndex = 1
        Me.btnColor.Text = "颜色"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'frmLayerManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.txtLayerName)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.btnSetActive)
        Me.Controls.Add(Me.lstLayer)
        Me.Name = "frmLayerManage"
        Me.Text = "frmLayerManage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLayer As System.Windows.Forms.ListBox
    Friend WithEvents btnSetActive As System.Windows.Forms.Button
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents txtLayerName As System.Windows.Forms.TextBox
    Friend WithEvents btnColor As System.Windows.Forms.Button
End Class
