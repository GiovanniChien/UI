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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CtrInputStudent = New Test.ctrInput()
        Me.CtrInputBook = New Test.ctrInput()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(55, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(89, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(165, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CtrInputStudent
        '
        Me.CtrInputStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtrInputStudent.Location = New System.Drawing.Point(27, 58)
        Me.CtrInputStudent.Name = "CtrInputStudent"
        Me.CtrInputStudent.Size = New System.Drawing.Size(349, 255)
        Me.CtrInputStudent.TabIndex = 1
        '
        'CtrInputBook
        '
        Me.CtrInputBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtrInputBook.Location = New System.Drawing.Point(408, 58)
        Me.CtrInputBook.Name = "CtrInputBook"
        Me.CtrInputBook.Size = New System.Drawing.Size(349, 255)
        Me.CtrInputBook.TabIndex = 1
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 336)
        Me.Controls.Add(Me.CtrInputBook)
        Me.Controls.Add(Me.CtrInputStudent)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CtrInputStudent As Test.ctrInput
    Friend WithEvents CtrInputBook As Test.ctrInput

End Class
