Imports System.Net.Mail
Imports System.IO
Public Class email
    Dim file(2) As String
    Dim medirectory As String = Application.StartupPath + "\Users\"
    Private Sub gmailicon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gmailicon.Click
        gmailicon.BackColor = Color.Gold
        aimicon.BackColor = Color.Transparent
        yahooicon.BackColor = Color.Transparent
        msnicon.BackColor = Color.Transparent
        smtptxt.Text = "smtp.gmail.com"
    End Sub

    Private Sub email_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If usertxt.Text.Contains("@msn.com") Then
            msnicon.BackColor = Color.Gold
        End If
        If usertxt.Text.Contains("@hotmail.com") Then
            msnicon.BackColor = Color.Gold
        End If
        If usertxt.Text.Contains("@gmail.com") Then
            gmailicon.BackColor = Color.Gold
        End If
        If usertxt.Text.Contains("@yahoo.com") Then
            yahooicon.BackColor = Color.Gold
        End If
        If usertxt.Text.Contains("@rocketmail.com") Then
            yahooicon.BackColor = Color.Gold
        End If
        If usertxt.Text.Contains("@aim.com") Then
            aimicon.BackColor = Color.Gold
        End If
        If usertxt.Text.Contains("@aol.com") Then
            aimicon.BackColor = Color.Gold
        End If
        usertxt.Text = My.Settings.username
        passtxt.Text = My.Settings.password
        Me.BackColor = beef.BackColor
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then ctrl.ForeColor = beef.Label4.ForeColor
        Next
        Dim contacts As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Contacts"
        For Each file As String In My.Computer.FileSystem.GetFiles(contacts, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            Dim noext As String = IO.Path.GetFileNameWithoutExtension(file)
            ComboBox1.Items.Add(noext)
        Next
        beef.ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub forgetcheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forgetcheck.CheckedChanged
        My.Settings.password = ""
        My.Settings.username = ""
        My.Settings.Save()
        My.Settings.Reload()
        usertxt.Text = ""
        passtxt.Text = ""
    End Sub

    Private Sub msnicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msnicon.Click
        msnicon.BackColor = Color.Gold
        aimicon.BackColor = Color.Transparent
        yahooicon.BackColor = Color.Transparent
        gmailicon.BackColor = Color.Transparent
        smtptxt.Text = "smtp.live.com"
    End Sub

    Private Sub yahooicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yahooicon.Click
        yahooicon.BackColor = Color.Gold
        aimicon.BackColor = Color.Transparent
        msnicon.BackColor = Color.Transparent
        gmailicon.BackColor = Color.Transparent
        smtptxt.Text = "smtp.mail.yahoo.com"
    End Sub

    Private Sub aimicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aimicon.Click
        aimicon.BackColor = Color.Gold
        msnicon.BackColor = Color.Transparent
        yahooicon.BackColor = Color.Transparent
        gmailicon.BackColor = Color.Transparent
        smtptxt.Text = "smtp.aol.com"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        file = Nothing
        If Attaches.ShowDialog = DialogResult.OK Then
            file = Attaches.FileNames
            Try
                ViewAttach.TextBox1.Text = file(0)
            Catch ex As IndexOutOfRangeException
            End Try
            ViewAttach.TextBox1.Text = file(0)
            Try
                ViewAttach.TextBox2.Text = file(1)
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                ViewAttach.TextBox3.Text = file(2)
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                ViewAttach.TextBox4.Text = file(3)
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                ViewAttach.TextBox5.Text = file(4)
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                ViewAttach.TextBox6.Text = file(5)
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                ViewAttach.TextBox7.Text = file(6)
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                ViewAttach.TextBox8.Text = file(7)
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                ViewAttach.TextBox9.Text = file(8)
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                ViewAttach.TextBox10.Text = file(9)
            Catch ex As IndexOutOfRangeException
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        viewattach.show()
    End Sub

    Private Sub sendbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendbttn.Click
        ProgressBar1.Value = 5
        Dim message As System.Net.Mail.MailMessage
        ProgressBar1.Value = 10
        Dim smtp As New System.Net.Mail.SmtpClient(smtptxt.Text, 587)
        ProgressBar1.Value = 24
        message = New System.Net.Mail.MailMessage(usertxt.Text, totxt.Text, subtxt.Text, bodytxt.Text)
        ProgressBar1.Value = 43
        smtp.EnableSsl = True
        ProgressBar1.Value = 59
        smtp.Credentials = New System.Net.NetworkCredential(usertxt.Text, passtxt.Text)
        ProgressBar1.Value = 70

        If Not ViewAttach.TextBox1.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox1.Text)
            message.Attachments.Add(attach)
        End If

        If Not ViewAttach.TextBox2.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox2.Text)
            message.Attachments.Add(attach)
        End If

        If Not ViewAttach.TextBox3.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox3.Text)
            message.Attachments.Add(attach)
        End If

        If Not ViewAttach.TextBox4.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox4.Text)
            message.Attachments.Add(attach)
        End If


        If Not ViewAttach.TextBox5.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox5.Text)
            message.Attachments.Add(attach)
        End If

        If Not ViewAttach.TextBox6.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox6.Text)
            message.Attachments.Add(attach)
        End If


        If Not ViewAttach.TextBox7.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox7.Text)
            message.Attachments.Add(attach)
        End If


        If Not ViewAttach.TextBox8.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox8.Text)
            message.Attachments.Add(attach)
        End If


        If Not ViewAttach.TextBox9.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox9.Text)
            message.Attachments.Add(attach)
        End If

        If Not ViewAttach.TextBox10.Text = Nothing Then
            Dim attach As New Attachment(ViewAttach.TextBox10.Text)
            message.Attachments.Add(attach)
        End If

        ProgressBar1.Value = 80
        Try
            Try
                smtp.Send(message)
                ProgressBar1.Value = 100
                MessageBox.Show("Message Successfully Sent!", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProgressBar1.Value = 0
            Catch
                MessageBox.Show("An Error Occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Check Your Internet Connection And/Or Your Username and Password And Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch exc As Net.Mail.SmtpException
            MessageBox.Show("An Error Occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Check Your Internet Connection And/Or Your Username and Password And Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If rememusernamecheck.Checked = True Then
            My.Settings.username = usertxt.Text
            My.Settings.Save()
            My.Settings.Reload()
        End If
        If remempasswordcheck.Checked = True Then
            My.Settings.password = passtxt.Text
            My.Settings.Save()
            My.Settings.Reload()
        End If
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFileName As String = ""
        Dim myStream As StreamWriter = New StreamWriter(strFileName, False)
        myStream.Write(bodytxt.Text)
        myStream.Close()
        myStream = Nothing
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            bodytxt.Text = fileReader
        End If

    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            bodytxt.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub TextColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            bodytxt.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub CustomizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizeToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            bodytxt.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        bodytxt.SelectAll()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        bodytxt.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        bodytxt.Redo()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        bodytxt.Clear()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(bodytxt.SelectedText)
    End Sub

    Private Sub email_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        beef.mail.BackgroundImage = Nothing
        beef.mail.BackColor = Color.Transparent
    End Sub

    Private Sub SaveToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim FILE_NAME As String = SaveFileDialog1.FileName
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(bodytxt.Text)
            objWriter.Close()
        End If
    End Sub

    Private Sub totxt_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totxt.DoubleClick
        ComboBox1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim reader As String = IO.File.ReadAllLines(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "\Contacts\" + ComboBox1.Text + ".txt")(1)
        totxt.Text = reader
    End Sub

    Private Sub ComboBox1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBox1.MouseDoubleClick
        ComboBox1.Hide()
    End Sub

    Private Sub remempasswordcheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remempasswordcheck.CheckedChanged

    End Sub
End Class