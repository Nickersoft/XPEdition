<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contacts
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
        Me.CurrentContacts = New System.Windows.Forms.ListBox()
        Me.addtxt = New System.Windows.Forms.Button()
        Me.removetxt = New System.Windows.Forms.Button()
        Me.sendtxt = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'CurrentContacts
        '
        Me.CurrentContacts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentContacts.FormattingEnabled = True
        Me.CurrentContacts.Location = New System.Drawing.Point(3, 9)
        Me.CurrentContacts.Name = "CurrentContacts"
        Me.CurrentContacts.Size = New System.Drawing.Size(428, 329)
        Me.CurrentContacts.TabIndex = 0
        '
        'addtxt
        '
        Me.addtxt.Location = New System.Drawing.Point(12, 361)
        Me.addtxt.Name = "addtxt"
        Me.addtxt.Size = New System.Drawing.Size(118, 34)
        Me.addtxt.TabIndex = 1
        Me.addtxt.Text = "New Contact"
        Me.addtxt.UseVisualStyleBackColor = True
        '
        'removetxt
        '
        Me.removetxt.Location = New System.Drawing.Point(156, 361)
        Me.removetxt.Name = "removetxt"
        Me.removetxt.Size = New System.Drawing.Size(118, 34)
        Me.removetxt.TabIndex = 2
        Me.removetxt.Text = "Remove Contact"
        Me.removetxt.UseVisualStyleBackColor = True
        '
        'sendtxt
        '
        Me.sendtxt.Location = New System.Drawing.Point(305, 361)
        Me.sendtxt.Name = "sendtxt"
        Me.sendtxt.Size = New System.Drawing.Size(118, 34)
        Me.sendtxt.TabIndex = 3
        Me.sendtxt.Text = "Send Email"
        Me.sendtxt.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 421)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(428, 173)
        Me.ListBox1.TabIndex = 4
        '
        'Contacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.XPEdition.My.Resources.Resources.glassstrip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(435, 402)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.sendtxt)
        Me.Controls.Add(Me.removetxt)
        Me.Controls.Add(Me.addtxt)
        Me.Controls.Add(Me.CurrentContacts)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Contacts"
        Me.Text = "Address Book"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CurrentContacts As System.Windows.Forms.ListBox
    Friend WithEvents addtxt As System.Windows.Forms.Button
    Friend WithEvents removetxt As System.Windows.Forms.Button
    Friend WithEvents sendtxt As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
