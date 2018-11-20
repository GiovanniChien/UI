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
        Me.picCanvasXY = New System.Windows.Forms.PictureBox()
        Me.tbXY = New System.Windows.Forms.TrackBar()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pbProgress1 = New LibProgressBar.ucProgressBar1()
        CType(Me.picCanvasXY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbXY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "btnOpen"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'picCanvasXY
        '
        Me.picCanvasXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvasXY.Location = New System.Drawing.Point(12, 41)
        Me.picCanvasXY.Name = "picCanvasXY"
        Me.picCanvasXY.Size = New System.Drawing.Size(517, 477)
        Me.picCanvasXY.TabIndex = 1
        Me.picCanvasXY.TabStop = False
        '
        'tbXY
        '
        Me.tbXY.Location = New System.Drawing.Point(12, 524)
        Me.tbXY.Name = "tbXY"
        Me.tbXY.Size = New System.Drawing.Size(517, 45)
        Me.tbXY.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(107, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pbProgress1
        '
        Me.pbProgress1.Location = New System.Drawing.Point(259, 12)
        Me.pbProgress1.Max = 0
        Me.pbProgress1.Min = 0
        Me.pbProgress1.Name = "pbProgress1"
        Me.pbProgress1.Size = New System.Drawing.Size(208, 22)
        Me.pbProgress1.TabIndex = 5
        Me.pbProgress1.Value = 0
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 550)
        Me.Controls.Add(Me.pbProgress1)
        Me.Controls.Add(Me.picCanvasXY)
        Me.Controls.Add(Me.tbXY)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvasXY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbXY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents picCanvasXY As System.Windows.Forms.PictureBox
    Friend WithEvents tbXY As System.Windows.Forms.TrackBar
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents pbProgress1 As LibProgressBar.ucProgressBar1

End Class
