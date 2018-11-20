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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.picCanvas3D = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.m_Tool = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_DrawPolygon = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_SelectVertex = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_MoveVertex = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.picCanvas3D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCanvas.Location = New System.Drawing.Point(0, 0)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(257, 242)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.picCanvas)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.picCanvas3D)
        Me.SplitContainer1.Size = New System.Drawing.Size(576, 242)
        Me.SplitContainer1.SplitterDistance = 257
        Me.SplitContainer1.TabIndex = 1
        '
        'picCanvas3D
        '
        Me.picCanvas3D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCanvas3D.Location = New System.Drawing.Point(0, 0)
        Me.picCanvas3D.Name = "picCanvas3D"
        Me.picCanvas3D.Size = New System.Drawing.Size(315, 242)
        Me.picCanvas3D.TabIndex = 0
        Me.picCanvas3D.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tool})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'm_Tool
        '
        Me.m_Tool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tool_DrawPolygon, Me.m_Tool_SelectVertex, Me.m_Tool_MoveVertex})
        Me.m_Tool.Name = "m_Tool"
        Me.m_Tool.Size = New System.Drawing.Size(41, 20)
        Me.m_Tool.Text = "工具"
        '
        'm_Tool_DrawPolygon
        '
        Me.m_Tool_DrawPolygon.Name = "m_Tool_DrawPolygon"
        Me.m_Tool_DrawPolygon.Size = New System.Drawing.Size(152, 22)
        Me.m_Tool_DrawPolygon.Text = "多边形"
        '
        'm_Tool_SelectVertex
        '
        Me.m_Tool_SelectVertex.Name = "m_Tool_SelectVertex"
        Me.m_Tool_SelectVertex.Size = New System.Drawing.Size(152, 22)
        Me.m_Tool_SelectVertex.Text = "选择顶点"
        '
        'm_Tool_MoveVertex
        '
        Me.m_Tool_MoveVertex.Name = "m_Tool_MoveVertex"
        Me.m_Tool_MoveVertex.Size = New System.Drawing.Size(152, 22)
        Me.m_Tool_MoveVertex.Text = "移动顶点"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 266)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.picCanvas3D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents picCanvas3D As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents m_Tool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_DrawPolygon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_SelectVertex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_MoveVertex As System.Windows.Forms.ToolStripMenuItem

End Class
