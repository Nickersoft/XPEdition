<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customize))
        Me.cwallpaperlbl = New System.Windows.Forms.Label()
        Me.openbttn = New System.Windows.Forms.Button()
        Me.styledropdown = New System.Windows.Forms.ComboBox()
        Me.wallpaperlayout = New System.Windows.Forms.Label()
        Me.resetbutton = New System.Windows.Forms.Button()
        Me.colorbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.tbttn = New System.Windows.Forms.Button()
        Me.cfontbttn = New System.Windows.Forms.Button()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cwallpaperlbl
        '
        Me.cwallpaperlbl.AutoSize = True
        Me.cwallpaperlbl.BackColor = System.Drawing.Color.Transparent
        Me.cwallpaperlbl.Location = New System.Drawing.Point(64, 19)
        Me.cwallpaperlbl.Name = "cwallpaperlbl"
        Me.cwallpaperlbl.Size = New System.Drawing.Size(95, 13)
        Me.cwallpaperlbl.TabIndex = 1
        Me.cwallpaperlbl.Text = "Current Wallpaper:"
        '
        'openbttn
        '
        Me.openbttn.Location = New System.Drawing.Point(52, 187)
        Me.openbttn.Name = "openbttn"
        Me.openbttn.Size = New System.Drawing.Size(57, 23)
        Me.openbttn.TabIndex = 3
        Me.openbttn.Text = "Open"
        Me.openbttn.UseVisualStyleBackColor = True
        '
        'styledropdown
        '
        Me.styledropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.styledropdown.FormattingEnabled = True
        Me.styledropdown.Items.AddRange(New Object() {"None", "Stretch", "Tile", "Zoom", "Center"})
        Me.styledropdown.Location = New System.Drawing.Point(255, 155)
        Me.styledropdown.Name = "styledropdown"
        Me.styledropdown.Size = New System.Drawing.Size(137, 21)
        Me.styledropdown.TabIndex = 4
        '
        'wallpaperlayout
        '
        Me.wallpaperlayout.AutoSize = True
        Me.wallpaperlayout.BackColor = System.Drawing.Color.Transparent
        Me.wallpaperlayout.Location = New System.Drawing.Point(281, 139)
        Me.wallpaperlayout.Name = "wallpaperlayout"
        Me.wallpaperlayout.Size = New System.Drawing.Size(93, 13)
        Me.wallpaperlayout.TabIndex = 6
        Me.wallpaperlayout.Text = "Wallpaper Layout:"
        '
        'resetbutton
        '
        Me.resetbutton.Location = New System.Drawing.Point(281, 189)
        Me.resetbutton.Name = "resetbutton"
        Me.resetbutton.Size = New System.Drawing.Size(93, 21)
        Me.resetbutton.TabIndex = 10
        Me.resetbutton.Text = "XPE Default"
        Me.resetbutton.UseVisualStyleBackColor = True
        '
        'colorbutton
        '
        Me.colorbutton.Location = New System.Drawing.Point(250, 45)
        Me.colorbutton.Name = "colorbutton"
        Me.colorbutton.Size = New System.Drawing.Size(156, 21)
        Me.colorbutton.TabIndex = 8
        Me.colorbutton.Text = "Change Desktop/Form Color"
        Me.colorbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(252, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Change Desktop and Font Color:"
        '
        'tbttn
        '
        Me.tbttn.Enabled = False
        Me.tbttn.Location = New System.Drawing.Point(250, 99)
        Me.tbttn.Name = "tbttn"
        Me.tbttn.Size = New System.Drawing.Size(156, 21)
        Me.tbttn.TabIndex = 12
        Me.tbttn.Text = "Make Clock Bar Transparent"
        Me.tbttn.UseVisualStyleBackColor = True
        '
        'cfontbttn
        '
        Me.cfontbttn.Location = New System.Drawing.Point(250, 72)
        Me.cfontbttn.Name = "cfontbttn"
        Me.cfontbttn.Size = New System.Drawing.Size(156, 21)
        Me.cfontbttn.TabIndex = 13
        Me.cfontbttn.Text = "Change Font Color"
        Me.cfontbttn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(115, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = Global.XPEdition.My.MySettings.Default.myBackColor
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = Global.XPEdition.My.MySettings.Default.myBackgroundImageLayout
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundImageLayout", Global.XPEdition.My.MySettings.Default, "myBackgroundImageLayout", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.XPEdition.My.MySettings.Default, "myBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureBox1.Location = New System.Drawing.Point(7, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 131)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = Global.XPEdition.My.MySettings.Default.homepage
        Me.OpenFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.gif;*.png;*.jpeg)|*.bmp;*.jpg;*.gif;*.png;*.jpeg|JPEG " & _
            "(*.jpeg)|*.jpeg, *.jpg|Bitmaps (*.bmp)|*.bmp|PNG (*.png)|*.png|GIF (*.gif)|*.gif" & _
            ""
        '
        'Customize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.XPEdition.My.Resources.Resources.glassstrip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(418, 222)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cfontbttn)
        Me.Controls.Add(Me.tbttn)
        Me.Controls.Add(Me.resetbutton)
        Me.Controls.Add(Me.colorbutton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wallpaperlayout)
        Me.Controls.Add(Me.styledropdown)
        Me.Controls.Add(Me.openbttn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cwallpaperlbl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Customize"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Customize"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cwallpaperlbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents openbttn As System.Windows.Forms.Button
    Friend WithEvents styledropdown As System.Windows.Forms.ComboBox
    Friend WithEvents wallpaperlayout As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents resetbutton As System.Windows.Forms.Button
    Friend WithEvents colorbutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents tbttn As System.Windows.Forms.Button
    Friend WithEvents cfontbttn As System.Windows.Forms.Button
    Friend WithEvents ColorDialog2 As System.Windows.Forms.ColorDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
