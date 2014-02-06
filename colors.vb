Public Class colors

    Private Sub colorbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorbutton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub applybutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles applybutton.Click
        beef.BackColor = Me.BackColor
        beef.mainmenu.BackColor = Me.BackColor
        browser.BackColor = Me.BackColor
        My.Settings.myBackColor = ColorDialog1.Color
        My.Settings.Save()
    End Sub

    Private Sub resetbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetbutton.Click
        Me.BackColor = Color.White
        beef.BackColor = Color.SkyBlue
        browser.BackColor = Color.RoyalBlue
        beef.mainmenu.BackColor = Color.SkyBlue
    End Sub
End Class