Imports MySql.Data.MySqlClient

Public Class payroll
    Dim conn As New MySqlConnection
    Dim comm As New MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PayrolltBindingSource1.AddNew()
    End Sub

    Private Sub COMPUTE_Click(sender As Object, e As EventArgs)
        ' Dim hoursworked As Int32 = TextBox5.Text
        ' Dim hourlyrate As Int32 = TextBox6.Text
        Dim basicpay As Integer
        Dim nhif As Integer = 200
        Dim paye As Integer = basicpay * (20 / 100)
        'basicpay = hoursworked * hourlyrate
        ' TextBox9.Text = basicpay
        ' TextBox8.Text = (basicpay * 0.2)
        ' TextBox10.Text = basicpay - nhif - paye
    End Sub

    Private Sub REPORT_Click(sender As Object, e As EventArgs)
        RichTextBox1.Text += "" + vbNewLine
        RichTextBox1.Text += "" + vbNewLine
        RichTextBox1.Text += "" + vbNewLine
        RichTextBox1.Text += "" + vbNewLine
        RichTextBox1.Text += "" + vbNewLine
        '  RichTextBox1.Text += "CASUAL NAME:" + vbTab + vbTab + TextBox1.Text + vbNewLine
        ' RichTextBox1.Text += "CASUAL ID:" + vbTab + vbTab + TextBox2.Text + vbNewLine
        'RichTextBox1.Text += "SECTION:" + vbTab + vbTab + TextBox3.Text + vbNewLine
        'RichTextBox1.Text += "SHIFT:" + vbTab + vbTab + vbTab + TextBox4.Text + vbNewLine
        'RichTextBox1.Text += "HOURLY RATE:" + vbTab + vbTab + TextBox5.Text + vbNewLine
        'RichTextBox1.Text += "HOURS WORKED:" + vbTab + vbTab + TextBox6.Text + vbNewLine
        'RichTextBox1.Text += "NHIF:" + vbTab + vbTab + vbTab + TextBox7.Text + vbNewLine
        'RichTextBox1.Text += "PAYE:" + vbTab + vbTab + vbTab + TextBox8.Text + vbNewLine
        'RichTextBox1.Text += "BASIC PAY:" + vbTab + vbTab + TextBox9.Text + vbNewLine
        'RichTextBox1.Text += "NET PAY:" + vbTab + vbTab + TextBox10.Text + vbNewLine
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim y As Integer

        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel1.Height += y
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub

    Private Sub payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CasualdatabaseDataSet.payrollt' table. You can move, or remove it, as needed.
        Me.PayrolltTableAdapter.Fill(Me.CasualdatabaseDataSet.payrollt)
        'TODO: This line of code loads data into the 'CasualdatabaseDataSet.payrollt' table. You can move, or remove it, as needed.

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)
        'Dim hoursworked As Int32 = TextBox5.Text
        'Dim hourlyrate As Int32 = TextBox6.Text
        Dim basicpay As Integer
        Dim nhif As Integer = 200
        Dim paye As Integer = basicpay * (20 / 100)
        'basicpay = hoursworked * hourlyrate
        'TextBox9.Text = basicpay
        'TextBox8.Text = (basicpay * 0.2)
        'TextBox10.Text = basicpay - nhif - paye
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            Me.PayrolltBindingSource1.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CasualdatabaseDataSet)
            MsgBox("Saved succesfully")
        Catch ex As Exception
            MsgBox("Not Saved succesfully")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim Connection As MySqlConnection
        Dim command As MySqlCommand
        Connection = New MySqlConnection
        Connection.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Dim reader As MySqlDataReader
        Connection.Open()
        Dim query As String
        'query = "Select * from payroll where casual_id='" & TextBox1.Text & "'"
        command = New MySqlCommand(query, Connection)
        reader = command.ExecuteReader
        Try
            reader.Read()
            RichTextBox1.Text += "CASUAL NAME:" + vbTab + vbTab + reader.GetString(0) + vbNewLine
            RichTextBox1.Text += "CASUAL ID:" + vbTab + vbTab + reader.GetString(1) + vbNewLine
            RichTextBox1.Text += "DATE OF BIRTH:" + vbTab + vbTab + reader.GetString(2) + vbNewLine
            RichTextBox1.Text += "DATE OF JOINING:" + vbTab + vbTab + reader.GetString(3) + vbNewLine
            RichTextBox1.Text += "SECTION:" + vbTab + vbTab + reader.GetString(4) + vbNewLine
            RichTextBox1.Text += "CONTACT NUMBER:" + vbTab + reader.GetString(5) + vbNewLine
            RichTextBox1.Text += "GENDER:" + vbTab + vbTab + reader.GetString(6) + vbNewLine
            RichTextBox1.Text += "PERMANENT ADDRESS:" + vbTab + reader.GetString(7) + vbNewLine

            reader.Close()
        Catch ex As Exception
            MsgBox("" + ex.Message)
            reader.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Conn As MySqlConnection
        Dim mysc As New MySqlCommand
        Conn = New MySqlConnection
        Conn.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Try
            If (MsgBox("Are you sure you want to delete the item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Conn.Open()
                Dim str As String
                str = "DELETE FROM payrollt WHERE casual_id= '" & TextBox11.Text & "' "
                mysc = New MySqlCommand(str, Conn)
                mysc.ExecuteNonQuery()
                MsgBox("Data Deleted!", MsgBoxStyle.Information)
                Conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Conn.Close()
        End Try

    End Sub

    Private Sub REPORT_Click_1(sender As Object, e As EventArgs) Handles REPORT.Click
        Dim Connection As MySqlConnection
        Dim command As MySqlCommand
        Connection = New MySqlConnection
        Connection.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Dim reader As MySqlDataReader
        Connection.Open()
        Dim query As String
        query = "Select * from payrollt where casual_id='" & TextBox11.Text & "'"
        command = New MySqlCommand(query, Connection)
        reader = command.ExecuteReader
        Try
            reader.Read()
            RichTextBox1.Text += "CASUAL NAME:" + vbTab + vbTab + reader.GetString(0) + vbNewLine
            RichTextBox1.Text += "CASUAL ID:" + vbTab + vbTab + reader.GetString(1) + vbNewLine
            RichTextBox1.Text += "DATE OF BIRTH:" + vbTab + vbTab + reader.GetString(2) + vbNewLine
            RichTextBox1.Text += "DATE OF JOINING:" + vbTab + vbTab + reader.GetString(3) + vbNewLine
            RichTextBox1.Text += "SECTION:" + vbTab + vbTab + reader.GetString(4) + vbNewLine
            RichTextBox1.Text += "CONTACT NUMBER:" + vbTab + reader.GetString(5) + vbNewLine
            RichTextBox1.Text += "GENDER:" + vbTab + vbTab + reader.GetString(6) + vbNewLine
            RichTextBox1.Text += "PERMANENT ADDRESS:" + vbTab + reader.GetString(8) + vbNewLine

            reader.Close()
        Catch ex As Exception
            MsgBox("" + ex.Message)
            reader.Close()
        End Try
    End Sub

    Private Sub TextBox6_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))

        e.Graphics.DrawImage(bm, 0, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim y As Integer

        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel1.Height += y
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub

    Private Sub Hours_workedTextBox_TextChanged(sender As Object, e As EventArgs) Handles Hours_workedTextBox.TextChanged
        Dim hoursworked As Int32 = Hours_workedTextBox.Text
        Dim hourlyrate As Int32 = Hourly_rateTextBox.Text
        Dim basicpay As Integer
        Dim nhif As Integer = 200
        Dim paye As Integer = basicpay * (20 / 100)
        basicpay = hoursworked * hourlyrate
        BasicpayTextBox.Text = basicpay
        PayeTextBox.Text = (basicpay * 0.2)
        NetpayTextBox.Text = basicpay - nhif - paye
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Connection As MySqlConnection
        Dim command As MySqlCommand
        Connection = New MySqlConnection
        Connection.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Dim reader As MySqlDataReader
        Connection.Open()
        Dim query As String
        query = "Select * from payrollt where casual_id='" & TextBox11.Text & "'"
        command = New MySqlCommand(query, Connection)
        reader = command.ExecuteReader
        Try
            reader.Read()

            Label14.Text = reader.GetString(0)
            Label15.Text = reader.GetString(1)
            Label16.Text = reader.GetString(2)
            Label17.Text = reader.GetString(3)
            Label18.Text = reader.GetString(4)
            Label19.Text = reader.GetString(5)
            Label20.Text = reader.GetString(6)
            Label21.Text = reader.GetString(7)
            Label22.Text = reader.GetString(8)
            Label23.Text = reader.GetString(9)

            reader.Close()
            Panel2.Visible = True
        Catch ex As Exception
            MsgBox("" + ex.Message)
            reader.Close()
        End Try
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub
End Class