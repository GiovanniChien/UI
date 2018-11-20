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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnUnion = New System.Windows.Forms.Button()
        Me.lstRegion = New System.Windows.Forms.ListBox()
        Me.RadioCreate = New System.Windows.Forms.RadioButton()
        Me.RadioSelect = New System.Windows.Forms.RadioButton()
        Me.txtR1 = New System.Windows.Forms.TextBox()
        Me.txtR2 = New System.Windows.Forms.TextBox()
        Me.btnRedraw = New System.Windows.Forms.Button()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Location = New System.Drawing.Point(21, 46)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(424, 211)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(40, 279)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(91, 30)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "btnCreate"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnUnion
        '
        Me.btnUnion.Location = New System.Drawing.Point(354, 279)
        Me.btnUnion.Name = "btnUnion"
        Me.btnUnion.Size = New System.Drawing.Size(91, 30)
        Me.btnUnion.TabIndex = 1
        Me.btnUnion.Text = "btnUnion"
        Me.btnUnion.UseVisualStyleBackColor = True
        '
        'lstRegion
        '
        Me.lstRegion.FormattingEnabled = True
        Me.lstRegion.ItemHeight = 12
        Me.lstRegion.Location = New System.Drawing.Point(478, 35)
        Me.lstRegion.Name = "lstRegion"
        Me.lstRegion.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstRegion.Size = New System.Drawing.Size(116, 196)
        Me.lstRegion.TabIndex = 2
        '
        'RadioCreate
        '
        Me.RadioCreate.AutoSize = True
        Me.RadioCreate.Checked = True
        Me.RadioCreate.Location = New System.Drawing.Point(42, 14)
        Me.RadioCreate.Name = "RadioCreate"
        Me.RadioCreate.Size = New System.Drawing.Size(89, 16)
        Me.RadioCreate.TabIndex = 3
        Me.RadioCreate.TabStop = True
        Me.RadioCreate.Text = "RadioCreate"
        Me.RadioCreate.UseVisualStyleBackColor = True
        '
        'RadioSelect
        '
        Me.RadioSelect.AutoSize = True
        Me.RadioSelect.Location = New System.Drawing.Point(170, 14)
        Me.RadioSelect.Name = "RadioSelect"
        Me.RadioSelect.Size = New System.Drawing.Size(89, 16)
        Me.RadioSelect.TabIndex = 3
        Me.RadioSelect.TabStop = True
        Me.RadioSelect.Text = "RadioSelect"
        Me.RadioSelect.UseVisualStyleBackColor = True
        '
        'txtR1
        '
        Me.txtR1.Location = New System.Drawing.Point(508, 257)
        Me.txtR1.Name = "txtR1"
        Me.txtR1.Size = New System.Drawing.Size(85, 21)
        Me.txtR1.TabIndex = 4
        '
        'txtR2
        '
        Me.txtR2.Location = New System.Drawing.Point(508, 284)
        Me.txtR2.Name = "txtR2"
        Me.txtR2.Size = New System.Drawing.Size(85, 21)
        Me.txtR2.TabIndex = 4
        '
        'btnRedraw
        '
        Me.btnRedraw.Location = New System.Drawing.Point(150, 279)
        Me.btnRedraw.Name = "btnRedraw"
        Me.btnRedraw.Size = New System.Drawing.Size(91, 30)
        Me.btnRedraw.TabIndex = 1
        Me.btnRedraw.Text = "btnRedraw"
        Me.btnRedraw.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 332)
        Me.Controls.Add(Me.txtR2)
        Me.Controls.Add(Me.txtR1)
        Me.Controls.Add(Me.RadioSelect)
        Me.Controls.Add(Me.RadioCreate)
        Me.Controls.Add(Me.lstRegion)
        Me.Controls.Add(Me.btnUnion)
        Me.Controls.Add(Me.btnRedraw)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.picCanvas)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnUnion As System.Windows.Forms.Button
    Friend WithEvents lstRegion As System.Windows.Forms.ListBox
    Friend WithEvents RadioCreate As System.Windows.Forms.RadioButton
    Friend WithEvents RadioSelect As System.Windows.Forms.RadioButton
    Friend WithEvents txtR1 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2 As System.Windows.Forms.TextBox
    Friend WithEvents btnRedraw As System.Windows.Forms.Button

End Class
