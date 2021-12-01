Imports System.Data.OleDb

Public Class Transfer_of_case
    ''متغيرات على مستوى الكلاسس
    Dim cnn As New OleDb.OleDbConnection ''تعريف متغير 
    Dim sql As String ''تعريف متغير من نوع سترينج
    Dim ds As New DataSet  ''تعريف متغير من نوع داتا ست
    Dim cr As Integer = 0 ''تعريف متغير من نوع صحيح قيمته الابتدائية صفر
    Dim path As String
    Private Sub Transfer_of_case_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''تعريف المسار 
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))

        ''تعريف للوصول لموقع الداتا سورس
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

        ''كتابة جملة الاسك يو ال لعرض جميع بيانات جدول العميل
        sql = "SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office)"
        ''تعريف داتا ادابتر ممر لها  جملة الاسك سو ال والسي ان ان 
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        ''تعبأة الداتا ادابتر بالداتا ست 
        da.Fill(ds, "e")

        ''كل حقل من الحقول(تكست بوكس) التي بالشاشة يعرض داتخله البيانات المناسبة له بالداتا ست
        Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
        Label6.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
        TxtRes_num.Text = ds.Tables("e").Rows(cr).Item("Res_num")
        Txtcourt_num.Text = ds.Tables("e").Rows(cr).Item("court_num")
        TxtImple_num.Text = ds.Tables("e").Rows(cr).Item("Imple_num")
        DTPTrans_Date.Value = ds.Tables("e").Rows(cr).Item("Trans_Date")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("notes")
        Txtnum_in_office.Select()

        ''تعبأة الداتا قريد فيو بمحتويات الداتا ست
        DataGridView1.DataSource = ds.Tables("e")

        'عرض ملف البدي اف المخزن داخل ملف  تخزين ملفات البدي اف داخل اداة البدي اف  
        AxAcroPDF1.src = path & "\AttachmentTransfer_of_case\" & Txtnum_in_office.Text & ".pdf"


    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
                Txtnum_in_office.Text = (DataGridView1.CurrentRow.Cells(1).Value)
                Label6.Text = (DataGridView1.CurrentRow.Cells(2).Value)
                TxtRes_num.Text = (DataGridView1.CurrentRow.Cells(3).Value)
                Txtcourt_num.Text = (DataGridView1.CurrentRow.Cells(4).Value)
                TxtImple_num.Text = (DataGridView1.CurrentRow.Cells(5).Value)
                DTPTrans_Date.Value = (DataGridView1.CurrentRow.Cells(6).Value)
                TxtNotes.Text = (DataGridView1.CurrentRow.Cells(7).Value)
                AxAcroPDF1.src = path & "\AttachmentTransfer_of_case\" & Txtnum_in_office.Text & ".pdf"
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
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Txtnum_in_office.Text = ""
        TxtRes_num.Text = ""
        Label6.Text = ""
        Txtcourt_num.Text = ""
        TxtImple_num.Text = ""
        TxtNotes.Text = ""
        Txtnum_in_office.Select()
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

        sql = "insert into   Transfer_of_case ( num_in_office, Res_num, court_num,Imple_num, Notes, Trans_Date)
         values( " & Txtnum_in_office.Text & ",'" & TxtRes_num.Text & "','" & Txtcourt_num.Text & "','" & TxtImple_num.Text & "','" & TxtNotes.Text & "','" & DTPTrans_Date.Text & "')"


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
        If AxAcroPDF1.src <> Nothing Then
            ''  تخزين ملف البدي اف داخل ملف  اتتشمينت كلبنت باسم رقم الاستشارة 
            FileCopy(OpenFileDialog1.FileName, path & "\AttachmentTransfer_of_case\" & Txtnum_in_office.Text & ".pdf")
        End If

        MsgBox("done")

        sql = "SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office)"
        ''تعريف داتا ادابتر ممر لها  جملة الاسك سو ال والسي ان ان 

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")

        ''كل حقل من الحقول(تكست بوكس) التي بالشاشة يعرض داتخله البيانات المناسبة له بالداتا ست
        Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
        Label6.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
        TxtRes_num.Text = ds.Tables("e").Rows(cr).Item("Res_num")
        Txtcourt_num.Text = ds.Tables("e").Rows(cr).Item("court_num")
        TxtImple_num.Text = ds.Tables("e").Rows(cr).Item("Imple_num")
        DTPTrans_Date.Value = ds.Tables("e").Rows(cr).Item("Trans_Date")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        Txtnum_in_office.Select()

        ''تعبأة الداتا قريد فيو بمحتويات الداتا ست
        DataGridView1.DataSource = ds.Tables("e")

        Exit Sub
Label1:
        cnn.Close()
        MsgBox(Err.Description)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        On Error GoTo Label1 ''اذا كان هناك مشكلة في تنفيذ الاوامر  بعد هذا السطر نفذ  ما بعد ليبل وان

        ''تعريف المسار 
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))

        ''تحديد الكوندشين
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

        '' تعريف جملة الاسكيوال الخاصة بالاضافة

        sql = " update Transfer_of_case set Res_num= '" & TxtRes_num.Text & "', court_num= '" & Txtcourt_num.Text & "',Imple_num ='" & TxtImple_num.Text & "',Trans_Date='" & DTPTrans_Date.Text & "',Notes='" & TxtNotes.Text & "' where num_in_office =" & Txtnum_in_office.Text & ""


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
        If AxAcroPDF1.src = Nothing Then
            ''  تخزين ملف البدي اف داخل ملف  اتتشمينت كلبنت باسم رقم الاستشارة 
            FileCopy(OpenFileDialog1.FileName, path & "\AttachmentTransfer_of_case\" & Txtnum_in_office.Text & ".pdf")

        End If

        MsgBox("done")

        sql = "SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office)"
        ''تعريف داتا ادابتر ممر لها  جملة الاسك سو ال والسي ان ان 

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")

        ''كل حقل من الحقول(تكست بوكس) التي بالشاشة يعرض داتخله البيانات المناسبة له بالداتا ست
        Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
        Label6.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
        TxtRes_num.Text = ds.Tables("e").Rows(cr).Item("Res_num")
        Txtcourt_num.Text = ds.Tables("e").Rows(cr).Item("court_num")
        TxtImple_num.Text = ds.Tables("e").Rows(cr).Item("Imple_num")
        DTPTrans_Date.Value = ds.Tables("e").Rows(cr).Item("Trans_Date")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        Txtnum_in_office.Select()

        ''تعبأة الداتا قريد فيو بمحتويات الداتا ست
        DataGridView1.DataSource = ds.Tables("e")

        Exit Sub
Label1:
        cnn.Close()
        MsgBox(Err.Description)

    End Sub

    Private Sub BtnDelet_Click(sender As Object, e As EventArgs) Handles BtnDelet.Click
        If MessageBox.Show("هل انت متاكد انك تريد حذف هذا القضية؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"
            sql = "delete from Transfer_of_case where num_in_office= " & Txtnum_in_office.Text & ""

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

            sql = "select * from Transfer_of_case"

            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()

            da.Fill(ds, "e")
            Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
            Label6.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
            TxtRes_num.Text = ds.Tables("e").Rows(cr).Item("Res_num")
            Txtcourt_num.Text = ds.Tables("e").Rows(cr).Item("court_num")
            TxtImple_num.Text = ds.Tables("e").Rows(cr).Item("Imple_num")
            DTPTrans_Date.Value = ds.Tables("e").Rows(cr).Item("Trans_Date")
            TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            Txtnum_in_office.Select()

        End If

    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        ''الانتقال للسجل الاول
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cr = 0
        sql = "SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office)"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")
        Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
        Label6.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
        TxtRes_num.Text = ds.Tables("e").Rows(cr).Item("Res_num")
        Txtcourt_num.Text = ds.Tables("e").Rows(cr).Item("court_num")
        TxtImple_num.Text = ds.Tables("e").Rows(cr).Item("Imple_num")
        DTPTrans_Date.Value = ds.Tables("e").Rows(cr).Item("Trans_Date")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        Txtnum_in_office.Select()
        AxAcroPDF1.src = path & "\AttachmentTransfer_of_case\" & Txtnum_in_office.Text & ".pdf"

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        Dim tr As Integer
        tr = ds.Tables("e").Rows.Count - 1
        If cr < tr Then
            cr = cr + 1
            sql = "SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office)"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()

            da.Fill(ds, "e")
            Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
            Label6.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
            TxtRes_num.Text = ds.Tables("e").Rows(cr).Item("Res_num")
            Txtcourt_num.Text = ds.Tables("e").Rows(cr).Item("court_num")
            TxtImple_num.Text = ds.Tables("e").Rows(cr).Item("Imple_num")
            DTPTrans_Date.Value = ds.Tables("e").Rows(cr).Item("Trans_Date")
            TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            Txtnum_in_office.Select()
            AxAcroPDF1.src = path & "\AttachmentTransfer_of_case\" & Txtnum_in_office.Text & ".pdf"
        End If
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        If cr >= 1 Then
            cr = cr - 1
            sql = "SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office)"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()

            da.Fill(ds, "e")
            Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
            Label6.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
            TxtRes_num.Text = ds.Tables("e").Rows(cr).Item("Res_num")
            Txtcourt_num.Text = ds.Tables("e").Rows(cr).Item("court_num")
            TxtImple_num.Text = ds.Tables("e").Rows(cr).Item("Imple_num")
            DTPTrans_Date.Value = ds.Tables("e").Rows(cr).Item("Trans_Date")
            TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            Txtnum_in_office.Select()
            AxAcroPDF1.src = path & "\AttachmentTransfer_of_case\" & Txtnum_in_office.Text & ".pdf"

        End If
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cr = ds.Tables("e").Rows.Count - 1
        sql = "SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office)"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")
        Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
        Label6.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
        TxtRes_num.Text = ds.Tables("e").Rows(cr).Item("Res_num")
        Txtcourt_num.Text = ds.Tables("e").Rows(cr).Item("court_num")
        TxtImple_num.Text = ds.Tables("e").Rows(cr).Item("Imple_num")
        DTPTrans_Date.Value = ds.Tables("e").Rows(cr).Item("Trans_Date")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        Txtnum_in_office.Select()
        AxAcroPDF1.src = path & "\AttachmentTransfer_of_case\" & Txtnum_in_office.Text & ".pdf"
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' للبحث
        If ComboBox1.Text = "رقم القضية (بالمكتب)" Then ''اذا كان داخل الكمبو بوكس يساوي الرقم
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
                     FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office) WHERE Transfer_of_case.num_in_office like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If

        If ComboBox1.Text = "رقم القضية (بالمحكمة)" Then ''اذا كان داخل الكمبو بوكس يساوي الرقم
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
                     FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office) WHERE casee.num_in_court like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "تاريخ التحويل" Then ''اذا كان داخل الكمبو بوكس يساوي الرقم
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT Transfer_of_case.num_in_office, casee.num_in_court, Transfer_of_case.Res_num, Transfer_of_case.court_num, Transfer_of_case.Imple_num, Transfer_of_case.Notes, Transfer_of_case.Trans_Date
                     FROM (casee INNER JOIN Transfer_of_case ON casee.num_in_office = Transfer_of_case.num_in_office) WHERE Trans_Date like '%" & txtSearch.Text & "%'", cnn)
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
End Class