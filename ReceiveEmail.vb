
Public Class ReceiveEmail


    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            WebBrowser1.Document.GetElementById("Email").SetAttribute("value", UserId.Text)
            WebBrowser1.Document.GetElementById("Passwd").SetAttribute("value", Password.Text)

            WebBrowser1.Document.GetElementById("signIn").InvokeMember("click")

            RichMessageBox.Text = WebBrowser1.Document.Body.InnerText
        End If
    End Sub

    Private Sub ReceiveEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("m.gmail.com")
    End Sub

    Private Sub ReadMailButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadMailButton.Click

    End Sub
End Class
