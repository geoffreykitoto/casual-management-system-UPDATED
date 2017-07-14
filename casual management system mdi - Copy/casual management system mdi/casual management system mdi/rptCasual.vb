Public Class rptCasual
    Private Sub rptCasual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'casualdatabaseDataSet.casual' table. You can move, or remove it, as needed.
        Me.casualTableAdapter.Fill(Me.casualdatabaseDataSet.casual)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class