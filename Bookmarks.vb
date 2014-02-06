Imports System.IO
Public Class Bookmarks
    Dim medirectory As String = Application.StartupPath + "\Users\"
    Private Sub Bookmarks_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        beef.favspic.BackgroundImage = Nothing
        beef.favspic.BackColor = Color.Transparent
    End Sub

    Private Sub Bookmarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = beef.BackColor
        Dim bmarks As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Bookmarks"
        For Each file As String In My.Computer.FileSystem.GetFiles(bmarks, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            Dim noext As String = IO.Path.GetFileNameWithoutExtension(file)
            ListBox1.Items.Add(noext)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub


    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Try
            Dim pagereader As String
            Dim path As String
            path = Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "\Bookmarks"
            pagereader = IO.File.ReadLines(path + "\" + ListBox1.SelectedItem.ToString + ".txt")(0)
            Dim site As String = pagereader
            Dim newbrowser As browser
            newbrowser = New browser
            newbrowser.Show()
            newbrowser.mainbrowser.Navigate(site)
        Catch
            MsgBox("We are sorry. XPEdition cannot seem to find the file containing the specified bookmark." + vbCrLf + "Go to the installation directory of XPEdition, click on your account folder, navigate to 'Bookmarks' and check to see if the file exists." + vbCrLf + "Contact Nickersoft for further troubleshooting.")
        End Try
    End Sub

    Private Sub editbmarkbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editbmarkbttn.Click
        EditBmark.Show()
    End Sub

    Private Sub newbmarkbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newbmarkbttn.Click
        EditBmark.Show()
    End Sub

    Private Sub removebmarkbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removebmarkbttn.Click
        File.Delete(medirectory & Login.UsernameTextBox.Text & "\Bookmarks\" & ListBox1.SelectedItem.ToString & ".txt")
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
End Class