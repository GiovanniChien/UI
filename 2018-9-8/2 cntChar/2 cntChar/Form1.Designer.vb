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
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.radCountChar = New System.Windows.Forms.RadioButton()
        Me.RadCountWord = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(16, 100)
        Me.txtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBox.Multiline = True
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(913, 459)
        Me.txtBox.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(12, 47)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(527, 33)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Enter some words in the labelBox"
        '
        'radCountChar
        '
        Me.radCountChar.AutoSize = True
        Me.radCountChar.Checked = True
        Me.radCountChar.Location = New System.Drawing.Point(16, 582)
        Me.radCountChar.Name = "radCountChar"
        Me.radCountChar.Size = New System.Drawing.Size(190, 37)
        Me.radCountChar.TabIndex = 2
        Me.radCountChar.TabStop = True
        Me.radCountChar.Text = "Character"
        Me.radCountChar.UseVisualStyleBackColor = True
        '
        'RadCountWord
        '
        Me.RadCountWord.AutoSize = True
        Me.RadCountWord.Location = New System.Drawing.Point(251, 582)
        Me.RadCountWord.Name = "RadCountWord"
        Me.RadCountWord.Size = New System.Drawing.Size(110, 37)
        Me.RadCountWord.TabIndex = 3
        Me.RadCountWord.Text = "Word"
        Me.RadCountWord.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 586)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Counting result is"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(705, 586)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(111, 33)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 649)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadCountWord)
        Me.Controls.Add(Me.radCountChar)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtBox)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents radCountChar As RadioButton
    Friend WithEvents RadCountWord As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
End Class
