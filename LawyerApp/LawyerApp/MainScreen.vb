Public Class MainScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeToolStripMenuItem.Text = Date.Now.ToLocalTime
    End Sub

    Private Sub العميلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles العميلToolStripMenuItem.Click
        client.ShowDialog()
    End Sub

    Private Sub القضيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles القضيةToolStripMenuItem.Click
        casee.ShowDialog()
    End Sub

    Private Sub الاستشارةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الاستشارةToolStripMenuItem.Click
        advice.ShowDialog()
    End Sub

    Private Sub الجلسةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الجلسةToolStripMenuItem.Click
        cont_session.ShowDialog()
    End Sub

    Private Sub نقلالقضيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles نقلالقضيةToolStripMenuItem.Click
        Transfer_of_case.ShowDialog()
    End Sub

    Private Sub وثائقعدليةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles وثائقعدليةToolStripMenuItem.Click
        Justic__documents.ShowDialog()
    End Sub

    Private Sub جلساتالقضاياToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles جلساتالقضاياToolStripMenuItem.Click
        cace_session.ShowDialog()
    End Sub

    Private Sub قسطاطToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles قسطاطToolStripMenuItem.Click
        Process.Start("https://qistas.com/")

    End Sub

    Private Sub المكتفيToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المكتفيToolStripMenuItem.Click
        Process.Start("http://muqtafi.birzeit.edu/")

    End Sub

    Private Sub عدالةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عدالةToolStripMenuItem.Click
        Process.Start("http://www.adaleh.info/sys/default.aspx/")

    End Sub

    Private Sub المنظومةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المنظومةToolStripMenuItem.Click
        Process.Start("http://mandumah.com/")

    End Sub

    Private Sub وزارةالعدلالعلياToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles وزارةالعدلالعلياToolStripMenuItem.Click
        Process.Start("https://www.courts.gov.ps/")

    End Sub

    Private Sub تسجيلالخروجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تسجيلالخروجToolStripMenuItem.Click
        End
    End Sub

    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click

    End Sub

    Private Sub فتحقاعدةالبياناتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles فتحقاعدةالبياناتToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath & "\" & "Lawyer1.mdb")
    End Sub

    Private Sub نسخةاحتياطيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles نسخةاحتياطيةToolStripMenuItem.Click
        Try
            Dim FBD As New FolderBrowserDialog
            If FBD.ShowDialog() = vbOK Then
                FileCopy("Lawyer1.mdb", FBD.SelectedPath & "\Lawyer1.mdb")
                MsgBox("تم عمل النسخة الاحتياطية")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub استرجاعالنسخةالاحتياطيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles استرجاعالنسخةالاحتياطيةToolStripMenuItem.Click
        Try
            Dim FBD As New FolderBrowserDialog
            If FBD.ShowDialog() = vbOK Then
                FileClose("Lawyer1.mdb")
                FileCopy(FBD.SelectedPath & "\Lawyer1.mdb", "Lawyer1.mdb")
                MsgBox("تم استرجاع النسخة الاحتياطية")
                Application.Restart()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub البطاقاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles البطاقاتToolStripMenuItem.Click

    End Sub

    Private Sub حولالبرنامجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حولالبرنامجToolStripMenuItem.Click
        about.ShowDialog()
    End Sub



    Private Sub قضاياالعميلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles قضاياالعميلToolStripMenuItem.Click
        Form1.ShowDialog()

    End Sub

    Private Sub الجلساتحسبالتاريخToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الجلساتحسبالتاريخToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub جلساتالاسئنافحسبالتاريخToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles جلساتالاسئنافحسبالتاريخToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub جلساتالقضاياToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles جلساتالقضاياToolStripMenuItem1.Click
        Form4.ShowDialog()
    End Sub

    Private Sub مواعيدجلساتالاستئنافToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مواعيدجلساتالاستئنافToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub
End Class