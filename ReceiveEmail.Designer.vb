<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveEmail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListInbox = New System.Windows.Forms.ListView()
        Me.FromHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubjectHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unread = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MailButton = New System.Windows.Forms.Button()
        Me.DraftButton = New System.Windows.Forms.Button()
        Me.SentItemsButton = New System.Windows.Forms.Button()
        Me.TrashButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.RichMessageBox = New System.Windows.Forms.RichTextBox()
        Me.UserId = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ReadMailButton = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'ListInbox
        '
        Me.ListInbox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FromHeader, Me.SubjectHeader, Me.DateHeader, Me.Unread})
        Me.ListInbox.Location = New System.Drawing.Point(104, 8)
        Me.ListInbox.Name = "ListInbox"
        Me.ListInbox.Size = New System.Drawing.Size(584, 240)
        Me.ListInbox.TabIndex = 0
        Me.ListInbox.UseCompatibleStateImageBehavior = False
        '
        'FromHeader
        '
        Me.FromHeader.Text = "From"
        Me.FromHeader.Width = 108
        '
        'SubjectHeader
        '
        Me.SubjectHeader.Text = "Subject"
        Me.SubjectHeader.Width = 209
        '
        'DateHeader
        '
        Me.DateHeader.Text = "Date"
        Me.DateHeader.Width = 173
        '
        'Unread
        '
        Me.Unread.Text = "Unread"
        '
        'MailButton
        '
        Me.MailButton.Location = New System.Drawing.Point(16, 16)
        Me.MailButton.Name = "MailButton"
        Me.MailButton.Size = New System.Drawing.Size(86, 26)
        Me.MailButton.TabIndex = 7
        Me.MailButton.Text = "Mail"
        Me.MailButton.UseVisualStyleBackColor = True
        '
        'DraftButton
        '
        Me.DraftButton.Location = New System.Drawing.Point(16, 48)
        Me.DraftButton.Name = "DraftButton"
        Me.DraftButton.Size = New System.Drawing.Size(86, 26)
        Me.DraftButton.TabIndex = 8
        Me.DraftButton.Text = "Drafts"
        Me.DraftButton.UseVisualStyleBackColor = True
        '
        'SentItemsButton
        '
        Me.SentItemsButton.Location = New System.Drawing.Point(16, 80)
        Me.SentItemsButton.Name = "SentItemsButton"
        Me.SentItemsButton.Size = New System.Drawing.Size(86, 26)
        Me.SentItemsButton.TabIndex = 9
        Me.SentItemsButton.Text = "Sent Items"
        Me.SentItemsButton.UseVisualStyleBackColor = True
        '
        'TrashButton
        '
        Me.TrashButton.Location = New System.Drawing.Point(16, 112)
        Me.TrashButton.Name = "TrashButton"
        Me.TrashButton.Size = New System.Drawing.Size(86, 22)
        Me.TrashButton.TabIndex = 10
        Me.TrashButton.Text = "Trash"
        Me.TrashButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(24, 500)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(78, 27)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(141, 500)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(77, 27)
        Me.LogoutButton.TabIndex = 3
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'RichMessageBox
        '
        Me.RichMessageBox.Location = New System.Drawing.Point(8, 280)
        Me.RichMessageBox.Name = "RichMessageBox"
        Me.RichMessageBox.Size = New System.Drawing.Size(680, 176)
        Me.RichMessageBox.TabIndex = 7
        Me.RichMessageBox.Text = ""
        '
        'UserId
        '
        Me.UserId.Location = New System.Drawing.Point(360, 500)
        Me.UserId.Name = "UserId"
        Me.UserId.Size = New System.Drawing.Size(128, 20)
        Me.UserId.TabIndex = 8
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(504, 500)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(114, 20)
        Me.Password.TabIndex = 6
        '
        'ReadMailButton
        '
        Me.ReadMailButton.Location = New System.Drawing.Point(258, 500)
        Me.ReadMailButton.Name = "ReadMailButton"
        Me.ReadMailButton.Size = New System.Drawing.Size(71, 27)
        Me.ReadMailButton.TabIndex = 4
        Me.ReadMailButton.Text = "Read"
        Me.ReadMailButton.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(110, 151)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(508, 123)
        Me.WebBrowser1.TabIndex = 11
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'ReceiveEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(712, 523)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ReadMailButton)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserId)
        Me.Controls.Add(Me.RichMessageBox)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.TrashButton)
        Me.Controls.Add(Me.SentItemsButton)
        Me.Controls.Add(Me.DraftButton)
        Me.Controls.Add(Me.MailButton)
        Me.Controls.Add(Me.ListInbox)
        Me.Name = "ReceiveEmail"
        Me.Text = "Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListInbox As System.Windows.Forms.ListView
    Friend WithEvents FromHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents SubjectHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents Unread As System.Windows.Forms.ColumnHeader
    Friend WithEvents MailButton As System.Windows.Forms.Button
    Friend WithEvents DraftButton As System.Windows.Forms.Button
    Friend WithEvents SentItemsButton As System.Windows.Forms.Button
    Friend WithEvents TrashButton As System.Windows.Forms.Button
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents RichMessageBox As System.Windows.Forms.RichTextBox
    Friend WithEvents UserId As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents ReadMailButton As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
