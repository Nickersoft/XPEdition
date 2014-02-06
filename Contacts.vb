Public Class Contacts
    Dim medirectory As String = IO.Directory.GetCurrentDirectory

    Private Sub Contacts_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        beef.abookicon.BackgroundImage = Nothing
        beef.abookicon.BackColor = Color.Transparent
    End Sub

    Private Sub addtxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addtxt.Click
        newcontact.Show()
    End Sub

    Private Sub removetxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removetxt.Click
    End Sub

    Private Sub Contacts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cpath As String = Application.StartupPath + "\Users\" + Login.UsernameTextBox.Text + "\Contacts\"
        For Each file As String In My.Computer.FileSystem.GetFiles(cpath, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            Dim contact As String = IO.Path.GetFileNameWithoutExtension(file)
            CurrentContacts.Items.Add(contact)
        Next
    End Sub

    Private Sub CurrentContacts_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentContacts.DoubleClick
        ViewContact.Show()
    End Sub

End Class