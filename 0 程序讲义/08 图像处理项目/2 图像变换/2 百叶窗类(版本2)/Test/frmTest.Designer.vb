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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.picSource = New System.Windows.Forms.PictureBox()
        Me.picSlide = New System.Windows.Forms.PictureBox()
        Me.btnSlide = New System.Windows.Forms.Button()
        CType(Me.picSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(55, 377)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(120, 23)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "btnDisplay"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'picSource
        '
        Me.picSource.Location = New System.Drawing.Point(3, 12)
        Me.picSource.Name = "picSource"
        Me.picSource.Size = New System.Drawing.Size(391, 345)
        Me.picSource.TabIndex = 2
        Me.picSource.TabStop = False
        '
        'picSlide
        '
        Me.picSlide.Location = New System.Drawing.Point(411, 12)
        Me.picSlide.Name = "picSlide"
        Me.picSlide.Size = New System.Drawing.Size(391, 345)
        Me.picSlide.TabIndex = 2
        Me.picSlide.TabStop = False
        '
        'btnSlide
        '
        Me.btnSlide.Location = New System.Drawing.Point(450, 377)
        Me.btnSlide.Name = "btnSlide"
        Me.btnSlide.Size = New System.Drawing.Size(120, 23)
        Me.btnSlide.TabIndex = 1
        Me.btnSlide.Text = "btnSlide"
        Me.btnSlide.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 521)
        Me.Controls.Add(Me.picSlide)
        Me.Controls.Add(Me.picSource)
        Me.Controls.Add(Me.btnSlide)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "frmTest"
        Me.Text = "创建Graphics对象"
        CType(Me.picSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents picSource As System.Windows.Forms.PictureBox
    Friend WithEvents picSlide As System.Windows.Forms.PictureBox
    Friend WithEvents btnSlide As System.Windows.Forms.Button

End Class
