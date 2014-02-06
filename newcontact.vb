Public Class newcontact

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ctl As Control

        ' Clear all the TextBoxes on the form.
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FILE_NAME As String = Login.UsernameTextBox.Text + "\Contacts\" + fname.Text + " " + lname.Text + ".txt"
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        Dim info As String
        info = fname.Text + vbCrLf + lname.Text + vbCrLf + email.Text + vbCrLf + TextBox1.Text + TextBox2.Text + TextBox3.Text + vbCrLf + TextBox4.Text + TextBox5.Text + TextBox6.Text + vbCrLf + TextBox7.Text + TextBox8.Text + TextBox9.Text + vbCrLf + TextBox10.Text + TextBox11.Text + TextBox12.Text + vbCrLf + a1.Text + vbCrLf + a2.Text + vbCrLf + street.Text + vbCrLf + state.Text + vbCrLf + country.SelectedItem.ToString + vbCrLf + zip.Text + vbCrLf + web.Text + vbCrLf + comment.Text
        objWriter.Write(info)
        objWriter.Close()
        Contacts.CurrentContacts.Items(Contacts.CurrentContacts.SelectedItem) = fname
        Me.Close()
    End Sub
End Class