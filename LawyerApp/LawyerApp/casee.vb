Imports System.Data.OleDb
Public Class casee
    ''متغيرات على مستوى الكلاسس
    Dim cnn As New OleDb.OleDbConnection ''تعريف متغير 
    Dim sql As String ''تعريف متغير من نوع سترينج
    Dim ds As New DataSet  ''تعريف متغير من نوع داتا ست
    Dim cr As Integer = 0 ''تعريف متغير من نوع صحيح قيمته الابتدائية صفر
    Dim path As String

    Private Sub casee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''تعريف المسار 
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))

        ''تعريف للوصول لموقع الداتا سورس
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

        ''كتابة جملة الاسك يو ال لعرض جميع بيانات جدول القضية
        sql = "SELECT casee.num_in_office, casee.num_in_court, casee.court_name, casee.judge, casee.agent, casee.Case_cost, casee.Case_date, casee.client_NUM, client.client_NAME, casee.client_desc, casee.Case_status, casee.case_type, 
               casee.opp_name, casee.opp_Address, casee.opp_id, casee.opp_Lawyer, casee.L_opp_phone, casee.Notes
              FROM (casee INNER JOIN client ON casee.client_NUM = client.client_num)"

        ''تعريف داتا ادابتر ممر لها  جملة الاسك سو ال والسي ان ان 
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        ''تعبأة الداتا ادابتر بالداتا ست 
        da.Fill(ds, "e")

        ''كل حقل من الحقول(تكست بوكس) التي بالشاشة يعرض داتخله البيانات المناسبة له بالداتا ست
        Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
        Txtnum_in_court.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
        Txtcourt_name.Text = ds.Tables("e").Rows(cr).Item("court_name")
        Txtjudge.Text = ds.Tables("e").Rows(cr).Item("judge")
        Txtagent.Text = ds.Tables("e").Rows(cr).Item("agent")
        TxtCase_cost.Text = ds.Tables("e").Rows(cr).Item("Case_cost")
        DTPCase_date.Value = ds.Tables("e").Rows(cr).Item("Case_date")

        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        Txtclient_desc.Text = ds.Tables("e").Rows(cr).Item("client_desc")
        CmboCase_status.Text = ds.Tables("e").Rows(cr).Item("Case_status")
        Txtcase_type.Text = ds.Tables("e").Rows(cr).Item("case_type")
        Txtopp_name.Text = ds.Tables("e").Rows(cr).Item("opp_name")
        Txtopp_Address.Text = ds.Tables("e").Rows(cr).Item("opp_Address")
        Txtopp_id.Text = ds.Tables("e").Rows(cr).Item("opp_id")
        Txtopp_Lawyer.Text = ds.Tables("e").Rows(cr).Item("opp_Lawyer")
        TxtL_opp_phone.Text = ds.Tables("e").Rows(cr).Item("L_opp_phone")
        TxetNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        Txtnum_in_office.Select()

        ''تعبأة الداتا قريد فيو بمحتويات الداتا ست
        DataGridView1.DataSource = ds.Tables("e")


        ''عرض ملف البدي اف المخزن داخل ملف  تخزين ملفات البدي اف داخل اداة البدي اف  
        AxAcroPDF1.src = path & "\Attachmentcasee\" & Txtnum_in_office.Text & ".pdf"

    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            '' تعديل
            If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
                Txtnum_in_office.Text = (DataGridView1.CurrentRow.Cells(1).Value)
                Txtnum_in_court.Text = (DataGridView1.CurrentRow.Cells(2).Value)
                Txtcourt_name.Text = (DataGridView1.CurrentRow.Cells(3).Value)
                Txtjudge.Text = (DataGridView1.CurrentRow.Cells(4).Value)
                Txtagent.Text = (DataGridView1.CurrentRow.Cells(5).Value)
                TxtCase_cost.Text = (DataGridView1.CurrentRow.Cells(6).Value)
                DTPCase_date.Value = (DataGridView1.CurrentRow.Cells(7).Value)
                Txtclient_NUM.Text = (DataGridView1.CurrentRow.Cells(8).Value)
                Txtclient_desc.Text = (DataGridView1.CurrentRow.Cells(9).Value)
                CmboCase_status.Text = (DataGridView1.CurrentRow.Cells(10).Value)
                Txtcase_type.Text = (DataGridView1.CurrentRow.Cells(11).Value)
                Txtopp_name.Text = (DataGridView1.CurrentRow.Cells(12).Value)
                Txtopp_Address.Text = (DataGridView1.CurrentRow.Cells(13).Value)
                Txtopp_id.Text = (DataGridView1.CurrentRow.Cells(14).Value)
                Txtopp_Lawyer.Text = (DataGridView1.CurrentRow.Cells(15).Value)
                TxtL_opp_phone.Text = (DataGridView1.CurrentRow.Cells(16).Value)
                TxetNotes.Text = (DataGridView1.CurrentRow.Cells(17).Value)
                AxAcroPDF1.src = path & "\Attachmentcasee\" & Txtnum_in_office.Text & ".pdf"

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
        Txtnum_in_office.Text = ""
        Txtnum_in_court.Clear()
        Txtcourt_name.Clear()
        Txtjudge.Clear()
        Txtagent.Clear()
        TxtCase_cost.Clear()
        Txtclient_NUM.Clear()
        Txtclient_desc.Clear()
        CmboCase_status.Text = ""
        Txtcase_type.Clear()
        Txtopp_name.Clear()
        Txtopp_Address.Clear()
        Txtopp_id.Clear()
        Txtopp_Lawyer.Clear()
        TxtL_opp_phone.Clear()
        TxetNotes.Clear()
        Txtnum_in_office.Focus()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ''برمجة زر اضافة قضية جديد
        On Error GoTo Label1 ''اذا كان هناك مشكلة في تنفيذ الاوامر  بعد هذا السطر نفذ  ما بعد ليبل وان

        ''تعريف المسار 
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))

        ''تحديد الكوندشين
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

        '' تعريف جملة الاسكيوال الخاصة بالاضافة
        sql = "insert into  casee (num_in_court, court_name, judge, agent, Case_cost, Case_date, client_NUM, client_desc, Case_status,case_type,opp_name,opp_Address,opp_id,opp_Lawyer,L_opp_phone,Notes)
values(" & Txtnum_in_court.Text & ", '" & Txtcourt_name.Text & "','" & Txtjudge.Text & "','" & Txtagent.Text & "'," & TxtCase_cost.Text & ",'" & DTPCase_date.Text & "'," & Txtclient_NUM.Text & ",'" & Txtclient_desc.Text & "','" & CmboCase_status.Text & "','" & Txtcase_type.Text & "','" & Txtopp_name.Text & "','" & Txtopp_Address.Text & "'," & Txtopp_id.Text & ",'" & Txtopp_Lawyer.Text & "','" & TxtL_opp_phone.Text & "','" & TxetNotes.Text & "')"

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
        sql = "SELECT       casee.num_in_office, casee.num_in_court, casee.court_name, casee.judge, casee.agent, casee.Case_cost, casee.Case_date, casee.client_NUM, client.client_NAME, casee.client_desc, casee.Case_status, casee.case_type, 
                         casee.opp_name, casee.opp_Address, casee.opp_id, casee.opp_Lawyer, casee.L_opp_phone, casee.Notes
FROM            (casee INNER JOIN
                         client ON casee.client_NUM = client.client_num)"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")
        Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
        Txtnum_in_court.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
        Txtcourt_name.Text = ds.Tables("e").Rows(cr).Item("court_name")
        Txtjudge.Text = ds.Tables("e").Rows(cr).Item("judge")
        Txtagent.Text = ds.Tables("e").Rows(cr).Item("agent")
        TxtCase_cost.Text = ds.Tables("e").Rows(cr).Item("Case_cost")
        DTPCase_date.Value = ds.Tables("e").Rows(cr).Item("Case_date")

        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        Txtclient_desc.Text = ds.Tables("e").Rows(cr).Item("client_desc")
        CmboCase_status.Text = ds.Tables("e").Rows(cr).Item("Case_status")
        Txtcase_type.Text = ds.Tables("e").Rows(cr).Item("case_type")
        Txtopp_name.Text = ds.Tables("e").Rows(cr).Item("opp_name")
        Txtopp_Address.Text = ds.Tables("e").Rows(cr).Item("opp_Address")
        Txtopp_id.Text = ds.Tables("e").Rows(cr).Item("opp_id")
        Txtopp_Lawyer.Text = ds.Tables("e").Rows(cr).Item("opp_Lawyer")
        TxtL_opp_phone.Text = ds.Tables("e").Rows(cr).Item("L_opp_phone")
        TxetNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        DataGridView1.DataSource = ds.Tables("e")

        Txtnum_in_court.Select()
        MsgBox("done")
        If AxAcroPDF1.src <> Nothing Then
            ''  تخزين ملف البدي اف داخل ملف  اتتشمينت كلبنت باسم رقم القضية 
            FileCopy(OpenFileDialog1.FileName, path & "\Attachmentcasee\" & Txtnum_in_office.Text & ".pdf")
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

        sql = " update casee set num_in_court ='" & Txtnum_in_court.Text & "' , court_name= '" & Txtcourt_name.Text & "', judge= '" & Txtjudge.Text & "',agent ='" & Txtagent.Text & "',Case_cost ='" & TxtCase_cost.Text & "',client_NUM=" & Txtclient_NUM.Text & ",client_desc='" & Txtclient_desc.Text & "' , Case_status='" & CmboCase_status.Text & "', case_type= '" & Txtcase_type.Text & "',opp_name ='" & Txtopp_name.Text & "',opp_Address ='" & Txtopp_Address.Text & "',opp_id=" & Txtopp_id.Text & ",opp_Lawyer='" & Txtopp_Lawyer.Text & "', L_opp_phone= '" & TxtL_opp_phone.Text & "', Notes= '" & TxetNotes.Text & "' where num_in_office =" & Txtnum_in_office.Text & ""
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

        sql = "select * from casee"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")
        Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
        Txtnum_in_court.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
        Txtcourt_name.Text = ds.Tables("e").Rows(cr).Item("court_name")
        Txtjudge.Text = ds.Tables("e").Rows(cr).Item("judge")
        Txtagent.Text = ds.Tables("e").Rows(cr).Item("agent")
        TxtCase_cost.Text = ds.Tables("e").Rows(cr).Item("Case_cost")
        DTPCase_date.Value = ds.Tables("e").Rows(cr).Item("Case_date")

        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        Txtclient_desc.Text = ds.Tables("e").Rows(cr).Item("client_desc")
        CmboCase_status.Text = ds.Tables("e").Rows(cr).Item("Case_status")
        Txtcase_type.Text = ds.Tables("e").Rows(cr).Item("case_type")
        Txtopp_name.Text = ds.Tables("e").Rows(cr).Item("opp_name")
        Txtopp_Address.Text = ds.Tables("e").Rows(cr).Item("opp_Address")
        Txtopp_id.Text = ds.Tables("e").Rows(cr).Item("opp_id")
        Txtopp_Lawyer.Text = ds.Tables("e").Rows(cr).Item("opp_Lawyer")
        TxtL_opp_phone.Text = ds.Tables("e").Rows(cr).Item("L_opp_phone")
        TxetNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        DataGridView1.DataSource = ds.Tables("e")

        Txtnum_in_court.Select()
        MsgBox("done")
        ''اذا لم تكون اداة البدي اف فارغة 
        If AxAcroPDF1.src <> Nothing Then
            ''  تخزين ملف البدي اف داخل ملف  اتتشمينت كلبنت باسم رقم القضية 
            FileCopy(OpenFileDialog1.FileName, path & "\Attachmentcasee\" & Txtnum_in_office.Text & ".pdf")

        End If
        ''اذا لم تكون اداة البدي اف فارغة 


    End Sub

    Private Sub BtnDelet_Click(sender As Object, e As EventArgs) Handles BtnDelet.Click
        If MessageBox.Show("هل انت متاكد انك تريد حذف هذا العميل؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\Lawyer1.mdb"

            sql = "delete from casee where num_in_court= " & Txtnum_in_court.Text & ""
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
            Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
            Txtnum_in_court.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
            Txtcourt_name.Text = ds.Tables("e").Rows(cr).Item("court_name")
            Txtjudge.Text = ds.Tables("e").Rows(cr).Item("judge")
            Txtagent.Text = ds.Tables("e").Rows(cr).Item("agent")
            TxtCase_cost.Text = ds.Tables("e").Rows(cr).Item("Case_cost")
            DTPCase_date.Value = ds.Tables("e").Rows(cr).Item("Case_date")

            Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
            Txtclient_desc.Text = ds.Tables("e").Rows(cr).Item("client_desc")
            CmboCase_status.Text = ds.Tables("e").Rows(cr).Item("Case_status")
            Txtcase_type.Text = ds.Tables("e").Rows(cr).Item("case_type")
            Txtopp_name.Text = ds.Tables("e").Rows(cr).Item("opp_name")
            Txtopp_Address.Text = ds.Tables("e").Rows(cr).Item("opp_Address")
            Txtopp_id.Text = ds.Tables("e").Rows(cr).Item("opp_id")
            Txtopp_Lawyer.Text = ds.Tables("e").Rows(cr).Item("opp_Lawyer")
            TxtL_opp_phone.Text = ds.Tables("e").Rows(cr).Item("L_opp_phone")
            TxetNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            DataGridView1.DataSource = ds.Tables("e")

            Txtnum_in_court.Select()
        End If
    End Sub

    Private Sub btnopen_Click(sender As Object, e As EventArgs)
        'للمرفقات

        OpenFileDialog1.Filter = "pdf files |*.pdf" ''فلترة الاوبن فايل ديلوق ليكن من نوع بدي اف
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then ''
            AxAcroPDF1.src = OpenFileDialog1.FileName ''يعرض داخل اداة البدي اف الملف المختار من الفايل ديلوق
        End If
    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        ''الانتقال للسجل الاول
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cr = 0
        sql = "select * from casee"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()

        da.Fill(ds, "e")
        Txtnum_in_office.Text = ds.Tables("e").Rows(0).Item("num_in_office")
        Txtnum_in_court.Text = ds.Tables("e").Rows(0).Item("num_in_court")
        Txtcourt_name.Text = ds.Tables("e").Rows(0).Item("court_name")
        Txtjudge.Text = ds.Tables("e").Rows(0).Item("judge")
        Txtagent.Text = ds.Tables("e").Rows(0).Item("agent")
        TxtCase_cost.Text = ds.Tables("e").Rows(0).Item("Case_cost")
        DTPCase_date.Value = ds.Tables("e").Rows(cr).Item("Case_date")
        Txtclient_NUM.Text = ds.Tables("e").Rows(0).Item("client_NUM")
        Txtclient_desc.Text = ds.Tables("e").Rows(0).Item("client_desc")
        CmboCase_status.Text = ds.Tables("e").Rows(0).Item("Case_status")
        Txtcase_type.Text = ds.Tables("e").Rows(0).Item("case_type")
        Txtopp_name.Text = ds.Tables("e").Rows(0).Item("opp_name")
        Txtopp_Address.Text = ds.Tables("e").Rows(0).Item("opp_Address")
        Txtopp_id.Text = ds.Tables("e").Rows(0).Item("opp_id")
        Txtopp_Lawyer.Text = ds.Tables("e").Rows(0).Item("opp_Lawyer")
        TxtL_opp_phone.Text = ds.Tables("e").Rows(0).Item("L_opp_phone")
        TxetNotes.Text = ds.Tables("e").Rows(0).Item("Notes")
        AxAcroPDF1.src = path & "\Attachmentcasee\" & Txtnum_in_office.Text & ".pdf"
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        Dim tr As Integer
        tr = ds.Tables("e").Rows.Count - 1
        If cr < tr Then
            cr = cr + 1
            sql = "select * from casee"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()
            da.Fill(ds, "e")
            Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
            Txtnum_in_court.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
            Txtcourt_name.Text = ds.Tables("e").Rows(cr).Item("court_name")
            Txtjudge.Text = ds.Tables("e").Rows(cr).Item("judge")
            Txtagent.Text = ds.Tables("e").Rows(cr).Item("agent")
            TxtCase_cost.Text = ds.Tables("e").Rows(cr).Item("Case_cost")
            DTPCase_date.Value = ds.Tables("e").Rows(cr).Item("Case_date")
            Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
            Txtclient_desc.Text = ds.Tables("e").Rows(cr).Item("client_desc")
            CmboCase_status.Text = ds.Tables("e").Rows(cr).Item("Case_status")
            Txtcase_type.Text = ds.Tables("e").Rows(cr).Item("case_type")
            Txtopp_name.Text = ds.Tables("e").Rows(cr).Item("opp_name")
            Txtopp_Address.Text = ds.Tables("e").Rows(cr).Item("opp_Address")
            Txtopp_id.Text = ds.Tables("e").Rows(cr).Item("opp_id")
            Txtopp_Lawyer.Text = ds.Tables("e").Rows(cr).Item("opp_Lawyer")
            TxtL_opp_phone.Text = ds.Tables("e").Rows(cr).Item("L_opp_phone")
            TxetNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            AxAcroPDF1.src = path & "\Attachmentcasee\" & Txtnum_in_office.Text & ".pdf"

        End If
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        If cr >= 1 Then
            cr = cr - 1
            sql = "select * from casee"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables.Clear()
            da.Fill(ds, "e")
            Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
            Txtnum_in_court.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
            Txtcourt_name.Text = ds.Tables("e").Rows(cr).Item("court_name")
            Txtjudge.Text = ds.Tables("e").Rows(cr).Item("judge")
            Txtagent.Text = ds.Tables("e").Rows(cr).Item("agent")
            TxtCase_cost.Text = ds.Tables("e").Rows(cr).Item("Case_cost")
            DTPCase_date.Value = ds.Tables("e").Rows(cr).Item("Case_date")
            Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
            Txtclient_desc.Text = ds.Tables("e").Rows(cr).Item("client_desc")
            CmboCase_status.Text = ds.Tables("e").Rows(cr).Item("Case_status")
            Txtcase_type.Text = ds.Tables("e").Rows(cr).Item("case_type")
            Txtopp_name.Text = ds.Tables("e").Rows(cr).Item("opp_name")
            Txtopp_Address.Text = ds.Tables("e").Rows(cr).Item("opp_Address")
            Txtopp_id.Text = ds.Tables("e").Rows(cr).Item("opp_id")
            Txtopp_Lawyer.Text = ds.Tables("e").Rows(cr).Item("opp_Lawyer")
            TxtL_opp_phone.Text = ds.Tables("e").Rows(cr).Item("L_opp_phone")
            TxetNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
            AxAcroPDF1.src = path & "\Attachmentcasee\" & Txtnum_in_office.Text & ".pdf"

        End If
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cr = ds.Tables("e").Rows.Count - 1
        sql = "select * from casee"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables.Clear()
        da.Fill(ds, "e")
        Txtnum_in_office.Text = ds.Tables("e").Rows(cr).Item("num_in_office")
        Txtnum_in_court.Text = ds.Tables("e").Rows(cr).Item("num_in_court")
        Txtcourt_name.Text = ds.Tables("e").Rows(cr).Item("court_name")
        Txtjudge.Text = ds.Tables("e").Rows(cr).Item("judge")
        Txtagent.Text = ds.Tables("e").Rows(cr).Item("agent")
        TxtCase_cost.Text = ds.Tables("e").Rows(cr).Item("Case_cost")
        DTPCase_date.Value = ds.Tables("e").Rows(cr).Item("Case_date")
        Txtclient_NUM.Text = ds.Tables("e").Rows(cr).Item("client_NUM")
        Txtclient_desc.Text = ds.Tables("e").Rows(cr).Item("client_desc")
        CmboCase_status.Text = ds.Tables("e").Rows(cr).Item("Case_status")
        Txtcase_type.Text = ds.Tables("e").Rows(cr).Item("case_type")
        Txtopp_name.Text = ds.Tables("e").Rows(cr).Item("opp_name")
        Txtopp_Address.Text = ds.Tables("e").Rows(cr).Item("opp_Address")
        Txtopp_id.Text = ds.Tables("e").Rows(cr).Item("opp_id")
        Txtopp_Lawyer.Text = ds.Tables("e").Rows(cr).Item("opp_Lawyer")
        TxtL_opp_phone.Text = ds.Tables("e").Rows(cr).Item("L_opp_phone")
        TxetNotes.Text = ds.Tables("e").Rows(cr).Item("Notes")
        AxAcroPDF1.src = path & "\Attachmentcasee\" & Txtnum_in_office.Text & ".pdf"

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' للبحث
        If ComboBox1.Text = "رقم القضية ( بالمحكمة)" Then ''اذا كان داخل الكمبو بوكس يساوي الرقم
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT casee.num_in_office, casee.num_in_court, casee.court_name, casee.judge, casee.agent, casee.Case_cost, casee.Case_date, casee.client_NUM, client.client_NAME, casee.client_desc, casee.Case_status, casee.case_type, 
  casee.opp_name, casee.opp_Address, casee.opp_id, casee.opp_lawyer, casee.l_opp_phone, casee.Notes
FROM(casee INNER JOIN client ON casee.client_NUM = client.client_num)WHERE  casee.num_in_court like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "اسم المحكمة" Then ''اذا كان داخل الكمبو بوكس يساوي الاسم
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT casee.num_in_office, casee.num_in_court, casee.court_name, casee.judge, casee.agent, casee.Case_cost, casee.Case_date, casee.client_NUM, client.client_NAME, casee.client_desc, casee.Case_status, casee.case_type, 
  casee.opp_name, casee.opp_Address, casee.opp_id, casee.opp_lawyer, casee.l_opp_phone, casee.Notes
FROM(casee INNER JOIN client ON casee.client_NUM = client.client_num)WHERE casee.court_name like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "اسم القاضي" Then ''اذا كان داخل الكمبو بوكس يساوي الاسم
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT casee.num_in_office, casee.num_in_court, casee.court_name, casee.judge, casee.agent, casee.Case_cost, casee.Case_date, casee.client_NUM, client.client_NAME, casee.client_desc, casee.Case_status, casee.case_type, 
  casee.opp_name, casee.opp_Address, casee.opp_id, casee.opp_lawyer, casee.l_opp_phone, casee.Notes
FROM(casee INNER JOIN client ON casee.client_NUM = client.client_num)WHERE casee.judge like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "التاريخ" Then ''اذا كان داخل الكمبو بوكس يساوي الاسم
            Dim DT As New DataTable ''تعريف متغير من نوع داتا تيبل
            Dim DA As New OleDb.OleDbDataAdapter ''تعريف متغير من نوع داتا ادابتر
            DA = New OleDb.OleDbDataAdapter("SELECT casee.num_in_office, casee.num_in_court, casee.court_name, casee.judge, casee.agent, casee.Case_cost, casee.Case_date, casee.client_NUM, client.client_NAME, casee.client_desc, casee.Case_status, casee.case_type, 
  casee.opp_name, casee.opp_Address, casee.opp_id, casee.opp_lawyer, casee.l_opp_phone, casee.Notes
FROM(casee INNER JOIN client ON casee.client_NUM = client.client_num)WHERE  casee.Case_date like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT) '' تعبأة الداتا ادابتر حسب الداتا الموجودة في داتا تيبل
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "اسم العميل" Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter

            DA = New OleDb.OleDbDataAdapter("SELECT casee.num_in_office, casee.num_in_court, casee.court_name, casee.judge, casee.agent, casee.Case_cost, casee.Case_date, casee.client_NUM, client.client_NAME, casee.client_desc, casee.Case_status, casee.case_type, 
  casee.opp_name, casee.opp_Address, casee.opp_id, casee.opp_lawyer, casee.l_opp_phone, casee.Notes
FROM(casee INNER JOIN client ON casee.client_NUM = client.client_num)WHERE client.client_NAME Like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.Text = "رقم العميل " Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter

            DA = New OleDb.OleDbDataAdapter("SELECT casee.num_in_office, casee.num_in_court, casee.court_name, casee.judge, casee.agent, casee.Case_cost, casee.Case_date, casee.client_NUM, client.client_NAME, casee.client_desc, casee.Case_status, casee.case_type, 
  casee.opp_name, casee.opp_Address, casee.opp_id, casee.opp_lawyer, casee.l_opp_phone, casee.Notes
FROM(casee INNER JOIN client ON casee.client_NUM = client.client_num ) WHERE casee.client_NUM like '%" & txtSearch.Text & "%'", cnn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "pdf files |*.pdf" ''فلترة الاوبن فايل ديلوق ليكن من نوع بدي اف
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then ''
            AxAcroPDF1.src = OpenFileDialog1.FileName ''يعرض داخل اداة البدي اف الملف المختار من الفايل ديلوق
        End If
    End Sub
End Class
