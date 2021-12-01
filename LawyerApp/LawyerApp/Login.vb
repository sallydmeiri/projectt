Imports System.Data.OleDb
Public Class Login
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Lawyer1.mdb")
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter

    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        Close()
    End Sub

    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        If txtusername.Text = Nothing Then
            MsgBox("يجب عليك ادخال اسم المستخدم", MsgBoxStyle.Information, "تنبيه")
            txtusername.Focus()
            Exit Sub
        End If
        If txtpass.Text = Nothing Then
            MsgBox("يجب عليك ادخال كلمة المرور ", MsgBoxStyle.Information, "تنبيه")
            txtpass.Focus()
            Exit Sub
        End If
        dt.Clear()
        da = New OleDbDataAdapter("select * from login where username = '" & txtusername.Text & "' and pass = '" & txtpass.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then 'اذا ادخل صح
            MainScreen.Show()
            Me.Close()
        Else
            MsgBox("اسم المستخدم او كلمة المرور غير صحيحة ", MsgBoxStyle.Information, "تنبيه")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
