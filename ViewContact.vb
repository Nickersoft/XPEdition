Public Class ViewContact
    Dim medirectory As String = Application.StartupPath + "\Users\"
    Private Sub ViewContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Contact Details: " + Contacts.CurrentContacts.SelectedItem.ToString
        Dim path As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Contacts\" + Contacts.CurrentContacts.SelectedItem.ToString + ".txt"
        Dim contactdeets As String = My.Computer.FileSystem.ReadAllText(path)
        Label6.Text = contactdeets
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class