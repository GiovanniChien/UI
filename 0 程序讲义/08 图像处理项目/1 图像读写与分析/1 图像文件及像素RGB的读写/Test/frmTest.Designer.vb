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
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.btnChangeColor = New System.Windows.Forms.Button()
        Me.rdRed = New System.Windows.Forms.RadioButton()
        Me.rdGreen = New System.Windows.Forms.RadioButton()
        Me.rdBlue = New System.Windows.Forms.RadioButton()
        Me.rdGray = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(32, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Location = New System.Drawing.Point(12, 41)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(602, 459)
        Me.picCanvas.TabIndex = 1
        Me.picCanvas.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(649, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Red"
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(696, 52)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(49, 21)
        Me.txtRed.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(649, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Green"
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(696, 81)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(49, 21)
        Me.txtGreen.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(649, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blue"
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(696, 106)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(49, 21)
        Me.txtBlue.TabIndex = 3
        '
        'btnChangeColor
        '
        Me.btnChangeColor.Location = New System.Drawing.Point(123, 12)
        Me.btnChangeColor.Name = "btnChangeColor"
        Me.btnChangeColor.Size = New System.Drawing.Size(84, 23)
        Me.btnChangeColor.TabIndex = 0
        Me.btnChangeColor.Text = "ChangeColor"
        Me.btnChangeColor.UseVisualStyleBackColor = True
        '
        'rdRed
        '
        Me.rdRed.AutoSize = True
        Me.rdRed.Checked = True
        Me.rdRed.Location = New System.Drawing.Point(271, 12)
        Me.rdRed.Name = "rdRed"
        Me.rdRed.Size = New System.Drawing.Size(41, 16)
        Me.rdRed.TabIndex = 4
        Me.rdRed.TabStop = True
        Me.rdRed.Text = "Red"
        Me.rdRed.UseVisualStyleBackColor = True
        '
        'rdGreen
        '
        Me.rdGreen.AutoSize = True
        Me.rdGreen.Location = New System.Drawing.Point(318, 12)
        Me.rdGreen.Name = "rdGreen"
        Me.rdGreen.Size = New System.Drawing.Size(53, 16)
        Me.rdGreen.TabIndex = 4
        Me.rdGreen.Text = "Green"
        Me.rdGreen.UseVisualStyleBackColor = True
        '
        'rdBlue
        '
        Me.rdBlue.AutoSize = True
        Me.rdBlue.Location = New System.Drawing.Point(365, 12)
        Me.rdBlue.Name = "rdBlue"
        Me.rdBlue.Size = New System.Drawing.Size(47, 16)
        Me.rdBlue.TabIndex = 4
        Me.rdBlue.Text = "Blue"
        Me.rdBlue.UseVisualStyleBackColor = True
        '
        'rdGray
        '
        Me.rdGray.AutoSize = True
        Me.rdGray.Location = New System.Drawing.Point(412, 12)
        Me.rdGray.Name = "rdGray"
        Me.rdGray.Size = New System.Drawing.Size(47, 16)
        Me.rdGray.TabIndex = 4
        Me.rdGray.Text = "Gray"
        Me.rdGray.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(522, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 512)
        Me.Controls.Add(Me.rdGray)
        Me.Controls.Add(Me.rdBlue)
        Me.Controls.Add(Me.rdGreen)
        Me.Controls.Add(Me.rdRed)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.btnChangeColor)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBlue As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeColor As System.Windows.Forms.Button
    Friend WithEvents rdRed As System.Windows.Forms.RadioButton
    Friend WithEvents rdGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rdBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rdGray As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
