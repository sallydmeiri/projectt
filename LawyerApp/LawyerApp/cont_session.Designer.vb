<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cont_session
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cont_session))
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DTPsession_date = New System.Windows.Forms.DateTimePicker()
        Me.Txtsession_num = New System.Windows.Forms.TextBox()
        Me.Txtsession_time = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtnum_in_office = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.session_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_in_office = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_in_court = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.session_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.session_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(39, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 58)
        Me.GroupBox2.TabIndex = 131
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
        Me.BtnDelet.TabIndex = 8
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
        Me.BtnEdit.TabIndex = 7
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
        Me.BtnAdd.TabIndex = 6
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
        Me.btnprevious.TabIndex = 11
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
        Me.btnfirst.TabIndex = 9
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
        Me.BtnNew.TabIndex = 5
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
        Me.btnnext.TabIndex = 10
        Me.btnnext.Text = "التالي"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(103, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 56)
        Me.GroupBox1.TabIndex = 132
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البحث"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(27, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(315, 20)
        Me.txtSearch.TabIndex = 14
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"رقم القضية (بالمكتب)", "رقم القضية (بالمحكمة)", "وقت جلسة القضية", "تاريخ جلسة القضية"})
        Me.ComboBox1.Location = New System.Drawing.Point(367, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.Text = "اختر نوع البحث"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(838, 235)
        Me.TabControl1.TabIndex = 134
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DTPsession_date)
        Me.TabPage1.Controls.Add(Me.Txtsession_num)
        Me.TabPage1.Controls.Add(Me.Txtsession_time)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Txtnum_in_office)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtNotes)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(830, 209)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "القضايا"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DTPsession_date
        '
        Me.DTPsession_date.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPsession_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPsession_date.Location = New System.Drawing.Point(418, 120)
        Me.DTPsession_date.Name = "DTPsession_date"
        Me.DTPsession_date.Size = New System.Drawing.Size(225, 22)
        Me.DTPsession_date.TabIndex = 2
        '
        'Txtsession_num
        '
        Me.Txtsession_num.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsession_num.Location = New System.Drawing.Point(418, 35)
        Me.Txtsession_num.Multiline = True
        Me.Txtsession_num.Name = "Txtsession_num"
        Me.Txtsession_num.Size = New System.Drawing.Size(225, 28)
        Me.Txtsession_num.TabIndex = 0
        '
        'Txtsession_time
        '
        Me.Txtsession_time.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsession_time.Location = New System.Drawing.Point(42, 34)
        Me.Txtsession_time.Multiline = True
        Me.Txtsession_time.Name = "Txtsession_time"
        Me.Txtsession_time.Size = New System.Drawing.Size(223, 28)
        Me.Txtsession_time.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 14)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "وقت جلسة القضية"
        '
        'Txtnum_in_office
        '
        Me.Txtnum_in_office.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnum_in_office.Location = New System.Drawing.Point(418, 77)
        Me.Txtnum_in_office.Multiline = True
        Me.Txtnum_in_office.Name = "Txtnum_in_office"
        Me.Txtnum_in_office.Size = New System.Drawing.Size(225, 28)
        Me.Txtnum_in_office.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "الملاحظات"
        '
        'TxtNotes
        '
        Me.TxtNotes.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNotes.Location = New System.Drawing.Point(42, 76)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(225, 79)
        Me.TxtNotes.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(676, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 14)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "تاريخ جلسة القضية"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(676, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 14)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "رقم جلسة القضية"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(670, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 14)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "رقم القضية (بالمكتب)"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnopen)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.AxAcroPDF1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(830, 209)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "مرفقات"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnopen
        '
        Me.btnopen.BackColor = System.Drawing.Color.White
        Me.btnopen.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopen.Location = New System.Drawing.Point(692, 4)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(53, 28)
        Me.btnopen.TabIndex = 178
        Me.btnopen.Text = "فتح"
        Me.btnopen.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(753, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "المرفقات"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(16, 38)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(808, 152)
        Me.AxAcroPDF1.TabIndex = 176
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Maroon
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.session_num, Me.num_in_office, Me.num_in_court, Me.session_date, Me.session_time, Me.Notes})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 394)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(784, 146)
        Me.DataGridView1.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "عرض"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'session_num
        '
        Me.session_num.DataPropertyName = "session_num"
        Me.session_num.HeaderText = "رقم جلسة القضية"
        Me.session_num.Name = "session_num"
        Me.session_num.ReadOnly = True
        Me.session_num.Width = 115
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
        Me.num_in_court.HeaderText = "رقم القضية (بالمحكمة)"
        Me.num_in_court.Name = "num_in_court"
        Me.num_in_court.ReadOnly = True
        Me.num_in_court.Width = 140
        '
        'session_date
        '
        Me.session_date.DataPropertyName = "session_date"
        Me.session_date.HeaderText = "تاريخ جلسة القضية"
        Me.session_date.Name = "session_date"
        Me.session_date.ReadOnly = True
        Me.session_date.Width = 140
        '
        'session_time
        '
        Me.session_time.DataPropertyName = "session_time"
        Me.session_time.HeaderText = "وقت جلسة القضية"
        Me.session_time.Name = "session_time"
        Me.session_time.ReadOnly = True
        Me.session_time.Width = 140
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "ملاحظات"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Width = 125
        '
        'cont_session
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(859, 546)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cont_session"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جلسات الاستئناف"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DTPsession_date As DateTimePicker
    Friend WithEvents Txtsession_num As TextBox
    Friend WithEvents Txtsession_time As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtnum_in_office As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnopen As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents session_num As DataGridViewTextBoxColumn
    Friend WithEvents num_in_office As DataGridViewTextBoxColumn
    Friend WithEvents num_in_court As DataGridViewTextBoxColumn
    Friend WithEvents session_date As DataGridViewTextBoxColumn
    Friend WithEvents session_time As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
End Class
