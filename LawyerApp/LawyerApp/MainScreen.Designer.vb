<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.البطاقاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.العميلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.القضيةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الاستشارةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.نقلالقضيةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.وثائقعدليةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الجلسةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.جلساتالقضاياToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.التقاريرToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.قضاياالعميلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الجلساتحسبالتاريخToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.جلساتالاسئنافحسبالتاريخToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.روابطمهمةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.قسطاطToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.المكتفيToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.عدالةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.المنظومةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.وزارةالعدلالعلياToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حفظالبياناتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.نسخةاحتياطيةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.فتحقاعدةالبياناتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.استرجاعالنسخةالاحتياطيةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حولالبرنامجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تسجيلالخروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.جلساتالقضاياToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.مواعيدجلساتالاستئنافToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 22
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkRed
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.البطاقاتToolStripMenuItem, Me.التقاريرToolStripMenuItem, Me.روابطمهمةToolStripMenuItem, Me.حفظالبياناتToolStripMenuItem, Me.حولالبرنامجToolStripMenuItem, Me.تسجيلالخروجToolStripMenuItem, Me.TimeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'البطاقاتToolStripMenuItem
        '
        Me.البطاقاتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.العميلToolStripMenuItem, Me.القضيةToolStripMenuItem, Me.الاستشارةToolStripMenuItem, Me.نقلالقضيةToolStripMenuItem, Me.وثائقعدليةToolStripMenuItem, Me.الجلسةToolStripMenuItem, Me.جلساتالقضاياToolStripMenuItem})
        Me.البطاقاتToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.البطاقاتToolStripMenuItem.Name = "البطاقاتToolStripMenuItem"
        Me.البطاقاتToolStripMenuItem.Size = New System.Drawing.Size(80, 25)
        Me.البطاقاتToolStripMenuItem.Text = "البطاقات"
        '
        'العميلToolStripMenuItem
        '
        Me.العميلToolStripMenuItem.Name = "العميلToolStripMenuItem"
        Me.العميلToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.العميلToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.العميلToolStripMenuItem.Text = "العميل"
        '
        'القضيةToolStripMenuItem
        '
        Me.القضيةToolStripMenuItem.Name = "القضيةToolStripMenuItem"
        Me.القضيةToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.القضيةToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.القضيةToolStripMenuItem.Text = "القضية"
        '
        'الاستشارةToolStripMenuItem
        '
        Me.الاستشارةToolStripMenuItem.Name = "الاستشارةToolStripMenuItem"
        Me.الاستشارةToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.الاستشارةToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.الاستشارةToolStripMenuItem.Text = "الاستشارة"
        '
        'نقلالقضيةToolStripMenuItem
        '
        Me.نقلالقضيةToolStripMenuItem.Name = "نقلالقضيةToolStripMenuItem"
        Me.نقلالقضيةToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.نقلالقضيةToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.نقلالقضيةToolStripMenuItem.Text = "نقل القضية "
        '
        'وثائقعدليةToolStripMenuItem
        '
        Me.وثائقعدليةToolStripMenuItem.Name = "وثائقعدليةToolStripMenuItem"
        Me.وثائقعدليةToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.وثائقعدليةToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.وثائقعدليةToolStripMenuItem.Text = "وثائق عدلية "
        '
        'الجلسةToolStripMenuItem
        '
        Me.الجلسةToolStripMenuItem.Name = "الجلسةToolStripMenuItem"
        Me.الجلسةToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.الجلسةToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.الجلسةToolStripMenuItem.Text = "جلسات الاستئناف"
        '
        'جلساتالقضاياToolStripMenuItem
        '
        Me.جلساتالقضاياToolStripMenuItem.Name = "جلساتالقضاياToolStripMenuItem"
        Me.جلساتالقضاياToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.جلساتالقضاياToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.جلساتالقضاياToolStripMenuItem.Text = "جلسات القضايا"
        '
        'التقاريرToolStripMenuItem
        '
        Me.التقاريرToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.قضاياالعميلToolStripMenuItem, Me.الجلساتحسبالتاريخToolStripMenuItem, Me.جلساتالاسئنافحسبالتاريخToolStripMenuItem, Me.جلساتالقضاياToolStripMenuItem1, Me.مواعيدجلساتالاستئنافToolStripMenuItem})
        Me.التقاريرToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem"
        Me.التقاريرToolStripMenuItem.Size = New System.Drawing.Size(68, 25)
        Me.التقاريرToolStripMenuItem.Text = "التقارير"
        '
        'قضاياالعميلToolStripMenuItem
        '
        Me.قضاياالعميلToolStripMenuItem.Name = "قضاياالعميلToolStripMenuItem"
        Me.قضاياالعميلToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.قضاياالعميلToolStripMenuItem.Text = "قضايا العميل"
        '
        'الجلساتحسبالتاريخToolStripMenuItem
        '
        Me.الجلساتحسبالتاريخToolStripMenuItem.Name = "الجلساتحسبالتاريخToolStripMenuItem"
        Me.الجلساتحسبالتاريخToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.الجلساتحسبالتاريخToolStripMenuItem.Text = "جلسات القضية"
        '
        'جلساتالاسئنافحسبالتاريخToolStripMenuItem
        '
        Me.جلساتالاسئنافحسبالتاريخToolStripMenuItem.Name = "جلساتالاسئنافحسبالتاريخToolStripMenuItem"
        Me.جلساتالاسئنافحسبالتاريخToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.جلساتالاسئنافحسبالتاريخToolStripMenuItem.Text = "جلسات الاستئناف"
        '
        'روابطمهمةToolStripMenuItem
        '
        Me.روابطمهمةToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.قسطاطToolStripMenuItem, Me.المكتفيToolStripMenuItem, Me.عدالةToolStripMenuItem, Me.المنظومةToolStripMenuItem, Me.وزارةالعدلالعلياToolStripMenuItem})
        Me.روابطمهمةToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.روابطمهمةToolStripMenuItem.Name = "روابطمهمةToolStripMenuItem"
        Me.روابطمهمةToolStripMenuItem.Size = New System.Drawing.Size(96, 25)
        Me.روابطمهمةToolStripMenuItem.Text = "روابط مهمة"
        '
        'قسطاطToolStripMenuItem
        '
        Me.قسطاطToolStripMenuItem.Name = "قسطاطToolStripMenuItem"
        Me.قسطاطToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.قسطاطToolStripMenuItem.Text = "قسطاط"
        '
        'المكتفيToolStripMenuItem
        '
        Me.المكتفيToolStripMenuItem.Name = "المكتفيToolStripMenuItem"
        Me.المكتفيToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.المكتفيToolStripMenuItem.Text = "المقتفي"
        '
        'عدالةToolStripMenuItem
        '
        Me.عدالةToolStripMenuItem.Name = "عدالةToolStripMenuItem"
        Me.عدالةToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.عدالةToolStripMenuItem.Text = "عدالة"
        '
        'المنظومةToolStripMenuItem
        '
        Me.المنظومةToolStripMenuItem.Name = "المنظومةToolStripMenuItem"
        Me.المنظومةToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.المنظومةToolStripMenuItem.Text = "المنظومة"
        '
        'وزارةالعدلالعلياToolStripMenuItem
        '
        Me.وزارةالعدلالعلياToolStripMenuItem.Name = "وزارةالعدلالعلياToolStripMenuItem"
        Me.وزارةالعدلالعلياToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.وزارةالعدلالعلياToolStripMenuItem.Text = "وزارة العدل العليا"
        '
        'حفظالبياناتToolStripMenuItem
        '
        Me.حفظالبياناتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.نسخةاحتياطيةToolStripMenuItem, Me.فتحقاعدةالبياناتToolStripMenuItem, Me.استرجاعالنسخةالاحتياطيةToolStripMenuItem})
        Me.حفظالبياناتToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.حفظالبياناتToolStripMenuItem.Name = "حفظالبياناتToolStripMenuItem"
        Me.حفظالبياناتToolStripMenuItem.Size = New System.Drawing.Size(103, 25)
        Me.حفظالبياناتToolStripMenuItem.Text = "حفظ البيانات"
        '
        'نسخةاحتياطيةToolStripMenuItem
        '
        Me.نسخةاحتياطيةToolStripMenuItem.Name = "نسخةاحتياطيةToolStripMenuItem"
        Me.نسخةاحتياطيةToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.نسخةاحتياطيةToolStripMenuItem.Text = "نسخة احتياطية"
        '
        'فتحقاعدةالبياناتToolStripMenuItem
        '
        Me.فتحقاعدةالبياناتToolStripMenuItem.Name = "فتحقاعدةالبياناتToolStripMenuItem"
        Me.فتحقاعدةالبياناتToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.فتحقاعدةالبياناتToolStripMenuItem.Text = "فتح قاعدة البيانات"
        '
        'استرجاعالنسخةالاحتياطيةToolStripMenuItem
        '
        Me.استرجاعالنسخةالاحتياطيةToolStripMenuItem.Name = "استرجاعالنسخةالاحتياطيةToolStripMenuItem"
        Me.استرجاعالنسخةالاحتياطيةToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.استرجاعالنسخةالاحتياطيةToolStripMenuItem.Text = "استرجاع النسخة الاحتياطية"
        '
        'حولالبرنامجToolStripMenuItem
        '
        Me.حولالبرنامجToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.حولالبرنامجToolStripMenuItem.Name = "حولالبرنامجToolStripMenuItem"
        Me.حولالبرنامجToolStripMenuItem.Size = New System.Drawing.Size(101, 25)
        Me.حولالبرنامجToolStripMenuItem.Text = "حول البرنامج"
        '
        'تسجيلالخروجToolStripMenuItem
        '
        Me.تسجيلالخروجToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem"
        Me.تسجيلالخروجToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.تسجيلالخروجToolStripMenuItem.Size = New System.Drawing.Size(111, 25)
        Me.تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(62, 25)
        Me.TimeToolStripMenuItem.Text = "الوقت"
        '
        'جلساتالقضاياToolStripMenuItem1
        '
        Me.جلساتالقضاياToolStripMenuItem1.Name = "جلساتالقضاياToolStripMenuItem1"
        Me.جلساتالقضاياToolStripMenuItem1.Size = New System.Drawing.Size(238, 26)
        Me.جلساتالقضاياToolStripMenuItem1.Text = "مواعيد جلسات القضايا"
        '
        'مواعيدجلساتالاستئنافToolStripMenuItem
        '
        Me.مواعيدجلساتالاستئنافToolStripMenuItem.Name = "مواعيدجلساتالاستئنافToolStripMenuItem"
        Me.مواعيدجلساتالاستئنافToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.مواعيدجلساتالاستئنافToolStripMenuItem.Text = "مواعيد جلسات الاستئناف"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 421)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainScreen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الشاشة الرئيسية"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents البطاقاتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents العميلToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents القضيةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الاستشارةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الجلسةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents نقلالقضيةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents وثائقعدليةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents روابطمهمةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents حفظالبياناتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents حولالبرنامجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents تسجيلالخروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents جلساتالقضاياToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents نسخةاحتياطيةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents فتحقاعدةالبياناتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents استرجاعالنسخةالاحتياطيةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents قسطاطToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents المكتفيToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents عدالةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents المنظومةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents وزارةالعدلالعلياToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents التقاريرToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents قضاياالعميلToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الجلساتحسبالتاريخToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents جلساتالاسئنافحسبالتاريخToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents جلساتالقضاياToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents مواعيدجلساتالاستئنافToolStripMenuItem As ToolStripMenuItem
End Class
