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
        Me.tbYZ = New System.Windows.Forms.TrackBar()
        Me.tbXZ = New System.Windows.Forms.TrackBar()
        Me.tbXY = New System.Windows.Forms.TrackBar()
        Me.picCanvasXZ = New System.Windows.Forms.PictureBox()
        Me.picCanvasYZ = New System.Windows.Forms.PictureBox()
        CType(Me.picCanvasXY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbYZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbXZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbXY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCanvasXZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCanvasYZ, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tbYZ
        '
        Me.tbYZ.Location = New System.Drawing.Point(551, 465)
        Me.tbYZ.Name = "tbYZ"
        Me.tbYZ.Size = New System.Drawing.Size(505, 42)
        Me.tbYZ.TabIndex = 4
        '
        'tbXZ
        '
        Me.tbXZ.Location = New System.Drawing.Point(551, 192)
        Me.tbXZ.Name = "tbXZ"
        Me.tbXZ.Size = New System.Drawing.Size(505, 42)
        Me.tbXZ.TabIndex = 4
        '
        'tbXY
        '
        Me.tbXY.Location = New System.Drawing.Point(12, 524)
        Me.tbXY.Name = "tbXY"
        Me.tbXY.Size = New System.Drawing.Size(517, 42)
        Me.tbXY.TabIndex = 4
        '
        'picCanvasXZ
        '
        Me.picCanvasXZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvasXZ.Location = New System.Drawing.Point(551, 12)
        Me.picCanvasXZ.Name = "picCanvasXZ"
        Me.picCanvasXZ.Size = New System.Drawing.Size(505, 174)
        Me.picCanvasXZ.TabIndex = 1
        Me.picCanvasXZ.TabStop = False
        '
        'picCanvasYZ
        '
        Me.picCanvasYZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvasYZ.Location = New System.Drawing.Point(551, 267)
        Me.picCanvasYZ.Name = "picCanvasYZ"
        Me.picCanvasYZ.Size = New System.Drawing.Size(505, 172)
        Me.picCanvasYZ.TabIndex = 1
        Me.picCanvasYZ.TabStop = False
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 567)
        Me.Controls.Add(Me.tbYZ)
        Me.Controls.Add(Me.tbXZ)
        Me.Controls.Add(Me.picCanvasYZ)
        Me.Controls.Add(Me.picCanvasXZ)
        Me.Controls.Add(Me.picCanvasXY)
        Me.Controls.Add(Me.tbXY)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvasXY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbYZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbXZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbXY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCanvasXZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCanvasYZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents picCanvasXY As System.Windows.Forms.PictureBox
    Friend WithEvents tbYZ As System.Windows.Forms.TrackBar
    Friend WithEvents tbXZ As System.Windows.Forms.TrackBar
    Friend WithEvents tbXY As System.Windows.Forms.TrackBar
    Friend WithEvents picCanvasXZ As System.Windows.Forms.PictureBox
    Friend WithEvents picCanvasYZ As System.Windows.Forms.PictureBox

End Class
