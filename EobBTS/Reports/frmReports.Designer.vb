<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.crView = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'crView
        '
        Me.crView.ActiveViewIndex = -1
        Me.crView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crView.Cursor = System.Windows.Forms.Cursors.Default
        Me.crView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crView.Location = New System.Drawing.Point(0, 0)
        Me.crView.Name = "crView"
        Me.crView.ReuseParameterValuesOnRefresh = True
        Me.crView.ShowCloseButton = False
        Me.crView.ShowCopyButton = False
        Me.crView.ShowParameterPanelButton = False
        Me.crView.Size = New System.Drawing.Size(800, 450)
        Me.crView.TabIndex = 0
        Me.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crView)
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents crView As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
