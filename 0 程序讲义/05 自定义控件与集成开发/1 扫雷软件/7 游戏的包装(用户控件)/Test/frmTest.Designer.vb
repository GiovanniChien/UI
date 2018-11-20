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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnGameOver = New System.Windows.Forms.Button()
        Me.gbGame = New System.Windows.Forms.GroupBox()
        Me.MineGame1 = New ctlGame.MineGame()
        Me.gbGame.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(23, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnGameOver
        '
        Me.btnGameOver.Location = New System.Drawing.Point(119, 12)
        Me.btnGameOver.Name = "btnGameOver"
        Me.btnGameOver.Size = New System.Drawing.Size(75, 23)
        Me.btnGameOver.TabIndex = 0
        Me.btnGameOver.Text = "GameOver"
        Me.btnGameOver.UseVisualStyleBackColor = True
        '
        'gbGame
        '
        Me.gbGame.Controls.Add(Me.MineGame1)
        Me.gbGame.Location = New System.Drawing.Point(23, 41)
        Me.gbGame.Name = "gbGame"
        Me.gbGame.Size = New System.Drawing.Size(369, 311)
        Me.gbGame.TabIndex = 1
        Me.gbGame.TabStop = False
        '
        'MineGame1
        '
        Me.MineGame1.Location = New System.Drawing.Point(22, 22)
        Me.MineGame1.Name = "MineGame1"
        Me.MineGame1.Size = New System.Drawing.Size(318, 262)
        Me.MineGame1.TabIndex = 0
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 417)
        Me.Controls.Add(Me.gbGame)
        Me.Controls.Add(Me.btnGameOver)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.gbGame.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnGameOver As System.Windows.Forms.Button
    Friend WithEvents gbGame As System.Windows.Forms.GroupBox
    Friend WithEvents MineGame1 As ctlGame.MineGame

End Class
