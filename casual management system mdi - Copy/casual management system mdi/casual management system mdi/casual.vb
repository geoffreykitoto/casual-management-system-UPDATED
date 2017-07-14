Imports mySql.Data.MySqlClient

Public Class casual
    Dim conn As New MySqlConnection
    Dim comm As New MySqlCommand
    Dim con As MySqlConnection = New MySqlConnection("server=localhost; user id=root; database=casualdatabase")
    'A SET OF COMMAND IN MYSQL
    Dim cmd As New MySqlCommand
    'SET A CLASS THAT SERVES AS THE BRIDGE BETWEEN A DATASET AND DATABASE FOR SAVING AND RETRIEVING DATA.
    Dim da As New MySqlDataAdapter
    'SET A CLASS THAT CONSISTS SPECIFIC TABLE IN THE DATABASE
    Dim dt As New DataTable
    Dim sqlQuery As String
    Dim result As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ADD.Click
        Me.CasualBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.CasualBindingSource.Clear()
        Dim DELMSG As Integer
        DELMSG = MsgBox("are you sure you want to delete", vbYesNoCancel + vbExclamation, " delete message")
        If DELMSG = 6 Then
            ' Data1.Recordset.DELETE
            MsgBox("record deleted")
        Else
            MsgBox(" record not deleted")
        End If
        conn = New MySqlConnection
        conn.ConnectionString = "server =localhost; userid=root; database=casualdatabase"
        Dim READER As MySqlDataReader
        conn.Open()
        Dim QUERY As String
        QUERY = "delete from  attendancetable where casual_id='" & TextBox9.Text & "'"
        comm = New MySqlCommand(QUERY, conn)
    End Sub

    Private Sub casual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CasualdatabaseDataSet.casual' table. You can move, or remove it, as needed.
        Me.CasualTableAdapter.Fill(Me.CasualdatabaseDataSet.casual)
        'TODO: This line of code loads data into the 'CasualdatabaseDataSet.casual' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim Connection As MySqlConnection
        Dim command As MySqlCommand
        Connection = New MySqlConnection
        Connection.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Dim reader As MySqlDataReader
        Connection.Open()
        Dim query As String
        query = "Select * from casual where casual_id='" & TextBox9.Text & "'"
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
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel2.Width, Me.Panel2.Height)

        Panel2.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel2.Width, Me.Panel2.Height))

        e.Graphics.DrawImage(bm, 0, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim y As Integer

        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel2.Height += y
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CasualBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CasualBindingNavigatorSaveItem.Click
        Me.Validate()


    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            Me.CasualBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CasualdatabaseDataSet)
            MsgBox("Saved succesfully")
        Catch ex As Exception
            MsgBox("Not Saved succesfully")
        End Try
    End Sub

    Private Sub CasualBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CasualBindingNavigatorSaveItem.Click
        Me.Validate()


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim Conn As MySqlConnection
        Dim mysc As New MySqlCommand
        Conn = New MySqlConnection
        Conn.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Try
            If (MsgBox("Are you sure you want to delete the item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Conn.Open()
                Dim str As String
                str = "DELETE FROM casual WHERE casual_id= '" & TextBox9.Text & "' "
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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Connection As MySqlConnection
        Dim command As MySqlCommand
        Connection = New MySqlConnection
        Connection.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Dim reader As MySqlDataReader
        Connection.Open()
        Dim query As String
        query = "Select * from casual where casual_id='" & TextBox9.Text & "'"
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

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Conn As MySqlConnection
        Dim mysc As New MySqlCommand
        Conn = New MySqlConnection
        Conn.ConnectionString = "Server=localhost;userid=root;database=casualdatabase"
        Try
            If (MsgBox("Are you sure you want to delete the item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Conn.Open()
                Dim str As String
                str = "DELETE FROM casual WHERE casual_id= '" & TextBox9.Text & "' "
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

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As Integer

        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel2.Height += y
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub

    Private Sub CasualDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CasualDataGridView.CellContentClick

    End Sub
End Class