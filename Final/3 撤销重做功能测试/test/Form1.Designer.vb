<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.initPic = New System.Windows.Forms.Button()
        Me.picLbl = New System.Windows.Forms.PictureBox()
        Me.redo = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.lstOps = New System.Windows.Forms.ListBox()
        CType(Me.picLbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'initPic
        '
        Me.initPic.Location = New System.Drawing.Point(12, 84)
        Me.initPic.Name = "initPic"
        Me.initPic.Size = New System.Drawing.Size(122, 50)
        Me.initPic.TabIndex = 0
        Me.initPic.Text = "initPic"
        Me.initPic.UseVisualStyleBackColor = True
        '
        'picLbl
        '
        Me.picLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLbl.Location = New System.Drawing.Point(140, 30)
        Me.picLbl.Name = "picLbl"
        Me.picLbl.Size = New System.Drawing.Size(185, 350)
        Me.picLbl.TabIndex = 1
        Me.picLbl.TabStop = False
        '
        'redo
        '
        Me.redo.Location = New System.Drawing.Point(12, 268)
        Me.redo.Name = "redo"
        Me.redo.Size = New System.Drawing.Size(122, 47)
        Me.redo.TabIndex = 2
        Me.redo.Text = "redo"
        Me.redo.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(12, 177)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(122, 48)
        Me.btnUndo.TabIndex = 3
        Me.btnUndo.Text = "undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'lstOps
        '
        Me.lstOps.FormattingEnabled = True
        Me.lstOps.ItemHeight = 24
        Me.lstOps.Location = New System.Drawing.Point(348, 30)
        Me.lstOps.Name = "lstOps"
        Me.lstOps.Size = New System.Drawing.Size(440, 340)
        Me.lstOps.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstOps)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.redo)
        Me.Controls.Add(Me.picLbl)
        Me.Controls.Add(Me.initPic)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picLbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents initPic As Button
    Friend WithEvents picLbl As PictureBox
    Friend WithEvents redo As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents lstOps As ListBox
End Class
