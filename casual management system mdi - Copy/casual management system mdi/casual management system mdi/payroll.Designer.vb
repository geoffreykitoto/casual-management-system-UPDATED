<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payroll
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
        Me.components = New System.ComponentModel.Container()
        Dim Casual_idLabel As System.Windows.Forms.Label
        Dim Casual_nameLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim ShiftLabel As System.Windows.Forms.Label
        Dim Hourly_rateLabel As System.Windows.Forms.Label
        Dim Hours_workedLabel As System.Windows.Forms.Label
        Dim PayeLabel As System.Windows.Forms.Label
        Dim NhifLabel As System.Windows.Forms.Label
        Dim BasicpayLabel As System.Windows.Forms.Label
        Dim NetpayLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.CasualdatabaseDataSet = New casual_management_system_mdi.casualdatabaseDataSet()
        Me.PayrolltBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrolltTableAdapter = New casual_management_system_mdi.casualdatabaseDataSetTableAdapters.payrolltTableAdapter()
        Me.TableAdapterManager = New casual_management_system_mdi.casualdatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PayrolltDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.REPORT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.COMPUTE = New System.Windows.Forms.Button()
        Me.Casual_idTextBox = New System.Windows.Forms.TextBox()
        Me.Casual_nameTextBox = New System.Windows.Forms.TextBox()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.ShiftTextBox = New System.Windows.Forms.TextBox()
        Me.Hourly_rateTextBox = New System.Windows.Forms.TextBox()
        Me.Hours_workedTextBox = New System.Windows.Forms.TextBox()
        Me.PayeTextBox = New System.Windows.Forms.TextBox()
        Me.NhifTextBox = New System.Windows.Forms.TextBox()
        Me.BasicpayTextBox = New System.Windows.Forms.TextBox()
        Me.NetpayTextBox = New System.Windows.Forms.TextBox()
        Me.PayrolltDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Casual_idLabel = New System.Windows.Forms.Label()
        Casual_nameLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        ShiftLabel = New System.Windows.Forms.Label()
        Hourly_rateLabel = New System.Windows.Forms.Label()
        Hours_workedLabel = New System.Windows.Forms.Label()
        PayeLabel = New System.Windows.Forms.Label()
        NhifLabel = New System.Windows.Forms.Label()
        BasicpayLabel = New System.Windows.Forms.Label()
        NetpayLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.CasualdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolltBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrolltDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PayrolltDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(524, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 80)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "ADD NEW RECORD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'CasualdatabaseDataSet
        '
        Me.CasualdatabaseDataSet.DataSetName = "casualdatabaseDataSet"
        Me.CasualdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayrolltBindingSource1
        '
        Me.PayrolltBindingSource1.DataMember = "payrollt"
        Me.PayrolltBindingSource1.DataSource = Me.CasualdatabaseDataSet
        '
        'PayrolltTableAdapter
        '
        Me.PayrolltTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendancetableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.casualTableAdapter = Nothing
        Me.TableAdapterManager.logintableTableAdapter = Nothing
        Me.TableAdapterManager.payrolltTableAdapter = Me.PayrolltTableAdapter
        Me.TableAdapterManager.UpdateOrder = casual_management_system_mdi.casualdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PayrolltDataGridView
        '
        Me.PayrolltDataGridView.AutoGenerateColumns = False
        Me.PayrolltDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrolltDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.PayrolltDataGridView.DataSource = Me.PayrolltBindingSource1
        Me.PayrolltDataGridView.Location = New System.Drawing.Point(540, 391)
        Me.PayrolltDataGridView.Name = "PayrolltDataGridView"
        Me.PayrolltDataGridView.Size = New System.Drawing.Size(13, 21)
        Me.PayrolltDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "casual_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "casual_id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "casual_name"
        Me.DataGridViewTextBoxColumn12.HeaderText = "casual_name"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "section"
        Me.DataGridViewTextBoxColumn13.HeaderText = "section"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "shift"
        Me.DataGridViewTextBoxColumn14.HeaderText = "shift"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "hourly_rate"
        Me.DataGridViewTextBoxColumn15.HeaderText = "hourly_rate"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "hours_worked"
        Me.DataGridViewTextBoxColumn16.HeaderText = "hours_worked"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "paye"
        Me.DataGridViewTextBoxColumn17.HeaderText = "paye"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "nhif"
        Me.DataGridViewTextBoxColumn18.HeaderText = "nhif"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "basicpay"
        Me.DataGridViewTextBoxColumn19.HeaderText = "basicpay"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "netpay"
        Me.DataGridViewTextBoxColumn20.HeaderText = "netpay"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(524, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 72)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(737, 528)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Casual_idLabel)
        Me.TabPage1.Controls.Add(Me.Casual_idTextBox)
        Me.TabPage1.Controls.Add(Casual_nameLabel)
        Me.TabPage1.Controls.Add(Me.Casual_nameTextBox)
        Me.TabPage1.Controls.Add(SectionLabel)
        Me.TabPage1.Controls.Add(Me.SectionTextBox)
        Me.TabPage1.Controls.Add(ShiftLabel)
        Me.TabPage1.Controls.Add(Me.ShiftTextBox)
        Me.TabPage1.Controls.Add(Hourly_rateLabel)
        Me.TabPage1.Controls.Add(Me.Hourly_rateTextBox)
        Me.TabPage1.Controls.Add(Hours_workedLabel)
        Me.TabPage1.Controls.Add(Me.Hours_workedTextBox)
        Me.TabPage1.Controls.Add(PayeLabel)
        Me.TabPage1.Controls.Add(Me.PayeTextBox)
        Me.TabPage1.Controls.Add(NhifLabel)
        Me.TabPage1.Controls.Add(Me.NhifTextBox)
        Me.TabPage1.Controls.Add(BasicpayLabel)
        Me.TabPage1.Controls.Add(Me.BasicpayTextBox)
        Me.TabPage1.Controls.Add(NetpayLabel)
        Me.TabPage1.Controls.Add(Me.NetpayTextBox)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(729, 502)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 40)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "PAY ROLL FORM"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.TextBox11)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.REPORT)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(729, 502)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Enter Casual ID:"
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Location = New System.Drawing.Point(139, 15)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(134, 20)
        Me.TextBox11.TabIndex = 32
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(57, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 28)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(414, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 28)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "PRINT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'REPORT
        '
        Me.REPORT.Location = New System.Drawing.Point(292, 15)
        Me.REPORT.Name = "REPORT"
        Me.REPORT.Size = New System.Drawing.Size(71, 29)
        Me.REPORT.TabIndex = 29
        Me.REPORT.Text = "SEARCH"
        Me.REPORT.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.COMPUTE)
        Me.Panel1.Location = New System.Drawing.Point(54, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 327)
        Me.Panel1.TabIndex = 26
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(424, 295)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'COMPUTE
        '
        Me.COMPUTE.Location = New System.Drawing.Point(18, 220)
        Me.COMPUTE.Name = "COMPUTE"
        Me.COMPUTE.Size = New System.Drawing.Size(170, 41)
        Me.COMPUTE.TabIndex = 21
        Me.COMPUTE.Text = "COMPUTE"
        Me.COMPUTE.UseVisualStyleBackColor = True
        '
        'Casual_idLabel
        '
        Casual_idLabel.AutoSize = True
        Casual_idLabel.Location = New System.Drawing.Point(44, 79)
        Casual_idLabel.Name = "Casual_idLabel"
        Casual_idLabel.Size = New System.Drawing.Size(52, 13)
        Casual_idLabel.TabIndex = 27
        Casual_idLabel.Text = "casual id:"
        '
        'Casual_idTextBox
        '
        Me.Casual_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolltBindingSource1, "casual_id", True))
        Me.Casual_idTextBox.Location = New System.Drawing.Point(124, 76)
        Me.Casual_idTextBox.Name = "Casual_idTextBox"
        Me.Casual_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Casual_idTextBox.TabIndex = 28
        '
        'Casual_nameLabel
        '
        Casual_nameLabel.AutoSize = True
        Casual_nameLabel.Location = New System.Drawing.Point(44, 105)
        Casual_nameLabel.Name = "Casual_nameLabel"
        Casual_nameLabel.Size = New System.Drawing.Size(70, 13)
        Casual_nameLabel.TabIndex = 29
        Casual_nameLabel.Text = "casual name:"
        '
        'Casual_nameTextBox
        '
        Me.Casual_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolltBindingSource1, "casual_name", True))
        Me.Casual_nameTextBox.Location = New System.Drawing.Point(124, 102)
        Me.Casual_nameTextBox.Name = "Casual_nameTextBox"
        Me.Casual_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Casual_nameTextBox.TabIndex = 30
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(44, 131)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(44, 13)
        SectionLabel.TabIndex = 31
        SectionLabel.Text = "section:"
        '
        'SectionTextBox
        '
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolltBindingSource1, "section", True))
        Me.SectionTextBox.Location = New System.Drawing.Point(124, 128)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SectionTextBox.TabIndex = 32
        '
        'ShiftLabel
        '
        ShiftLabel.AutoSize = True
        ShiftLabel.Location = New System.Drawing.Point(44, 157)
        ShiftLabel.Name = "ShiftLabel"
        ShiftLabel.Size = New System.Drawing.Size(29, 13)
        ShiftLabel.TabIndex = 33
        ShiftLabel.Text = "shift:"
        '
        'ShiftTextBox
        '
        Me.ShiftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolltBindingSource1, "shift", True))
        Me.ShiftTextBox.Location = New System.Drawing.Point(124, 154)
        Me.ShiftTextBox.Name = "ShiftTextBox"
        Me.ShiftTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShiftTextBox.TabIndex = 34
        '
        'Hourly_rateLabel
        '
        Hourly_rateLabel.AutoSize = True
        Hourly_rateLabel.Location = New System.Drawing.Point(44, 183)
        Hourly_rateLabel.Name = "Hourly_rateLabel"
        Hourly_rateLabel.Size = New System.Drawing.Size(59, 13)
        Hourly_rateLabel.TabIndex = 35
        Hourly_rateLabel.Text = "hourly rate:"
        '
        'Hourly_rateTextBox
        '
        Me.Hourly_rateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolltBindingSource1, "hourly_rate", True))
        Me.Hourly_rateTextBox.Location = New System.Drawing.Point(124, 180)
        Me.Hourly_rateTextBox.Name = "Hourly_rateTextBox"
        Me.Hourly_rateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hourly_rateTextBox.TabIndex = 36
        '
        'Hours_workedLabel
        '
        Hours_workedLabel.AutoSize = True
        Hours_workedLabel.Location = New System.Drawing.Point(44, 209)
        Hours_workedLabel.Name = "Hours_workedLabel"
        Hours_workedLabel.Size = New System.Drawing.Size(74, 13)
        Hours_workedLabel.TabIndex = 37
        Hours_workedLabel.Text = "hours worked:"
        '
        'Hours_workedTextBox
        '
        Me.Hours_workedTextBox.Location = New System.Drawing.Point(124, 206)
        Me.Hours_workedTextBox.Name = "Hours_workedTextBox"
        Me.Hours_workedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hours_workedTextBox.TabIndex = 38
        '
        'PayeLabel
        '
        PayeLabel.AutoSize = True
        PayeLabel.Location = New System.Drawing.Point(44, 235)
        PayeLabel.Name = "PayeLabel"
        PayeLabel.Size = New System.Drawing.Size(33, 13)
        PayeLabel.TabIndex = 39
        PayeLabel.Text = "paye:"
        '
        'PayeTextBox
        '
        Me.PayeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolltBindingSource1, "paye", True))
        Me.PayeTextBox.Location = New System.Drawing.Point(124, 232)
        Me.PayeTextBox.Name = "PayeTextBox"
        Me.PayeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PayeTextBox.TabIndex = 40
        '
        'NhifLabel
        '
        NhifLabel.AutoSize = True
        NhifLabel.Location = New System.Drawing.Point(44, 261)
        NhifLabel.Name = "NhifLabel"
        NhifLabel.Size = New System.Drawing.Size(27, 13)
        NhifLabel.TabIndex = 41
        NhifLabel.Text = "nhif:"
        '
        'NhifTextBox
        '
        Me.NhifTextBox.Location = New System.Drawing.Point(124, 258)
        Me.NhifTextBox.Name = "NhifTextBox"
        Me.NhifTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NhifTextBox.TabIndex = 42
        Me.NhifTextBox.Text = "200"
        '
        'BasicpayLabel
        '
        BasicpayLabel.AutoSize = True
        BasicpayLabel.Location = New System.Drawing.Point(44, 287)
        BasicpayLabel.Name = "BasicpayLabel"
        BasicpayLabel.Size = New System.Drawing.Size(52, 13)
        BasicpayLabel.TabIndex = 43
        BasicpayLabel.Text = "basicpay:"
        '
        'BasicpayTextBox
        '
        Me.BasicpayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolltBindingSource1, "basicpay", True))
        Me.BasicpayTextBox.Location = New System.Drawing.Point(124, 284)
        Me.BasicpayTextBox.Name = "BasicpayTextBox"
        Me.BasicpayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BasicpayTextBox.TabIndex = 44
        '
        'NetpayLabel
        '
        NetpayLabel.AutoSize = True
        NetpayLabel.Location = New System.Drawing.Point(44, 313)
        NetpayLabel.Name = "NetpayLabel"
        NetpayLabel.Size = New System.Drawing.Size(42, 13)
        NetpayLabel.TabIndex = 45
        NetpayLabel.Text = "netpay:"
        '
        'NetpayTextBox
        '
        Me.NetpayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrolltBindingSource1, "netpay", True))
        Me.NetpayTextBox.Location = New System.Drawing.Point(124, 310)
        Me.NetpayTextBox.Name = "NetpayTextBox"
        Me.NetpayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NetpayTextBox.TabIndex = 46
        '
        'PayrolltDataGridView1
        '
        Me.PayrolltDataGridView1.AutoGenerateColumns = False
        Me.PayrolltDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrolltDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.PayrolltDataGridView1.DataSource = Me.PayrolltBindingSource1
        Me.PayrolltDataGridView1.Location = New System.Drawing.Point(107, 130)
        Me.PayrolltDataGridView1.Name = "PayrolltDataGridView1"
        Me.PayrolltDataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.PayrolltDataGridView1.TabIndex = 29
        Me.PayrolltDataGridView1.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "casual_id"
        Me.DataGridViewTextBoxColumn21.HeaderText = "casual_id"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "casual_name"
        Me.DataGridViewTextBoxColumn22.HeaderText = "casual_name"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "section"
        Me.DataGridViewTextBoxColumn23.HeaderText = "section"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "shift"
        Me.DataGridViewTextBoxColumn24.HeaderText = "shift"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "hourly_rate"
        Me.DataGridViewTextBoxColumn25.HeaderText = "hourly_rate"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "hours_worked"
        Me.DataGridViewTextBoxColumn26.HeaderText = "hours_worked"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "paye"
        Me.DataGridViewTextBoxColumn27.HeaderText = "paye"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "nhif"
        Me.DataGridViewTextBoxColumn28.HeaderText = "nhif"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "basicpay"
        Me.DataGridViewTextBoxColumn29.HeaderText = "basicpay"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "netpay"
        Me.DataGridViewTextBoxColumn30.HeaderText = "netpay"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Label6)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Controls.Add(Label8)
        Me.Panel2.Controls.Add(Label9)
        Me.Panel2.Controls.Add(Label10)
        Me.Panel2.Controls.Add(Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.RichTextBox2)
        Me.Panel2.Controls.Add(Me.PayrolltDataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(768, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(348, 451)
        Me.Panel2.TabIndex = 30
        Me.Panel2.Visible = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(0, 3)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(342, 441)
        Me.RichTextBox2.TabIndex = 30
        Me.RichTextBox2.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(282, 31)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "PAY ROLL REPORT"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.White
        Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(18, 75)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(72, 19)
        Label2.TabIndex = 46
        Label2.Text = "casual id:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.White
        Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(18, 101)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(96, 19)
        Label3.TabIndex = 47
        Label3.Text = "casual name:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.White
        Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(18, 127)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(61, 19)
        Label4.TabIndex = 48
        Label4.Text = "section:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.White
        Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(18, 153)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(43, 19)
        Label5.TabIndex = 49
        Label5.Text = "shift:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.White
        Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(18, 179)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(87, 19)
        Label6.TabIndex = 50
        Label6.Text = "hourly rate:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.White
        Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(18, 205)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(104, 19)
        Label7.TabIndex = 51
        Label7.Text = "hours worked:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.White
        Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(18, 231)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(46, 19)
        Label8.TabIndex = 52
        Label8.Text = "paye:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.White
        Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(18, 257)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(39, 19)
        Label9.TabIndex = 53
        Label9.Text = "nhif:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.BackColor = System.Drawing.Color.White
        Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(18, 283)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(72, 19)
        Label10.TabIndex = 54
        Label10.Text = "basicpay:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.White
        Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(18, 309)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(59, 19)
        Label11.TabIndex = 55
        Label11.Text = "netpay:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(768, 542)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 26)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "REPORT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(150, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(150, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(150, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(150, 153)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(150, 205)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(150, 179)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(150, 231)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(150, 257)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(150, 283)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Label22"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(150, 309)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "Label23"
        '
        'payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1276, 750)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PayrolltDataGridView)
        Me.Name = "payroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "payroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CasualdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolltBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrolltDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PayrolltDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument

    Friend WithEvents PayrolltBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents CasualdatabaseDataSet As casualdatabaseDataSet
    Friend WithEvents PayrolltBindingSource1 As BindingSource
    Friend WithEvents PayrolltTableAdapter As casualdatabaseDataSetTableAdapters.payrolltTableAdapter
    Friend WithEvents TableAdapterManager As casualdatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PayrolltDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents COMPUTE As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents REPORT As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Casual_idTextBox As TextBox
    Friend WithEvents Casual_nameTextBox As TextBox
    Friend WithEvents SectionTextBox As TextBox
    Friend WithEvents ShiftTextBox As TextBox
    Friend WithEvents Hourly_rateTextBox As TextBox
    Friend WithEvents Hours_workedTextBox As TextBox
    Friend WithEvents PayeTextBox As TextBox
    Friend WithEvents NhifTextBox As TextBox
    Friend WithEvents BasicpayTextBox As TextBox
    Friend WithEvents NetpayTextBox As TextBox
    Friend WithEvents PayrolltDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
