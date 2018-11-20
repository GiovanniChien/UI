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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.txtParent = New System.Windows.Forms.TextBox()
        Me.txtChild = New System.Windows.Forms.TextBox()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(22, 13)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(100, 31)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(22, 51)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(299, 237)
        Me.TreeView1.TabIndex = 1
        '
        'txtParent
        '
        Me.txtParent.Location = New System.Drawing.Point(345, 12)
        Me.txtParent.Name = "txtParent"
        Me.txtParent.Size = New System.Drawing.Size(100, 26)
        Me.txtParent.TabIndex = 2
        '
        'txtChild
        '
        Me.txtChild.Location = New System.Drawing.Point(345, 44)
        Me.txtChild.Name = "txtChild"
        Me.txtChild.Size = New System.Drawing.Size(100, 26)
        Me.txtChild.TabIndex = 2
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(345, 77)
        Me.btnAppend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(100, 31)
        Me.btnAppend.TabIndex = 0
        Me.btnAppend.Text = "Append"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(22, 312)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 31)
        Me.btnRemove.TabIndex = 0
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(157, 317)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(100, 26)
        Me.txtKey.TabIndex = 2
        Me.txtKey.Text = "Lines"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 390)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtChild)
        Me.Controls.Add(Me.txtParent)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCreate)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents txtParent As System.Windows.Forms.TextBox
    Friend WithEvents txtChild As System.Windows.Forms.TextBox
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtKey As System.Windows.Forms.TextBox

End Class
