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
        Me.txtObjects = New System.Windows.Forms.TextBox()
        Me.txtConstellations = New System.Windows.Forms.TextBox()
        Me.txtMaterials = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 218)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtObjects
        '
        Me.txtObjects.Location = New System.Drawing.Point(12, 41)
        Me.txtObjects.Multiline = True
        Me.txtObjects.Name = "txtObjects"
        Me.txtObjects.Size = New System.Drawing.Size(227, 171)
        Me.txtObjects.TabIndex = 3
        '
        'txtConstellations
        '
        Me.txtConstellations.Location = New System.Drawing.Point(255, 41)
        Me.txtConstellations.Multiline = True
        Me.txtConstellations.Name = "txtConstellations"
        Me.txtConstellations.Size = New System.Drawing.Size(227, 171)
        Me.txtConstellations.TabIndex = 3
        '
        'txtMaterials
        '
        Me.txtMaterials.Location = New System.Drawing.Point(498, 41)
        Me.txtMaterials.Multiline = True
        Me.txtMaterials.Name = "txtMaterials"
        Me.txtMaterials.Size = New System.Drawing.Size(227, 171)
        Me.txtMaterials.TabIndex = 3
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 266)
        Me.Controls.Add(Me.txtMaterials)
        Me.Controls.Add(Me.txtConstellations)
        Me.Controls.Add(Me.txtObjects)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtObjects As System.Windows.Forms.TextBox
    Friend WithEvents txtConstellations As System.Windows.Forms.TextBox
    Friend WithEvents txtMaterials As System.Windows.Forms.TextBox

End Class
