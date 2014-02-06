Public Class Form1
    Private Declare Auto Function AddFontMemResourceEx Lib "Gdi32.dll" _
    (ByVal pbFont As IntPtr, ByVal cbFont As Integer, _
    ByVal pdv As Integer, ByRef pcFonts As Integer) As IntPtr

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser2.Navigate("http://downforeveryoneorjustme.com/m." & TextBox1.Text)
        End If
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        If WebBrowser2.DocumentTitle = "It's just you." Then
            TextBox1.Text = Replace(TextBox1.Text, "http://", "")
            TextBox1.Text = Replace(TextBox1.Text, "https://", "")
            TextBox1.Text = Replace(TextBox1.Text, "www.", "")
            WebBrowser1.Navigate("http://www.m." & TextBox1.Text)
        Else
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub
End Class
