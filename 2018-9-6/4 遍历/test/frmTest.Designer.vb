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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lstInfo = New System.Windows.Forms.ListBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(51, 43)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(185, 58)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Button1"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lstInfo
        '
        Me.lstInfo.FormattingEnabled = True
        Me.lstInfo.ItemHeight = 37
        Me.lstInfo.Location = New System.Drawing.Point(51, 234)
        Me.lstInfo.Margin = New System.Windows.Forms.Padding(5)
        Me.lstInfo.Name = "lstInfo"
        Me.lstInfo.Size = New System.Drawing.Size(1113, 337)
        Me.lstInfo.TabIndex = 1
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(51, 146)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(1113, 50)
        Me.txtPath.TabIndex = 2
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(51, 600)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(199, 59)
        Me.btnCount.TabIndex = 3
        Me.btnCount.Text = "btnCount"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(290, 600)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(199, 59)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "btnSearch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(523, 608)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(641, 50)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.Text = "test.sln"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1267, 694)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lstInfo)
        Me.Controls.Add(Me.btnBrowse)
        Me.Font = New System.Drawing.Font("宋体", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents lstInfo As ListBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnCount As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
