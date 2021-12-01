<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class casee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(casee))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.القضية = New System.Windows.Forms.TabPage()
        Me.DTPCase_date = New System.Windows.Forms.DateTimePicker()
        Me.CmboCase_status = New System.Windows.Forms.ComboBox()
        Me.TxtL_opp_phone = New System.Windows.Forms.TextBox()
        Me.Txtopp_Lawyer = New System.Windows.Forms.TextBox()
        Me.Txtopp_id = New System.Windows.Forms.TextBox()
        Me.Txtopp_Address = New System.Windows.Forms.TextBox()
        Me.Txtopp_name = New System.Windows.Forms.TextBox()
        Me.Txtcase_type = New System.Windows.Forms.TextBox()
        Me.Txtclient_desc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxetNotes = New System.Windows.Forms.TextBox()
        Me.Txtclient_NUM = New System.Windows.Forms.TextBox()
        Me.TxtCase_cost = New System.Windows.Forms.TextBox()
        Me.Txtjudge = New System.Windows.Forms.TextBox()
        Me.Txtagent = New System.Windows.Forms.TextBox()
        Me.Txtcourt_name = New System.Windows.Forms.TextBox()
        Me.Txtnum_in_court = New System.Windows.Forms.TextBox()
        Me.Txtnum_in_office = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.المرفقات = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.BtnDelet = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Lawyer1DataSet = New LawyerApp.Lawyer1DataSet()
        Me.Lawyer1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.num_in_office = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_in_court = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.court_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Case_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Case_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client_NUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Case_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.case_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opp_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opp_lawyer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.l_opp_phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.القضية.SuspendLayout()
        Me.المرفقات.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Lawyer1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lawyer1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.القضية)
        Me.TabControl1.Controls.Add(Me.المرفقات)
        Me.TabControl1.Location = New System.Drawing.Point(4, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(989, 389)
        Me.TabControl1.TabIndex = 1
        '
        'القضية
        '
        Me.القضية.Controls.Add(Me.DTPCase_date)
        Me.القضية.Controls.Add(Me.CmboCase_status)
        Me.القضية.Controls.Add(Me.TxtL_opp_phone)
        Me.القضية.Controls.Add(Me.Txtopp_Lawyer)
        Me.القضية.Controls.Add(Me.Txtopp_id)
        Me.القضية.Controls.Add(Me.Txtopp_Address)
        Me.القضية.Controls.Add(Me.Txtopp_name)
        Me.القضية.Controls.Add(Me.Txtcase_type)
        Me.القضية.Controls.Add(Me.Txtclient_desc)
        Me.القضية.Controls.Add(Me.Label14)
        Me.القضية.Controls.Add(Me.Label15)
        Me.القضية.Controls.Add(Me.Label16)
        Me.القضية.Controls.Add(Me.Label17)
        Me.القضية.Controls.Add(Me.Label18)
        Me.القضية.Controls.Add(Me.Label19)
        Me.القضية.Controls.Add(Me.Label20)
        Me.القضية.Controls.Add(Me.TxetNotes)
        Me.القضية.Controls.Add(Me.Txtclient_NUM)
        Me.القضية.Controls.Add(Me.TxtCase_cost)
        Me.القضية.Controls.Add(Me.Txtjudge)
        Me.القضية.Controls.Add(Me.Txtagent)
        Me.القضية.Controls.Add(Me.Txtcourt_name)
        Me.القضية.Controls.Add(Me.Txtnum_in_court)
        Me.القضية.Controls.Add(Me.Txtnum_in_office)
        Me.القضية.Controls.Add(Me.Label9)
        Me.القضية.Controls.Add(Me.Label10)
        Me.القضية.Controls.Add(Me.Label11)
        Me.القضية.Controls.Add(Me.Label7)
        Me.القضية.Controls.Add(Me.Label6)
        Me.القضية.Controls.Add(Me.Label5)
        Me.القضية.Controls.Add(Me.Label4)
        Me.القضية.Controls.Add(Me.Label3)
        Me.القضية.Controls.Add(Me.Label2)
        Me.القضية.Controls.Add(Me.Label1)
        Me.القضية.Location = New System.Drawing.Point(4, 22)
        Me.القضية.Name = "القضية"
        Me.القضية.Padding = New System.Windows.Forms.Padding(3)
        Me.القضية.Size = New System.Drawing.Size(981, 363)
        Me.القضية.TabIndex = 0
        Me.القضية.Text = "معلومات القضية"
        Me.القضية.UseVisualStyleBackColor = True
        '
        'DTPCase_date
        '
        Me.DTPCase_date.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPCase_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPCase_date.Location = New System.Drawing.Point(571, 241)
        Me.DTPCase_date.Name = "DTPCase_date"
        Me.DTPCase_date.Size = New System.Drawing.Size(225, 21)
        Me.DTPCase_date.TabIndex = 6
        '
        'CmboCase_status
        '
        Me.CmboCase_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmboCase_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmboCase_status.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmboCase_status.FormattingEnabled = True
        Me.CmboCase_status.Items.AddRange(New Object() {"نشطة", "ارشيف"})
        Me.CmboCase_status.Location = New System.Drawing.Point(155, 35)
        Me.CmboCase_status.Name = "CmboCase_status"
        Me.CmboCase_status.Size = New System.Drawing.Size(225, 22)
        Me.CmboCase_status.TabIndex = 9
        '
        'TxtL_opp_phone
        '
        Me.TxtL_opp_phone.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtL_opp_phone.Location = New System.Drawing.Point(155, 244)
        Me.TxtL_opp_phone.Multiline = True
        Me.TxtL_opp_phone.Name = "TxtL_opp_phone"
        Me.TxtL_opp_phone.Size = New System.Drawing.Size(225, 28)
        Me.TxtL_opp_phone.TabIndex = 15
        '
        'Txtopp_Lawyer
        '
        Me.Txtopp_Lawyer.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtopp_Lawyer.Location = New System.Drawing.Point(155, 208)
        Me.Txtopp_Lawyer.Multiline = True
        Me.Txtopp_Lawyer.Name = "Txtopp_Lawyer"
        Me.Txtopp_Lawyer.Size = New System.Drawing.Size(225, 28)
        Me.Txtopp_Lawyer.TabIndex = 14
        '
        'Txtopp_id
        '
        Me.Txtopp_id.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtopp_id.Location = New System.Drawing.Point(155, 174)
        Me.Txtopp_id.Multiline = True
        Me.Txtopp_id.Name = "Txtopp_id"
        Me.Txtopp_id.Size = New System.Drawing.Size(225, 28)
        Me.Txtopp_id.TabIndex = 13
        '
        'Txtopp_Address
        '
        Me.Txtopp_Address.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtopp_Address.Location = New System.Drawing.Point(155, 139)
        Me.Txtopp_Address.Multiline = True
        Me.Txtopp_Address.Name = "Txtopp_Address"
        Me.Txtopp_Address.Size = New System.Drawing.Size(225, 28)
        Me.Txtopp_Address.TabIndex = 12
        '
        'Txtopp_name
        '
        Me.Txtopp_name.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtopp_name.Location = New System.Drawing.Point(155, 103)
        Me.Txtopp_name.Multiline = True
        Me.Txtopp_name.Name = "Txtopp_name"
        Me.Txtopp_name.Size = New System.Drawing.Size(225, 28)
        Me.Txtopp_name.TabIndex = 11
        '
        'Txtcase_type
        '
        Me.Txtcase_type.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcase_type.Location = New System.Drawing.Point(155, 63)
        Me.Txtcase_type.Multiline = True
        Me.Txtcase_type.Name = "Txtcase_type"
        Me.Txtcase_type.Size = New System.Drawing.Size(225, 28)
        Me.Txtcase_type.TabIndex = 10
        '
        'Txtclient_desc
        '
        Me.Txtclient_desc.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtclient_desc.Location = New System.Drawing.Point(568, 309)
        Me.Txtclient_desc.Multiline = True
        Me.Txtclient_desc.Name = "Txtclient_desc"
        Me.Txtclient_desc.Size = New System.Drawing.Size(225, 28)
        Me.Txtclient_desc.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(407, 279)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 14)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "ملاحظات"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(407, 246)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 14)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "رقم محامي الخصم"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(407, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 14)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "محامي الخصم"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(407, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 14)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "هوية الخصم"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(407, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 14)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "عنوان الخصم"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(407, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 14)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "اسم الخصم"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(407, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 14)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "النوع"
        '
        'TxetNotes
        '
        Me.TxetNotes.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxetNotes.Location = New System.Drawing.Point(155, 278)
        Me.TxetNotes.Multiline = True
        Me.TxetNotes.Name = "TxetNotes"
        Me.TxetNotes.Size = New System.Drawing.Size(225, 78)
        Me.TxetNotes.TabIndex = 16
        '
        'Txtclient_NUM
        '
        Me.Txtclient_NUM.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtclient_NUM.Location = New System.Drawing.Point(571, 275)
        Me.Txtclient_NUM.Multiline = True
        Me.Txtclient_NUM.Name = "Txtclient_NUM"
        Me.Txtclient_NUM.Size = New System.Drawing.Size(225, 28)
        Me.Txtclient_NUM.TabIndex = 7
        '
        'TxtCase_cost
        '
        Me.TxtCase_cost.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCase_cost.Location = New System.Drawing.Point(571, 207)
        Me.TxtCase_cost.Multiline = True
        Me.TxtCase_cost.Name = "TxtCase_cost"
        Me.TxtCase_cost.Size = New System.Drawing.Size(225, 28)
        Me.TxtCase_cost.TabIndex = 5
        '
        'Txtjudge
        '
        Me.Txtjudge.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtjudge.Location = New System.Drawing.Point(572, 138)
        Me.Txtjudge.Multiline = True
        Me.Txtjudge.Name = "Txtjudge"
        Me.Txtjudge.Size = New System.Drawing.Size(225, 28)
        Me.Txtjudge.TabIndex = 3
        '
        'Txtagent
        '
        Me.Txtagent.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtagent.Location = New System.Drawing.Point(571, 173)
        Me.Txtagent.Multiline = True
        Me.Txtagent.Name = "Txtagent"
        Me.Txtagent.Size = New System.Drawing.Size(225, 28)
        Me.Txtagent.TabIndex = 4
        '
        'Txtcourt_name
        '
        Me.Txtcourt_name.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcourt_name.Location = New System.Drawing.Point(572, 97)
        Me.Txtcourt_name.Multiline = True
        Me.Txtcourt_name.Name = "Txtcourt_name"
        Me.Txtcourt_name.Size = New System.Drawing.Size(225, 28)
        Me.Txtcourt_name.TabIndex = 2
        '
        'Txtnum_in_court
        '
        Me.Txtnum_in_court.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnum_in_court.Location = New System.Drawing.Point(572, 63)
        Me.Txtnum_in_court.Multiline = True
        Me.Txtnum_in_court.Name = "Txtnum_in_court"
        Me.Txtnum_in_court.Size = New System.Drawing.Size(225, 28)
        Me.Txtnum_in_court.TabIndex = 1
        '
        'Txtnum_in_office
        '
        Me.Txtnum_in_office.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnum_in_office.Location = New System.Drawing.Point(572, 28)
        Me.Txtnum_in_office.Multiline = True
        Me.Txtnum_in_office.Name = "Txtnum_in_office"
        Me.Txtnum_in_office.ReadOnly = True
        Me.Txtnum_in_office.Size = New System.Drawing.Size(225, 28)
        Me.Txtnum_in_office.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(407, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 14)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "حالة القضية"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(822, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 14)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "صفة العميل"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(827, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 14)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "رقم العميل"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(826, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 14)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "تاريخ القضية"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(827, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 14)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "قيمة القضية"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(827, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 14)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "الوكيل"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(827, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 14)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "اسم القاضي"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(827, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 14)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "اسم المحكمة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(816, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 14)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "رقم القضية ( بالمحكمة)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(816, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 14)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "رقم القضية (بالمكتب)"
        '
        'المرفقات
        '
        Me.المرفقات.Controls.Add(Me.Label8)
        Me.المرفقات.Controls.Add(Me.AxAcroPDF1)
        Me.المرفقات.Controls.Add(Me.Button1)
        Me.المرفقات.Location = New System.Drawing.Point(4, 22)
        Me.المرفقات.Name = "المرفقات"
        Me.المرفقات.Padding = New System.Windows.Forms.Padding(3)
        Me.المرفقات.Size = New System.Drawing.Size(981, 425)
        Me.المرفقات.TabIndex = 1
        Me.المرفقات.Text = "المرفقات"
        Me.المرفقات.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(910, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "المرفقات"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(3, 44)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(972, 375)
        Me.AxAcroPDF1.TabIndex = 100
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(844, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 31)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "فتح"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnlast)
        Me.GroupBox2.Controls.Add(Me.BtnDelet)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.btnprevious)
        Me.GroupBox2.Controls.Add(Me.btnfirst)
        Me.GroupBox2.Controls.Add(Me.BtnNew)
        Me.GroupBox2.Controls.Add(Me.btnnext)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(136, 406)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 58)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "للتحكم"
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.White
        Me.btnlast.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.Color.Black
        Me.btnlast.Location = New System.Drawing.Point(53, 17)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(82, 27)
        Me.btnlast.TabIndex = 24
        Me.btnlast.Text = "الاخير"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'BtnDelet
        '
        Me.BtnDelet.BackColor = System.Drawing.Color.White
        Me.BtnDelet.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelet.ForeColor = System.Drawing.Color.Black
        Me.BtnDelet.Location = New System.Drawing.Point(406, 18)
        Me.BtnDelet.Name = "BtnDelet"
        Me.BtnDelet.Size = New System.Drawing.Size(82, 27)
        Me.BtnDelet.TabIndex = 20
        Me.BtnDelet.Text = "حذف"
        Me.BtnDelet.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.White
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEdit.Location = New System.Drawing.Point(488, 18)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(82, 27)
        Me.BtnEdit.TabIndex = 19
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.Location = New System.Drawing.Point(570, 18)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(82, 27)
        Me.BtnAdd.TabIndex = 18
        Me.BtnAdd.Text = "اضافة"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.Color.White
        Me.btnprevious.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.Color.Black
        Me.btnprevious.Location = New System.Drawing.Point(135, 17)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(82, 27)
        Me.btnprevious.TabIndex = 23
        Me.btnprevious.Text = "السابق"
        Me.btnprevious.UseVisualStyleBackColor = False
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.White
        Me.btnfirst.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.Color.Black
        Me.btnfirst.Location = New System.Drawing.Point(297, 17)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(82, 27)
        Me.btnfirst.TabIndex = 21
        Me.btnfirst.Text = "الاول"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.White
        Me.BtnNew.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.Black
        Me.BtnNew.Location = New System.Drawing.Point(652, 19)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(82, 27)
        Me.BtnNew.TabIndex = 17
        Me.BtnNew.Text = "جديد"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.White
        Me.btnnext.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.Black
        Me.btnnext.Location = New System.Drawing.Point(216, 17)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(82, 27)
        Me.btnnext.TabIndex = 22
        Me.btnnext.Text = "التالي"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(220, 465)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 56)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البحث"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(27, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(315, 20)
        Me.txtSearch.TabIndex = 26
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"رقم القضية ( بالمحكمة)", "اسم المحكمة", "التاريخ", "اسم القاضي", "رقم العميل ", "اسم العميل"})
        Me.ComboBox1.Location = New System.Drawing.Point(367, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox1.TabIndex = 25
        Me.ComboBox1.Text = "اختر نوع البحث"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Lawyer1DataSet
        '
        Me.Lawyer1DataSet.DataSetName = "Lawyer1DataSet"
        Me.Lawyer1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lawyer1DataSetBindingSource
        '
        Me.Lawyer1DataSetBindingSource.DataSource = Me.Lawyer1DataSet
        Me.Lawyer1DataSetBindingSource.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Maroon
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.num_in_office, Me.num_in_court, Me.court_name, Me.judge, Me.agent, Me.Case_cost, Me.Case_date, Me.client_NUM, Me.client_NAME, Me.client_desc, Me.Case_status, Me.case_type, Me.opp_name, Me.opp_Address, Me.opp_id, Me.opp_lawyer, Me.l_opp_phone, Me.Notes})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 527)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(933, 150)
        Me.DataGridView1.TabIndex = 27
        '
        'Column1
        '
        Me.Column1.HeaderText = "عرض"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'num_in_office
        '
        Me.num_in_office.DataPropertyName = "num_in_office"
        Me.num_in_office.HeaderText = "رقم القضية( بالمكتب)"
        Me.num_in_office.Name = "num_in_office"
        Me.num_in_office.ReadOnly = True
        Me.num_in_office.Width = 130
        '
        'num_in_court
        '
        Me.num_in_court.DataPropertyName = "num_in_court"
        Me.num_in_court.HeaderText = "الرقم القضية (بالمحكمة)"
        Me.num_in_court.Name = "num_in_court"
        Me.num_in_court.ReadOnly = True
        Me.num_in_court.Width = 145
        '
        'court_name
        '
        Me.court_name.DataPropertyName = "court_name"
        Me.court_name.HeaderText = "اسم المحكمة"
        Me.court_name.Name = "court_name"
        Me.court_name.ReadOnly = True
        '
        'judge
        '
        Me.judge.DataPropertyName = "judge"
        Me.judge.HeaderText = "اسم القاضي"
        Me.judge.Name = "judge"
        Me.judge.ReadOnly = True
        '
        'agent
        '
        Me.agent.DataPropertyName = "agent"
        Me.agent.HeaderText = "الوكيل"
        Me.agent.Name = "agent"
        Me.agent.ReadOnly = True
        '
        'Case_cost
        '
        Me.Case_cost.DataPropertyName = "Case_cost"
        Me.Case_cost.HeaderText = "قيمة القضية"
        Me.Case_cost.Name = "Case_cost"
        Me.Case_cost.ReadOnly = True
        '
        'Case_date
        '
        Me.Case_date.DataPropertyName = "Case_date"
        Me.Case_date.HeaderText = "تاريخ القضية"
        Me.Case_date.Name = "Case_date"
        Me.Case_date.ReadOnly = True
        '
        'client_NUM
        '
        Me.client_NUM.DataPropertyName = "client_NUM"
        Me.client_NUM.HeaderText = "رقم العميل"
        Me.client_NUM.Name = "client_NUM"
        Me.client_NUM.ReadOnly = True
        '
        'client_NAME
        '
        Me.client_NAME.DataPropertyName = "client_NAME"
        Me.client_NAME.HeaderText = "اسم العميل"
        Me.client_NAME.Name = "client_NAME"
        Me.client_NAME.ReadOnly = True
        '
        'client_desc
        '
        Me.client_desc.DataPropertyName = "client_desc"
        Me.client_desc.HeaderText = "صفة العميل"
        Me.client_desc.Name = "client_desc"
        Me.client_desc.ReadOnly = True
        '
        'Case_status
        '
        Me.Case_status.DataPropertyName = "Case_status"
        Me.Case_status.HeaderText = "حالة القضية"
        Me.Case_status.Name = "Case_status"
        Me.Case_status.ReadOnly = True
        '
        'case_type
        '
        Me.case_type.DataPropertyName = "case_type"
        Me.case_type.HeaderText = "النوع"
        Me.case_type.Name = "case_type"
        Me.case_type.ReadOnly = True
        '
        'opp_name
        '
        Me.opp_name.DataPropertyName = "opp_name"
        Me.opp_name.HeaderText = "اسم الخصم"
        Me.opp_name.Name = "opp_name"
        Me.opp_name.ReadOnly = True
        '
        'opp_Address
        '
        Me.opp_Address.DataPropertyName = "opp_Address"
        Me.opp_Address.HeaderText = "عنوان الخصم"
        Me.opp_Address.Name = "opp_Address"
        Me.opp_Address.ReadOnly = True
        '
        'opp_id
        '
        Me.opp_id.DataPropertyName = "opp_id"
        Me.opp_id.HeaderText = "هوية الخصم"
        Me.opp_id.Name = "opp_id"
        Me.opp_id.ReadOnly = True
        '
        'opp_lawyer
        '
        Me.opp_lawyer.DataPropertyName = "opp_lawyer"
        Me.opp_lawyer.HeaderText = "محامي الخصم"
        Me.opp_lawyer.Name = "opp_lawyer"
        Me.opp_lawyer.ReadOnly = True
        '
        'l_opp_phone
        '
        Me.l_opp_phone.DataPropertyName = "l_opp_phone"
        Me.l_opp_phone.HeaderText = "رقم محامي الخصم"
        Me.l_opp_phone.Name = "l_opp_phone"
        Me.l_opp_phone.ReadOnly = True
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "ملاحظات"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        '
        'casee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1005, 676)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "casee"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بطاقة القضية"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.القضية.ResumeLayout(False)
        Me.القضية.PerformLayout()
        Me.المرفقات.ResumeLayout(False)
        Me.المرفقات.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Lawyer1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lawyer1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents القضية As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxetNotes As TextBox
    Friend WithEvents Txtclient_NUM As TextBox
    Friend WithEvents TxtCase_cost As TextBox
    Friend WithEvents Txtjudge As TextBox
    Friend WithEvents Txtagent As TextBox
    Friend WithEvents Txtcourt_name As TextBox
    Friend WithEvents Txtnum_in_court As TextBox
    Friend WithEvents Txtnum_in_office As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtclient_desc As TextBox
    Friend WithEvents Txtopp_Address As TextBox
    Friend WithEvents Txtopp_name As TextBox
    Friend WithEvents Txtcase_type As TextBox
    Friend WithEvents TxtL_opp_phone As TextBox
    Friend WithEvents Txtopp_Lawyer As TextBox
    Friend WithEvents Txtopp_id As TextBox
    Friend WithEvents CmboCase_status As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnlast As Button
    Friend WithEvents BtnDelet As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnfirst As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Lawyer1DataSet As Lawyer1DataSet
    Friend WithEvents Lawyer1DataSetBindingSource As BindingSource
    Friend WithEvents DTPCase_date As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents المرفقات As TabPage
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents num_in_office As DataGridViewTextBoxColumn
    Friend WithEvents num_in_court As DataGridViewTextBoxColumn
    Friend WithEvents court_name As DataGridViewTextBoxColumn
    Friend WithEvents judge As DataGridViewTextBoxColumn
    Friend WithEvents agent As DataGridViewTextBoxColumn
    Friend WithEvents Case_cost As DataGridViewTextBoxColumn
    Friend WithEvents Case_date As DataGridViewTextBoxColumn
    Friend WithEvents client_NUM As DataGridViewTextBoxColumn
    Friend WithEvents client_NAME As DataGridViewTextBoxColumn
    Friend WithEvents client_desc As DataGridViewTextBoxColumn
    Friend WithEvents Case_status As DataGridViewTextBoxColumn
    Friend WithEvents case_type As DataGridViewTextBoxColumn
    Friend WithEvents opp_name As DataGridViewTextBoxColumn
    Friend WithEvents opp_Address As DataGridViewTextBoxColumn
    Friend WithEvents opp_id As DataGridViewTextBoxColumn
    Friend WithEvents opp_lawyer As DataGridViewTextBoxColumn
    Friend WithEvents l_opp_phone As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
End Class
