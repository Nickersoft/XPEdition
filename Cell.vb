Public Class Cell

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        celltext.show()
    End Sub

    Private Sub Cell_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        beef.PictureBox3.BackgroundImage = Nothing
        beef.PictureBox3.BackColor = Color.Transparent
    End Sub
End Class