Public Class ToLetYaKnow

    Private Sub ToLetYaKnow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.ForeColor = beef.Label4.ForeColor
        Me.MdiParent = beef
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Contains("error") = True Then
            Report.Show()
        End If
        Me.Close()
    End Sub

    Private Sub ToLetYaKnow_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        beef.PictureBox13.BackColor = Color.Transparent
    End Sub
End Class