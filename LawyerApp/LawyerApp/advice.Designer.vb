<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class advice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(advice))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.عرض = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.advice_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.advice_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client_NUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.General_class = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Response = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tabpage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Txtclient_NUM = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Txtadvice_num = New System.Windows.Forms.TextBox()
        Me.TxtSubject = New System.Windows.Forms.TextBox()
        Me.TxtGeneral_class = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTPadvice_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabpage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        Me.GroupBox2.Location = New System.Drawing.Point(114, 341)
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
        Me.btnlast.TabIndex = 15
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
        Me.BtnDelet.TabIndex = 11
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
        Me.BtnEdit.TabIndex = 10
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
        Me.BtnAdd.TabIndex = 9
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
        Me.btnprevious.TabIndex = 14
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
        Me.btnfirst.TabIndex = 12
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
        Me.BtnNew.TabIndex = 8
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
        Me.btnnext.TabIndex = 13
        Me.btnnext.Text = "التالي"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(173, 403)
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
        Me.txtSearch.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"التاريخ", "رقم العميل", "اسم العميل", "الموضوع"})
        Me.ComboBox1.Location = New System.Drawing.Point(367, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox1.TabIndex = 16
        Me.ComboBox1.Text = "اختر نوع البحث"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Maroon
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.عرض, Me.advice_num, Me.advice_Date, Me.client_NUM, Me.client_NAME, Me.General_class, Me.Subject, Me.Notes, Me.Description, Me.Response})
        Me.DataGridView1.Location = New System.Drawing.Point(48, 465)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(968, 98)
        Me.DataGridView1.TabIndex = 17
        '
        'عرض
        '
        Me.عرض.HeaderText = "عرض"
        Me.عرض.Name = "عرض"
        Me.عرض.ReadOnly = True
        Me.عرض.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.عرض.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'advice_num
        '
        Me.advice_num.DataPropertyName = "advice_num"
        Me.advice_num.HeaderText = "رقم الاستشارة"
        Me.advice_num.Name = "advice_num"
        Me.advice_num.ReadOnly = True
        '
        'advice_Date
        '
        Me.advice_Date.DataPropertyName = "advice_Date"
        Me.advice_Date.HeaderText = "التاريخ"
        Me.advice_Date.Name = "advice_Date"
        Me.advice_Date.ReadOnly = True
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
        'General_class
        '
        Me.General_class.DataPropertyName = "General_class"
        Me.General_class.HeaderText = "التصنيف العام"
        Me.General_class.Name = "General_class"
        Me.General_class.ReadOnly = True
        '
        'Subject
        '
        Me.Subject.DataPropertyName = "Subject"
        Me.Subject.HeaderText = "الموضوع"
        Me.Subject.Name = "Subject"
        Me.Subject.ReadOnly = True
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "الملاحظات"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "الوصف"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Response
        '
        Me.Response.DataPropertyName = "Response"
        Me.Response.HeaderText = "الرد"
        Me.Response.Name = "Response"
        Me.Response.ReadOnly = True
        '
        'Tabpage1
        '
        Me.Tabpage1.Controls.Add(Me.Label6)
        Me.Tabpage1.Controls.Add(Me.Label4)
        Me.Tabpage1.Controls.Add(Me.txtResponse)
        Me.Tabpage1.Controls.Add(Me.txtDescription)
        Me.Tabpage1.Controls.Add(Me.Txtclient_NUM)
        Me.Tabpage1.Controls.Add(Me.txtNotes)
        Me.Tabpage1.Controls.Add(Me.Txtadvice_num)
        Me.Tabpage1.Controls.Add(Me.TxtSubject)
        Me.Tabpage1.Controls.Add(Me.TxtGeneral_class)
        Me.Tabpage1.Controls.Add(Me.Label7)
        Me.Tabpage1.Controls.Add(Me.DTPadvice_Date)
        Me.Tabpage1.Controls.Add(Me.Label1)
        Me.Tabpage1.Controls.Add(Me.Label2)
        Me.Tabpage1.Controls.Add(Me.Label15)
        Me.Tabpage1.Controls.Add(Me.Label5)
        Me.Tabpage1.Controls.Add(Me.Label3)
        Me.Tabpage1.ForeColor = System.Drawing.Color.Black
        Me.Tabpage1.Location = New System.Drawing.Point(4, 22)
        Me.Tabpage1.Name = "Tabpage1"
        Me.Tabpage1.Size = New System.Drawing.Size(964, 276)
        Me.Tabpage1.TabIndex = 0
        Me.Tabpage1.Text = "معلومات الاستشارة"
        Me.Tabpage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(518, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 14)
        Me.Label6.TabIndex = 166
        Me.Label6.Text = "الرد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(515, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 14)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "الوصف"
        '
        'txtResponse
        '
        Me.txtResponse.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponse.Location = New System.Drawing.Point(186, 138)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.Size = New System.Drawing.Size(311, 98)
        Me.txtResponse.TabIndex = 7
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(186, 25)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(311, 98)
        Me.txtDescription.TabIndex = 6
        '
        'Txtclient_NUM
        '
        Me.Txtclient_NUM.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtclient_NUM.Location = New System.Drawing.Point(597, 87)
        Me.Txtclient_NUM.Multiline = True
        Me.Txtclient_NUM.Name = "Txtclient_NUM"
        Me.Txtclient_NUM.Size = New System.Drawing.Size(192, 24)
        Me.Txtclient_NUM.TabIndex = 2
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(597, 191)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(192, 66)
        Me.txtNotes.TabIndex = 5
        '
        'Txtadvice_num
        '
        Me.Txtadvice_num.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtadvice_num.Location = New System.Drawing.Point(597, 13)
        Me.Txtadvice_num.Multiline = True
        Me.Txtadvice_num.Name = "Txtadvice_num"
        Me.Txtadvice_num.ReadOnly = True
        Me.Txtadvice_num.Size = New System.Drawing.Size(192, 24)
        Me.Txtadvice_num.TabIndex = 0
        '
        'TxtSubject
        '
        Me.TxtSubject.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubject.Location = New System.Drawing.Point(597, 161)
        Me.TxtSubject.Multiline = True
        Me.TxtSubject.Name = "TxtSubject"
        Me.TxtSubject.Size = New System.Drawing.Size(192, 24)
        Me.TxtSubject.TabIndex = 4
        '
        'TxtGeneral_class
        '
        Me.TxtGeneral_class.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGeneral_class.Location = New System.Drawing.Point(597, 125)
        Me.TxtGeneral_class.Multiline = True
        Me.TxtGeneral_class.Name = "TxtGeneral_class"
        Me.TxtGeneral_class.Size = New System.Drawing.Size(192, 24)
        Me.TxtGeneral_class.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(813, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 14)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "رقم الاستشارة"
        '
        'DTPadvice_Date
        '
        Me.DTPadvice_Date.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPadvice_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPadvice_Date.Location = New System.Drawing.Point(597, 53)
        Me.DTPadvice_Date.Name = "DTPadvice_Date"
        Me.DTPadvice_Date.Size = New System.Drawing.Size(192, 21)
        Me.DTPadvice_Date.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(821, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "الموضوع"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(820, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "ملاحظات"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(826, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 14)
        Me.Label15.TabIndex = 153
        Me.Label15.Text = "التاريخ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(821, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 14)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "التصنيف العام"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(817, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "رقم العميل"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tabpage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(31, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(972, 302)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnopen)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.AxAcroPDF1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(964, 276)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "المرفقات"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnopen
        '
        Me.btnopen.BackColor = System.Drawing.Color.White
        Me.btnopen.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen.Location = New System.Drawing.Point(837, 6)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(53, 28)
        Me.btnopen.TabIndex = 172
        Me.btnopen.Text = "فتح"
        Me.btnopen.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(896, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "المرفقات"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(84, 40)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(797, 210)
        Me.AxAcroPDF1.TabIndex = 170
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'advice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1028, 574)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "advice"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بطاقة الاستشارة"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabpage1.ResumeLayout(False)
        Me.Tabpage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Tabpage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtResponse As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Txtclient_NUM As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Txtadvice_num As TextBox
    Friend WithEvents TxtSubject As TextBox
    Friend WithEvents TxtGeneral_class As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DTPadvice_Date As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents btnopen As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents عرض As DataGridViewButtonColumn
    Friend WithEvents advice_num As DataGridViewTextBoxColumn
    Friend WithEvents advice_Date As DataGridViewTextBoxColumn
    Friend WithEvents client_NUM As DataGridViewTextBoxColumn
    Friend WithEvents client_NAME As DataGridViewTextBoxColumn
    Friend WithEvents General_class As DataGridViewTextBoxColumn
    Friend WithEvents Subject As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Response As DataGridViewTextBoxColumn
End Class
