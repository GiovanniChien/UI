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
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.txtXmin = New System.Windows.Forms.TextBox()
        Me.txtXmax = New System.Windows.Forms.TextBox()
        Me.txtYmin = New System.Windows.Forms.TextBox()
        Me.txtYmax = New System.Windows.Forms.TextBox()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Location = New System.Drawing.Point(21, 23)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(566, 211)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(63, 302)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(91, 30)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "btnSetup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'txtXmin
        '
        Me.txtXmin.Location = New System.Drawing.Point(63, 250)
        Me.txtXmin.Name = "txtXmin"
        Me.txtXmin.Size = New System.Drawing.Size(71, 21)
        Me.txtXmin.TabIndex = 2
        Me.txtXmin.Text = "-100"
        '
        'txtXmax
        '
        Me.txtXmax.Location = New System.Drawing.Point(140, 250)
        Me.txtXmax.Name = "txtXmax"
        Me.txtXmax.Size = New System.Drawing.Size(71, 21)
        Me.txtXmax.TabIndex = 2
        Me.txtXmax.Text = "100"
        '
        'txtYmin
        '
        Me.txtYmin.Location = New System.Drawing.Point(63, 275)
        Me.txtYmin.Name = "txtYmin"
        Me.txtYmin.Size = New System.Drawing.Size(71, 21)
        Me.txtYmin.TabIndex = 2
        Me.txtYmin.Text = "-50"
        '
        'txtYmax
        '
        Me.txtYmax.Location = New System.Drawing.Point(140, 275)
        Me.txtYmax.Name = "txtYmax"
        Me.txtYmax.Size = New System.Drawing.Size(71, 21)
        Me.txtYmax.TabIndex = 2
        Me.txtYmax.Text = "50"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 332)
        Me.Controls.Add(Me.txtYmax)
        Me.Controls.Add(Me.txtXmax)
        Me.Controls.Add(Me.txtYmin)
        Me.Controls.Add(Me.txtXmin)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.picCanvas)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents txtXmin As System.Windows.Forms.TextBox
    Friend WithEvents txtXmax As System.Windows.Forms.TextBox
    Friend WithEvents txtYmin As System.Windows.Forms.TextBox
    Friend WithEvents txtYmax As System.Windows.Forms.TextBox

End Class
