Imports System.Net.Mail
Imports System.IO
Public Class CellText
    Dim medirectory As String = Application.StartupPath + "\Users\"
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim newbrowser As browser
        newbrowser = New browser
        newbrowser.mainbrowser.Navigate("http://www.fonefinder.net/findome.php?npa=" & TextBox1.Text & "&nxx=" & TextBox2.Text)
        newbrowser.Show()
    End Sub

    Private Sub SetCarrierEmail()
        Try
            If Not TextBox1.Text = Nothing And Not TextBox2.Text = Nothing And Not TextBox3.Text = Nothing Then
                Dim number As String = TextBox1.Text & TextBox2.Text & TextBox3.Text
                If ComboBox1.Text = "3 River Wireless" Then
                    Label8.Text = number & "@sms.3rivers.net"
                End If
                If ComboBox1.Text = "ACS Wireless" Then
                    Label8.Text = number & "@paging.acswireless.com"
                End If
                If ComboBox1.Text = "Alltel" Then
                    Label8.Text = number & "@txt.att.net"
                End If
                If ComboBox1.Text = "AT&T" Then
                    Label8.Text = number & "@txt.att.net"
                End If
                If ComboBox1.Text = "Bell Canada" Then
                    Label8.Text = number & "@txt.bellmobility.ca"
                End If
                If ComboBox1.Text = "Bell Mobility (Canada)" Then
                    Label8.Text = number & "@txt.bell.ca"
                End If
                If ComboBox1.Text = "Blue Sky Frog" Then
                    Label8.Text = number & "@blueskyfrog.com"
                End If
                If ComboBox1.Text = "Boost Mobile" Then
                    Label8.Text = number & "@myboostmobile.com"
                End If
                If ComboBox1.Text = "Carolina West Wireless" Then
                    Label8.Text = number & "@cwwsms.com"
                End If
                If ComboBox1.Text = "Cellular South" Then
                    Label8.Text = number & "@csouth1.com"
                End If
                If ComboBox1.Text = "Centennial Wireless" Then
                    Label8.Text = number & "@cwemail.com"
                End If
                If ComboBox1.Text = "CenturyTel" Then
                    Label8.Text = number & "@messaging.centurytel.net"
                End If
                If ComboBox1.Text = "Cingular (Now AT&T)" Then
                    Label8.Text = number & "@txt.att.net"
                End If
                If ComboBox1.Text = "Clearnet" Then
                    Label8.Text = number & "@msg.clearnet.com"
                End If
                If ComboBox1.Text = "Comcast" Then
                    Label8.Text = number & "@comcastpcs.textmsg.com"
                End If
                If ComboBox1.Text = "Corr Wireless Communications" Then
                    Label8.Text = number & "@corrwireless.net"
                End If
                If ComboBox1.Text = "Dobson" Then
                    Label8.Text = number & "@mobile.dobson.net"
                End If
                If ComboBox1.Text = "Edge Wireless" Then
                    Label8.Text = number & "@sms.edgewireless.com"
                End If
                If ComboBox1.Text = "Fido" Then
                    Label8.Text = number & "@fido.ca"
                End If
                If ComboBox1.Text = "Golden Telecom" Then
                    Label8.Text = number & "@sms.goldentele.com"
                End If
                If ComboBox1.Text = "Helio" Then
                    Label8.Text = number & "@messaging.sprintpcs.com"
                End If
                If ComboBox1.Text = "Houston Cellular" Then
                    Label8.Text = number & "@text.houstoncellular.net"
                End If
                If ComboBox1.Text = "Idea Cellular" Then
                    Label8.Text = number & "@ideacellular.net"
                End If
                If ComboBox1.Text = "Illinois Valley Cellular" Then
                    Label8.Text = number & "@ivctext.com"
                End If
                If ComboBox1.Text = "Inland Cellular Telephone" Then
                    Label8.Text = number & "@inlandlink.com"
                End If
                If ComboBox1.Text = "MCI" Then
                    Label8.Text = number & "@pagemci.com"
                End If
                If ComboBox1.Text = "Metrocall" Then
                    Label8.Text = number & "@page.metrocall.com"
                End If
                If ComboBox1.Text = "Metrocall 2-way" Then
                    Label8.Text = number & "@my2way.com"
                End If
                If ComboBox1.Text = "Metro PCS" Then
                    Label8.Text = number & "@mymetropcs.com"
                End If
                If ComboBox1.Text = "Microcell" Then
                    Label8.Text = number & "@fido.ca"
                End If
                If ComboBox1.Text = "Midwest Wireless" Then
                    Label8.Text = number & "@clearlydigital.com"
                End If
                If ComboBox1.Text = "Mobilcomm" Then
                    Label8.Text = number & "@mobilecomm.net"
                End If
                If ComboBox1.Text = "MTS" Then
                    Label8.Text = number & "@text.mtsmobility.com"
                End If
                If ComboBox1.Text = "Nextel" Then
                    Label8.Text = number & "@messaging.nextel.com"
                End If
                If ComboBox1.Text = "OnlineBeep" Then
                    Label8.Text = number & "@onlinebeep.net"
                End If
                If ComboBox1.Text = "PCS One" Then
                    Label8.Text = number & "@pcsone.net"
                End If
                If ComboBox1.Text = "President's Choice" Then
                    Label8.Text = number & "@txt.bell.ca"
                End If
                If ComboBox1.Text = "Public Service Cellular" Then
                    Label8.Text = number & "@sms.pscel.com"
                End If
                If ComboBox1.Text = "Qwest" Then
                    Label8.Text = number & "@qwestmp.com"
                End If
                If ComboBox1.Text = "Rogers AT&T Wireless" Then
                    Label8.Text = number & "@pcs.rogers.com"
                End If
                If ComboBox1.Text = "Rogers Canada" Then
                    Label8.Text = number & "@pcs.rogers.com"
                End If
                If ComboBox1.Text = "Satellink" Then
                    Label8.Text = number & ".pageme@satellink.net"
                End If
                If ComboBox1.Text = "Southwestern Bell" Then
                    Label8.Text = number & "@email.swbw.com"
                End If
                If ComboBox1.Text = "Sprint" Then
                    Label8.Text = number & "@messaging.sprintpcs.com"
                End If
                If ComboBox1.Text = "Sumcom" Then
                    Label8.Text = number & "@tms.suncom.com"
                End If
                If ComboBox1.Text = "Surewest Communications" Then
                    Label8.Text = number & "@mobile.surewest.com"
                End If
                If ComboBox1.Text = "T-Mobile" Then
                    Label8.Text = number & "@tmomail.net"
                End If
                If ComboBox1.Text = "Telus" Then
                    Label8.Text = number & "@msg.telus.com"
                End If
                If ComboBox1.Text = "Tracfone" Then
                    Label8.Text = number & "@txt.att.net"
                End If
                If ComboBox1.Text = "Triton" Then
                    Label8.Text = number & "@tms.suncom.com"
                End If
                If ComboBox1.Text = "Unicel" Then
                    Label8.Text = number & "@utext.com"
                End If
                If ComboBox1.Text = "US Cellular" Then
                    Label8.Text = number & "@email.uscc.net"
                End If
                If ComboBox1.Text = "US West" Then
                    Label8.Text = number & "@uswestdatamail.com"
                End If
                If ComboBox1.Text = "Verizon" Then
                    Label8.Text = number & "@vtext.com"
                End If
                If ComboBox1.Text = "Virgin Mobile" Then
                    Label8.Text = number & "@vmobl.com"
                End If
                If ComboBox1.Text = "Virgin Mobile Canada" Then
                    Label8.Text = number & "@vmobile.ca"
                End If
                If ComboBox1.Text = "West Central Wireless" Then
                    Label8.Text = number & "@sms.wcc.net"
                End If
                If ComboBox1.Text = "Western Wireless" Then
                    Label8.Text = number & "@cellularonewest.com"
                End If
            Else
                Dim number As String = IO.File.ReadLines(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "userinfo\contacts\" + ComboBox2.Text + ".txt")(5)
                If ComboBox1.Text = "3 River Wireless" Then
                    Label8.Text = number & "@sms.3rivers.net"
                End If
                If ComboBox1.Text = "ACS Wireless" Then
                    Label8.Text = number & "@paging.acswireless.com"
                End If
                If ComboBox1.Text = "Alltel" Then
                    Label8.Text = number & "@txt.att.net"
                End If
                If ComboBox1.Text = "AT&T" Then
                    Label8.Text = number & "@txt.att.net"
                End If
                If ComboBox1.Text = "Bell Canada" Then
                    Label8.Text = number & "@txt.bellmobility.ca"
                End If
                If ComboBox1.Text = "Bell Mobility (Canada)" Then
                    Label8.Text = number & "@txt.bell.ca"
                End If
                If ComboBox1.Text = "Blue Sky Frog" Then
                    Label8.Text = number & "@blueskyfrog.com"
                End If
                If ComboBox1.Text = "Boost Mobile" Then
                    Label8.Text = number & "@myboostmobile.com"
                End If
                If ComboBox1.Text = "Carolina West Wireless" Then
                    Label8.Text = number & "@cwwsms.com"
                End If
                If ComboBox1.Text = "Cellular South" Then
                    Label8.Text = number & "@csouth1.com"
                End If
                If ComboBox1.Text = "Centennial Wireless" Then
                    Label8.Text = number & "@cwemail.com"
                End If
                If ComboBox1.Text = "CenturyTel" Then
                    Label8.Text = number & "@messaging.centurytel.net"
                End If
                If ComboBox1.Text = "Cingular (Now AT&T)" Then
                    Label8.Text = number & "@txt.att.net"
                End If
                If ComboBox1.Text = "Clearnet" Then
                    Label8.Text = number & "@msg.clearnet.com"
                End If
                If ComboBox1.Text = "Comcast" Then
                    Label8.Text = number & "@comcastpcs.textmsg.com"
                End If
                If ComboBox1.Text = "Corr Wireless Communications" Then
                    Label8.Text = number & "@corrwireless.net"
                End If
                If ComboBox1.Text = "Dobson" Then
                    Label8.Text = number & "@mobile.dobson.net"
                End If
                If ComboBox1.Text = "Edge Wireless" Then
                    Label8.Text = number & "@sms.edgewireless.com"
                End If
                If ComboBox1.Text = "Fido" Then
                    Label8.Text = number & "@fido.ca"
                End If
                If ComboBox1.Text = "Golden Telecom" Then
                    Label8.Text = number & "@sms.goldentele.com"
                End If
                If ComboBox1.Text = "Helio" Then
                    Label8.Text = number & "@messaging.sprintpcs.com"
                End If
                If ComboBox1.Text = "Houston Cellular" Then
                    Label8.Text = number & "@text.houstoncellular.net"
                End If
                If ComboBox1.Text = "Idea Cellular" Then
                    Label8.Text = number & "@ideacellular.net"
                End If
                If ComboBox1.Text = "Illinois Valley Cellular" Then
                    Label8.Text = number & "@ivctext.com"
                End If
                If ComboBox1.Text = "Inland Cellular Telephone" Then
                    Label8.Text = number & "@inlandlink.com"
                End If
                If ComboBox1.Text = "MCI" Then
                    Label8.Text = number & "@pagemci.com"
                End If
                If ComboBox1.Text = "Metrocall" Then
                    Label8.Text = number & "@page.metrocall.com"
                End If
                If ComboBox1.Text = "Metrocall 2-way" Then
                    Label8.Text = number & "@my2way.com"
                End If
                If ComboBox1.Text = "Metro PCS" Then
                    Label8.Text = number & "@mymetropcs.com"
                End If
                If ComboBox1.Text = "Microcell" Then
                    Label8.Text = number & "@fido.ca"
                End If
                If ComboBox1.Text = "Midwest Wireless" Then
                    Label8.Text = number & "@clearlydigital.com"
                End If
                If ComboBox1.Text = "Mobilcomm" Then
                    Label8.Text = number & "@mobilecomm.net"
                End If
                If ComboBox1.Text = "MTS" Then
                    Label8.Text = number & "@text.mtsmobility.com"
                End If
                If ComboBox1.Text = "Nextel" Then
                    Label8.Text = number & "@messaging.nextel.com"
                End If
                If ComboBox1.Text = "OnlineBeep" Then
                    Label8.Text = number & "@onlinebeep.net"
                End If
                If ComboBox1.Text = "PCS One" Then
                    Label8.Text = number & "@pcsone.net"
                End If
                If ComboBox1.Text = "President's Choice" Then
                    Label8.Text = number & "@txt.bell.ca"
                End If
                If ComboBox1.Text = "Public Service Cellular" Then
                    Label8.Text = number & "@sms.pscel.com"
                End If
                If ComboBox1.Text = "Qwest" Then
                    Label8.Text = number & "@qwestmp.com"
                End If
                If ComboBox1.Text = "Rogers AT&T Wireless" Then
                    Label8.Text = number & "@pcs.rogers.com"
                End If
                If ComboBox1.Text = "Rogers Canada" Then
                    Label8.Text = number & "@pcs.rogers.com"
                End If
                If ComboBox1.Text = "Satellink" Then
                    Label8.Text = number & ".pageme@satellink.net"
                End If
                If ComboBox1.Text = "Southwestern Bell" Then
                    Label8.Text = number & "@email.swbw.com"
                End If
                If ComboBox1.Text = "Sprint" Then
                    Label8.Text = number & "@messaging.sprintpcs.com"
                End If
                If ComboBox1.Text = "Sumcom" Then
                    Label8.Text = number & "@tms.suncom.com"
                End If
                If ComboBox1.Text = "Surewest Communications" Then
                    Label8.Text = number & "@mobile.surewest.com"
                End If
                If ComboBox1.Text = "T-Mobile" Then
                    Label8.Text = number & "@tmomail.net"
                End If
                If ComboBox1.Text = "Telus" Then
                    Label8.Text = number & "@msg.telus.com"
                End If
                If ComboBox1.Text = "Tracfone" Then
                    Label8.Text = number & "@txt.att.net"
                End If
                If ComboBox1.Text = "Triton" Then
                    Label8.Text = number & "@tms.suncom.com"
                End If
                If ComboBox1.Text = "Unicel" Then
                    Label8.Text = number & "@utext.com"
                End If
                If ComboBox1.Text = "US Cellular" Then
                    Label8.Text = number & "@email.uscc.net"
                End If
                If ComboBox1.Text = "US West" Then
                    Label8.Text = number & "@uswestdatamail.com"
                End If
                If ComboBox1.Text = "Verizon" Then
                    Label8.Text = number & "@vtext.com"
                End If
                If ComboBox1.Text = "Virgin Mobile" Then
                    Label8.Text = number & "@vmobl.com"
                End If
                If ComboBox1.Text = "Virgin Mobile Canada" Then
                    Label8.Text = number & "@vmobile.ca"
                End If
                If ComboBox1.Text = "West Central Wireless" Then
                    Label8.Text = number & "@sms.wcc.net"
                End If
                If ComboBox1.Text = "Western Wireless" Then
                    Label8.Text = number & "@cellularonewest.com"
                End If
            End If
        Catch
            MsgBox("An error occured.")
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SetCarrierEmail()
        ProgressBar1.Value = 5
        Dim message As System.Net.Mail.MailMessage
        ProgressBar1.Value = 10
        Dim smtp As New System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
        ProgressBar1.Value = 24
        Dim namereader As String = IO.File.ReadLines(medirectory + "\" + Login.UsernameTextBox.Text + "\userinfo\usercredentials.ini")(3)(3)
        message = New System.Net.Mail.MailMessage(namereader & "@nickersoft.webs.com", Label8.Text, TextBox5.Text, TextBox4.Text)
        ProgressBar1.Value = 43
        smtp.EnableSsl = True
        ProgressBar1.Value = 59
        smtp.Credentials = New System.Net.NetworkCredential("radxpictures@gmail.com", "tyler1104")
        ProgressBar1.Value = 70
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
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim fonereader1 As String = IO.File.ReadLines(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "userinfo\contacts\" + ComboBox2.Text + ".txt")(5)(0)
        Dim fonereader2 As String = IO.File.ReadLines(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "userinfo\contacts\" + ComboBox2.Text + ".txt")(5)(1)
        Dim fonereader3 As String = IO.File.ReadLines(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "userinfo\contacts\" + ComboBox2.Text + ".txt")(5)(2)
        Dim fonereader4 As String = IO.File.ReadLines(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "userinfo\contacts\" + ComboBox2.Text + ".txt")(5)(3)
        Dim fonereader5 As String = IO.File.ReadLines(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "userinfo\contacts\" + ComboBox2.Text + ".txt")(5)(4)
        Dim fonereader6 As String = IO.File.ReadLines(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "userinfo\contacts\" + ComboBox2.Text + ".txt")(5)(5)
        Dim first3 As String = fonereader1 & fonereader2 & fonereader3
        Dim second3 As String = fonereader4 & fonereader5 & fonereader6
        Dim newbrowser As browser
        newbrowser = New browser
        newbrowser.mainbrowser.Navigate("http://www.fonefinder.net/findome.php?npa=" & first3 & "&nxx=" & second3)
        newbrowser.Show()
    End Sub

    Private Sub CellText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = beef.BackColor
    End Sub

    Private Sub CellText_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        beef.PictureBox3.BackgroundImage = Nothing
        beef.PictureBox3.BackColor = Color.Transparent
    End Sub
End Class