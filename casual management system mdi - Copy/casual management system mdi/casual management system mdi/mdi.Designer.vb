<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdi
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CASUALFORMToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHIFTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAYROLLFORMToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasualReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CASUALFORMToolStripMenuItem1, Me.SHIFTToolStripMenuItem, Me.PAYROLLFORMToolStripMenuItem1, Me.EXITToolStripMenuItem, Me.REPORTSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CASUALFORMToolStripMenuItem1
        '
        Me.CASUALFORMToolStripMenuItem1.Name = "CASUALFORMToolStripMenuItem1"
        Me.CASUALFORMToolStripMenuItem1.Size = New System.Drawing.Size(99, 20)
        Me.CASUALFORMToolStripMenuItem1.Text = "CASUAL FORM"
        '
        'SHIFTToolStripMenuItem
        '
        Me.SHIFTToolStripMenuItem.Name = "SHIFTToolStripMenuItem"
        Me.SHIFTToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.SHIFTToolStripMenuItem.Text = "ATTENDANCE FORM"
        '
        'PAYROLLFORMToolStripMenuItem1
        '
        Me.PAYROLLFORMToolStripMenuItem1.Name = "PAYROLLFORMToolStripMenuItem1"
        Me.PAYROLLFORMToolStripMenuItem1.Size = New System.Drawing.Size(105, 20)
        Me.PAYROLLFORMToolStripMenuItem1.Text = "PAYROLL FORM"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttendanceReportToolStripMenuItem, Me.CasualReportToolStripMenuItem, Me.PayrollReportToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'AttendanceReportToolStripMenuItem
        '
        Me.AttendanceReportToolStripMenuItem.Name = "AttendanceReportToolStripMenuItem"
        Me.AttendanceReportToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AttendanceReportToolStripMenuItem.Text = "Attendance Report"
        '
        'CasualReportToolStripMenuItem
        '
        Me.CasualReportToolStripMenuItem.Name = "CasualReportToolStripMenuItem"
        Me.CasualReportToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CasualReportToolStripMenuItem.Text = "Casual Report"
        '
        'PayrollReportToolStripMenuItem
        '
        Me.PayrollReportToolStripMenuItem.Name = "PayrollReportToolStripMenuItem"
        Me.PayrollReportToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PayrollReportToolStripMenuItem.Text = "Payroll Report"
        '
        'mdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.casual_management_system_mdi.My.Resources.Resources._150311140216_kenya_flowers_4_super_169
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(964, 356)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mdi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CASUALFORMToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SHIFTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PAYROLLFORMToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CasualReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollReportToolStripMenuItem As ToolStripMenuItem
End Class
