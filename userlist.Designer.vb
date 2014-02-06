<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userlist
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
        Me.users = New System.Windows.Forms.ListBox()
        Me.passwords = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'users
        '
        Me.users.FormattingEnabled = True
        Me.users.Location = New System.Drawing.Point(4, 13)
        Me.users.Name = "users"
        Me.users.Size = New System.Drawing.Size(89, 238)
        Me.users.TabIndex = 0
        '
        'passwords
        '
        Me.passwords.FormattingEnabled = True
        Me.passwords.Location = New System.Drawing.Point(102, 14)
        Me.passwords.MultiColumn = True
        Me.passwords.Name = "passwords"
        Me.passwords.Size = New System.Drawing.Size(88, 238)
        Me.passwords.TabIndex = 1
        '
        'userlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 266)
        Me.Controls.Add(Me.passwords)
        Me.Controls.Add(Me.users)
        Me.Name = "userlist"
        Me.Text = "userlist"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents users As System.Windows.Forms.ListBox
    Friend WithEvents passwords As System.Windows.Forms.ListBox
End Class
