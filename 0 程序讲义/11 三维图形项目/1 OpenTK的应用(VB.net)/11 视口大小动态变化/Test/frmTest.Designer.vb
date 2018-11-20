<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTest
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
        Me.glCtrl = New OpenTK.GLControl()
        Me.lineVertical = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineHorizon = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SuspendLayout()
        '
        'glCtrl
        '
        Me.glCtrl.BackColor = System.Drawing.Color.Black
        Me.glCtrl.Location = New System.Drawing.Point(30, 183)
        Me.glCtrl.Name = "glCtrl"
        Me.glCtrl.Size = New System.Drawing.Size(571, 276)
        Me.glCtrl.TabIndex = 0
        Me.glCtrl.VSync = False
        '
        'lineVertical
        '
        Me.lineVertical.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lineVertical.BorderWidth = 10
        Me.lineVertical.Name = "lineVertical"
        Me.lineVertical.X1 = 247
        Me.lineVertical.X2 = 249
        Me.lineVertical.Y1 = 17
        Me.lineVertical.Y2 = 277
        '
        'LineHorizon
        '
        Me.LineHorizon.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineHorizon.BorderWidth = 3
        Me.LineHorizon.Name = "LineHorizon"
        Me.LineHorizon.X1 = 491
        Me.LineHorizon.X2 = 170
        Me.LineHorizon.Y1 = 84
        Me.LineHorizon.Y2 = 89
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineHorizon, Me.lineVertical})
        Me.ShapeContainer1.Size = New System.Drawing.Size(633, 459)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'FrmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 459)
        Me.Controls.Add(Me.glCtrl)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FrmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents glCtrl As OpenTK.GLControl
    Friend WithEvents lineVertical As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineHorizon As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer

End Class
