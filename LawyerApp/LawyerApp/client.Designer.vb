<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(client))
        Me.المرفقات = New System.Windows.Forms.TabControl()
        Me.العميل = New System.Windows.Forms.TabPage()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.DTPbirthday = New System.Windows.Forms.DateTimePicker()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtMob_NUM = New System.Windows.Forms.TextBox()
        Me.Txtjob = New System.Windows.Forms.TextBox()
        Me.Txtclient_ID = New System.Windows.Forms.TextBox()
        Me.Txtclient_NAME = New System.Windows.Forms.TextBox()
        Me.Txtclient_num = New System.Windows.Forms.TextBox()
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDelet = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AdviceTableAdapter1 = New LawyerApp.Lawyer1DataSetTableAdapters.adviceTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.عرض = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.client_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.job = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mob_NUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lawyer1DataSet = New LawyerApp.Lawyer1DataSet()
        Me.Lawyer1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New LawyerApp.Lawyer1DataSetTableAdapters.clientTableAdapter()
        Me.المرفقات.SuspendLayout()
        Me.العميل.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lawyer1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lawyer1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'المرفقات
        '
        Me.المرفقات.Controls.Add(Me.العميل)
        Me.المرفقات.Controls.Add(Me.TabPage1)
        Me.المرفقات.Location = New System.Drawing.Point(12, 4)
        Me.المرفقات.Name = "المرفقات"
        Me.المرفقات.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.المرفقات.RightToLeftLayout = True
        Me.المرفقات.SelectedIndex = 0
        Me.المرفقات.Size = New System.Drawing.Size(921, 283)
        Me.المرفقات.TabIndex = 0
        '
        'العميل
        '
        Me.العميل.Controls.Add(Me.txtAddress)
        Me.العميل.Controls.Add(Me.txtNotes)
        Me.العميل.Controls.Add(Me.DTPbirthday)
        Me.العميل.Controls.Add(Me.TxtEmail)
        Me.العميل.Controls.Add(Me.TxtPhone)
        Me.العميل.Controls.Add(Me.TxtMob_NUM)
        Me.العميل.Controls.Add(Me.Txtjob)
        Me.العميل.Controls.Add(Me.Txtclient_ID)
        Me.العميل.Controls.Add(Me.Txtclient_NAME)
        Me.العميل.Controls.Add(Me.Txtclient_num)
        Me.العميل.Controls.Add(Me.Label9)
        Me.العميل.Controls.Add(Me.Label10)
        Me.العميل.Controls.Add(Me.Label11)
        Me.العميل.Controls.Add(Me.Label7)
        Me.العميل.Controls.Add(Me.Label6)
        Me.العميل.Controls.Add(Me.Label5)
        Me.العميل.Controls.Add(Me.Label4)
        Me.العميل.Controls.Add(Me.Label3)
        Me.العميل.Controls.Add(Me.Label2)
        Me.العميل.Controls.Add(Me.Label1)
        Me.العميل.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.العميل.Location = New System.Drawing.Point(4, 22)
        Me.العميل.Name = "العميل"
        Me.العميل.Padding = New System.Windows.Forms.Padding(3)
        Me.العميل.Size = New System.Drawing.Size(913, 257)
        Me.العميل.TabIndex = 0
        Me.العميل.Text = "معلومات العميل"
        Me.العميل.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(539, 122)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(225, 28)
        Me.txtAddress.TabIndex = 3
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(160, 137)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(225, 78)
        Me.txtNotes.TabIndex = 9
        '
        'DTPbirthday
        '
        Me.DTPbirthday.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPbirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPbirthday.Location = New System.Drawing.Point(539, 158)
        Me.DTPbirthday.Name = "DTPbirthday"
        Me.DTPbirthday.Size = New System.Drawing.Size(225, 21)
        Me.DTPbirthday.TabIndex = 4
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(159, 102)
        Me.TxtEmail.Multiline = True
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(225, 28)
        Me.TxtEmail.TabIndex = 8
        '
        'TxtPhone
        '
        Me.TxtPhone.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhone.Location = New System.Drawing.Point(159, 67)
        Me.TxtPhone.Multiline = True
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(225, 28)
        Me.TxtPhone.TabIndex = 7
        '
        'TxtMob_NUM
        '
        Me.TxtMob_NUM.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMob_NUM.Location = New System.Drawing.Point(160, 33)
        Me.TxtMob_NUM.Multiline = True
        Me.TxtMob_NUM.Name = "TxtMob_NUM"
        Me.TxtMob_NUM.Size = New System.Drawing.Size(225, 28)
        Me.TxtMob_NUM.TabIndex = 6
        '
        'Txtjob
        '
        Me.Txtjob.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtjob.Location = New System.Drawing.Point(538, 187)
        Me.Txtjob.Multiline = True
        Me.Txtjob.Name = "Txtjob"
        Me.Txtjob.Size = New System.Drawing.Size(225, 28)
        Me.Txtjob.TabIndex = 5
        '
        'Txtclient_ID
        '
        Me.Txtclient_ID.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtclient_ID.Location = New System.Drawing.Point(539, 91)
        Me.Txtclient_ID.Multiline = True
        Me.Txtclient_ID.Name = "Txtclient_ID"
        Me.Txtclient_ID.Size = New System.Drawing.Size(225, 28)
        Me.Txtclient_ID.TabIndex = 2
        '
        'Txtclient_NAME
        '
        Me.Txtclient_NAME.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtclient_NAME.Location = New System.Drawing.Point(539, 60)
        Me.Txtclient_NAME.Multiline = True
        Me.Txtclient_NAME.Name = "Txtclient_NAME"
        Me.Txtclient_NAME.Size = New System.Drawing.Size(225, 28)
        Me.Txtclient_NAME.TabIndex = 1
        '
        'Txtclient_num
        '
        Me.Txtclient_num.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtclient_num.Location = New System.Drawing.Point(539, 28)
        Me.Txtclient_num.Multiline = True
        Me.Txtclient_num.Name = "Txtclient_num"
        Me.Txtclient_num.ReadOnly = True
        Me.Txtclient_num.Size = New System.Drawing.Size(225, 28)
        Me.Txtclient_num.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(427, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 14)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "الملاحظات"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(428, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 14)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "الايميل"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(431, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 14)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "الهاتف"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(426, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 14)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "رقم الجوال"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(789, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 14)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "المهنة"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(788, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 14)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "تاريخ الميلاد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(788, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "العنوان"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(788, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "رقم الهوية"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(788, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 14)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "اسم العميل"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(788, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "رقم العميل"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AxAcroPDF1)
        Me.TabPage1.Controls.Add(Me.btnopen)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(913, 257)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "المرفقات"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(6, 45)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(904, 195)
        Me.AxAcroPDF1.TabIndex = 169
        '
        'btnopen
        '
        Me.btnopen.BackColor = System.Drawing.Color.White
        Me.btnopen.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen.Location = New System.Drawing.Point(788, 11)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(53, 28)
        Me.btnopen.TabIndex = 86
        Me.btnopen.Text = "فتح"
        Me.btnopen.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(849, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "المرفقات"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(224, 382)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 56)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البحث"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(27, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(315, 20)
        Me.txtSearch.TabIndex = 19
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"الرقم", "الاسم", "رقم الهوية", "العنوان", "المهنة", "رقم الجوال", "الهاتف"})
        Me.ComboBox1.Location = New System.Drawing.Point(367, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.Text = "اختر نوع البحث"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.Location = New System.Drawing.Point(1097, 10)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(65, 27)
        Me.BtnCancel.TabIndex = 27
        Me.BtnCancel.Text = "الخروج"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnDelet
        '
        Me.BtnDelet.BackColor = System.Drawing.Color.White
        Me.BtnDelet.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelet.ForeColor = System.Drawing.Color.Black
        Me.BtnDelet.Location = New System.Drawing.Point(406, 18)
        Me.BtnDelet.Name = "BtnDelet"
        Me.BtnDelet.Size = New System.Drawing.Size(82, 27)
        Me.BtnDelet.TabIndex = 13
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
        Me.BtnEdit.TabIndex = 12
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
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "اضافة"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.White
        Me.BtnNew.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.Black
        Me.BtnNew.Location = New System.Drawing.Point(652, 19)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(82, 27)
        Me.BtnNew.TabIndex = 10
        Me.BtnNew.Text = "جديد"
        Me.BtnNew.UseVisualStyleBackColor = False
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
        Me.GroupBox2.Location = New System.Drawing.Point(156, 310)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 58)
        Me.GroupBox2.TabIndex = 18
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
        Me.btnlast.TabIndex = 17
        Me.btnlast.Text = "الاخير"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.Color.White
        Me.btnprevious.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.Color.Black
        Me.btnprevious.Location = New System.Drawing.Point(135, 17)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(82, 27)
        Me.btnprevious.TabIndex = 16
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
        Me.btnfirst.TabIndex = 14
        Me.btnfirst.Text = "الاول"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.White
        Me.btnnext.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.Black
        Me.btnnext.Location = New System.Drawing.Point(216, 17)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(82, 27)
        Me.btnnext.TabIndex = 15
        Me.btnnext.Text = "التالي"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AdviceTableAdapter1
        '
        Me.AdviceTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Maroon
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.عرض, Me.client_num, Me.client_NAME, Me.client_ID, Me.Address, Me.birthday, Me.job, Me.Mob_NUM, Me.phone, Me.Email, Me.Notes})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 444)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(918, 157)
        Me.DataGridView1.TabIndex = 20
        '
        'عرض
        '
        Me.عرض.DataPropertyName = "r"
        Me.عرض.HeaderText = "عرض"
        Me.عرض.Name = "عرض"
        Me.عرض.ReadOnly = True
        Me.عرض.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.عرض.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'client_num
        '
        Me.client_num.DataPropertyName = "client_num"
        Me.client_num.HeaderText = "رقم العميل"
        Me.client_num.Name = "client_num"
        Me.client_num.ReadOnly = True
        Me.client_num.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'client_NAME
        '
        Me.client_NAME.DataPropertyName = "client_NAME"
        Me.client_NAME.HeaderText = "اسم العميل"
        Me.client_NAME.Name = "client_NAME"
        Me.client_NAME.ReadOnly = True
        '
        'client_ID
        '
        Me.client_ID.DataPropertyName = "client_ID"
        Me.client_ID.HeaderText = "رقم الهوية"
        Me.client_ID.Name = "client_ID"
        Me.client_ID.ReadOnly = True
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "العنوان"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'birthday
        '
        Me.birthday.DataPropertyName = "birthday"
        Me.birthday.HeaderText = "تاريخ الميلاد"
        Me.birthday.Name = "birthday"
        Me.birthday.ReadOnly = True
        '
        'job
        '
        Me.job.DataPropertyName = "job"
        Me.job.HeaderText = "المهنة"
        Me.job.Name = "job"
        Me.job.ReadOnly = True
        '
        'Mob_NUM
        '
        Me.Mob_NUM.DataPropertyName = "Mob_NUM"
        Me.Mob_NUM.HeaderText = "رقم الجوال"
        Me.Mob_NUM.Name = "Mob_NUM"
        Me.Mob_NUM.ReadOnly = True
        '
        'phone
        '
        Me.phone.DataPropertyName = "phone"
        Me.phone.HeaderText = "الهاتف"
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "الايميل"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "الملاحظات"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.Lawyer1DataSet
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
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(937, 609)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.المرفقات)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "client"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بطاقة العميل"
        Me.المرفقات.ResumeLayout(False)
        Me.العميل.ResumeLayout(False)
        Me.العميل.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lawyer1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lawyer1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents المرفقات As TabControl
    Friend WithEvents العميل As TabPage
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
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents DTPbirthday As DateTimePicker
    Friend WithEvents TxtMob_NUM As TextBox
    Friend WithEvents Txtjob As TextBox
    Friend WithEvents Txtclient_ID As TextBox
    Friend WithEvents Txtclient_NAME As TextBox
    Friend WithEvents Txtclient_num As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnDelet As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnlast As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnfirst As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AdviceTableAdapter1 As Lawyer1DataSetTableAdapters.adviceTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Lawyer1DataSetBindingSource As BindingSource
    Friend WithEvents Lawyer1DataSet As Lawyer1DataSet
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents ClientTableAdapter As Lawyer1DataSetTableAdapters.clientTableAdapter
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents btnopen As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents عرض As DataGridViewButtonColumn
    Friend WithEvents client_num As DataGridViewTextBoxColumn
    Friend WithEvents client_NAME As DataGridViewTextBoxColumn
    Friend WithEvents client_ID As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents job As DataGridViewTextBoxColumn
    Friend WithEvents Mob_NUM As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewLinkColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    'Friend WithEvents AxAcroPDF2 As AxAcroPDFLib.AxAcroPDF
End Class
