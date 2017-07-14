Public Class rptAttendance
    Private Sub rptAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'casualdatabaseDataSet.attendancetable' table. You can move, or remove it, as needed.
        Me.attendancetableTableAdapter.Fill(Me.casualdatabaseDataSet.attendancetable)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class