
Public Class Weatherl

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        wb.Navigate("http://m.wund.com/cgi-bin/findweather/getForecast?brand=mobile&query=" + TextBox2.Text)
        TextBox1.Text = "Finding local forecast. Please wait..."
    End Sub

    Private Sub wb_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        TextBox1.Text = wb.Document.Body.InnerText
    End Sub
End Class