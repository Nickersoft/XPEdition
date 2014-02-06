<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class browser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(browser))
        Me.mainbrowser = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.pbar = New System.Windows.Forms.Panel()
        Me.slime = New System.Windows.Forms.PictureBox()
        Me.infopanel = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.forwardbutton = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pageinfo = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.backbutton = New System.Windows.Forms.PictureBox()
        Me.stopimage = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.pbar.SuspendLayout()
        CType(Me.slime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.infopanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forwardbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pageinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stopimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainbrowser
        '
        Me.mainbrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainbrowser.Location = New System.Drawing.Point(-1, 12)
        Me.mainbrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.mainbrowser.Name = "mainbrowser"
        Me.mainbrowser.Size = New System.Drawing.Size(624, 356)
        Me.mainbrowser.TabIndex = 0
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Timer3
        '
        '
        'pbar
        '
        Me.pbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbar.BackColor = System.Drawing.Color.Transparent
        Me.pbar.BackgroundImage = Global.XPEdition.My.Resources.Resources.glassstrip
        Me.pbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbar.Controls.Add(Me.slime)
        Me.pbar.Location = New System.Drawing.Point(0, -1)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(623, 10)
        Me.pbar.TabIndex = 6
        '
        'slime
        '
        Me.slime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.slime.BackColor = System.Drawing.Color.Lime
        Me.slime.BackgroundImage = Global.XPEdition.My.Resources.Resources.glassstrip
        Me.slime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.slime.Image = Global.XPEdition.My.Resources.Resources.glassstrip
        Me.slime.Location = New System.Drawing.Point(-3, 0)
        Me.slime.Name = "slime"
        Me.slime.Size = New System.Drawing.Size(18, 10)
        Me.slime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slime.TabIndex = 0
        Me.slime.TabStop = False
        '
        'infopanel
        '
        Me.infopanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infopanel.BackColor = System.Drawing.Color.Transparent
        Me.infopanel.BackgroundImage = Global.XPEdition.My.Resources.Resources.glassstrip
        Me.infopanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.infopanel.Controls.Add(Me.PictureBox4)
        Me.infopanel.Controls.Add(Me.Label1)
        Me.infopanel.Location = New System.Drawing.Point(0, 334)
        Me.infopanel.Name = "infopanel"
        Me.infopanel.Size = New System.Drawing.Size(623, 33)
        Me.infopanel.TabIndex = 10
        Me.infopanel.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Location = New System.Drawing.Point(4, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Address"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.XPEdition.My.Resources.Resources.glassstrip
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.forwardbutton)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.pageinfo)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.backbutton)
        Me.Panel1.Controls.Add(Me.stopimage)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 366)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 50)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(426, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 49)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'forwardbutton
        '
        Me.forwardbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.forwardbutton.BackColor = System.Drawing.Color.Transparent
        Me.forwardbutton.BackgroundImage = CType(resources.GetObject("forwardbutton.BackgroundImage"), System.Drawing.Image)
        Me.forwardbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.forwardbutton.Image = CType(resources.GetObject("forwardbutton.Image"), System.Drawing.Image)
        Me.forwardbutton.Location = New System.Drawing.Point(572, 0)
        Me.forwardbutton.Name = "forwardbutton"
        Me.forwardbutton.Size = New System.Drawing.Size(52, 50)
        Me.forwardbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.forwardbutton.TabIndex = 8
        Me.forwardbutton.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(314, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(55, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'pageinfo
        '
        Me.pageinfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pageinfo.BackColor = System.Drawing.Color.Transparent
        Me.pageinfo.BackgroundImage = CType(resources.GetObject("pageinfo.BackgroundImage"), System.Drawing.Image)
        Me.pageinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pageinfo.Location = New System.Drawing.Point(143, 0)
        Me.pageinfo.Name = "pageinfo"
        Me.pageinfo.Size = New System.Drawing.Size(53, 53)
        Me.pageinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pageinfo.TabIndex = 7
        Me.pageinfo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(375, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'backbutton
        '
        Me.backbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.backbutton.BackColor = System.Drawing.Color.Transparent
        Me.backbutton.BackgroundImage = CType(resources.GetObject("backbutton.BackgroundImage"), System.Drawing.Image)
        Me.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backbutton.Image = CType(resources.GetObject("backbutton.Image"), System.Drawing.Image)
        Me.backbutton.Location = New System.Drawing.Point(-2, 1)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(50, 49)
        Me.backbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.backbutton.TabIndex = 9
        Me.backbutton.TabStop = False
        '
        'stopimage
        '
        Me.stopimage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.stopimage.BackColor = System.Drawing.Color.Transparent
        Me.stopimage.BackgroundImage = CType(resources.GetObject("stopimage.BackgroundImage"), System.Drawing.Image)
        Me.stopimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.stopimage.Location = New System.Drawing.Point(259, 2)
        Me.stopimage.Name = "stopimage"
        Me.stopimage.Size = New System.Drawing.Size(49, 49)
        Me.stopimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stopimage.TabIndex = 5
        Me.stopimage.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(202, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "WebPage- Complete|*.mht"
        '
        'browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(623, 416)
        Me.Controls.Add(Me.pbar)
        Me.Controls.Add(Me.infopanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mainbrowser)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(631, 443)
        Me.Name = "browser"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Untitled"
        Me.TopMost = True
        Me.pbar.ResumeLayout(False)
        CType(Me.slime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.infopanel.ResumeLayout(False)
        Me.infopanel.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forwardbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pageinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stopimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainbrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbar As System.Windows.Forms.Panel
    Friend WithEvents slime As System.Windows.Forms.PictureBox
    Friend WithEvents stopimage As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pageinfo As System.Windows.Forms.PictureBox
    Friend WithEvents forwardbutton As System.Windows.Forms.PictureBox
    Friend WithEvents backbutton As System.Windows.Forms.PictureBox
    Friend WithEvents infopanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
