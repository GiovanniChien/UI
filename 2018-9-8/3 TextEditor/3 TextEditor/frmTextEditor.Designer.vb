<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTextEditor))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbrClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrRed = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrBlue = New System.Windows.Forms.ToolStripButton()
        Me.tbrUppercase = New System.Windows.Forms.ToolStripButton()
        Me.tbrLowercase = New System.Windows.Forms.ToolStripButton()
        Me.tbrAbout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrClear, Me.ToolStripSeparator1, Me.tbrRed, Me.ToolStripSeparator2, Me.tbrBlue, Me.tbrUppercase, Me.tbrLowercase, Me.tbrAbout, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(574, 39)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbrClear
        '
        Me.tbrClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrClear.Image = CType(resources.GetObject("tbrClear.Image"), System.Drawing.Image)
        Me.tbrClear.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrClear.Name = "tbrClear"
        Me.tbrClear.Size = New System.Drawing.Size(36, 36)
        Me.tbrClear.Text = "Clear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tbrRed
        '
        Me.tbrRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRed.Image = CType(resources.GetObject("tbrRed.Image"), System.Drawing.Image)
        Me.tbrRed.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrRed.Name = "tbrRed"
        Me.tbrRed.Size = New System.Drawing.Size(36, 36)
        Me.tbrRed.Text = "Red"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tbrBlue
        '
        Me.tbrBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrBlue.Image = CType(resources.GetObject("tbrBlue.Image"), System.Drawing.Image)
        Me.tbrBlue.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrBlue.Name = "tbrBlue"
        Me.tbrBlue.Size = New System.Drawing.Size(36, 36)
        Me.tbrBlue.Text = "Blue"
        '
        'tbrUppercase
        '
        Me.tbrUppercase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrUppercase.Image = CType(resources.GetObject("tbrUppercase.Image"), System.Drawing.Image)
        Me.tbrUppercase.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrUppercase.Name = "tbrUppercase"
        Me.tbrUppercase.Size = New System.Drawing.Size(36, 36)
        Me.tbrUppercase.Text = "UpperCase"
        '
        'tbrLowercase
        '
        Me.tbrLowercase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrLowercase.Image = CType(resources.GetObject("tbrLowercase.Image"), System.Drawing.Image)
        Me.tbrLowercase.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrLowercase.Name = "tbrLowercase"
        Me.tbrLowercase.Size = New System.Drawing.Size(36, 36)
        Me.tbrLowercase.Text = "Lowercase"
        '
        'tbrAbout
        '
        Me.tbrAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrAbout.Image = CType(resources.GetObject("tbrAbout.Image"), System.Drawing.Image)
        Me.tbrAbout.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrAbout.Name = "tbrAbout"
        Me.tbrAbout.Size = New System.Drawing.Size(36, 36)
        Me.tbrAbout.Text = "About"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 353)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(574, 36)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(85, 31)
        Me.sslStatus.Text = "Ready"
        '
        'txtEdit
        '
        Me.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEdit.Location = New System.Drawing.Point(0, 39)
        Me.txtEdit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 20)
        Me.txtEdit.Multiline = True
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEdit.Size = New System.Drawing.Size(574, 314)
        Me.txtEdit.TabIndex = 2
        '
        'frmTextEditor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(574, 389)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmTextEditor"
        Me.Text = "TextEditor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tbrClear As ToolStripButton
    Friend WithEvents tbrRed As ToolStripButton
    Friend WithEvents tbrBlue As ToolStripButton
    Friend WithEvents tbrUppercase As ToolStripButton
    Friend WithEvents tbrLowercase As ToolStripButton
    Friend WithEvents tbrAbout As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sslStatus As ToolStripStatusLabel
    Friend WithEvents txtEdit As TextBox
End Class
