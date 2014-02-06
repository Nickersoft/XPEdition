Public Class pcsetup


    Private Sub pcsetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each myDirectory As IO.DirectoryInfo In New IO.DirectoryInfo(Application.StartupPath & "\Users").GetDirectories()
            ListBox1.Items.Add(myDirectory.Name)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cwriter As New IO.StreamWriter(Application.StartupPath & "\Users\" & ListBox1.SelectedItem.ToString & "\UserControl.epc")
        cwriter.Write(newuser.UsernameTextBox.Text)
        cwriter.Close()
        Dim cfiledetail As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(Application.StartupPath & "\Users\" & ListBox1.SelectedItem.ToString & "\UserControl.epc")
        cfiledetail.IsReadOnly = True
        cfiledetail.Attributes = IO.FileAttributes.Hidden

        Dim pwriter As New IO.StreamWriter(Application.StartupPath & "\Users\" & newuser.UsernameTextBox.Text & "\IsParental.epc")
        pwriter.Write("")
        pwriter.Close()
        Dim pfiledetail As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(Application.StartupPath & "\Users\" & newuser.UsernameTextBox.Text & "\IsParental.epc")
        pfiledetail.IsReadOnly = True
        pfiledetail.Attributes = IO.FileAttributes.Hidden

        Login.UsernameTextBox.Text = newuser.UsernameTextBox.Text
        Login.PasswordTextBox.Text = newuser.PasswordTextBox.Text
        Me.Close()
        newuser.Close()
    End Sub
End Class