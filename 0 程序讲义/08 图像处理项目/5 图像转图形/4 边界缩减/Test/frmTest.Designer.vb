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
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.txtBluemax = New System.Windows.Forms.TextBox()
        Me.txtGreenmax = New System.Windows.Forms.TextBox()
        Me.txtRedmax = New System.Windows.Forms.TextBox()
        Me.txtBluemin = New System.Windows.Forms.TextBox()
        Me.txtGreenmin = New System.Windows.Forms.TextBox()
        Me.txtRedmin = New System.Windows.Forms.TextBox()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.btnTarget = New System.Windows.Forms.Button()
        Me.lstRegion = New System.Windows.Forms.ListBox()
        Me.btnGetRegions = New System.Windows.Forms.Button()
        Me.lstBorder = New System.Windows.Forms.ListBox()
        Me.btnGetBorders = New System.Windows.Forms.Button()
        Me.txtOrderPoints = New System.Windows.Forms.TextBox()
        Me.btnDisplayOrderPoints = New System.Windows.Forms.Button()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 23)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(77, 27)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'picCanvas
        '
        Me.picCanvas.Location = New System.Drawing.Point(244, 12)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(544, 376)
        Me.picCanvas.TabIndex = 2
        Me.picCanvas.TabStop = False
        '
        'txtBluemax
        '
        Me.txtBluemax.Location = New System.Drawing.Point(70, 110)
        Me.txtBluemax.Name = "txtBluemax"
        Me.txtBluemax.Size = New System.Drawing.Size(34, 21)
        Me.txtBluemax.TabIndex = 6
        Me.txtBluemax.Text = "200"
        '
        'txtGreenmax
        '
        Me.txtGreenmax.Location = New System.Drawing.Point(70, 83)
        Me.txtGreenmax.Name = "txtGreenmax"
        Me.txtGreenmax.Size = New System.Drawing.Size(34, 21)
        Me.txtGreenmax.TabIndex = 7
        Me.txtGreenmax.Text = "255"
        '
        'txtRedmax
        '
        Me.txtRedmax.Location = New System.Drawing.Point(70, 56)
        Me.txtRedmax.Name = "txtRedmax"
        Me.txtRedmax.Size = New System.Drawing.Size(34, 21)
        Me.txtRedmax.TabIndex = 8
        Me.txtRedmax.Text = "200"
        '
        'txtBluemin
        '
        Me.txtBluemin.Location = New System.Drawing.Point(12, 110)
        Me.txtBluemin.Name = "txtBluemin"
        Me.txtBluemin.Size = New System.Drawing.Size(34, 21)
        Me.txtBluemin.TabIndex = 3
        Me.txtBluemin.Text = "0"
        '
        'txtGreenmin
        '
        Me.txtGreenmin.Location = New System.Drawing.Point(12, 83)
        Me.txtGreenmin.Name = "txtGreenmin"
        Me.txtGreenmin.Size = New System.Drawing.Size(34, 21)
        Me.txtGreenmin.TabIndex = 4
        Me.txtGreenmin.Text = "66"
        '
        'txtRedmin
        '
        Me.txtRedmin.Location = New System.Drawing.Point(12, 56)
        Me.txtRedmin.Name = "txtRedmin"
        Me.txtRedmin.Size = New System.Drawing.Size(34, 21)
        Me.txtRedmin.TabIndex = 5
        Me.txtRedmin.Text = "0"
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(12, 137)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(77, 27)
        Me.btnSource.TabIndex = 1
        Me.btnSource.Text = "原图"
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'btnTarget
        '
        Me.btnTarget.Location = New System.Drawing.Point(12, 170)
        Me.btnTarget.Name = "btnTarget"
        Me.btnTarget.Size = New System.Drawing.Size(77, 27)
        Me.btnTarget.TabIndex = 1
        Me.btnTarget.Text = "变色图"
        Me.btnTarget.UseVisualStyleBackColor = True
        '
        'lstRegion
        '
        Me.lstRegion.FormattingEnabled = True
        Me.lstRegion.ItemHeight = 12
        Me.lstRegion.Location = New System.Drawing.Point(2, 263)
        Me.lstRegion.Name = "lstRegion"
        Me.lstRegion.Size = New System.Drawing.Size(115, 352)
        Me.lstRegion.TabIndex = 10
        '
        'btnGetRegions
        '
        Me.btnGetRegions.Location = New System.Drawing.Point(9, 220)
        Me.btnGetRegions.Name = "btnGetRegions"
        Me.btnGetRegions.Size = New System.Drawing.Size(95, 25)
        Me.btnGetRegions.TabIndex = 9
        Me.btnGetRegions.Text = "GetRegions"
        Me.btnGetRegions.UseVisualStyleBackColor = True
        '
        'lstBorder
        '
        Me.lstBorder.FormattingEnabled = True
        Me.lstBorder.ItemHeight = 12
        Me.lstBorder.Location = New System.Drawing.Point(123, 265)
        Me.lstBorder.Name = "lstBorder"
        Me.lstBorder.Size = New System.Drawing.Size(115, 352)
        Me.lstBorder.TabIndex = 10
        '
        'btnGetBorders
        '
        Me.btnGetBorders.Location = New System.Drawing.Point(123, 220)
        Me.btnGetBorders.Name = "btnGetBorders"
        Me.btnGetBorders.Size = New System.Drawing.Size(95, 25)
        Me.btnGetBorders.TabIndex = 9
        Me.btnGetBorders.Text = "GetBorders"
        Me.btnGetBorders.UseVisualStyleBackColor = True
        '
        'txtOrderPoints
        '
        Me.txtOrderPoints.Location = New System.Drawing.Point(244, 436)
        Me.txtOrderPoints.Multiline = True
        Me.txtOrderPoints.Name = "txtOrderPoints"
        Me.txtOrderPoints.Size = New System.Drawing.Size(544, 179)
        Me.txtOrderPoints.TabIndex = 11
        '
        'btnDisplayOrderPoints
        '
        Me.btnDisplayOrderPoints.Location = New System.Drawing.Point(244, 405)
        Me.btnDisplayOrderPoints.Name = "btnDisplayOrderPoints"
        Me.btnDisplayOrderPoints.Size = New System.Drawing.Size(95, 25)
        Me.btnDisplayOrderPoints.TabIndex = 9
        Me.btnDisplayOrderPoints.Text = "显示点序列"
        Me.btnDisplayOrderPoints.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 629)
        Me.Controls.Add(Me.txtOrderPoints)
        Me.Controls.Add(Me.lstBorder)
        Me.Controls.Add(Me.lstRegion)
        Me.Controls.Add(Me.btnDisplayOrderPoints)
        Me.Controls.Add(Me.btnGetBorders)
        Me.Controls.Add(Me.btnGetRegions)
        Me.Controls.Add(Me.txtBluemax)
        Me.Controls.Add(Me.txtGreenmax)
        Me.Controls.Add(Me.txtRedmax)
        Me.Controls.Add(Me.txtBluemin)
        Me.Controls.Add(Me.txtGreenmin)
        Me.Controls.Add(Me.txtRedmin)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.btnTarget)
        Me.Controls.Add(Me.btnSource)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents txtBluemax As System.Windows.Forms.TextBox
    Friend WithEvents txtGreenmax As System.Windows.Forms.TextBox
    Friend WithEvents txtRedmax As System.Windows.Forms.TextBox
    Friend WithEvents txtBluemin As System.Windows.Forms.TextBox
    Friend WithEvents txtGreenmin As System.Windows.Forms.TextBox
    Friend WithEvents txtRedmin As System.Windows.Forms.TextBox
    Friend WithEvents btnSource As System.Windows.Forms.Button
    Friend WithEvents btnTarget As System.Windows.Forms.Button
    Friend WithEvents lstRegion As System.Windows.Forms.ListBox
    Friend WithEvents btnGetRegions As System.Windows.Forms.Button
    Friend WithEvents lstBorder As System.Windows.Forms.ListBox
    Friend WithEvents btnGetBorders As System.Windows.Forms.Button
    Friend WithEvents txtOrderPoints As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayOrderPoints As System.Windows.Forms.Button

End Class
