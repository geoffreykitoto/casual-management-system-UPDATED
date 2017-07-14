<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class casual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(casual))
        Dim CASUAL_NAMELabel As System.Windows.Forms.Label
        Dim CASUAL_IDLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim JOININGDATELabel As System.Windows.Forms.Label
        Dim SECTIONLabel As System.Windows.Forms.Label
        Dim CONTACT_NUMBERLabel As System.Windows.Forms.Label
        Dim GENDERLabel As System.Windows.Forms.Label
        Dim PERMANENT_ADDRESSLabel As System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ADD = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CasualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CasualdatabaseDataSet = New casual_management_system_mdi.casualdatabaseDataSet()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CasualTableAdapter = New casual_management_system_mdi.casualdatabaseDataSetTableAdapters.casualTableAdapter()
        Me.TableAdapterManager = New casual_management_system_mdi.casualdatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CasualDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CasualBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CASUAL_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.CASUAL_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.JOININGDATETextBox = New System.Windows.Forms.TextBox()
        Me.SECTIONTextBox = New System.Windows.Forms.TextBox()
        Me.CONTACT_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.GENDERTextBox = New System.Windows.Forms.TextBox()
        Me.PERMANENT_ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.CasualDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CASUAL_NAMELabel = New System.Windows.Forms.Label()
        CASUAL_IDLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        JOININGDATELabel = New System.Windows.Forms.Label()
        SECTIONLabel = New System.Windows.Forms.Label()
        CONTACT_NUMBERLabel = New System.Windows.Forms.Label()
        GENDERLabel = New System.Windows.Forms.Label()
        PERMANENT_ADDRESSLabel = New System.Windows.Forms.Label()
        CType(Me.CasualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasualdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasualDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CasualDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(386, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(337, 31)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "CASUAL DETAILS FORM"
        '
        'ADD
        '
        Me.ADD.Location = New System.Drawing.Point(424, 71)
        Me.ADD.Name = "ADD"
        Me.ADD.Size = New System.Drawing.Size(116, 76)
        Me.ADD.TabIndex = 17
        Me.ADD.Text = "ADD NEW RECORD"
        Me.ADD.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(424, 177)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 75)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CasualBindingSource
        '
        Me.CasualBindingSource.DataMember = "casual"
        Me.CasualBindingSource.DataSource = Me.CasualdatabaseDataSet
        '
        'CasualdatabaseDataSet
        '
        Me.CasualdatabaseDataSet.DataSetName = "casualdatabaseDataSet"
        Me.CasualdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'CasualTableAdapter
        '
        Me.CasualTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendancetableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.casualTableAdapter = Me.CasualTableAdapter
        Me.TableAdapterManager.logintableTableAdapter = Nothing
        Me.TableAdapterManager.payrolltTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = casual_management_system_mdi.casualdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CasualDataGridView
        '
        Me.CasualDataGridView.AutoGenerateColumns = False
        Me.CasualDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CasualDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.CasualDataGridView.DataSource = Me.CasualBindingSource
        Me.CasualDataGridView.Location = New System.Drawing.Point(927, 395)
        Me.CasualDataGridView.Name = "CasualDataGridView"
        Me.CasualDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.CasualDataGridView.TabIndex = 31
        Me.CasualDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CASUAL_NAME"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CASUAL_NAME"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CASUAL_ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CASUAL_ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn11.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "JOININGDATE"
        Me.DataGridViewTextBoxColumn12.HeaderText = "JOININGDATE"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SECTION"
        Me.DataGridViewTextBoxColumn13.HeaderText = "SECTION"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CONTACT_NUMBER"
        Me.DataGridViewTextBoxColumn14.HeaderText = "CONTACT_NUMBER"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "GENDER"
        Me.DataGridViewTextBoxColumn15.HeaderText = "GENDER"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "PERMANENT_ADDRESS"
        Me.DataGridViewTextBoxColumn16.HeaderText = "PERMANENT_ADDRESS"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CasualBindingNavigatorSaveItem
        '
        Me.CasualBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CasualBindingNavigatorSaveItem.Image = CType(resources.GetObject("CasualBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CasualBindingNavigatorSaveItem.Name = "CasualBindingNavigatorSaveItem"
        Me.CasualBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CasualBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(584, 443)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(CASUAL_NAMELabel)
        Me.TabPage1.Controls.Add(Me.CASUAL_NAMETextBox)
        Me.TabPage1.Controls.Add(CASUAL_IDLabel)
        Me.TabPage1.Controls.Add(Me.CASUAL_IDTextBox)
        Me.TabPage1.Controls.Add(DOBLabel)
        Me.TabPage1.Controls.Add(Me.DOBTextBox)
        Me.TabPage1.Controls.Add(JOININGDATELabel)
        Me.TabPage1.Controls.Add(Me.JOININGDATETextBox)
        Me.TabPage1.Controls.Add(SECTIONLabel)
        Me.TabPage1.Controls.Add(Me.SECTIONTextBox)
        Me.TabPage1.Controls.Add(CONTACT_NUMBERLabel)
        Me.TabPage1.Controls.Add(Me.CONTACT_NUMBERTextBox)
        Me.TabPage1.Controls.Add(GENDERLabel)
        Me.TabPage1.Controls.Add(Me.GENDERTextBox)
        Me.TabPage1.Controls.Add(PERMANENT_ADDRESSLabel)
        Me.TabPage1.Controls.Add(Me.PERMANENT_ADDRESSTextBox)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.ADD)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(576, 417)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TextBox9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(452, 417)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(18, 367)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 23)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "PRINT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(103, 13)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(122, 20)
        Me.TextBox9.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Enter Casual Id"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(231, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(18, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 288)
        Me.Panel2.TabIndex = 30
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 10)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(401, 275)
        Me.RichTextBox1.TabIndex = 26
        Me.RichTextBox1.Text = ""
        '
        'CASUAL_NAMELabel
        '
        CASUAL_NAMELabel.AutoSize = True
        CASUAL_NAMELabel.Location = New System.Drawing.Point(33, 37)
        CASUAL_NAMELabel.Name = "CASUAL_NAMELabel"
        CASUAL_NAMELabel.Size = New System.Drawing.Size(86, 13)
        CASUAL_NAMELabel.TabIndex = 30
        CASUAL_NAMELabel.Text = "CASUAL NAME:"
        '
        'CASUAL_NAMETextBox
        '
        Me.CASUAL_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CasualBindingSource, "CASUAL_NAME", True))
        Me.CASUAL_NAMETextBox.Location = New System.Drawing.Point(172, 34)
        Me.CASUAL_NAMETextBox.Name = "CASUAL_NAMETextBox"
        Me.CASUAL_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CASUAL_NAMETextBox.TabIndex = 31
        '
        'CASUAL_IDLabel
        '
        CASUAL_IDLabel.AutoSize = True
        CASUAL_IDLabel.Location = New System.Drawing.Point(33, 63)
        CASUAL_IDLabel.Name = "CASUAL_IDLabel"
        CASUAL_IDLabel.Size = New System.Drawing.Size(66, 13)
        CASUAL_IDLabel.TabIndex = 32
        CASUAL_IDLabel.Text = "CASUAL ID:"
        '
        'CASUAL_IDTextBox
        '
        Me.CASUAL_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CasualBindingSource, "CASUAL_ID", True))
        Me.CASUAL_IDTextBox.Location = New System.Drawing.Point(172, 60)
        Me.CASUAL_IDTextBox.Name = "CASUAL_IDTextBox"
        Me.CASUAL_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CASUAL_IDTextBox.TabIndex = 33
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(33, 89)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 34
        DOBLabel.Text = "DOB:"
        '
        'DOBTextBox
        '
        Me.DOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CasualBindingSource, "DOB", True))
        Me.DOBTextBox.Location = New System.Drawing.Point(172, 86)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DOBTextBox.TabIndex = 35
        '
        'JOININGDATELabel
        '
        JOININGDATELabel.AutoSize = True
        JOININGDATELabel.Location = New System.Drawing.Point(33, 115)
        JOININGDATELabel.Name = "JOININGDATELabel"
        JOININGDATELabel.Size = New System.Drawing.Size(99, 13)
        JOININGDATELabel.TabIndex = 36
        JOININGDATELabel.Text = "DATE OF JOINING"
        '
        'JOININGDATETextBox
        '
        Me.JOININGDATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CasualBindingSource, "JOININGDATE", True))
        Me.JOININGDATETextBox.Location = New System.Drawing.Point(172, 112)
        Me.JOININGDATETextBox.Name = "JOININGDATETextBox"
        Me.JOININGDATETextBox.Size = New System.Drawing.Size(100, 20)
        Me.JOININGDATETextBox.TabIndex = 37
        '
        'SECTIONLabel
        '
        SECTIONLabel.AutoSize = True
        SECTIONLabel.Location = New System.Drawing.Point(33, 141)
        SECTIONLabel.Name = "SECTIONLabel"
        SECTIONLabel.Size = New System.Drawing.Size(57, 13)
        SECTIONLabel.TabIndex = 38
        SECTIONLabel.Text = "SECTION:"
        '
        'SECTIONTextBox
        '
        Me.SECTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CasualBindingSource, "SECTION", True))
        Me.SECTIONTextBox.Location = New System.Drawing.Point(172, 138)
        Me.SECTIONTextBox.Name = "SECTIONTextBox"
        Me.SECTIONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SECTIONTextBox.TabIndex = 39
        '
        'CONTACT_NUMBERLabel
        '
        CONTACT_NUMBERLabel.AutoSize = True
        CONTACT_NUMBERLabel.Location = New System.Drawing.Point(33, 167)
        CONTACT_NUMBERLabel.Name = "CONTACT_NUMBERLabel"
        CONTACT_NUMBERLabel.Size = New System.Drawing.Size(111, 13)
        CONTACT_NUMBERLabel.TabIndex = 40
        CONTACT_NUMBERLabel.Text = "CONTACT NUMBER:"
        '
        'CONTACT_NUMBERTextBox
        '
        Me.CONTACT_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CasualBindingSource, "CONTACT_NUMBER", True))
        Me.CONTACT_NUMBERTextBox.Location = New System.Drawing.Point(172, 164)
        Me.CONTACT_NUMBERTextBox.Name = "CONTACT_NUMBERTextBox"
        Me.CONTACT_NUMBERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CONTACT_NUMBERTextBox.TabIndex = 41
        '
        'GENDERLabel
        '
        GENDERLabel.AutoSize = True
        GENDERLabel.Location = New System.Drawing.Point(33, 193)
        GENDERLabel.Name = "GENDERLabel"
        GENDERLabel.Size = New System.Drawing.Size(56, 13)
        GENDERLabel.TabIndex = 42
        GENDERLabel.Text = "GENDER:"
        '
        'GENDERTextBox
        '
        Me.GENDERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CasualBindingSource, "GENDER", True))
        Me.GENDERTextBox.Location = New System.Drawing.Point(172, 190)
        Me.GENDERTextBox.Name = "GENDERTextBox"
        Me.GENDERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GENDERTextBox.TabIndex = 43
        '
        'PERMANENT_ADDRESSLabel
        '
        PERMANENT_ADDRESSLabel.AutoSize = True
        PERMANENT_ADDRESSLabel.Location = New System.Drawing.Point(33, 219)
        PERMANENT_ADDRESSLabel.Name = "PERMANENT_ADDRESSLabel"
        PERMANENT_ADDRESSLabel.Size = New System.Drawing.Size(133, 13)
        PERMANENT_ADDRESSLabel.TabIndex = 44
        PERMANENT_ADDRESSLabel.Text = "PERMANENT ADDRESS:"
        '
        'PERMANENT_ADDRESSTextBox
        '
        Me.PERMANENT_ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CasualBindingSource, "PERMANENT_ADDRESS", True))
        Me.PERMANENT_ADDRESSTextBox.Location = New System.Drawing.Point(172, 216)
        Me.PERMANENT_ADDRESSTextBox.Name = "PERMANENT_ADDRESSTextBox"
        Me.PERMANENT_ADDRESSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PERMANENT_ADDRESSTextBox.TabIndex = 45
        '
        'CasualDataGridView1
        '
        Me.CasualDataGridView1.AutoGenerateColumns = False
        Me.CasualDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.CasualDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CasualDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.CasualDataGridView1.DataSource = Me.CasualBindingSource
        Me.CasualDataGridView1.Location = New System.Drawing.Point(614, 77)
        Me.CasualDataGridView1.Name = "CasualDataGridView1"
        Me.CasualDataGridView1.Size = New System.Drawing.Size(607, 227)
        Me.CasualDataGridView1.TabIndex = 32
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CASUAL_NAME"
        Me.DataGridViewTextBoxColumn17.HeaderText = "CASUAL_NAME"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 111
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CASUAL_ID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "CASUAL_ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 91
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn19.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 55
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "JOININGDATE"
        Me.DataGridViewTextBoxColumn20.HeaderText = "JOININGDATE"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 104
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "SECTION"
        Me.DataGridViewTextBoxColumn21.HeaderText = "SECTION"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 79
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "CONTACT_NUMBER"
        Me.DataGridViewTextBoxColumn22.HeaderText = "CONTACT_NUMBER"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 136
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "GENDER"
        Me.DataGridViewTextBoxColumn23.HeaderText = "GENDER"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 78
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "PERMANENT_ADDRESS"
        Me.DataGridViewTextBoxColumn24.HeaderText = "PERMANENT_ADDRESS"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 158
        '
        'casual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1276, 750)
        Me.Controls.Add(Me.CasualDataGridView1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CasualDataGridView)
        Me.Controls.Add(Me.Label9)
        Me.Name = "casual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Casual Details Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CasualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasualdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasualDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.CasualDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents ADD As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button3 As Button

    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CasualBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents CasualdatabaseDataSet As casualdatabaseDataSet
    Friend WithEvents CasualBindingSource As BindingSource
    Friend WithEvents CasualTableAdapter As casualdatabaseDataSetTableAdapters.casualTableAdapter
    Friend WithEvents TableAdapterManager As casualdatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CasualDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CASUAL_NAMETextBox As TextBox
    Friend WithEvents CASUAL_IDTextBox As TextBox
    Friend WithEvents DOBTextBox As TextBox
    Friend WithEvents JOININGDATETextBox As TextBox
    Friend WithEvents SECTIONTextBox As TextBox
    Friend WithEvents CONTACT_NUMBERTextBox As TextBox
    Friend WithEvents GENDERTextBox As TextBox
    Friend WithEvents PERMANENT_ADDRESSTextBox As TextBox
    Friend WithEvents CasualDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
End Class
