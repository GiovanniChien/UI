﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBeanch
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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
        Me.FlowLayoutPanelMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'FlowLayoutPanelMain
        '
        Me.FlowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanelMain.Name = "FlowLayoutPanelMain"
        Me.FlowLayoutPanelMain.Size = New System.Drawing.Size(146, 146)
        Me.FlowLayoutPanelMain.TabIndex = 0
        '
        'ucDigit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.FlowLayoutPanelMain)
        Me.Name = "ucDigit"
        Me.Size = New System.Drawing.Size(146, 146)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanelMain As System.Windows.Forms.FlowLayoutPanel

End Class
