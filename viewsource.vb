Public Class viewsource

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim w As New IO.StreamWriter(SaveFileDialog1.FileName)
            w.Write(TextBox1.Text)
            w.Close()
        End If
    End Sub

    Private Sub viewsource_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = beef
    End Sub
End Class