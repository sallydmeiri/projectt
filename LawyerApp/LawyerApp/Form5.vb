Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cryRep As New CrystalReport5()        CrystalReportViewer1.SelectionFormula = "cstr(datevalue({cont_session.session_date})) like '" & DateTimePicker1.Value.ToShortDateString & "'"        CrystalReportViewer1.ReportSource = cryRep

    End Sub
End Class