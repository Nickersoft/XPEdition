<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class newuser
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newuser))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.Label()
        Me.phint = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.BackgroundImage = CType(resources.GetObject("LogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Location = New System.Drawing.Point(5, 54)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(93, 81)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Location = New System.Drawing.Point(174, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(67, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "User Name:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Location = New System.Drawing.Point(411, 9)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(79, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.XPEdition.My.MySettings.Default, "CreatePass", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PasswordTextBox.Location = New System.Drawing.Point(341, 35)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 4
        Me.PasswordTextBox.Text = Global.XPEdition.My.MySettings.Default.CreatePass
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.Transparent
        Me.OK.Location = New System.Drawing.Point(230, 192)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 8
        Me.OK.Text = "&OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(341, 192)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 9
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'fname
        '
        Me.fname.BackColor = System.Drawing.Color.LightBlue
        Me.fname.Location = New System.Drawing.Point(104, 84)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(220, 20)
        Me.fname.TabIndex = 2
        Me.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.Color.Transparent
        Me.txtfname.Location = New System.Drawing.Point(176, 58)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(65, 23)
        Me.txtfname.TabIndex = 4
        Me.txtfname.Text = "First Name:"
        Me.txtfname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'phint
        '
        Me.phint.BackColor = System.Drawing.Color.LightBlue
        Me.phint.Location = New System.Drawing.Point(341, 138)
        Me.phint.Name = "phint"
        Me.phint.Size = New System.Drawing.Size(220, 20)
        Me.phint.TabIndex = 6
        Me.phint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(403, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Password Hint:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rpassword
        '
        Me.rpassword.BackColor = System.Drawing.Color.LightBlue
        Me.rpassword.Location = New System.Drawing.Point(341, 84)
        Me.rpassword.Name = "rpassword"
        Me.rpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.rpassword.Size = New System.Drawing.Size(220, 20)
        Me.rpassword.TabIndex = 5
        Me.rpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(403, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Repeat Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lname
        '
        Me.lname.BackColor = System.Drawing.Color.LightBlue
        Me.lname.Location = New System.Drawing.Point(104, 138)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(220, 20)
        Me.lname.TabIndex = 3
        Me.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.Color.Transparent
        Me.txtlname.Location = New System.Drawing.Point(176, 112)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(65, 23)
        Me.txtlname.TabIndex = 12
        Me.txtlname.Text = "Last Name:"
        Me.txtlname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(230, 169)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(206, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Make my account a parental account."
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.XPEdition.My.MySettings.Default, "CreateUN", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.UsernameTextBox.Location = New System.Drawing.Point(104, 35)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        Me.UsernameTextBox.Text = Global.XPEdition.My.MySettings.Default.CreateUN
        Me.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'newuser
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(581, 223)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.rpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.phint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newuser"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create A New User"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.Label
    Friend WithEvents phint As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
