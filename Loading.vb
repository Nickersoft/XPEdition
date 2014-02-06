Imports System.Runtime.InteropServices
Public Class Loading
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
    Dim medirectory As String = Application.StartupPath + "\Users\"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        loader()
        wallpaper()
        Home()
        Dim page As New beef
        page = beef
        page.Show()
        Me.Close()
    End Sub

    Private Sub AddHomes()
        Try
            Dim bmarks As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Bookmarks"
            For Each file As String In My.Computer.FileSystem.GetFiles(bmarks, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                My.Computer.FileSystem.ReadAllText(file)
                Dim url As New Uri(file)
                Try
                    If url.Host = UriHostNameType.Dns Then
                        Dim picURL = "http://" & url.Host & "/xpedition-icon.png"

                        Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(picURL)
                        Dim response As System.Net.HttpWebResponse = request.GetResponse()
                        Dim stream As System.IO.Stream = response.GetResponseStream()
                        Dim pic = Image.FromStream(stream)

                        Dim pbox As New PictureBox
                        pbox.BackgroundImage = pic
                        pbox.Image = My.Resources.glassstrip
                        pbox.BackgroundImageLayout = ImageLayout.Stretch
                        pbox.Size = New Point(64, 64)
                        pbox.SizeMode = PictureBoxSizeMode.StretchImage
                        beef.FlowLayoutPanel2.Controls.Add(pbox)
                    End If
                Catch
                    Dim pbox As New PictureBox
                    Dim lbl As New Label
                    lbl.Text = url.ToString
                    pbox.BackgroundImage = My.Resources.glassstrip
                    pbox.Image = My.Resources.glassstrip
                    pbox.BackgroundImageLayout = ImageLayout.Stretch
                    pbox.Size = New Point(64, 64)
                    pbox.SizeMode = PictureBoxSizeMode.StretchImage
                    beef.FlowLayoutPanel2.Controls.Add(pbox)
                    beef.FlowLayoutPanel2.Controls.Add(lbl)
                End Try
            Next
        Catch
        End Try
    End Sub
    Private Sub Loading_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
        Timer2.Start()

    End Sub
    Private Sub wallpaper()
        Dim config As String = Application.StartupPath + "\Users\" + Login.UsernameTextBox.Text + "\UserInfo\config.ini"
        Dim fileReader As String
        fileReader = IO.File.ReadLines(config)(0)
        beef.Label2.Text = fileReader
        Dim coloreader As String
        coloreader = IO.File.ReadLines(config)(1)
        beef.BackColor = Color.FromArgb(coloreader)
        Dim freader As String
        freader = IO.File.ReadLines(config)(2)
        beef.Label4.ForeColor = Color.FromArgb(freader)
        Timer1.Stop()

        Try
            If fileReader = "Label2" Then
                beef.BackgroundImage = My.Resources.glassstrip
                beef.BackgroundImageLayout = ImageLayout.Stretch
            Else
                beef.BackgroundImage = Image.FromFile(beef.Label2.Text)
            End If
            Dim bl As String = IO.File.ReadLines(config)(4)
            If bl = "Label8" Then
                beef.BackgroundImageLayout = ImageLayout.Stretch
            Else
                beef.BackgroundImageLayout = bl
            End If
        Catch
            MsgBox("We're sorry. There was an error loading your last configuration. Please re-adjust your display.", MsgBoxStyle.Critical)
            beef.BackColor = Color.SkyBlue
            browser.BackColor = Color.RoyalBlue
            beef.mainmenu.BackColor = Color.SkyBlue
            beef.BackgroundImage = My.Resources.glassstrip
            beef.Label4.ForeColor = Color.Black
        End Try
        MDIBC()
        Timer1.Stop()
    End Sub
    Private Sub loader()
        Try
            beef.ComboBox1.SelectedIndex = 0
            beef.ComboBox2.SelectedIndex = 0

            beef.FileToolStripMenuItem.ForeColor = beef.Label4.ForeColor
            beef.ToolsToolStripMenuItem.ForeColor = beef.Label4.ForeColor
            beef.HelpToolStripMenuItem.ForeColor = beef.Label4.ForeColor
            beef.Label1.ForeColor = beef.Label4.ForeColor

            Try
                Dim mcolorpath As String = Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "\UserInfo\config.ini"
                Dim menureader As String = IO.File.ReadLines(mcolorpath)(3)
                beef.Label5.Text = menureader
                beef.mainmenu.BackColor = Color.FromArgb(menureader)
            Catch
                beef.mainmenu.BackColor = Color.SkyBlue
            End Try

            Dim namereader As String = IO.File.ReadLines(medirectory + "\" + Login.UsernameTextBox.Text + "\userinfo\usercredentials.ini")(3)
            beef.Text = "Welcome, " + namereader + "."
            Dim td As DateTime = DateTime.Now
            beef.Label1.Text = td
            beef.Label4.Text = Login.UsernameTextBox.Text
            beef.Panel1.BackColor = beef.mainmenu.BackColor

            If Login.Visible = True Then
                Login.Close()
            End If
            browser.BackColor = beef.BackColor
        Catch ex As Exception
            ToLetYaKnow.TextBox1.Text = ex.Message & vbCrLf & "Please report this error to Nickersoft."
            ToLetYaKnow.Text = ex.InnerException.ToString
            ToLetYaKnow.Show()
        End Try
    End Sub
    Private Sub Home()
        Dim r As String = IO.File.ReadLines(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt")(1)
        Dim l As New Label
        l.Text = r
        If l.Text = "Yes" Then
            browser.Show()
            Dim home As String = Application.StartupPath + "\Users\" & Login.UsernameTextBox.Text & "\UserInfo\Home.txt"
            If IO.File.Exists(home) Then
                Dim reader As String = My.Computer.FileSystem.ReadAllText(home)
                browser.mainbrowser.Navigate(reader)

            Else

                browser.mainbrowser.Navigate("http://www.nickersoft.webs.com/")

            End If
        Else
        End If
    End Sub
    Private Sub MDIBC()
        Dim ctl As Control
        Dim ctlMDI As MdiClient


        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In beef.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = beef.BackColor
                beef.FlowLayoutPanel1.BackColor = ctlMDI.BackColor
            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

        For Each c As Control In beef.Controls
            'Find the MdiClient in the MdiWindow
            If TypeOf c Is MdiClient Then
                mdiClient = TryCast(c, MdiClient)
            End If
        Next
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PictureBox2.Width += 5
    End Sub
End Class
