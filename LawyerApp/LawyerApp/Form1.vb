Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrystalReportViewer1.SelectionFormula = "{client.client_ID} = " & TextBox1.Text & ""
        CrystalReportViewer1.ReportSource = New CrystalReport1()
    End Sub
End Class