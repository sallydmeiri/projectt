Imports System.Data.OleDb
Public Class advice
    ''متغيرات على مستوى الكلاسس
    Dim cnn As New OleDb.OleDbConnection ''تعريف متغير 
    Dim sql As String ''تعريف متغير من نوع سترينج
    Dim ds As New DataSet  ''تعريف متغير من نوع داتا ست
    Dim cr As Integer = 0 ''تعريف متغير من نوع صحيح قيمته الابتدائية صفر
    Dim path As String

    Private Sub advice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''تعريف المسار 
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))

        ''تعريف للوصول لموقع الداتا سورس
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

        ''كتابة جملة الاسك يو ال لعرض جميع بيانات جدول العميل
        sql = "SELECT advice.advice_num, advice.advice_Date, advice.General_class, advice.Response, advice.client_NUM, client.client_NAME, advice.Subject, advice.Notes, advice.Description
FROM (advice INNER JOIN client ON advice.client_NUM = client.client_num)"

        ''تعريف داتا ادابتر ممر لها  جملة الاسك سو ال والسي ان ان 
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ''تعبأة الداتا ادابتر بالداتا ست 
        da.Fill(ds, "e")

        ''كل حقل من الحقول(تكست بوكس) التي بالشاشة يعرض داتخله البيانات المناسبة له بالداتا ست
        Txtadvice_num.Text = ds.Tables("e").Rows(cr).Item("advice_num")
        DTPadvice_Date.Value = ds.Tables("e").Rows(cr).Item("advice_Date")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        TxtGeneral_class.Text = ds.Tables("e").Rows(cr).Item("General_class")
        TxtSubject.Text = ds.Tables("e").Rows(cr).Item("Subject")
        txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        txtDescription.Text = ds.Tables("e").Rows(cr).Item("Description")
        txtResponse.Text = ds.Tables("e").Rows(cr).Item("Response")

        ''تعبأة الداتا قريد فيو بمحتويات الداتا ست
        DataGridView1.DataSource = ds.Tables("e")

        ''عرض ملف البدي اف المخزن داخل ملف  تخزين ملفات البدي اف داخل اداة البدي اف  
        AxAcroPDF1.src = path & "\Attachmentadvice\" & Txtadvice_num.Text & ".pdf"
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
                Txtadvice_num.Text = (DataGridView1.CurrentRow.Cells(1).Value)
                DTPadvice_Date.Value = (DataGridView1.CurrentRow.Cells(2).Value)
                Txtclient_NUM.Text = (DataGridView1.CurrentRow.Cells(5).Value)
                TxtGeneral_class.Text = (DataGridView1.CurrentRow.Cells(3).Value)
                TxtSubject.Text = (DataGridView1.CurrentRow.Cells(7).Value)
                txtNotes.Text = (DataGridView1.CurrentRow.Cells(8).Value)
                txtDescription.Text = (DataGridView1.CurrentRow.Cells(9).Value)
                txtResponse.Text = (DataGridView1.CurrentRow.Cells(4).Value)
                AxAcroPDF1.src = path & "\Attachmentadvice\" & Txtadvice_num.Text & ".pdf"

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
        ''تفريغ الحقول جميعها....
        Txtadvice_num.Text = ""
        Txtclient_NUM.Text = ""
        TxtGeneral_class.Text = ""
        TxtSubject.Text = ""
        txtNotes.Text = ""
        txtDescription.Text = ""
        txtResponse.Text = ""
        Txtadvice_num.Focus()
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

        sql = "insert into  advice (advice_Date, client_NUM, General_class, Subject, Notes, Description, Response)
         values( '" & DTPadvice_Date.Text & "'," & Txtclient_NUM.Text & ",'" & TxtGeneral_class.Text & "','" & TxtSubject.Text & "','" & txtNotes.Text & "','" & txtDescription.Text & "','" & txtResponse.Text & "')"


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
            FileCopy(OpenFileDialog1.FileName, path & "\Attachmentadvice\" & Txtadvice_num.Text & ".pdf")
        End If

        MsgBox("done")

        sql = "SELECT advice.advice_num, advice.advice_Date, advice.General_class, advice.Response, advice.client_NUM, client.client_NAME, advice.Subject, advice.Notes, advice.Description
FROM (advice INNER JOIN client ON advice.client_NUM = client.client_num)"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")

        Txtadvice_num.Text = ds.Tables("e").Rows(cr).Item("advice_num")
        DTPadvice_Date.Value = ds.Tables("e").Rows(cr).Item("advice_Date")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        TxtGeneral_class.Text = ds.Tables("e").Rows(cr).Item("General_class")
        TxtSubject.Text = ds.Tables("e").Rows(cr).Item("Subject")
        txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        txtDescription.Text = ds.Tables("e").Rows(cr).Item("Description")
        txtResponse.Text = ds.Tables("e").Rows(cr).Item("Response")
        DataGridView1.DataSource = ds.Tables("e")

        txtDescription.Select()

        Exit Sub
Label1:
        cnn.Close()
        MsgBox(Err.Description)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        sql = " update advice set advice_Date ='" & DTPadvice_Date.Text & "' , client_NUM= " & Txtclient_NUM.Text & ", General_class= '" & TxtGeneral_class.Text & "',Subject ='" & TxtSubject.Text & "',Notes ='" & txtNotes.Text & "',Description='" & txtDescription.Text & "',Response='" & txtResponse.Text & "' where advice_num =" & Txtadvice_num.Text & ""

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



        sql = "SELECT advice.advice_num, advice.advice_Date, advice.General_class, advice.Response, advice.client_NUM, client.client_NAME, advice.Subject, advice.Notes, advice.Description
FROM (advice INNER JOIN client ON advice.client_NUM = client.client_num)"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")

        Txtadvice_num.Text = ds.Tables("e").Rows(cr).Item("advice_num")
        DTPadvice_Date.Value = ds.Tables("e").Rows(cr).Item("advice_Date")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        TxtGeneral_class.Text = ds.Tables("e").Rows(cr).Item("General_class")
        TxtSubject.Text = ds.Tables("e").Rows(cr).Item("Subject")
        txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        txtDescription.Text = ds.Tables("e").Rows(cr).Item("Description")
        txtResponse.Text = ds.Tables("e").Rows(cr).Item("Response")
        DataGridView1.DataSource = ds.Tables("e")

        txtDescription.Select()

        MsgBox("done")
        If AxAcroPDF1.src = Nothing Then
            ''  تخزين ملف البدي اف داخل ملف  اتتشمينت كلبنت باسم رقم الاستشارة 
            FileCopy(OpenFileDialog1.FileName, path & "\Attachmentadvice\" & Txtadvice_num.Text & ".pdf")

        End If
    End Sub


    Private Sub BtnDelet_Click(sender As Object, e As EventArgs) Handles BtnDelet.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        If MessageBox.Show("هل انت متاكد انك تريد حذف هذه الاستشارة؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            sql = "delete from advice where advice_num= " & Txtadvice_num.Text & ""
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()

            da.Fill(ds, "e")

            Txtadvice_num.Text = ds.Tables("e").Rows(cr).Item("advice_num")
            DTPadvice_Date.Value = ds.Tables("e").Rows(cr).Item("advice_Date")
            Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
            TxtGeneral_class.Text = ds.Tables("e").Rows(cr).Item("General_class")
            TxtSubject.Text = ds.Tables("e").Rows(cr).Item("Subject")
            txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            txtDescription.Text = ds.Tables("e").Rows(cr).Item("Description")
            txtResponse.Text = ds.Tables("e").Rows(cr).Item("Response")
            DataGridView1.DataSource = ds.Tables("e")

            txtDescription.Select()

            MsgBox("done")
        End If
    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        ''الانتقال للسجل الاول
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cr = 0
        sql = "SELECT advice.advice_num, advice.advice_Date, advice.General_class, advice.Response, advice.client_NUM, client.client_NAME, advice.Subject, advice.Notes, advice.Description
FROM (advice INNER JOIN client ON advice.client_NUM = client.client_num)"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()
        da.Fill(ds, "e")
        Txtadvice_num.Text = ds.Tables("e").Rows(cr).Item("advice_num")
        DTPadvice_Date.Value = ds.Tables("e").Rows(cr).Item("advice_Date")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        TxtGeneral_class.Text = ds.Tables("e").Rows(cr).Item("General_class")
        TxtSubject.Text = ds.Tables("e").Rows(cr).Item("Subject")
        txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        txtDescription.Text = ds.Tables("e").Rows(cr).Item("Description")
        txtResponse.Text = ds.Tables("e").Rows(cr).Item("Response")

        AxAcroPDF1.src = path & "\Attachmentadvice\" & Txtadvice_num.Text & ".pdf"

    End Sub
    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        ''السجل التالي
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        Dim tr As Integer
        tr = ds.Tables("e").Rows.Count - 1
        If cr < tr Then
            cr = cr + 1
            sql = "SELECT advice.advice_num, advice.advice_Date, advice.General_class, advice.Response, advice.client_NUM, client.client_NAME, advice.Subject, advice.Notes, advice.Description
FROM (advice INNER JOIN client ON advice.client_NUM = client.client_num)"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()
            da.Fill(ds, "e")
            Txtadvice_num.Text = ds.Tables("e").Rows(cr).Item("advice_num")
            DTPadvice_Date.Value = ds.Tables("e").Rows(cr).Item("advice_Date")
            Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
            TxtGeneral_class.Text = ds.Tables("e").Rows(cr).Item("General_class")
            TxtSubject.Text = ds.Tables("e").Rows(cr).Item("Subject")
            txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            txtDescription.Text = ds.Tables("e").Rows(cr).Item("Description")
            txtResponse.Text = ds.Tables("e").Rows(cr).Item("Response")

            AxAcroPDF1.src = path & "\Attachmentadvice\" & Txtadvice_num.Text & ".pdf"

        End If
    End Sub
    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        ''السجل السابق
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        If cr >= 1 Then
            cr = cr - 1
            sql = "SELECT advice.advice_num, advice.advice_Date, advice.General_class, advice.Response, advice.client_NUM, client.client_NAME, advice.Subject, advice.Notes, advice.Description
FROM (advice INNER JOIN client ON advice.client_NUM = client.client_num)"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()
            da.Fill(ds, "e")
            Txtadvice_num.Text = ds.Tables("e").Rows(cr).Item("advice_num")
            DTPadvice_Date.Value = ds.Tables("e").Rows(cr).Item("advice_Date")
            Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
            TxtGeneral_class.Text = ds.Tables("e").Rows(cr).Item("General_class")
            TxtSubject.Text = ds.Tables("e").Rows(cr).Item("Subject")
            txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            txtDescription.Text = ds.Tables("e").Rows(cr).Item("Description")
            txtResponse.Text = ds.Tables("e").Rows(cr).Item("Response")
            AxAcroPDF1.src = path & "\Attachmentadvice\" & Txtadvice_num.Text & ".pdf"

        End If
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        ''السجل الاخير
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cr = ds.Tables("e").Rows.Count - 1
        sql = "SELECT advice.advice_num, advice.advice_Date, advice.General_class, advice.Response, advice.client_NUM, client.client_NAME, advice.Subject, advice.Notes, advice.Description
FROM (advice INNER JOIN client ON advice.client_NUM = client.client_num)"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()
        da.Fill(ds, "e")
        Txtadvice_num.Text = ds.Tables("e").Rows(cr).Item("advice_num")
        DTPadvice_Date.Value = ds.Tables("e").Rows(cr).Item("advice_Date")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        TxtGeneral_class.Text = ds.Tables("e").Rows(cr).Item("General_class")
        TxtSubject.Text = ds.Tables("e").Rows(cr).Item("Subject")
        txtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        txtDescription.Text = ds.Tables("e").Rows(cr).Item("Description")
        txtResponse.Text = ds.Tables("e").Rows(cr).Item("Response")
        AxAcroPDF1.src = path & "\Attachmentadvice\" & Txtadvice_num.Text & ".pdf"


    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If ComboBox1.Text = "التاريخ" Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM advice WHERE advice_num like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "رقم العميل" Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT advice.advice_num, advice.advice_Date, advice.General_class, advice.Response, advice.client_NUM, client.client_NAME, advice.Subject, advice.Notes, advice.Description
FROM (advice INNER JOIN client ON advice.client_NUM = client.client_num) WHERE advice.client_NUM like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "اسم العميل" Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT advice.advice_num, advice.advice_Date, advice.General_class, advice.Response, advice.client_NUM, client.client_NAME, advice.Subject, advice.Notes, advice.Description
FROM (advice INNER JOIN client ON advice.client_NUM = client.client_num) WHERE client_NAME like '%" & txtSearch.Text & "%'", cnn)

            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "الموضوع" Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM advice WHERE Subject like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT)
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