Public Class Welcome

    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = beef
        ' Initialize the string array
        Dim strStrings As String() = {"Easily learn what each item does by clicking the Help Assisstant in the lower right hand corner of the screen.",
                                      "Right click the Help Assisstant in the lower right hand corner of the screen for additional help options.",
                                      "The address bar automatically removes any spaces you type.",
                                      "The main page is called the desktop.",
                                      "You can change the background color and image of the desktop by clicking the Customization icon.",
                                      "The browser that opens the minute your browser starts is called the homepage."}
        ' Choose a random slogan
        Dim RandString As New Random()
        ' Display the random slogan
        RichTextBox1.Text = strStrings(RandString.Next(0, strStrings.Length - 1))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Initialize the string array
        Dim strStrings As String() = {"Easily learn what each item does by clicking the Help Assisstant in the lower right hand corner of the screen.",
                                      "Right click the Help Assisstant in the lower right hand corner of the screen for additional help options.",
                                      "The address bar automatically removes any spaces you type.",
                                      "The main page is called the desktop.",
                                      "You can change the background color and image of the desktop by clicking the Customization icon.",
                                      "The browser that opens the minute your browser starts is called the homepage."}
        ' Choose a random slogan
        Dim RandString As New Random()
        ' Display the random slogan
        RichTextBox1.Text = strStrings(RandString.Next(0, strStrings.Length - 1))

    End Sub
   
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then

            Dim h As String = IO.File.ReadLines(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt")(1)
            Dim hl As New Label
            hl.Text = h
            Dim w As New IO.StreamWriter(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt", False)
            w.Write("Yes" & vbCrLf & hl.Text)
            w.Close()
        Else

            Dim h As String = IO.File.ReadLines(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt")(1)
            Dim hl As New Label
            hl.Text = h
            Dim w As New IO.StreamWriter(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt", False)
            w.Write("No" & vbCrLf & hl.Text)
            w.Close()
        End If
    End Sub
End Class