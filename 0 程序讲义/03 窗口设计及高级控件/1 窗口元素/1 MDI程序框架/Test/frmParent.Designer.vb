<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParent
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.排列方式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ArrangeIcons = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Cascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_TileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_TileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_CloseAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreate, Me.排列方式ToolStripMenuItem, Me.m_CloseAll})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCreate
        '
        Me.mnuCreate.Name = "mnuCreate"
        Me.mnuCreate.Size = New System.Drawing.Size(77, 20)
        Me.mnuCreate.Text = "创建子窗体"
        '
        '排列方式ToolStripMenuItem
        '
        Me.排列方式ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_ArrangeIcons, Me.m_Cascade, Me.m_TileHorizontal, Me.m_TileVertical})
        Me.排列方式ToolStripMenuItem.Name = "排列方式ToolStripMenuItem"
        Me.排列方式ToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.排列方式ToolStripMenuItem.Text = "排列方式"
        '
        'm_ArrangeIcons
        '
        Me.m_ArrangeIcons.Name = "m_ArrangeIcons"
        Me.m_ArrangeIcons.Size = New System.Drawing.Size(154, 22)
        Me.m_ArrangeIcons.Text = "ArrangeIcons"
        '
        'm_Cascade
        '
        Me.m_Cascade.Name = "m_Cascade"
        Me.m_Cascade.Size = New System.Drawing.Size(154, 22)
        Me.m_Cascade.Text = "Cascade"
        '
        'm_TileHorizontal
        '
        Me.m_TileHorizontal.Name = "m_TileHorizontal"
        Me.m_TileHorizontal.Size = New System.Drawing.Size(154, 22)
        Me.m_TileHorizontal.Text = "TileHorizontal"
        '
        'm_TileVertical
        '
        Me.m_TileVertical.Name = "m_TileVertical"
        Me.m_TileVertical.Size = New System.Drawing.Size(154, 22)
        Me.m_TileVertical.Text = "TileVertical"
        '
        'm_CloseAll
        '
        Me.m_CloseAll.Name = "m_CloseAll"
        Me.m_CloseAll.Size = New System.Drawing.Size(65, 20)
        Me.m_CloseAll.Text = "关闭全部"
        '
        'frmParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmParent"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuCreate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 排列方式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ArrangeIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Cascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_TileHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_CloseAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_TileVertical As System.Windows.Forms.ToolStripMenuItem

End Class
