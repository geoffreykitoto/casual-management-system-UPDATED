Public Class rptPayroll
    Private Sub rptPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'casualdatabaseDataSet.payrollt' table. You can move, or remove it, as needed.
        Me.payrolltTableAdapter.Fill(Me.casualdatabaseDataSet.payrollt)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class