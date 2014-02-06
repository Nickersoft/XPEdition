Option Strict Off
Option Explicit On
Friend Class CFrmMain
  Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()
  End Sub
  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
    If Disposing Then
      If Not components Is Nothing Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(Disposing)
  End Sub
  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer
  Public ToolTip1 As System.Windows.Forms.ToolTip
  Public WithEvents txtIP As System.Windows.Forms.TextBox
  Public WithEvents txtPort As System.Windows.Forms.TextBox
  Public WithEvents btnCancel As System.Windows.Forms.Button
  Public WithEvents btnConnect As System.Windows.Forms.Button
  Public WithEvents Label3 As System.Windows.Forms.Label
  Public WithEvents Label4 As System.Windows.Forms.Label
  Public WithEvents Frame4 As System.Windows.Forms.GroupBox
  Public WithEvents txtAlertMsg As System.Windows.Forms.TextBox
  Public WithEvents btnAlert As System.Windows.Forms.Button
  Public WithEvents Frame2 As System.Windows.Forms.GroupBox
  Public WithEvents btnSettings As System.Windows.Forms.Button
  Public WithEvents helper As System.Windows.Forms.Button
  Public WithEvents btnExit As System.Windows.Forms.Button
  Public WithEvents btnIP As System.Windows.Forms.Button
  Public WithEvents btnChat As System.Windows.Forms.Button
  Public WithEvents txtChatLog As System.Windows.Forms.TextBox
  Public WithEvents txtChatMsg As System.Windows.Forms.TextBox
  Public WithEvents Frame3 As System.Windows.Forms.GroupBox
  Public WithEvents btnRemove As System.Windows.Forms.Button
  Public WithEvents Frame1 As System.Windows.Forms.GroupBox
  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.
  'Do not modify it using the code editor.
  Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
  Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents lvPeers As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents SockLib As AxbsSocketLibrary.AxBSSockLibX
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.components = New System.ComponentModel.Container
Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CFrmMain))
Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
Me.Frame4 = New System.Windows.Forms.GroupBox
Me.txtIP = New System.Windows.Forms.TextBox
Me.txtPort = New System.Windows.Forms.TextBox
Me.btnCancel = New System.Windows.Forms.Button
Me.btnConnect = New System.Windows.Forms.Button
Me.Label3 = New System.Windows.Forms.Label
Me.Label4 = New System.Windows.Forms.Label
Me.Frame2 = New System.Windows.Forms.GroupBox
Me.txtAlertMsg = New System.Windows.Forms.TextBox
Me.btnAlert = New System.Windows.Forms.Button
Me.btnSettings = New System.Windows.Forms.Button
Me.helper = New System.Windows.Forms.Button
Me.btnExit = New System.Windows.Forms.Button
Me.btnIP = New System.Windows.Forms.Button
Me.Frame3 = New System.Windows.Forms.GroupBox
Me.SockLib = New AxbsSocketLibrary.AxBSSockLibX
Me.btnChat = New System.Windows.Forms.Button
Me.txtChatLog = New System.Windows.Forms.TextBox
Me.txtChatMsg = New System.Windows.Forms.TextBox
Me.Frame1 = New System.Windows.Forms.GroupBox
Me.lvPeers = New System.Windows.Forms.ListView
Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
Me.btnRemove = New System.Windows.Forms.Button
Me.StatusBar = New System.Windows.Forms.StatusBar
Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
Me.Frame4.SuspendLayout()
Me.Frame2.SuspendLayout()
Me.Frame3.SuspendLayout()
CType(Me.SockLib, System.ComponentModel.ISupportInitialize).BeginInit()
Me.Frame1.SuspendLayout()
CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'Frame4
'
Me.Frame4.BackColor = System.Drawing.SystemColors.Control
Me.Frame4.Controls.Add(Me.txtIP)
Me.Frame4.Controls.Add(Me.txtPort)
Me.Frame4.Controls.Add(Me.btnCancel)
Me.Frame4.Controls.Add(Me.btnConnect)
Me.Frame4.Controls.Add(Me.Label3)
Me.Frame4.Controls.Add(Me.Label4)
Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
Me.Frame4.Location = New System.Drawing.Point(451, 10)
Me.Frame4.Name = "Frame4"
Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Frame4.Size = New System.Drawing.Size(203, 155)
Me.Frame4.TabIndex = 15
Me.Frame4.TabStop = False
Me.Frame4.Text = "New"
'
'txtIP
'
Me.txtIP.AcceptsReturn = True
Me.txtIP.AutoSize = False
Me.txtIP.BackColor = System.Drawing.SystemColors.Window
Me.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam
Me.txtIP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtIP.ForeColor = System.Drawing.SystemColors.WindowText
Me.txtIP.Location = New System.Drawing.Point(10, 39)
Me.txtIP.MaxLength = 0
Me.txtIP.Name = "txtIP"
Me.txtIP.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.txtIP.Size = New System.Drawing.Size(184, 23)
Me.txtIP.TabIndex = 19
Me.txtIP.Text = "127.0.0.1"
'
'txtPort
'
Me.txtPort.AcceptsReturn = True
Me.txtPort.AutoSize = False
Me.txtPort.BackColor = System.Drawing.SystemColors.Window
Me.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam
Me.txtPort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtPort.ForeColor = System.Drawing.SystemColors.WindowText
Me.txtPort.Location = New System.Drawing.Point(10, 87)
Me.txtPort.MaxLength = 0
Me.txtPort.Name = "txtPort"
Me.txtPort.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.txtPort.Size = New System.Drawing.Size(184, 23)
Me.txtPort.TabIndex = 18
Me.txtPort.Text = "2222"
'
'btnCancel
'
Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
Me.btnCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnCancel.Location = New System.Drawing.Point(106, 119)
Me.btnCancel.Name = "btnCancel"
Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnCancel.Size = New System.Drawing.Size(75, 25)
Me.btnCancel.TabIndex = 17
Me.btnCancel.Text = "Cancel"
'
'btnConnect
'
Me.btnConnect.BackColor = System.Drawing.SystemColors.Control
Me.btnConnect.Cursor = System.Windows.Forms.Cursors.Default
Me.btnConnect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnConnect.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnConnect.Location = New System.Drawing.Point(10, 119)
Me.btnConnect.Name = "btnConnect"
Me.btnConnect.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnConnect.Size = New System.Drawing.Size(75, 25)
Me.btnConnect.TabIndex = 16
Me.btnConnect.Text = "Connect"
'
'Label3
'
Me.Label3.BackColor = System.Drawing.SystemColors.Control
Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label3.Location = New System.Drawing.Point(10, 20)
Me.Label3.Name = "Label3"
Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label3.Size = New System.Drawing.Size(78, 21)
Me.Label3.TabIndex = 21
Me.Label3.Text = "IP address:"
'
'Label4
'
Me.Label4.BackColor = System.Drawing.SystemColors.Control
Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label4.Location = New System.Drawing.Point(10, 68)
Me.Label4.Name = "Label4"
Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label4.Size = New System.Drawing.Size(40, 21)
Me.Label4.TabIndex = 20
Me.Label4.Text = "Port:"
'
'Frame2
'
Me.Frame2.BackColor = System.Drawing.SystemColors.Control
Me.Frame2.Controls.Add(Me.txtAlertMsg)
Me.Frame2.Controls.Add(Me.btnAlert)
Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
Me.Frame2.Location = New System.Drawing.Point(20, 374)
Me.Frame2.Name = "Frame2"
Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Frame2.Size = New System.Drawing.Size(634, 50)
Me.Frame2.TabIndex = 10
Me.Frame2.TabStop = False
Me.Frame2.Text = " Alert  "
'
'txtAlertMsg
'
Me.txtAlertMsg.AcceptsReturn = True
Me.txtAlertMsg.AutoSize = False
Me.txtAlertMsg.BackColor = System.Drawing.SystemColors.Window
Me.txtAlertMsg.Cursor = System.Windows.Forms.Cursors.IBeam
Me.txtAlertMsg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtAlertMsg.ForeColor = System.Drawing.SystemColors.WindowText
Me.txtAlertMsg.Location = New System.Drawing.Point(10, 20)
Me.txtAlertMsg.MaxLength = 0
Me.txtAlertMsg.Name = "txtAlertMsg"
Me.txtAlertMsg.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.txtAlertMsg.Size = New System.Drawing.Size(519, 23)
Me.txtAlertMsg.TabIndex = 12
Me.txtAlertMsg.Text = ""
'
'btnAlert
'
Me.btnAlert.BackColor = System.Drawing.SystemColors.Control
Me.btnAlert.Cursor = System.Windows.Forms.Cursors.Default
Me.btnAlert.Enabled = False
Me.btnAlert.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnAlert.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnAlert.Location = New System.Drawing.Point(537, 18)
Me.btnAlert.Name = "btnAlert"
Me.btnAlert.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnAlert.Size = New System.Drawing.Size(75, 25)
Me.btnAlert.TabIndex = 11
Me.btnAlert.Text = "Send"
'
'btnSettings
'
Me.btnSettings.BackColor = System.Drawing.SystemColors.Control
Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Default
Me.btnSettings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnSettings.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnSettings.Location = New System.Drawing.Point(20, 451)
Me.btnSettings.Name = "btnSettings"
Me.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnSettings.Size = New System.Drawing.Size(75, 25)
Me.btnSettings.TabIndex = 9
Me.btnSettings.Text = "Settings"
'
'helper
'
Me.helper.BackColor = System.Drawing.SystemColors.Control
Me.helper.Cursor = System.Windows.Forms.Cursors.Default
Me.helper.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.helper.ForeColor = System.Drawing.SystemColors.ControlText
Me.helper.Location = New System.Drawing.Point(-159, 451)
Me.helper.Name = "helper"
Me.helper.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.helper.Size = New System.Drawing.Size(105, 21)
Me.helper.TabIndex = 8
Me.helper.Text = "Command1"
'
'btnExit
'
Me.btnExit.BackColor = System.Drawing.SystemColors.Control
Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnExit.Location = New System.Drawing.Point(211, 451)
Me.btnExit.Name = "btnExit"
Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnExit.Size = New System.Drawing.Size(75, 25)
Me.btnExit.TabIndex = 7
Me.btnExit.Text = "Exit"
'
'btnIP
'
Me.btnIP.BackColor = System.Drawing.SystemColors.Control
Me.btnIP.Cursor = System.Windows.Forms.Cursors.Default
Me.btnIP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnIP.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnIP.Location = New System.Drawing.Point(115, 451)
Me.btnIP.Name = "btnIP"
Me.btnIP.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnIP.Size = New System.Drawing.Size(75, 25)
Me.btnIP.TabIndex = 6
Me.btnIP.Text = "My IP ?"
'
'Frame3
'
Me.Frame3.BackColor = System.Drawing.SystemColors.Control
Me.Frame3.Controls.Add(Me.SockLib)
Me.Frame3.Controls.Add(Me.btnChat)
Me.Frame3.Controls.Add(Me.txtChatLog)
Me.Frame3.Controls.Add(Me.txtChatMsg)
Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
Me.Frame3.Location = New System.Drawing.Point(20, 173)
Me.Frame3.Name = "Frame3"
Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Frame3.Size = New System.Drawing.Size(634, 184)
Me.Frame3.TabIndex = 1
Me.Frame3.TabStop = False
Me.Frame3.Text = " Chat "
'
'SockLib
'
Me.SockLib.ContainingControl = Me
Me.SockLib.Location = New System.Drawing.Point(56, 40)
Me.SockLib.Name = "SockLib"
Me.SockLib.OcxState = CType(resources.GetObject("SockLib.OcxState"), System.Windows.Forms.AxHost.State)
Me.SockLib.Size = New System.Drawing.Size(305, 20)
Me.SockLib.TabIndex = 5
'
'btnChat
'
Me.btnChat.BackColor = System.Drawing.SystemColors.Control
Me.btnChat.Cursor = System.Windows.Forms.Cursors.Default
Me.btnChat.Enabled = False
Me.btnChat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnChat.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnChat.Location = New System.Drawing.Point(537, 152)
Me.btnChat.Name = "btnChat"
Me.btnChat.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnChat.Size = New System.Drawing.Size(75, 25)
Me.btnChat.TabIndex = 4
Me.btnChat.Text = "Send"
'
'txtChatLog
'
Me.txtChatLog.AcceptsReturn = True
Me.txtChatLog.AutoSize = False
Me.txtChatLog.BackColor = System.Drawing.SystemColors.Window
Me.txtChatLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.txtChatLog.CausesValidation = False
Me.txtChatLog.Cursor = System.Windows.Forms.Cursors.IBeam
Me.txtChatLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtChatLog.ForeColor = System.Drawing.SystemColors.WindowText
Me.txtChatLog.Location = New System.Drawing.Point(10, 20)
Me.txtChatLog.MaxLength = 0
Me.txtChatLog.Multiline = True
Me.txtChatLog.Name = "txtChatLog"
Me.txtChatLog.ReadOnly = True
Me.txtChatLog.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.txtChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
Me.txtChatLog.Size = New System.Drawing.Size(615, 126)
Me.txtChatLog.TabIndex = 3
Me.txtChatLog.Text = ""
Me.txtChatLog.WordWrap = False
'
'txtChatMsg
'
Me.txtChatMsg.AcceptsReturn = True
Me.txtChatMsg.AutoSize = False
Me.txtChatMsg.BackColor = System.Drawing.SystemColors.Window
Me.txtChatMsg.Cursor = System.Windows.Forms.Cursors.IBeam
Me.txtChatMsg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtChatMsg.ForeColor = System.Drawing.SystemColors.WindowText
Me.txtChatMsg.Location = New System.Drawing.Point(10, 154)
Me.txtChatMsg.MaxLength = 0
Me.txtChatMsg.Name = "txtChatMsg"
Me.txtChatMsg.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.txtChatMsg.Size = New System.Drawing.Size(519, 23)
Me.txtChatMsg.TabIndex = 2
Me.txtChatMsg.Text = ""
'
'Frame1
'
Me.Frame1.BackColor = System.Drawing.SystemColors.Control
Me.Frame1.Controls.Add(Me.lvPeers)
Me.Frame1.Controls.Add(Me.btnRemove)
Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
Me.Frame1.Location = New System.Drawing.Point(20, 10)
Me.Frame1.Name = "Frame1"
Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Frame1.Size = New System.Drawing.Size(423, 155)
Me.Frame1.TabIndex = 0
Me.Frame1.TabStop = False
Me.Frame1.Text = "Peers"
'
'lvPeers
'
Me.lvPeers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
Me.lvPeers.FullRowSelect = True
Me.lvPeers.HideSelection = False
Me.lvPeers.Location = New System.Drawing.Point(10, 22)
Me.lvPeers.MultiSelect = False
Me.lvPeers.Name = "lvPeers"
Me.lvPeers.Size = New System.Drawing.Size(400, 88)
Me.lvPeers.TabIndex = 6
Me.lvPeers.View = System.Windows.Forms.View.Details
'
'ColumnHeader1
'
Me.ColumnHeader1.Text = "IP Address"
Me.ColumnHeader1.Width = 99
'
'ColumnHeader2
'
Me.ColumnHeader2.Text = "Port"
Me.ColumnHeader2.Width = 99
'
'ColumnHeader3
'
Me.ColumnHeader3.Text = "State"
Me.ColumnHeader3.Width = 99
'
'btnRemove
'
Me.btnRemove.BackColor = System.Drawing.SystemColors.Control
Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Default
Me.btnRemove.Enabled = False
Me.btnRemove.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnRemove.Location = New System.Drawing.Point(10, 120)
Me.btnRemove.Name = "btnRemove"
Me.btnRemove.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnRemove.Size = New System.Drawing.Size(75, 25)
Me.btnRemove.TabIndex = 5
Me.btnRemove.Text = "Remove"
'
'StatusBar
'
Me.StatusBar.Location = New System.Drawing.Point(0, 497)
Me.StatusBar.Name = "StatusBar"
Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4})
Me.StatusBar.ShowPanels = True
Me.StatusBar.Size = New System.Drawing.Size(674, 22)
Me.StatusBar.TabIndex = 23
Me.StatusBar.Text = "StatusBar1"
'
'StatusBarPanel1
'
Me.StatusBarPanel1.Text = "StatusBarPanel1"
Me.StatusBarPanel1.Width = 150
'
'StatusBarPanel2
'
Me.StatusBarPanel2.Text = "StatusBarPanel2"
Me.StatusBarPanel2.Width = 150
'
'StatusBarPanel3
'
Me.StatusBarPanel3.Text = "StatusBarPanel3"
Me.StatusBarPanel3.Width = 150
'
'StatusBarPanel4
'
Me.StatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
Me.StatusBarPanel4.Text = "StatusBarPanel4"
Me.StatusBarPanel4.Width = 208
'
'CFrmMain
'
Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
Me.BackColor = System.Drawing.SystemColors.Control
Me.ClientSize = New System.Drawing.Size(674, 519)
Me.Controls.Add(Me.StatusBar)
Me.Controls.Add(Me.Frame4)
Me.Controls.Add(Me.Frame2)
Me.Controls.Add(Me.btnSettings)
Me.Controls.Add(Me.helper)
Me.Controls.Add(Me.btnExit)
Me.Controls.Add(Me.btnIP)
Me.Controls.Add(Me.Frame3)
Me.Controls.Add(Me.Frame1)
Me.Cursor = System.Windows.Forms.Cursors.Default
Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
Me.Location = New System.Drawing.Point(4, 28)
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "CFrmMain"
Me.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "BigSpeed Secure Socket Library - VB.NET Example"
Me.Frame4.ResumeLayout(False)
Me.Frame2.ResumeLayout(False)
Me.Frame3.ResumeLayout(False)
CType(Me.SockLib, System.ComponentModel.ISupportInitialize).EndInit()
Me.Frame1.ResumeLayout(False)
CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

  End Sub
#End Region



  'VB.NET example of chat and alert messaging

  Dim fSettings As CFrmSettings
  Dim CallHandle As Integer 'Handle to the calling socket

  Const pcALERT As Short = 10 'Alert message ID
  Const pcCHAT As Short = 20 'Chat message ID


  'Initializations
  Private Sub fMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    fSettings = New CFrmSettings     'create settings form
    CallHandle = 0
    SetProperties()
    UpdateStatus()
  End Sub



  'Terminate on form closing
  Private Sub fMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
    End
  End Sub




  'Set the component properties
  Private Sub SetProperties()
  If fSettings.txtKey.Text > "" Then
    SockLib.SecurityMode = 2  'shared secret key
    SockLib.SecretKey = fSettings.txtKey.Text
  Else
    SockLib.SecurityMode = 0  'no encryption
  End If

  SockLib.UseCompression = fSettings.chkCompress.Checked

  SockLib.StopListening()
  If fSettings.chkServer.Checked Then
    SockLib.StartListening(Val(fSettings.txtListenPort.Text))
  End If
  End Sub



  'An alert message is available
  Private Sub HaveAlert(ByVal aHandle As Integer)
    Dim Line As String

    Line = "From " & SockLib.GetRemoteAddress(aHandle) & " at " & VB6.Format(Now, "hh:mm:ss") & Chr(13) & Chr(13)
    Line = Line & SockLib.TextFromBuffer(aHandle)
    Call MsgBox(Line, MsgBoxStyle.SystemModal, "Alert")

  End Sub



  'A chat message is available
  Private Sub HaveChat(ByVal aHandle As Integer)
    Dim Line As String
    If txtChatLog.Text > "" Then
      Line = Chr(13) & Chr(10)
    End If
    Line = Line & "[" & VB6.Format(Now, "hh:mm:ss") & "] Peer: "
    Line = Line & SockLib.TextFromBuffer(aHandle)
    txtChatLog.SelectionStart = Len(txtChatLog.Text)
    txtChatLog.SelectedText = Line
  End Sub



  '*** Event handlers


  'A chat message will be sent
  Private Sub btnChat_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnChat.Click
    Dim Line As String

    Call SockLib.TextToBuffer(lvPeers.SelectedItems(0).Tag, txtChatMsg.Text) 'Store the message
    Call SockLib.SendPacket(lvPeers.SelectedItems(0).Tag, pcCHAT) 'Send the chat message
    Line = ""
    If txtChatLog.Text > "" Then
      Line = Chr(13) & Chr(10)
    End If
    Line = Line & "[" & VB6.Format(Now, "hh:mm:ss") & "] Me: " & txtChatMsg.Text
    txtChatMsg.Text = ""
    txtChatLog.Text = txtChatLog.Text & Line
  End Sub



  'An alert message will be sent
  Private Sub btnAlert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnAlert.Click
    Call SockLib.TextToBuffer(lvPeers.SelectedItems(0).Tag, txtAlertMsg.Text) 'Store the message
    Call SockLib.SendPacket(lvPeers.SelectedItems(0).Tag, pcALERT) 'Send an alert message
    txtAlertMsg.Text = ""
  End Sub




  'Modify the settings
  Private Sub btnSettings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSettings.Click

    If fSettings.ShowDialog <> DialogResult.OK Then Exit Sub

    SetProperties()
    UpdateStatus()
  End Sub



  'Show my IP address
  Private Sub btnIP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnIP.Click
    MsgBox(SockLib.LocalIP)
  End Sub


  'Terminate the application
  Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click
    End
  End Sub


  'Initiate a call
  Private Sub btnConnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnConnect.Click

  'create a new calling socket
  CallHandle = SockLib.CreateSession(txtIP.Text, Val(txtPort.Text))
  If CallHandle = 0 Then
    Call MsgBox("Cannot initiate a call", MsgBoxStyle.SystemModal, "Error")
    CallHandle = 0
  End If

  UpdateStatus()
  End Sub


  'Cancel a call operation
  Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
  If CallHandle > 0 Then
    SockLib.TerminateSession(CallHandle)
    CallHandle = 0
    UpdateStatus()
  End If
  End Sub



  'Remove a socket
  Private Sub btnRemove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnRemove.Click
  If lvPeers.SelectedItems.Count = 0 Then
    Exit Sub
  End If
  SockLib.TerminateSession(lvPeers.SelectedItems(0).Tag)
  lvPeers.Items.Remove(lvPeers.SelectedItems(0))
  End Sub



  Private Sub lvPeers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPeers.SelectedIndexChanged
    UpdateStatus()
  End Sub



  'Hide the focus from the chat box
  Private Sub txtChatLog_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChatLog.GotFocus
    helper.Focus()
  End Sub



  'A new socket socket is created due to an incoming call
  Private Sub SockLib_OnSessionInvoked(ByVal sender As Object, ByVal e As AxbsSocketLibrary.IBSSockLibXEvents_OnSessionInvokedEvent) Handles SockLib.OnSessionInvoked
    Dim LI As ListViewItem
    Dim S As String
    S = SockLib.GetRemoteAddress(e.aHandle)
    LI = lvPeers.Items.Add(S)                              'IP
    LI.SubItems.Add(SockLib.GetRemotePort(e.aHandle))      'port
    LI.SubItems.Add(VB6.Format(Now, "hh:mm:ss"))           'time
    LI.Tag = e.aHandle

    UpdateStatus()
  End Sub



  'Successful call
  Private Sub SockLib_OnSessionCreated(ByVal sender As Object, ByVal e As AxbsSocketLibrary.IBSSockLibXEvents_OnSessionCreatedEvent) Handles SockLib.OnSessionCreated
    Dim LI As ListViewItem

    LI = lvPeers.Items.Add(txtIP.Text)                 'IP
    LI.SubItems.Add(txtPort.Text)                      'Port
    LI.SubItems.Add(VB6.Format(Now, "hh:mm:ss"))       'time
    LI.Tag = CallHandle
    CallHandle = 0

    If lvPeers.SelectedItems.Count = 0 Then
      LI.Selected = True
    End If

    UpdateStatus()
  End Sub



  'Unsuccessful call
  Private Sub SockLib_OnSessionRejected(ByVal sender As Object, ByVal e As AxbsSocketLibrary.IBSSockLibXEvents_OnSessionRejectedEvent) Handles SockLib.OnSessionRejected
    CallHandle = 0
    UpdateStatus()
    MsgBox("Cannot connect to " & txtIP.Text & ":" & txtPort.Text)
  End Sub




  'The socket is disconnected
  Private Sub SockLib_OnSessionClosed(ByVal sender As Object, ByVal e As AxbsSocketLibrary.IBSSockLibXEvents_OnSessionClosedEvent) Handles SockLib.OnSessionClosed
  Dim i As Long
  For i = 0 To lvPeers.Items.Count - 1
    If lvPeers.Items.Item(i).Tag = e.aHandle Then
      lvPeers.Items.RemoveAt(i)
    End If
  Next i
  UpdateStatus()
  End Sub



  'A new packet is available
  Private Sub SockLib_OnPacketReceived(ByVal eventSender As System.Object, ByVal eventArgs As AxbsSocketLibrary.IBSSockLibXEvents_OnPacketReceivedEvent) Handles SockLib.OnPacketReceived
    Select Case SockLib.GetRcvdCmnd(eventArgs.aHandle)
      Case pcALERT
        Call HaveAlert(eventArgs.aHandle) 'alert message
      Case pcCHAT
        Call HaveChat(eventArgs.aHandle)  'chat message
    End Select
  End Sub








  'Update the buttons state and the status text
  Private Sub UpdateStatus()
    Dim St As String
    Dim LI As ListViewItem
    Dim i, Sk, ConCnt As Integer

    'Buttons

    If CallHandle > 0 Then
      'a call is in progress
      btnConnect.Enabled = False
      btnCancel.Enabled = True
    Else
      'a new call can be initiated
      btnConnect.Enabled = True
      btnCancel.Enabled = False
    End If

    If lvPeers.SelectedItems.Count = 0 Then
      btnRemove.Enabled = False
      btnChat.Enabled = False
      btnAlert.Enabled = False
    Else
      btnRemove.Enabled = True
      btnChat.Enabled = True
      btnAlert.Enabled = True
    End If


    'Status bar

    If fSettings.txtKey.Text > "" Then
      StatusBar.Panels.Item(0).Text = "Encryption: ON"
    Else
      StatusBar.Panels.Item(0).Text = "Encryption: OFF"
    End If

    If fSettings.chkCompress.CheckState = 1 Then
      StatusBar.Panels.Item(1).Text = "Compression: ON"
    Else
      StatusBar.Panels.Item(1).Text = "Compression: OFF"
    End If

    If fSettings.chkServer.CheckState = 1 Then
      StatusBar.Panels.Item(2).Text = "Server: ON"
    Else
      StatusBar.Panels.Item(2).Text = "Server: OFF"
    End If

    If lvPeers.Items.Count = 0 Then
      St = "No active connection"
    Else
      St = Str(lvPeers.Items.Count) & " connected peer(s)"
    End If
    StatusBar.Panels.Item(3).Text = St



  End Sub






End Class