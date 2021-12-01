<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transfer_of_case
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transfer_of_case))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.العميل = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtImple_num = New System.Windows.Forms.TextBox()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.DTPTrans_Date = New System.Windows.Forms.DateTimePicker()
        Me.Txtcourt_num = New System.Windows.Forms.TextBox()
        Me.TxtRes_num = New System.Windows.Forms.TextBox()
        Me.Txtnum_in_office = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.مرفقات = New System.Windows.Forms.TabPage()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.BtnDelet = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.num_in_office = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_in_court = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.court_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imple_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trans_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.العميل.SuspendLayout()
        Me.مرفقات.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.العميل)
        Me.TabControl1.Controls.Add(Me.مرفقات)
        Me.TabControl1.Location = New System.Drawing.Point(5, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(929, 227)
        Me.TabControl1.TabIndex = 1
        '
        'العميل
        '
        Me.العميل.Controls.Add(Me.Label6)
        Me.العميل.Controls.Add(Me.TxtImple_num)
        Me.العميل.Controls.Add(Me.TxtNotes)
        Me.العميل.Controls.Add(Me.DTPTrans_Date)
        Me.العميل.Controls.Add(Me.Txtcourt_num)
        Me.العميل.Controls.Add(Me.TxtRes_num)
        Me.العميل.Controls.Add(Me.Txtnum_in_office)
        Me.العميل.Controls.Add(Me.Label9)
        Me.العميل.Controls.Add(Me.Label5)
        Me.العميل.Controls.Add(Me.Label4)
        Me.العميل.Controls.Add(Me.Label3)
        Me.العميل.Controls.Add(Me.Label2)
        Me.العميل.Controls.Add(Me.Label1)
        Me.العميل.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.العميل.Location = New System.Drawing.Point(4, 22)
        Me.العميل.Name = "العميل"
        Me.العميل.Padding = New System.Windows.Forms.Padding(3)
        Me.العميل.Size = New System.Drawing.Size(921, 201)
        Me.العميل.TabIndex = 0
        Me.العميل.Text = "العميل"
        Me.العميل.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(503, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 14)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Label6"
        '
        'TxtImple_num
        '
        Me.TxtImple_num.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImple_num.Location = New System.Drawing.Point(503, 144)
        Me.TxtImple_num.Multiline = True
        Me.TxtImple_num.Name = "TxtImple_num"
        Me.TxtImple_num.Size = New System.Drawing.Size(225, 28)
        Me.TxtImple_num.TabIndex = 3
        '
        'TxtNotes
        '
        Me.TxtNotes.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNotes.Location = New System.Drawing.Point(47, 69)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(225, 78)
        Me.TxtNotes.TabIndex = 5
        '
        'DTPTrans_Date
        '
        Me.DTPTrans_Date.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTrans_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTrans_Date.Location = New System.Drawing.Point(47, 29)
        Me.DTPTrans_Date.Name = "DTPTrans_Date"
        Me.DTPTrans_Date.Size = New System.Drawing.Size(225, 21)
        Me.DTPTrans_Date.TabIndex = 4
        '
        'Txtcourt_num
        '
        Me.Txtcourt_num.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcourt_num.Location = New System.Drawing.Point(503, 103)
        Me.Txtcourt_num.Multiline = True
        Me.Txtcourt_num.Name = "Txtcourt_num"
        Me.Txtcourt_num.Size = New System.Drawing.Size(225, 28)
        Me.Txtcourt_num.TabIndex = 2
        '
        'TxtRes_num
        '
        Me.TxtRes_num.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRes_num.Location = New System.Drawing.Point(503, 69)
        Me.TxtRes_num.Multiline = True
        Me.TxtRes_num.Name = "TxtRes_num"
        Me.TxtRes_num.Size = New System.Drawing.Size(225, 28)
        Me.TxtRes_num.TabIndex = 1
        '
        'Txtnum_in_office
        '
        Me.Txtnum_in_office.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnum_in_office.Location = New System.Drawing.Point(585, 32)
        Me.Txtnum_in_office.Multiline = True
        Me.Txtnum_in_office.Name = "Txtnum_in_office"
        Me.Txtnum_in_office.Size = New System.Drawing.Size(143, 28)
        Me.Txtnum_in_office.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(304, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 14)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "الملاحظات"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 14)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "تاريخ تحويل القضية واستئنافها"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(776, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 14)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "رقم التنفيذ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(776, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 14)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "رقم محكمة التميز"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(776, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 14)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "رقم الاستئناف"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(754, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 14)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "رقم القضية ( بالمكتب)"
        '
        'مرفقات
        '
        Me.مرفقات.Controls.Add(Me.btnopen)
        Me.مرفقات.Controls.Add(Me.Label8)
        Me.مرفقات.Controls.Add(Me.AxAcroPDF1)
        Me.مرفقات.Location = New System.Drawing.Point(4, 22)
        Me.مرفقات.Name = "مرفقات"
        Me.مرفقات.Padding = New System.Windows.Forms.Padding(3)
        Me.مرفقات.Size = New System.Drawing.Size(921, 201)
        Me.مرفقات.TabIndex = 1
        Me.مرفقات.Text = "مرفقات"
        Me.مرفقات.UseVisualStyleBackColor = True
        '
        'btnopen
        '
        Me.btnopen.BackColor = System.Drawing.Color.White
        Me.btnopen.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen.Location = New System.Drawing.Point(792, 7)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(53, 28)
        Me.btnopen.TabIndex = 175
        Me.btnopen.Text = "فتح"
        Me.btnopen.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(853, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "المرفقات"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(6, 41)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(884, 157)
        Me.AxAcroPDF1.TabIndex = 173
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(185, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 56)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البحث"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(27, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(315, 20)
        Me.txtSearch.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"رقم القضية (بالمكتب)", "رقم القضية (بالمحكمة)", "تاريخ التحويل"})
        Me.ComboBox1.Location = New System.Drawing.Point(367, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.Text = "اختر نوع البحث"
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
        Me.GroupBox2.Location = New System.Drawing.Point(94, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 58)
        Me.GroupBox2.TabIndex = 21
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
        Me.btnlast.TabIndex = 12
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
        Me.BtnDelet.TabIndex = 9
        Me.BtnDelet.Text = "حذف"
        Me.BtnDelet.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.White
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEdit.Location = New System.Drawing.Point(489, 18)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(82, 27)
        Me.BtnEdit.TabIndex = 8
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
        Me.BtnAdd.TabIndex = 7
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
        Me.btnprevious.TabIndex = 12
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
        Me.btnfirst.TabIndex = 10
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
        Me.BtnNew.TabIndex = 6
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
        Me.btnnext.TabIndex = 11
        Me.btnnext.Text = "التالي"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Maroon
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.num_in_office, Me.num_in_court, Me.Res_num, Me.court_num, Me.Imple_num, Me.Trans_Date, Me.Notes})
        Me.DataGridView1.Location = New System.Drawing.Point(44, 367)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(817, 134)
        Me.DataGridView1.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "عرض"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'num_in_office
        '
        Me.num_in_office.DataPropertyName = "num_in_office"
        Me.num_in_office.HeaderText = "رقم القضية (بالمكتب)"
        Me.num_in_office.Name = "num_in_office"
        Me.num_in_office.ReadOnly = True
        Me.num_in_office.Width = 140
        '
        'num_in_court
        '
        Me.num_in_court.DataPropertyName = "num_in_court"
        Me.num_in_court.HeaderText = "رقم القضية ( بالمحكمة)"
        Me.num_in_court.Name = "num_in_court"
        Me.num_in_court.ReadOnly = True
        Me.num_in_court.Width = 140
        '
        'Res_num
        '
        Me.Res_num.DataPropertyName = "Res_num"
        Me.Res_num.HeaderText = "رقم الاستئناف"
        Me.Res_num.Name = "Res_num"
        Me.Res_num.ReadOnly = True
        '
        'court_num
        '
        Me.court_num.DataPropertyName = "court_num"
        Me.court_num.HeaderText = "رقم محكمة التميز"
        Me.court_num.Name = "court_num"
        Me.court_num.ReadOnly = True
        Me.court_num.Width = 120
        '
        'Imple_num
        '
        Me.Imple_num.DataPropertyName = "Imple_num"
        Me.Imple_num.HeaderText = "رقم التنفيذ"
        Me.Imple_num.Name = "Imple_num"
        Me.Imple_num.ReadOnly = True
        '
        'Trans_Date
        '
        Me.Trans_Date.DataPropertyName = "Trans_Date"
        Me.Trans_Date.HeaderText = "تاريح التحويل"
        Me.Trans_Date.Name = "Trans_Date"
        Me.Trans_Date.ReadOnly = True
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "ملاحظات"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Width = 125
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Transfer_of_case
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(936, 506)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transfer_of_case"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بطاقة نقل القضية"
        Me.TabControl1.ResumeLayout(False)
        Me.العميل.ResumeLayout(False)
        Me.العميل.PerformLayout()
        Me.مرفقات.ResumeLayout(False)
        Me.مرفقات.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents العميل As TabPage
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents DTPTrans_Date As DateTimePicker
    Friend WithEvents Txtcourt_num As TextBox
    Friend WithEvents TxtRes_num As TextBox
    Friend WithEvents Txtnum_in_office As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents مرفقات As TabPage
    Friend WithEvents TxtImple_num As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnlast As Button
    Friend WithEvents BtnDelet As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnfirst As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnopen As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents num_in_office As DataGridViewTextBoxColumn
    Friend WithEvents num_in_court As DataGridViewTextBoxColumn
    Friend WithEvents Res_num As DataGridViewTextBoxColumn
    Friend WithEvents court_num As DataGridViewTextBoxColumn
    Friend WithEvents Imple_num As DataGridViewTextBoxColumn
    Friend WithEvents Trans_Date As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
End Class
