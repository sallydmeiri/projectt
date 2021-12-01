Imports System.Data.OleDb
Public Class client
    ''متغيرات على مستوى الكلاسس
    Dim cnn As New OleDb.OleDbConnection ''تعريف متغير 
    Dim sql As String ''تعريف متغير من نوع سترينج
    Dim ds As New DataSet  ''تعريف متغير من نوع داتا ست
    Dim cr As Integer = 0 ''تعريف متغير من نوع صحيح قيمته الابتدائية صفر
    Dim path As String


    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''تعريف المسار 
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))

        ''تعريف للوصول لموقع الداتا سورس
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

        ''كتابة جملة الاسك يو ال لعرض جميع بيانات جدول العميل
        sql = "select * from client"

        ''تعريف داتا ادابتر ممر لها  جملة الاسك سو ال والسي ان ان 
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        ''تعبأة الداتا ادابتر بالداتا ست 
        da.Fill(ds, "e")

        ''كل حقل من الحقول(تكست بوكس) التي بالشاشة يعرض داتخله البيانات المناسبة له بالداتا ست
        Txtclient_num.Text = ds.Tables("e").Rows(cr).Item("client_num")
        Txtclient_NAME.Text = ds.Tables("e").Rows(cr).Item("client_NAME")
        Txtclient_ID.Text = ds.Tables("e").Rows(cr).Item("client_ID")
        txtAddress.Text = ds.Tables("e").Rows(cr).Item("Address")
        DTPbirthday.Value = ds.Tables("e").Rows(cr).Item("birthday")
        Txtjob.Text = ds.Tables("e").Rows(cr).Item("job")
        TxtMob_NUM.Text = ds.Tables("e").Rows(cr).Item("Mob_NUM")
        TxtPhone.Text = ds.Tables("e").Rows(cr).Item("Phone")
        TxtEmail.Text = ds.Tables("e").Rows(cr).Item("Email")
        txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        Txtclient_NAME.Select()

        ''تعبأة الداتا قريد فيو بمحتويات الداتا ست
        DataGridView1.DataSource = ds.Tables("e")

        ''عرض ملف البدي اف المخزن داخل ملف  تخزين ملفات البدي اف داخل اداة البدي اف  
        AxAcroPDF1.src = path & "\Attachmentclient\" & Txtclient_ID.Text & ".pdf"
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ''تفريغ الحقول جميعها....
        Txtclient_num.Text = ""
        Txtclient_NAME.Clear()
        Txtclient_ID.Clear()
        txtAddress.Clear()
        Txtjob.Clear()
        TxtMob_NUM.Clear()
        TxtPhone.Clear()
        TxtEmail.Clear()
        txtNotes.Clear()
        Txtclient_NAME.Focus()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ''برمجة زر اضافة عميل جديد
        On Error GoTo Label1 ''اذا كان هناك مشكلة في تنفيذ الاوامر  بعد هذا السطر نفذ  ما بعد ليبل وان

        ''تعريف المسار 
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))

        ''تحديد الكوندشين
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

        '' تعريف جملة الاسكيوال الخاصة بالاضافة
        sql = "insert into  client (client_NAME, client_ID, Address, birthday, job, Mob_NUM, phone, Email, Notes)
                 values('" & Txtclient_NAME.Text & "', " & Txtclient_ID.Text & ",'" & txtAddress.Text & "','" & DTPbirthday.Text & "','" & Txtjob.Text & "','" & TxtMob_NUM.Text & "','" & TxtPhone.Text & "','" & TxtEmail.Text & "','" & txtNotes.Text & "')"

        ''فتح الكوندشين
        cnn.Open()

        ''تعريف السي ام ادي   واعطاها الكوندشين وجملة الاسكيوال
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql

        ''السي ام دي ليست استعلام 
        cmd.ExecuteNonQuery()

        ''اغلاق السي ام دي
        cnn.Close()

        ''اذا لم تكون اداة البدي اف فارغة 
        sql = "select * from client"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")
        Txtclient_num.Text = ds.Tables("e").Rows(cr).Item("client_num")
        Txtclient_NAME.Text = ds.Tables("e").Rows(cr).Item("client_NAME")
        Txtclient_ID.Text = ds.Tables("e").Rows(cr).Item("client_ID")
        txtAddress.Text = ds.Tables("e").Rows(cr).Item("Address")
        DTPbirthday.Value = ds.Tables("e").Rows(cr).Item("birthday")
        Txtjob.Text = ds.Tables("e").Rows(cr).Item("job")
        TxtMob_NUM.Text = ds.Tables("e").Rows(cr).Item("Mob_NUM")
        TxtPhone.Text = ds.Tables("e").Rows(cr).Item("Phone")
        TxtEmail.Text = ds.Tables("e").Rows(cr).Item("Email")
        txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        DataGridView1.DataSource = ds.Tables("e")

        Txtclient_num.Select()
        MsgBox("done")
        If AxAcroPDF1.src <> Nothing Then
            ''  تخزين ملف البدي اف داخل ملف  اتتشمينت كلبنت باسم رقم الهوية 
            FileCopy(OpenFileDialog1.FileName, path & "\Attachmentclient\" & Txtclient_ID.Text & ".pdf")
        End If

        Exit Sub
Label1:
        cnn.Close()
        MsgBox(Err.Description)
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

        sql = " update client set client_NAME ='" & Txtclient_NAME.Text & "' , client_ID= " & Txtclient_ID.Text & ", Address= '" & txtAddress.Text & "',birthday ='" & DTPbirthday.Text & "',job ='" & Txtjob.Text & "',Mob_NUM='" & TxtMob_NUM.Text & "',Phone='" & TxtPhone.Text & "',Email='" & TxtEmail.Text & "',Notes='" & txtNotes.Text & "' where client_num =" & Txtclient_num.Text & ""

        ''فتح الكوندشين
        cnn.Open()

        ''تعريف السي ام ادي   واعطاها الكوندشين وجملة الاسكيوال
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql

        ''السي ام دي ليست استعلام 
        cmd.ExecuteNonQuery()

        ''اغلاق السي ام دي
        cnn.Close()

        sql = "select * from client"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")
        Txtclient_num.Text = ds.Tables("e").Rows(cr).Item("client_num")
        Txtclient_NAME.Text = ds.Tables("e").Rows(cr).Item("client_NAME")
        Txtclient_ID.Text = ds.Tables("e").Rows(cr).Item("client_ID")
        txtAddress.Text = ds.Tables("e").Rows(cr).Item("Address")
        DTPbirthday.Value = ds.Tables("e").Rows(cr).Item("birthday")
        Txtjob.Text = ds.Tables("e").Rows(cr).Item("job")
        TxtMob_NUM.Text = ds.Tables("e").Rows(cr).Item("Mob_NUM")
        TxtPhone.Text = ds.Tables("e").Rows(cr).Item("Phone")
        TxtEmail.Text = ds.Tables("e").Rows(cr).Item("Email")
        txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        DataGridView1.DataSource = ds.Tables("e")

        Txtclient_num.Select()
        MsgBox("done")

        ''اذا لم تكون اداة البدي اف فارغة 
        If AxAcroPDF1.src = Nothing Then
            ''  تخزين ملف البدي اف داخل ملف  اتتشمينت كلبنت باسم رقم الهوية 
            FileCopy(OpenFileDialog1.FileName, path & "\Attachmentclient\" & Txtclient_ID.Text & ".pdf")

        End If
        AxAcroPDF1.src = path & "\Attachmentclient\" & Txtclient_ID.Text & ".pdf"

    End Sub
    Private Sub BtnDelet_Click(sender As Object, e As EventArgs) Handles BtnDelet.Click
        If MessageBox.Show("هل انت متاكد انك تريد حذف هذا العميل؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"
            sql = "delete from client where client_num= " & Txtclient_num.Text & ""

            ''فتح الكوندشين
            cnn.Open()

            ''تعريف السي ام ادي   واعطاها الكوندشين وجملة الاسكيوال
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = sql

            ''السي ام دي ليست استعلام 
            cmd.ExecuteNonQuery()

            ''اغلاق السي ام دي
            cnn.Close()

            ''اذا لم تكون اداة البدي اف فارغة 


            MsgBox("done")

            sql = "select * from client"

            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()

            da.Fill(ds, "e")
            Txtclient_num.Text = ds.Tables("e").Rows(0).Item("client_num")
            Txtclient_NAME.Text = ds.Tables("e").Rows(0).Item("client_NAME")
            Txtclient_ID.Text = ds.Tables("e").Rows(0).Item("client_ID")
            txtAddress.Text = ds.Tables("e").Rows(0).Item("Address")
            DTPbirthday.Value = ds.Tables("e").Rows(0).Item("birthday")
            Txtjob.Text = ds.Tables("e").Rows(0).Item("job")
            TxtMob_NUM.Text = ds.Tables("e").Rows(0).Item("Mob_NUM")
            TxtPhone.Text = ds.Tables("e").Rows(0).Item("Phone")
            TxtEmail.Text = ds.Tables("e").Rows(0).Item("Email")
            txtNotes.Text = ds.Tables("e").Rows(0).Item("Notes")
            DataGridView1.DataSource = ds.Tables("e")
            Txtclient_num.Select()

        End If
    End Sub



    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        ''الانتقال للسجل الاول
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cr = 0
        sql = "select * from client"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")
        Txtclient_num.Text = ds.Tables("e").Rows(0).Item("client_num")
        Txtclient_NAME.Text = ds.Tables("e").Rows(0).Item("client_NAME")
        Txtclient_ID.Text = ds.Tables("e").Rows(0).Item("client_ID")
        txtAddress.Text = ds.Tables("e").Rows(0).Item("Address")
        DTPbirthday.Value = ds.Tables("e").Rows(0).Item("birthday")
        Txtjob.Text = ds.Tables("e").Rows(0).Item("job")
        TxtMob_NUM.Text = ds.Tables("e").Rows(0).Item("Mob_NUM")
        TxtPhone.Text = ds.Tables("e").Rows(0).Item("Phone")
        TxtEmail.Text = ds.Tables("e").Rows(0).Item("Email")
        txtNotes.Text = ds.Tables("e").Rows(0).Item("Notes")
        AxAcroPDF1.src = path & "\Attachmentclient\" & Txtclient_ID.Text & ".pdf"


    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        Dim tr As Integer
        tr = ds.Tables("e").Rows.Count - 1
        If cr < tr Then
            cr = cr + 1
            sql = "select * from client"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()

            da.Fill(ds, "e")
            Txtclient_num.Text = ds.Tables("e").Rows(cr).Item("client_num")
            Txtclient_NAME.Text = ds.Tables("e").Rows(cr).Item("client_NAME")
            Txtclient_ID.Text = ds.Tables("e").Rows(cr).Item("client_ID")
            txtAddress.Text = ds.Tables("e").Rows(cr).Item("Address")
            DTPbirthday.Value = ds.Tables("e").Rows(cr).Item("birthday")
            Txtjob.Text = ds.Tables("e").Rows(cr).Item("job")
            TxtMob_NUM.Text = ds.Tables("e").Rows(cr).Item("Mob_NUM")
            TxtPhone.Text = ds.Tables("e").Rows(cr).Item("Phone")
            TxtEmail.Text = ds.Tables("e").Rows(cr).Item("Email")
            txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            AxAcroPDF1.src = path & "\Attachmentclient\" & Txtclient_ID.Text & ".pdf"
        End If
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        If cr >= 1 Then
            cr = cr - 1
            sql = "select * from client"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()

            da.Fill(ds, "e")
            Txtclient_num.Text = ds.Tables("e").Rows(cr).Item("client_num")
            Txtclient_NAME.Text = ds.Tables("e").Rows(cr).Item("client_NAME")
            Txtclient_ID.Text = ds.Tables("e").Rows(cr).Item("client_ID")
            txtAddress.Text = ds.Tables("e").Rows(cr).Item("Address")
            DTPbirthday.Value = ds.Tables("e").Rows(cr).Item("birthday")
            Txtjob.Text = ds.Tables("e").Rows(cr).Item("job")
            TxtMob_NUM.Text = ds.Tables("e").Rows(cr).Item("Mob_NUM")
            TxtPhone.Text = ds.Tables("e").Rows(cr).Item("Phone")
            TxtEmail.Text = ds.Tables("e").Rows(cr).Item("Email")
            txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            AxAcroPDF1.src = path & "\Attachmentclient\" & Txtclient_ID.Text & ".pdf"

        End If

    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cr = ds.Tables("e").Rows.Count - 1
        sql = "select * from client"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()
        da.Fill(ds, "e")
        Txtclient_num.Text = ds.Tables("e").Rows(cr).Item("client_num")
        Txtclient_NAME.Text = ds.Tables("e").Rows(cr).Item("client_NAME")
        Txtclient_ID.Text = ds.Tables("e").Rows(cr).Item("client_ID")
        txtAddress.Text = ds.Tables("e").Rows(cr).Item("Address")
        DTPbirthday.Value = ds.Tables("e").Rows(cr).Item("birthday")
        Txtjob.Text = ds.Tables("e").Rows(cr).Item("job")
        TxtMob_NUM.Text = ds.Tables("e").Rows(cr).Item("Mob_NUM")
        TxtPhone.Text = ds.Tables("e").Rows(cr).Item("Phone")
        TxtEmail.Text = ds.Tables("e").Rows(cr).Item("Email")
        txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        AxAcroPDF1.src = path & "\Attachmentclient\" & Txtclient_ID.Text & ".pdf"

    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' للبحث
        If ComboBox1.Text = "الرقم" Then ''اذا كان داخل الكمبو بوكس يساوي الرقم
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM client WHERE client_num like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "الاسم" Then ''اذا كان داخل الكمبو بوكس يساوي الاسم
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM client WHERE client_NAME like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "رقم الهوية" Then ''اذا كان داخل الكمبو بوكس يساوي رقم الهوية
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM client WHERE client_ID like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "العنوان" Then ''اذا كان داخل الكمبو بوكس يساوي العنوان
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM client WHERE Address like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "المهنة" Then ''اذا كان داخل الكمبو بوكس يساوي المهنة
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM client WHERE job like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "رقم الجوال" Then ''اذا كان داخل الكمبو بوكس ساوي رقم الجوال
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM client WHERE Mob_NUM like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "الهاتف" Then ''اذا كان داخل الكمبو بوكس ساوي الهاتف
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM client WHERE Phone like '%" & txtSearch.Text & "%'", cnn) ''جملة اسكيوال 
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
    End Sub


    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click
        OpenFileDialog1.Filter = "pdf files |*.pdf" ''فلترة الاوبن فايل ديلوق ليكن من نوع بدي اف
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then ''
            AxAcroPDF1.src = OpenFileDialog1.FileName ''يعرض داخل اداة البدي اف الملف المختار من الفايل ديلوق
        End If
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
                Txtclient_num.Text = (DataGridView1.CurrentRow.Cells(1).Value)
                Txtclient_NAME.Text = (DataGridView1.CurrentRow.Cells(2).Value)
                Txtclient_ID.Text = (DataGridView1.CurrentRow.Cells(3).Value)
                txtAddress.Text = (DataGridView1.CurrentRow.Cells(4).Value)
                DTPbirthday.Value = (DataGridView1.CurrentRow.Cells(5).Value)
                Txtjob.Text = (DataGridView1.CurrentRow.Cells(6).Value)
                TxtMob_NUM.Text = (DataGridView1.CurrentRow.Cells(7).Value)
                TxtPhone.Text = (DataGridView1.CurrentRow.Cells(8).Value)
                TxtEmail.Text = (DataGridView1.CurrentRow.Cells(9).Value)
                txtNotes.Text = (DataGridView1.CurrentRow.Cells(10).Value)
                AxAcroPDF1.src = path & "\Attachmentclient\" & Txtclient_ID.Text & ".pdf"

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(0).Value = "عرض البيانات"
            Dim rows As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
End Class