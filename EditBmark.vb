Public Class EditBmark
    Dim path As String = Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "\Bookmarks"
    Private Sub EditBmark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = beef
        If IO.File.Exists(path + "\" + Bookmarks.ListBox1.SelectedItem.ToString + ".txt") Then
            TextBox1.Text = Bookmarks.ListBox1.SelectedItem.ToString
            Dim pagereader As String
            pagereader = My.Computer.FileSystem.ReadAllText(path + "\" + Bookmarks.ListBox1.SelectedItem.ToString + ".txt")
            Dim site As String = pagereader
            TextBox2.Text = site
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IO.File.Exists(path + "\" + Bookmarks.ListBox1.SelectedItem.ToString + ".txt") Then
            Kill(path + "\" + Bookmarks.ListBox1.SelectedItem.ToString + ".txt")
            Dim FILE_NAME As String = path + "\" + TextBox1.Text + ".txt"
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(TextBox2.Text)
            objWriter.Close()
            Bookmarks.ListBox1.Items(Bookmarks.ListBox1.SelectedItem) = TextBox2.Text
            Bookmarks.Hide()
            Bookmarks.Show()
            Me.Close()

        Else
            Dim FILE_NAME As String = path + "\" + TextBox1.Text + ".txt"
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(TextBox2.Text)
            objWriter.Close()
            Bookmarks.ListBox1.Refresh()
            Bookmarks.Hide()
            Bookmarks.Show()
            Me.Close()

        End If
    End Sub

End Class