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
        Me.btnAddString = New System.Windows.Forms.Button()
        Me.lstFonts = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnShowFonts = New System.Windows.Forms.Button()
        Me.txtSign = New System.Windows.Forms.TextBox()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Location = New System.Drawing.Point(228, 77)
        Me.picCanvas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(630, 531)
        Me.picCanvas.TabIndex = 2
        Me.picCanvas.TabStop = False
        '
        'btnAddString
        '
        Me.btnAddString.Location = New System.Drawing.Point(228, 29)
        Me.btnAddString.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddString.Name = "btnAddString"
        Me.btnAddString.Size = New System.Drawing.Size(160, 31)
        Me.btnAddString.TabIndex = 1
        Me.btnAddString.Text = "btnAddString"
        Me.btnAddString.UseVisualStyleBackColor = True
        '
        'lstFonts
        '
        Me.lstFonts.FormattingEnabled = True
        Me.lstFonts.ItemHeight = 16
        Me.lstFonts.Location = New System.Drawing.Point(16, 77)
        Me.lstFonts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstFonts.Name = "lstFonts"
        Me.lstFonts.Size = New System.Drawing.Size(159, 548)
        Me.lstFonts.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(698, 29)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 31)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnShowFonts
        '
        Me.btnShowFonts.Location = New System.Drawing.Point(16, 29)
        Me.btnShowFonts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShowFonts.Name = "btnShowFonts"
        Me.btnShowFonts.Size = New System.Drawing.Size(160, 31)
        Me.btnShowFonts.TabIndex = 1
        Me.btnShowFonts.Text = "btnShowFonts"
        Me.btnShowFonts.UseVisualStyleBackColor = True
        '
        'txtSign
        '
        Me.txtSign.Location = New System.Drawing.Point(396, 29)
        Me.txtSign.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSign.Name = "txtSign"
        Me.txtSign.Size = New System.Drawing.Size(251, 26)
        Me.txtSign.TabIndex = 4
        Me.txtSign.Text = "人机交互UI"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 648)
        Me.Controls.Add(Me.txtSign)
        Me.Controls.Add(Me.lstFonts)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnShowFonts)
        Me.Controls.Add(Me.btnAddString)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmTest"
        Me.Text = "创建Graphics对象"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddString As System.Windows.Forms.Button
    Friend WithEvents lstFonts As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnShowFonts As System.Windows.Forms.Button
    Friend WithEvents txtSign As System.Windows.Forms.TextBox

End Class
