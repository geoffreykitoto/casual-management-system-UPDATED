Public Class mdi

    Private Sub mdi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CasualFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub CASUALFORMToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CASUALFORMToolStripMenuItem1.Click
        Dim frm As New casual
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SHIFTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHIFTToolStripMenuItem.Click
        Dim frm As New shift
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PAYROLLFORMToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PAYROLLFORMToolStripMenuItem1.Click
        Dim frm As New payroll
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
        login.Close()
        FmSplash.Close()
    End Sub

    Private Sub AttendanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceReportToolStripMenuItem.Click
        rptAttendance.Show()
    End Sub

    Private Sub CasualReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasualReportToolStripMenuItem.Click
        rptCasual.Show()
    End Sub

    Private Sub PayrollReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollReportToolStripMenuItem.Click
        rptPayroll.Show()
    End Sub
End Class
