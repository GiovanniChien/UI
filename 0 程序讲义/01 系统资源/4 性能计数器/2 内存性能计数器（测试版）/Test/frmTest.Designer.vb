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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblMemory_InputPages = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMemory_Pages = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblMemory_OutputPages = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblMemoryAvailableMBytes = New System.Windows.Forms.Label()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMemory_InputPages
        '
        Me.lblMemory_InputPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemory_InputPages.Location = New System.Drawing.Point(438, 51)
        Me.lblMemory_InputPages.Name = "lblMemory_InputPages"
        Me.lblMemory_InputPages.Size = New System.Drawing.Size(323, 28)
        Me.lblMemory_InputPages.TabIndex = 9
        '
        'Timer1
        '
        '
        'lblMemory_Pages
        '
        Me.lblMemory_Pages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemory_Pages.Location = New System.Drawing.Point(438, 6)
        Me.lblMemory_Pages.Name = "lblMemory_Pages"
        Me.lblMemory_Pages.Size = New System.Drawing.Size(323, 28)
        Me.lblMemory_Pages.TabIndex = 9
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(438, 139)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(426, 290)
        Me.Chart2.TabIndex = 10
        Me.Chart2.Text = "Chart1"
        '
        'lblMemory_OutputPages
        '
        Me.lblMemory_OutputPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemory_OutputPages.Location = New System.Drawing.Point(438, 95)
        Me.lblMemory_OutputPages.Name = "lblMemory_OutputPages"
        Me.lblMemory_OutputPages.Size = New System.Drawing.Size(323, 28)
        Me.lblMemory_OutputPages.TabIndex = 9
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(12, 139)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(397, 290)
        Me.Chart1.TabIndex = 10
        Me.Chart1.Text = "Chart1"
        '
        'lblMemoryAvailableMBytes
        '
        Me.lblMemoryAvailableMBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemoryAvailableMBytes.Location = New System.Drawing.Point(21, 9)
        Me.lblMemoryAvailableMBytes.Name = "lblMemoryAvailableMBytes"
        Me.lblMemoryAvailableMBytes.Size = New System.Drawing.Size(323, 28)
        Me.lblMemoryAvailableMBytes.TabIndex = 9
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 444)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.lblMemory_Pages)
        Me.Controls.Add(Me.lblMemoryAvailableMBytes)
        Me.Controls.Add(Me.lblMemory_OutputPages)
        Me.Controls.Add(Me.lblMemory_InputPages)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMemory_InputPages As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblMemory_Pages As System.Windows.Forms.Label
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblMemory_OutputPages As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblMemoryAvailableMBytes As System.Windows.Forms.Label

End Class
