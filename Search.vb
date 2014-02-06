Public Class Search

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Label2.Text = "http://www.google.com/search?hl=en&source=hp&q="
        PictureBox3.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        PictureBox1.BackColor = Color.Gold
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Label2.Text = "http://search.yahoo.com/search;_ylt=AmIvnE8p0gfJPBea16kagMKbvZx4?p="
        PictureBox3.BackColor = Color.Gold
        PictureBox1.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Label2.Text = "http://www.bing.com/search?q="
        PictureBox3.BackColor = Color.Transparent
        PictureBox1.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Gold
    End Sub


    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = beef
        Me.BackColor = beef.BackColor
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then ctrl.ForeColor = beef.Label4.ForeColor
        Next
    End Sub

    Private Sub Search_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        beef.PictureBox1.BackColor = Color.Transparent
        beef.PictureBox1.BackgroundImage = Nothing
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        PictureBox10.BackColor = Color.Gold
        PictureBox3.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        PictureBox1.BackColor = Color.Transparent
        Label2.Text = "http://www.ask.com/web?q="
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        PictureBox11.BackColor = Color.Gold
        PictureBox10.BackColor = Color.Transparent
        PictureBox3.BackColor = Color.Transparent
        PictureBox9.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        PictureBox1.BackColor = Color.Transparent
        Label7.Text = "http://www.metacafe.com/topics/"
    End Sub


    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        PictureBox8.BackColor = Color.Gold
        PictureBox7.BackColor = Color.Transparent
        PictureBox11.BackColor = Color.Transparent
        PictureBox9.BackColor = Color.Transparent
        PictureBox12.BackColor = Color.Transparent
        Label7.Text = "http://www.youtube.com/results?search_query="
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        PictureBox8.BackColor = Color.Transparent
        PictureBox7.BackColor = Color.Gold
        PictureBox9.BackColor = Color.Transparent
        PictureBox11.BackColor = Color.Transparent
        PictureBox12.BackColor = Color.Transparent
        Label7.Text = "http://www.google.com/search?q="
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Label7.Text = "http://www.google.com/search?q=" Then
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.mainbrowser.Navigate("http://www.google.com/search?q=" + TextBox3.Text + "&um=1&ie=UTF-8&tbo=u&tbs=vid:1&source=og&sa=N&hl=en&tab=wv")
        Else
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.mainbrowser.Navigate(Label7.Text + TextBox3.Text)
        End If
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Label7.Text = "http://video.yahoo.com/search/?p="
        PictureBox8.BackColor = Color.Transparent
        PictureBox7.BackColor = Color.Transparent
        PictureBox11.BackColor = Color.Transparent
        PictureBox9.BackColor = Color.Transparent
        PictureBox12.BackColor = Color.Gold
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Label7.Text = "http://www.bing.com/videos/search?q="
        PictureBox8.BackColor = Color.Transparent
        PictureBox7.BackColor = Color.Transparent
        PictureBox11.BackColor = Color.Transparent
        PictureBox12.BackColor = Color.Transparent
        PictureBox9.BackColor = Color.Gold
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.BackColor = Color.Transparent
        PictureBox6.BackColor = Color.Gold
        PictureBox13.BackColor = Color.Transparent
        PictureBox14.BackColor = Color.Transparent
        PictureBox15.BackColor = Color.Transparent
        Label4.Text = "http://www.flickr.com/search/?q="
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.BackColor = Color.Gold
        PictureBox6.BackColor = Color.Transparent
        PictureBox13.BackColor = Color.Transparent
        PictureBox14.BackColor = Color.Transparent
        PictureBox15.BackColor = Color.Transparent
        Label4.Text = "http://www.google.com/images?hl=en&source=imghp&q="
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.BackColor = Color.Transparent
        PictureBox6.BackColor = Color.Transparent
        PictureBox13.BackColor = Color.Gold
        PictureBox14.BackColor = Color.Transparent
        PictureBox15.BackColor = Color.Transparent
        Label4.Text = "http://images.search.yahoo.com/search/images;_ylt=A0WTeff56ChMpAEA5_GLuLkF?p="
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.BackColor = Color.Transparent
        PictureBox6.BackColor = Color.Transparent
        PictureBox13.BackColor = Color.Transparent
        PictureBox14.BackColor = Color.Gold
        PictureBox15.BackColor = Color.Transparent
        Label4.Text = "http://my.imageshack.us/new_search.php?q="
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox4.BackColor = Color.Gold
        PictureBox5.BackColor = Color.Transparent
        PictureBox6.BackColor = Color.Transparent
        PictureBox13.BackColor = Color.Transparent
        PictureBox14.BackColor = Color.Transparent
        PictureBox15.BackColor = Color.Transparent
        Label4.Text = "http://www.bing.com/images?q="
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.BackColor = Color.Transparent
        PictureBox6.BackColor = Color.Transparent
        PictureBox13.BackColor = Color.Transparent
        PictureBox14.BackColor = Color.Transparent
        PictureBox15.BackColor = Color.Gold
        Label4.Text = "http://picasaweb.google.com/lh/view?q="
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Label10.Text = "http://www.mp3raid.com/music/" Then
            TextBox4.Text = Replace(TextBox4.Text, " ", "_")
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.mainbrowser.Navigate("http://www.mp3raid.com/music/" + TextBox4.Text + ".html")
        Else
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.mainbrowser.Navigate(Label10.Text + TextBox4.Text + ".html")
        End If
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Label10.Text = "http://new.music.yahoo.com/search/?p="
        PictureBox16.BackColor = Color.Gold
        PictureBox17.BackColor = Color.Transparent
        PictureBox18.BackColor = Color.Transparent
        PictureBox19.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        PictureBox16.BackColor = Color.Transparent
        PictureBox17.BackColor = Color.Transparent
        PictureBox18.BackColor = Color.Transparent
        PictureBox19.BackColor = Color.Gold
        Label10.Text = "http://beemp3.com/index.php?q="
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        PictureBox16.BackColor = Color.Transparent
        PictureBox17.BackColor = Color.Transparent
        PictureBox18.BackColor = Color.Gold
        PictureBox19.BackColor = Color.Transparent
        Label10.Text = "http://incompetech.com/m/c/royalty-free/index.html?keywords="
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        PictureBox16.BackColor = Color.Transparent
        PictureBox17.BackColor = Color.Gold
        PictureBox18.BackColor = Color.Transparent
        PictureBox19.BackColor = Color.Transparent
        Label10.Text = "http://www.mp3raid.com/music/"
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        If Label2.Text = "Label2" Then
            MsgBox("Please select a server.")
        Else
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.Show()
            newbrowser.mainbrowser.Navigate(Label2.Text + TextBox1.Text)
        End If
        
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        If Label4.Text = "Label4" Then
            MsgBox("Please select a server.")
        Else
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.Show()
            newbrowser.mainbrowser.Navigate(Label4.Text + TextBox1.Text)
        End If
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        If Label7.Text = "http://www.google.com/search?q=" Then
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.mainbrowser.Navigate("http://www.google.com/search?q=" + TextBox3.Text + "&um=1&ie=UTF-8&tbo=u&tbs=vid:1&source=og&sa=N&hl=en&tab=wv")
        Else
                If Label7.Text = "Label7" Then
                    MsgBox("Please select a server.")
                Else
                    Dim newbrowser As browser
                    newbrowser = New browser
                    newbrowser.Show()
                    newbrowser.mainbrowser.Navigate(Label7.Text + TextBox1.Text)
                End If
            End If
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        If Label10.Text = "http://www.mp3raid.com/music/" Then
            TextBox4.Text = Replace(TextBox4.Text, " ", "_")
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.mainbrowser.Navigate("http://www.mp3raid.com/music/" + TextBox4.Text + ".html")
        Else
            If Label10.Text = "Label10" Then
                MsgBox("Please select a server.")
            Else
                Dim newbrowser As browser
                newbrowser = New browser
                newbrowser.Show()
                newbrowser.mainbrowser.Navigate(Label10.Text + TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Label2.Text = "Label2" Then
                MsgBox("Please select a server.")
            Else
                Dim newbrowser As browser
                newbrowser = New browser
                newbrowser.Show()
                newbrowser.mainbrowser.Navigate(Label2.Text + TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Label4.Text = "Label4" Then
                MsgBox("Please select a server.")
            Else
                Dim newbrowser As browser
                newbrowser = New browser
                newbrowser.Show()
                newbrowser.mainbrowser.Navigate(Label4.Text + TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If Label7.Text = "http://www.google.com/search?q=" Then
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.mainbrowser.Navigate("http://www.google.com/search?q=" + TextBox3.Text + "&um=1&ie=UTF-8&tbo=u&tbs=vid:1&source=og&sa=N&hl=en&tab=wv")
        Else
            If Label7.Text = "Label7" Then
                MsgBox("Please select a server.")
            Else
                Dim newbrowser As browser
                newbrowser = New browser
                newbrowser.Show()
                newbrowser.mainbrowser.Navigate(Label7.Text + TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Label10.Text = "Label10" Then
                MsgBox("Please select a server.")
            Else
                Dim newbrowser As browser
                newbrowser = New browser
                newbrowser.Show()
                newbrowser.mainbrowser.Navigate(Label10.Text + TextBox1.Text)
            End If
        End If
    End Sub
End Class