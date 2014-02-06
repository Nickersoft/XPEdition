<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class email
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(email))
        Me.bodytxt = New System.Windows.Forms.RichTextBox()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.totxt = New System.Windows.Forms.TextBox()
        Me.subtxt = New System.Windows.Forms.TextBox()
        Me.smtptxt = New System.Windows.Forms.TextBox()
        Me.userlbl = New System.Windows.Forms.Label()
        Me.passlbl = New System.Windows.Forms.Label()
        Me.tolbl = New System.Windows.Forms.Label()
        Me.sublbl = New System.Windows.Forms.Label()
        Me.serverselectlbl = New System.Windows.Forms.Label()
        Me.gmailicon = New System.Windows.Forms.PictureBox()
        Me.msnicon = New System.Windows.Forms.PictureBox()
        Me.yahooicon = New System.Windows.Forms.PictureBox()
        Me.aimicon = New System.Windows.Forms.PictureBox()
        Me.sendbttn = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.rememusernamecheck = New System.Windows.Forms.CheckBox()
        Me.remempasswordcheck = New System.Windows.Forms.CheckBox()
        Me.forgetcheck = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.attachgroup = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Attaches = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.gmailicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msnicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yahooicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aimicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.attachgroup.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bodytxt
        '
        Me.bodytxt.BackColor = System.Drawing.Color.White
        Me.bodytxt.Location = New System.Drawing.Point(12, 302)
        Me.bodytxt.Name = "bodytxt"
        Me.bodytxt.Size = New System.Drawing.Size(554, 250)
        Me.bodytxt.TabIndex = 10
        Me.bodytxt.Text = ""
        '
        'usertxt
        '
        Me.usertxt.Location = New System.Drawing.Point(185, 141)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(193, 20)
        Me.usertxt.TabIndex = 1
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(185, 167)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(193, 20)
        Me.passtxt.TabIndex = 2
        Me.passtxt.UseSystemPasswordChar = True
        '
        'totxt
        '
        Me.totxt.Location = New System.Drawing.Point(74, 219)
        Me.totxt.Name = "totxt"
        Me.totxt.Size = New System.Drawing.Size(349, 20)
        Me.totxt.TabIndex = 6
        '
        'subtxt
        '
        Me.subtxt.Location = New System.Drawing.Point(74, 245)
        Me.subtxt.Name = "subtxt"
        Me.subtxt.Size = New System.Drawing.Size(349, 20)
        Me.subtxt.TabIndex = 7
        '
        'smtptxt
        '
        Me.smtptxt.Location = New System.Drawing.Point(185, 193)
        Me.smtptxt.Name = "smtptxt"
        Me.smtptxt.Size = New System.Drawing.Size(193, 20)
        Me.smtptxt.TabIndex = 5
        Me.smtptxt.Visible = False
        '
        'userlbl
        '
        Me.userlbl.AutoSize = True
        Me.userlbl.BackColor = System.Drawing.Color.Transparent
        Me.userlbl.Location = New System.Drawing.Point(121, 144)
        Me.userlbl.Name = "userlbl"
        Me.userlbl.Size = New System.Drawing.Size(58, 13)
        Me.userlbl.TabIndex = 6
        Me.userlbl.Text = "Username:"
        '
        'passlbl
        '
        Me.passlbl.AutoSize = True
        Me.passlbl.BackColor = System.Drawing.Color.Transparent
        Me.passlbl.Location = New System.Drawing.Point(121, 170)
        Me.passlbl.Name = "passlbl"
        Me.passlbl.Size = New System.Drawing.Size(56, 13)
        Me.passlbl.TabIndex = 7
        Me.passlbl.Text = "Password:"
        '
        'tolbl
        '
        Me.tolbl.AutoSize = True
        Me.tolbl.BackColor = System.Drawing.Color.Transparent
        Me.tolbl.Location = New System.Drawing.Point(45, 222)
        Me.tolbl.Name = "tolbl"
        Me.tolbl.Size = New System.Drawing.Size(23, 13)
        Me.tolbl.TabIndex = 8
        Me.tolbl.Text = "To:"
        '
        'sublbl
        '
        Me.sublbl.AutoSize = True
        Me.sublbl.BackColor = System.Drawing.Color.Transparent
        Me.sublbl.Location = New System.Drawing.Point(22, 248)
        Me.sublbl.Name = "sublbl"
        Me.sublbl.Size = New System.Drawing.Size(46, 13)
        Me.sublbl.TabIndex = 9
        Me.sublbl.Text = "Subject:"
        '
        'serverselectlbl
        '
        Me.serverselectlbl.AutoSize = True
        Me.serverselectlbl.BackColor = System.Drawing.Color.Transparent
        Me.serverselectlbl.Location = New System.Drawing.Point(193, 51)
        Me.serverselectlbl.Name = "serverselectlbl"
        Me.serverselectlbl.Size = New System.Drawing.Size(193, 13)
        Me.serverselectlbl.TabIndex = 10
        Me.serverselectlbl.Text = "Please Select An Email Provider Below:"
        '
        'gmailicon
        '
        Me.gmailicon.BackColor = System.Drawing.Color.Transparent
        Me.gmailicon.BackgroundImage = CType(resources.GetObject("gmailicon.BackgroundImage"), System.Drawing.Image)
        Me.gmailicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gmailicon.Image = CType(resources.GetObject("gmailicon.Image"), System.Drawing.Image)
        Me.gmailicon.Location = New System.Drawing.Point(91, 77)
        Me.gmailicon.Name = "gmailicon"
        Me.gmailicon.Size = New System.Drawing.Size(71, 58)
        Me.gmailicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gmailicon.TabIndex = 11
        Me.gmailicon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.gmailicon, "Gmail")
        '
        'msnicon
        '
        Me.msnicon.BackColor = System.Drawing.Color.Transparent
        Me.msnicon.BackgroundImage = CType(resources.GetObject("msnicon.BackgroundImage"), System.Drawing.Image)
        Me.msnicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.msnicon.Image = CType(resources.GetObject("msnicon.Image"), System.Drawing.Image)
        Me.msnicon.Location = New System.Drawing.Point(204, 77)
        Me.msnicon.Name = "msnicon"
        Me.msnicon.Size = New System.Drawing.Size(71, 58)
        Me.msnicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.msnicon.TabIndex = 12
        Me.msnicon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.msnicon, "MicroSoft Network")
        '
        'yahooicon
        '
        Me.yahooicon.BackColor = System.Drawing.Color.Transparent
        Me.yahooicon.BackgroundImage = CType(resources.GetObject("yahooicon.BackgroundImage"), System.Drawing.Image)
        Me.yahooicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.yahooicon.Image = CType(resources.GetObject("yahooicon.Image"), System.Drawing.Image)
        Me.yahooicon.Location = New System.Drawing.Point(307, 77)
        Me.yahooicon.Name = "yahooicon"
        Me.yahooicon.Size = New System.Drawing.Size(71, 58)
        Me.yahooicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.yahooicon.TabIndex = 13
        Me.yahooicon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.yahooicon, "Yahoo!")
        '
        'aimicon
        '
        Me.aimicon.BackColor = System.Drawing.Color.Transparent
        Me.aimicon.BackgroundImage = CType(resources.GetObject("aimicon.BackgroundImage"), System.Drawing.Image)
        Me.aimicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.aimicon.Image = CType(resources.GetObject("aimicon.Image"), System.Drawing.Image)
        Me.aimicon.Location = New System.Drawing.Point(401, 77)
        Me.aimicon.Name = "aimicon"
        Me.aimicon.Size = New System.Drawing.Size(71, 58)
        Me.aimicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.aimicon.TabIndex = 14
        Me.aimicon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.aimicon, "AOL and AIM")
        '
        'sendbttn
        '
        Me.sendbttn.Location = New System.Drawing.Point(258, 558)
        Me.sendbttn.Name = "sendbttn"
        Me.sendbttn.Size = New System.Drawing.Size(71, 21)
        Me.sendbttn.TabIndex = 11
        Me.sendbttn.Text = "Send"
        Me.sendbttn.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 589)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(578, 24)
        Me.ProgressBar1.TabIndex = 16
        '
        'rememusernamecheck
        '
        Me.rememusernamecheck.AutoSize = True
        Me.rememusernamecheck.BackColor = System.Drawing.Color.Transparent
        Me.rememusernamecheck.Location = New System.Drawing.Point(49, 195)
        Me.rememusernamecheck.Name = "rememusernamecheck"
        Me.rememusernamecheck.Size = New System.Drawing.Size(128, 17)
        Me.rememusernamecheck.TabIndex = 3
        Me.rememusernamecheck.Text = "Remember Username"
        Me.rememusernamecheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rememusernamecheck.UseVisualStyleBackColor = False
        '
        'remempasswordcheck
        '
        Me.remempasswordcheck.AutoSize = True
        Me.remempasswordcheck.BackColor = System.Drawing.Color.Transparent
        Me.remempasswordcheck.Location = New System.Drawing.Point(218, 196)
        Me.remempasswordcheck.Name = "remempasswordcheck"
        Me.remempasswordcheck.Size = New System.Drawing.Size(126, 17)
        Me.remempasswordcheck.TabIndex = 4
        Me.remempasswordcheck.Text = "Remember Password"
        Me.remempasswordcheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.remempasswordcheck.UseVisualStyleBackColor = False
        '
        'forgetcheck
        '
        Me.forgetcheck.AutoSize = True
        Me.forgetcheck.BackColor = System.Drawing.Color.Transparent
        Me.forgetcheck.Location = New System.Drawing.Point(384, 196)
        Me.forgetcheck.Name = "forgetcheck"
        Me.forgetcheck.Size = New System.Drawing.Size(74, 17)
        Me.forgetcheck.TabIndex = 5
        Me.forgetcheck.Text = "Forget Me"
        Me.forgetcheck.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'attachgroup
        '
        Me.attachgroup.BackColor = System.Drawing.Color.Transparent
        Me.attachgroup.Controls.Add(Me.Button2)
        Me.attachgroup.Controls.Add(Me.Button1)
        Me.attachgroup.Location = New System.Drawing.Point(437, 213)
        Me.attachgroup.Name = "attachgroup"
        Me.attachgroup.Size = New System.Drawing.Size(129, 52)
        Me.attachgroup.TabIndex = 24
        Me.attachgroup.TabStop = False
        Me.attachgroup.Text = "Attachments"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(64, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 26)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "View..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Attaches
        '
        Me.Attaches.Multiselect = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = Global.XPEdition.My.Resources.Resources.glassstrip
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(12, 272)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 28)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(137, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(137, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(136, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(136, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Font"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextColorToolStripMenuItem, Me.BackgroundToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.OptionsToolStripMenuItem.Text = "&Color"
        '
        'TextColorToolStripMenuItem
        '
        Me.TextColorToolStripMenuItem.Name = "TextColorToolStripMenuItem"
        Me.TextColorToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.TextColorToolStripMenuItem.Text = "&Text"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(115, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        Me.OpenFileDialog1.Title = "Insert Text"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(74, 219)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(349, 21)
        Me.ComboBox1.TabIndex = 26
        Me.ComboBox1.Visible = False
        '
        'email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(578, 613)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.forgetcheck)
        Me.Controls.Add(Me.remempasswordcheck)
        Me.Controls.Add(Me.rememusernamecheck)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.sendbttn)
        Me.Controls.Add(Me.aimicon)
        Me.Controls.Add(Me.yahooicon)
        Me.Controls.Add(Me.msnicon)
        Me.Controls.Add(Me.gmailicon)
        Me.Controls.Add(Me.serverselectlbl)
        Me.Controls.Add(Me.sublbl)
        Me.Controls.Add(Me.tolbl)
        Me.Controls.Add(Me.passlbl)
        Me.Controls.Add(Me.userlbl)
        Me.Controls.Add(Me.smtptxt)
        Me.Controls.Add(Me.subtxt)
        Me.Controls.Add(Me.totxt)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.bodytxt)
        Me.Controls.Add(Me.attachgroup)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "email"
        Me.Text = "New Email Message"
        Me.TopMost = True
        CType(Me.gmailicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msnicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yahooicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aimicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.attachgroup.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bodytxt As System.Windows.Forms.RichTextBox
    Friend WithEvents usertxt As System.Windows.Forms.TextBox
    Friend WithEvents passtxt As System.Windows.Forms.TextBox
    Friend WithEvents totxt As System.Windows.Forms.TextBox
    Friend WithEvents subtxt As System.Windows.Forms.TextBox
    Friend WithEvents smtptxt As System.Windows.Forms.TextBox
    Friend WithEvents userlbl As System.Windows.Forms.Label
    Friend WithEvents passlbl As System.Windows.Forms.Label
    Friend WithEvents tolbl As System.Windows.Forms.Label
    Friend WithEvents sublbl As System.Windows.Forms.Label
    Friend WithEvents serverselectlbl As System.Windows.Forms.Label
    Friend WithEvents gmailicon As System.Windows.Forms.PictureBox
    Friend WithEvents msnicon As System.Windows.Forms.PictureBox
    Friend WithEvents yahooicon As System.Windows.Forms.PictureBox
    Friend WithEvents aimicon As System.Windows.Forms.PictureBox
    Friend WithEvents sendbttn As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents rememusernamecheck As System.Windows.Forms.CheckBox
    Friend WithEvents remempasswordcheck As System.Windows.Forms.CheckBox
    Friend WithEvents forgetcheck As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents attachgroup As System.Windows.Forms.GroupBox
    Friend WithEvents Attaches As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
