Public Class Customize
    Dim medirectory As String = IO.Directory.GetCurrentDirectory
    Private Sub Customize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = beef.BackColor
        Me.MdiParent = beef
        PictureBox1.BackColor = beef.BackColor
        PictureBox1.BackgroundImage = beef.BackgroundImage
        PictureBox1.BackgroundImageLayout = beef.BackgroundImageLayout
        styledropdown.SelectedItem = beef.BackgroundImageLayout.ToString
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then ctrl.ForeColor = beef.Label4.ForeColor
        Next
    End Sub

    Private Sub openbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openbttn.Click
        OpenFileDialog1.InitialDirectory = Application.StartupPath + "\Wallpapers"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            beef.BackgroundImage = PictureBox1.BackgroundImage
            Dim ext As String = IO.Path.GetExtension(OpenFileDialog1.FileName)
            Dim bg As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Wallpaper"
            beef.Label2.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub colorbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorbutton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
                For Each frm As Form In Application.OpenForms
                    frm.BackColor = ColorDialog1.Color
            Next

                Dim ctl As Control
                Dim ctlMDI As MdiClient


                ' Loop through all of the form's controls looking
                ' for the control of type MdiClient.
            For Each ctl In beef.Controls
                Try
                    ' Attempt to cast the control to type MdiClient.
                    ctlMDI = CType(ctl, MdiClient)

                    ' Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = ColorDialog1.Color
                    beef.BackColor = ctlMDI.BackColor
                    beef.FlowLayoutPanel1.BackColor = ctlMDI.BackColor
                Catch exc As InvalidCastException
                    ' Catch and ignore the error if casting failed.
                End Try
            Next
                My.Settings.myBackColor = ColorDialog1.Color
                My.Settings.Save()
                beef.mainmenu.BackColor = Me.BackColor
                beef.Panel1.BackColor = Me.BackColor
                PictureBox1.BackColor = beef.BackColor

            End If
    End Sub
    Private Sub resetbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetbutton.Click
        Me.BackColor = Color.White
        beef.BackColor = Color.SkyBlue
        browser.BackColor = Color.RoyalBlue
        beef.mainmenu.BackColor = Color.SkyBlue
        PictureBox1.BackColor = Color.SkyBlue
        beef.BackgroundImage = My.Resources.glassstrip
        beef.Label4.ForeColor = Color.Black
        PictureBox1.BackgroundImage = beef.BackgroundImage
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then ctrl.ForeColor = beef.Label4.ForeColor
        Next
    End Sub

    Private Sub styledropdown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles styledropdown.SelectedIndexChanged
        If styledropdown.SelectedItem = "Stretch" Then
            beef.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        End If
        If styledropdown.SelectedItem = "Tile" Then
            beef.BackgroundImageLayout = ImageLayout.Tile
            PictureBox1.BackgroundImageLayout = ImageLayout.Tile
        End If
        If styledropdown.SelectedItem = "Center" Then
            beef.BackgroundImageLayout = ImageLayout.Center
            PictureBox1.BackgroundImageLayout = ImageLayout.Center
        End If
        If styledropdown.SelectedItem = "Zoom" Then
            beef.BackgroundImageLayout = ImageLayout.Zoom
            PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        End If
        If styledropdown.SelectedItem = "None" Then
            beef.BackgroundImageLayout = ImageLayout.None
            PictureBox1.BackgroundImageLayout = ImageLayout.None
        End If
        beef.Label8.Text = beef.BackgroundImageLayout
    End Sub

    Private Sub tbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbttn.Click
        MsgBox("Are you sure?" + vbCrLf + "This may cause it to be difficult to read the text.", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            beef.mainmenu.BackColor = Color.Transparent
            beef.Panel1.BackColor = Color.Transparent
            beef.Label5.Text = beef.mainmenu.BackColor.ToArgb
        Else
        End If
    End Sub

    Private Sub cfontbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cfontbttn.Click
        If ColorDialog2.ShowDialog() = DialogResult.OK Then
            beef.Label4.ForeColor = ColorDialog2.Color
            For Each frm As Form In Application.OpenForms
                For Each ctrl As Control In Application.OpenForms
                    If TypeOf ctrl Is Label Then ctrl.ForeColor = ColorDialog2.Color
                Next
            Next
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Label Then ctrl.ForeColor = beef.Label4.ForeColor
            Next
            beef.Label1.ForeColor = beef.Label4.ForeColor
            End If
    End Sub

    Private Sub Customize_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        beef.PictureBox6.BackColor = Color.Transparent
        beef.PictureBox6.BackgroundImage = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        beef.BackgroundImage = Nothing
        beef.Label2.Text = "Label2"
    End Sub
End Class