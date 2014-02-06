Imports System.Net.Mail
Public Class Report
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.Size = New Size(231, 317)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.Size = New Size(231, 345)
    End Sub

    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.Text = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Size = New Size(231, 370)
        Dim smtpServer As New SmtpClient
        ProgressBar1.Value = 10
        Label1.Text = "Preparing Server..."
        Dim mail As New MailMessage()
        ProgressBar1.Value = 20
        Label1.Text = "Preparing Message..."
        smtpServer.Credentials = New Net.NetworkCredential("radxpictures@gmail.com", "tyler1104")
        ProgressBar1.Value = 30
        Label1.Text = "Setting Credentials..."
        smtpServer.Port = 587
        smtpServer.Host = "smtp.gmail.com"
        smtpServer.EnableSsl = True
        mail = New MailMessage()
        mail.From = New MailAddress("radxpictures@gmail.com")
        ProgressBar1.Value = 50
        Label1.Text = "Locating Recipient..."
        mail.To.Add("radxpictures@gmail.com")
        ProgressBar1.Value = 60
        Label1.Text = "Locating Additional Recipients..."
        mail.Subject = ComboBox1.SelectedItem.ToString
        ProgressBar1.Value = 70
        Label1.Text = "Writing Subject Line..."
        mail.Body = TextBox1.Text
        ProgressBar1.Value = 80
        Label1.Text = "Inserting Error Details..."
        smtpServer.Send(mail)
        ProgressBar1.Value = 100
        Label1.Text = "Sending Report..."
        MsgBox("Error Reported!")
    End Sub

End Class