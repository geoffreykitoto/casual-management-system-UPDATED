Public Class FmSplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 2
        If (ProgressBar1.Value = 10) Then
            Label3.Text = "Reading program files......."
        ElseIf (ProgressBar1.Value = 20) Then
            Label3.Text = "Turning on program......."
        ElseIf (ProgressBar1.Value = 40) Then
            Label3.Text = "Starting database connection......."
        ElseIf (ProgressBar1.Value = 60) Then
            Label3.Text = "Loading the database files.."
        ElseIf (ProgressBar1.Value = 80) Then
            Label3.Text = "Opening Casual Management System........."
        ElseIf (ProgressBar1.Value = 100) Then
            Timer1.Enabled = False
            login.Show()
            Me.Hide()

        End If

    End Sub


    Private Sub FmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = ""
        Timer1.Start()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
