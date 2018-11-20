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
        Me.btnPanHomeY = New System.Windows.Forms.Button()
        Me.btnPanHomeZ = New System.Windows.Forms.Button()
        Me.btnPanZ2 = New System.Windows.Forms.Button()
        Me.btnPanZ1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPanY2 = New System.Windows.Forms.Button()
        Me.btnPanY1 = New System.Windows.Forms.Button()
        Me.btnPanX1 = New System.Windows.Forms.Button()
        Me.btnPanX2 = New System.Windows.Forms.Button()
        Me.btnPanHome = New System.Windows.Forms.Button()
        Me.btnPanHomeX = New System.Windows.Forms.Button()
        Me.btnXML = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPanHomeY
        '
        Me.btnPanHomeY.Image = Global.Test.My.Resources.Resources.HomeY
        Me.btnPanHomeY.Location = New System.Drawing.Point(188, 24)
        Me.btnPanHomeY.Name = "btnPanHomeY"
        Me.btnPanHomeY.Size = New System.Drawing.Size(60, 50)
        Me.btnPanHomeY.TabIndex = 30
        Me.btnPanHomeY.UseVisualStyleBackColor = True
        '
        'btnPanHomeZ
        '
        Me.btnPanHomeZ.Image = Global.Test.My.Resources.Resources.HomeZ
        Me.btnPanHomeZ.Location = New System.Drawing.Point(188, 174)
        Me.btnPanHomeZ.Name = "btnPanHomeZ"
        Me.btnPanHomeZ.Size = New System.Drawing.Size(60, 50)
        Me.btnPanHomeZ.TabIndex = 29
        Me.btnPanHomeZ.UseVisualStyleBackColor = True
        '
        'btnPanZ2
        '
        Me.btnPanZ2.Image = Global.Test.My.Resources.Resources.Z_
        Me.btnPanZ2.Location = New System.Drawing.Point(270, 139)
        Me.btnPanZ2.Name = "btnPanZ2"
        Me.btnPanZ2.Size = New System.Drawing.Size(43, 85)
        Me.btnPanZ2.TabIndex = 31
        Me.btnPanZ2.UseVisualStyleBackColor = True
        '
        'btnPanZ1
        '
        Me.btnPanZ1.Image = Global.Test.My.Resources.Resources.Z_1
        Me.btnPanZ1.Location = New System.Drawing.Point(270, 24)
        Me.btnPanZ1.Name = "btnPanZ1"
        Me.btnPanZ1.Size = New System.Drawing.Size(43, 85)
        Me.btnPanZ1.TabIndex = 33
        Me.btnPanZ1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPanHomeY)
        Me.GroupBox2.Controls.Add(Me.btnPanHomeZ)
        Me.GroupBox2.Controls.Add(Me.btnPanZ2)
        Me.GroupBox2.Controls.Add(Me.btnPanZ1)
        Me.GroupBox2.Controls.Add(Me.btnPanY2)
        Me.GroupBox2.Controls.Add(Me.btnPanY1)
        Me.GroupBox2.Controls.Add(Me.btnPanX1)
        Me.GroupBox2.Controls.Add(Me.btnPanX2)
        Me.GroupBox2.Controls.Add(Me.btnPanHome)
        Me.GroupBox2.Controls.Add(Me.btnPanHomeX)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("宋体", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 255)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "控制"
        '
        'btnPanY2
        '
        Me.btnPanY2.Image = Global.Test.My.Resources.Resources.Y_
        Me.btnPanY2.Location = New System.Drawing.Point(111, 139)
        Me.btnPanY2.Name = "btnPanY2"
        Me.btnPanY2.Size = New System.Drawing.Size(43, 85)
        Me.btnPanY2.TabIndex = 32
        Me.btnPanY2.UseVisualStyleBackColor = True
        '
        'btnPanY1
        '
        Me.btnPanY1.Image = Global.Test.My.Resources.Resources.Y_1
        Me.btnPanY1.Location = New System.Drawing.Point(111, 24)
        Me.btnPanY1.Name = "btnPanY1"
        Me.btnPanY1.Size = New System.Drawing.Size(43, 85)
        Me.btnPanY1.TabIndex = 25
        Me.btnPanY1.UseVisualStyleBackColor = True
        '
        'btnPanX1
        '
        Me.btnPanX1.Image = Global.Test.My.Resources.Resources.X_1
        Me.btnPanX1.Location = New System.Drawing.Point(160, 97)
        Me.btnPanX1.Name = "btnPanX1"
        Me.btnPanX1.Size = New System.Drawing.Size(88, 50)
        Me.btnPanX1.TabIndex = 24
        Me.btnPanX1.UseVisualStyleBackColor = True
        '
        'btnPanX2
        '
        Me.btnPanX2.Image = Global.Test.My.Resources.Resources.X_
        Me.btnPanX2.Location = New System.Drawing.Point(18, 97)
        Me.btnPanX2.Name = "btnPanX2"
        Me.btnPanX2.Size = New System.Drawing.Size(88, 50)
        Me.btnPanX2.TabIndex = 26
        Me.btnPanX2.UseVisualStyleBackColor = True
        '
        'btnPanHome
        '
        Me.btnPanHome.Image = Global.Test.My.Resources.Resources.Home
        Me.btnPanHome.Location = New System.Drawing.Point(18, 174)
        Me.btnPanHome.Name = "btnPanHome"
        Me.btnPanHome.Size = New System.Drawing.Size(60, 50)
        Me.btnPanHome.TabIndex = 28
        Me.btnPanHome.UseVisualStyleBackColor = True
        '
        'btnPanHomeX
        '
        Me.btnPanHomeX.Image = Global.Test.My.Resources.Resources.HomeX
        Me.btnPanHomeX.Location = New System.Drawing.Point(18, 24)
        Me.btnPanHomeX.Name = "btnPanHomeX"
        Me.btnPanHomeX.Size = New System.Drawing.Size(60, 50)
        Me.btnPanHomeX.TabIndex = 27
        Me.btnPanHomeX.UseVisualStyleBackColor = True
        '
        'btnXML
        '
        Me.btnXML.Location = New System.Drawing.Point(18, 261)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Size = New System.Drawing.Size(75, 23)
        Me.btnXML.TabIndex = 18
        Me.btnXML.Text = "XML"
        Me.btnXML.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(99, 261)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(149, 112)
        Me.ListBox1.TabIndex = 19
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 379)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnXML)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPanHomeY As System.Windows.Forms.Button
    Friend WithEvents btnPanHomeZ As System.Windows.Forms.Button
    Friend WithEvents btnPanZ2 As System.Windows.Forms.Button
    Friend WithEvents btnPanZ1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPanY2 As System.Windows.Forms.Button
    Friend WithEvents btnPanY1 As System.Windows.Forms.Button
    Friend WithEvents btnPanX1 As System.Windows.Forms.Button
    Friend WithEvents btnPanX2 As System.Windows.Forms.Button
    Friend WithEvents btnPanHome As System.Windows.Forms.Button
    Friend WithEvents btnPanHomeX As System.Windows.Forms.Button
    Friend WithEvents btnXML As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
