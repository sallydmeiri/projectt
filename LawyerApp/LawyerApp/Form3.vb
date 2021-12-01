Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrystalReportViewer1.SelectionFormula = "{casee.num_in_court} like '*" & TextBox1.Text & "*'"
        CrystalReportViewer1.ReportSource = New CrystalReport3()
    End Sub
End Class