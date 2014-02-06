Public Class sethomepage
    Dim path As String = Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "\UserInfo"
    Dim FILE_NAME As String = path + "\Home.txt"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IO.File.Exists(path + "\Home.txt") Then
            Kill(path + "\Home.txt")
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(TextBox1.Text)
            objWriter.Close()
            MsgBox("Homepage Set!")
            Me.Close()
        Else
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(TextBox1.Text)
            objWriter.Close()
            MsgBox("Homepage Set!")
            Me.Close()
        End If
    End Sub

    Private Sub sethomepage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim homereader As String = My.Computer.FileSystem.ReadAllText(FILE_NAME)
        TextBox1.Text = homereader
    End Sub
End Class