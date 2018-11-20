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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilePathName = New System.Windows.Forms.TextBox()
        Me.txtDirectoryName = New System.Windows.Forms.TextBox()
        Me.txtFileNameWithoutExtension = New System.Windows.Forms.TextBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(16, 29)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 31)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilePathName
        '
        Me.txtFilePathName.Location = New System.Drawing.Point(124, 75)
        Me.txtFilePathName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilePathName.Name = "txtFilePathName"
        Me.txtFilePathName.Size = New System.Drawing.Size(227, 26)
        Me.txtFilePathName.TabIndex = 1
        '
        'txtDirectoryName
        '
        Me.txtDirectoryName.Location = New System.Drawing.Point(124, 120)
        Me.txtDirectoryName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirectoryName.Name = "txtDirectoryName"
        Me.txtDirectoryName.Size = New System.Drawing.Size(227, 26)
        Me.txtDirectoryName.TabIndex = 1
        '
        'txtFileNameWithoutExtension
        '
        Me.txtFileNameWithoutExtension.Location = New System.Drawing.Point(124, 154)
        Me.txtFileNameWithoutExtension.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFileNameWithoutExtension.Name = "txtFileNameWithoutExtension"
        Me.txtFileNameWithoutExtension.Size = New System.Drawing.Size(227, 26)
        Me.txtFileNameWithoutExtension.TabIndex = 1
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(124, 188)
        Me.txtExtension.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(227, 26)
        Me.txtExtension.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "绝对文件名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "路径名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "文件主名"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "后缀名"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 364)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExtension)
        Me.Controls.Add(Me.txtFileNameWithoutExtension)
        Me.Controls.Add(Me.txtDirectoryName)
        Me.Controls.Add(Me.txtFilePathName)
        Me.Controls.Add(Me.btnBrowse)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFilePathName As System.Windows.Forms.TextBox
    Friend WithEvents txtDirectoryName As System.Windows.Forms.TextBox
    Friend WithEvents txtFileNameWithoutExtension As System.Windows.Forms.TextBox
    Friend WithEvents txtExtension As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
