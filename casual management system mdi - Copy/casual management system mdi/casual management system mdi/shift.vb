Imports MySql.Data.MySqlClient
Public Class shift
    Dim conn As New MySqlConnection
    Dim comm As New MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.AttendancetableBindingSource1.AddNew()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))

        e.Graphics.DrawImage(bm, 0, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim y As Integer

        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel1.Height += y
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub



    Private Sub shift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CasualdatabaseDataSet.attendancetable' table. You can move, or remove it, as needed.
        Me.AttendancetableTableAdapter.Fill(Me.CasualdatabaseDataSet.attendancetable)
        'TODO: This line of code loads data into the 'CasualdatabaseDataSet.attendancetable' table. You can move, or remove it, as needed.


    End Sub

    Private Sub AttendancetableBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AttendancetableBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CasualdatabaseDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.AttendancetableBindingSource1.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CasualdatabaseDataSet)
            MsgBox("Saved succesfully")
        Catch ex As Exception
            MsgBox("Not Saved succesfully")
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SEARCH_Click(sender As Object, e As EventArgs)
        Dim Connection As MySqlConnection
        Dim command As MySqlCommand
        Connection = New MySqlConnection
        Connection.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Dim reader As MySqlDataReader
        Connection.Open()
        Dim query As String
        query = "Select * from attendancetable where casual_id='" & TextBox1.Text & "'"
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

    Private Sub SEARCH_Click_1(sender As Object, e As EventArgs) Handles SEARCH.Click
        Dim Connection As MySqlConnection
        Dim command As MySqlCommand
        Connection = New MySqlConnection
        Connection.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Dim reader As MySqlDataReader
        Connection.Open()
        Dim query As String
        query = "Select * from attendancetable where casual_id='" & TextBox1.Text & "'"
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

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As Integer

        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel1.Height += y
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.AttendancetableBindingSource1.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CasualdatabaseDataSet)
            MsgBox("Saved succesfully")
        Catch ex As Exception
            MsgBox("Not Saved succesfully")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.AttendancetableBindingSource1.AddNew()
    End Sub

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click
        Dim Conn As MySqlConnection
        Dim mysc As New MySqlCommand
        Conn = New MySqlConnection
        Conn.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Try
            If (MsgBox("Are you sure you want to delete the item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Conn.Open()
                Dim str As String
                str = "DELETE FROM attendancetable WHERE casual_id= '" & TextBox8.Text & "' "
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

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim Conn As MySqlConnection
        Dim mysc As New MySqlCommand
        Conn = New MySqlConnection
        Conn.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Try
            If (MsgBox("Are you sure you want to delete the item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Dim str As String
                str = "DELETE FROM attendancetable WHERE casual_id= '" & TextBox8.Text & "' "
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
End Class