<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLove
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
        Me.btnLove = New System.Windows.Forms.Button()
        Me.picWorld = New System.Windows.Forms.PictureBox()
        Me.lstWords = New System.Windows.Forms.ListBox()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLove
        '
        Me.btnLove.Location = New System.Drawing.Point(12, 12)
        Me.btnLove.Name = "btnLove"
        Me.btnLove.Size = New System.Drawing.Size(78, 27)
        Me.btnLove.TabIndex = 0
        Me.btnLove.Text = "btnLove"
        Me.btnLove.UseVisualStyleBackColor = True
        '
        'picWorld
        '
        Me.picWorld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picWorld.Location = New System.Drawing.Point(12, 188)
        Me.picWorld.Name = "picWorld"
        Me.picWorld.Size = New System.Drawing.Size(496, 314)
        Me.picWorld.TabIndex = 1
        Me.picWorld.TabStop = False
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 12
        Me.lstWords.Location = New System.Drawing.Point(12, 43)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(410, 136)
        Me.lstWords.TabIndex = 2
        '
        'frmLove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 514)
        Me.Controls.Add(Me.lstWords)
        Me.Controls.Add(Me.picWorld)
        Me.Controls.Add(Me.btnLove)
        Me.Name = "frmLove"
        Me.Text = "Form1"
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLove As System.Windows.Forms.Button
    Friend WithEvents picWorld As System.Windows.Forms.PictureBox
    Friend WithEvents lstWords As System.Windows.Forms.ListBox

End Class
