Imports System.Runtime.InteropServices
Imports System.Net
Public Class beef
    Private Const SB_BOTH As Integer = 3
    Private Const WM_NCCALCSIZE As Integer = &H83

    <DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(ByVal hWnd As IntPtr, ByVal wBar As Integer, ByVal bShow As Integer) As Integer
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        If mdiClient IsNot Nothing Then
            'Hide the ScrollBars
            ShowScrollBar(mdiClient.Handle, SB_BOTH, 0)
        End If

        MyBase.WndProc(m)
    End Sub
    Private mdiClient As MdiClient = Nothing
    Dim newbrowser As New browser
    Dim medirectory As String = Application.StartupPath + "\Users\"
    Private Declare Function mciExecute Lib "winmm.dll" (ByVal lpstrCommand As String) As Long


    Private Sub ColorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        colors.Show()
    End Sub

    Private Sub ReportErrorToNickersoftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportErrorToNickersoftToolStripMenuItem.Click
        Report.Show()

    End Sub

    Private Sub DesktopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Customize.Show()
    End Sub

    Private Sub mail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mail.Click
        mail.BackgroundImage = My.Resources.glassstrip
        mail.BackColor = Color.Gold
        email.Show()
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newbrowser As New browser
        newbrowser = New browser
        newbrowser.Show()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim newbrowser As New browser
            newbrowser = New browser
            newbrowser.Show()
            newbrowser.mainbrowser.Navigate(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub AboutXPEditionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutXPEditionToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub favspic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles favspic.Click
        Bookmarks.Show()
        favspic.BackgroundImage = My.Resources.glassstrip
        favspic.BackColor = Color.Gold
    End Sub


    Private Sub UserOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserOptionsToolStripMenuItem.Click
        UserControl.Show()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Login.Show()
        My.Computer.Audio.Play("logoffwav.wav", AudioPlayMode.Background)
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        CheckForUpdates()
    End Sub
    Public Sub CheckForUpdates()
        Try
            Dim file As String =
                Application.StartupPath + "\version.txt"
            Dim myver As String = My.Application.Info.Version.ToString
            If My.Computer.FileSystem.FileExists(file) Then
                My.Computer.FileSystem.DeleteFile(file)
            End If
            My.Computer.Network.DownloadFile("http://nickersoft.webs.com/version.txt", file)
            Dim lastver As String = My.Computer.FileSystem.ReadAllText(file)
            If Not myver = lastver Then
                MsgBox("Update Available!" & vbCrLf & "Your version: " & file & vbCrLf & "Current Version: " & lastver & vbCrLf & "Would you like to install now?", MsgBoxStyle.YesNo)
                If MsgBoxResult.Yes Then
                    Dim instance As WebClient = New WebClient
                    Dim address As String = "http://nickersoft.webs.com/xpeinstall.txt"
                    Dim returnValue As String
                    returnValue = instance.DownloadString(address)
                    My.Computer.Network.DownloadFile(returnValue, Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\Temp\setup.exe")
                    MsgBox("Once the installer opens, please exit XPEdition and install the new version in XPEdition's current program directory.")
                    Process.Start(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\Temp\setup.exe")
                    Me.Close()
                Else
                End If
            Else
                MsgBox("XPEdition Is Up To Date", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox("Error retrieving latest version." & vbCrLf & ex.Message & vbCrLf & "Please contact Nickersoft.")
        End Try
    End Sub

    Private Sub FAQToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FAQToolStripMenuItem.Click
        Dim newbrowser As New browser
        newbrowser = New browser
        newbrowser.Show()
        newbrowser.mainbrowser.Navigate("http://www.nickersoft.webs.com/faq.htm")
    End Sub

    Private Sub abookicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abookicon.Click
        abookicon.BackgroundImage = My.Resources.glassstrip
        abookicon.BackColor = Color.Gold
        Contacts.Show()


    End Sub

    Private Sub abookicon_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles abookicon.MouseEnter
        abookicon.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub abookicon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles abookicon.MouseLeave
        abookicon.BackgroundImage = Nothing
    End Sub

    Private Sub mail_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mail.MouseEnter
        mail.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub mail_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mail.MouseLeave
        mail.BackgroundImage = Nothing
    End Sub

    Private Sub favspic_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles favspic.MouseEnter
        favspic.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub favspic_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles favspic.MouseLeave
        favspic.BackgroundImage = Nothing
    End Sub


    Private Sub addressbar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles addressbar.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                Dim space As String = " "


                If addressbar.Text.Contains(space) Then
                    addressbar.Text = Replace(addressbar.Text, space, "")
                End If


                If aafter.Text.Contains(space) Then
                    aafter.Text = Replace(aafter.Text, space, "%20")
                End If


                Dim FILE_NAME As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Userinfo\History.txt"
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
                objWriter.Write(vbCrLf + ComboBox1.Text & addressbar.Text & ComboBox2.Text & aafter.Text)
                objWriter.Close()

                browser.BackColor = Me.BackColor

                Dim newbrowser As browser
                newbrowser = New browser
                newbrowser.Show()
                newbrowser.mainbrowser.Navigate(ComboBox1.Text & addressbar.Text & ComboBox2.Text & aafter.Text)

                Dim chl As String = Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\UserInfo\ChildHistoryList.txt"
                Dim rat As New IO.StreamWriter(chl, True)
                rat.Write(vbCrLf & ComboBox1.Text & addressbar.Text & ComboBox2.Text & aafter.Text + "    ====    " + Label1.Text)
                rat.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.BackgroundImage = My.Resources.glassstrip
        PictureBox1.BackColor = Color.Gold
        Search.Show()
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox2.BackColor = Color.Gold
        Dim newbrowser As browser
        newbrowser = New browser
        newbrowser.MdiParent = Me
        newbrowser.Show()
        Dim home As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "\Userinfo\home.txt")
        newbrowser.mainbrowser.Navigate(home)
    End Sub


    Private Sub beef_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Label2.text = Wallpaper Path (0)
        'Me.Backcolor.ToArgb = Background Color (1)
        'Label4.Forecolor.ToArgb = Forecolor (2)
        'Label5.text = Menu Colors (3)
        'Label8.text= Background Layout (4)
        Dim FILE_NAME As String = medirectory & "\" & Label4.Text & "\UserInfo\config.ini"
        If IO.File.Exists(FILE_NAME) Then
            Kill(FILE_NAME)
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            Dim info As String = Label2.Text & vbCrLf & Me.BackColor.ToArgb & vbCrLf & Label4.ForeColor.ToArgb & vbCrLf & mainmenu.BackColor.ToArgb & vbCrLf & Label8.Text
            objWriter.Write(info)
            objWriter.Close()
        Else
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            Dim info As String = Label2.Text & vbCrLf & Me.BackColor.ToArgb & vbCrLf & Label4.ForeColor.ToArgb & vbCrLf & Label5.Text & vbCrLf & Label8.Text
            objWriter.Write(info)
            objWriter.Close()
        End If
    End Sub


    Private Sub beef_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Timer1.Start()
        Try
            My.Computer.Audio.Play(Application.StartupPath + "\logonwav.wav", AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ExitXPeditionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub SetHomepageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetHomepageToolStripMenuItem.Click
        sethomepage.Show()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Dim hispath As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Userinfo\History.txt"
        Kill(hispath)
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem1.Click
        ToLetYaKnow.Text = "Browsing History"
        Dim read As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "\Userinfo\History.txt")
        ToLetYaKnow.TextBox1.Text = read
        ToLetYaKnow.Show()
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackgroundImage = Nothing

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Hide()
        ToolTip1.SetToolTip(addressbar, "Here is the address bar. Enter your main criteria here (spaces are allowed!). XPEdition automatically removes the spaces and adds(the) 'http://www.' and '.com' to your address. To change either the 'http://www.' or '.com', edit the combo boxes on the left and right of the address bar.")
        ToolTip1.SetToolTip(mail, "This is the mail icon. Click here to gain access to your email accounts, and send and recieve email messages.")
        ToolTip1.SetToolTip(favspic, "This is your bookmarks icon. Click here to gain access to your bookmarks you've collected while browsing the web.")
        ToolTip1.SetToolTip(PictureBox2, "This is your home shortcut. Click this to quickly open your home page.")
        ToolTip1.SetToolTip(abookicon, "This is your address book icon. Click here to gain access to your contact's email, phone and fax numbers, address, and much more.")
        ToolTip1.SetToolTip(PictureBox1, "This is the XPEdition scavenger icon. Use this to search for information easily on the web without having to navigate to the site's home page.")
        ToolTip1.SetToolTip(PictureBox6, "This is your customization toolbox. Use this change the color of menus and fonts, along with the desktop background.")
        ToolTip1.SetToolTip(PictureBox5, "Click here to exit XPEdition.")
        ToolTip1.SetToolTip(PictureBox4, "Click here to log out of XPEdition.")
        ToolTip1.SetToolTip(PictureBox7, "Click here to open a new browsing window.")
        ToolTip1.SetToolTip(PictureBox8, "Click here to open a url from your hard drive.")
        ToolTip1.SetToolTip(PictureBox9, "Click here to make XPEdition fullscreen.")
        ToolTip1.SetToolTip(PictureBox10, "Click here to open your user options.")
        ToolTip1.SetToolTip(PictureBox11, "Click here to minimize XPEdition.")
        ToolTip1.SetToolTip(PictureBox13, "Click here to view your child's recently accessed webpages. Right click to clear all webpages.")
        browser.ToolTip1.SetToolTip(browser.pageinfo, "Place your cursor here to view info about the page.")
        browser.ToolTip1.SetToolTip(browser.PictureBox1, "Click here to add this page to your bookmarks.")
        browser.ToolTip1.SetToolTip(browser.stopimage, "Click here to stop the webpage from loading.")
        browser.ToolTip1.SetToolTip(browser.PictureBox3, "Click here to navigate to your homepage.")
        browser.ToolTip1.SetToolTip(browser.PictureBox2, "Click here view the source of the webpage.")


    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button1.Show()
        ToolTip1.SetToolTip(addressbar, "")
        ToolTip1.SetToolTip(mail, "")
        ToolTip1.SetToolTip(favspic, "")
        ToolTip1.SetToolTip(PictureBox2, "")
        ToolTip1.SetToolTip(abookicon, "")
        ToolTip1.SetToolTip(PictureBox1, "")
        ToolTip1.SetToolTip(PictureBox6, "")
        ToolTip1.SetToolTip(PictureBox5, "")
        ToolTip1.SetToolTip(PictureBox4, "")
        ToolTip1.SetToolTip(PictureBox7, "")
        ToolTip1.SetToolTip(PictureBox8, "")
        ToolTip1.SetToolTip(PictureBox9, "")
        ToolTip1.SetToolTip(PictureBox10, "")
        ToolTip1.SetToolTip(PictureBox13, "")
        ToolTip1.SetToolTip(PictureBox11, "")
        browser.ToolTip1.SetToolTip(browser.pageinfo, "")
        browser.ToolTip1.SetToolTip(browser.PictureBox1, "")
        browser.ToolTip1.SetToolTip(browser.stopimage, "")
        browser.ToolTip1.SetToolTip(browser.PictureBox3, "")
        browser.ToolTip1.SetToolTip(browser.PictureBox2, "")


    End Sub

    Private Sub PictureBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox3.BackgroundImage = My.Resources.glassstrip
        PictureBox3.BackColor = Color.Gold
        Cell.Show()
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackgroundImage = Nothing
    End Sub

    Private Sub MDIBC()
        Dim ctl As Control
        Dim ctlMDI As MdiClient


        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor
                FlowLayoutPanel1.BackColor = ctlMDI.BackColor
            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

        For Each c As Control In Me.Controls
            'Find the MdiClient in the MdiWindow
            If TypeOf c Is MdiClient Then
                mdiClient = TryCast(c, MdiClient)
            End If
        Next

    End Sub
    Private Sub beef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.NotifyIcon1.Visible = False
        NotifyIcon1.Visible = True
        MDIBC()
        If IO.File.Exists(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt") Then
            Dim r As String = IO.File.ReadLines(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt")(0)
            If r = "Yes" Then
                Welcome.Show()
            Else
            End If
        Else
        End If
        c4u()
        If IO.File.Exists(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\IsParental.epc") Then
            FlowLayoutPanel1.Size = New Point(568, 68)
            PictureBox13.Visible = True
        Else
        End If
    End Sub
    Private Sub c4u()
        Try
            Dim file As String =
                Application.StartupPath + "\version.txt"
            Dim myver As String = My.Application.Info.Version.ToString
            If My.Computer.FileSystem.FileExists(file) Then
                My.Computer.FileSystem.DeleteFile(file)
            End If
            My.Computer.Network.DownloadFile("http://nickersoft.webs.com/version.txt", file)
            Dim lastver As String = My.Computer.FileSystem.ReadAllText(file)
            If Not myver = lastver Then
                NotifyIcon2.Visible = True
                NotifyIcon2.ShowBalloonTip(100000)
            Else
            End If
        Catch ex As Exception
            ToLetYaKnow.Text = "Error retrieving latest version."
            ToLetYaKnow.TextBox1.Text = ex.Message & vbCrLf & "Please contact Nickersoft."
            ToLetYaKnow.Show()
        End Try
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox4.BackColor = Color.Gold
        PictureBox4.BackgroundImage = My.Resources.glassstrip
        Login.Show()
        Label7.Text = "Logging Off..."
        Me.Close()
        Try
            My.Computer.Audio.Play(Application.StartupPath + "\logoffwav.wav", AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Panel2.Visible = True
        Try
            My.Computer.Audio.Play(Application.StartupPath + "\logoffwav.wav", AudioPlayMode.WaitToComplete)
        Catch ex As Exception
        End Try
        Application.Exit()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Customize.Show()
        PictureBox6.BackColor = Color.Gold
        PictureBox6.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseDown
        PictureBox6.BackColor = Color.Gold
        PictureBox6.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseDown
        PictureBox5.BackColor = Color.Gold
        PictureBox5.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseUp
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseUp
        PictureBox4.BackgroundImage = Nothing
        PictureBox4.BackColor = Color.Transparent
    End Sub

    Private Sub addressbar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub aafter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles aafter.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                Dim space As String = " "


                If addressbar.Text.Contains(space) Then
                    addressbar.Text = Replace(addressbar.Text, space, "")
                End If


                If aafter.Text.Contains(space) Then
                    aafter.Text = Replace(aafter.Text, space, "%20")
                End If


                Dim FILE_NAME As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Userinfo\History.txt"
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
                objWriter.Write(vbCrLf + ComboBox1.Text & addressbar.Text & ComboBox2.Text & aafter.Text)
                objWriter.Close()

                browser.BackColor = Me.BackColor

                Dim newbrowser As browser
                newbrowser = New browser
                newbrowser.Show()
                newbrowser.mainbrowser.Navigate(ComboBox1.Text & addressbar.Text & ComboBox2.Text & aafter.Text)

                Dim chl As String = Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\UserInfo\ChildHistoryList.txt"
                Dim rat As New IO.StreamWriter(chl, True)
                rat.Write(vbCrLf & ComboBox1.Text & addressbar.Text & ComboBox2.Text & aafter.Text + "    ====    " + Label1.Text)
                rat.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        UserControl.Show()
        PictureBox10.BackColor = Color.Gold
        PictureBox10.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub FAQToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FAQToolStripMenuItem1.Click
        Dim newbrowser As New browser
        newbrowser = New browser
        newbrowser.Show()
        newbrowser.mainbrowser.Navigate("http://www.nickersoft.webs.com/faq.htm")
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem1.Click
        CheckForUpdates()
    End Sub

    Private Sub ReportErrorToNickersoftToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportErrorToNickersoftToolStripMenuItem1.Click
        Report.Show()
    End Sub

    Private Sub AboutXPEditionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutXPEditionToolStripMenuItem1.Click
        About.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Dim newbrowser As New browser
        newbrowser = New browser
        newbrowser.Show()

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        PictureBox8.BackColor = Color.Gold
        PictureBox8.BackgroundImage = My.Resources.glassstrip
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox8.BackColor = Color.Transparent
            PictureBox8.BackgroundImage = Nothing
            Dim newbrowser As New browser
            newbrowser = New browser
            newbrowser.Show()
            newbrowser.mainbrowser.Navigate(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PictureBox11.Visible = True
        PictureBox9.Visible = False

    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        PictureBox11.Visible = False
        PictureBox9.Visible = True
    End Sub

    Private Sub PictureBox11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox11.MouseDown
        PictureBox11.BackgroundImage = My.Resources.glassstrip
        PictureBox11.BackColor = Color.Gold
    End Sub

    Private Sub PictureBox11_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseEnter
        PictureBox11.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseLeave
        PictureBox11.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseDown
        PictureBox9.BackgroundImage = My.Resources.glassstrip
        PictureBox9.BackColor = Color.Gold
    End Sub

    Private Sub PictureBox9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter
        PictureBox9.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        PictureBox9.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox9_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseUp
        PictureBox9.BackgroundImage = Nothing
        PictureBox9.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox11_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox11.MouseUp
        PictureBox11.BackColor = Color.Transparent
        PictureBox11.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseDown
        PictureBox7.BackColor = Color.Gold
        PictureBox7.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseUp
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = Nothing
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseDown
        PictureBox8.BackColor = Color.Gold
        PictureBox8.BackgroundImage = My.Resources.glassstrip
    End Sub


    Private Sub PictureBox8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseEnter

        PictureBox8.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave

        PictureBox8.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseUp
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox10_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox10.MouseDown
        PictureBox10.BackColor = Color.Gold
        PictureBox10.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseEnter

        PictureBox10.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseLeave
        PictureBox10.BackgroundImage = Nothing
    End Sub


    Private Sub HelpTopicsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpTopicsToolStripMenuItem1.Click
        Try
            Process.Start(Application.StartupPath & "\Help\XPHELP.HLP")
            Exit Sub
        Catch ex As Exception
            MsgBox("Cannot find help file", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
        For Each frm As Form In Application.OpenForms
            frm.WindowState = FormWindowState.Minimized
        Next
    End Sub

    
    Private Sub beef_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "XPEdition is still running!"
            NotifyIcon1.BalloonTipText = "XPEdition will continue to run in the background until you click the shut down button on the XPEdition desktop."
            NotifyIcon1.ShowBalloonTip(10000)
        End If
        If WindowState = FormWindowState.Maximized Then
            Me.Visible = True
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub NotifyIcon2_BalloonTipClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon2.BalloonTipClicked
        Try
            Dim n As String = Application.StartupPath & "\xpeinstall.txt"
            Dim address As String = "http://nickersoft.webs.com/xpeinstall.txt"
            If My.Computer.FileSystem.FileExists(n) Then
                My.Computer.FileSystem.DeleteFile(n)
            End If
            My.Computer.Network.DownloadFile(address, Application.StartupPath & "\xpeinstall.txt")
            Dim dld As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\xpeinstall.txt")
            My.Computer.Network.DownloadFile(dld, Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\Temp\setup.exe")
            MsgBox("Once the installer opens, please exit XPEdition and install the new version in XPEdition's current program directory.")
            Process.Start(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\Temp\setup.exe")
            Me.Close()
        Catch ex As Exception
            ToLetYaKnow.Text = "Error retrieving latest version."
            ToLetYaKnow.TextBox1.Text = ex.Message & vbCrLf & "Please contact Nickersoft."
            ToLetYaKnow.Show()
        End Try
    End Sub

    Private Sub NotifyIcon2_BalloonTipClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon2.BalloonTipClosed
        NotifyIcon2.Visible = False
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Try
            Dim tlyk As New ToLetYaKnow
            tlyk.Text = "Your Child's Browsing History"
            Dim reader As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\UserInfo\ChildHistoryList.txt")
            tlyk.TextBox1.Text = reader
            tlyk.Show()
        Catch ex As Exception
            MsgBox("Your child's history is sent to you the instant he/she clears her history. Your child has not recently cleared his/her history and his/her collaborative list file has yet to be created.")
        End Try
    End Sub

    Private Sub PictureBox13_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox13.MouseDown
        PictureBox13.BackgroundImage = My.Resources.glassstrip
        PictureBox13.BackColor = Color.Gold
    End Sub

    Private Sub PictureBox13_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseEnter
        PictureBox13.BackgroundImage = My.Resources.glassstrip
    End Sub

    Private Sub PictureBox13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseLeave
        PictureBox13.BackgroundImage = Nothing
    End Sub

    Private Sub ClearWebpagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearWebpagesToolStripMenuItem.Click
        Kill(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\UserInfo\ChildHistoryList.txt")
        MsgBox("Webpages Cleared!")
    End Sub

End Class
