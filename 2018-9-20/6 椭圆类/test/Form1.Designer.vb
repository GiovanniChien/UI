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
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.m_Tool = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_Line = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_Ellipse = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCanvas.Location = New System.Drawing.Point(0, 24)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(292, 249)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tool})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'm_Tool
        '
        Me.m_Tool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tool_Line, Me.m_Tool_Ellipse})
        Me.m_Tool.Name = "m_Tool"
        Me.m_Tool.Size = New System.Drawing.Size(41, 20)
        Me.m_Tool.Text = "工具"
        '
        'm_Tool_Line
        '
        Me.m_Tool_Line.Name = "m_Tool_Line"
        Me.m_Tool_Line.Size = New System.Drawing.Size(152, 22)
        Me.m_Tool_Line.Text = "线段"
        '
        'm_Tool_Ellipse
        '
        Me.m_Tool_Ellipse.Name = "m_Tool_Ellipse"
        Me.m_Tool_Ellipse.Size = New System.Drawing.Size(152, 22)
        Me.m_Tool_Ellipse.Text = "椭圆"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents m_Tool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_Line As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_Ellipse As System.Windows.Forms.ToolStripMenuItem

End Class
