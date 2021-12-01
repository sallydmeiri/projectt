Imports System.Data.OleDb
Public Class Justic__documents
    ''متغيرات على مستوى الكلاسس
    Dim cnn As New OleDb.OleDbConnection ''تعريف متغير 
    Dim sql As String ''تعريف متغير من نوع سترينج
    Dim ds As New DataSet  ''تعريف متغير من نوع داتا ست
    Dim cr As Integer = 0 ''تعريف متغير من نوع صحيح قيمته الابتدائية صفر
    Dim path As String


    Private Sub Justic__documents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''تعريف المسار 
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))

        ''تعريف للوصول لموقع الداتا سورس
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

        ''كتابة جملة الاسك يو ال لعرض جميع بيانات جدول العميل

        sql = "SELECT Justic_documents.Doc_num, Justic_documents.client_NUM, client.client_NAME, Justic_documents.Type, Justic_documents.Details, Justic_documents.Notes
FROM(client INNER JOIN Justic_documents ON client.client_num = Justic_documents.client_NUM)"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        da.Fill(ds, "e")
        TxtDoc_num.Text = ds.Tables("e").Rows(cr).Item("Doc_num")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        CmboType.Text = ds.Tables("e").Rows(cr).Item("Type")
        TxtDetails.Text = ds.Tables("e").Rows(cr).Item("Details")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")

        TxtDoc_num.Select()
        ''تعبأة الداتا قريد فيو بمحتويات الداتا ست
        DataGridView1.DataSource = ds.Tables("e")

        ''عرض ملف البدي اف المخزن داخل ملف  تخزين ملفات البدي اف داخل اداة البدي اف  
        AxAcroPDF1.src = path & "\Attachmentjustic_documents\" & TxtDoc_num.Text & ".pdf"
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
                TxtDoc_num.Text = (DataGridView1.CurrentRow.Cells(1).Value)
                Txtclient_NUM.Text = (DataGridView1.CurrentRow.Cells(2).Value)
                CmboType.Text = (DataGridView1.CurrentRow.Cells(4).Value)
                TxtDetails.Text = (DataGridView1.CurrentRow.Cells(5).Value)
                TxtNotes.Text = (DataGridView1.CurrentRow.Cells(6).Value)
                AxAcroPDF1.src = path & "\Attachmentjustic_documents\" & TxtDoc_num.Text & ".pdf"

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
        TxtDoc_num.Text = ""
        Txtclient_NUM.Text = ""
        CmboType.Text = ""
        TxtDetails.Text = ""
        TxtNotes.Text = ""
        TxtDoc_num.Focus()
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

        sql = "insert into Justic_documents ( client_NUM, Type, Details, Notes)
         values( " & Txtclient_NUM.Text & ",'" & CmboType.Text & "','" & TxtDetails.Text & "','" & TxtNotes.Text & "')"

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
            FileCopy(OpenFileDialog1.FileName, path & "\Attachmentjustic_documents\" & TxtDoc_num.Text & ".pdf")
        End If

        MsgBox("done")

        sql = "SELECT Justic_documents.Doc_num, Justic_documents.client_NUM, client.client_NAME, Justic_documents.Type, Justic_documents.Details, Justic_documents.Notes
FROM(client INNER JOIN Justic_documents ON client.client_num = Justic_documents.client_NUM)"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")

        TxtDoc_num.Text = ds.Tables("e").Rows(cr).Item("Doc_num")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        CmboType.Text = ds.Tables("e").Rows(cr).Item("Type")
        TxtDetails.Text = ds.Tables("e").Rows(cr).Item("Details")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")

        TxtDoc_num.Select()

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

        sql = " update  Justic_documents set client_NUM =" & Txtclient_NUM.Text & " , Type= '" & CmboType.Text & "', Details= '" & TxtDetails.Text & "',Notes ='" & TxtNotes.Text & "' where Doc_num =" & TxtDoc_num.Text & ""


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
            FileCopy(OpenFileDialog1.FileName, path & "\Attachmentjustic_documents\" & TxtDoc_num.Text & ".pdf")

        End If


        MsgBox("done")

        sql = "SELECT Justic_documents.Doc_num, Justic_documents.client_NUM, client.client_NAME, Justic_documents.Type, Justic_documents.Details, Justic_documents.Notes
FROM(client INNER JOIN Justic_documents ON client.client_num = Justic_documents.client_NUM)"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")

        TxtDoc_num.Text = ds.Tables("e").Rows(cr).Item("Doc_num")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        CmboType.Text = ds.Tables("e").Rows(cr).Item("Type")
        TxtDetails.Text = ds.Tables("e").Rows(cr).Item("Details")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")

        TxtDoc_num.Select()

        Exit Sub
Label1:
        cnn.Close()
        MsgBox(Err.Description)

    End Sub

    Private Sub BtnDelet_Click(sender As Object, e As EventArgs) Handles BtnDelet.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        If MessageBox.Show("هل انت متاكد انك تريد حذف هذه الوثيقة؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            sql = "delete from Justic_documents where TxtDoc_num= " & TxtDoc_num.Text & ""
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()

            da.Fill(ds, "e")

            TxtDoc_num.Text = ds.Tables("e").Rows(cr).Item("Doc_num")
            Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
            CmboType.Text = ds.Tables("e").Rows(cr).Item("Type")
            TxtDetails.Text = ds.Tables("e").Rows(cr).Item("Details")
            TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")

            TxtDoc_num.Select()

            MsgBox("done")
        End If
    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        ''الانتقال للسجل الاول
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cr = 0
        sql = "SELECT Justic_documents.Doc_num, Justic_documents.client_NUM, client.client_NAME, Justic_documents.Type, Justic_documents.Details, Justic_documents.Notes
FROM(client INNER JOIN Justic_documents ON client.client_num = Justic_documents.client_NUM)"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()
        da.Fill(ds, "e")
        TxtDoc_num.Text = ds.Tables("e").Rows(cr).Item("Doc_num")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        CmboType.Text = ds.Tables("e").Rows(cr).Item("Type")
        TxtDetails.Text = ds.Tables("e").Rows(cr).Item("Details")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        AxAcroPDF1.src = path & "\Attachmentjustic_documents\" & TxtDoc_num.Text & ".pdf"

    End Sub


    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        If cr >= 1 Then
            cr = cr - 1
            sql = "SELECT Justic_documents.Doc_num, Justic_documents.client_NUM, client.client_NAME, Justic_documents.Type, Justic_documents.Details, Justic_documents.Notes
FROM(client INNER JOIN Justic_documents ON client.client_num = Justic_documents.client_NUM)"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()

            da.Fill(ds, "e")
            TxtDoc_num.Text = ds.Tables("e").Rows(cr).Item("Doc_num")
            Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
            CmboType.Text = ds.Tables("e").Rows(cr).Item("Type")
            TxtDetails.Text = ds.Tables("e").Rows(cr).Item("Details")
            TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            AxAcroPDF1.src = path & "\Attachmentjustic_documents\" & TxtDoc_num.Text & ".pdf"

        End If
    End Sub
    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        Dim tr As Integer
        tr = ds.Tables("e").Rows.Count - 1
        If cr < tr Then
            cr = cr + 1
            sql = "SELECT Justic_documents.Doc_num, Justic_documents.client_NUM, client.client_NAME, Justic_documents.Type, Justic_documents.Details, Justic_documents.Notes
FROM(client INNER JOIN Justic_documents ON client.client_num = Justic_documents.client_NUM)"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()
            da.Fill(ds, "e")
            TxtDoc_num.Text = ds.Tables("e").Rows(cr).Item("Doc_num")
            Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
            CmboType.Text = ds.Tables("e").Rows(cr).Item("Type")
            TxtDetails.Text = ds.Tables("e").Rows(cr).Item("Details")
            TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            AxAcroPDF1.src = path & "\Attachmentjustic_documents\" & TxtDoc_num.Text & ".pdf"

        End If

    End Sub


    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        cr = ds.Tables("e").Rows.Count - 1
        sql = "SELECT Justic_documents.Doc_num, Justic_documents.client_NUM, client.client_NAME, Justic_documents.Type, Justic_documents.Details, Justic_documents.Notes
FROM(client INNER JOIN Justic_documents ON client.client_num = Justic_documents.client_NUM)"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")

        TxtDoc_num.Text = ds.Tables("e").Rows(cr).Item("Doc_num")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        CmboType.Text = ds.Tables("e").Rows(cr).Item("Type")
        TxtDetails.Text = ds.Tables("e").Rows(cr).Item("Details")
        TxtNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        AxAcroPDF1.src = path & "\Attachmentjustic_documents\" & TxtDoc_num.Text & ".pdf"
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If ComboBox1.Text = "رقم الوثيقة" Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM Justic_documents WHERE Doc_num like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "نوع الوثيقة" Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM Justic_documents WHERE Type like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "رقم العميل" Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM Justic_documents WHERE client_NUM like '%" & txtSearch.Text & "%'", cnn)
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