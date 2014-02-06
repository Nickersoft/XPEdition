Imports ADODB
Imports CDO
Public Class browser
    Private mywebclient As New System.Net.WebClient
    Dim medirectory As String = Application.StartupPath + "\Users\"

    Private Sub mainbrowser_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles mainbrowser.Navigating
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        slime.Width += 1
    End Sub

    Private Sub mainbrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles mainbrowser.DocumentCompleted
        slime.Size = New Point(624, 43)
        PictureBox1.Enabled = True
        Me.Text = mainbrowser.Document.Title
        Label1.Text = mainbrowser.Url.ToString
        Try
            Dim url As Uri = New Uri(mainbrowser.Url.ToString)
            If url.HostNameType = UriHostNameType.Dns Then
                Dim iconURL = "http://" & url.Host & "/favicon.ico"

                Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim stream As System.IO.Stream = response.GetResponseStream()
                Dim favicon = Image.FromStream(stream)

                PictureBox4.Image = favicon
            End If
        Catch ex As Exception
            PictureBox4.Image = Nothing
        End Try
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        slime.Hide()
    End Sub


    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        CheckSite()
    End Sub
    Public Sub CheckSite()
        Dim file As String =
            Application.StartupPath + "\Users\" & "\" & Login.UsernameTextBox.Text & "\Temp\currentwebpage.html"
        Dim myver As String = Application.StartupPath + "\Users\" & "\" & Login.UsernameTextBox.Text & "\Temp\recentwebpage.html"
        If My.Computer.FileSystem.FileExists(file) Then
            My.Computer.FileSystem.DeleteFile(file)
        End If
        My.Computer.Network.DownloadFile(mainbrowser.Url.ToString, file)

        Dim lastver As String = My.Computer.FileSystem.ReadAllText(file)
        If Not myver = lastver Then
            MsgBox("Update Available!" + vbCrLf + "Your version: " + file + vbCrLf + "Current Version: " + lastver + vbCrLf + "Would you like to install now?", MsgBoxStyle.YesNo)
            If MsgBoxResult.Yes Then
                My.Computer.Network.DownloadFile("http://nickersoft.webs.com/installxp.exe", "")
            Else
            End If
        Else
            MsgBox("XPedition Is Up To Date.", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            Dim FILE_NAME As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Bookmarks\" + mainbrowser.DocumentTitle + ".txt"
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(mainbrowser.Url.ToString)
            objWriter.Close()
            MsgBox("Bookmark Added!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub stopimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopimage.Click
        mainbrowser.Stop()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        viewsource.Show()
        viewsource.TextBox1.Text = mainbrowser.DocumentText
        viewsource.Text = "HTML Source: " + mainbrowser.DocumentTitle
    End Sub

    Private Sub backbutton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backbutton.Click
        mainbrowser.GoBack()
        Me.Refresh()
        Me.Text = mainbrowser.Document.Title
        pbar.Show()
        slime.Size = New Point(18, 10)
    End Sub

    Private Sub forwardbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forwardbutton.Click
        mainbrowser.GoForward()
        Me.Refresh()
        Me.Text = mainbrowser.Document.Title
        slime.Show()
        slime.Size = New Point(18, 10)
    End Sub

    Private Sub forwardbutton_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles forwardbutton.MouseDown
        forwardbutton.BackColor = Color.Gold
        forwardbutton.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub forwardbutton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles forwardbutton.MouseUp
        forwardbutton.BorderStyle = BorderStyle.None
        forwardbutton.BackColor = Color.Transparent
    End Sub

    Private Sub backbutton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles backbutton.MouseDown
        backbutton.BackColor = Color.Gold
        backbutton.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub backbutton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles backbutton.MouseUp
        backbutton.BackColor = Color.Transparent
        backbutton.BorderStyle = BorderStyle.None
    End Sub

    Private Sub browser_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = beef.BackColor
    End Sub


    Private Sub pageinfo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pageinfo.MouseEnter
        infopanel.Show()
    End Sub

    Private Sub pageinfo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pageinfo.MouseLeave
        infopanel.Hide()
    End Sub

    Private Sub mainbrowser_NewWindow(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mainbrowser.NewWindow
        e.Cancel = True
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim homereader As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "\Userinfo\home.txt")
        mainbrowser.Navigate(homereader)
    End Sub

    Private Sub browser_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If beef.PictureBox2.BackColor = Color.Gold Then
            beef.PictureBox2.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub browser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = beef
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        PictureBox2.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown
        PictureBox3.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseUp
        PictureBox3.BorderStyle = BorderStyle.None
    End Sub

    Private Sub stopimage_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles stopimage.MouseDown
        stopimage.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub stopimage_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles stopimage.MouseUp
        stopimage.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        SaveFileDialog1.FileName = mainbrowser.DocumentTitle
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            SavePage(mainbrowser.Url.ToString, SaveFileDialog1.FileName)
        End If
    End Sub
    Private Sub SavePage(ByVal Url As String, ByVal FilePath As String)
        Dim iMessage As CDO.Message = New CDO.Message
        iMessage.CreateMHTMLBody(Url, _
        CDO.CdoMHTMLFlags.cdoSuppressNone, "", "")
        Dim adodbstream As ADODB.Stream = New ADODB.Stream
        adodbstream.Type = ADODB.StreamTypeEnum.adTypeText
        adodbstream.Charset = "US-ASCII"
        adodbstream.Open()
        iMessage.DataSource.SaveToObject(adodbstream, "_Stream")
        adodbstream.SaveToFile(FilePath, _
                  ADODB.SaveOptionsEnum.adSaveCreateOverWrite)
    End Sub

    Private Sub PictureBox5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseDown
        PictureBox5.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseUp
        PictureBox5.BorderStyle = BorderStyle.None
    End Sub
End Class